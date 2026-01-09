namespace ACBindings;

// BTNode
public unsafe struct BTNode
{
    // Members
    public fixed int NextNode_[62];
    public int NumEntries_;
    public fixed byte Entry__Raw[1464];
    public ACBindings.BTEntry* Entry_ => (ACBindings.BTEntry*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref Entry__Raw[0]);

    // Generated Constructor
    public BTNode() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall BTNode::BTNode(BTNode*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTNode, void>)0x00672EC0)(ref this);
}

