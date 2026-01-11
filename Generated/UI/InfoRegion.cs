namespace ACBindings.Internal;

public unsafe struct InfoRegion : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler

    // Child Types
    public unsafe struct InfoRegion_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityRemoved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, void> InfoRegion_dtor_8; // function pointer
        public System.IntPtr GetLabel;
        public System.IntPtr GetTooltip;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, ACBindings.Internal.StatType> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, uint> GetStat; // function pointer
        public fixed byte gap1C[8];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, byte> Update; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, ACBindings.Internal.CACQualities*, int> GetVitaeModifier; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, uint, byte> SetState; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.StatType m_StatType;
    public ACBindings.Internal.UIElement* m_pElement;
    public ACBindings.Internal.UIElement_Text* m_pLabelText;
    public ACBindings.Internal.UIElement_Text* m_pValueText;

    // Generated Constructor
    public InfoRegion(ACBindings.Internal.UIElement_ListBox* a2, int here, int i_id, ACBindings.Internal.StatType a5, int a6, uint a7) {
        _ConstructorInternal(a2, here, i_id, a5, a6, a7);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F1B00
    /// void __thiscall InfoRegion::~InfoRegion(InfoRegion*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, void>)0x004F1B00)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F1B30
    /// int __thiscall InfoRegion::GetVitaeModifier(Spell*,Enchantment*)</code>
    /// </summary>
    public int GetVitaeModifier(ACBindings.Internal.Enchantment* e) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, ACBindings.Internal.Enchantment*, int>)0x004F1B30)(ref this, e);

    /// <summary>
    /// <code>Offset: 0x004F1B40
    /// void __thiscall InfoRegion::OnQualityRemoved(InfoRegion*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public void OnQualityRemoved(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004F1B40)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x004F1B70
    /// bool __thiscall InfoRegion::SetState(InfoRegion*,unsigned int)</code>
    /// </summary>
    public byte SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, uint, byte>)0x004F1B70)(ref this, state);

    /// <summary>
    /// <code>Offset: 0x004F1CF0
    /// void __thiscall InfoRegion::SetID(InfoRegion*,int)</code>
    /// </summary>
    public void SetID(int i_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, int, void>)0x004F1CF0)(ref this, i_id);

    /// <summary>
    /// <code>Offset: 0x004F20B0
    /// InfoRegion* __thiscall InfoRegion::InfoRegion(InfoRegion*,UIElement_ListBox*,int,int,StatType,int,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.InfoRegion* _ConstructorInternal(ACBindings.Internal.UIElement_ListBox* a2, int here, int i_id, ACBindings.Internal.StatType a5, int a6, uint a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, ACBindings.Internal.UIElement_ListBox*, int, int, ACBindings.Internal.StatType, int, uint, ACBindings.Internal.InfoRegion*>)0x004F20B0)(ref this, a2, here, i_id, a5, a6, a7);

    /// <summary>
    /// <code>Offset: 0x004F2940
    /// bool __thiscall InfoRegion::Update(InfoRegion*)</code>
    /// </summary>
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, byte>)0x004F2940)(ref this);
}

