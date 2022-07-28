namespace FibreSharp.HighLevel;

public interface IReadWriteScalarAccessor<T> : IReadScalarAccessor<T>, IWriteScalarAccessor<T>, IScalarAccessor
{
    new T Value { get; set; }
}