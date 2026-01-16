namespace ACBindings.Internal;


/// <summary>
/// Provides a virtual function table interface for handling quality changes within the application.
/// </summary>
public unsafe struct QualityChangeHandler
{
    // Child Types

    /// <summary>Holds function pointers invoked when an object's quality changes or is removed, enabling the system to react to dynamic property updates.</summary>
    public unsafe struct QualityChangeHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityChangeHandler*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityChangeHandler*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityRemoved; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

