namespace ACBindings.Internal;

public unsafe struct IDataFilter
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IDataFilter_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataFilter*, uint, int, byte*, int, byte*, int, int*, int*, uint, int> DoEncode; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataFilter*, uint, int, byte*, int, byte*, int, int*, int*, uint, int> DoDecode; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IDataFilter*, uint, int> SetEncodingLevel; // function pointer

        // Methods
    }

    // Methods
}

