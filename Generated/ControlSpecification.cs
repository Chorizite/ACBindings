namespace ACBindings.Internal;

public unsafe struct ControlSpecification
{
    // Members
    public ACBindings.Internal._E8DC79759AA0AA4C5121FAB9DA332741 ___u0;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0068B220
    /// void __thiscall ControlSpecification::Serialize(ControlSpecification*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlSpecification, ACBindings.Internal.Archive*, void>)0x0068B220)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0068BB80
    /// bool __thiscall ControlSpecification::ToFileNode(ControlSpecification*,PFileNode*,DeviceType)</code>
    /// </summary>
    public byte ToFileNode(ACBindings.Internal.PFileNode* i_pNode, ACBindings.Internal.DeviceType i_dt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlSpecification, ACBindings.Internal.PFileNode*, ACBindings.Internal.DeviceType, byte>)0x0068BB80)(ref this, i_pNode, i_dt);

    /// <summary>
    /// <code>Offset: 0x0068BCB0
    /// PStringBase&lt;char&gt;* __thiscall ControlSpecification::GetDIKName(unsigned __int16*,PStringBase&lt;char&gt;*)</code>
    /// </summary>
    public ACBindings.Internal.PStringBase__sbyte* GetDIKName(ACBindings.Internal.PStringBase__sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlSpecification, ACBindings.Internal.PStringBase__sbyte*, ACBindings.Internal.PStringBase__sbyte*>)0x0068BCB0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0068C2B0
    /// bool __thiscall ControlSpecification::FromFileNode(ControlSpecification*,const PFileNode*)</code>
    /// </summary>
    public byte FromFileNode(ACBindings.Internal.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlSpecification, ACBindings.Internal.PFileNode*, byte>)0x0068C2B0)(ref this, i_pNode);
}

