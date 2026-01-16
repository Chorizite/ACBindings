namespace ACBindings.Internal;


/// <summary>Turbine_RefCountNoMT provides a lightweight reference counting mechanism without thread‑safety guarantees, using ReferenceCountTemplate to manage object lifetimes in a single‑threaded environment.</summary>
public unsafe struct Turbine_RefCountNoMT
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct Turbine_RefCountNoMT_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Turbine_RefCountNoMT*, void> Turbine_RefCountNoMT_dtor_0; // function pointer

        // Methods
    }

    // Methods
}

