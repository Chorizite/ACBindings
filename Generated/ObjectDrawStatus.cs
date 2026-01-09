namespace ACBindings;

// ObjectDrawStatus
public enum ObjectDrawStatus : uint
{
    UNKNOWN_ODS = 0x0,
    OUTSIDE_VIEWCONE_ODS = 0x1,
    INSIDE_VIEWCONE_ODS = 0x2,
    UNDER_CURSOR_ODS = 0x3,
    FORCE_ObjectDrawStatus_32_BIT = 0x7FFFFFFF
}

