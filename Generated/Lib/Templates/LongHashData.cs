namespace ACBindings.Internal;


/// <summary>Represents an unsigned long hash value stored in a 4‑byte aligned container, leveraging HashBaseData for core functionality.</summary>
/// <remarks>The struct is lightweight and intended to be used with hashing algorithms that require 32‑bit alignment.</remarks>
public unsafe struct LongHashData
{
    // Base Classes
    public ACBindings.Internal.HashBaseData__uint BaseClass_HashBaseData; // ACBindings.Internal.HashBaseData__uint

    // Child Types
    public unsafe struct LongHashData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LongHashData*, void> LongHashData_dtor_0; // function pointer

        // Methods
    }

    // Methods
}

