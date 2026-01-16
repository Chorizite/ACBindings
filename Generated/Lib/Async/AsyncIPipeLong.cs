namespace ACBindings.Internal;


/// <summary>Handles asynchronous communication of 32‑bit integers over a pipe, exposing the interface through COM’s IUnknown.</summary>
public unsafe struct AsyncIPipeLong
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct AsyncIPipeLong_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIPipeLong*, uint, int> Begin_Pull; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIPipeLong*, int*, uint*, int> Finish_Pull; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIPipeLong*, int*, uint, int> Begin_Push; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIPipeLong*, int> Finish_Push; // function pointer

        // Methods
    }

    // Methods
}

