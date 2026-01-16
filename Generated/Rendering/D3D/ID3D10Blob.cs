namespace ACBindings.Internal;


/// <summary>Immutable binary blob used by Direct3D 10 components, such as shader bytecode and constant buffers.</summary>
/// <remarks>Provides a pointer to the vtable of methods defined by ID3D10Blob, typically returned from D3DX functions or device creation calls.</remarks>
public unsafe struct ID3D10Blob
{
    // Members
    public System.IntPtr lpVtbl; // vtable pointer

    // Methods
}

