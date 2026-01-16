namespace ACBindings.Internal;


/// <summary>COM interface enabling interaction with audio services through IDispatch.</summary>
public unsafe struct IBasicAudio
{
    // Base Classes
    public ACBindings.Internal.IDispatch BaseClass_IDispatch; // ACBindings.Internal.IDispatch

    // Child Types
    public unsafe struct IBasicAudio_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, uint*, int> GetTypeInfoCount; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, uint, uint, System.IntPtr, int> GetTypeInfo; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, ACBindings.Internal._GUID*, ushort**, uint, uint, int*, int> GetIDsOfNames; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, int, ACBindings.Internal._GUID*, uint, ushort, System.IntPtr, System.IntPtr, System.IntPtr, uint*, int> Invoke; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicAudio*, int, int> put_Volume; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicAudio*, int*, int> get_Volume; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicAudio*, int, int> put_Balance; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicAudio*, int*, int> get_Balance; // function pointer

        // Methods
    }

    // Methods
}

