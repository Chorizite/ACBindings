namespace ACBindings;

// House
public unsafe struct House
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // House_vtbl
    public unsafe struct House_vtbl
    {
        // Members
        public System.IntPtr House_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _id;
    public uint _htype;
    public ACBindings.IDClass___tagDataID _wcid;
    public uint _owner;
    public ACBindings.AC1Legacy.PStringBase__sbyte _name;
    public ACBindings.AC1Legacy.PStringBase__sbyte _account;
    public uint _bitmask;
    public int _buy_time;
    public int _rent_time;
    public ACBindings.PackableList__uint _houses;
    public ACBindings.HousePaymentList _buy;
    public ACBindings.HousePaymentList _rent;
    public ACBindings.HAR _access;
    public ACBindings.Position _boot_pos;
    public ACBindings.Position _house_pos;
    public int _maintenance_free;
    public int _min_level;
    public int _max_level;
    public int _min_alleg_rank;
    public int _max_alleg_rank;
    public int _iMaxUsableHooks;
    public int _iCurrentHooksUsed;
    public ACBindings.HookGroupData _hookGroupData;
    public uint _currentHookGroupValue;
    public ACBindings.PackableList__HouseWHouseData _housesData;

    // Methods
}

