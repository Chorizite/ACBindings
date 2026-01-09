namespace ACBindings;

// MissingFilePlugin
public unsafe struct MissingFilePlugin
{
    // Base Classes
    public ACBindings.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.CPluginPrototype

    // Child Types
    // MissingFilePlugin_vtbl
    public unsafe struct MissingFilePlugin_vtbl
    {
        // Members
        public System.IntPtr MissingFilePlugin_dtor_0; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer
        public System.IntPtr ReportMissingFile;
        public System.IntPtr ReportUnallocatedFile;

        // Methods
    }

    // Methods
}

