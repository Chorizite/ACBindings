namespace ACBindings.Internal;


/// <summary>
/// Holds a player's configuration, including shortcuts, favorite spells, desired component levels, UI flags, and gameplay options; provides serialization support for persistence.
/// </summary>
public unsafe struct PlayerModule : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct PlayerModule_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PlayerModule*, void> PlayerModule_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PlayerModule*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PlayerModule*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PlayerModule*, void**, uint, int> UnPack; // function pointer
        public fixed byte gap14[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PlayerModule*, ACBindings.Internal.BaseProperty*, uint, void> OnChanged; // function pointer

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

    /// <summary>Ensures a shortcut manager exists and forwards scData to it, adding a new shortcut.
    /// <code>Offset: 0x005D39A0
    /// bool __thiscall PlayerModule::AddShortCut(PlayerModule*,const ShortCutData*)</code>
    /// </summary>
    /// <param name="scData">The shortcut data to register, including index, object ID, and spell ID.</param>
    /// <returns>True if the shortcut was successfully added; otherwise false.</returns>
    public byte AddShortCut(ACBindings.Internal.ShortCutData* scData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, ACBindings.Internal.ShortCutData*, byte>)0x005D39A0)(ref this, scData);

    /// <summary>Removes a shortcut at the specified index from the player's shortcut collection, if the shortcuts manager exists.
    /// <code>Offset: 0x005D39E0
    /// void __thiscall PlayerModule::RemoveShortCut(PlayerModule*,const int)</code>
    /// </summary>
    /// <param name="index">Zero‑based position of the shortcut to remove.</param>
    public void RemoveShortCut(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, int, void>)0x005D39E0)(ref this, index);

    /// <summary>Retrieves the address of one of the player's favorite spell lists.
    /// <code>Offset: 0x005D39F0
    /// int __thiscall PlayerModule::GetFavoriteSpellsList(void*,int)</code>
    /// </summary>
    /// <param name="a2">Index (0-7) of the desired list.</param>
    /// <returns>Integer value representing the memory address of the selected PackableList&lt;unsigned long&gt;.</returns>
    public int GetFavoriteSpellsList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, int, int>)0x005D39F0)(ref this, a2);

    /// <summary>Clears the desired component list by invoking its cleanup callback and resetting the internal storage.
    /// <code>Offset: 0x005D3A00
    /// void __thiscall PlayerModule::ClearDesiredCompList(PlayerModule*)</code>
    /// </summary>
    public void ClearDesiredCompList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void>)0x005D3A00)(ref this);

    /// <summary>Determines whether the player is allowed to give items based on an internal option flag.
    /// <code>Offset: 0x005D3A20
    /// bool __thiscall PlayerModule::AllowGive(PlayerModule*)</code>
    /// </summary>
    /// <returns>True when the give‑permission bit (bit 6 of options_) is set; otherwise, false.</returns>
    public byte AllowGive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3A20)(ref this);

    /// <summary>Returns the default enabled state for the given player option. For a predefined set of options, the default is true; all other options default to false.
    /// <code>Offset: 0x005D3A30
    /// bool __thiscall PlayerModule::GetDefaultOptionValue(PlayerModule*,PlayerOption)</code>
    /// </summary>
    /// <param name="po">The PlayerOption whose default value should be retrieved.</param>
    /// <returns>True if the option defaults to enabled; otherwise, false.</returns>
    public byte GetDefaultOptionValue(ACBindings.Internal.PlayerOption po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, ACBindings.Internal.PlayerOption, byte>)0x005D3A30)(ref this, po);

    /// <summary>Returns whether the player has auto‑repeat attack enabled.
    /// <code>Offset: 0x005D3A90
    /// bool __thiscall PlayerModule::AutoRepeatAttack(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if bit 1 of options_ is set; otherwise false.</returns>
    public byte AutoRepeatAttack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3A90)(ref this);

    /// <summary>Enables or disables the player’s auto‑repeat attack mode based on the supplied flag.
    /// <code>Offset: 0x005D3AA0
    /// void __thiscall PlayerModule::SetAutoRepeatAttack(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to turn auto‑repeat attack on; false to turn it off.</param>
    public void SetAutoRepeatAttack(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3AA0)(ref this, on);

    /// <summary>Returns whether the player has chosen to ignore allegiance requests.
    /// <code>Offset: 0x005D3AE0
    /// bool __thiscall PlayerModule::IgnoreAllegianceRequests(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the ignore flag is set; otherwise false.</returns>
    public byte IgnoreAllegianceRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3AE0)(ref this);

    /// <summary>Sets the player's preference for ignoring allegiance requests.
    /// <code>Offset: 0x005D3AF0
    /// void __thiscall PlayerModule::SetIgnoreAllegianceRequests(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">If true, the player will ignore such requests; if false, they may be accepted.</param>
    public void SetIgnoreAllegianceRequests(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3AF0)(ref this, on);

    /// <summary>Indicates whether the player has chosen to ignore fellowship requests.
    /// <code>Offset: 0x005D3B30
    /// bool __thiscall PlayerModule::IgnoreFellowshipRequests(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if fellowship requests are ignored; otherwise false.</returns>
    public byte IgnoreFellowshipRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3B30)(ref this);

    /// <summary>Enables or disables ignoring fellowship requests by setting the corresponding option flag.
    /// <code>Offset: 0x005D3B40
    /// void __thiscall PlayerModule::SetIgnoreFellowshipRequests(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to ignore future fellowship requests; false to allow them again.</param>
    public void SetIgnoreFellowshipRequests(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3B40)(ref this, on);

    /// <summary>Determines whether the player has enabled the ignore-trade-requests setting.
    /// <code>Offset: 0x005D3B80
    /// bool __thiscall PlayerModule::IgnoreTradeRequests(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the corresponding option bit is set; otherwise, false.</returns>
    public byte IgnoreTradeRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3B80)(ref this);

    /// <summary>Enables or disables the player’s trade request ignore flag, updating internal options and notifying the base class if the state changes.
    /// <code>Offset: 0x005D3B90
    /// void __thiscall PlayerModule::SetIgnoreTradeRequests(PlayerModule*,bool)</code>
    /// </summary>
    /// <param name="on">True to enable ignoring trade requests; false to disable.</param>
    public void SetIgnoreTradeRequests(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3B90)(ref this, on);

    /// <summary>Checks whether the player has disabled most weather effects based on stored options.
    /// <code>Offset: 0x005D3BD0
    /// bool __thiscall PlayerModule::DisableMostWeatherEffects(PlayerModule*)</code>
    /// </summary>
    /// <returns>True when the disable flag is set; otherwise false.</returns>
    public byte DisableMostWeatherEffects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3BD0)(ref this);

    /// <summary>Configures the player module to enable or disable most weather effects.
    /// <code>Offset: 0x005D3BE0
    /// void __thiscall PlayerModule::SetDisableMostWeatherEffects(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to disable most weather effects; false to allow them.</param>
    public void SetDisableMostWeatherEffects(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3BE0)(ref this, on);

    /// <summary>Determines whether the player is marked as persistent during daytime gameplay.
    /// <code>Offset: 0x005D3C20
    /// bool __thiscall PlayerModule::PersistentAtDay(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the PersistentAtDay flag (bit 0 of options2_) is set; otherwise false.</returns>
    public byte PersistentAtDay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3C20)(ref this);

    /// <summary>Sets whether the player module should persist at day transitions according to the given flag.
    /// <code>Offset: 0x005D3C30
    /// void __thiscall PlayerModule::SetPersistentAtDay(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable persistent behavior; false to disable it.</param>
    public void SetPersistentAtDay(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3C30)(ref this, on);

    /// <summary>Enables or disables the player’s ability to give items by updating the internal options flag.
    /// <code>Offset: 0x005D3C70
    /// void __thiscall PlayerModule::SetAllowGive(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to permit giving, false to forbid it.</param>
    public void SetAllowGive(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3C70)(ref this, on);

    /// <summary>Determines if the player has the view combat target option set.
    /// <code>Offset: 0x005D3CB0
    /// bool __thiscall PlayerModule::ViewCombatTarget(PlayerModule*)</code>
    /// </summary>
    /// <returns>True when the corresponding bit in options_ is enabled; otherwise, false.</returns>
    public byte ViewCombatTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3CB0)(ref this);

    /// <summary>Enables or disables the display of the combat target in the player's view based on the supplied flag.
    /// <code>Offset: 0x005D3CC0
    /// void __thiscall PlayerModule::SetViewCombatTarget(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable, false to disable.</param>
    public void SetViewCombatTarget(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3CC0)(ref this, on);

    /// <summary>Determines whether tooltips are enabled for the player module.
    /// <code>Offset: 0x005D3D00
    /// bool __thiscall PlayerModule::ShowTooltips(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if tooltips are shown; otherwise, false.</returns>
    public byte ShowTooltips() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3D00)(ref this);

    /// <summary>Enables or disables tooltip display for the player module by updating the internal options flag and triggering necessary cleanup when the state changes.
    /// <code>Offset: 0x005D3D10
    /// void __thiscall PlayerModule::SetShowTooltips(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable tooltips; false to disable them.</param>
    public void SetShowTooltips(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3D10)(ref this, on);

    /// <summary>Checks whether the player has enabled deception mode by inspecting the options flag.
    /// <code>Offset: 0x005D3D50
    /// bool __thiscall PlayerModule::UseDeception(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the deception option bit (bit 9) is set; otherwise false.</returns>
    public byte UseDeception() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3D50)(ref this);

    /// <summary>Sets whether the player uses deception, updating the internal options flag accordingly.
    /// <code>Offset: 0x005D3D60
    /// void __thiscall PlayerModule::SetUseDeception(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable deception; false to disable it.</param>
    public void SetUseDeception(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3D60)(ref this, on);

    /// <summary>Determines whether the player’s run mode is currently enabled by examining the run flag within options_.
    /// <code>Offset: 0x005D3DA0
    /// bool __thiscall PlayerModule::ToggleRun(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the run bit (bit 10) of options_ is set; otherwise false.</returns>
    public byte ToggleRun() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3DA0)(ref this);

    /// <summary>Enables or disables the player’s toggle‑run mode by setting or clearing bit 0x400 in the options field.
    /// <code>Offset: 0x005D3DB0
    /// void __thiscall PlayerModule::SetToggleRun(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable run mode; false to disable it.</param>
    public void SetToggleRun(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3DB0)(ref this, on);

    /// <summary>Indicates whether the player module is currently operating in chat mode.
    /// <code>Offset: 0x005D3DF0
    /// bool __thiscall PlayerModule::StayInChatMode(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the player is in chat mode; otherwise, false.</returns>
    public byte StayInChatMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3DF0)(ref this);

    /// <summary>Sets whether the player remains in chat mode, updating the internal options flag if the desired state differs from the current one.
    /// <code>Offset: 0x005D3E00
    /// void __thiscall PlayerModule::SetStayInChatMode(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable stay‑in‑chat mode; false to disable it.</param>
    public void SetStayInChatMode(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3E00)(ref this, on);

    /// <summary>Determines whether the advanced combat user interface is enabled for the player.
    /// <code>Offset: 0x005D3E40
    /// bool __thiscall PlayerModule::AdvancedCombatUI(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if bit 12 of the player's options flag is set; otherwise, false.</returns>
    public byte AdvancedCombatUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3E40)(ref this);

    /// <summary>Enables or disables the advanced combat UI by setting or clearing bit 0x1000 in the module's options field.
    /// <code>Offset: 0x005D3E50
    /// void __thiscall PlayerModule::SetAdvancedCombatUI(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable the UI, false to disable it.</param>
    public void SetAdvancedCombatUI(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3E50)(ref this, on);

    /// <summary>Returns true if auto‑targeting is enabled in the player's options; otherwise false.
    /// <code>Offset: 0x005D3E90
    /// bool __thiscall PlayerModule::AutoTarget(PlayerModule*)</code>
    /// </summary>
    /// <returns>A boolean value indicating whether auto‑targeting is active for this player module.</returns>
    public byte AutoTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3E90)(ref this);

    /// <summary>Enables or disables automatic targeting for the player by updating the options flag accordingly.
    /// <code>Offset: 0x005D3EA0
    /// void __thiscall PlayerModule::SetAutoTarget(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable auto‑targeting; false to disable it.</param>
    public void SetAutoTarget(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3EA0)(ref this, on);

    /// <summary>Determines whether the player has the vivid targeting indicator enabled.
    /// <code>Offset: 0x005D3EE0
    /// bool __thiscall PlayerModule::VividTargetingIndicator(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if option bit 15 in options_ is set; otherwise, false.</returns>
    public byte VividTargetingIndicator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3EE0)(ref this);

    /// <summary>Enables or disables the vivid targeting indicator for this player module.
    /// <code>Offset: 0x005D3EF0
    /// void __thiscall PlayerModule::SetVividTargetingIndicator(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable, false to disable the indicator.</param>
    public void SetVividTargetingIndicator(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3EF0)(ref this, on);

    /// <summary>Determines whether experience points are shared among fellowship members.
    /// <code>Offset: 0x005D3F30
    /// bool __thiscall PlayerModule::FellowshipShareXP(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the fellowship share XP flag (bit 18 of options_) is set; otherwise, false.</returns>
    public byte FellowshipShareXP() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3F30)(ref this);

    /// <summary>Toggles the option for sharing experience points with fellowship members.
    /// <code>Offset: 0x005D3F40
    /// void __thiscall PlayerModule::SetFellowshipShareXP(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">If true, enables XP sharing; if false, disables it.</param>
    public void SetFellowshipShareXP(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3F40)(ref this, on);

    /// <summary>Determines whether the player has enabled acceptance of loot permits.
    /// <code>Offset: 0x005D3F80
    /// bool __thiscall PlayerModule::AcceptLootPermits(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if loot permits are accepted; otherwise false.</returns>
    public byte AcceptLootPermits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3F80)(ref this);

    /// <summary>Configures whether the player accepts loot permits by modifying the internal options flag.
    /// <code>Offset: 0x005D3F90
    /// void __thiscall PlayerModule::SetAcceptLootPermits(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable loot permit acceptance; False to disable it.</param>
    public void SetAcceptLootPermits(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3F90)(ref this, on);

    /// <summary>Indicates whether the player has enabled sharing of loot within their fellowship.
    /// <code>Offset: 0x005D3FD0
    /// bool __thiscall PlayerModule::FellowshipShareLoot(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the fellowship share‑loot option is set; otherwise, false.</returns>
    public byte FellowshipShareLoot() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D3FD0)(ref this);

    /// <summary>Sets whether the player’s fellowship shares loot among its members.
    /// <code>Offset: 0x005D3FE0
    /// void __thiscall PlayerModule::SetFellowshipShareLoot(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">If true, enables sharing; if false, disables it.</param>
    public void SetFellowshipShareLoot(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D3FE0)(ref this, on);

    /// <summary>Determines whether the player has enabled automatic acceptance of fellowship requests.
    /// <code>Offset: 0x005D4020
    /// bool __thiscall PlayerModule::FellowshipAutoAcceptRequests(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the auto‑accept flag is set; otherwise false.</returns>
    public byte FellowshipAutoAcceptRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4020)(ref this);

    /// <summary>Enables or disables automatic acceptance of fellowship requests by setting the corresponding option flag.
    /// <code>Offset: 0x005D4030
    /// void __thiscall PlayerModule::SetFellowshipAutoAcceptRequests(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable auto‑accept; false to disable.</param>
    public void SetFellowshipAutoAcceptRequests(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4030)(ref this, on);

    /// <summary>Checks whether the side‑by‑side vitals display option is enabled.
    /// <code>Offset: 0x005D4070
    /// bool __thiscall PlayerModule::SideBySideVitals(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if bit 21 of options_ is set, otherwise false.</returns>
    public byte SideBySideVitals() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4070)(ref this);

    /// <summary>Enables or disables the side‑by‑side vitals display for the player.
    /// <code>Offset: 0x005D4080
    /// void __thiscall PlayerModule::SetSideBySideVitals(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable, false to disable.</param>
    public void SetSideBySideVitals(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4080)(ref this, on);

    /// <summary>Determines whether the player’s current position is displayed on the radar.
    /// <code>Offset: 0x005D40C0
    /// bool __thiscall PlayerModule::CoordinatesOnRadar(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the coordinate display flag is enabled; otherwise, false.</returns>
    public byte CoordinatesOnRadar() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D40C0)(ref this);

    /// <summary>Enables or disables player coordinates on the radar.
    /// <code>Offset: 0x005D40D0
    /// void __thiscall PlayerModule::SetCoordinatesOnRadar(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to display coordinates, false to hide them.</param>
    public void SetCoordinatesOnRadar(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D40D0)(ref this, on);

    /// <summary>Checks whether the spell duration option (bit 23 of options_) is enabled for this player module.
    /// <code>Offset: 0x005D4110
    /// bool __thiscall PlayerModule::SpellDuration(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the flag is set; otherwise, false.</returns>
    public byte SpellDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4110)(ref this);

    /// <summary>Enables or disables spell duration tracking for the player based on the supplied flag, updating internal options and performing necessary cleanup when the state changes.
    /// <code>Offset: 0x005D4120
    /// void __thiscall PlayerModule::SetSpellDuration(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="this">The PlayerModule instance to modify.</param>
    /// <param name="on">Desired state of the spell duration option; true enables it, false disables it.</param>
    public void SetSpellDuration(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4120)(ref this, on);

    /// <summary>Determines whether the house restriction effects have been disabled in the player's settings.
    /// <code>Offset: 0x005D4160
    /// bool __thiscall PlayerModule::DisableHouseRestrictionEffects(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the corresponding option flag is set; otherwise, false.</returns>
    public byte DisableHouseRestrictionEffects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4160)(ref this);

    /// <summary>Toggles the player’s “disable house restriction effects” setting, updating internal options and notifying the system when the state changes.
    /// <code>Offset: 0x005D4170
    /// void __thiscall PlayerModule::SetDisableHouseRestrictionEffects(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable the option; false to disable it.</param>
    public void SetDisableHouseRestrictionEffects(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4170)(ref this, on);

    /// <summary>Determines whether dragging an item onto a player triggers opening of the secure trade window based on the current module settings.
    /// <code>Offset: 0x005D41B0
    /// bool __thiscall PlayerModule::DragItemOnPlayerOpensSecureTrade(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if bit 26 of the options field is set, indicating secure trade is enabled; otherwise false.</returns>
    public byte DragItemOnPlayerOpensSecureTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D41B0)(ref this);

    /// <summary>Enables or disables the feature that opens a secure trade interface when an item is dragged over the player character.
    /// <code>Offset: 0x005D41C0
    /// void __thiscall PlayerModule::SetDragItemOnPlayerOpensSecureTrade(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable the behavior; false to disable it.</param>
    public void SetDragItemOnPlayerOpensSecureTrade(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D41C0)(ref this, on);

    /// <summary>Determines whether allegiance logon notifications are displayed, based on an internal option flag.
    /// <code>Offset: 0x005D4200
    /// bool __thiscall PlayerModule::DisplayAllegianceLogonNotifications(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the notification display option bit is set; otherwise false.</returns>
    public byte DisplayAllegianceLogonNotifications() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4200)(ref this);

    /// <summary>Sets whether allegiance logon notifications are displayed.
    /// <code>Offset: 0x005D4210
    /// void __thiscall PlayerModule::SetDisplayAllegianceLogonNotifications(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable, false to disable.</param>
    public void SetDisplayAllegianceLogonNotifications(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4210)(ref this, on);

    /// <summary>Checks whether the charge attack option is enabled in the player module's settings.
    /// <code>Offset: 0x005D4250
    /// bool __thiscall PlayerModule::UseChargeAttack(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if bit 28 of the options_ field is set; otherwise, false.</returns>
    public byte UseChargeAttack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4250)(ref this);

    /// <summary>Toggles the use of charge attacks by setting or clearing the corresponding option flag in the player's options field.
    /// <code>Offset: 0x005D4260
    /// void __thiscall PlayerModule::SetUseChargeAttack(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable charge attack; false to disable it.</param>
    public void SetUseChargeAttack(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4260)(ref this, on);

    /// <summary>Indicates whether the player’s helm visibility flag is enabled.
    /// <code>Offset: 0x005D42A0
    /// bool __thiscall PlayerModule::ShowHelm(PlayerModule*)</code>
    /// </summary>
    /// <returns>True when the helm should be displayed; otherwise false.</returns>
    public byte ShowHelm() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D42A0)(ref this);

    /// <summary>Enables or disables the display of the player's helmet by setting the corresponding flag in options2_. If the requested state differs from the current state, updates the flag and triggers a base class change notification.
    /// <code>Offset: 0x005D42B0
    /// void __thiscall PlayerModule::SetShowHelm(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to show the helm; false to hide it.</param>
    public void SetShowHelm(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D42B0)(ref this, on);

    /// <summary>Changes the player's cloak visibility by setting or clearing the corresponding flag in the options state.
    /// <code>Offset: 0x005D42F0
    /// void __thiscall PlayerModule::SetShowCloak(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable showing the cloak; false to disable it.</param>
    public void SetShowCloak(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D42F0)(ref this, on);

    /// <summary>Determines whether the user interface is currently locked for this player module.
    /// <code>Offset: 0x005D4330
    /// bool __thiscall PlayerModule::LockUI(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the UI lock flag is set; otherwise, false.</returns>
    public byte LockUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4330)(ref this);

    /// <summary>Sets the player’s UI lock state, updating internal options and performing required cleanup when the state changes.
    /// <code>Offset: 0x005D4340
    /// void __thiscall PlayerModule::SetLockUI(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable UI locking; false to disable it.</param>
    public void SetLockUI(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4340)(ref this, on);

    /// <summary>Indicates whether the player module has mouse‑turning enabled.
    /// <code>Offset: 0x005D4380
    /// bool __thiscall PlayerModule::UseMouseTurning(PlayerModule*)</code>
    /// </summary>
    /// <returns>True when mouse turning is active; otherwise false.</returns>
    public byte UseMouseTurning() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4380)(ref this);

    /// <summary>Enables or disables mouse‑turning functionality by updating the relevant option flag.
    /// <code>Offset: 0x005D4390
    /// void __thiscall PlayerModule::SetUseMouseTurning(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to turn on mouse‑based camera rotation; false to turn it off.</param>
    public void SetUseMouseTurning(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4390)(ref this, on);

    /// <summary>Indicates whether the player's distance fog effect has been disabled.
    /// <code>Offset: 0x005D43D0
    /// bool __thiscall PlayerModule::DisableDistanceFog(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if distance fog is disabled; otherwise, false.</returns>
    public byte DisableDistanceFog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D43D0)(ref this);

    /// <summary>Sets the option controlling whether distance fog is disabled.
    /// <code>Offset: 0x005D43E0
    /// void __thiscall PlayerModule::SetDisableDistanceFog(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True disables distance fog, false enables it.</param>
    public void SetDisableDistanceFog(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D43E0)(ref this, on);

    /// <summary>Determines whether missile lead targeting is active by checking a specific flag in the module’s options field.
    /// <code>Offset: 0x005D4420
    /// bool __thiscall PlayerModule::LeadMissileTargets(PlayerModule*)</code>
    /// </summary>
    /// <returns>True when the target‑leading option bit (bit 15 of options2_) is set; otherwise false.</returns>
    public byte LeadMissileTargets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4420)(ref this);

    /// <summary>Activates or deactivates lead missile targeting for the player by updating an internal options flag.
    /// <code>Offset: 0x005D4430
    /// void __thiscall PlayerModule::SetLeadMissileTargets(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable lead missile targets; false to disable them.</param>
    public void SetLeadMissileTargets(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4430)(ref this, on);

    /// <summary>Determines whether fast missiles are enabled for this player module.
    /// <code>Offset: 0x005D4470
    /// bool __thiscall PlayerModule::UseFastMissiles(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the fast missile option flag is set; otherwise, false.</returns>
    public byte UseFastMissiles() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4470)(ref this);

    /// <summary>Sets the player's preference for using fast missiles to the specified value. If the setting differs from the current state, the internal options flag is updated and associated state is refreshed.
    /// <code>Offset: 0x005D4480
    /// void __thiscall PlayerModule::SetUseFastMissiles(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable fast missile usage; false to disable it.</param>
    public void SetUseFastMissiles(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4480)(ref this, on);

    /// <summary>Indicates whether the player has enabled the craft success dialog option.
    /// <code>Offset: 0x005D44C0
    /// bool __thiscall PlayerModule::UseCraftSuccessDialog(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the highest bit of the options field is set; otherwise, false.</returns>
    public byte UseCraftSuccessDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D44C0)(ref this);

    /// <summary>Enables or disables the crafting success dialog based on the supplied boolean.
    /// <code>Offset: 0x005D44D0
    /// void __thiscall PlayerModule::SetUseCraftSuccessDialog(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable, false to disable the crafting success dialog.</param>
    public void SetUseCraftSuccessDialog(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D44D0)(ref this, on);

    /// <summary>Determines whether the player has enabled use of volatile rare items.
    /// <code>Offset: 0x005D4510
    /// bool __thiscall PlayerModule::ConfirmVolatileRareUse(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the corresponding option flag is set; otherwise, false.</returns>
    public byte ConfirmVolatileRareUse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4510)(ref this);

    /// <summary>Configures whether the player requires confirmation before using volatile rare items.
    /// <code>Offset: 0x005D4520
    /// void __thiscall PlayerModule::SetConfirmVolatileRareUse(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable confirmation, false to disable.</param>
    public void SetConfirmVolatileRareUse(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4520)(ref this, on);

    /// <summary>Determines whether the player receives allegiance chat messages according to current settings.
    /// <code>Offset: 0x005D4560
    /// bool __thiscall PlayerModule::HearAllegianceChat(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if allegiance chat reception is enabled; otherwise false.</returns>
    public byte HearAllegianceChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4560)(ref this);

    /// <summary>Enables or disables hearing of allegiance chat messages for the player.
    /// <code>Offset: 0x005D4570
    /// void __thiscall PlayerModule::SetHearAllegianceChat(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable hearing; false to disable.</param>
    public void SetHearAllegianceChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4570)(ref this, on);

    /// <summary>Determines whether the player is currently listening to general chat based on option settings.
    /// <code>Offset: 0x005D45B0
    /// bool __thiscall PlayerModule::HearGeneralChat(PlayerModule*)</code>
    /// </summary>
    /// <returns>True when general chat is enabled; otherwise, false.</returns>
    public byte HearGeneralChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D45B0)(ref this);

    /// <summary>Enables or disables hearing of general chat messages for the player.
    /// <code>Offset: 0x005D45C0
    /// void __thiscall PlayerModule::SetHearGeneralChat(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable; false to disable.</param>
    public void SetHearGeneralChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D45C0)(ref this, on);

    /// <summary>Indicates whether the player has enabled hearing of trade chat messages.
    /// <code>Offset: 0x005D4600
    /// bool __thiscall PlayerModule::HearTradeChat(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the trade chat option is set; otherwise false.</returns>
    public byte HearTradeChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4600)(ref this);

    /// <summary>Enables or disables the player's ability to hear trade chat by setting the corresponding option bit.
    /// <code>Offset: 0x005D4610
    /// void __thiscall PlayerModule::SetHearTradeChat(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable hearing trade chat; false to disable.</param>
    public void SetHearTradeChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4610)(ref this, on);

    /// <summary>Returns whether the player is configured to receive LFG chat messages.
    /// <code>Offset: 0x005D4650
    /// bool __thiscall PlayerModule::HearLFGChat(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the LFG chat option (bit 10 of options2_) is set; otherwise false.</returns>
    public byte HearLFGChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4650)(ref this);

    /// <summary>Enables or disables the player’s ability to hear “Looking For Group” chat based on the supplied flag.
    /// <code>Offset: 0x005D4660
    /// void __thiscall PlayerModule::SetHearLFGChat(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable hearing of LFG chat, false to disable it.</param>
    public void SetHearLFGChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4660)(ref this, on);

    /// <summary>Determines whether the player module is configured to hear role‑play chat.
    /// <code>Offset: 0x005D46A0
    /// bool __thiscall PlayerModule::HearRoleplayChat(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if bit 11 of options2_ is set; otherwise false.</returns>
    public byte HearRoleplayChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D46A0)(ref this);

    /// <summary>Enables or disables the player's ability to hear roleplay chat by setting the corresponding option flag.
    /// <code>Offset: 0x005D46B0
    /// void __thiscall PlayerModule::SetHearRoleplayChat(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable hearing of roleplay chat, false to disable it.</param>
    public void SetHearRoleplayChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D46B0)(ref this, on);

    /// <summary>Returns whether the player is configured to receive society chat messages.
    /// <code>Offset: 0x005D46F0
    /// bool __thiscall PlayerModule::HearSocietyChat(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if society chat listening is enabled; otherwise false.</returns>
    public byte HearSocietyChat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D46F0)(ref this);

    /// <summary>Enables or disables hearing of society chat for the player by setting or clearing the corresponding options flag.
    /// <code>Offset: 0x005D4700
    /// void __thiscall PlayerModule::SetHearSocietyChat(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable hearing; false to disable.</param>
    public void SetHearSocietyChat(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4700)(ref this, on);

    /// <summary>Configures whether the player appears offline or online.
    /// <code>Offset: 0x005D4790
    /// void __thiscall PlayerModule::SetAppearOffline(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to set the player as appearing offline, false for normal online appearance.</param>
    public void SetAppearOffline(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4790)(ref this, on);

    /// <summary>Determines whether the player’s date of birth is displayed based on internal option flags.
    /// <code>Offset: 0x005D47D0
    /// bool __thiscall PlayerModule::DisplayDateOfBirth(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if display is enabled; otherwise, false.</returns>
    public byte DisplayDateOfBirth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D47D0)(ref this);

    /// <summary>Controls visibility of the player's date of birth in user interfaces.
    /// <code>Offset: 0x005D47E0
    /// void __thiscall PlayerModule::SetDisplayDateOfBirth(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable display; false to disable.</param>
    public void SetDisplayDateOfBirth(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D47E0)(ref this, on);

    /// <summary>Checks whether the age display option is enabled for the player.
    /// <code>Offset: 0x005D4820
    /// bool __thiscall PlayerModule::DisplayAge(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if bit 5 of options2_ is set; otherwise, false.</returns>
    public byte DisplayAge() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4820)(ref this);

    /// <summary>Enables or disables the display of a player's age by setting a flag in the options2_ field and triggering an update.
    /// <code>Offset: 0x005D4830
    /// void __thiscall PlayerModule::SetDisplayAge(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to show the age; false to hide it.</param>
    public void SetDisplayAge(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4830)(ref this, on);

    /// <summary>Determines whether the player's chess rank should be displayed.
    /// <code>Offset: 0x005D4870
    /// bool __thiscall PlayerModule::DisplayChessRank(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the display flag is set; otherwise, false.</returns>
    public byte DisplayChessRank() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4870)(ref this);

    /// <summary>Enables or disables displaying the player’s chess rank.
    /// <code>Offset: 0x005D4880
    /// void __thiscall PlayerModule::SetDisplayChessRank(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to show the rank; false to hide it.</param>
    public void SetDisplayChessRank(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4880)(ref this, on);

    /// <summary>Determines whether the fishing skill overlay should be displayed by examining an internal options flag.
    /// <code>Offset: 0x005D48C0
    /// bool __thiscall PlayerModule::DisplayFishingSkill(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the fishing skill display is enabled; otherwise, false.</returns>
    public byte DisplayFishingSkill() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D48C0)(ref this);

    /// <summary>Enables or disables the display of the player’s fishing skill based on the provided flag.
    /// <code>Offset: 0x005D48D0
    /// void __thiscall PlayerModule::SetDisplayFishingSkill(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">If true, activates the fishing skill display; if false, hides it.</param>
    public void SetDisplayFishingSkill(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D48D0)(ref this, on);

    /// <summary>Indicates whether the player’s number of deaths should be displayed.
    /// <code>Offset: 0x005D4910
    /// bool __thiscall PlayerModule::DisplayNumberDeaths(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the death‑count display option is enabled; otherwise false.</returns>
    public byte DisplayNumberDeaths() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4910)(ref this);

    /// <summary>Enables or disables the death count display for the player, updating internal option flags when the state changes.
    /// <code>Offset: 0x005D4920
    /// void __thiscall PlayerModule::SetDisplayNumberDeaths(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to show deaths; false to hide them.</param>
    public void SetDisplayNumberDeaths(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4920)(ref this, on);

    /// <summary>Determines whether numbered character titles are enabled for this player module.
    /// <code>Offset: 0x005D4960
    /// bool __thiscall PlayerModule::DisplayNumberCharacterTitles(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if bit 13 of the options2_ field is set; otherwise, false.</returns>
    public byte DisplayNumberCharacterTitles() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4960)(ref this);

    /// <summary>Enables or disables the numeric character title display by setting the appropriate flag in the module’s options.
    /// <code>Offset: 0x005D4970
    /// void __thiscall PlayerModule::SetDisplayNumberCharacterTitles(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">If true, numbered titles are displayed; if false, they are hidden.</param>
    public void SetDisplayNumberCharacterTitles(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4970)(ref this, on);

    /// <summary>Determines whether the language filter option is active by checking bit 17 of the options2_ flag.
    /// <code>Offset: 0x005D49B0
    /// bool __thiscall PlayerModule::FilterLanguage(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if the language filter is enabled; otherwise, false.</returns>
    public byte FilterLanguage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D49B0)(ref this);

    /// <summary>Enables or disables the player’s language filter by setting the corresponding flag in the module's options. If the new state differs from the current one, updates options and triggers necessary cleanup.
    /// <code>Offset: 0x005D49C0
    /// void __thiscall PlayerModule::SetFilterLanguage(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable the language filter; false to disable it.</param>
    public void SetFilterLanguage(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D49C0)(ref this, on);

    /// <summary>Evaluates whether the player’s timestamp display setting is active.
    /// <code>Offset: 0x005D4A00
    /// bool __thiscall PlayerModule::DisplayTimeStamps(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if timestamp display is enabled; otherwise false.</returns>
    public byte DisplayTimeStamps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4A00)(ref this);

    /// <summary>Enables or disables timestamp display for the player module, updating internal flags and notifying relevant systems when the state changes.
    /// <code>Offset: 0x005D4A10
    /// void __thiscall PlayerModule::SetDisplayTimeStamps(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable timestamps; false to disable them.</param>
    public void SetDisplayTimeStamps(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4A10)(ref this, on);

    /// <summary>Indicates whether the player can salvage multiple items at once.
    /// <code>Offset: 0x005D4A50
    /// bool __thiscall PlayerModule::SalvageMultiple(PlayerModule*)</code>
    /// </summary>
    /// <returns>True if multiple salvaging is permitted; otherwise false.</returns>
    public byte SalvageMultiple() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4A50)(ref this);

    /// <summary>Updates the salvage multiple setting in the player module by toggling the corresponding option bit if needed.
    /// <code>Offset: 0x005D4A60
    /// void __thiscall PlayerModule::SetSalvageMultiple(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to enable salvage multiple; false to disable it.</param>
    public void SetSalvageMultiple(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4A60)(ref this, on);

    /// <summary>Determines whether the main pack option is selected based on internal flags.
    /// <code>Offset: 0x005D4AA0
    /// bool __thiscall PlayerModule::MainPackPreferred(PlayerModule*)</code>
    /// </summary>
    /// <returns>True when bit 14 of options2_ is set; otherwise false.</returns>
    public byte MainPackPreferred() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte>)0x005D4AA0)(ref this);

    /// <summary>Sets the player’s main pack preference by enabling or disabling a specific option flag.
    /// <code>Offset: 0x005D4AB0
    /// void __thiscall PlayerModule::SetMainPackPreferred(PlayerModule*,const bool)</code>
    /// </summary>
    /// <param name="on">True to mark the main pack as preferred; false to clear the preference.</param>
    public void SetMainPackPreferred(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, byte, void>)0x005D4AB0)(ref this, on);

    /// <summary>Checks whether a specific player option flag is enabled and returns true if so.
    /// <code>Offset: 0x005D4AF0
    /// bool __thiscall PlayerModule::GetOption(PlayerModule*,PlayerOption)</code>
    /// </summary>
    /// <param name="po">The player option enumeration value whose status should be queried.</param>
    /// <returns>True when the requested option bit is set; otherwise false.</returns>
    public byte GetOption(ACBindings.Internal.PlayerOption po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, ACBindings.Internal.PlayerOption, byte>)0x005D4AF0)(ref this, po);

    /// <summary>Enables or disables a specified player option, delegating to the appropriate handler for each option value.
    /// <code>Offset: 0x005D4F20
    /// void __thiscall PlayerModule::SetOption(PlayerModule*,PlayerOption,bool)</code>
    /// </summary>
    /// <param name="this">Reference to the PlayerModule instance whose setting is modified.</param>
    /// <param name="po">The option identifier from the PlayerOption enumeration.</param>
    /// <param name="on">True to enable the option; false to disable it.</param>
    public void SetOption(ACBindings.Internal.PlayerOption po, byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, ACBindings.Internal.PlayerOption, byte, void>)0x005D4F20)(ref this, po, on);

    /// <summary>Adds a spell ID to one of the player's favorite spell lists at the specified position.
    /// <code>Offset: 0x005D5460
    /// void __thiscall PlayerModule::AddSpellFavorite(PlayerModule*,const unsigned int,const int,const int)</code>
    /// </summary>
    /// <param name="spid">The unique identifier of the spell to add.</param>
    /// <param name="index">Zero‑based index within the list where the spell should be inserted.</param>
    /// <param name="list">Index (0–7) selecting which favorites list to modify.</param>
    public void AddSpellFavorite(uint spid, int index, int list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint, int, int, void>)0x005D5460)(ref this, spid, index, list);

    /// <summary>Initializes an iterator over the player's desired component hash table, writing iterator data to the supplied buffer and returning that pointer.
    /// <code>Offset: 0x005D5490
    /// int __thiscall PlayerModule::GetDesiredCompHashStart(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Memory location where iterator state will be stored; must accommodate a PackableHashIterator structure.</param>
    /// <returns>The address passed in as ‘a2’, now containing an initialized iterator (empty if no desired components exist).</returns>
    public int GetDesiredCompHashStart(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, int, int>)0x005D5490)(ref this, a2);

    /// <summary>Provides the end iterator for the player's desired component hash table.
    /// <code>Offset: 0x005D54D0
    /// void*** __thiscall PlayerModule::GetDesiredCompHashEnd(_DWORD*,void***)</code>
    /// </summary>
    /// <param name="a2">Array of four void pointers used to store the iterator state:
    /// - index 0 receives a pointer to the iterator’s vtable.
    /// - index 1 is always set to null.
    /// - index 2 holds the hash table’s second field when a table exists; otherwise null.
    /// - index 3 holds the hash table’s first field when a table exists; otherwise null.</param>
    /// <returns>Pointer to the iterator object—the same as the supplied buffer pointer.</returns>
    public void*** GetDesiredCompHashEnd(void*** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void***, void***>)0x005D54D0)(ref this, a2);

    /// <summary>Sets a bitmask that indicates which optional components of the player module are present.
    /// <code>Offset: 0x005D5520
    /// void __thiscall PlayerModule::SetPackHeader(PlayerModule*,unsigned int*)</code>
    /// </summary>
    /// <param name="bitfield">A pointer to an unsigned int into which flags for available components are written.</param>
    public void SetPackHeader(uint* bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint*, void>)0x005D5520)(ref this, bitfield);

    /// <summary>Computes the total serialized byte size of a player's module data, including shortcuts, favorite spell lists, desired components, player options, and gameplay option properties, rounded up to the nearest 4‑byte boundary.
    /// <code>Offset: 0x005D5580
    /// unsigned int __thiscall PlayerModule::GetPackSize(PlayerModule*)</code>
    /// </summary>
    /// <returns>The aligned size in bytes needed to pack the PlayerModule instance.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint>)0x005D5580)(ref this);

    /// <summary>Packs the player module's state into a supplied memory buffer, including options, shortcuts, favorite spells, desired components, spell filters, gameplay properties, and alignment padding.
    /// <code>Offset: 0x005D5640
    /// unsigned int __thiscall PlayerModule::Pack(PlayerModule*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; updated to point past the last byte written as data is packed.</param>
    /// <param name="size">Size of the available space in bytes; must be at least the value returned by GetPackSize() for packing to succeed.</param>
    /// <returns>The total number of bytes required for the packed representation (the same as GetPackSize()). If the supplied buffer is smaller, no data is written and this value is still returned.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void**, uint, uint>)0x005D5640)(ref this, addr, size);

    /// <summary>Retrieves the desired component level for a given component ID from the module's lookup table; returns zero when the ID is not present.
    /// <code>Offset: 0x005D5850
    /// int __thiscall PlayerModule::GetDesiredCompLevel(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Component identifier to query.</param>
    /// <returns>The desired component level, or 0 if no entry exists.</returns>
    public int GetDesiredCompLevel(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, int, int>)0x005D5850)(ref this, a2);

    /// <summary>Sets the timestamp format string used by the player module to the specified format object.
    /// <code>Offset: 0x005D5880
    /// LONG __thiscall PlayerModule::SetTimeStampFormat(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">The new format string object; must not be null. The method updates reference counts and stores the string internally.</param>
    /// <returns>The remaining reference count of the supplied format string after decrementing, or zero if the object was released.</returns>
    public int SetTimeStampFormat(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, int, int>)0x005D5880)(ref this, a2);

    /// <summary>Releases all dynamic resources owned by the player module, including shortcuts, desired components, and gameplay options. Resets related pointers to null and clears internal collections.
    /// <code>Offset: 0x005D59F0
    /// void __thiscall PlayerModule::Clear(PlayerModule*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void>)0x005D59F0)(ref this);

    /// <summary>Removes a spell ID from one of the player’s favorite spell lists when the list index is valid.
    /// <code>Offset: 0x005D5A60
    /// void __thiscall PlayerModule::RemoveSpellFavorite(PlayerModule*,const unsigned int,const int)</code>
    /// </summary>
    /// <param name="spid">The identifier of the spell to remove.</param>
    /// <param name="list">Index (0‑7) of the favorites list from which to delete the spell.</param>
    public void RemoveSpellFavorite(uint spid, int list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint, int, void>)0x005D5A60)(ref this, spid, list);

    /// <summary>Sets the desired level for a component identified by <paramref name="a2"/>. If no entry exists it is created; otherwise the existing value is updated.
    /// <code>Offset: 0x005D5A90
    /// bool __thiscall PlayerModule::SetDesiredCompLevel(_DWORD*,int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The identifier of the component whose desired level should be set.</param>
    /// <param name="a3">The desired level to assign (must not exceed 0x1388).</param>
    /// <returns>True if the level was stored or updated successfully; otherwise false when the level exceeds the allowed maximum or memory allocation fails.</returns>
    public byte SetDesiredCompLevel(int a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, int, uint, byte>)0x005D5A90)(ref this, a2, a3);

    /// <summary>Deserializes a PlayerModule from a binary buffer, updating internal state and advancing the read pointer.
    /// <code>Offset: 0x005D5B20
    /// int __thiscall PlayerModule::UnPack(PlayerModule*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer that points to the current read position in the buffer; advanced as data is consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer available for unpacking.</param>
    /// <returns>1 if the unpack succeeded, 0 otherwise (e.g., insufficient data).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void**, uint, int>)0x005D5B20)(ref this, addr, size);

    /// <summary>Retrieves a gameplay option identified by i_propName and stores its details in the supplied BaseProperty structure.
    /// <code>Offset: 0x005D5E20
    /// bool __thiscall PlayerModule::InqOption(PlayerModule*,unsigned int,BaseProperty*)</code>
    /// </summary>
    /// <param name="i_propName">Identifier of the property to query.</param>
    /// <param name="o_baseProp">Pointer to a BaseProperty that receives the retrieved property data.</param>
    /// <returns>True if the specified option was found and populated; otherwise false.</returns>
    public byte InqOption(uint i_propName, ACBindings.Internal.BaseProperty* o_baseProp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint, ACBindings.Internal.BaseProperty*, byte>)0x005D5E20)(ref this, i_propName, o_baseProp);

    /// <summary>Destructs the PlayerModule, freeing resources such as its time‑stamp format buffer, gameplay option collection, and component lists, while resetting virtual tables to default state.
    /// <code>Offset: 0x005D6160
    /// void __thiscall PlayerModule::~PlayerModule(PlayerModule*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void>)0x005D6160)(ref this);

    /// <summary>Creates a player module instance with default configuration, initializing shortcut manager to null, setting up eight empty favorite spell lists, and configuring gameplay option collections.
    /// <code>Offset: 0x005D6340
    /// void __thiscall PlayerModule::PlayerModule(PlayerModule*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, void>)0x005D6340)(ref this);

    /// <summary>Assigns the specified gameplay option to the player module by storing its property name and associated data in the options collection, then triggers any necessary update logic.
    /// <code>Offset: 0x005D6410
    /// void __thiscall PlayerModule::SetOption(PlayerModule*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="i_prop">Property that defines the option to set; contains both a descriptor and a value.</param>
    public void SetOption(ACBindings.Internal.BaseProperty* i_prop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, ACBindings.Internal.BaseProperty*, void>)0x005D6410)(ref this, i_prop);

    /// <summary>Retrieves the BaseProperty for a specified chat window from the module’s gameplay options, creating the property if it does not yet exist.
    /// <code>Offset: 0x005D6450
    /// BaseProperty* __thiscall PlayerModule::GetChatOptionStructure(PlayerModule*,unsigned int)</code>
    /// </summary>
    /// <param name="i_nWhichWindow">The 1‑based index of the chat window whose option structure is requested.</param>
    /// <returns>A pointer to the BaseProperty containing the chat options for that window, or null if the index is out of range.</returns>
    public ACBindings.Internal.BaseProperty* GetChatOptionStructure(uint i_nWhichWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint, ACBindings.Internal.BaseProperty*>)0x005D6450)(ref this, i_nWhichWindow);

    /// <summary>Retrieves an option value from a specified chat window and writes it into the supplied BaseProperty.
    /// <code>Offset: 0x005D6690
    /// bool __thiscall PlayerModule::InqChatWindowOption(PlayerModule*,unsigned int,unsigned int,BaseProperty*)</code>
    /// </summary>
    /// <param name="i_nWhichWindow">Index of the chat window to query.</param>
    /// <param name="i_propName">Identifier of the property to retrieve.</param>
    /// <param name="o_baseProp">Destination property structure that will receive the retrieved value.</param>
    /// <returns>True if the option was found and written; otherwise false.</returns>
    public byte InqChatWindowOption(uint i_nWhichWindow, uint i_propName, ACBindings.Internal.BaseProperty* o_baseProp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint, uint, ACBindings.Internal.BaseProperty*, byte>)0x005D6690)(ref this, i_nWhichWindow, i_propName, o_baseProp);

    /// <summary>Sets a chat window option using the provided property data for the specified window index, updating its stored value and notifying the module on success.
    /// <code>Offset: 0x005D66C0
    /// bool __thiscall PlayerModule::SetChatWindowOption(PlayerModule*,unsigned int,const BaseProperty*)</code>
    /// </summary>
    /// <param name="i_nWhichWindow">Index of the chat window whose option should be set.</param>
    /// <param name="i_prop">Property object containing the new option value to apply.</param>
    /// <returns>True if the option was successfully updated; false if no matching option exists or the update fails.</returns>
    public byte SetChatWindowOption(uint i_nWhichWindow, ACBindings.Internal.BaseProperty* i_prop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerModule, uint, ACBindings.Internal.BaseProperty*, byte>)0x005D66C0)(ref this, i_nWhichWindow, i_prop);
}

