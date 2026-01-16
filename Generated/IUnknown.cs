namespace ACBindings.Internal;


/// <summary>Fundamental COM interface enabling object lifetime management and interface discovery through reference counting and querying.</summary>
public unsafe struct IUnknown
{
    // Child Types

    /// <summary>Represents the virtual function table for COM’s IUnknown interface, providing pointers to QueryInterface, AddRef, and Release methods.</summary>
    public unsafe struct IUnknown_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

