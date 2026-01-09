namespace ACBindings;

// IDTableStorage
public unsafe struct IDTableStorage
{
    // Base Classes
    public ACBindings.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.CPluginPrototype

    // Child Types
    // IDTableStorage_vtbl
    public unsafe struct IDTableStorage_vtbl
    {
        // Members
        public System.IntPtr IDTableStorage_dtor_0; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer
        public System.IntPtr InitFromFilename;
        public System.IntPtr TestForExistance;
        public System.IntPtr OnDone;
        public System.IntPtr RequestClearAll; // function pointer
        public System.IntPtr RequestAllTypeData; // function pointer
        public System.IntPtr RequestTypeNumber;
        public System.IntPtr SetTypeData;
        public System.IntPtr RequestAllMappings; // function pointer
        public System.IntPtr RequestMappings; // function pointer
        public System.IntPtr RequestMapping;
        public System.IntPtr SetMapping;
        public System.IntPtr SetDescriptionString;
        public System.IntPtr GetDescriptionString;

        // Methods
    }

    // Methods
}

