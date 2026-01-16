namespace ACBindings.Internal;


/// <summary>Represents a status plugin prototype, enabling registration and interaction within the application’s plugin framework.</summary>
public unsafe struct CDDDStatusPlugin
{
    // Base Classes
    public ACBindings.Internal.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.Internal.CPluginPrototype

    // Child Types
    public unsafe struct CDDDStatusPlugin_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CDDDStatusPlugin*, void> CDDDStatusPlugin_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CDDDStatusPlugin*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CDDDStatusPlugin*, ACBindings.Internal.DDDEvent, uint, void> OnDDDEvent; // function pointer

        // Methods
    }

    // Methods
}

