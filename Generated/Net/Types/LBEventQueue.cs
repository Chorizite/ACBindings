namespace ACBindings.Internal;

public unsafe struct LBEventQueue
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct LBEventQueue_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LBEventQueue*, void> LBEventQueue_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LBEventQueue*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LBEventQueue*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LBEventQueue*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint lbID;
    public System.IntPtr evQ;

    // Methods
}

