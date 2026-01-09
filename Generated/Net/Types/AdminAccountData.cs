namespace ACBindings;

// AdminAccountData
public unsafe struct AdminAccountData
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // AdminAccountData_vtbl
    public unsafe struct AdminAccountData_vtbl
    {
        // Members
        public System.IntPtr AdminAccountData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte accountName;
    public uint bookieID;

    // Generated Constructor
    public AdminAccountData() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall AdminAccountData::AdminAccountData(AdminAccountData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AdminAccountData, void>)0x006B1A00)(ref this);
    // unsigned int __thiscall AdminAccountData::Pack(AdminAccountData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AdminAccountData, void**, uint, uint>)0x006B1A60)(ref this, addr, size);
    // int __thiscall AdminAccountData::UnPack(AdminAccountData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AdminAccountData, void**, uint, int>)0x006B1AC0)(ref this, addr, size);
}

