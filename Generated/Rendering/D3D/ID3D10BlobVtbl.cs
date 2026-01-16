namespace ACBindings.Internal;


/// <summary>Defines the vtable layout for the ID3D10Blob interface, enabling COM method dispatch for blob objects within Direct3D 10.</summary>
public unsafe struct ID3D10BlobVtbl
{
    // Members
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3D10Blob*, System.IntPtr, void**, int> QueryInterface; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3D10Blob*, uint> AddRef; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3D10Blob*, uint> Release; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3D10Blob*, System.IntPtr> GetBufferPointer; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3D10Blob*, nuint> GetBufferSize; // function pointer

    // Methods
}

