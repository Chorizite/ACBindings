namespace ACBindings;

// WTimeStamper
public unsafe struct WTimeStamper : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // WTimeStamper_vtbl
    public unsafe struct WTimeStamper_vtbl
    {
        // Members
        public System.IntPtr WTimeStamper_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PHashTable__uint__byte _table;
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
    // int __thiscall WTimeStamper::UpdateHouseRestrictionTS(WTimeStamper*,unsigned __int8)
    public int UpdateHouseRestrictionTS(byte ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WTimeStamper, byte, int>)0x006B3860)(ref this, ts);
    // unsigned int __thiscall WTimeStamper::GetPackSize(WTimeStamper*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.WTimeStamper, uint>)0x006B38A0)(ref this);
    // unsigned int __thiscall WTimeStamper::Pack(WTimeStamper*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WTimeStamper, void**, uint, uint>)0x006B38E0)(ref this, addr, size);
    // int __thiscall WTimeStamper::UnPack(WTimeStamper*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WTimeStamper, void**, uint, int>)0x006B3920)(ref this, addr, size);
    // void __thiscall WTimeStamper::~WTimeStamper(WTimeStamper*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.WTimeStamper, void>)0x006B3B90)(ref this);
    // void __thiscall WTimeStamper::WTimeStamper(WTimeStamper*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.WTimeStamper, void>)0x006B3C10)(ref this);
    // int __thiscall WTimeStamper::UpdateTS(WTimeStamper*,unsigned int,unsigned __int8)
    public int UpdateTS(uint key, byte new_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WTimeStamper, uint, byte, int>)0x006B3CB0)(ref this, key, new_ts);
}

