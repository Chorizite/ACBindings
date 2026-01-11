namespace ACBindings.Internal;

public unsafe struct _SECURITY_DESCRIPTOR
{
    // Members
    public byte Revision;
    public byte Sbz1;
    public ushort Control;
    public System.IntPtr Owner;
    public System.IntPtr Group;
    public System.IntPtr Sacl;
    public System.IntPtr Dacl;

    // Methods
}

