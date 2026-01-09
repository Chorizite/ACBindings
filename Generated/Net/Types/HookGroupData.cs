namespace ACBindings;

// HookGroupData
public unsafe struct HookGroupData
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // HookGroupData_vtbl
    public unsafe struct HookGroupData_vtbl
    {
        // Members
        public System.IntPtr HookGroupData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _version;
    public ACBindings.PackableHashTable__uint__int _data;

    // Methods
}

