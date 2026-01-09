namespace ACBindings;

// ControlSpecification
public unsafe struct ControlSpecification
{
    // Members
    public ACBindings._E8DC79759AA0AA4C5121FAB9DA332741 ___u0;

    // Methods
    // void __thiscall ControlSpecification::Serialize(ControlSpecification*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ControlSpecification, ACBindings.Archive*, void>)0x0068B220)(ref this, io_archive);
    // bool __thiscall ControlSpecification::ToFileNode(ControlSpecification*,PFileNode*,DeviceType)
    public byte ToFileNode(ACBindings.PFileNode* i_pNode, ACBindings.DeviceType i_dt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ControlSpecification, ACBindings.PFileNode*, ACBindings.DeviceType, byte>)0x0068BB80)(ref this, i_pNode, i_dt);
    // PStringBase<char>* __thiscall ControlSpecification::GetDIKName(unsigned __int16*,PStringBase<char>*)
    public ACBindings.PStringBase__sbyte* GetDIKName(ACBindings.PStringBase__sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ControlSpecification, ACBindings.PStringBase__sbyte*, ACBindings.PStringBase__sbyte*>)0x0068BCB0)(ref this, a2);
    // bool __thiscall ControlSpecification::FromFileNode(ControlSpecification*,const PFileNode*)
    public byte FromFileNode(ACBindings.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ControlSpecification, ACBindings.PFileNode*, byte>)0x0068C2B0)(ref this, i_pNode);
}

