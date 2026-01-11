namespace ACBindings.Internal;

// SEND_CODE
public enum SEND_CODE : uint
{
    UNDEF_SEND = 0x0,
    OK_SEND = 0x1,
    NET_FAIL_SEND = 0x2,
    FLOW_FAIL_SEND = 0x3,
    FORCE_SEND_CODE_32_BIT = 0x7FFFFFFF
}

