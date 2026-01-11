namespace ACBindings.Internal;

public unsafe struct HouseWHouseData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct HouseWHouseData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseWHouseData*, void> HouseWHouseData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseWHouseData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseWHouseData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseWHouseData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _wHouseIID;
    public int _iHooksInUse;
    public uint _version;
    public ACBindings.Internal.HookGroupData _hookGroupData;

    // Methods
}

