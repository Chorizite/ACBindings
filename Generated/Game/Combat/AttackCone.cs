namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x005273B0
    /// void __thiscall AttackCone::~AttackCone(AttackCone*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackCone, void>)0x005273B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527BF0
    /// unsigned int __thiscall AttackCone::Pack(AttackCone*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackCone, void**, uint, uint>)0x00527BF0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00527C60
    /// int __thiscall AttackCone::UnPack(AttackCone*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackCone, void**, uint, int>)0x00527C60)(ref this, addr, size);
}

