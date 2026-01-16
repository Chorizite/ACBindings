namespace ACBindings.Internal;


/// <summary>Converts raw joystick input into calibrated, range‑limited values using low/high ramp curves and configurable minimum/maximum limits for both analog axes and POV hats.</summary>
public unsafe struct JOYRANGECONVERT
{
    // Members
    public int fRaw;
    public ACBindings.Internal.JOYRAMP rmpLow;
    public ACBindings.Internal.JOYRAMP rmpHigh;
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

