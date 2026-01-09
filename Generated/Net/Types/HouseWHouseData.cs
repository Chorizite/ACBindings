namespace ACBindings;

// HouseWHouseData
public unsafe struct HouseWHouseData
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // HouseWHouseData_vtbl
    public unsafe struct HouseWHouseData_vtbl
    {
        // Members
        public System.IntPtr HouseWHouseData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _wHouseIID;
    public int _iHooksInUse;
    public uint _version;
    public ACBindings.HookGroupData _hookGroupData;

    // Methods
}

