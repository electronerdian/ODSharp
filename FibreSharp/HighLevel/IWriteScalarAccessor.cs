namespace FibreSharp.HighLevel;

public interface IWriteScalarAccessor<T> : IScalarAccessor
{
    T Value { set; }
    Task SetAsync(T value);
}