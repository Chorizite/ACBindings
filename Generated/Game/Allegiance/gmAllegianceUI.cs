namespace ACBindings.Internal;


/// <summary>Handles the Allegiance user interface, displaying allegiance hierarchy, managing vassals, monarchs, patrons, and providing actions to swear, break, or kick allegiance. It also creates confirmation dialogs and updates UI elements based on game events.</summary>
public unsafe struct gmAllegianceUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler

    // Child Types
    public unsafe struct gmAllegianceUI_vtbl
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
    public byte m_bAwaitingUpdate;
    public uint m_iidSelectedVassal;
    public uint m_iidPossibleNewPatron;
    public uint m_iidPossibleKickedVassal;
    public uint m_uiAcceptSwearServerContextID;
    public ACBindings.Internal.UIElement_Text* m_pAllegianceName;
    public ACBindings.Internal.UIElement_Text* m_pPlayerFollowers;
    public ACBindings.Internal.UIElement_Text* m_pPlayerRank;
    public ACBindings.Internal.UIElement* m_pMonarchField;
    public ACBindings.Internal.UIElement_Text* m_pMonarchLabel;
    public ACBindings.Internal.UIElement_Text* m_pMonarchName;
    public ACBindings.Internal.UIElement_Text* m_pMonarchFollowers;
    public ACBindings.Internal.UIElement* m_pPatronField;
    public ACBindings.Internal.UIElement_Text* m_pPatronName;
    public ACBindings.Internal.UIElement_ListBox* m_pVassalListBox;
    public ACBindings.Internal.UIElement_Button* m_pSwearButton;
    public ACBindings.Internal.UIElement_Button* m_pBreakButton;
    public ACBindings.Internal.UIElement_Button* m_pKickButton;
    public uint m_swearContext;
    public uint m_acceptSwearContext;
    public uint m_breakContext;
    public uint m_kickContext;

    // Generated Constructor
    public gmAllegianceUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Responds to global UI messages, selecting the first vassal in the list when a specific message arrives.
    /// <code>Offset: 0x00490B90
    /// void __thiscall gmAllegianceUI::ListenToGlobalMessage(gmAllegianceUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the incoming global message.</param>
    /// <param name="i_data_int">Additional data associated with the message used to determine actions.</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, uint, int, void>)0x00490B90)(ref this, i_messageID, i_data_int);

    /// <summary>Updates the Swear button’s enabled state by checking if the player has no patron, a different entity is selected, that entity is eligible for swearing, and no existing allegiance record connects them; enables the button when all conditions are met, otherwise disables it.
    /// <code>Offset: 0x00490BC0
    /// void __thiscall gmAllegianceUI::UpdateSwearButton(gmAllegianceUI*)</code>
    /// </summary>
    public void UpdateSwearButton() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00490BC0)(ref this);

    /// <summary>Adjusts the break button’s enabled state based on whether a patron exists for the selected vassal.
    /// <code>Offset: 0x00490CB0
    /// void __thiscall gmAllegianceUI::UpdateBreakButton(gmAllegianceUI*)</code>
    /// </summary>
    public void UpdateBreakButton() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00490CB0)(ref this);

    /// <summary>Closes the accept‑swear confirmation dialog, sends the user’s response to the server and clears the associated context IDs.
    /// <code>Offset: 0x00490D30
    /// bool __thiscall gmAllegianceUI::CloseAcceptSwearConfirmationDialog(gmAllegianceUI*,bool)</code>
    /// </summary>
    /// <param name="i_bConfirm">True if the user accepted; false otherwise.</param>
    /// <returns>Always true after closing the dialog.</returns>
    public byte CloseAcceptSwearConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte, byte>)0x00490D30)(ref this, i_bConfirm);

    /// <summary>Closes the break‑confirmation dialog; if confirmation is accepted, initiates breaking allegiance with the current patron.
    /// <code>Offset: 0x00490D70
    /// bool __thiscall gmAllegianceUI::CloseBreakConfirmationDialog(gmAllegianceUI*,bool)</code>
    /// </summary>
    /// <param name="i_bConfirm">True when the user confirms the request to break allegiance.</param>
    /// <returns>Always true, indicating the dialog was closed successfully.</returns>
    public byte CloseBreakConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte, byte>)0x00490D70)(ref this, i_bConfirm);

    /// <summary>Closes the kick‑confirmation dialog and, if confirmed, initiates breaking allegiance for the selected vassal.
    /// <code>Offset: 0x00490DE0
    /// bool __thiscall gmAllegianceUI::CloseKickConfirmationDialog(gmAllegianceUI*,bool)</code>
    /// </summary>
    /// <param name="i_bConfirm">True when the user confirms the kick; false to cancel.</param>
    /// <returns>Always true after closing the dialog.</returns>
    public byte CloseKickConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte, byte>)0x00490DE0)(ref this, i_bConfirm);

    /// <summary>Constructs an allegiance UI element using the supplied layout and element description, initializing all internal pointers and state variables to default values.
    /// <code>Offset: 0x00490E20
    /// void __thiscall gmAllegianceUI::gmAllegianceUI(gmAllegianceUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Describes the overall layout configuration for the UI component, including dimensions and child elements.</param>
    /// <param name="full_desc">Provides the detailed definition of this specific UI element, including its properties and nested sub-elements.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00490E20)(ref this, layout, full_desc);

    /// <summary>Attempts a runtime cast of this gmAllegianceUI instance to the requested UI element type, returning a valid pointer when the type identifier matches or nullptr otherwise.
    /// <code>Offset: 0x00490EF0
    /// UIElement* __thiscall gmAllegianceUI::DynamicCast(gmAllegianceUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the desired UI element type for casting (e.g., base UIElement or gmAllegianceUI).</param>
    /// <returns>A pointer to the corresponding UIElement if the cast succeeds; otherwise null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, uint, ACBindings.Internal.UIElement*>)0x00490EF0)(ref this, i_eType);

    /// <summary>Returns the unique identifier representing the UI element type of this object.
    /// <code>Offset: 0x00490F10
    /// unsigned int __thiscall gmAllegianceUI::GetUIElementType(gmAllegianceUI*)</code>
    /// </summary>
    /// <returns>An unsigned integer constant identifying the element type, currently 268435500.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, uint>)0x00490F10)(ref this);

    /// <summary>Destroys the gmAllegianceUI instance by unregistering all notice and quality-change handlers, removing global message registrations, closing any active allegiance dialogs, and invoking base class destructors.
    /// <code>Offset: 0x00490F20
    /// void __thiscall gmAllegianceUI::~gmAllegianceUI(gmAllegianceUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00490F20)(ref this);

    /// <summary>Creates a new gmAllegianceUI instance using the supplied layout and element descriptions, returning it as a UIElement pointer.
    /// <code>Offset: 0x00490FF0
    /// UIElement* __cdecl gmAllegianceUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining display size and contained elements.</param>
    /// <param name="full_desc">Full element description used to populate the UI hierarchy.</param>
    /// <returns>Pointer to the created UIElement, or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00490FF0)(layout, full_desc);

    /// <summary>Handles a received player description notice by marking the UI system busy and requesting an allegiance update.
    /// <code>Offset: 0x00491020
    /// void __thiscall gmAllegianceUI::RecvNotice_PlayerDescReceived(gmAllegianceUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="this">The gmAllegianceUI instance handling the notice.</param>
    /// <param name="i_playerDesc">Player qualities descriptor received from the server.</param>
    /// <param name="i_playerModule">Additional player module data accompanying the notice.</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x00491020)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Responds to selection change notices by refreshing the state of relevant UI controls.
    /// <code>Offset: 0x00491050
    /// void __thiscall gmAllegianceUI::RecvNotice_SelectionChanged(gmAllegianceUI*)</code>
    /// </summary>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00491050)(ref this);

    /// <summary>Aborts an active allegiance confirmation dialog when the user dismisses it, clearing dialog references and updating UI elements accordingly.
    /// <code>Offset: 0x00491060
    /// void __thiscall gmAllegianceUI::RecvNotice_AbortConfirmationRequest(gmAllegianceUI*,int,unsigned int)</code>
    /// </summary>
    /// <param name="confirmationType">Specifies which type of confirmation is being aborted; only value 1 triggers the abort logic.</param>
    /// <param name="context">Identifier for the specific confirmation request; not used in this implementation but kept for interface consistency.</param>
    public void RecvNotice_AbortConfirmationRequest(int confirmationType, uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, int, uint, void>)0x00491060)(ref this, confirmationType, context);

    /// <summary>Requests an allegiance update when a quality is removed from a game object and marks the UI as busy if not already flagged.
    /// <code>Offset: 0x00491090
    /// void __thiscall gmAllegianceUI::OnQualityRemoved(gmAllegianceUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="this">The allegiance UI instance handling the event.</param>
    /// <param name="cwobj">The game object from which the quality was removed; ignored by this handler.</param>
    /// <param name="stype">Stat type of the removed quality; ignored by this handler.</param>
    /// <param name="senum">Additional context enumeration for the removal event; ignored by this handler.</param>
    public void OnQualityRemoved(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x00491090)(ref this, cwobj, stype, senum);

    /// <summary>Initializes the Allegiance UI by locating child elements, configuring text fields and buttons, registering quality change handlers, and subscribing to global events.
    /// <code>Offset: 0x00491170
    /// void __thiscall gmAllegianceUI::PostInit(gmAllegianceUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00491170)(ref this);

    /// <summary>Registers the Allegiance UI component type with the UI system, enabling creation of instances via its Create method.
    /// <code>Offset: 0x004914D0
    /// void __cdecl gmAllegianceUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004914D0)();

    /// <summary>Handles changes to the Allegiance UI visibility state. When shown, initiates a pending update request and signals that the interface requires fresh data; when hidden, cancels any pending updates and informs subsystems that the UI is no longer active.
    /// <code>Offset: 0x00491520
    /// void __thiscall gmAllegianceUI::OnVisibilityChanged(gmAllegianceUI*,bool)</code>
    /// </summary>
    /// <param name="i_bVisible">True if the UI has become visible, false if it has been hidden.</param>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte, void>)0x00491520)(ref this, i_bVisible);

    /// <summary>Refreshes the allegiance UI with the player’s current data, pulling information from the ClientAllegianceSystem to update the name, follower count, and rank/title display elements.
    /// <code>Offset: 0x00491610
    /// void __thiscall gmAllegianceUI::UpdatePlayerData(gmAllegianceUI*)</code>
    /// </summary>
    public void UpdatePlayerData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00491610)(ref this);

    /// <summary>Refreshes the patron section of the allegiance UI by retrieving the current player's monarch and patron data, updating displayed names and experience metrics, and adjusting interaction controls based on login status.
    /// <code>Offset: 0x00491AA0
    /// void __thiscall gmAllegianceUI::UpdatePatronData(gmAllegianceUI*)</code>
    /// </summary>
    public void UpdatePatronData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00491AA0)(ref this);

    /// <summary>Retrieves the current monarch information from the allegiance system and updates UI elements such as name, follower count, and labels to reflect the monarch's status. Adjusts talk focus based on whether a logged‑in monarch is present.
    /// <code>Offset: 0x00491E20
    /// void __thiscall gmAllegianceUI::UpdateMonarchData(gmAllegianceUI*)</code>
    /// </summary>
    public void UpdateMonarchData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00491E20)(ref this);

    /// <summary>Refreshes the UI’s player data in response to a change in enchantment status.
    /// <code>Offset: 0x00492330
    /// void __thiscall gmAllegianceUI::RecvNotice_EnchantmentsChanged(gmAllegianceUI*)</code>
    /// </summary>
    public void RecvNotice_EnchantmentsChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00492330)(ref this);

    /// <summary>Processes a close dialog notice for the Allegiance UI, interpreting the context identifier and accompanying data to trigger actions such as completing allegiance swearing, closing confirmation dialogs, or handling break/kick confirmations.
    /// <code>Offset: 0x00492340
    /// void __thiscall gmAllegianceUI::RecvNotice_CloseDialog(gmAllegianceUI*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    /// <param name="context">Identifier specifying which dialog was closed (e.g., swear, break, kick).</param>
    /// <param name="data">Collection of properties sent with the notice; may include a flag indicating whether the action was confirmed.</param>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, uint, ACBindings.Internal.PropertyCollection*, void>)0x00492340)(ref this, context, data);

    /// <summary>Handles login or logout notifications for an allegiance member, appending a message to the UI indicating whether the member logged in or out.
    /// <code>Offset: 0x00492500
    /// void __thiscall gmAllegianceUI::RecvNotice_AllegianceLogin(gmAllegianceUI*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_iidMember">Identifier of the allegiance member whose status changed.</param>
    /// <param name="i_bNowLoggedIn">True if the member is now logged in; false if they have logged out.</param>
    public void RecvNotice_AllegianceLogin(uint i_iidMember, byte i_bNowLoggedIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, uint, byte, void>)0x00492500)(ref this, i_iidMember, i_bNowLoggedIn);

    /// <summary>Refreshes the vassals UI list by clearing existing entries, querying the current allegiance profile for active vassals, and populating each entry with a vassal’s name and experience. Enables or disables talk focus based on whether any logged‑in vassals are present.
    /// <code>Offset: 0x00492620
    /// void __thiscall gmAllegianceUI::UpdateVassalsData(gmAllegianceUI*)</code>
    /// </summary>
    public void UpdateVassalsData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00492620)(ref this);

    /// <summary>Refreshes the allegiance user interface by querying the current player state and updating displayed information for player, monarch, patron, and vassals. It also adjusts action buttons (swear, break, kick) based on selection and manages reference counts to the underlying interface objects.
    /// <code>Offset: 0x00492950
    /// void __thiscall gmAllegianceUI::Update(gmAllegianceUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00492950)(ref this);

    /// <summary>Receives a notification that an allegiance profile has changed and updates the UI to reflect new information such as member counts and rank.
    /// <code>Offset: 0x00492A60
    /// void __thiscall gmAllegianceUI::RecvNotice_AllegianceUpdate(gmAllegianceUI*,const CAllegianceProfile*,unsigned int)</code>
    /// </summary>
    /// <param name="i_prof">The updated allegiance profile containing hierarchy and membership details.</param>
    /// <param name="i_uiRank">The player's current allegiance rank within the profile.</param>
    public void RecvNotice_AllegianceUpdate(ACBindings.Internal.CAllegianceProfile* i_prof, uint i_uiRank) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, ACBindings.Internal.CAllegianceProfile*, uint, void>)0x00492A60)(ref this, i_prof, i_uiRank);

    /// <summary>Responds to an aborted allegiance update notice by invoking a UI refresh when listeners are registered.
    /// <code>Offset: 0x00492A70
    /// void __thiscall gmAllegianceUI::RecvNotice_AllegianceUpdateAborted(gmAllegianceUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_etype">The event type identifier for the aborted notice.</param>
    public void RecvNotice_AllegianceUpdateAborted(uint i_etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, uint, void>)0x00492A70)(ref this, i_etype);

    /// <summary>Creates a swear confirmation dialog for the currently selected character and stores its context identifier.
    /// <code>Offset: 0x00492A90
    /// bool __thiscall gmAllegianceUI::MakeSwearConfirmationDialog(gmAllegianceUI*)</code>
    /// </summary>
    /// <returns>True if the dialog is successfully created; otherwise, false when a swear dialog is already active or creation fails.</returns>
    public byte MakeSwearConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte>)0x00492A90)(ref this);

    /// <summary>Creates an accept‑swear confirmation dialog in the current UI, displaying the specified player name and storing a context identifier.
    /// <code>Offset: 0x00492C70
    /// char __thiscall gmAllegianceUI::MakeAcceptSwearConfirmationDialog(_DWORD*,const char*,int)</code>
    /// </summary>
    /// <param name="a2">Reference‑counted string containing the player's name to show in the dialog.</param>
    /// <param name="a3">Context ID used when the player accepts the swear action.</param>
    /// <returns>Non‑zero if the dialog was successfully created; zero otherwise.</returns>
    public sbyte MakeAcceptSwearConfirmationDialog(sbyte* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, sbyte*, int, sbyte>)0x00492C70)(ref this, a2, a3);

    /// <summary>Creates and displays a confirmation dialog to confirm breaking an allegiance. Returns true if the dialog was successfully created and displayed; otherwise false.
    /// <code>Offset: 0x00492ED0
    /// bool __thiscall gmAllegianceUI::MakeBreakConfirmationDialog(gmAllegianceUI*)</code>
    /// </summary>
    /// <returns>True when the break confirmation dialog is shown; false if it could not be created or if one already exists.</returns>
    public byte MakeBreakConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte>)0x00492ED0)(ref this);

    /// <summary>Create a kick confirmation dialog for the selected vassal if one is not already active, using allegiance profile data to populate it.
    /// <code>Offset: 0x004930F0
    /// bool __thiscall gmAllegianceUI::MakeKickConfirmationDialog(gmAllegianceUI*)</code>
    /// </summary>
    /// <returns>True when the dialog is successfully created; otherwise false.</returns>
    public byte MakeKickConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte>)0x004930F0)(ref this);

    /// <summary>Handles UI element messages for the Allegiance screen, responding to button clicks for swearing allegiance, breaking ties, and kicking vassals, as well as updating the selected vassal when the list changes. After processing its own logic it forwards remaining events to the base class handler.
    /// <code>Offset: 0x00493310
    /// UIElementMessageListenResult __thiscall gmAllegianceUI::ListenToElementMessage(gmAllegianceUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">The gmAllegianceUI instance receiving the message.</param>
    /// <param name="i_rMsg">Information about the UI element event, including the element ID and message type.</param>
    /// <returns>Result indicating whether the message was handled and how it should propagate through the UI hierarchy.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00493310)(ref this, i_rMsg);

    /// <summary>
    /// Handles a swear‑allegiance notice by extracting the patron’s name from the notice data and displaying an accept confirmation dialog.
    /// 
    /// <code>Offset: 0x004933F0
    /// char __thiscall gmAllegianceUI::RecvNotice_SwearAllegianceRequest(_DWORD*,int*,const char*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a structure containing notice information; the patron's name is located at offset +20.</param>
    /// <param name="a3">Identifier for the context of the swear request, passed to the confirmation dialog.</param>
    /// <returns>Non‑zero if the confirmation dialog was successfully created; zero otherwise.</returns>
    public sbyte RecvNotice_SwearAllegianceRequest(int* a2, sbyte* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, int*, sbyte*, sbyte>)0x004933F0)(ref this, a2, a3);
}

