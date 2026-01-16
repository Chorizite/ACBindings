namespace ACBindings.Internal;


/// <summary>Holds a pointer to the virtual function table for archive-related types, enabling polymorphic behavior within the archiving subsystem.</summary>
/// <remarks>Serves as a lightweight base that provides access to an existing vftable without adding additional state.</remarks>
public unsafe struct ArchiveInitializer
{
    // Child Types

    /// <summary>Defines the virtual function table for ArchiveInitializer, facilitating dynamic dispatch of archive initialization logic.</summary>
    public unsafe struct ArchiveInitializer_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.Archive*, byte> InitializeArchive; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

