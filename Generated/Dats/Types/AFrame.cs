namespace ACBindings;

// AFrame
public unsafe struct AFrame
{
    // Child Types
    // AFrame::FrameInitializationEnum
    public enum FrameInitializationEnum : byte
    {
        FRAME_NO_INITIALIZATION = 0x0
    }

    // Members
    public ACBindings.AC1Legacy.Vector3 m_fOrigin;
    public float qw;
    public float qx;
    public float qy;
    public float qz;

    // Generated Constructor
    public AFrame() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall AFrame::AFrame(AFrame*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AFrame, void>)0x00520180)(ref this);
    // int __thiscall AFrame::IsValid(AFrame*)
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AFrame, int>)0x005AAEE0)(ref this);
    // unsigned int __thiscall AFrame::Pack(AFrame*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AFrame, void**, uint, uint>)0x005AAFF0)(ref this, addr, size);
    // int __thiscall AFrame::UnPack(AFrame*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AFrame, void**, uint, int>)0x005AB060)(ref this, addr, size);
}

