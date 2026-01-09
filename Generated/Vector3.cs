namespace ACBindings;

// Vector3
public unsafe struct Vector3
{
    // Members
    public float x;
    public float y;
    public float z;

    // Methods
    // void __thiscall Vector3::Normalize(Vector3*)
    public void Normalize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Vector3, void>)0x0043E880)(ref this);
    // bool __thiscall Vector3::ToFileNode(Vector3*,PFileNode*)
    public byte ToFileNode(ACBindings.PFileNode* pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Vector3, ACBindings.PFileNode*, byte>)0x0065C6E0)(ref this, pNode);
    // bool __thiscall Vector3::FromFileNode(Vector3*,const PFileNode*)
    public byte FromFileNode(ACBindings.PFileNode* pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Vector3, ACBindings.PFileNode*, byte>)0x0065C750)(ref this, pNode);
}

