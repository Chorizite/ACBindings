namespace ACBindings;

// AttackCone
public unsafe struct AttackCone : System.IDisposable
{
    // Members
    public int part_index;
    public ACBindings.Vec2D left;
    public ACBindings.Vec2D right;
    public float radius;
    public float height;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall AttackCone::~AttackCone(AttackCone*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackCone, void>)0x005273B0)(ref this);
    // unsigned int __thiscall AttackCone::Pack(AttackCone*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackCone, void**, uint, uint>)0x00527BF0)(ref this, addr, size);
    // int __thiscall AttackCone::UnPack(AttackCone*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackCone, void**, uint, int>)0x00527C60)(ref this, addr, size);
}

