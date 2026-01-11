namespace ACBindings.Internal;

public unsafe struct PlayerModule : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct PlayerModule_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PlayerModule*, void> PlayerModule_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PlayerModule*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PlayerModule*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PlayerModule*, void**, uint, int> UnPack; // function pointer
        public fixed byte gap14[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PlayerModule*, ACBindings.Internal.BaseProperty*, uint, void> OnChanged; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.ShortCutManager* shortcuts_;
    public fixed byte favorite_spells__Raw[128];
    public ACBindings.Internal.PackableList__uint* favorite_spells_ => (ACBindings.Internal.PackableList__uint*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref favorite_spells__Raw[0]);
    public System.IntPtr desired_comps_;
    public uint options_;
    public uint options2_;
    public uint spell_filters_;
    public ACBindings.Internal.GenericQualitiesData* m_pPlayerOptionsData;
    public ACBindings.Internal.PackObjPropertyCollection m_colGameplayOptions;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_TimeStampFormat;

    // Generated Constructor
    public PlayerModule() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves the player's current set of spellbook filters.
    /// <code>Offset: 0x00401DB0
    /// unsigned int __thiscall PlayerModule::GetSpellbookFilters(PlayerModule*)</code>
    /// </summary>
    /// <returns>The spell filter bitmask stored in the PlayerModule instance.</returns>
    public uint GetSpellbookFilters() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint>)0x00401DB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D39A0
    /// bool __thiscall PlayerModule::AddShortCut(PlayerModule*,const ShortCutData*)</code>
    /// </summary>
    public byte AddShortCut(ACBindings.Internal.ShortCutData* scData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, ACBindings.Internal.ShortCutData*, byte>)0x005D39A0)(ref this, scData);

    /// <summary>
    /// <code>Offset: 0x005D39E0
    /// void __thiscall PlayerModule::RemoveShortCut(PlayerModule*,const int)</code>
    /// </summary>
    public void RemoveShortCut(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, int, void>)0x005D39E0)(ref this, index);

    /// <summary>
    /// <code>Offset: 0x005D39F0
    /// int __thiscall PlayerModule::GetFavoriteSpellsList(void*,int)</code>
    /// </summary>
    public int GetFavoriteSpellsList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, int, int>)0x005D39F0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005D3A00
    /// void __thiscall PlayerModule::ClearDesiredCompList(PlayerModule*)</code>
    /// </summary>
    public void ClearDesiredCompList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void>)0x005D3A00)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3A20
    /// bool __thiscall PlayerModule::AllowGive(PlayerModule*)</code>
    /// </summary>
    public byte AllowGive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3A20)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3A30
    /// bool __thiscall PlayerModule::GetDefaultOptionValue(PlayerModule*,PlayerOption)</code>
    /// </summary>
    public byte GetDefaultOptionValue(ACBindings.Internal.PlayerOption po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, ACBindings.Internal.PlayerOption, byte>)0x005D3A30)(ref this, po);

    /// <summary>
    /// <code>Offset: 0x005D3A90
    /// bool __thiscall PlayerModule::AutoRepeatAttack(PlayerModule*)</code>
    /// </summary>
    public byte AutoRepeatAttack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3A90)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3AA0
    /// void __thiscall PlayerModule::SetAutoRepeatAttack(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetAutoRepeatAttack(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3AA0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3AE0
    /// bool __thiscall PlayerModule::IgnoreAllegianceRequests(PlayerModule*)</code>
    /// </summary>
    public byte IgnoreAllegianceRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3AE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3AF0
    /// void __thiscall PlayerModule::SetIgnoreAllegianceRequests(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetIgnoreAllegianceRequests(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3AF0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3B30
    /// bool __thiscall PlayerModule::IgnoreFellowshipRequests(PlayerModule*)</code>
    /// </summary>
    public byte IgnoreFellowshipRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3B30)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3B40
    /// void __thiscall PlayerModule::SetIgnoreFellowshipRequests(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetIgnoreFellowshipRequests(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3B40)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3B80
    /// bool __thiscall PlayerModule::IgnoreTradeRequests(PlayerModule*)</code>
    /// </summary>
    public byte IgnoreTradeRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3B80)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3B90
    /// void __thiscall PlayerModule::SetIgnoreTradeRequests(PlayerModule*,bool)</code>
    /// </summary>
    public void SetIgnoreTradeRequests(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3B90)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3BD0
    /// bool __thiscall PlayerModule::DisableMostWeatherEffects(PlayerModule*)</code>
    /// </summary>
    public byte DisableMostWeatherEffects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3BD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3BE0
    /// void __thiscall PlayerModule::SetDisableMostWeatherEffects(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetDisableMostWeatherEffects(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3BE0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3C20
    /// bool __thiscall PlayerModule::PersistentAtDay(PlayerModule*)</code>
    /// </summary>
    public byte PersistentAtDay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3C20)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3C30
    /// void __thiscall PlayerModule::SetPersistentAtDay(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetPersistentAtDay(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3C30)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3C70
    /// void __thiscall PlayerModule::SetAllowGive(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetAllowGive(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3C70)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3CB0
    /// bool __thiscall PlayerModule::ViewCombatTarget(PlayerModule*)</code>
    /// </summary>
    public byte ViewCombatTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3CB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3CC0
    /// void __thiscall PlayerModule::SetViewCombatTarget(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetViewCombatTarget(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3CC0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3D00
    /// bool __thiscall PlayerModule::ShowTooltips(PlayerModule*)</code>
    /// </summary>
    public byte ShowTooltips() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3D00)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3D10
    /// void __thiscall PlayerModule::SetShowTooltips(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetShowTooltips(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3D10)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3D50
    /// bool __thiscall PlayerModule::UseDeception(PlayerModule*)</code>
    /// </summary>
    public byte UseDeception() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3D50)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3D60
    /// void __thiscall PlayerModule::SetUseDeception(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetUseDeception(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3D60)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3DA0
    /// bool __thiscall PlayerModule::ToggleRun(PlayerModule*)</code>
    /// </summary>
    public byte ToggleRun() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3DA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3DB0
    /// void __thiscall PlayerModule::SetToggleRun(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetToggleRun(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3DB0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3DF0
    /// bool __thiscall PlayerModule::StayInChatMode(PlayerModule*)</code>
    /// </summary>
    public byte StayInChatMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3DF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3E00
    /// void __thiscall PlayerModule::SetStayInChatMode(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetStayInChatMode(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3E00)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3E40
    /// bool __thiscall PlayerModule::AdvancedCombatUI(PlayerModule*)</code>
    /// </summary>
    public byte AdvancedCombatUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3E40)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3E50
    /// void __thiscall PlayerModule::SetAdvancedCombatUI(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetAdvancedCombatUI(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3E50)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3E90
    /// bool __thiscall PlayerModule::AutoTarget(PlayerModule*)</code>
    /// </summary>
    public byte AutoTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3E90)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3EA0
    /// void __thiscall PlayerModule::SetAutoTarget(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetAutoTarget(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3EA0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3EE0
    /// bool __thiscall PlayerModule::VividTargetingIndicator(PlayerModule*)</code>
    /// </summary>
    public byte VividTargetingIndicator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3EE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3EF0
    /// void __thiscall PlayerModule::SetVividTargetingIndicator(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetVividTargetingIndicator(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3EF0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3F30
    /// bool __thiscall PlayerModule::FellowshipShareXP(PlayerModule*)</code>
    /// </summary>
    public byte FellowshipShareXP() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3F30)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3F40
    /// void __thiscall PlayerModule::SetFellowshipShareXP(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetFellowshipShareXP(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3F40)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3F80
    /// bool __thiscall PlayerModule::AcceptLootPermits(PlayerModule*)</code>
    /// </summary>
    public byte AcceptLootPermits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3F80)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3F90
    /// void __thiscall PlayerModule::SetAcceptLootPermits(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetAcceptLootPermits(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3F90)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D3FD0
    /// bool __thiscall PlayerModule::FellowshipShareLoot(PlayerModule*)</code>
    /// </summary>
    public byte FellowshipShareLoot() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3FD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3FE0
    /// void __thiscall PlayerModule::SetFellowshipShareLoot(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetFellowshipShareLoot(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3FE0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4020
    /// bool __thiscall PlayerModule::FellowshipAutoAcceptRequests(PlayerModule*)</code>
    /// </summary>
    public byte FellowshipAutoAcceptRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4020)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4030
    /// void __thiscall PlayerModule::SetFellowshipAutoAcceptRequests(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetFellowshipAutoAcceptRequests(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4030)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4070
    /// bool __thiscall PlayerModule::SideBySideVitals(PlayerModule*)</code>
    /// </summary>
    public byte SideBySideVitals() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4070)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4080
    /// void __thiscall PlayerModule::SetSideBySideVitals(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetSideBySideVitals(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4080)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D40C0
    /// bool __thiscall PlayerModule::CoordinatesOnRadar(PlayerModule*)</code>
    /// </summary>
    public byte CoordinatesOnRadar() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D40C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D40D0
    /// void __thiscall PlayerModule::SetCoordinatesOnRadar(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetCoordinatesOnRadar(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D40D0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4110
    /// bool __thiscall PlayerModule::SpellDuration(PlayerModule*)</code>
    /// </summary>
    public byte SpellDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4110)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4120
    /// void __thiscall PlayerModule::SetSpellDuration(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetSpellDuration(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4120)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4160
    /// bool __thiscall PlayerModule::DisableHouseRestrictionEffects(PlayerModule*)</code>
    /// </summary>
    public byte DisableHouseRestrictionEffects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4160)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4170
    /// void __thiscall PlayerModule::SetDisableHouseRestrictionEffects(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetDisableHouseRestrictionEffects(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4170)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D41B0
    /// bool __thiscall PlayerModule::DragItemOnPlayerOpensSecureTrade(PlayerModule*)</code>
    /// </summary>
    public byte DragItemOnPlayerOpensSecureTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D41B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D41C0
    /// void __thiscall PlayerModule::SetDragItemOnPlayerOpensSecureTrade(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetDragItemOnPlayerOpensSecureTrade(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D41C0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4200
    /// bool __thiscall PlayerModule::DisplayAllegianceLogonNotifications(PlayerModule*)</code>
    /// </summary>
    public byte DisplayAllegianceLogonNotifications() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4200)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4210
    /// void __thiscall PlayerModule::SetDisplayAllegianceLogonNotifications(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetDisplayAllegianceLogonNotifications(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4210)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4250
    /// bool __thiscall PlayerModule::UseChargeAttack(PlayerModule*)</code>
    /// </summary>
    public byte UseChargeAttack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4250)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4260
    /// void __thiscall PlayerModule::SetUseChargeAttack(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetUseChargeAttack(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4260)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D42A0
    /// bool __thiscall PlayerModule::ShowHelm(PlayerModule*)</code>
    /// </summary>
    public byte ShowHelm() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D42A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D42B0
    /// void __thiscall PlayerModule::SetShowHelm(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetShowHelm(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D42B0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D42F0
    /// void __thiscall PlayerModule::SetShowCloak(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetShowCloak(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D42F0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4330
    /// bool __thiscall PlayerModule::LockUI(PlayerModule*)</code>
    /// </summary>
    public byte LockUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4330)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4340
    /// void __thiscall PlayerModule::SetLockUI(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetLockUI(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4340)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4380
    /// bool __thiscall PlayerModule::UseMouseTurning(PlayerModule*)</code>
    /// </summary>
    public byte UseMouseTurning() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4380)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4390
    /// void __thiscall PlayerModule::SetUseMouseTurning(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetUseMouseTurning(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4390)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D43D0
    /// bool __thiscall PlayerModule::DisableDistanceFog(PlayerModule*)</code>
    /// </summary>
    public byte DisableDistanceFog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D43D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D43E0
    /// void __thiscall PlayerModule::SetDisableDistanceFog(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetDisableDistanceFog(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D43E0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4420
    /// bool __thiscall PlayerModule::LeadMissileTargets(PlayerModule*)</code>
    /// </summary>
    public byte LeadMissileTargets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4420)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4430
    /// void __thiscall PlayerModule::SetLeadMissileTargets(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetLeadMissileTargets(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4430)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4470
    /// bool __thiscall PlayerModule::UseFastMissiles(PlayerModule*)</code>
    /// </summary>
    public byte UseFastMissiles() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4470)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4480
    /// void __thiscall PlayerModule::SetUseFastMissiles(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetUseFastMissiles(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4480)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D44C0
    /// bool __thiscall PlayerModule::UseCraftSuccessDialog(PlayerModule*)</code>
    /// </summary>
    public byte UseCraftSuccessDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D44C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D44D0
    /// void __thiscall PlayerModule::SetUseCraftSuccessDialog(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetUseCraftSuccessDialog(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D44D0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4510
    /// bool __thiscall PlayerModule::ConfirmVolatileRareUse(PlayerModule*)</code>
    /// </summary>
    public byte ConfirmVolatileRareUse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4510)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4520
    /// void __thiscall PlayerModule::SetConfirmVolatileRareUse(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetConfirmVolatileRareUse(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4520)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4560
    /// bool __thiscall PlayerModule::HearAllegianceChat(PlayerModule*)</code>
    /// </summary>
    public byte HearAllegianceChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4560)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4570
    /// void __thiscall PlayerModule::SetHearAllegianceChat(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetHearAllegianceChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4570)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D45B0
    /// bool __thiscall PlayerModule::HearGeneralChat(PlayerModule*)</code>
    /// </summary>
    public byte HearGeneralChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D45B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D45C0
    /// void __thiscall PlayerModule::SetHearGeneralChat(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetHearGeneralChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D45C0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4600
    /// bool __thiscall PlayerModule::HearTradeChat(PlayerModule*)</code>
    /// </summary>
    public byte HearTradeChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4600)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4610
    /// void __thiscall PlayerModule::SetHearTradeChat(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetHearTradeChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4610)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4650
    /// bool __thiscall PlayerModule::HearLFGChat(PlayerModule*)</code>
    /// </summary>
    public byte HearLFGChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4650)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4660
    /// void __thiscall PlayerModule::SetHearLFGChat(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetHearLFGChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4660)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D46A0
    /// bool __thiscall PlayerModule::HearRoleplayChat(PlayerModule*)</code>
    /// </summary>
    public byte HearRoleplayChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D46A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D46B0
    /// void __thiscall PlayerModule::SetHearRoleplayChat(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetHearRoleplayChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D46B0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D46F0
    /// bool __thiscall PlayerModule::HearSocietyChat(PlayerModule*)</code>
    /// </summary>
    public byte HearSocietyChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D46F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4700
    /// void __thiscall PlayerModule::SetHearSocietyChat(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetHearSocietyChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4700)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4790
    /// void __thiscall PlayerModule::SetAppearOffline(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetAppearOffline(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4790)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D47D0
    /// bool __thiscall PlayerModule::DisplayDateOfBirth(PlayerModule*)</code>
    /// </summary>
    public byte DisplayDateOfBirth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D47D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D47E0
    /// void __thiscall PlayerModule::SetDisplayDateOfBirth(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetDisplayDateOfBirth(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D47E0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4820
    /// bool __thiscall PlayerModule::DisplayAge(PlayerModule*)</code>
    /// </summary>
    public byte DisplayAge() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4820)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4830
    /// void __thiscall PlayerModule::SetDisplayAge(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetDisplayAge(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4830)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4870
    /// bool __thiscall PlayerModule::DisplayChessRank(PlayerModule*)</code>
    /// </summary>
    public byte DisplayChessRank() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4870)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4880
    /// void __thiscall PlayerModule::SetDisplayChessRank(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetDisplayChessRank(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4880)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D48C0
    /// bool __thiscall PlayerModule::DisplayFishingSkill(PlayerModule*)</code>
    /// </summary>
    public byte DisplayFishingSkill() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D48C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D48D0
    /// void __thiscall PlayerModule::SetDisplayFishingSkill(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetDisplayFishingSkill(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D48D0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4910
    /// bool __thiscall PlayerModule::DisplayNumberDeaths(PlayerModule*)</code>
    /// </summary>
    public byte DisplayNumberDeaths() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4910)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4920
    /// void __thiscall PlayerModule::SetDisplayNumberDeaths(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetDisplayNumberDeaths(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4920)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4960
    /// bool __thiscall PlayerModule::DisplayNumberCharacterTitles(PlayerModule*)</code>
    /// </summary>
    public byte DisplayNumberCharacterTitles() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4960)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4970
    /// void __thiscall PlayerModule::SetDisplayNumberCharacterTitles(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetDisplayNumberCharacterTitles(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4970)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D49B0
    /// bool __thiscall PlayerModule::FilterLanguage(PlayerModule*)</code>
    /// </summary>
    public byte FilterLanguage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D49B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D49C0
    /// void __thiscall PlayerModule::SetFilterLanguage(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetFilterLanguage(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D49C0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4A00
    /// bool __thiscall PlayerModule::DisplayTimeStamps(PlayerModule*)</code>
    /// </summary>
    public byte DisplayTimeStamps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4A00)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4A10
    /// void __thiscall PlayerModule::SetDisplayTimeStamps(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetDisplayTimeStamps(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4A10)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4A50
    /// bool __thiscall PlayerModule::SalvageMultiple(PlayerModule*)</code>
    /// </summary>
    public byte SalvageMultiple() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4A50)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4A60
    /// void __thiscall PlayerModule::SetSalvageMultiple(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetSalvageMultiple(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4A60)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4AA0
    /// bool __thiscall PlayerModule::MainPackPreferred(PlayerModule*)</code>
    /// </summary>
    public byte MainPackPreferred() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4AA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D4AB0
    /// void __thiscall PlayerModule::SetMainPackPreferred(PlayerModule*,const bool)</code>
    /// </summary>
    public void SetMainPackPreferred(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4AB0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x005D4AF0
    /// bool __thiscall PlayerModule::GetOption(PlayerModule*,PlayerOption)</code>
    /// </summary>
    public byte GetOption(ACBindings.Internal.PlayerOption po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, ACBindings.Internal.PlayerOption, byte>)0x005D4AF0)(ref this, po);

    /// <summary>
    /// <code>Offset: 0x005D4F20
    /// void __thiscall PlayerModule::SetOption(PlayerModule*,PlayerOption,bool)</code>
    /// </summary>
    public void SetOption(ACBindings.Internal.PlayerOption po, byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, ACBindings.Internal.PlayerOption, byte, void>)0x005D4F20)(ref this, po, on);

    /// <summary>
    /// <code>Offset: 0x005D5460
    /// void __thiscall PlayerModule::AddSpellFavorite(PlayerModule*,const unsigned int,const int,const int)</code>
    /// </summary>
    public void AddSpellFavorite(uint spid, int index, int list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint, int, int, void>)0x005D5460)(ref this, spid, index, list);

    /// <summary>
    /// <code>Offset: 0x005D5490
    /// int __thiscall PlayerModule::GetDesiredCompHashStart(_DWORD*,int)</code>
    /// </summary>
    public int GetDesiredCompHashStart(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, int, int>)0x005D5490)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005D54D0
    /// void*** __thiscall PlayerModule::GetDesiredCompHashEnd(_DWORD*,void***)</code>
    /// </summary>
    public void*** GetDesiredCompHashEnd(void*** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void***, void***>)0x005D54D0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005D5520
    /// void __thiscall PlayerModule::SetPackHeader(PlayerModule*,unsigned int*)</code>
    /// </summary>
    public void SetPackHeader(uint* bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint*, void>)0x005D5520)(ref this, bitfield);

    /// <summary>
    /// <code>Offset: 0x005D5580
    /// unsigned int __thiscall PlayerModule::GetPackSize(PlayerModule*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint>)0x005D5580)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D5640
    /// unsigned int __thiscall PlayerModule::Pack(PlayerModule*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void**, uint, uint>)0x005D5640)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D5850
    /// int __thiscall PlayerModule::GetDesiredCompLevel(_DWORD*,int)</code>
    /// </summary>
    public int GetDesiredCompLevel(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, int, int>)0x005D5850)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005D5880
    /// LONG __thiscall PlayerModule::SetTimeStampFormat(_DWORD*,int)</code>
    /// </summary>
    public int SetTimeStampFormat(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, int, int>)0x005D5880)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005D59F0
    /// void __thiscall PlayerModule::Clear(PlayerModule*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void>)0x005D59F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D5A60
    /// void __thiscall PlayerModule::RemoveSpellFavorite(PlayerModule*,const unsigned int,const int)</code>
    /// </summary>
    public void RemoveSpellFavorite(uint spid, int list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint, int, void>)0x005D5A60)(ref this, spid, list);

    /// <summary>
    /// <code>Offset: 0x005D5A90
    /// bool __thiscall PlayerModule::SetDesiredCompLevel(_DWORD*,int,unsigned int)</code>
    /// </summary>
    public byte SetDesiredCompLevel(int a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, int, uint, byte>)0x005D5A90)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005D5B20
    /// int __thiscall PlayerModule::UnPack(PlayerModule*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void**, uint, int>)0x005D5B20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D5E20
    /// bool __thiscall PlayerModule::InqOption(PlayerModule*,unsigned int,BaseProperty*)</code>
    /// </summary>
    public byte InqOption(uint i_propName, ACBindings.Internal.BaseProperty* o_baseProp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint, ACBindings.Internal.BaseProperty*, byte>)0x005D5E20)(ref this, i_propName, o_baseProp);

    /// <summary>
    /// <code>Offset: 0x005D6160
    /// void __thiscall PlayerModule::~PlayerModule(PlayerModule*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void>)0x005D6160)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D6340
    /// void __thiscall PlayerModule::PlayerModule(PlayerModule*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void>)0x005D6340)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D6410
    /// void __thiscall PlayerModule::SetOption(PlayerModule*,const BaseProperty*)</code>
    /// </summary>
    public void SetOption(ACBindings.Internal.BaseProperty* i_prop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, ACBindings.Internal.BaseProperty*, void>)0x005D6410)(ref this, i_prop);

    /// <summary>
    /// <code>Offset: 0x005D6450
    /// BaseProperty* __thiscall PlayerModule::GetChatOptionStructure(PlayerModule*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.BaseProperty* GetChatOptionStructure(uint i_nWhichWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint, ACBindings.Internal.BaseProperty*>)0x005D6450)(ref this, i_nWhichWindow);

    /// <summary>
    /// <code>Offset: 0x005D6690
    /// bool __thiscall PlayerModule::InqChatWindowOption(PlayerModule*,unsigned int,unsigned int,BaseProperty*)</code>
    /// </summary>
    public byte InqChatWindowOption(uint i_nWhichWindow, uint i_propName, ACBindings.Internal.BaseProperty* o_baseProp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint, uint, ACBindings.Internal.BaseProperty*, byte>)0x005D6690)(ref this, i_nWhichWindow, i_propName, o_baseProp);

    /// <summary>
    /// <code>Offset: 0x005D66C0
    /// bool __thiscall PlayerModule::SetChatWindowOption(PlayerModule*,unsigned int,const BaseProperty*)</code>
    /// </summary>
    public byte SetChatWindowOption(uint i_nWhichWindow, ACBindings.Internal.BaseProperty* i_prop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint, ACBindings.Internal.BaseProperty*, byte>)0x005D66C0)(ref this, i_nWhichWindow, i_prop);
}

