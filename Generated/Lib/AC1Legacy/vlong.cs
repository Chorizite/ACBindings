namespace ACBindings.Internal.AC1Legacy;


/// <summary>Encapsulates a legacy 64‑bit signed integer value, separating its numeric data and sign flag to maintain backward compatibility within the AC1Legacy system.</summary>
public unsafe struct vlong : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types

    /// <summary>Defines the virtual method table for AC1Legacy::vlong, exposing destructor and serialization-related operations.</summary>
    public unsafe struct vlong_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Legacy.vlong*, void> AC1Legacy; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Legacy.vlong*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Legacy.vlong*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Legacy.vlong*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.vlong_value* value;
    public int negative;

    // Generated Constructor
    public vlong(uint x) {
        _ConstructorInternal(x);
    }
    public vlong(ACBindings.Internal.AC1Legacy.vlong* x) {
        _ConstructorInternal(x);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Copies the internal unsigned integer representation of a vlong into an array.
    /// <code>Offset: 0x005B1740
    /// void __thiscall AC1Legacy::vlong::store(AC1Legacy::vlong*,unsigned int*,unsigned int)</code>
    /// </summary>
    /// <param name="a">Destination array for the stored values.</param>
    /// <param name="n">Maximum number of elements to copy. If the vlong holds fewer, remaining entries are zeroed.</param>
    public void store(uint* a, uint n) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, uint*, uint, void>)0x005B1740)(ref this, a, n);

    /// <summary>Copies the underlying value of a vlong, allocating a new instance when the current value is shared.
    /// <code>Offset: 0x005B1770
    /// void __thiscall AC1Legacy::vlong::docopy(AC1Legacy::vlong*)</code>
    /// </summary>
    public void docopy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, void>)0x005B1770)(ref this);

    /// <summary>Returns whether the bit at position i in this vlong is set.
    /// <code>Offset: 0x005B17B0
    /// unsigned int __thiscall AC1Legacy::vlong::bit(AC1Legacy::vlong*,unsigned int)</code>
    /// </summary>
    /// <param name="i">Zero-based index of the bit to test.</param>
    /// <returns>Non-zero if the specified bit is 1; zero otherwise.</returns>
    public uint bit(uint i) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, uint, uint>)0x005B17B0)(ref this, i);

    /// <summary>Sets the specified bit in the vlong's internal representation, performing a copy‑on‑write if the value is shared.
    /// <code>Offset: 0x005B17F0
    /// void __thiscall AC1Legacy::vlong::setbit(AC1Legacy::vlong*,unsigned int)</code>
    /// </summary>
    /// <param name="i">Zero‑based index of the bit to set.</param>
    public void setbit(uint i) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, uint, void>)0x005B17F0)(ref this, i);

    /// <summary>Computes the byte size required to serialize a vlong instance.
    /// <code>Offset: 0x005B1880
    /// unsigned int __thiscall AC1Legacy::vlong::GetPackSize(AC1Legacy::vlong*)</code>
    /// </summary>
    /// <returns>The total number of bytes needed, calculated as four times the element count plus an additional word.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, uint>)0x005B1880)(ref this);

    /// <summary>Loads an array of unsigned integers into the AC1Legacy::vlong instance, handling reference counting and copying when necessary.
    /// <code>Offset: 0x005B1890
    /// void __thiscall AC1Legacy::vlong::load(AC1Legacy::vlong*,unsigned int*,unsigned int)</code>
    /// </summary>
    /// <param name="a">Pointer to the source array of values.</param>
    /// <param name="n">Number of elements in the array.</param>
    public void load(uint* a, uint n) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, uint*, uint, void>)0x005B1890)(ref this, a, n);

    /// <summary>Create an AC1Legacy::vlong object, allocating internal storage for its value and initializing it with the supplied unsigned integer.
    /// <code>Offset: 0x005B1900
    /// void __thiscall AC1Legacy::vlong::vlong(AC1Legacy::vlong*,unsigned int)</code>
    /// </summary>
    /// <param name="x">The initial value assigned to the vlong instance.</param>
    public void _ConstructorInternal(uint x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, uint, void>)0x005B1900)(ref this, x);

    /// <summary>Creates a new AC1Legacy::vlong instance by copying the supplied vlong, sharing its underlying value and updating reference counts.
    /// <code>Offset: 0x005B1950
    /// void __thiscall AC1Legacy::vlong::vlong(AC1Legacy::vlong*,const AC1Legacy::vlong*)</code>
    /// </summary>
    /// <param name="x">Source vlong whose value and sign are copied into this object.</param>
    public void _ConstructorInternal(ACBindings.Internal.AC1Legacy.vlong* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, ACBindings.Internal.AC1Legacy.vlong*, void>)0x005B1950)(ref this, x);

    /// <summary>Destructs a vlong object, decreasing its share count and freeing the owned value when it is the last reference; restores the base class vtable to PackObj.
    /// <code>Offset: 0x005B19D0
    /// void __thiscall AC1Legacy::vlong::~vlong(AC1Legacy::vlong*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, void>)0x005B19D0)(ref this);

    /// <summary>Parses a hexadecimal string and assigns its numeric value to the calling vlong instance.
    /// <code>Offset: 0x005B1BC0
    /// int __thiscall AC1Legacy::vlong::read_from_hex_string(AC1Legacy::vlong*,const char*)</code>
    /// </summary>
    /// <param name="str">Null‑terminated sequence of hex digits representing the number.</param>
    /// <returns>Always 1, indicating successful parsing.</returns>
    public int read_from_hex_string(sbyte* str) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, sbyte*, int>)0x005B1BC0)(ref this, str);

    /// <summary>Serializes an AC1Legacy::vlong instance into a byte stream, writing its element count followed by each stored value when the supplied buffer has enough space.
    /// <code>Offset: 0x005B1F20
    /// unsigned int __thiscall AC1Legacy::vlong::Pack(AC1Legacy::vlong*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the buffer; updated to point after the written data.</param>
    /// <param name="size">Number of bytes available in the buffer for packing.</param>
    /// <returns>The number of bytes required to pack the object, even if it was not written due to insufficient space.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, void**, uint, uint>)0x005B1F20)(ref this, addr, size);

    /// <summary>Unpacks a variable-length integer sequence from the supplied buffer into this vlong instance. The function reads an initial count, validates that enough data remains, loads the integers, and advances the address pointer.
    /// <code>Offset: 0x005B1F70
    /// int __thiscall AC1Legacy::vlong::UnPack(AC1Legacy::vlong*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the buffer; updated to point after the unpacked data upon success.</param>
    /// <param name="size">Number of bytes remaining in the buffer from the provided address.</param>
    /// <returns>1 if unpacking succeeds, 0 otherwise (e.g., insufficient size).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, void**, uint, int>)0x005B1F70)(ref this, addr, size);
}

