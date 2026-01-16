namespace ACBindings.Internal;


/// <summary>
/// House structure holds all data related to an in‑game house, including its unique ID, type, owner information, name, access rights, positional data, maintenance flags, level constraints, hook usage limits, and payment schedules for buying and renting.
/// </summary>
public unsafe struct House
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct House_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.House*, void> House_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.House*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.House*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.House*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _id;
    public uint _htype;
    public ACBindings.Internal.IDClass____tagDataID _wcid;
    public uint _owner;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _account;
    public uint _bitmask;
    public int _buy_time;
    public int _rent_time;
    public ACBindings.Internal.PackableList__uint _houses;
    public ACBindings.Internal.HousePaymentList _buy;
    public ACBindings.Internal.HousePaymentList _rent;
    public ACBindings.Internal.HAR _access;
    public ACBindings.Internal.Position _boot_pos;
    public ACBindings.Internal.Position _house_pos;
    public int _maintenance_free;
    public int _min_level;
    public int _max_level;
    public int _min_alleg_rank;
    public int _max_alleg_rank;
    public int _iMaxUsableHooks;
    public int _iCurrentHooksUsed;
    public ACBindings.Internal.HookGroupData _hookGroupData;
    public uint _currentHookGroupValue;
    public ACBindings.Internal.PackableList___HouseWHouseData _housesData;

    // Methods
}

