namespace ACBindings.Internal;

public unsafe struct ID3D10BlobVtbl
{
    // Members
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3D10Blob*, System.IntPtr, void**, int> QueryInterface; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3D10Blob*, uint> AddRef; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3D10Blob*, uint> Release; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3D10Blob*, System.IntPtr> GetBufferPointer; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3D10Blob*, nuint> GetBufferSize; // function pointer

    // Methods
}

