namespace ACBindings.Internal;

// LOG_TRUNCATE_OP
public enum LOG_TRUNCATE_OP : byte
{
    TRUNCATE_NOP = 0x0,
    CIRCULAR_TRUNCATE_OP = 0x1,
    BACKUP_TRUNCATE_OP = 0x2
}

