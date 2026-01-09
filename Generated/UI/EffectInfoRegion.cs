namespace ACBindings;

// EffectInfoRegion
public unsafe struct EffectInfoRegion
{
    // Base Classes
    public ACBindings.InfoRegion BaseClass_InfoRegion; // ACBindings.InfoRegion

    // Child Types
    // EffectInfoRegion_vtbl
    public unsafe struct EffectInfoRegion_vtbl
    {
        // Members
        public System.IntPtr OnQualityChanged; // function pointer
        public System.IntPtr OnQualityRemoved; // function pointer
        public System.IntPtr EffectInfoRegion_dtor_8; // function pointer
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
    public uint m_Spell;

    // Generated Constructor
    public EffectInfoRegion(ACBindings.UIElement_ListBox* i_pParent, int i_internalID, uint i_spell, byte i_bRegisterForUpdates) {
        _ConstructorInternal(i_pParent, i_internalID, i_spell, i_bRegisterForUpdates);
    }

    // Methods
    // bool __thiscall EffectInfoRegion::Update(EffectInfoRegion*,long double)
    public byte Update(double duration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EffectInfoRegion, double, byte>)0x004F2860)(ref this, duration);
    // long double __thiscall EffectInfoRegion::GetDuration(EffectInfoRegion*,const CACQualities*)
    public double GetDuration(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EffectInfoRegion, ACBindings.CACQualities*, double>)0x004F2FF0)(ref this, i_playerDesc);
    // char __thiscall EffectInfoRegion::GetLabel(unsigned int*,wchar_t**)
    public sbyte GetLabel(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EffectInfoRegion, System.IntPtr, sbyte>)0x004F30A0)(ref this, a2);
    // bool __thiscall EffectInfoRegion::Update(EffectInfoRegion*,const CACQualities*)
    public byte Update(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EffectInfoRegion, ACBindings.CACQualities*, byte>)0x004F3160)(ref this, i_playerDesc);
    // void __thiscall EffectInfoRegion::EffectInfoRegion(EffectInfoRegion*,UIElement_ListBox*,int,unsigned int,bool)
    public void _ConstructorInternal(ACBindings.UIElement_ListBox* i_pParent, int i_internalID, uint i_spell, byte i_bRegisterForUpdates) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EffectInfoRegion, ACBindings.UIElement_ListBox*, int, uint, byte, void>)0x004F31C0)(ref this, i_pParent, i_internalID, i_spell, i_bRegisterForUpdates);
}

