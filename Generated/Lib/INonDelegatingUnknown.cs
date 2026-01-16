namespace ACBindings.Internal;


/// <summary>Provides a lightweight base interface for COM‑style objects that bypasses delegation, offering only a virtual function table pointer for method dispatch.</summary>
public unsafe struct INonDelegatingUnknown
{
    // Child Types
    public unsafe struct INonDelegatingUnknown_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.INonDelegatingUnknown*, ACBindings.Internal._GUID*, void**, int> NonDelegatingQueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.INonDelegatingUnknown*, uint> NonDelegatingAddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.INonDelegatingUnknown*, uint> NonDelegatingRelease; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

