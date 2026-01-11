namespace ACBindings.Internal;

public unsafe struct INonDelegatingUnknown
{
    // Child Types
    public unsafe struct INonDelegatingUnknown_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.INonDelegatingUnknown*, ACBindings.Internal._GUID*, void**, int> NonDelegatingQueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.INonDelegatingUnknown*, uint> NonDelegatingAddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.INonDelegatingUnknown*, uint> NonDelegatingRelease; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

