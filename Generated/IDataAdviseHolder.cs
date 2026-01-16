namespace ACBindings.Internal;


/// <summary>Represents the IDataAdviseHolder COM interface, enabling clients to register and manage advisory connections with data objects.</summary>
public unsafe struct IDataAdviseHolder
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IDataAdviseHolder_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataAdviseHolder*, ACBindings.Internal.IDataObject*, System.IntPtr, uint, System.IntPtr, uint*, int> Advise; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataAdviseHolder*, uint, int> Unadvise; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataAdviseHolder*, System.IntPtr, int> EnumAdvise; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataAdviseHolder*, ACBindings.Internal.IDataObject*, uint, uint, int> SendOnDataChange; // function pointer

        // Methods
    }

    // Methods
}

