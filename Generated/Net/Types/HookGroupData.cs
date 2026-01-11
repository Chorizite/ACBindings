namespace ACBindings.Internal;

public unsafe struct HookGroupData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct HookGroupData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HookGroupData*, void> HookGroupData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HookGroupData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HookGroupData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HookGroupData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _version;
    public ACBindings.Internal.PackableHashTable__uint__int _data;

    // Methods
}

