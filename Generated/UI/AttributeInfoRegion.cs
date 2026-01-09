namespace ACBindings;

// AttributeInfoRegion
public unsafe struct AttributeInfoRegion
{
    // Base Classes
    public ACBindings.InfoRegion BaseClass_InfoRegion; // ACBindings.InfoRegion

    // Child Types
    // AttributeInfoRegion_vtbl
    public unsafe struct AttributeInfoRegion_vtbl
    {
        // Members
        public System.IntPtr OnQualityChanged; // function pointer
        public System.IntPtr OnQualityRemoved; // function pointer
        public System.IntPtr AttributeInfoRegion_dtor_8; // function pointer
        public System.IntPtr GetLabel;
        public System.IntPtr GetTooltip;
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetStat; // function pointer
        public fixed byte gap1C[8];
        public System.IntPtr Update; // function pointer
        public System.IntPtr GetVitaeModifier; // function pointer
        public System.IntPtr SetState; // function pointer

        // Methods
    }

    // Members
    public uint m_Attribute;

    // Generated Constructor
    public AttributeInfoRegion(ACBindings.UIElement_ListBox* a2, int a3, int a4, uint a5, sbyte a6) {
        _ConstructorInternal(a2, a3, a4, a5, a6);
    }

    // Methods
    // char __thiscall AttributeInfoRegion::GetLabel(int*,void**)
    public sbyte GetLabel(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeInfoRegion, void**, sbyte>)0x004F1B90)(ref this, a2);
    // char __thiscall AttributeInfoRegion::GetTooltip(int*,void**)
    public sbyte GetTooltip(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeInfoRegion, void**, sbyte>)0x004F1BB0)(ref this, a2);
    // int __thiscall AttributeInfoRegion::AttributeInfoRegion(int,UIElement_ListBox*,int,int,unsigned int,char)
    public int _ConstructorInternal(ACBindings.UIElement_ListBox* a2, int a3, int a4, uint a5, sbyte a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeInfoRegion, ACBindings.UIElement_ListBox*, int, int, uint, sbyte, int>)0x004F2190)(ref this, a2, a3, a4, a5, a6);
    // bool __thiscall AttributeInfoRegion::Update(AttributeInfoRegion*,const CACQualities*)
    public byte Update(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeInfoRegion, ACBindings.CACQualities*, byte>)0x004F2570)(ref this, i_playerDesc);
    // bool __thiscall AttributeInfoRegion::Update(AttributeInfoRegion*,const AppraisalProfile*)
    public byte Update(ACBindings.AppraisalProfile* i_prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeInfoRegion, ACBindings.AppraisalProfile*, byte>)0x004F29F0)(ref this, i_prof);
}

