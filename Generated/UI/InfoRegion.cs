namespace ACBindings;

// InfoRegion
public unsafe struct InfoRegion : System.IDisposable
{
    // Base Classes
    public ACBindings.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.QualityChangeHandler

    // Child Types
    // InfoRegion_vtbl
    public unsafe struct InfoRegion_vtbl
    {
        // Members
        public System.IntPtr OnQualityChanged; // function pointer
        public System.IntPtr OnQualityRemoved; // function pointer
        public System.IntPtr InfoRegion_dtor_8; // function pointer
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
    public ACBindings.StatType m_StatType;
    public ACBindings.UIElement* m_pElement;
    public ACBindings.UIElement_Text* m_pLabelText;
    public ACBindings.UIElement_Text* m_pValueText;

    // Generated Constructor
    public InfoRegion(ACBindings.UIElement_ListBox* a2, int here, int i_id, ACBindings.StatType a5, int a6, uint a7) {
        _ConstructorInternal(a2, here, i_id, a5, a6, a7);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall InfoRegion::~InfoRegion(InfoRegion*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InfoRegion, void>)0x004F1B00)(ref this);
    // int __thiscall InfoRegion::GetVitaeModifier(Spell*,Enchantment*)
    public int GetVitaeModifier(ACBindings.Enchantment* e) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InfoRegion, ACBindings.Enchantment*, int>)0x004F1B30)(ref this, e);
    // void __thiscall InfoRegion::OnQualityRemoved(InfoRegion*,CWeenieObject*,StatType,unsigned int)
    public void OnQualityRemoved(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InfoRegion, ACBindings.CWeenieObject*, ACBindings.StatType, uint, void>)0x004F1B40)(ref this, cwobj, stype, senum);
    // bool __thiscall InfoRegion::SetState(InfoRegion*,unsigned int)
    public byte SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InfoRegion, uint, byte>)0x004F1B70)(ref this, state);
    // void __thiscall InfoRegion::SetID(InfoRegion*,int)
    public void SetID(int i_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InfoRegion, int, void>)0x004F1CF0)(ref this, i_id);
    // InfoRegion* __thiscall InfoRegion::InfoRegion(InfoRegion*,UIElement_ListBox*,int,int,StatType,int,unsigned int)
    public ACBindings.InfoRegion* _ConstructorInternal(ACBindings.UIElement_ListBox* a2, int here, int i_id, ACBindings.StatType a5, int a6, uint a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InfoRegion, ACBindings.UIElement_ListBox*, int, int, ACBindings.StatType, int, uint, ACBindings.InfoRegion*>)0x004F20B0)(ref this, a2, here, i_id, a5, a6, a7);
    // bool __thiscall InfoRegion::Update(InfoRegion*)
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InfoRegion, byte>)0x004F2940)(ref this);
}

