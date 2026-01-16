namespace ACBindings.Internal;


/// <summary>Represents an event queue tied to a specific local board (lbID), providing packable storage via PackObj and holding a linked list of events through evQ.</summary>
public unsafe struct LBEventQueue
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct LBEventQueue_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LBEventQueue*, void> LBEventQueue_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LBEventQueue*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LBEventQueue*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LBEventQueue*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint lbID;
    public System.IntPtr evQ;

    // Methods
}

