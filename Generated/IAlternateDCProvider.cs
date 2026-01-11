namespace ACBindings.Internal;

public unsafe struct IAlternateDCProvider
{
    // Child Types
    public unsafe struct IAlternateDCProvider_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IAlternateDCProvider*, int*, System.IntPtr, byte> GetDC; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IAlternateDCProvider*, System.IntPtr, int*, byte> ReleaseDC; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

