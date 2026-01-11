namespace ACBindings.Internal;

public unsafe struct Vector3
{
    // Members
    public float x;
    public float y;
    public float z;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0043E880
    /// void __thiscall Vector3::Normalize(Vector3*)</code>
    /// </summary>
    public void Normalize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Vector3, void>)0x0043E880)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065C6E0
    /// bool __thiscall Vector3::ToFileNode(Vector3*,PFileNode*)</code>
    /// </summary>
    public byte ToFileNode(ACBindings.Internal.PFileNode* pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Vector3, ACBindings.Internal.PFileNode*, byte>)0x0065C6E0)(ref this, pNode);

    /// <summary>
    /// <code>Offset: 0x0065C750
    /// bool __thiscall Vector3::FromFileNode(Vector3*,const PFileNode*)</code>
    /// </summary>
    public byte FromFileNode(ACBindings.Internal.PFileNode* pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Vector3, ACBindings.Internal.PFileNode*, byte>)0x0065C750)(ref this, pNode);
}

