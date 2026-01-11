namespace ACBindings.Internal;

public unsafe struct BBox
{
    // Members
    public ACBindings.Internal.Vector3 m_vMin;
    public ACBindings.Internal.Vector3 m_vMax;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00534E90
    /// void __thiscall BBox::AdjustBBox(BBox*,const Vector3*)</code>
    /// </summary>
    public void AdjustBBox(ACBindings.Internal.Vector3* vc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BBox, ACBindings.Internal.Vector3*, void>)0x00534E90)(ref this, vc);

    /// <summary>
    /// <code>Offset: 0x005B2E20
    /// void __thiscall BBox::BuildBoundingBox(BBox*,BBox*)</code>
    /// </summary>
    public void BuildBoundingBox(ACBindings.Internal.BBox* bbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BBox, ACBindings.Internal.BBox*, void>)0x005B2E20)(ref this, bbox);

    /// <summary>
    /// <code>Offset: 0x005B2EA0
    /// void __thiscall BBox::InitForAdjustment(BBox*)</code>
    /// </summary>
    public void InitForAdjustment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BBox, void>)0x005B2EA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B2F10
    /// void __thiscall BBox::LocalToLocal(BBox*,const BBox*,const Position*,const Position*)</code>
    /// </summary>
    public void LocalToLocal(ACBindings.Internal.BBox* from_box, ACBindings.Internal.Position* from_pos, ACBindings.Internal.Position* to_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BBox, ACBindings.Internal.BBox*, ACBindings.Internal.Position*, ACBindings.Internal.Position*, void>)0x005B2F10)(ref this, from_box, from_pos, to_pos);

    /// <summary>
    /// <code>Offset: 0x005B31D0
    /// void __thiscall BBox::LocalToGlobal(BBox*,const BBox*,const Position*,const Position*)</code>
    /// </summary>
    public void LocalToGlobal(ACBindings.Internal.BBox* from_box, ACBindings.Internal.Position* from_pos, ACBindings.Internal.Position* to_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BBox, ACBindings.Internal.BBox*, ACBindings.Internal.Position*, ACBindings.Internal.Position*, void>)0x005B31D0)(ref this, from_box, from_pos, to_pos);

    /// <summary>
    /// <code>Offset: 0x005B3490
    /// void __thiscall BBox::ConvertToGlobal(BBox*,const Position*)</code>
    /// </summary>
    public void ConvertToGlobal(ACBindings.Internal.Position* i_rcOriginPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BBox, ACBindings.Internal.Position*, void>)0x005B3490)(ref this, i_rcOriginPos);

    /// <summary>
    /// <code>Offset: 0x005B3840
    /// Vector3* __thiscall BBox::GetCenter(BBox*,Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.Vector3* GetCenter(ACBindings.Internal.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BBox, ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*>)0x005B3840)(ref this, result);
}

