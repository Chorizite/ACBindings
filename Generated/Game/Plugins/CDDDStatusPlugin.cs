namespace ACBindings.Internal;

public unsafe struct CDDDStatusPlugin
{
    // Base Classes
    public ACBindings.Internal.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.Internal.CPluginPrototype

    // Child Types
    public unsafe struct CDDDStatusPlugin_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CDDDStatusPlugin*, void> CDDDStatusPlugin_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CDDDStatusPlugin*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CDDDStatusPlugin*, ACBindings.Internal.DDDEvent, uint, void> OnDDDEvent; // function pointer

        // Methods
    }

    // Methods
}

