namespace ACBindings.Internal;


/// <summary>Provides a COM interface for accessing raw byte buffers returned by D3DX utilities, exposing pointer and size information.</summary>
/// <remarks>Implements IUnknown; used to retrieve buffer contents from DirectX 9 functions.</remarks>
public unsafe struct ID3DXBuffer
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct ID3DXBuffer_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBuffer*, System.IntPtr> GetBufferPointer; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBuffer*, uint> GetBufferSize; // function pointer

        // Methods
    }

    // Methods
}

