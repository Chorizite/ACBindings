namespace ACBindings.Internal;

public unsafe struct AdminPlayerData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AdminPlayerData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminPlayerData*, void> AdminPlayerData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminPlayerData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminPlayerData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminPlayerData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte name;
    public uint bookieID;

    // Generated Constructor
    public AdminPlayerData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x006B1A30
    /// void __thiscall AdminPlayerData::AdminPlayerData(AdminPlayerData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AdminPlayerData, void>)0x006B1A30)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B1AA0
    /// unsigned int __thiscall AdminPlayerData::GetPackSize(AdminAccountData*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AdminPlayerData, uint>)0x006B1AA0)(ref this);
}

