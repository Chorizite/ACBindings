namespace ACBindings.Internal;

public unsafe struct InterpolationNode
{
    // Base Classes
    public ACBindings.Internal.LListData BaseClass_LListData; // ACBindings.Internal.LListData

    // Members
    public uint type;
    public ACBindings.Internal.Position p;
    public ACBindings.Internal.AC1Legacy.Vector3 v;
    public float extent;

    // Generated Constructor
    public InterpolationNode() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00556670
    /// void __thiscall InterpolationNode::InterpolationNode(InterpolationNode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationNode, void>)0x00556670)(ref this);
}

