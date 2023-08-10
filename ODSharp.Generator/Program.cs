using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using System.Text.Json;
using FibreSharp.LegacyManifestParser;
using FibreSharp.YamlManifestParser;
using ODSharp.GeneratorCore;

var m = new YamlFibreManifestParser().Parse(File.OpenText(@"c:\Users\elect\Downloads\odrive-interface.yaml"));

var manifestFileOption = new Option<FileInfo>("--manifest")
    .ExistingOnly();
manifestFileOption.IsRequired = true;

var enumsOption = new Option<FileInfo>("--enums")
    .ExistingOnly();
manifestFileOption.IsRequired = true;

var outFileOption = new Option<FileInfo>("--outFile")
    .LegalFilePathsOnly();
outFileOption.IsRequired = true;


var rootCommand = new RootCommand("generate C# code to represent the ODrive endpoint tree")
{
    manifestFileOption,
    outFileOption,
    enumsOption,
};
var commandLineBuilder = new CommandLineBuilder(rootCommand).UseDefaults();
var parser = commandLineBuilder.Build();


rootCommand.SetHandler(
    (manifestFile, outFile, enumsFile) =>
    {
        Console.WriteLine($"Manifest file: {manifestFile.FullName}");
        Console.WriteLine($"Enums file: {enumsFile.FullName}");
        Console.WriteLine($"Output file: {outFile.FullName}");

        Directory.CreateDirectory(outFile.DirectoryName!);

        var rootObject = LegacyFibreManifestParser.Parse(File.ReadAllBytes(manifestFile.FullName));
        var enums = JsonSerializer.Deserialize<IReadOnlyDictionary<string, EnumInfo>>(
            File.ReadAllBytes(enumsFile.FullName),
            new JsonSerializerOptions{PropertyNamingPolicy = JsonNamingPolicy.CamelCase})!;

        var syntaxTree = GenerateAll.Generate(rootObject, enums);
        File.WriteAllText(outFile.FullName, syntaxTree.GetText().ToString());
    },
    manifestFileOption,
    outFileOption,
    enumsOption);

await parser.InvokeAsync(args);