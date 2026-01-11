namespace ACBindings.Internal;

public unsafe struct IStorageVtbl
{
    // Members
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, uint> AddRef; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, uint> Release; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, ushort*, uint, uint, uint, ACBindings.Internal.IStream**, int> CreateStream; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, ushort*, System.IntPtr, uint, uint, ACBindings.Internal.IStream**, int> OpenStream; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, ushort*, uint, uint, uint, ACBindings.Internal.IStorage**, int> CreateStorage; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, ushort*, ACBindings.Internal.IStorage*, uint, ushort**, uint, ACBindings.Internal.IStorage**, int> OpenStorage; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, uint, ACBindings.Internal._GUID*, ushort**, ACBindings.Internal.IStorage*, int> CopyTo; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, ushort*, ACBindings.Internal.IStorage*, ushort*, uint, int> MoveElementTo; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, uint, int> Commit; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, int> Revert; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, uint, System.IntPtr, uint, System.IntPtr, int> EnumElements; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, ushort*, int> DestroyElement; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, ushort*, ushort*, int> RenameElement; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, ushort*, System.IntPtr, System.IntPtr, System.IntPtr, int> SetElementTimes; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, ACBindings.Internal._GUID*, int> SetClass; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, uint, uint, int> SetStateBits; // function pointer
    public delegate* unmanaged[Stdcall]<ACBindings.Internal.IStorage*, System.IntPtr, uint, int> Stat; // function pointer

    // Methods
}

