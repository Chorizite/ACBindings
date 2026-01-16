namespace ACBindings.Internal;


/// <summary>Describes a window class configuration for Keystone windows, providing resource identifiers and callback functions for message handling, ASP interactions, and sound events.</summary>
public unsafe struct KSWNDCLASS
{
    // Members
    public ushort* lpResourceName;
    public static delegate* unmanaged[Cdecl]<ACBindings.Internal.IKeystoneWindow*, uint, uint, int, int> fnWndProc; // function pointer
    public static delegate* unmanaged[Cdecl]<ushort*, ushort*> fnASPCallback; // function pointer
    public static delegate* unmanaged[Cdecl]<ushort*, int> fnSoundCallback; // function pointer

    // Methods
}

