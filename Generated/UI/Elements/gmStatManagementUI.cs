namespace ACBindings.Internal;


/// <summary>Manages the character statistics user interface, coordinating display elements, reacting to player quality changes, and propagating relevant events and notices within the UI system.</summary>
public unsafe struct gmStatManagementUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler

    // Child Types
    public unsafe struct gmStatManagementUI_vtbl
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
        public fixed byte gap138[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> Update; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, byte> UpdateCharacterInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, byte> UpdatePKStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, byte> UpdateExperience; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.UIElement*, byte> SetSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> UpdateSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> RaiseSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> Raise10Selection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, uint> GetCostToRaise; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.StatType, uint, byte> MessageIsFromSelectedElement; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_Text* m_pNameText;
    public ACBindings.Internal.UIElement_Text* m_pHeritageText;
    public ACBindings.Internal.UIElement_Text* m_pPKStatusText;
    public ACBindings.Internal.UIElement_Text* m_pLevelText;
    public ACBindings.Internal.UIElement_Text* m_pTotalXPText;
    public ACBindings.Internal.UIElement_Text* m_pXPToLevelText;
    public ACBindings.Internal.UIElement_Text* m_pLuminanceLabelText;
    public ACBindings.Internal.UIElement_Text* m_pLuminanceText;
    public ACBindings.Internal.UIElement_Meter* m_pXPToLevelMeter;
    public ACBindings.Internal.UIElement_ListBox* m_pListBox;
    public ACBindings.Internal.SmartArray___InfoRegion_ptr m_rgTokens;
    public byte m_bAwaitingRaise;
    public uint m_titleID;

    // Generated Constructor
    public gmStatManagementUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Dispatches UI element messages for the stat management interface, handling button actions, focus changes, and listbox interactions based on message identifiers.
    /// <code>Offset: 0x004F0870
    /// UIElementMessageListenResult __thiscall gmStatManagementUI::ListenToElementMessage(gmStatManagementUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">Pointer to the current gmStatManagementUI instance.</param>
    /// <param name="i_rMsg">Message information containing element ID, message type, parameters, and coordinates.</param>
    /// <returns>Result of UIElement::ListenToElementMessage after processing or overridden behavior.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004F0870)(ref this, i_rMsg);

    /// <summary>Notifies registered components that a player description has been received.
    /// <code>Offset: 0x004F0980
    /// void __thiscall gmStatManagementUI::RecvNotice_PlayerDescReceived(gmStatManagementUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">The player's quality information contained in a CACQualities object.</param>
    /// <param name="i_playerModule">Additional module data for the player, typically containing metadata or state.</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004F0980)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Receives a notification that the character’s enchantments have changed and updates the UI to reflect the new state.
    /// <code>Offset: 0x004F09A0
    /// void __thiscall gmStatManagementUI::RecvNotice_EnchantmentsChanged(gmStatManagementUI*)</code>
    /// </summary>
    public void RecvNotice_EnchantmentsChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, void>)0x004F09A0)(ref this);

    /// <summary>Updates the stat management UI with a new character title table, setting the current display title and triggering a list refresh.
    /// <code>Offset: 0x004F09C0
    /// void __thiscall gmStatManagementUI::RecvNotice_UpdateCharacterTitleTable(gmStatManagementUI*,const CharacterTitleTable*)</code>
    /// </summary>
    /// <param name="i_titleTable">The character title table containing the new display title and available titles.</param>
    public void RecvNotice_UpdateCharacterTitleTable(ACBindings.Internal.CharacterTitleTable* i_titleTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CharacterTitleTable*, void>)0x004F09C0)(ref this, i_titleTable);

    /// <summary>Updates the character's displayed title in the user interface by storing the new title ID and notifying listeners.
    /// <code>Offset: 0x004F09E0
    /// void __thiscall gmStatManagementUI::RecvNotice_SetDisplayCharacterTitle(gmStatManagementUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_title">Identifier of the title to display.</param>
    public void RecvNotice_SetDisplayCharacterTitle(uint i_title) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, uint, void>)0x004F09E0)(ref this, i_title);

    /// <summary>Notifies the stat management UI that a quality change has been removed, enabling it to handle any required updates.
    /// <code>Offset: 0x004F0A00
    /// void __thiscall gmStatManagementUI::OnQualityRemoved(gmStatManagementUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="this">Instance of gmStatManagementUI receiving the notification.</param>
    /// <param name="cwobj">Game object from which the quality was removed.</param>
    /// <param name="stype">Type of stat whose quality was removed.</param>
    /// <param name="senum">Identifier for the specific quality change event.</param>
    public void OnQualityRemoved(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004F0A00)(ref this, cwobj, stype, senum);

    /// <summary>
    /// Initializes the Stat Management UI after base initialization by locating child components, assigning them to member pointers, and registering event and quality change handlers for various stat updates.
    /// 
    /// <code>Offset: 0x004F0A20
    /// void __thiscall gmStatManagementUI::PostInit(gmStatManagementUI*)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmStatManagementUI instance.</param>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, void>)0x004F0A20)(ref this);

    /// <summary>Updates the stat‑management UI when player qualities change, handling focus loss, input actions, and notifying all token regions of the new values. Returns true if the widget is active and processed, otherwise false.
    /// <code>Offset: 0x004F0CB0
    /// bool __thiscall gmStatManagementUI::Update(gmStatManagementUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player qualities used to refresh displayed information.</param>
    /// <returns>True if the update succeeded; false when the UI element is inactive.</returns>
    public byte Update(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CACQualities*, byte>)0x004F0CB0)(ref this, i_playerDesc);

    /// <summary>Updates the PK status display by querying the current WeenieObject and setting the PK status text to “PK”, “NPK” or “PKL” accordingly.
    /// <code>Offset: 0x004F0D30
    /// bool __thiscall gmStatManagementUI::UpdatePKStatus(gmStatManagementUI*,const CACQualities*)</code>
    /// </summary>
    /// <returns>True if the UI element was updated successfully; otherwise false (never occurs in current implementation).</returns>
    public byte UpdatePKStatus(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CACQualities*, byte>)0x004F0D30)(ref this, i_playerDesc);

    /// <summary>Retrieves the text element that displays the footer title for the current state of the statistics‑management interface.
    /// <code>Offset: 0x004F0E00
    /// UIElement_Text* __thiscall gmStatManagementUI::GetFooterTitleLabel(gmStatManagementUI*)</code>
    /// </summary>
    /// <returns>A pointer to the footer title label, or nullptr if the element cannot be found.</returns>
    public ACBindings.Internal.UIElement_Text* GetFooterTitleLabel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Text*>)0x004F0E00)(ref this);

    /// <summary>Retrieves the first footer line label UIElement_Text from the stat management UI based on its current state.
    /// <code>Offset: 0x004F0E50
    /// UIElement_Text* __thiscall gmStatManagementUI::GetFooterLineOneLabel(gmStatManagementUI*)</code>
    /// </summary>
    /// <returns>The UIElement_Text representing the footer line one label, or nullptr if not found.</returns>
    public ACBindings.Internal.UIElement_Text* GetFooterLineOneLabel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Text*>)0x004F0E50)(ref this);

    /// <summary>Retrieves the text element displayed in the first footer line of the stat management UI, selecting the appropriate child based on the current UI state.
    /// <code>Offset: 0x004F0EA0
    /// UIElement_Text* __thiscall gmStatManagementUI::GetFooterLineOneValue(gmStatManagementUI*)</code>
    /// </summary>
    /// <returns>A pointer to the UIElement_Text instance that holds the footer line content, or null if no matching element is available.</returns>
    public ACBindings.Internal.UIElement_Text* GetFooterLineOneValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Text*>)0x004F0EA0)(ref this);

    /// <summary>Retrieves the footer meter UI element associated with the current state of the stat management interface.
    /// <code>Offset: 0x004F0EF0
    /// UIElement_Meter* __thiscall gmStatManagementUI::GetFooterMeter(gmStatManagementUI*)</code>
    /// </summary>
    /// <returns>A pointer to the footer meter if found; otherwise, null.</returns>
    public ACBindings.Internal.UIElement_Meter* GetFooterMeter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Meter*>)0x004F0EF0)(ref this);

    /// <summary>Retrieves the footer line two label UI element for the current stat management UI state.
    /// <code>Offset: 0x004F0F40
    /// UIElement_Text* __thiscall gmStatManagementUI::GetFooterLineTwoLabel(gmStatManagementUI*)</code>
    /// </summary>
    /// <returns>The UIElement_Text instance representing the second footer line, or null if it cannot be located.</returns>
    public ACBindings.Internal.UIElement_Text* GetFooterLineTwoLabel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Text*>)0x004F0F40)(ref this);

    /// <summary>Retrieves the UIElement_Text representing the second footer line value according to the current UI state.
    /// <code>Offset: 0x004F0F90
    /// UIElement_Text* __thiscall gmStatManagementUI::GetFooterLineTwoValue(gmStatManagementUI*)</code>
    /// </summary>
    /// <returns>A pointer to the matching UIElement_Text if present; otherwise, a null pointer.</returns>
    public ACBindings.Internal.UIElement_Text* GetFooterLineTwoValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Text*>)0x004F0F90)(ref this);

    /// <summary>Retrieves the footer button element associated with this statistics‑management UI instance based on its current visual state.
    /// <code>Offset: 0x004F0FE0
    /// UIElement_Button* __thiscall gmStatManagementUI::GetFooterButton(gmStatManagementUI*)</code>
    /// </summary>
    /// <param name="this">The gmStatManagementUI object requesting the footer button.</param>
    /// <returns>A pointer to the footer button (UIElement_Button) if it exists; otherwise, nullptr.</returns>
    public ACBindings.Internal.UIElement_Button* GetFooterButton() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Button*>)0x004F0FE0)(ref this);

    /// <summary>Retrieves the footer button at index 10 within the stat‑management UI and invokes its action if present.
    /// <code>Offset: 0x004F1030
    /// UIElement_Button* __thiscall gmStatManagementUI::GetFooter10Button(gmStatManagementUI*)</code>
    /// </summary>
    /// <returns>A pointer to the UIElement_Button representing that footer button, or nullptr when the button cannot be located.</returns>
    public ACBindings.Internal.UIElement_Button* GetFooter10Button() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Button*>)0x004F1030)(ref this);

    /// <summary>Initializes a gmStatManagementUI instance with the supplied layout and element description, setting up base UI elements, notice and quality change handlers, and clearing all internal pointers and state flags.
    /// <code>Offset: 0x004F1080
    /// void __thiscall gmStatManagementUI::gmStatManagementUI(gmStatManagementUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">The layout descriptor that defines display size and element mappings for this UI component.</param>
    /// <param name="full_desc">A full element description providing configuration details for the root element of the UI.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004F1080)(ref this, layout, full_desc);

    /// <summary>
    /// Updates the statistics management UI by acquiring the player descriptor interface, handling reference counts, and invoking the input callback. Returns false if the UI element is inactive or the interface query fails.
    /// 
    /// <code>Offset: 0x004F1130
    /// bool __thiscall gmStatManagementUI::Update(gmStatManagementUI*)</code>
    /// </summary>
    /// <returns>True if the update succeeded; otherwise false.</returns>
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, byte>)0x004F1130)(ref this);

    /// <summary>Clears the UI list box, notifies each token of a quality change, removes all token references, and resets the token count.
    /// <code>Offset: 0x004F11E0
    /// bool __thiscall gmStatManagementUI::FlushList(gmStatManagementUI*)</code>
    /// </summary>
    /// <returns>Always true, indicating the flush operation completed successfully.</returns>
    public byte FlushList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, byte>)0x004F11E0)(ref this);

    /// <summary>Destroys the gmStatManagementUI instance, unregistering all notice handlers and quality change callbacks, clearing UI element references, deleting the token array, and resetting base class vtables.
    /// <code>Offset: 0x004F1270
    /// void __thiscall gmStatManagementUI::~gmStatManagementUI(gmStatManagementUI*)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmStatManagementUI object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, void>)0x004F1270)(ref this);

    /// <summary>Updates the stat management UI to show a character’s current attributes—including name, heritage, title, level, and other quality values—using data supplied in a CACQualities structure.
    /// <code>Offset: 0x004F1400
    /// bool __thiscall gmStatManagementUI::UpdateCharacterInfo(gmStatManagementUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">A pointer to a CACQualities instance containing the character’s qualities and stats used for populating the UI fields.</param>
    /// <returns>True if the UI was updated successfully; otherwise false.</returns>
    public byte UpdateCharacterInfo(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CACQualities*, byte>)0x004F1400)(ref this, i_playerDesc);

    /// <summary>Updates the stat‑management user interface with the player’s current experience, level progress toward the next level, and, when applicable, luminance values derived from the player’s qualities.
    /// <code>Offset: 0x004F1700
    /// bool __thiscall gmStatManagementUI::UpdateExperience(gmStatManagementUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">The player quality descriptor containing experience, level, and related stats used to compute display values.</param>
    /// <returns>True if the UI fields were updated successfully; this implementation always returns true.</returns>
    public byte UpdateExperience(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CACQualities*, byte>)0x004F1700)(ref this, i_playerDesc);
}

