namespace ACBindings.DBUpdateType;

// DBUpdateType::Type
public enum Type : byte
{
    Skip = 0x0,
    None = 0x0,
    Patch = 0x1,
    Dynamic = 0x2,
    Zone = 0x3
}

