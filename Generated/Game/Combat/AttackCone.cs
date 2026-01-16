namespace ACBindings.Internal;


/// <summary>Represents an attack area defined by a part index, two boundary direction vectors (left and right), a radius and a height; it is used for collision detection, spell targeting, and serialization to/from binary buffers.</summary>
public unsafe struct AttackCone : System.IDisposable
{
    // Members
    public int part_index;
    public ACBindings.Internal.Vec2D left;
    public ACBindings.Internal.Vec2D right;
    public float radius;
    public float height;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Notifies the system that an attack cone has been removed by sending its left and right directional vectors to the notice handler, enabling cleanup of any related spell selections.
    /// <code>Offset: 0x005273B0
    /// void __thiscall AttackCone::~AttackCone(AttackCone*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackCone, void>)0x005273B0)(ref this);

    /// <summary>Serializes an AttackCone into a binary buffer, writing its fields sequentially if the supplied buffer has sufficient space.
    /// <code>Offset: 0x00527BF0
    /// unsigned int __thiscall AttackCone::Pack(AttackCone*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the buffer; updated to point after the packed data when serialization occurs.</param>
    /// <param name="size">Number of bytes available from *addr onward for packing.</param>
    /// <returns>The total number of bytes required to pack an AttackCone. If size is less than this value, no data is written and only the required size is returned.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackCone, void**, uint, uint>)0x00527BF0)(ref this, addr, size);

    /// <summary>Unpacks an AttackCone instance from a binary buffer, restoring part index, left/right vectors, radius and height.
    /// <code>Offset: 0x00527C60
    /// int __thiscall AttackCone::UnPack(AttackCone*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position in the buffer; advanced past unpacked data.</param>
    /// <param name="size">Size of remaining data in the buffer (unused directly).</param>
    /// <returns>1 on success.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackCone, void**, uint, int>)0x00527C60)(ref this, addr, size);
}

