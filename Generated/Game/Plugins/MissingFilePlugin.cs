namespace ACBindings.Internal;

public unsafe struct MissingFilePlugin
{
    // Base Classes
    public ACBindings.Internal.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.Internal.CPluginPrototype

    // Child Types
    public unsafe struct MissingFilePlugin_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MissingFilePlugin*, void> MissingFilePlugin_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MissingFilePlugin*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public System.IntPtr ReportMissingFile;
        public System.IntPtr ReportUnallocatedFile;

        // Methods
    }

    // Methods
}

