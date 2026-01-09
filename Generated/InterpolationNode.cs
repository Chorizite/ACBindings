namespace ACBindings;

// InterpolationNode
public unsafe struct InterpolationNode
{
    // Base Classes
    public ACBindings.LListData BaseClass_LListData; // ACBindings.LListData

    // Members
    public uint type;
    public ACBindings.Position p;
    public ACBindings.AC1Legacy.Vector3 v;
    public float extent;

    // Generated Constructor
    public InterpolationNode() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall InterpolationNode::InterpolationNode(InterpolationNode*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpolationNode, void>)0x00556670)(ref this);
}

