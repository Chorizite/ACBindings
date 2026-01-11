namespace ACBindings.Internal;

public unsafe struct AttributeInfoRegion
{
    // Base Classes
    public ACBindings.Internal.InfoRegion BaseClass_InfoRegion; // ACBindings.Internal.InfoRegion

    // Child Types
    public unsafe struct AttributeInfoRegion_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityRemoved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, void> AttributeInfoRegion_dtor_8; // function pointer
        public System.IntPtr GetLabel;
        public System.IntPtr GetTooltip;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, ACBindings.Internal.StatType> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, uint> GetStat; // function pointer
        public fixed byte gap1C[8];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, byte> Update; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, ACBindings.Internal.CACQualities*, int> GetVitaeModifier; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, uint, byte> SetState; // function pointer

        // Methods
    }

    // Members
    public uint m_Attribute;

    // Generated Constructor
    public AttributeInfoRegion(ACBindings.Internal.UIElement_ListBox* a2, int a3, int a4, uint a5, sbyte a6) {
        _ConstructorInternal(a2, a3, a4, a5, a6);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F1B90
    /// char __thiscall AttributeInfoRegion::GetLabel(int*,void**)</code>
    /// </summary>
    public sbyte GetLabel(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeInfoRegion, void**, sbyte>)0x004F1B90)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004F1BB0
    /// char __thiscall AttributeInfoRegion::GetTooltip(int*,void**)</code>
    /// </summary>
    public sbyte GetTooltip(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeInfoRegion, void**, sbyte>)0x004F1BB0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004F2190
    /// int __thiscall AttributeInfoRegion::AttributeInfoRegion(int,UIElement_ListBox*,int,int,unsigned int,char)</code>
    /// </summary>
    public int _ConstructorInternal(ACBindings.Internal.UIElement_ListBox* a2, int a3, int a4, uint a5, sbyte a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeInfoRegion, ACBindings.Internal.UIElement_ListBox*, int, int, uint, sbyte, int>)0x004F2190)(ref this, a2, a3, a4, a5, a6);

    /// <summary>
    /// <code>Offset: 0x004F2570
    /// bool __thiscall AttributeInfoRegion::Update(AttributeInfoRegion*,const CACQualities*)</code>
    /// </summary>
    public byte Update(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeInfoRegion, ACBindings.Internal.CACQualities*, byte>)0x004F2570)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004F29F0
    /// bool __thiscall AttributeInfoRegion::Update(AttributeInfoRegion*,const AppraisalProfile*)</code>
    /// </summary>
    public byte Update(ACBindings.Internal.AppraisalProfile* i_prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeInfoRegion, ACBindings.Internal.AppraisalProfile*, byte>)0x004F29F0)(ref this, i_prof);
}

