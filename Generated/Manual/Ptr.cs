namespace ACBindings;

public readonly unsafe struct Ptr<T> where T : unmanaged
{
    public readonly T* Value;

    public Ptr(T* ptr) => Value = ptr;
    public Ptr(ref T value) => Value = (T*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value);

    // Very useful implicit conversions
    public static implicit operator T*(Ptr<T> p)    => p.Value;
    public static implicit operator Ptr<T>(T* p)    => new Ptr<T>(p);
    public static implicit operator nint(Ptr<T> p)  => (nint)p.Value;

    // For debugging / logging
    public override string ToString() => $"Ptr<{typeof(T).Name}>: {(nint)Value:X16}";

    // Optional: equality (very useful for HashSet)
    public override bool Equals(object? obj)
        => obj is Ptr<T> other && Value == other.Value;

    public override int GetHashCode() => (int)((int)Value ^ 0xCAFEBABE); // simple but collision resistant enough

    public bool Equals(Ptr<T> other) => Value == other.Value;
}