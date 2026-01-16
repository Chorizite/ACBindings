namespace ACBindings.Internal;


/// <summary>Encapsulates the components of an APDU command for T=0 smart card protocol: class, instruction, and parameter bytes.</summary>
/// <remarks>Represents a low‑level request sent to or received from a smart card in PC/SC environments.</remarks>
public unsafe struct SCARD_T0_COMMAND
{
    // Members
    public byte bCla;
    public byte bIns;
    public byte bP1;
    public byte bP2;
    public byte bP3;

    // Methods
}

