namespace ACBindings.Internal;


/// <summary>Provides the user interface for active magical effects, handling list display, spell selection, duration updates and rebuilding when the player’s enchantments change.</summary>
public unsafe struct gmEffectsUI
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmEffectsUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_Text* m_pInfoText;
    public ACBindings.Internal.UIElement_ListBox* m_pListBox;
    public ACBindings.Internal.SmartArray___EffectInfoRegion_ptr m_rgTokens;
    public uint m_effectsUIType;
    public double m_nextDurationUpdate;
    public uint m_SelectedSpell;
    public byte m_bNeedToRebuild;

    // Methods

    /// <summary>Initializes the effects UI component after construction by locating child elements such as info text and list box, registering global event handlers for relevant notices, and updating internal state based on action callbacks.
    /// <code>Offset: 0x004B8180
    /// void __thiscall gmEffectsUI::PostInit(gmEffectsUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, void>)0x004B8180)(ref this);

    /// <summary>Refreshes the durations of all active effect regions using the current player qualities and schedules the next update for one second later.
    /// <code>Offset: 0x004B8290
    /// bool __thiscall gmEffectsUI::UpdateDurations(gmEffectsUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Describes the player's current qualities, used to notify each effect region of any changes.</param>
    /// <returns>Always true, indicating the update completed successfully.</returns>
    public byte UpdateDurations(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.CACQualities*, byte>)0x004B8290)(ref this, i_playerDesc);

    /// <summary>Checks whether a spell identified by <c>i_spellID</c> satisfies the UI’s effect‑type filter based on its internal flag.
    /// <code>Offset: 0x004B82E0
    /// bool __thiscall gmEffectsUI::SpellEffectMatchesUIType(gmEffectsUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_spellID">The identifier of the spell to evaluate.</param>
    /// <returns>True if the spell’s flag matches the UI’s current type setting (1 for flagged spells, 2 for unflagged); otherwise false. Returns false when the magic system is unavailable or the spell cannot be found.</returns>
    public byte SpellEffectMatchesUIType(uint i_spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, uint, byte>)0x004B82E0)(ref this, i_spellID);

    /// <summary>Casts a gmEffectsUI instance to the requested UIElement type according to the supplied type identifier.
    /// <code>Offset: 0x004B8470
    /// UIElement* __thiscall gmEffectsUI::DynamicCast(gmEffectsUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The numeric type identifier indicating which UIElement subclass should be returned.</param>
    /// <returns>Pointer to the gmEffectsUI or its base UIElement representation when the identifier matches; otherwise null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, uint, ACBindings.Internal.UIElement*>)0x004B8470)(ref this, i_eType);

    /// <summary>Registers the gmEffectsUI type with the UI system, associating a unique identifier and a creation callback for layout instantiation.
    /// <code>Offset: 0x004B84C0
    /// void __cdecl gmEffectsUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004B84C0)();

    /// <summary>Determines the zero‑based position at which a given spell should be inserted into the effects UI list to maintain alphabetical ordering by spell name.
    /// <code>Offset: 0x004B84E0
    /// unsigned int __thiscall gmEffectsUI::GetSortedInsertionPlace(gmEffectsUI*,CSpellBase*)</code>
    /// </summary>
    /// <param name="spellBase">The spell whose insertion point is being calculated.</param>
    /// <returns>The index within m_pListBox where the spell should be inserted; returns the current item count if it belongs after all existing spells.</returns>
    public uint GetSortedInsertionPlace(ACBindings.Internal.CSpellBase* spellBase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.CSpellBase*, uint>)0x004B84E0)(ref this, spellBase);

    /// <summary>Refreshes effect durations for the current player by obtaining the player's description and delegating to the internal UpdateDurations routine.
    /// <code>Offset: 0x004B87D0
    /// bool __thiscall gmEffectsUI::UpdateDurations(gmEffectsUI*)</code>
    /// </summary>
    /// <returns>True if the update succeeded; otherwise, false.</returns>
    public byte UpdateDurations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, byte>)0x004B87D0)(ref this);

    /// <summary>Clears the effects UI list box and resets stored effect tokens without deallocating them.
    /// <code>Offset: 0x004B8880
    /// bool __thiscall gmEffectsUI::FlushList(gmEffectsUI*)</code>
    /// </summary>
    /// <returns>True, indicating that the flush completed successfully.</returns>
    public byte FlushList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, byte>)0x004B8880)(ref this);

    /// <summary>Handles global messages for the effects UI, triggering a duration refresh when a duration‑update message is received and the update timer has elapsed.
    /// <code>Offset: 0x004B8B60
    /// void __thiscall gmEffectsUI::ListenToGlobalMessage(gmEffectsUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the global message received.</param>
    /// <param name="i_data_int">Additional integer data associated with the message (unused in this implementation).</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, uint, int, void>)0x004B8B60)(ref this, i_messageID, i_data_int);

    /// <summary>Updates the effects list UI by refreshing token quality states and setting the info text based on the currently selected spell. If no spell is selected, prompts the user; otherwise shows the spell’s name and description.
    /// <code>Offset: 0x004B8BB0
    /// bool __thiscall gmEffectsUI::UpdateSelection(gmEffectsUI*)</code>
    /// </summary>
    /// <returns>True if the update succeeded; false when the magic system cannot be obtained.</returns>
    public byte UpdateSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, byte>)0x004B8BB0)(ref this);

    /// <summary>Selects a spell corresponding to the given UI element, updates internal state and invokes any associated callbacks.
    /// <code>Offset: 0x004B8EB0
    /// bool __thiscall gmEffectsUI::SetSelectedSpell(gmEffectsUI*,UIElement*)</code>
    /// </summary>
    /// <param name="selectedUI">The UIElement representing the chosen spell; may be null to clear the selection.</param>
    /// <returns>True if the selection update succeeded; otherwise false.</returns>
    public byte SetSelectedSpell(ACBindings.Internal.UIElement* selectedUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.UIElement*, byte>)0x004B8EB0)(ref this, selectedUI);

    /// <summary>Rebuilds the effect list shown in the UI from a player's active enchantments. Filters entries to match the UI type, inserts them sorted by spell base, updates display and selection state.
    /// <code>Offset: 0x004B8F70
    /// bool __thiscall gmEffectsUI::RebuildList(gmEffectsUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">The player descriptor containing current enchantments.</param>
    /// <returns>True if the list was successfully rebuilt; false if no enchantments were found or an error occurred.</returns>
    public byte RebuildList(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.CACQualities*, byte>)0x004B8F70)(ref this, i_playerDesc);

    /// <summary>Updates the effects user interface by rebuilding the list of active effects or refreshing their remaining durations, but only when the UI is currently enabled.
    /// <code>Offset: 0x004B9150
    /// bool __thiscall gmEffectsUI::Update(gmEffectsUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">The player’s quality data used to determine which effects are active and how long they last.</param>
    /// <returns>True if the UI was updated; false if it was not active.</returns>
    public byte Update(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.CACQualities*, byte>)0x004B9150)(ref this, i_playerDesc);

    /// <summary>Handles a player description receipt notification by updating or rebuilding the effects list UI based on current state.
    /// <code>Offset: 0x004B9190
    /// void __thiscall gmEffectsUI::RecvNotice_PlayerDescReceived(gmEffectsUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player quality information used to update effect durations or rebuild the list.</param>
    /// <param name="i_playerModule">Player module providing context for the update (currently unused).</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004B9190)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Refreshes the effects user interface to reflect the current state of the active player and its abilities.
    /// <code>Offset: 0x004B91D0
    /// bool __thiscall gmEffectsUI::Update(gmEffectsUI*)</code>
    /// </summary>
    /// <returns>True if the UI was successfully updated; otherwise false, typically when no valid player data is available or the interface is hidden.</returns>
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, byte>)0x004B91D0)(ref this);

    /// <summary>Responds to element messages within the effects UI, managing global input listeners and updating the selected spell based on list box interactions. Handles message IDs 24 (registration) and 28 (selection).
    /// <code>Offset: 0x004B9280
    /// UIElementMessageListenResult __thiscall gmEffectsUI::ListenToElementMessage(gmEffectsUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmEffectsUI instance.</param>
    /// <param name="i_rMsg">Message information for an element event.</param>
    /// <returns>Result of base class message handling, indicating whether the message was consumed.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004B9280)(ref this, i_rMsg);

    /// <summary>Refreshes the enchantments display when changes occur, ensuring UI elements reflect the updated list of active effects.
    /// <code>Offset: 0x004B9300
    /// void __thiscall gmEffectsUI::RecvNotice_EnchantmentsChanged(gmEffectsUI*)</code>
    /// </summary>
    public void RecvNotice_EnchantmentsChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, void>)0x004B9300)(ref this);

    /// <summary>Retrieves the unique identifier for the burden indicator UI element.
    /// <code>Offset: 0x004E7800
    /// unsigned int __thiscall gmEffectsUI::GetUIElementType(gmUIElement_BurdenIndicator*)</code>
    /// </summary>
    /// <returns>The unsigned integer ID that represents this UI element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEffectsUI, uint>)0x004E7800)(ref this);
}

