namespace ACBindings;

// CDDDStatusPlugin
public unsafe struct CDDDStatusPlugin
{
    // Base Classes
    public ACBindings.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.CPluginPrototype

    // Child Types
    // CDDDStatusPlugin_vtbl
    public unsafe struct CDDDStatusPlugin_vtbl
    {
        // Members
        public System.IntPtr CDDDStatusPlugin_dtor_0; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer
        public System.IntPtr OnDDDEvent; // function pointer

        // Methods
    }

    // Methods
}

