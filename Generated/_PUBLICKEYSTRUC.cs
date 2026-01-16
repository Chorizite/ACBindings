namespace ACBindings.Internal;


/// <summary>Defines a header for public key information, indicating the key type, version, reserved field, and cryptographic algorithm identifier. Used by the Windows Crypto API to describe the format of subsequent key data.</summary>
public unsafe struct _PUBLICKEYSTRUC
{
    // Members
    public byte bType;
    public byte bVersion;
    public ushort reserved;
    public uint aiKeyAlg;

    // Methods
}

