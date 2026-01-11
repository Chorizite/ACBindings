namespace ACBindings.Internal;

public unsafe struct NonDBObjElementDesc
{
    // Base Classes
    public ACBindings.Internal.ElementDesc BaseClass_ElementDesc; // ACBindings.Internal.ElementDesc

    // Child Types
    public unsafe struct NonDBObjElementDesc_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NonDBObjElementDesc*, void> NonDBObjElementDesc_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NonDBObjElementDesc*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NonDBObjElementDesc*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NonDBObjElementDesc*, ACBindings.Internal.PFileNode*, byte> ToFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NonDBObjElementDesc*, ACBindings.Internal.PFileNode*, byte> FromFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NonDBObjElementDesc*, ACBindings.Internal.PFileNode*, byte> PositionToFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NonDBObjElementDesc*, ACBindings.Internal.PFileNode*, byte*, byte> HandleNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NonDBObjElementDesc*, ACBindings.Internal.PFileNode*, byte> CheckFFN; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NonDBObjElementDesc*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, uint, uint, uint, uint, void> UpdateSizeAndPosition; // function pointer

        // Methods
    }

    // Methods
}

