namespace ACBindings;

// CLinkStatusPlugin
public unsafe struct CLinkStatusPlugin
{
    // Base Classes
    public ACBindings.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.CPluginPrototype

    // Child Types
    // CLinkStatusPlugin_vtbl
    public unsafe struct CLinkStatusPlugin_vtbl
    {
        // Members
        public System.IntPtr CLinkStatusPlugin_dtor_0; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer
        public System.IntPtr OnHeartbeat; // function pointer
        public System.IntPtr OnNetStatusChange; // function pointer

        // Methods
    }

    // Methods
}

