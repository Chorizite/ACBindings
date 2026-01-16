namespace ACBindings.Internal;


/// <summary>Represents a single budget statistic item, storing its descriptive information, current value, and status as reported by the profiler.</summary>
public unsafe struct BudgetStatItem
{
    // Members
    public ACBindings.Internal.BudgetStatInfo sInfo;
    public uint nValue;
    public ACBindings.Internal.ProfilerBudget.Status nStatus;

    // Methods
}

