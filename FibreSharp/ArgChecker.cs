using System.Runtime.CompilerServices;

namespace FibreSharp;

public static class ArgChecker
{
    public static void Range<T>(
        T val,
        T lowerBoundInclusive,
        T upperBoundInclusive,
        [CallerArgumentExpression("val")] string argExpression = "(not provided)")
        where T: IComparable<T>
    {
        if (val.CompareTo(lowerBoundInclusive) < 0 || val.CompareTo(upperBoundInclusive) > 0)
        {
            throw new ArgumentOutOfRangeException(
                argExpression,
                val,
                $"{argExpression} must be between {lowerBoundInclusive} and {upperBoundInclusive}, inclusive");
        }
    }

    public static void NotNull<T>(
        ArraySegment<T> val,
        [CallerArgumentExpression("val")] string argExpression = "(not provided)")
    {
        if (val.Array is null)
        {
            throw new ArgumentNullException(argExpression);
        }
    }
    
    public static void NotNull<T>(
        T val,
        [CallerArgumentExpression("val")] string argExpression = "(not provided)")
    {
        if (val is null)
        {
            throw new ArgumentNullException(argExpression);
        }
    }
}