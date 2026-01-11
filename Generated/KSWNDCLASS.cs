namespace ACBindings.Internal;

public unsafe struct KSWNDCLASS
{
    // Members
    public ushort* lpResourceName;
    public delegate* unmanaged[Cdecl]<ACBindings.Internal.IKeystoneWindow*, uint, uint, int, int> fnWndProc; // function pointer
    public delegate* unmanaged[Cdecl]<ushort*, ushort*> fnASPCallback; // function pointer
    public delegate* unmanaged[Cdecl]<ushort*, int> fnSoundCallback; // function pointer

    // Methods
}

