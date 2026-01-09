namespace ACBindings;

// Attribute2ndInfoRegion
public unsafe struct Attribute2ndInfoRegion
{
    // Base Classes
    public ACBindings.InfoRegion BaseClass_InfoRegion; // ACBindings.InfoRegion

    // Child Types
    // Attribute2ndInfoRegion_vtbl
    public unsafe struct Attribute2ndInfoRegion_vtbl
    {
        // Members
        public System.IntPtr OnQualityChanged; // function pointer
        public System.IntPtr OnQualityRemoved; // function pointer
        public System.IntPtr Attribute2ndInfoRegion_dtor_8; // function pointer
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
    public uint m_CurAttribute;
    public uint m_MaxAttribute;
    public byte m_bShowPercent;

    // Generated Constructor
    public Attribute2ndInfoRegion(ACBindings.UIElement_ListBox* a2, int a3, int a4, sbyte a5, uint a6, sbyte a7) {
        _ConstructorInternal(a2, a3, a4, a5, a6, a7);
    }

    // Methods
    // char __thiscall Attribute2ndInfoRegion::GetLabel(int*,void**)
    public sbyte GetLabel(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute2ndInfoRegion, void**, sbyte>)0x004F1BD0)(ref this, a2);
    // char __thiscall Attribute2ndInfoRegion::GetTooltip(int*,void**)
    public sbyte GetTooltip(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute2ndInfoRegion, void**, sbyte>)0x004F1BF0)(ref this, a2);
    // int __thiscall Attribute2ndInfoRegion::GetVitaeModifier(Attribute2ndInfoRegion*,const CACQualities*)
    public int GetVitaeModifier(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute2ndInfoRegion, ACBindings.CACQualities*, int>)0x004F1D90)(ref this, i_playerDesc);
    // int __thiscall Attribute2ndInfoRegion::Attribute2ndInfoRegion(int,UIElement_ListBox*,int,int,char,unsigned int,char)
    public int _ConstructorInternal(ACBindings.UIElement_ListBox* a2, int a3, int a4, sbyte a5, uint a6, sbyte a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute2ndInfoRegion, ACBindings.UIElement_ListBox*, int, int, sbyte, uint, sbyte, int>)0x004F22E0)(ref this, a2, a3, a4, a5, a6, a7);
    // bool __thiscall Attribute2ndInfoRegion::Update(Attribute2ndInfoRegion*,const CACQualities*)
    public byte Update(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute2ndInfoRegion, ACBindings.CACQualities*, byte>)0x004F2640)(ref this, i_playerDesc);
    // bool __thiscall Attribute2ndInfoRegion::Update(Attribute2ndInfoRegion*,const AppraisalProfile*)
    public byte Update(ACBindings.AppraisalProfile* i_prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute2ndInfoRegion, ACBindings.AppraisalProfile*, byte>)0x004F2AE0)(ref this, i_prof);
}

