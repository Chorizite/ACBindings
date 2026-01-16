namespace ACBindings.Internal;


/// <summary>Serves as a COM-style sink for handling incoming chat network events and messages.</summary>
public unsafe struct IChatNetworkSink
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IChatNetworkSink_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatNetworkSink*, ACBindings.Internal.tagBLOB, int> OnNetworkData; // function pointer

        // Methods
    }

    // Methods
}

