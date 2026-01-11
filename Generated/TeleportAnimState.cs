namespace ACBindings.Internal;

// TeleportAnimState
public enum TeleportAnimState : uint
{
    TAS_OFF = 0x0,
    TAS_WORLD_FADE_OUT = 0x1,
    TAS_TUNNEL_FADE_IN = 0x2,
    TAS_TUNNEL = 0x3,
    TAS_TUNNEL_CONTINUE = 0x4,
    TAS_TUNNEL_FADE_OUT = 0x5,
    TAS_WORLD_FADE_IN = 0x6,
    FORCE_TeleportAnimState_32_BIT = 0x7FFFFFFF
}

