namespace ACBindings.Internal;

public unsafe struct ID3DXBuffer
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct ID3DXBuffer_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBuffer*, System.IntPtr> GetBufferPointer; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBuffer*, uint> GetBufferSize; // function pointer

        // Methods
    }

    // Methods
}

