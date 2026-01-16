namespace ACBindings.Internal;


/// <summary>Defines a COM interface for asynchronous byte‑level pipe operations, inheriting from IUnknown to support reference counting and interface querying.</summary>
public unsafe struct AsyncIPipeByte
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct AsyncIPipeByte_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIPipeByte*, uint, int> Begin_Pull; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIPipeByte*, byte*, uint*, int> Finish_Pull; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIPipeByte*, byte*, uint, int> Begin_Push; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIPipeByte*, int> Finish_Push; // function pointer

        // Methods
    }

    // Methods
}

