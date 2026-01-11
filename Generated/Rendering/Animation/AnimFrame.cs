namespace ACBindings.Internal;

public unsafe struct AnimFrame
{
    // Members
    public ACBindings.Internal.AFrame* frame;
    public uint num_frame_hooks;
    public ACBindings.Internal.CAnimHook* hooks;
    public uint num_parts;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00520150
    /// unsigned int __thiscall AnimFrame::pack_size(AnimFrame*,unsigned int)</code>
    /// </summary>
    public uint pack_size(uint num_parts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimFrame, uint, uint>)0x00520150)(ref this, num_parts);

    /// <summary>
    /// <code>Offset: 0x005202F0
    /// void __thiscall AnimFrame::Destroy(AnimFrame*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimFrame, void>)0x005202F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00520340
    /// unsigned int __thiscall AnimFrame::Pack(AnimFrame*,unsigned int,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(uint num_parts, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimFrame, uint, void**, uint, uint>)0x00520340)(ref this, num_parts, addr, size);

    /// <summary>
    /// <code>Offset: 0x005203F0
    /// int __thiscall AnimFrame::UnPack(AnimFrame*,unsigned int,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(uint num_parts, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimFrame, uint, void**, uint, int>)0x005203F0)(ref this, num_parts, addr, size);
}

