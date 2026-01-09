namespace ACBindings;

// SetPositionError
public enum SetPositionError : uint
{
    OK_SPE = 0x0,
    GENERAL_FAILURE_SPE = 0x1,
    NO_VALID_POSITION_SPE = 0x2,
    NO_CELL_SPE = 0x3,
    COLLIDED_SPE = 0x4,
    INVALID_ARGUMENTS = 0x100,
    FORCE_SetPositionError_32_BIT = 0x7FFFFFFF
}

