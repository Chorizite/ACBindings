namespace ACBindings.Internal;

public unsafe struct IRpcHelper
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IRpcHelper_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcHelper*, uint*, int> GetDCOMProtocolVersion; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcHelper*, System.IntPtr, ACBindings.Internal._GUID**, int> GetIIDFromOBJREF; // function pointer

        // Methods
    }

    // Methods
}

