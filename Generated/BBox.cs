namespace ACBindings;

// BBox
public unsafe struct BBox
{
    // Statics
    public static ACBindings.BBox* s_cZeroAABB = (ACBindings.BBox*)0x008EF180;

    // Members
    public ACBindings.Vector3 m_vMin;
    public ACBindings.Vector3 m_vMax;

    // Methods
    // void __thiscall BBox::AdjustBBox(BBox*,const Vector3*)
    public void AdjustBBox(ACBindings.Vector3* vc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BBox, ACBindings.Vector3*, void>)0x00534E90)(ref this, vc);
    // void __thiscall BBox::BuildBoundingBox(BBox*,BBox*)
    public void BuildBoundingBox(ACBindings.BBox* bbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BBox, ACBindings.BBox*, void>)0x005B2E20)(ref this, bbox);
    // void __thiscall BBox::InitForAdjustment(BBox*)
    public void InitForAdjustment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BBox, void>)0x005B2EA0)(ref this);
    // void __thiscall BBox::LocalToLocal(BBox*,const BBox*,const Position*,const Position*)
    public void LocalToLocal(ACBindings.BBox* from_box, ACBindings.Position* from_pos, ACBindings.Position* to_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BBox, ACBindings.BBox*, ACBindings.Position*, ACBindings.Position*, void>)0x005B2F10)(ref this, from_box, from_pos, to_pos);
    // void __thiscall BBox::LocalToGlobal(BBox*,const BBox*,const Position*,const Position*)
    public void LocalToGlobal(ACBindings.BBox* from_box, ACBindings.Position* from_pos, ACBindings.Position* to_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BBox, ACBindings.BBox*, ACBindings.Position*, ACBindings.Position*, void>)0x005B31D0)(ref this, from_box, from_pos, to_pos);
    // void __thiscall BBox::ConvertToGlobal(BBox*,const Position*)
    public void ConvertToGlobal(ACBindings.Position* i_rcOriginPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BBox, ACBindings.Position*, void>)0x005B3490)(ref this, i_rcOriginPos);
    // Vector3* __thiscall BBox::GetCenter(BBox*,Vector3*)
    public ACBindings.Vector3* GetCenter(ACBindings.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BBox, ACBindings.Vector3*, ACBindings.Vector3*>)0x005B3840)(ref this, result);
}

