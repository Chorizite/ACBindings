namespace ACBindings.Internal;


/// <summary>Stores data for a referral response, including a 64‑bit cookie value, the target server’s network address, and its service identifier.</summary>
public unsafe struct CReferralStruct
{
    // Members
    public ulong qwCookie;
    public int Addr;
    public ushort idServer;
    public ushort padding;

    // Methods
}

