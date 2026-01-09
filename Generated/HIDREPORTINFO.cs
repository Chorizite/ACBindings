namespace ACBindings;

// HIDREPORTINFO
public unsafe struct HIDREPORTINFO
{
    // Members
    public System.IntPtr rgdata;
    public System.IntPtr pvReport;
    public int cdataMax;
    public int cdataUsed;
    public uint cbReport;
    public int fNeedClear;
    public int fChanged;

    // Methods
}

