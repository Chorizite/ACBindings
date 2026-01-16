namespace ACBindings.Internal;


/// <summary>
/// Represents the virtual function table for the COM IStream interface, providing method pointers that enable stream operations such as reading, writing, seeking, and cloning.
/// </summary>
public unsafe struct IStreamVtbl
{
    // Members
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, uint> AddRef; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, uint> Release; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, System.IntPtr, uint, uint*, int> Read; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, void*, uint, uint*, int> Write; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, ACBindings.Internal._LARGE_INTEGER, uint, ACBindings.Internal._ULARGE_INTEGER*, int> Seek; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, ACBindings.Internal._ULARGE_INTEGER, int> SetSize; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, ACBindings.Internal.IStream*, ACBindings.Internal._ULARGE_INTEGER, ACBindings.Internal._ULARGE_INTEGER*, ACBindings.Internal._ULARGE_INTEGER*, int> CopyTo; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, uint, int> Commit; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, int> Revert; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, ACBindings.Internal._ULARGE_INTEGER, ACBindings.Internal._ULARGE_INTEGER, uint, int> LockRegion; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, ACBindings.Internal._ULARGE_INTEGER, ACBindings.Internal._ULARGE_INTEGER, uint, int> UnlockRegion; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, System.IntPtr, uint, int> Stat; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IStream*, ACBindings.Internal.IStream**, int> Clone; // function pointer

    // Methods
}

