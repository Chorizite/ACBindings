namespace ACBindings;

// InternetCookieState
public enum InternetCookieState : byte
{
    COOKIE_STATE_UNKNOWN = 0x0,
    COOKIE_STATE_ACCEPT = 0x1,
    COOKIE_STATE_PROMPT = 0x2,
    COOKIE_STATE_LEASH = 0x3,
    COOKIE_STATE_DOWNGRADE = 0x4,
    COOKIE_STATE_REJECT = 0x5,
    COOKIE_STATE_MAX = 0x5
}

