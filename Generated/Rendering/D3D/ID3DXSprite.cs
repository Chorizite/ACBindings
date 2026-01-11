namespace ACBindings.Internal;

public unsafe struct ID3DXSprite
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct ID3DXSprite_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXSprite*, System.IntPtr, int> GetDevice; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXSprite*, ACBindings.Internal.D3DXMATRIX*, int> GetTransform; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXSprite*, ACBindings.Internal.D3DXMATRIX*, int> SetTransform; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXSprite*, ACBindings.Internal.D3DXMATRIX*, ACBindings.Internal.D3DXMATRIX*, int> SetWorldViewRH; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXSprite*, ACBindings.Internal.D3DXMATRIX*, ACBindings.Internal.D3DXMATRIX*, int> SetWorldViewLH; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXSprite*, uint, int> Begin; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXSprite*, System.IntPtr, ACBindings.Internal.tagRECT*, ACBindings.Internal.D3DXVECTOR3*, ACBindings.Internal.D3DXVECTOR3*, uint, int> Draw; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXSprite*, int> Flush; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXSprite*, int> End; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXSprite*, int> OnLostDevice; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXSprite*, int> OnResetDevice; // function pointer

        // Methods
    }

    // Methods
}

