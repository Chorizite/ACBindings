namespace ACBindings.Internal;

public unsafe struct AdminAccountData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AdminAccountData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminAccountData*, void> AdminAccountData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminAccountData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminAccountData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminAccountData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte accountName;
    public uint bookieID;

    // Generated Constructor
    public AdminAccountData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x006B1A00
    /// void __thiscall AdminAccountData::AdminAccountData(AdminAccountData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AdminAccountData, void>)0x006B1A00)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B1A60
    /// unsigned int __thiscall AdminAccountData::Pack(AdminAccountData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AdminAccountData, void**, uint, uint>)0x006B1A60)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B1AC0
    /// int __thiscall AdminAccountData::UnPack(AdminAccountData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AdminAccountData, void**, uint, int>)0x006B1AC0)(ref this, addr, size);
}

