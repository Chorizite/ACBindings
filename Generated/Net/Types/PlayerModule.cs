namespace ACBindings;

// PlayerModule
public unsafe struct PlayerModule : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // PlayerModule_vtbl
    public unsafe struct PlayerModule_vtbl
    {
        // Members
        public System.IntPtr PlayerModule_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public fixed byte gap14[4];
        public System.IntPtr OnChanged; // function pointer

        // Methods
    }

    // Members
    public ACBindings.ShortCutManager* shortcuts_;
    public fixed byte favorite_spells__Raw[128];
    public ACBindings.PackableList__uint* favorite_spells_ => (ACBindings.PackableList__uint*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref favorite_spells__Raw[0]);
    public System.IntPtr desired_comps_;
    public uint options_;
    public uint options2_;
    public uint spell_filters_;
    public ACBindings.GenericQualitiesData* m_pPlayerOptionsData;
    public ACBindings.PackObjPropertyCollection m_colGameplayOptions;
    public ACBindings.AC1Legacy.PStringBase__sbyte m_TimeStampFormat;

    // Generated Constructor
    public PlayerModule() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall PlayerModule::GetSpellbookFilters(PlayerModule*)
    public uint GetSpellbookFilters() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, uint>)0x00401DB0)(ref this);
    // bool __thiscall PlayerModule::AddShortCut(PlayerModule*,const ShortCutData*)
    public byte AddShortCut(ACBindings.ShortCutData* scData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, ACBindings.ShortCutData*, byte>)0x005D39A0)(ref this, scData);
    // void __thiscall PlayerModule::RemoveShortCut(PlayerModule*,const int)
    public void RemoveShortCut(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, int, void>)0x005D39E0)(ref this, index);
    // int __thiscall PlayerModule::GetFavoriteSpellsList(void*,int)
    public int GetFavoriteSpellsList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, int, int>)0x005D39F0)(ref this, a2);
    // void __thiscall PlayerModule::ClearDesiredCompList(PlayerModule*)
    public void ClearDesiredCompList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, void>)0x005D3A00)(ref this);
    // bool __thiscall PlayerModule::AllowGive(PlayerModule*)
    public byte AllowGive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3A20)(ref this);
    // bool __thiscall PlayerModule::GetDefaultOptionValue(PlayerModule*,PlayerOption)
    public byte GetDefaultOptionValue(ACBindings.PlayerOption po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, ACBindings.PlayerOption, byte>)0x005D3A30)(ref this, po);
    // bool __thiscall PlayerModule::AutoRepeatAttack(PlayerModule*)
    public byte AutoRepeatAttack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3A90)(ref this);
    // void __thiscall PlayerModule::SetAutoRepeatAttack(PlayerModule*,const bool)
    public void SetAutoRepeatAttack(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3AA0)(ref this, on);
    // bool __thiscall PlayerModule::IgnoreAllegianceRequests(PlayerModule*)
    public byte IgnoreAllegianceRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3AE0)(ref this);
    // void __thiscall PlayerModule::SetIgnoreAllegianceRequests(PlayerModule*,const bool)
    public void SetIgnoreAllegianceRequests(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3AF0)(ref this, on);
    // bool __thiscall PlayerModule::IgnoreFellowshipRequests(PlayerModule*)
    public byte IgnoreFellowshipRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3B30)(ref this);
    // void __thiscall PlayerModule::SetIgnoreFellowshipRequests(PlayerModule*,const bool)
    public void SetIgnoreFellowshipRequests(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3B40)(ref this, on);
    // bool __thiscall PlayerModule::IgnoreTradeRequests(PlayerModule*)
    public byte IgnoreTradeRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3B80)(ref this);
    // void __thiscall PlayerModule::SetIgnoreTradeRequests(PlayerModule*,bool)
    public void SetIgnoreTradeRequests(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3B90)(ref this, on);
    // bool __thiscall PlayerModule::DisableMostWeatherEffects(PlayerModule*)
    public byte DisableMostWeatherEffects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3BD0)(ref this);
    // void __thiscall PlayerModule::SetDisableMostWeatherEffects(PlayerModule*,const bool)
    public void SetDisableMostWeatherEffects(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3BE0)(ref this, on);
    // bool __thiscall PlayerModule::PersistentAtDay(PlayerModule*)
    public byte PersistentAtDay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3C20)(ref this);
    // void __thiscall PlayerModule::SetPersistentAtDay(PlayerModule*,const bool)
    public void SetPersistentAtDay(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3C30)(ref this, on);
    // void __thiscall PlayerModule::SetAllowGive(PlayerModule*,const bool)
    public void SetAllowGive(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3C70)(ref this, on);
    // bool __thiscall PlayerModule::ViewCombatTarget(PlayerModule*)
    public byte ViewCombatTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3CB0)(ref this);
    // void __thiscall PlayerModule::SetViewCombatTarget(PlayerModule*,const bool)
    public void SetViewCombatTarget(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3CC0)(ref this, on);
    // bool __thiscall PlayerModule::ShowTooltips(PlayerModule*)
    public byte ShowTooltips() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3D00)(ref this);
    // void __thiscall PlayerModule::SetShowTooltips(PlayerModule*,const bool)
    public void SetShowTooltips(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3D10)(ref this, on);
    // bool __thiscall PlayerModule::UseDeception(PlayerModule*)
    public byte UseDeception() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3D50)(ref this);
    // void __thiscall PlayerModule::SetUseDeception(PlayerModule*,const bool)
    public void SetUseDeception(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3D60)(ref this, on);
    // bool __thiscall PlayerModule::ToggleRun(PlayerModule*)
    public byte ToggleRun() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3DA0)(ref this);
    // void __thiscall PlayerModule::SetToggleRun(PlayerModule*,const bool)
    public void SetToggleRun(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3DB0)(ref this, on);
    // bool __thiscall PlayerModule::StayInChatMode(PlayerModule*)
    public byte StayInChatMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3DF0)(ref this);
    // void __thiscall PlayerModule::SetStayInChatMode(PlayerModule*,const bool)
    public void SetStayInChatMode(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3E00)(ref this, on);
    // bool __thiscall PlayerModule::AdvancedCombatUI(PlayerModule*)
    public byte AdvancedCombatUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3E40)(ref this);
    // void __thiscall PlayerModule::SetAdvancedCombatUI(PlayerModule*,const bool)
    public void SetAdvancedCombatUI(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3E50)(ref this, on);
    // bool __thiscall PlayerModule::AutoTarget(PlayerModule*)
    public byte AutoTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3E90)(ref this);
    // void __thiscall PlayerModule::SetAutoTarget(PlayerModule*,const bool)
    public void SetAutoTarget(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3EA0)(ref this, on);
    // bool __thiscall PlayerModule::VividTargetingIndicator(PlayerModule*)
    public byte VividTargetingIndicator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3EE0)(ref this);
    // void __thiscall PlayerModule::SetVividTargetingIndicator(PlayerModule*,const bool)
    public void SetVividTargetingIndicator(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3EF0)(ref this, on);
    // bool __thiscall PlayerModule::FellowshipShareXP(PlayerModule*)
    public byte FellowshipShareXP() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3F30)(ref this);
    // void __thiscall PlayerModule::SetFellowshipShareXP(PlayerModule*,const bool)
    public void SetFellowshipShareXP(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3F40)(ref this, on);
    // bool __thiscall PlayerModule::AcceptLootPermits(PlayerModule*)
    public byte AcceptLootPermits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3F80)(ref this);
    // void __thiscall PlayerModule::SetAcceptLootPermits(PlayerModule*,const bool)
    public void SetAcceptLootPermits(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3F90)(ref this, on);
    // bool __thiscall PlayerModule::FellowshipShareLoot(PlayerModule*)
    public byte FellowshipShareLoot() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D3FD0)(ref this);
    // void __thiscall PlayerModule::SetFellowshipShareLoot(PlayerModule*,const bool)
    public void SetFellowshipShareLoot(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D3FE0)(ref this, on);
    // bool __thiscall PlayerModule::FellowshipAutoAcceptRequests(PlayerModule*)
    public byte FellowshipAutoAcceptRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4020)(ref this);
    // void __thiscall PlayerModule::SetFellowshipAutoAcceptRequests(PlayerModule*,const bool)
    public void SetFellowshipAutoAcceptRequests(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4030)(ref this, on);
    // bool __thiscall PlayerModule::SideBySideVitals(PlayerModule*)
    public byte SideBySideVitals() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4070)(ref this);
    // void __thiscall PlayerModule::SetSideBySideVitals(PlayerModule*,const bool)
    public void SetSideBySideVitals(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4080)(ref this, on);
    // bool __thiscall PlayerModule::CoordinatesOnRadar(PlayerModule*)
    public byte CoordinatesOnRadar() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D40C0)(ref this);
    // void __thiscall PlayerModule::SetCoordinatesOnRadar(PlayerModule*,const bool)
    public void SetCoordinatesOnRadar(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D40D0)(ref this, on);
    // bool __thiscall PlayerModule::SpellDuration(PlayerModule*)
    public byte SpellDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4110)(ref this);
    // void __thiscall PlayerModule::SetSpellDuration(PlayerModule*,const bool)
    public void SetSpellDuration(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4120)(ref this, on);
    // bool __thiscall PlayerModule::DisableHouseRestrictionEffects(PlayerModule*)
    public byte DisableHouseRestrictionEffects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4160)(ref this);
    // void __thiscall PlayerModule::SetDisableHouseRestrictionEffects(PlayerModule*,const bool)
    public void SetDisableHouseRestrictionEffects(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4170)(ref this, on);
    // bool __thiscall PlayerModule::DragItemOnPlayerOpensSecureTrade(PlayerModule*)
    public byte DragItemOnPlayerOpensSecureTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D41B0)(ref this);
    // void __thiscall PlayerModule::SetDragItemOnPlayerOpensSecureTrade(PlayerModule*,const bool)
    public void SetDragItemOnPlayerOpensSecureTrade(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D41C0)(ref this, on);
    // bool __thiscall PlayerModule::DisplayAllegianceLogonNotifications(PlayerModule*)
    public byte DisplayAllegianceLogonNotifications() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4200)(ref this);
    // void __thiscall PlayerModule::SetDisplayAllegianceLogonNotifications(PlayerModule*,const bool)
    public void SetDisplayAllegianceLogonNotifications(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4210)(ref this, on);
    // bool __thiscall PlayerModule::UseChargeAttack(PlayerModule*)
    public byte UseChargeAttack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4250)(ref this);
    // void __thiscall PlayerModule::SetUseChargeAttack(PlayerModule*,const bool)
    public void SetUseChargeAttack(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4260)(ref this, on);
    // bool __thiscall PlayerModule::ShowHelm(PlayerModule*)
    public byte ShowHelm() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D42A0)(ref this);
    // void __thiscall PlayerModule::SetShowHelm(PlayerModule*,const bool)
    public void SetShowHelm(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D42B0)(ref this, on);
    // void __thiscall PlayerModule::SetShowCloak(PlayerModule*,const bool)
    public void SetShowCloak(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D42F0)(ref this, on);
    // bool __thiscall PlayerModule::LockUI(PlayerModule*)
    public byte LockUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4330)(ref this);
    // void __thiscall PlayerModule::SetLockUI(PlayerModule*,const bool)
    public void SetLockUI(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4340)(ref this, on);
    // bool __thiscall PlayerModule::UseMouseTurning(PlayerModule*)
    public byte UseMouseTurning() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4380)(ref this);
    // void __thiscall PlayerModule::SetUseMouseTurning(PlayerModule*,const bool)
    public void SetUseMouseTurning(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4390)(ref this, on);
    // bool __thiscall PlayerModule::DisableDistanceFog(PlayerModule*)
    public byte DisableDistanceFog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D43D0)(ref this);
    // void __thiscall PlayerModule::SetDisableDistanceFog(PlayerModule*,const bool)
    public void SetDisableDistanceFog(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D43E0)(ref this, on);
    // bool __thiscall PlayerModule::LeadMissileTargets(PlayerModule*)
    public byte LeadMissileTargets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4420)(ref this);
    // void __thiscall PlayerModule::SetLeadMissileTargets(PlayerModule*,const bool)
    public void SetLeadMissileTargets(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4430)(ref this, on);
    // bool __thiscall PlayerModule::UseFastMissiles(PlayerModule*)
    public byte UseFastMissiles() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4470)(ref this);
    // void __thiscall PlayerModule::SetUseFastMissiles(PlayerModule*,const bool)
    public void SetUseFastMissiles(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4480)(ref this, on);
    // bool __thiscall PlayerModule::UseCraftSuccessDialog(PlayerModule*)
    public byte UseCraftSuccessDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D44C0)(ref this);
    // void __thiscall PlayerModule::SetUseCraftSuccessDialog(PlayerModule*,const bool)
    public void SetUseCraftSuccessDialog(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D44D0)(ref this, on);
    // bool __thiscall PlayerModule::ConfirmVolatileRareUse(PlayerModule*)
    public byte ConfirmVolatileRareUse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4510)(ref this);
    // void __thiscall PlayerModule::SetConfirmVolatileRareUse(PlayerModule*,const bool)
    public void SetConfirmVolatileRareUse(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4520)(ref this, on);
    // bool __thiscall PlayerModule::HearAllegianceChat(PlayerModule*)
    public byte HearAllegianceChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4560)(ref this);
    // void __thiscall PlayerModule::SetHearAllegianceChat(PlayerModule*,const bool)
    public void SetHearAllegianceChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4570)(ref this, on);
    // bool __thiscall PlayerModule::HearGeneralChat(PlayerModule*)
    public byte HearGeneralChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D45B0)(ref this);
    // void __thiscall PlayerModule::SetHearGeneralChat(PlayerModule*,const bool)
    public void SetHearGeneralChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D45C0)(ref this, on);
    // bool __thiscall PlayerModule::HearTradeChat(PlayerModule*)
    public byte HearTradeChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4600)(ref this);
    // void __thiscall PlayerModule::SetHearTradeChat(PlayerModule*,const bool)
    public void SetHearTradeChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4610)(ref this, on);
    // bool __thiscall PlayerModule::HearLFGChat(PlayerModule*)
    public byte HearLFGChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4650)(ref this);
    // void __thiscall PlayerModule::SetHearLFGChat(PlayerModule*,const bool)
    public void SetHearLFGChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4660)(ref this, on);
    // bool __thiscall PlayerModule::HearRoleplayChat(PlayerModule*)
    public byte HearRoleplayChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D46A0)(ref this);
    // void __thiscall PlayerModule::SetHearRoleplayChat(PlayerModule*,const bool)
    public void SetHearRoleplayChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D46B0)(ref this, on);
    // bool __thiscall PlayerModule::HearSocietyChat(PlayerModule*)
    public byte HearSocietyChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D46F0)(ref this);
    // void __thiscall PlayerModule::SetHearSocietyChat(PlayerModule*,const bool)
    public void SetHearSocietyChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4700)(ref this, on);
    // void __thiscall PlayerModule::SetAppearOffline(PlayerModule*,const bool)
    public void SetAppearOffline(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4790)(ref this, on);
    // bool __thiscall PlayerModule::DisplayDateOfBirth(PlayerModule*)
    public byte DisplayDateOfBirth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D47D0)(ref this);
    // void __thiscall PlayerModule::SetDisplayDateOfBirth(PlayerModule*,const bool)
    public void SetDisplayDateOfBirth(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D47E0)(ref this, on);
    // bool __thiscall PlayerModule::DisplayAge(PlayerModule*)
    public byte DisplayAge() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4820)(ref this);
    // void __thiscall PlayerModule::SetDisplayAge(PlayerModule*,const bool)
    public void SetDisplayAge(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4830)(ref this, on);
    // bool __thiscall PlayerModule::DisplayChessRank(PlayerModule*)
    public byte DisplayChessRank() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4870)(ref this);
    // void __thiscall PlayerModule::SetDisplayChessRank(PlayerModule*,const bool)
    public void SetDisplayChessRank(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4880)(ref this, on);
    // bool __thiscall PlayerModule::DisplayFishingSkill(PlayerModule*)
    public byte DisplayFishingSkill() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D48C0)(ref this);
    // void __thiscall PlayerModule::SetDisplayFishingSkill(PlayerModule*,const bool)
    public void SetDisplayFishingSkill(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D48D0)(ref this, on);
    // bool __thiscall PlayerModule::DisplayNumberDeaths(PlayerModule*)
    public byte DisplayNumberDeaths() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4910)(ref this);
    // void __thiscall PlayerModule::SetDisplayNumberDeaths(PlayerModule*,const bool)
    public void SetDisplayNumberDeaths(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4920)(ref this, on);
    // bool __thiscall PlayerModule::DisplayNumberCharacterTitles(PlayerModule*)
    public byte DisplayNumberCharacterTitles() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4960)(ref this);
    // void __thiscall PlayerModule::SetDisplayNumberCharacterTitles(PlayerModule*,const bool)
    public void SetDisplayNumberCharacterTitles(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4970)(ref this, on);
    // bool __thiscall PlayerModule::FilterLanguage(PlayerModule*)
    public byte FilterLanguage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D49B0)(ref this);
    // void __thiscall PlayerModule::SetFilterLanguage(PlayerModule*,const bool)
    public void SetFilterLanguage(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D49C0)(ref this, on);
    // bool __thiscall PlayerModule::DisplayTimeStamps(PlayerModule*)
    public byte DisplayTimeStamps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4A00)(ref this);
    // void __thiscall PlayerModule::SetDisplayTimeStamps(PlayerModule*,const bool)
    public void SetDisplayTimeStamps(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4A10)(ref this, on);
    // bool __thiscall PlayerModule::SalvageMultiple(PlayerModule*)
    public byte SalvageMultiple() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4A50)(ref this);
    // void __thiscall PlayerModule::SetSalvageMultiple(PlayerModule*,const bool)
    public void SetSalvageMultiple(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4A60)(ref this, on);
    // bool __thiscall PlayerModule::MainPackPreferred(PlayerModule*)
    public byte MainPackPreferred() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte>)0x005D4AA0)(ref this);
    // void __thiscall PlayerModule::SetMainPackPreferred(PlayerModule*,const bool)
    public void SetMainPackPreferred(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, byte, void>)0x005D4AB0)(ref this, on);
    // bool __thiscall PlayerModule::GetOption(PlayerModule*,PlayerOption)
    public byte GetOption(ACBindings.PlayerOption po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, ACBindings.PlayerOption, byte>)0x005D4AF0)(ref this, po);
    // void __thiscall PlayerModule::SetOption(PlayerModule*,PlayerOption,bool)
    public void SetOption(ACBindings.PlayerOption po, byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, ACBindings.PlayerOption, byte, void>)0x005D4F20)(ref this, po, on);
    // void __thiscall PlayerModule::AddSpellFavorite(PlayerModule*,const unsigned int,const int,const int)
    public void AddSpellFavorite(uint spid, int index, int list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, uint, int, int, void>)0x005D5460)(ref this, spid, index, list);
    // int __thiscall PlayerModule::GetDesiredCompHashStart(_DWORD*,int)
    public int GetDesiredCompHashStart(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, int, int>)0x005D5490)(ref this, a2);
    // void*** __thiscall PlayerModule::GetDesiredCompHashEnd(_DWORD*,void***)
    public void*** GetDesiredCompHashEnd(void*** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, void***, void***>)0x005D54D0)(ref this, a2);
    // void __thiscall PlayerModule::SetPackHeader(PlayerModule*,unsigned int*)
    public void SetPackHeader(uint* bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, uint*, void>)0x005D5520)(ref this, bitfield);
    // unsigned int __thiscall PlayerModule::GetPackSize(PlayerModule*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, uint>)0x005D5580)(ref this);
    // unsigned int __thiscall PlayerModule::Pack(PlayerModule*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, void**, uint, uint>)0x005D5640)(ref this, addr, size);
    // int __thiscall PlayerModule::GetDesiredCompLevel(_DWORD*,int)
    public int GetDesiredCompLevel(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, int, int>)0x005D5850)(ref this, a2);
    // LONG __thiscall PlayerModule::SetTimeStampFormat(_DWORD*,int)
    public int SetTimeStampFormat(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, int, int>)0x005D5880)(ref this, a2);
    // void __thiscall PlayerModule::Clear(PlayerModule*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, void>)0x005D59F0)(ref this);
    // void __thiscall PlayerModule::RemoveSpellFavorite(PlayerModule*,const unsigned int,const int)
    public void RemoveSpellFavorite(uint spid, int list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, uint, int, void>)0x005D5A60)(ref this, spid, list);
    // bool __thiscall PlayerModule::SetDesiredCompLevel(_DWORD*,int,unsigned int)
    public byte SetDesiredCompLevel(int a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, int, uint, byte>)0x005D5A90)(ref this, a2, a3);
    // int __thiscall PlayerModule::UnPack(PlayerModule*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, void**, uint, int>)0x005D5B20)(ref this, addr, size);
    // bool __thiscall PlayerModule::InqOption(PlayerModule*,unsigned int,BaseProperty*)
    public byte InqOption(uint i_propName, ACBindings.BaseProperty* o_baseProp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, uint, ACBindings.BaseProperty*, byte>)0x005D5E20)(ref this, i_propName, o_baseProp);
    // void __thiscall PlayerModule::~PlayerModule(PlayerModule*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, void>)0x005D6160)(ref this);
    // void __thiscall PlayerModule::PlayerModule(PlayerModule*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, void>)0x005D6340)(ref this);
    // void __thiscall PlayerModule::SetOption(PlayerModule*,const BaseProperty*)
    public void SetOption(ACBindings.BaseProperty* i_prop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, ACBindings.BaseProperty*, void>)0x005D6410)(ref this, i_prop);
    // BaseProperty* __thiscall PlayerModule::GetChatOptionStructure(PlayerModule*,unsigned int)
    public ACBindings.BaseProperty* GetChatOptionStructure(uint i_nWhichWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, uint, ACBindings.BaseProperty*>)0x005D6450)(ref this, i_nWhichWindow);
    // bool __thiscall PlayerModule::InqChatWindowOption(PlayerModule*,unsigned int,unsigned int,BaseProperty*)
    public byte InqChatWindowOption(uint i_nWhichWindow, uint i_propName, ACBindings.BaseProperty* o_baseProp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, uint, uint, ACBindings.BaseProperty*, byte>)0x005D6690)(ref this, i_nWhichWindow, i_propName, o_baseProp);
    // bool __thiscall PlayerModule::SetChatWindowOption(PlayerModule*,unsigned int,const BaseProperty*)
    public byte SetChatWindowOption(uint i_nWhichWindow, ACBindings.BaseProperty* i_prop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerModule, uint, ACBindings.BaseProperty*, byte>)0x005D66C0)(ref this, i_nWhichWindow, i_prop);
}

