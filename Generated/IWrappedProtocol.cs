namespace ACBindings.Internal;


/// <summary>Encapsulates an IUnknown interface reference used within the application.</summary>
/// <remarks>The struct aligns its member to a 4-byte boundary to satisfy binary layout constraints.</remarks>
public unsafe struct IWrappedProtocol
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IWrappedProtocol_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IWrappedProtocol*, int*, uint, int> GetWrapperCode; // function pointer

        // Methods
    }

    // Methods
}

