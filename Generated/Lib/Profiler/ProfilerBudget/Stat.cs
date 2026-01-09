namespace ACBindings.ProfilerBudget;

// ProfilerBudget::Stat
public enum Stat : byte
{
    Stat_Triangles = 0x0,
    Stat_Vertices = 0x1,
    Stat_Batches = 0x2,
    Stat_SystemMemory = 0x3,
    Stat_VirtualMemory = 0x4,
    Stat_TotalVideoMemory = 0x5,
    Stat_VideoMemory = 0x6,
    NumStats = 0x7
}

