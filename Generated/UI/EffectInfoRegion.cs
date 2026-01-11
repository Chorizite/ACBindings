namespace ACBindings.Internal;

public unsafe struct EffectInfoRegion
{
    // Base Classes
    public ACBindings.Internal.InfoRegion BaseClass_InfoRegion; // ACBindings.Internal.InfoRegion

    // Child Types
    public unsafe struct EffectInfoRegion_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityRemoved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, void> EffectInfoRegion_dtor_8; // function pointer
        public System.IntPtr GetLabel;
        public System.IntPtr GetTooltip;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, ACBindings.Internal.StatType> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, uint> GetStat; // function pointer
        public fixed byte gap1C[8];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, byte> Update; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, ACBindings.Internal.CACQualities*, int> GetVitaeModifier; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, uint, byte> SetState; // function pointer

        // Methods
    }

    // Members
    public uint m_Spell;

    // Generated Constructor
    public EffectInfoRegion(ACBindings.Internal.UIElement_ListBox* i_pParent, int i_internalID, uint i_spell, byte i_bRegisterForUpdates) {
        _ConstructorInternal(i_pParent, i_internalID, i_spell, i_bRegisterForUpdates);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F2860
    /// bool __thiscall EffectInfoRegion::Update(EffectInfoRegion*,long double)</code>
    /// </summary>
    public byte Update(double duration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EffectInfoRegion, double, byte>)0x004F2860)(ref this, duration);

    /// <summary>
    /// <code>Offset: 0x004F2FF0
    /// long double __thiscall EffectInfoRegion::GetDuration(EffectInfoRegion*,const CACQualities*)</code>
    /// </summary>
    public double GetDuration(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EffectInfoRegion, ACBindings.Internal.CACQualities*, double>)0x004F2FF0)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004F30A0
    /// char __thiscall EffectInfoRegion::GetLabel(unsigned int*,wchar_t**)</code>
    /// </summary>
    public sbyte GetLabel(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EffectInfoRegion, System.IntPtr, sbyte>)0x004F30A0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004F3160
    /// bool __thiscall EffectInfoRegion::Update(EffectInfoRegion*,const CACQualities*)</code>
    /// </summary>
    public byte Update(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EffectInfoRegion, ACBindings.Internal.CACQualities*, byte>)0x004F3160)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004F31C0
    /// void __thiscall EffectInfoRegion::EffectInfoRegion(EffectInfoRegion*,UIElement_ListBox*,int,unsigned int,bool)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.UIElement_ListBox* i_pParent, int i_internalID, uint i_spell, byte i_bRegisterForUpdates) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EffectInfoRegion, ACBindings.Internal.UIElement_ListBox*, int, uint, byte, void>)0x004F31C0)(ref this, i_pParent, i_internalID, i_spell, i_bRegisterForUpdates);
}

