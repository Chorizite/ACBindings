namespace ACBindings.Internal;

public unsafe struct TurnEventPack
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct TurnEventPack_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TurnEventPack*, void> TurnEventPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TurnEventPack*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TurnEventPack*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TurnEventPack*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float relative_degrees;

    // Methods
}

