namespace ACBindings.Internal;


/// <summary>Facilitates creation and management of alternative device context objects used by the system for graphics rendering tasks.</summary>
public unsafe struct IAlternateDCProvider
{
    // Child Types
    public unsafe struct IAlternateDCProvider_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IAlternateDCProvider*, int*, System.IntPtr, byte> GetDC; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IAlternateDCProvider*, System.IntPtr, int*, byte> ReleaseDC; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

