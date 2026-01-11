namespace ACBindings.Internal;

public unsafe struct TurnToEventPack
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct TurnToEventPack_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TurnToEventPack*, void> TurnToEventPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TurnToEventPack*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TurnToEventPack*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TurnToEventPack*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float absolute_degrees;
    public int run;

    // Methods
}

