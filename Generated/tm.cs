namespace ACBindings.Internal;


/// <summary>Represents a calendar date and time broken into individual fields—seconds, minutes, hours, day of month, month (0‑11), years since 1900, weekday (0‑6), day of year (0‑365), and daylight saving time flag—and is employed by functions such as localtime() and gmtime().</summary>
public unsafe struct tm
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
    public int tm_isdst;

    // Methods
}

