namespace ACBindings.Internal;


/// <summary>Represents a COM‑compatible base for RPC helper implementations, inheriting from IUnknown to support reference counting.</summary>
/// <remarks>Alignment is set to 4 bytes for memory layout compatibility with the original binary.</remarks>
public unsafe struct IRpcHelper
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IRpcHelper_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcHelper*, uint*, int> GetDCOMProtocolVersion; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcHelper*, System.IntPtr, ACBindings.Internal._GUID**, int> GetIIDFromOBJREF; // function pointer

        // Methods
    }

    // Methods
}

