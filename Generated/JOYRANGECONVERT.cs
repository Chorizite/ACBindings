namespace ACBindings;

// JOYRANGECONVERT
public unsafe struct JOYRANGECONVERT
{
    // Members
    public int fRaw;
    public ACBindings.JOYRAMP rmpLow;
    public ACBindings.JOYRAMP rmpHigh;
    public uint dwPmin;
    public uint dwPmax;
    public uint dwPc;
    public int lMin;
    public int lMax;
    public int lC;
    public uint dwDz;
    public uint dwSat;
    public int fFakeRaw;
    public int fPolledPOV;
    public fixed int lMinPOV[5];
    public fixed int lMaxPOV[5];

    // Methods
}

