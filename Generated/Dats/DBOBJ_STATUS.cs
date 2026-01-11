namespace ACBindings.Internal;

// DBOBJ_STATUS
public enum DBOBJ_STATUS : byte
{
    DBOBJ_UNDEF = 0x0,
    DBOBJ_OK = 0x1,
    DBOBJ_NOTFOUND = 0x2,
    DBOBJ_DEFERRED = 0x3,
    DBOBJ_NOTLOADED = 0x4,
    DBOBJ_FROZEN = 0x5
}

