namespace ACBindings.Internal;


/// <summary>Captures essential administrative details for a player, including base class information, a readable name, and a unique bookie identifier.</summary>
public unsafe struct AdminPlayerData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AdminPlayerData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminPlayerData*, void> AdminPlayerData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminPlayerData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminPlayerData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminPlayerData*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>Initializes an AdminPlayerData instance by configuring the base class virtual table, default‑constructing the player name string, and resetting the bookie identifier to zero.
    /// <code>Offset: 0x006B1A30
    /// void __thiscall AdminPlayerData::AdminPlayerData(AdminPlayerData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AdminPlayerData, void>)0x006B1A30)(ref this);

    /// <summary>Calculates the number of bytes needed to pack the accountName field of an AdminAccountData instance.
    /// <code>Offset: 0x006B1AA0
    /// unsigned int __thiscall AdminPlayerData::GetPackSize(AdminAccountData*)</code>
    /// </summary>
    /// <param name="this">Pointer to the AdminAccountData whose account name is measured for packing.</param>
    /// <returns>The total size in bytes required for serializing that account name, including any protocol overhead.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AdminPlayerData, uint>)0x006B1AA0)(ref this);
}

