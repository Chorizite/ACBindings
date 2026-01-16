namespace ACBindings.Internal;


/// <summary>Defines a COM interface used by the application for configuring movie playback sessions.</summary>
/// <remarks>Inherits from IUnknown to support standard COM operations. No additional members or methods are present in this decompiled representation.</remarks>
public unsafe struct IAMovieSetup
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IAMovieSetup_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAMovieSetup*, int> Register; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAMovieSetup*, int> Unregister; // function pointer

        // Methods
    }

    // Methods
}

