namespace ACBindings.Internal;


/// <summary>
/// Represents a node in an interpolation sequence, storing positional data, orientation quaternion, type classification, and extent for motion or animation calculations. Links to adjacent nodes via a singly linked list for efficient traversal during interpolation.
/// </summary>
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

    /// <summary>Initializes an InterpolationNode instance with default values, setting up its linked list pointer, type, position data, and frame quaternion for a stationary identity transform. Also caches the frame for future use.
    /// <code>Offset: 0x00556670
    /// void __thiscall InterpolationNode::InterpolationNode(InterpolationNode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationNode, void>)0x00556670)(ref this);
}

