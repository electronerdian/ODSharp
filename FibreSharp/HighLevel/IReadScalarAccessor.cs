namespace FibreSharp.HighLevel;

public interface IReadScalarAccessor<T> : IScalarAccessor
{
    T Value { get; }
    Task<T> GetAsync();
}