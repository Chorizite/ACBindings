namespace ACBindings;

// Vec2D
public unsafe struct Vec2D
{
    // Members
    public float x;
    public float y;

    // Methods
    // unsigned int __thiscall Vec2D::Pack(Vec2D*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Vec2D, void**, uint, uint>)0x005AAE80)(ref this, addr, size);
    // int __thiscall Vec2D::UnPack(Vec2D*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Vec2D, void**, uint, int>)0x005AAEB0)(ref this, addr, size);
}

