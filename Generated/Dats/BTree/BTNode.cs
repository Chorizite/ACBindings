namespace ACBindings.Internal;


/// <summary>Stores child node references, tracks entry count, and contains an array of BTEntry items for efficient lookup within the tree-based data structure.</summary>
public unsafe struct BTNode
{
    // Members
    public fixed int NextNode_[62];
    public int NumEntries_;
    public fixed byte Entry__Raw[1464];
    public ACBindings.Internal.BTEntry* Entry_ => (ACBindings.Internal.BTEntry*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref Entry__Raw[0]);

    // Generated Constructor
    public BTNode() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a BTNode instance by clearing all entry data, setting each entry's identifier to an invalid value, and resetting the first next‑node pointer to zero.
    /// <code>Offset: 0x00672EC0
    /// void __thiscall BTNode::BTNode(BTNode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTNode, void>)0x00672EC0)(ref this);
}

