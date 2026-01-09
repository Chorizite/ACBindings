namespace ACBindings;

// HAR
public unsafe struct HAR : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // HAR_vtbl
    public unsafe struct HAR_vtbl
    {
        // Members
        public System.IntPtr HAR_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _bitmask;
    public uint _monarch_iid;
    public ACBindings.PackableHashTable__uint__GuestInfo _guest_table;
    public ACBindings.PList__uint _roommate_list;

    // Generated Constructor
    public HAR() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall HAR::Pack(HAR*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HAR, void**, uint, uint>)0x005B00E0)(ref this, addr, size);
    // int __thiscall HAR::Dump(_DWORD*,int,int)
    public int Dump(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HAR, int, int, int>)0x005B06F0)(ref this, a2, a3);
    // int __thiscall HAR::UnPack(HAR*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HAR, void**, uint, int>)0x005B0A70)(ref this, addr, size);
    // void __thiscall HAR::HAR(HAR*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HAR, void>)0x005B0DF0)(ref this);
    // void __thiscall HAR::~HAR(HAR*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HAR, void>)0x005B0E60)(ref this);
}

