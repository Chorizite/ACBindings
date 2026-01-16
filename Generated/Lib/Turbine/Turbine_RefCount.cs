namespace ACBindings.Internal;


/// <summary>Manages reference counts for objects using a fixed-size template pool of 1,048,576 entries, enabling efficient memory tracking and cleanup.</summary>
public unsafe struct Turbine_RefCount
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct Turbine_RefCount_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Turbine_RefCount*, void> Turbine_RefCount_dtor_0; // function pointer

        // Methods
    }

    // Methods
}

