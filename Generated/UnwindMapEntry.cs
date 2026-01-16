namespace ACBindings.Internal;


/// <summary>Represents a transition entry in an unwind map, linking a destination state to an associated action callback. Utilized during exception handling or state machine execution to direct control flow and invoke the specified routine.</summary>
public unsafe struct UnwindMapEntry
{
    // Members
    public int toState;
    public System.IntPtr action;

    // Methods
}

