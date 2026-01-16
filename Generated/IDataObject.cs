namespace ACBindings.Internal;


/// <summary>COM interface for accessing data objects, allowing clients to retrieve or manipulate structured data within the application.</summary>
public unsafe struct IDataObject
{
    // Child Types
    public unsafe struct IDataObject_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataObject*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataObject*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataObject*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataObject*, System.IntPtr, System.IntPtr, int> GetData; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataObject*, System.IntPtr, System.IntPtr, int> GetDataHere; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataObject*, System.IntPtr, int> QueryGetData; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataObject*, System.IntPtr, System.IntPtr, int> GetCanonicalFormatEtc; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataObject*, System.IntPtr, System.IntPtr, int, int> SetData; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataObject*, uint, System.IntPtr, int> EnumFormatEtc; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataObject*, System.IntPtr, uint, System.IntPtr, uint*, int> DAdvise; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataObject*, uint, int> DUnadvise; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataObject*, System.IntPtr, int> EnumDAdvise; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr lpVtbl; // vtable pointer

    // Methods
}

