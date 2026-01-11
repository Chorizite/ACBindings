namespace ACBindings.Internal;

public unsafe struct IDTableStorage
{
    // Base Classes
    public ACBindings.Internal.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.Internal.CPluginPrototype

    // Child Types
    public unsafe struct IDTableStorage_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDTableStorage*, void> IDTableStorage_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDTableStorage*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public System.IntPtr InitFromFilename;
        public System.IntPtr TestForExistance;
        public System.IntPtr OnDone;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDTableStorage*, byte> RequestClearAll; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDTableStorage*, ACBindings.Internal.IDTableStorageCallback*, byte> RequestAllTypeData; // function pointer
        public System.IntPtr RequestTypeNumber;
        public System.IntPtr SetTypeData;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDTableStorage*, ACBindings.Internal.IDTableStorageCallback*, byte> RequestAllMappings; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDTableStorage*, ACBindings.Internal.IDTableStorageCallback*, uint, byte> RequestMappings; // function pointer
        public System.IntPtr RequestMapping;
        public System.IntPtr SetMapping;
        public System.IntPtr SetDescriptionString;
        public System.IntPtr GetDescriptionString;

        // Methods
    }

    // Methods
}

