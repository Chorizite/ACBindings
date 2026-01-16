namespace ACBindings.Internal;


/// <summary>Provides late‑binding support for COM components, enabling dynamic method and property access through dispatch identifiers.</summary>
public unsafe struct IDispatch
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IDispatch_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, uint*, int> GetTypeInfoCount; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, uint, uint, System.IntPtr, int> GetTypeInfo; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, ACBindings.Internal._GUID*, ushort**, uint, uint, int*, int> GetIDsOfNames; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, int, ACBindings.Internal._GUID*, uint, ushort, System.IntPtr, System.IntPtr, System.IntPtr, uint*, int> Invoke; // function pointer

        // Methods
    }

    // Methods
}

