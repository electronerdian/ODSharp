namespace FibreSharp;

public class SequenceCounter
{
    private uint last = 0;

    public ushort Next()
    {
        return (ushort)(Interlocked.Increment(ref last) & 0x7FFF);
    }
}