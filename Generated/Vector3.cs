namespace ACBindings.Internal;


/// <summary>Defines a three‑dimensional vector with floating‑point components x, y, and z for representing positions or directions in 3D space.</summary>
public unsafe struct Vector3
{
    // Members
    public float x;
    public float y;
    public float z;

    // Methods

    /// <summary>Converts the vector into a unit vector by scaling its components with the reciprocal of its length.
    /// <code>Offset: 0x0043E880
    /// void __thiscall Vector3::Normalize(Vector3*)</code>
    /// </summary>
    public void Normalize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Vector3, void>)0x0043E880)(ref this);

    /// <summary>Saves the vector's X, Y, and Z components as sub‑nodes of a file node.
    /// <code>Offset: 0x0065C6E0
    /// bool __thiscall Vector3::ToFileNode(Vector3*,PFileNode*)</code>
    /// </summary>
    /// <param name="this">The vector whose components are written.</param>
    /// <param name="pNode">The destination file node that receives the component sub‑nodes.</param>
    /// <returns>True when pNode is valid and all three components were successfully appended; otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.PFileNode* pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Vector3, ACBindings.Internal.PFileNode*, byte>)0x0065C6E0)(ref this, pNode);

    /// <summary>Reads three float components from the specified file node, assigns them to x, y and z, and validates the resulting vector.
    /// <code>Offset: 0x0065C750
    /// bool __thiscall Vector3::FromFileNode(Vector3*,const PFileNode*)</code>
    /// </summary>
    /// <param name="pNode">The file node that should contain exactly three sub‑nodes representing the vector components.</param>
    /// <returns>True if the node contains valid float values for all three components and the vector passes validation; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Vector3, ACBindings.Internal.PFileNode*, byte>)0x0065C750)(ref this, pNode);
}

