namespace ACBindings.Internal;

public unsafe struct WTimeStamper : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct WTimeStamper_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WTimeStamper*, void> WTimeStamper_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WTimeStamper*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WTimeStamper*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WTimeStamper*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PHashTable__uint__byte _table;
    public byte _house_ts;

    // Generated Constructor
    public WTimeStamper() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x006B3860
    /// int __thiscall WTimeStamper::UpdateHouseRestrictionTS(WTimeStamper*,unsigned __int8)</code>
    /// </summary>
    public int UpdateHouseRestrictionTS(byte ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, byte, int>)0x006B3860)(ref this, ts);

    /// <summary>
    /// <code>Offset: 0x006B38A0
    /// unsigned int __thiscall WTimeStamper::GetPackSize(WTimeStamper*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, uint>)0x006B38A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B38E0
    /// unsigned int __thiscall WTimeStamper::Pack(WTimeStamper*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, void**, uint, uint>)0x006B38E0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B3920
    /// int __thiscall WTimeStamper::UnPack(WTimeStamper*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, void**, uint, int>)0x006B3920)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B3B90
    /// void __thiscall WTimeStamper::~WTimeStamper(WTimeStamper*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, void>)0x006B3B90)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B3C10
    /// void __thiscall WTimeStamper::WTimeStamper(WTimeStamper*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, void>)0x006B3C10)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B3CB0
    /// int __thiscall WTimeStamper::UpdateTS(WTimeStamper*,unsigned int,unsigned __int8)</code>
    /// </summary>
    public int UpdateTS(uint key, byte new_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, uint, byte, int>)0x006B3CB0)(ref this, key, new_ts);
}

