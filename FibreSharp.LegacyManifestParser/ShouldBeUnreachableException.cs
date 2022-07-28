namespace FibreSharp.LegacyManifestParser;

internal class ShouldBeUnreachableException : Exception
{
    public ShouldBeUnreachableException() : base("Reached a code location that should be unreachable")
    {
    }
}