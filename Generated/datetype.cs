namespace ACBindings.Internal;


/// <summary>Represents a calendar date and time broken into individual components, mirroring the C standard library’s struct tm layout for compatibility with time‑related APIs.</summary>
/// <remarks>Fields include seconds, minutes, hours, day of month, month (0‑11), year offset from 1900, weekday, yearday, and daylight saving indicator.</remarks>
public unsafe struct datetype
{
    // Members
    public int tm_sec;
    public int tm_min;
    public int tm_hour;
    public int tm_mday;
    public int tm_mon;
    public int tm_year;
    public int tm_wday;
    public int tm_yday;
    public byte tm_isdst;

    // Methods
}

