namespace ACBindings;

// KSWNDCLASS
public unsafe struct KSWNDCLASS
{
    // Members
    public ushort* lpResourceName;
    public System.IntPtr fnWndProc; // function pointer
    public System.IntPtr fnASPCallback; // function pointer
    public System.IntPtr fnSoundCallback; // function pointer

    // Methods
}

