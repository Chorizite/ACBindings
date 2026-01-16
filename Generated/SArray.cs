namespace ACBindings.Internal;


/// <summary>Represents a contiguous array of pointers to CPhysicsObj, storing both data and element count for efficient iteration in physics simulation.</summary>
public unsafe struct SArray___CPhysicsObj_ptr
{
    // Members
    public ACBindings.Internal.CPhysicsObj** data;
    public ushort sizeOf;

    // Methods
}


/// <summary>Represents an array of Frame objects, storing a pointer to the data and its element count for efficient access and management within the system.</summary>
public unsafe struct SArray___Frame
{
    // Members
    public ACBindings.Internal.Frame* data;
    public ushort sizeOf;

    // Methods

    /// <summary>Ensures the Frame array contains at least the specified number of elements by reallocating and copying existing items; if the requested size is smaller, reduces the array via shrink.
    /// <code>Offset: 0x0051BBF0
    /// void __thiscall SArray&lt;Frame&gt;::grow(_WORD*,int)</code>
    /// </summary>
    /// <param name="a2">The desired capacity for the array after growth.</param>
    // void __thiscall SArray<Frame>::grow(_WORD*,int) (template type method)

    /// <summary>Resizes the Frame array to the specified count, reallocating storage and copying existing entries when reducing or keeping the same size; if the requested size exceeds the current capacity, delegates to grow().
    /// <code>Offset: 0x0051BC80
    /// void __thiscall SArray&lt;Frame&gt;::shrink(_WORD*,int)</code>
    /// </summary>
    /// <param name="a2">The target number of Frame elements.</param>
    // void __thiscall SArray<Frame>::shrink(_WORD*,int) (template type method)
}


/// <summary>Encapsulates a variable-length collection of 32‑bit unsigned integers, maintaining a pointer to the elements and a 16‑bit size field. The structure is aligned on a 4‑byte boundary for efficient memory access.</summary>
public unsafe struct SArray__uint
{
    // Members
    public uint* data;
    public ushort sizeOf;

    // Methods
}

