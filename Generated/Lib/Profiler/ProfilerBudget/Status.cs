namespace ACBindings.ProfilerBudget;

// ProfilerBudget::Status
public enum Status : byte
{
    NotSet = 0x0,
    WayInBudget = 0x1,
    InBudget = 0x2,
    AlmostOverBudget = 0x3,
    JustOverBudget = 0x4,
    WayOverBudget = 0x5,
    NumOfStatuses = 0x6
}

