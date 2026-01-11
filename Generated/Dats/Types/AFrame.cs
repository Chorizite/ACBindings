namespace ACBindings.Internal;

public unsafe struct AFrame
{
    // Child Types
    // AFrame::FrameInitializationEnum
    public enum FrameInitializationEnum : byte
    {
        FRAME_NO_INITIALIZATION = 0x0
    }

    // Members
    public ACBindings.Internal.AC1Legacy.Vector3 m_fOrigin;
    public float qw;
    public float qx;
    public float qy;
    public float qz;

    // Generated Constructor
    public AFrame() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00520180
    /// void __thiscall AFrame::AFrame(AFrame*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AFrame, void>)0x00520180)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AAEE0
    /// int __thiscall AFrame::IsValid(AFrame*)</code>
    /// </summary>
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AFrame, int>)0x005AAEE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AAFF0
    /// unsigned int __thiscall AFrame::Pack(AFrame*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AFrame, void**, uint, uint>)0x005AAFF0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AB060
    /// int __thiscall AFrame::UnPack(AFrame*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AFrame, void**, uint, int>)0x005AB060)(ref this, addr, size);
}

