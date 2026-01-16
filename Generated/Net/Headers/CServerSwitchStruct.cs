namespace ACBindings.Internal;


/// <summary>Tracks a server switch event by recording the time of occurrence and its classification.</summary>
/// <remarks>The dwSeqNo member stores a timestamp (CTimestamp) indicating when the switch was logged, while Type specifies the transition category via ServerSwitchType.</remarks>
public unsafe struct CServerSwitchStruct
{
    // Members
    public ACBindings.Internal.CTimestamp__uint dwSeqNo;
    public ACBindings.Internal.ServerSwitchType Type;

    // Methods
}

