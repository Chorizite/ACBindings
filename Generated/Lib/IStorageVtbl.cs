namespace ACBindings;

// IStorageVtbl
public unsafe struct IStorageVtbl
{
    // Members
    public System.IntPtr QueryInterface; // function pointer
    public System.IntPtr AddRef; // function pointer
    public System.IntPtr Release; // function pointer
    public System.IntPtr CreateStream; // function pointer
    public System.IntPtr OpenStream; // function pointer
    public System.IntPtr CreateStorage; // function pointer
    public System.IntPtr OpenStorage; // function pointer
    public System.IntPtr CopyTo; // function pointer
    public System.IntPtr MoveElementTo; // function pointer
    public System.IntPtr Commit; // function pointer
    public System.IntPtr Revert; // function pointer
    public System.IntPtr EnumElements; // function pointer
    public System.IntPtr DestroyElement; // function pointer
    public System.IntPtr RenameElement; // function pointer
    public System.IntPtr SetElementTimes; // function pointer
    public System.IntPtr SetClass; // function pointer
    public System.IntPtr SetStateBits; // function pointer
    public System.IntPtr Stat; // function pointer

    // Methods
}

