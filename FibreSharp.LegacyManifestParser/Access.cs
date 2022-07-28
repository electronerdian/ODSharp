namespace FibreSharp.LegacyManifestParser;

[Flags]
public enum Access
{
    Read = 1 << 1,
    Write = 1 << 2,
}