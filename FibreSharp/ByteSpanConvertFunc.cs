namespace FibreSharp;

public delegate T ByteSpanConvertFunc<out T>(ReadOnlySpan<byte> span);