using System.Collections.Immutable;
using System.Diagnostics;

namespace FibreSharp.YamlManifestParser;

public sealed class QualifiedName : IEquatable<QualifiedName>
{
    public static readonly QualifiedName Root = new QualifiedName();
    private QualifiedName(ImmutableList<string> segments, bool checkedSegments)
    {
        Debug.Assert(checkedSegments);
        Segments = segments;
    }

    public QualifiedName(params string[] segments)
        :this((IEnumerable<string>)segments)
    {
    }

    public QualifiedName(IEnumerable<string> segments)
        :this(segments.ToImmutableList(), true)
    {
        foreach (var segment in Segments)
        {
            CheckValidSegment(segment);
        }
    }

    public QualifiedName Parent => Segments.IsEmpty
        ? Root
        : new QualifiedName(Segments.RemoveAt(Segments.Count - 1), checkedSegments: true);
    public IEnumerable<QualifiedName> EnumerateSelfAndAncestors()
    {
        var node = this;
        while (node != Root)
        {
            yield return node;
            node = node.Parent;
        }

        yield return Root;
    }

    private static void CheckValidSegment(string segment)
    {
        if (string.IsNullOrWhiteSpace(segment)) throw new ArgumentException("segment cannot be null or whitespace");
        if (segment.Contains('.'))
        {
            throw new ArgumentException("segment cannot contain . characters");
        }
    }

    public ImmutableList<string> Segments { get; }
    public string Leaf => Segments.Count > 0 ? Segments[^1] : throw new InvalidOperationException("Root has no leaf name");

    public override string ToString()
    {
        return string.Join('.', Segments);
    }

    public static QualifiedName Parse(string str)
    {
        return new QualifiedName(
            str.Split('.', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .ToImmutableList());
    }

    public static QualifiedName operator /(QualifiedName left, string right)
    {
        CheckValidSegment(right);
        return new QualifiedName(left.Segments.Add(right), checkedSegments: true);
    }
    public static QualifiedName operator /(QualifiedName left, QualifiedName right)
    {
        return new QualifiedName(left.Segments.AddRange(right.Segments), checkedSegments: true);
    }

    public bool Equals(QualifiedName? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Segments.SequenceEqual(other.Segments, StringComparer.Ordinal);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is QualifiedName other && Equals(other);
    }

    public override int GetHashCode()
    {
        HashCode hc = new();
        foreach (var segment in Segments)
        {
            hc.Add(segment, StringComparer.Ordinal);
        }
        return hc.ToHashCode();
    }

    public static bool operator ==(QualifiedName? left, QualifiedName? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(QualifiedName? left, QualifiedName? right)
    {
        return !Equals(left, right);
    }
}