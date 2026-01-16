namespace ACBindings.Internal;


/// <summary>Stores details of a HID report, including data buffer pointers, size, capacity, and status flags for change detection and clearing. Used by the HID subsystem to build, send, and validate reports between devices and software.</summary>
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

