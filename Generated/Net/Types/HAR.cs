namespace ACBindings.Internal;

public unsafe struct HAR : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct HAR_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HAR*, void> HAR_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HAR*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HAR*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HAR*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _bitmask;
    public uint _monarch_iid;
    public ACBindings.Internal.PackableHashTable__uint___GuestInfo _guest_table;
    public ACBindings.Internal.PList__uint _roommate_list;

    // Generated Constructor
    public HAR() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005B00E0
    /// unsigned int __thiscall HAR::Pack(HAR*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HAR, void**, uint, uint>)0x005B00E0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005B06F0
    /// int __thiscall HAR::Dump(_DWORD*,int,int)</code>
    /// </summary>
    public int Dump(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HAR, int, int, int>)0x005B06F0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005B0A70
    /// int __thiscall HAR::UnPack(HAR*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HAR, void**, uint, int>)0x005B0A70)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005B0DF0
    /// void __thiscall HAR::HAR(HAR*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HAR, void>)0x005B0DF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B0E60
    /// void __thiscall HAR::~HAR(HAR*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HAR, void>)0x005B0E60)(ref this);
}

