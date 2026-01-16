namespace ACBindings.Internal;


/// <summary>Manages skill selection and display within the character statistics interface, extending the base stat‑management UI to track the currently selected skill and its list index.</summary>
public unsafe struct gmSkillUI
{
    // Base Classes
    public ACBindings.Internal.gmStatManagementUI BaseClass_gmStatManagementUI; // ACBindings.Internal.gmStatManagementUI

    // Child Types
    public unsafe struct gmSkillUI_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmSkillUI*, ACBindings.Internal.CACQualities*, uint> GetCostToRaise10; // function pointer

        // Methods
    }

    // Members
    public uint m_SelectedSkill;
    public int m_SelectedIndex;

    // Generated Constructor
    public gmSkillUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>Creates a new skill UI component with the specified layout and description, initializing base statistics and setting initial selection state.
    /// <code>Offset: 0x0049B040
    /// void __thiscall gmSkillUI::gmSkillUI(gmSkillUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout information for the UI element.</param>
    /// <param name="full_desc">Full element description defining visual and interactive properties.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0049B040)(ref this, layout, full_desc);

    /// <summary>Converts a gmSkillUI instance to the requested UI element type, returning either the base UIElement or the gmSkillUI itself when the type matches known identifiers.
    /// <code>Offset: 0x0049B090
    /// UIElement* __thiscall gmSkillUI::DynamicCast(gmSkillUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the desired type; certain values cause the function to return the corresponding base class pointer, others result in null.</param>
    /// <returns>Pointer to a UIElement matching the requested type, or nullptr if the conversion is not supported.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, uint, ACBindings.Internal.UIElement*>)0x0049B090)(ref this, i_eType);

    /// <summary>Returns the unique identifier of the skill UI element type.
    /// <code>Offset: 0x0049B0B0
    /// unsigned int __thiscall gmSkillUI::GetUIElementType(gmSkillUI*)</code>
    /// </summary>
    /// <returns>The unsigned integer ID corresponding to this UI element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, uint>)0x0049B0B0)(ref this);

    /// <summary>Initializes the skill UI, invoking base initialization and registering a global notice handler for skill-related events.
    /// <code>Offset: 0x0049B0C0
    /// void __thiscall gmSkillUI::PostInit(gmSkillUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, void>)0x0049B0C0)(ref this);

    /// <summary>Create a new skill UI element based on the supplied layout and element description.
    /// <code>Offset: 0x0049B100
    /// UIElement* __cdecl gmSkillUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout definition containing dimensions and child elements.</param>
    /// <param name="full_desc">Descriptor of the root UI element to instantiate.</param>
    /// <returns>Pointer to the created UIElement instance; may be null if memory allocation fails. Note that the current implementation does not initialize the return value, so its contents are undefined when allocation succeeds.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0049B100)(layout, full_desc);

    /// <summary>Computes the experience point cost required to increase the currently selected skill by up to ten levels, respecting maximum limits for trained and specialized advancements. Returns zero when no further advancement is possible.
    /// <code>Offset: 0x0049B130
    /// unsigned int __thiscall gmSkillUI::GetCostToRaise10(gmSkillUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player quality data used to determine current skill level and advancement class.</param>
    /// <returns>Unsigned integer representing total experience points needed to raise the selected skill; zero if advancement cannot occur.</returns>
    public uint GetCostToRaise10(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, uint>)0x0049B130)(ref this, i_playerDesc);

    /// <summary>Determines whether a supplied statistic corresponds to the UI's currently selected skill.
    /// <code>Offset: 0x0049B210
    /// bool __thiscall gmSkillUI::MessageIsFromSelectedElement(gmSkillUI*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="i_statType">The type of statistic to examine (unused in this check).</param>
    /// <param name="i_statEnum">Identifier of the statistic being tested against the selected skill.</param>
    /// <returns>True if i_statEnum matches the selected skill ID; otherwise, false.</returns>
    public byte MessageIsFromSelectedElement(ACBindings.Internal.StatType i_statType, uint i_statEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.StatType, uint, byte>)0x0049B210)(ref this, i_statType, i_statEnum);

    /// <summary>Registers the skill UI element class with the UI subsystem, associating a unique type ID with its creation callback.
    /// <code>Offset: 0x0049B290
    /// void __cdecl gmSkillUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0049B290)();

    /// <summary>Updates the skill selection based on the provided UI element, toggling the current selection if the same skill is chosen again and managing associated callbacks.
    /// <code>Offset: 0x0049B2B0
    /// bool __thiscall gmSkillUI::SetSelection(gmSkillUI*,UIElement*)</code>
    /// </summary>
    /// <param name="selectedUI">The UI element representing the skill to select; may be null to clear the selection.</param>
    /// <returns>True when a skill was set or cleared successfully; otherwise false.</returns>
    public byte SetSelection(ACBindings.Internal.UIElement* selectedUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.UIElement*, byte>)0x0049B2B0)(ref this, selectedUI);

    /// <summary>Displays default footer section of the skill UI, populating title and numeric values for skill credits and experience from a player’s qualities.
    /// <code>Offset: 0x0049B380
    /// bool __thiscall gmSkillUI::DisplayDefaultFooter(gmSkillUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player qualities providing skill credits and experience data.</param>
    /// <returns>True if the footer was successfully updated; always true in current implementation.</returns>
    public byte DisplayDefaultFooter(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, byte>)0x0049B380)(ref this, i_playerDesc);

    /// <summary>Displays the footer information for an untrained skill, showing the skill name, credits required to raise it, and the player’s current credit balance. Updates UI elements and enables or disables the raise button based on affordability.
    /// <code>Offset: 0x0049B5C0
    /// bool __thiscall gmSkillUI::DisplaySelectionFooter_Untrained(gmSkillUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player data used to determine current skill level and available credits.</param>
    /// <returns>True if the footer was successfully populated; otherwise false (should always succeed).</returns>
    public byte DisplaySelectionFooter_Untrained(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, byte>)0x0049B5C0)(ref this, i_playerDesc);

    /// <summary>Calculates the number of experience points required to raise the currently selected skill by one level for a player, accounting for trained and specialized advancement classes. Returns zero if the skill is already at its maximum level or no data is available.
    /// <code>Offset: 0x0049B8F0
    /// unsigned int __thiscall gmSkillUI::GetCostToRaise(gmSkillUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">The player's quality descriptor containing current skill statistics.</param>
    /// <returns>The experience point cost to raise the selected skill; zero if not applicable.</returns>
    public uint GetCostToRaise(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, uint>)0x0049B8F0)(ref this, i_playerDesc);

    /// <summary>Raises the currently selected skill by ten levels if the skill is eligible for training, updating UI state and triggering a training event.
    /// <code>Offset: 0x0049B9D0
    /// bool __thiscall gmSkillUI::Raise10Selection(gmSkillUI*)</code>
    /// </summary>
    /// <returns>True when the skill was successfully raised; otherwise false.</returns>
    public byte Raise10Selection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, byte>)0x0049B9D0)(ref this);

    /// <summary>Updates the skill selection footer UI to display information about a trained skill, including name, level progress, experience needed for the next level, and button states.
    /// <code>Offset: 0x0049BAD0
    /// bool __thiscall gmSkillUI::DisplaySelectionFooter_Trained(gmSkillUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player quality descriptor providing current skill levels and experience values used to populate the footer.</param>
    /// <returns>true if the footer was successfully updated; otherwise false (currently always true).</returns>
    public byte DisplaySelectionFooter_Trained(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, byte>)0x0049BAD0)(ref this, i_playerDesc);

    /// <summary>Adds a skill entry into the UI listbox at a position relative to specified elements, maintaining sorted order based on skill name.
    /// <code>Offset: 0x0049C040
    /// bool __thiscall gmSkillUI::AddSortedSkill(gmSkillUI*,unsigned int,const SkillBase*,UIElement*,UIElement*)</code>
    /// </summary>
    /// <param name="i_SkillID">Identifier of the skill to be added.</param>
    /// <param name="i_SkillBase">Pointer to the base data for the skill (name, icon, etc.).</param>
    /// <param name="i_pAfter">UI element after which the new skill should appear; must not be null.</param>
    /// <param name="i_pBefore">Optional UI element before which the new skill should appear; if null, appends at the end.</param>
    /// <returns>True if the skill was successfully inserted into the list; otherwise, false.</returns>
    public byte AddSortedSkill(uint i_SkillID, ACBindings.Internal.SkillBase* i_SkillBase, ACBindings.Internal.UIElement* i_pAfter, ACBindings.Internal.UIElement* i_pBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, uint, ACBindings.Internal.SkillBase*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte>)0x0049C040)(ref this, i_SkillID, i_SkillBase, i_pAfter, i_pBefore);

    /// <summary>Updates the UI to reflect the currently selected skill. Marks the appropriate token, fetches the player description, determines whether the skill is trained or not, and displays the corresponding footer.
    /// <code>Offset: 0x0049C310
    /// bool __thiscall gmSkillUI::UpdateSelection(gmSkillUI*)</code>
    /// </summary>
    /// <returns>True if the update succeeded; false if the player descriptor could not be retrieved or an error occurred.</returns>
    public byte UpdateSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, byte>)0x0049C310)(ref this);

    /// <summary>Processes results from a skill training dialog, retrieving the selected skill identifier, optional advancement class, and credits spent, then triggers a skill advancement event if all relevant data are present.
    /// <code>Offset: 0x0049C480
    /// void __cdecl gmSkillUI::TrainSkillDialogCallback(const PropertyCollection*)</code>
    /// </summary>
    /// <param name="i_rcResults">Property collection returned by the training dialog containing the skill ID, advancement class (if any), and credit amount spent.</param>
    public static void TrainSkillDialogCallback(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x0049C480)(i_rcResults);

    /// <summary>Rebuilds the skill list UI by clearing existing entries, loading the current player profile, and adding all skills sorted into specialized, trained, and untrained categories.
    /// <code>Offset: 0x0049C610
    /// bool __thiscall gmSkillUI::RebuildSkillList(gmSkillUI*)</code>
    /// </summary>
    /// <returns>True if the rebuild succeeded; otherwise false when required data cannot be loaded or an error occurs.</returns>
    public byte RebuildSkillList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, byte>)0x0049C610)(ref this);

    /// <summary>Updates the skill list UI after receiving a player's description.
    /// <code>Offset: 0x0049C840
    /// void __thiscall gmSkillUI::RecvNotice_PlayerDescReceived(gmSkillUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player qualities descriptor containing stats and attributes.</param>
    /// <param name="i_playerModule">Player module providing additional player state information.</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x0049C840)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Responds to a skill advancement class change notification by rebuilding the skill list displayed in the UI.
    /// <code>Offset: 0x0049C850
    /// void __thiscall gmSkillUI::RecvNotice_SkillAdvancementClassChanged(gmSkillUI*)</code>
    /// </summary>
    public void RecvNotice_SkillAdvancementClassChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, void>)0x0049C850)(ref this);

    /// <summary>Attempts to train the currently selected skill for a player by presenting a confirmation dialog that shows the training cost and skill name.
    /// <code>Offset: 0x0049C860
    /// bool __thiscall gmSkillUI::TrainSkill(gmSkillUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">The player's quality descriptor used to determine available skills and resources.</param>
    /// <returns>True if a skill is selected and the training prompt is shown; otherwise false when no skill is selected.</returns>
    public byte TrainSkill(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, byte>)0x0049C860)(ref this, i_playerDesc);

    /// <summary>Raises the currently selected skill for the player, training it if untrained or advancing its class otherwise.
    /// <code>Offset: 0x0049CB30
    /// bool __thiscall gmSkillUI::RaiseSelection(gmSkillUI*)</code>
    /// </summary>
    /// <returns>True when the operation succeeds; otherwise false if no skill is selected or an error occurs.</returns>
    public byte RaiseSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, byte>)0x0049CB30)(ref this);
}

