namespace ACBindings.Internal;

public unsafe struct Attribute2ndInfoRegion
{
    // Base Classes
    public ACBindings.Internal.InfoRegion BaseClass_InfoRegion; // ACBindings.Internal.InfoRegion

    // Child Types
    public unsafe struct Attribute2ndInfoRegion_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityRemoved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, void> Attribute2ndInfoRegion_dtor_8; // function pointer
        public System.IntPtr GetLabel;
        public System.IntPtr GetTooltip;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, ACBindings.Internal.StatType> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, uint> GetStat; // function pointer
        public fixed byte gap1C[8];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, byte> Update; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, ACBindings.Internal.CACQualities*, int> GetVitaeModifier; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, uint, byte> SetState; // function pointer

        // Methods
    }

    // Members
    public uint m_CurAttribute;
    public uint m_MaxAttribute;
    public byte m_bShowPercent;

    // Generated Constructor
    public Attribute2ndInfoRegion(ACBindings.Internal.UIElement_ListBox* a2, int a3, int a4, sbyte a5, uint a6, sbyte a7) {
        _ConstructorInternal(a2, a3, a4, a5, a6, a7);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F1BD0
    /// char __thiscall Attribute2ndInfoRegion::GetLabel(int*,void**)</code>
    /// </summary>
    public sbyte GetLabel(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndInfoRegion, void**, sbyte>)0x004F1BD0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004F1BF0
    /// char __thiscall Attribute2ndInfoRegion::GetTooltip(int*,void**)</code>
    /// </summary>
    public sbyte GetTooltip(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndInfoRegion, void**, sbyte>)0x004F1BF0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004F1D90
    /// int __thiscall Attribute2ndInfoRegion::GetVitaeModifier(Attribute2ndInfoRegion*,const CACQualities*)</code>
    /// </summary>
    public int GetVitaeModifier(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndInfoRegion, ACBindings.Internal.CACQualities*, int>)0x004F1D90)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004F22E0
    /// int __thiscall Attribute2ndInfoRegion::Attribute2ndInfoRegion(int,UIElement_ListBox*,int,int,char,unsigned int,char)</code>
    /// </summary>
    public int _ConstructorInternal(ACBindings.Internal.UIElement_ListBox* a2, int a3, int a4, sbyte a5, uint a6, sbyte a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndInfoRegion, ACBindings.Internal.UIElement_ListBox*, int, int, sbyte, uint, sbyte, int>)0x004F22E0)(ref this, a2, a3, a4, a5, a6, a7);

    /// <summary>
    /// <code>Offset: 0x004F2640
    /// bool __thiscall Attribute2ndInfoRegion::Update(Attribute2ndInfoRegion*,const CACQualities*)</code>
    /// </summary>
    public byte Update(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndInfoRegion, ACBindings.Internal.CACQualities*, byte>)0x004F2640)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004F2AE0
    /// bool __thiscall Attribute2ndInfoRegion::Update(Attribute2ndInfoRegion*,const AppraisalProfile*)</code>
    /// </summary>
    public byte Update(ACBindings.Internal.AppraisalProfile* i_prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndInfoRegion, ACBindings.Internal.AppraisalProfile*, byte>)0x004F2AE0)(ref this, i_prof);
}

