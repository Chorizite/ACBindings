namespace ACBindings.Internal;


/// <summary>Manages the in‑game Fellowship user interface, handling creation, recruitment, leadership changes, and UI updates for fellowship members.</summary>
public unsafe struct gmFellowshipUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmFellowshipUI_vtbl
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
    public ACBindings.Internal.CFellowship* m_pFellowship;
    public uint m_iidSelectedFellow;
    public uint m_uiAcceptFellowRequestServerContextID;
    public uint m_fellowRequestContext;
    public ACBindings.Internal.UIElement* m_pNotInAFellowshipFrame;
    public ACBindings.Internal.UIElement* m_pInAFellowshipFrame;
    public ACBindings.Internal.UIElement_Text* m_pFellowshipNameEntryBox;
    public ACBindings.Internal.UIElement_Button* m_pCreateFellowshipButton;
    public ACBindings.Internal.UIElement_Text* m_pFellowshipName;
    public ACBindings.Internal.UIElement_ListBox* m_pFellowsListBox;
    public ACBindings.Internal.UIElement_Button* m_pFellowLeaderButton;
    public ACBindings.Internal.UIElement_Button* m_pFellowQuitButton;
    public ACBindings.Internal.UIElement_Button* m_pFellowOpenButton;
    public ACBindings.Internal.UIElement_Button* m_pFellowRecruitButton;
    public ACBindings.Internal.UIElement_Button* m_pFellowDismissButton;
    public ACBindings.Internal.UIElement_Button* m_pFellowDisbandButton;

    // Generated Constructor
    public gmFellowshipUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a gmFellowshipUI instance by constructing its underlying UIElement with the specified layout and element descriptor, then clearing all internal pointers and configuring notice handling for fellowship interactions.
    /// <code>Offset: 0x0048E610
    /// void __thiscall gmFellowshipUI::gmFellowshipUI(gmFellowshipUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout description used to set up the UI element.</param>
    /// <param name="full_desc">Full element descriptor defining the structure of the UI components.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0048E610)(ref this, layout, full_desc);

    /// <summary>Performs a runtime type check and returns a pointer to the requested UIElement-derived interface of the object or nullptr when unsupported.
    /// <code>Offset: 0x0048E6B0
    /// UIElement* __thiscall gmFellowshipUI::DynamicCast(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the desired type for casting.</param>
    /// <returns>A UIElement* pointing to the appropriate base class if the type matches; otherwise, null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, ACBindings.Internal.UIElement*>)0x0048E6B0)(ref this, i_eType);

    /// <summary>Retrieves the identifier used to classify this UI element within the system.
    /// <code>Offset: 0x0048E6D0
    /// unsigned int __thiscall gmFellowshipUI::GetUIElementType(gmFellowshipUI*)</code>
    /// </summary>
    /// <returns>The unsigned integer constant 268435501 that uniquely identifies the gmFellowshipUI element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint>)0x0048E6D0)(ref this);

    /// <summary>
    /// Creates a new Fellowship user interface element using the specified layout and element description, allocating memory for a gmFellowshipUI instance and initializing it.
    /// 
    /// <code>Offset: 0x0048E6E0
    /// UIElement* __cdecl gmFellowshipUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Description of the UI layout to use.</param>
    /// <param name="full_desc">Full element description defining the UI hierarchy and properties.</param>
    /// <returns>Pointer to the newly created UIElement representing the Fellowship UI, or null if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0048E6E0)(layout, full_desc);

    /// <summary>Handles abort confirmation requests from the UI. If the confirmation type equals 4, closes the currently displayed dialog and clears its element references.
    /// <code>Offset: 0x0048E710
    /// void __thiscall gmFellowshipUI::RecvNotice_AbortConfirmationRequest(gmFellowshipUI*,int,unsigned int)</code>
    /// </summary>
    /// <param name="confirmationType">Identifier of the confirmation request; value 4 indicates a cancel action that should close the dialog.</param>
    /// <param name="context">Context ID associated with the aborted operation (unused in this implementation).</param>
    public void RecvNotice_AbortConfirmationRequest(int confirmationType, uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, int, uint, void>)0x0048E710)(ref this, confirmationType, context);

    /// <summary>Notifies the fellowship system of a visibility change, prompting it to update its internal state accordingly.
    /// <code>Offset: 0x0048E740
    /// void __thiscall gmFellowshipUI::OnVisibilityChanged(gmFellowshipUI*,bool)</code>
    /// </summary>
    /// <param name="i_bVisible">True if the UI is now visible; false if it has been hidden.</param>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, byte, void>)0x0048E740)(ref this, i_bVisible);

    /// <summary>Dismisses the specified fellow from the active fellowship if they belong to it and are not the caller; otherwise displays an appropriate error message.
    /// <code>Offset: 0x0048E750
    /// void __thiscall gmFellowshipUI::DismissFellow(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidPlayer">Identifier of the fellow to dismiss.</param>
    public void DismissFellow(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x0048E750)(ref this, i_iidPlayer);

    /// <summary>Attempts to add the specified player as a member of the current fellowship; if the player is already present or attempting to recruit oneself, displays an error notice.
    /// <code>Offset: 0x0048E810
    /// void __thiscall gmFellowshipUI::RecruitFellow(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidPlayer">Identifier of the player to recruit.</param>
    public void RecruitFellow(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x0048E810)(ref this, i_iidPlayer);

    /// <summary>Destroys a gmFellowshipUI instance by unregistering all related notice handlers, removing global message registrations, closing any active fellowship request dialog, resetting internal context identifiers, and cleaning up inherited UI elements.
    /// <code>Offset: 0x0048E910
    /// void __thiscall gmFellowshipUI::~gmFellowshipUI(gmFellowshipUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x0048E910)(ref this);

    /// <summary>Registers the Fellowship UI element class with the UI system, enabling its instantiation via a unique identifier.
    /// <code>Offset: 0x0048E980
    /// void __cdecl gmFellowshipUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0048E980)();

    /// <summary>Updates UI buttons for fellowship management according to current membership, leadership status, selected member, and whether a fellow is open. Enables or disables actions such as quit, disband, recruit, dismiss, leader assignment, and updates the open/close button label accordingly.
    /// <code>Offset: 0x0048E9A0
    /// void __thiscall gmFellowshipUI::UpdateButtons(gmFellowshipUI*)</code>
    /// </summary>
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x0048E9A0)(ref this);

    /// <summary>Updates the UI display for a fellow’s level and experience contribution within the fellowship.
    /// <code>Offset: 0x0048EE00
    /// void __thiscall gmFellowshipUI::UpdateFellowStats(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidPlayer">The unique identifier of the player whose stats should be refreshed in the fellows list box.</param>
    public void UpdateFellowStats(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x0048EE00)(ref this, i_iidPlayer);

    /// <summary>Refreshes the UI entry for a fellowship member, updating health, stamina and mana progress bars and numeric labels to reflect the current values of the specified player.
    /// <code>Offset: 0x0048F040
    /// void __thiscall gmFellowshipUI::UpdateFellowVitals(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidPlayer">The instance ID of the player whose vitals should be displayed.</param>
    public void UpdateFellowVitals(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x0048F040)(ref this, i_iidPlayer);

    /// <summary>Updates the fellowship listbox selection to match the currently selected object ID from the global state. If that ID is present in the list it becomes highlighted; otherwise the previously selected fellow remains highlighted if still listed, or the selection is cleared when no matching item exists.
    /// <code>Offset: 0x0048F3D0
    /// void __thiscall gmFellowshipUI::UpdateFellowSelection(gmFellowshipUI*)</code>
    /// </summary>
    /// <param name="this">Reference to the gmFellowshipUI instance.</param>
    public void UpdateFellowSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x0048F3D0)(ref this);

    /// <summary>Responds to a selection change notice in the fellowship UI by updating the selected fellow display.
    /// <code>Offset: 0x0048F4A0
    /// void __thiscall gmFellowshipUI::RecvNotice_SelectionChanged(gmFellowshipUI*)</code>
    /// </summary>
    /// <param name="this">The gmFellowshipUI instance that received the notice.</param>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x0048F4A0)(ref this);

    /// <summary>Assigns the specified fellow as the new leader of the current fellowship, provided the member exists and is not already the leader.
    /// <code>Offset: 0x0048F4C0
    /// void __thiscall gmFellowshipUI::AssignLeadershipToFellow(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidFellow">Identifier of the fellow to become the new leader.</param>
    public void AssignLeadershipToFellow(uint i_iidFellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x0048F4C0)(ref this, i_iidFellow);

    /// <summary>Handles a close‑dialog notice for the fellowship UI, extracting response information from the supplied property collection, updating internal state, notifying the character controller of confirmation results, and releasing related resources.
    /// <code>Offset: 0x0048F5A0
    /// void __thiscall gmFellowshipUI::RecvNotice_CloseDialog(gmFellowshipUI*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    /// <param name="context">Identifier used to match the dialog instance that is being closed.</param>
    /// <param name="data">Property collection carrying additional information such as the dialog result code.</param>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, ACBindings.Internal.PropertyCollection*, void>)0x0048F5A0)(ref this, context, data);

    /// <summary>Refreshes the fellowship user interface to reflect the current state of the player’s fellowship. When a fellowship exists, it updates the in‑fellowship frame with the fellowship name, member list, and individual stats; otherwise it displays the not‑in‑fellowship view.
    /// <code>Offset: 0x0048F720
    /// void __thiscall gmFellowshipUI::Update(gmFellowshipUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x0048F720)(ref this);

    /// <summary>Create a new fellowship from the name entered in the UI entry box. The method formats the name, updates the UI field, retrieves the current XP‑share flag, and triggers the fellowship creation event with the formatted name and share setting.
    /// <code>Offset: 0x0048FA10
    /// void __thiscall gmFellowshipUI::CreateFellowship(gmFellowshipUI*)</code>
    /// </summary>
    public void CreateFellowship() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x0048FA10)(ref this);

    /// <summary>Announces that a player has joined the current fellowship, updating the UI and displaying a notification message.
    /// <code>Offset: 0x0048FF00
    /// void __thiscall gmFellowshipUI::FellowAdded(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidPlayer">Identifier of the player who was added to the fellowship.</param>
    public void FellowAdded(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x0048FF00)(ref this, i_iidPlayer);

    /// <summary>Initializes UI elements for the fellowship interface, linking controls to member variables, configuring option text and help strings, registering global event handlers, and performing a final update.
    /// <code>Offset: 0x00490020
    /// void __thiscall gmFellowshipUI::PostInit(gmFellowshipUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x00490020)(ref this);

    /// <summary>Handles UI element messages for the fellowship interface, executing actions such as creating or leaving a fellowship, assigning leadership, toggling open status, recruiting or dismissing members, and updating button states in response to user interaction.
    /// <code>Offset: 0x004904A0
    /// UIElementMessageListenResult __thiscall gmFellowshipUI::ListenToElementMessage(gmFellowshipUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmFellowshipUI instance that processes the message.</param>
    /// <param name="i_rMsg">Message information containing element ID, message type, and associated data for the UI event.</param>
    /// <returns>Result of processing the message, indicating whether the event was consumed or should propagate further.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004904A0)(ref this, i_rMsg);

    /// <summary>Updates UI and informs user when a fellowship update notice arrives, displaying creation or recruitment messages as appropriate.
    /// <code>Offset: 0x00490770
    /// void __thiscall gmFellowshipUI::RecvNotice_FellowshipUpdate(gmFellowshipUI*,const CFellowship*)</code>
    /// </summary>
    /// <param name="i_fellowship">The updated Fellowship data received from the server.</param>
    public void RecvNotice_FellowshipUpdate(ACBindings.Internal.CFellowship* i_fellowship) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, ACBindings.Internal.CFellowship*, void>)0x00490770)(ref this, i_fellowship);

    /// <summary>
    /// Handles the event when a Fellowship is disbanded by updating UI elements and notifying the user.
    /// If the current player was the leader, informs them of their own action; otherwise displays who disbanded the Fellowship.
    /// After processing, clears the stored Fellowship reference and refreshes the UI.
    /// 
    /// <code>Offset: 0x004908B0
    /// void __thiscall gmFellowshipUI::RecvNotice_FellowshipDisbanded(gmFellowshipUI*)</code>
    /// </summary>
    public void RecvNotice_FellowshipDisbanded() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x004908B0)(ref this);

    /// <summary>Updates the fellowship UI when a member quits, removing them from the local list and displaying an appropriate message.
    /// <code>Offset: 0x004908C0
    /// void __thiscall gmFellowshipUI::RecvNotice_FellowQuit(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidPlayer">Identifier of the player who left the fellowship.</param>
    public void RecvNotice_FellowQuit(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x004908C0)(ref this, i_iidPlayer);

    /// <summary>Handles a dismissal notice within a fellowship, updating UI state and internal data to reflect removal of a member.
    /// <code>Offset: 0x004908D0
    /// void __thiscall gmFellowshipUI::RecvNotice_FellowDismissed(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidPlayer">Identifier of the fellow whose dismissal is being processed.</param>
    public void RecvNotice_FellowDismissed(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x004908D0)(ref this, i_iidPlayer);

    /// <summary>Adds a newly joined fellow, identified by <paramref name="i_iidPlayer"/>, to the UI's fellows list and refreshes relevant display elements.
    /// <code>Offset: 0x004908E0
    /// void __thiscall gmFellowshipUI::RecvNotice_FellowAdded(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidPlayer">Identifier of the player who has joined the fellowship.</param>
    public void RecvNotice_FellowAdded(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x004908E0)(ref this, i_iidPlayer);

    /// <summary>Receives a fellowship update notice and refreshes the UI to reflect changes to the specified fellow. Depending on the update type, it updates vitals, stats, or performs a full UI refresh.
    /// <code>Offset: 0x004908F0
    /// void __thiscall gmFellowshipUI::RecvNotice_FellowUpdated(gmFellowshipUI*,unsigned int,const Fellow*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidPlayer">Identifier of the player whose fellow has been updated.</param>
    /// <param name="i_fellow">Pointer to the Fellow structure containing updated data.</param>
    /// <param name="i_uiUpdateType">Code indicating which set of information has changed (e.g., vitals, stats, or full update).</param>
    public void RecvNotice_FellowUpdated(uint i_iidPlayer, ACBindings.Internal.Fellow* i_fellow, uint i_uiUpdateType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, ACBindings.Internal.Fellow*, uint, void>)0x004908F0)(ref this, i_iidPlayer, i_fellow, i_uiUpdateType);

    /// <summary>Creates a fellowship request dialog in the current UI using the supplied player identifier and context.
    /// <code>Offset: 0x00490900
    /// char __thiscall gmFellowshipUI::MakeFellowRequestDialog(_DWORD*,const char*,int)</code>
    /// </summary>
    /// <param name="a2">Reference‑counted string containing the player’s name or ID to include in the dialog.</param>
    /// <param name="a3">Context identifier used when the dialog is accepted or rejected.</param>
    /// <returns>Non‑zero if the dialog was successfully created; zero otherwise.</returns>
    public sbyte MakeFellowRequestDialog(sbyte* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, sbyte*, int, sbyte>)0x00490900)(ref this, a2, a3);

    /// <summary>Handles a fellowship request notice by extracting the message and opening a dialog with the appropriate context ID.
    /// <code>Offset: 0x00490B60
    /// char __thiscall gmFellowshipUI::RecvNotice_FellowshipRequest(_DWORD*,int*,const char*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the notice payload; its first field is used as an offset to locate the request string.</param>
    /// <param name="a3">Encoded server‑side request identifier, passed as a const char* but interpreted as an integer context ID.</param>
    /// <returns>Non‑zero if the request dialog was successfully created; zero otherwise.</returns>
    public sbyte RecvNotice_FellowshipRequest(int* a2, sbyte* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, int*, sbyte*, sbyte>)0x00490B60)(ref this, a2, a3);
}

