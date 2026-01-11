namespace ACBindings.Internal;

public unsafe struct Vec2D
{
    // Members
    public float x;
    public float y;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005AAE80
    /// unsigned int __thiscall Vec2D::Pack(Vec2D*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Vec2D, void**, uint, uint>)0x005AAE80)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AAEB0
    /// int __thiscall Vec2D::UnPack(Vec2D*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Vec2D, void**, uint, int>)0x005AAEB0)(ref this, addr, size);
}

