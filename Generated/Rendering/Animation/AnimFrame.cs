namespace ACBindings;

// AnimFrame
public unsafe struct AnimFrame
{
    // Members
    public ACBindings.AFrame* frame;
    public uint num_frame_hooks;
    public ACBindings.CAnimHook* hooks;
    public uint num_parts;

    // Methods
    // unsigned int __thiscall AnimFrame::pack_size(AnimFrame*,unsigned int)
    public uint pack_size(uint num_parts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimFrame, uint, uint>)0x00520150)(ref this, num_parts);
    // void __thiscall AnimFrame::Destroy(AnimFrame*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimFrame, void>)0x005202F0)(ref this);
    // unsigned int __thiscall AnimFrame::Pack(AnimFrame*,unsigned int,void**,unsigned int)
    public uint Pack(uint num_parts, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimFrame, uint, void**, uint, uint>)0x00520340)(ref this, num_parts, addr, size);
    // int __thiscall AnimFrame::UnPack(AnimFrame*,unsigned int,void**,unsigned int)
    public int UnPack(uint num_parts, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimFrame, uint, void**, uint, int>)0x005203F0)(ref this, num_parts, addr, size);
}

