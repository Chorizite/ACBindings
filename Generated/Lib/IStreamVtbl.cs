namespace ACBindings;

// IStreamVtbl
public unsafe struct IStreamVtbl
{
    // Members
    public System.IntPtr QueryInterface; // function pointer
    public System.IntPtr AddRef; // function pointer
    public System.IntPtr Release; // function pointer
    public System.IntPtr Read; // function pointer
    public System.IntPtr Write; // function pointer
    public System.IntPtr Seek; // function pointer
    public System.IntPtr SetSize; // function pointer
    public System.IntPtr CopyTo; // function pointer
    public System.IntPtr Commit; // function pointer
    public System.IntPtr Revert; // function pointer
    public System.IntPtr LockRegion; // function pointer
    public System.IntPtr UnlockRegion; // function pointer
    public System.IntPtr Stat; // function pointer
    public System.IntPtr Clone; // function pointer

    // Methods
}

