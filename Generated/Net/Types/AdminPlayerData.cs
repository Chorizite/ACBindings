namespace ACBindings;

// AdminPlayerData
public unsafe struct AdminPlayerData
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // AdminPlayerData_vtbl
    public unsafe struct AdminPlayerData_vtbl
    {
        // Members
        public System.IntPtr AdminPlayerData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte name;
    public uint bookieID;

    // Generated Constructor
    public AdminPlayerData() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall AdminPlayerData::AdminPlayerData(AdminPlayerData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AdminPlayerData, void>)0x006B1A30)(ref this);
    // unsigned int __thiscall AdminPlayerData::GetPackSize(AdminAccountData*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AdminPlayerData, uint>)0x006B1AA0)(ref this);
}

