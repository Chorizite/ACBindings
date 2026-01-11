namespace ACBindings.Internal;

public unsafe struct QualityChangeHandler
{
    // Child Types
    public unsafe struct QualityChangeHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityChangeHandler*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityChangeHandler*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityRemoved; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

