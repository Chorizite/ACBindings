namespace ACBindings.Internal;


/// <summary>Encapsulates a turning event, combining serialization functionality via PackObj with the rotation angle expressed in degrees.</summary>
public unsafe struct TurnEventPack
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct TurnEventPack_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TurnEventPack*, void> TurnEventPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TurnEventPack*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TurnEventPack*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TurnEventPack*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float relative_degrees;

    // Methods
}

