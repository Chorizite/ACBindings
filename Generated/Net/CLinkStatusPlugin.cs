namespace ACBindings.Internal;

public unsafe struct CLinkStatusPlugin
{
    // Base Classes
    public ACBindings.Internal.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.Internal.CPluginPrototype

    // Child Types
    public unsafe struct CLinkStatusPlugin_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLinkStatusPlugin*, void> CLinkStatusPlugin_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLinkStatusPlugin*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLinkStatusPlugin*, ACBindings.Internal.CLinkStatusAverages*, void> OnHeartbeat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLinkStatusPlugin*, ACBindings.Internal.NetStatus, int, int, void> OnNetStatusChange; // function pointer

        // Methods
    }

    // Methods
}

