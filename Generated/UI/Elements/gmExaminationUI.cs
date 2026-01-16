namespace ACBindings.Internal;


/// <summary>Handles the user interface for examining items, creatures, characters, and spells within the game, coordinating sub‑UI components, appraisal logic, and user input events.</summary>
public unsafe struct gmExaminationUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmExaminationUI_vtbl
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
    public ACBindings.Internal.ExamineSubUI* m_activeUI;
    public ACBindings.Internal.ItemExamineUI* m_itemUI;
    public ACBindings.Internal.CreatureExamineUI* m_creatureUI;
    public ACBindings.Internal.CharExamineUI* m_charUI;
    public ACBindings.Internal.SpellExamineUI* m_spellUI;
    public ACBindings.Internal.UIElement_Text* m_displayedNameText;
    public uint awaiting_appraisal_ID;
    public uint current_appraisal_ID;
    public byte m_examineNewlySelectedItem;
    public double m_timeNextUpdate;

    // Generated Constructor
    public gmExaminationUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a gmExaminationUI instance by constructing its base UI element with the supplied layout and full description, then clears all sub‑UI pointers and appraisal state.
    /// <code>Offset: 0x004AB630
    /// void __thiscall gmExaminationUI::gmExaminationUI(gmExaminationUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining dimensions and elements for the examination UI.</param>
    /// <param name="full_desc">Full element description used to build the underlying UI structure.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004AB630)(ref this, layout, full_desc);

    /// <summary>Returns a pointer to the specified UIElement-derived class represented by the current gmExaminationUI object, or nullptr when the cast is invalid.
    /// <code>Offset: 0x004AB6B0
    /// UIElement* __thiscall gmExaminationUI::DynamicCast(gmExaminationUI*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The gmExaminationUI instance on which the cast is performed.</param>
    /// <param name="i_eType">Identifier of the desired element type; for example, 268435484 requests the base UIElement, while 3 requests the gmExaminationUI itself.</param>
    /// <returns>A pointer to the requested UIElement if the object matches that type; otherwise, null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, ACBindings.Internal.UIElement*>)0x004AB6B0)(ref this, i_eType);

    /// <summary>Returns the unique identifier for the examination user interface element, used by the UI framework to distinguish this component from others.
    /// <code>Offset: 0x004AB6D0
    /// unsigned int __thiscall gmExaminationUI::GetUIElementType(gmExaminationUI*)</code>
    /// </summary>
    /// <returns>The unsigned integer ID corresponding to the gmExaminationUI element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint>)0x004AB6D0)(ref this);

    /// <summary>Creates a new examination user interface from the specified layout and element descriptions.
    /// <code>Offset: 0x004AB6E0
    /// UIElement* __cdecl gmExaminationUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor providing dimensions, elements, and state headers for the UI.</param>
    /// <param name="full_desc">Element descriptor defining the root UI element to instantiate.</param>
    /// <returns>A pointer to the created UIElement representing the examination interface, or null if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004AB6E0)(layout, full_desc);

    /// <summary>Handles actions received by child UI elements, forwarding them to the base implementation unless a specific input action occurs on the item inscription text during its start phase, which is then suppressed.
    /// <code>Offset: 0x004AB710
    /// bool __thiscall gmExaminationUI::OnChildAction(gmExaminationUI*,const UIElement*,const InputEvent*)</code>
    /// </summary>
    /// <param name="i_pChild">The child UI element that triggered the action.</param>
    /// <param name="i_evt">Details of the input event associated with the action.</param>
    /// <returns>True if the action was handled by the base implementation; false if it was suppressed.</returns>
    public byte OnChildAction(ACBindings.Internal.UIElement* i_pChild, ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte>)0x004AB710)(ref this, i_pChild, i_evt);

    /// <summary>Responds to a selection change notice by examining the currently selected object if one is chosen; otherwise it clears the active examination view.
    /// <code>Offset: 0x004AB750
    /// void __thiscall gmExaminationUI::RecvNotice_SelectionChanged(gmExaminationUI*)</code>
    /// </summary>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, void>)0x004AB750)(ref this);

    /// <summary>Activates the supplied Examination Sub‑UI, updating visibility of all related sub‑UIs so that only the chosen UI is shown.
    /// <code>Offset: 0x004AB7A0
    /// void __thiscall gmExaminationUI::SetActiveExamineUI(gmExaminationUI*,ExamineSubUI*)</code>
    /// </summary>
    /// <param name="ui">The ExamineSubUI instance to activate.</param>
    public void SetActiveExamineUI(ACBindings.Internal.ExamineSubUI* ui) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, ACBindings.Internal.ExamineSubUI*, void>)0x004AB7A0)(ref this, ui);

    /// <summary>Periodically processes appraisal events for the currently examined creature or character while in combat mode, updating every 750 milliseconds.
    /// <code>Offset: 0x004AB8B0
    /// void __thiscall gmExaminationUI::UseTime(gmExaminationUI*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, void>)0x004AB8B0)(ref this);

    /// <summary>Registers the gmExaminationUI element class with the UI framework, enabling creation of instances via the designated factory method.
    /// <code>Offset: 0x004ABB00
    /// void __cdecl gmExaminationUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004ABB00)();

    /// <summary>Responds to a global message by invoking the UI’s time update routine when the message id equals 3.
    /// <code>Offset: 0x004ABB20
    /// void __thiscall gmExaminationUI::ListenToGlobalMessage(gmExaminationUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the received global message.</param>
    /// <param name="i_data_int">Additional integer data attached to the message (ignored in this implementation).</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, int, void>)0x004ABB20)(ref this, i_messageID, i_data_int);

    /// <summary>Receives a notice to examine an object; stores the object ID for appraisal, triggers the appraisal event, and marks the UI system busy when required.
    /// <code>Offset: 0x004ABB30
    /// void __thiscall gmExaminationUI::RecvNotice_ExamineObject(gmExaminationUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_objid">The identifier of the object requested for examination.</param>
    public void RecvNotice_ExamineObject(uint i_objid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, void>)0x004ABB30)(ref this, i_objid);

    /// <summary>Updates spell examination UI components when a component change notice is received.
    /// <code>Offset: 0x004AC3C0
    /// void __thiscall gmExaminationUI::RecvNotice_UpdateSpellComponents(gmExaminationUI*,int)</code>
    /// </summary>
    /// <param name="i_change">Specifies the type of component update to perform, as defined by ComponentTrackerUpdate.</param>
    public void RecvNotice_UpdateSpellComponents(int i_change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, int, void>)0x004AC3C0)(ref this, i_change);

    /// <summary>Initializes the examination UI by creating sub‑UI components for items, creatures, characters and spells, locating the displayed name text element, registering global message listeners, subscribing to various notice handlers, and activating the default item examine interface.
    /// <code>Offset: 0x004ADA20
    /// void __thiscall gmExaminationUI::PostInit(gmExaminationUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, void>)0x004ADA20)(ref this);

    /// <summary>Handles a server notification indicating that an item has moved from one container or location to another, updating the examination UI accordingly and refreshing the item's editable inscription state if it is currently being examined.
    /// <code>Offset: 0x004ADB80
    /// void __thiscall gmExaminationUI::RecvNotice_ServerSaysMoveItem(gmExaminationUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the item that was moved.</param>
    /// <param name="oldContainer">Identifier of the original container holding the item.</param>
    /// <param name="oldWielder">Identifier of the previous wielder (if any).</param>
    /// <param name="oldLocation">Previous slot or location index within the old container.</param>
    /// <param name="newContainer">Identifier of the new container receiving the item.</param>
    /// <param name="place">Desired position or order within the new container.</param>
    /// <param name="newWielder">Identifier of the new wielder (if any).</param>
    /// <param name="newLocation">New slot or location index within the new container.</param>
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004ADB80)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>Destroys the gmExaminationUI instance, freeing any sub‑UIs it owns (item, creature, character, spell) and deregistering its notice handlers from global event systems.
    /// <code>Offset: 0x004ADBD0
    /// void __thiscall gmExaminationUI::~gmExaminationUI(gmExaminationUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, void>)0x004ADBD0)(ref this);

    /// <summary>Sets the title text displayed by the examination UI to the given item name, optionally appending a stack count when more than one item is selected.
    /// <code>Offset: 0x004ADCB0
    /// void __thiscall gmExaminationUI::SetTitleText(gmExaminationUI*,const char*,int)</code>
    /// </summary>
    /// <param name="name">Item name to display.</param>
    /// <param name="stack">Number of items stacked; if greater than 1, appended after the name separated by a space.</param>
    public void SetTitleText(sbyte* name, int stack) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, sbyte*, int, void>)0x004ADCB0)(ref this, name, stack);

    /// <summary>Updates the examination UI with appraisal information for the specified object ID using the provided profile. Handles transitioning between awaiting and current appraisals, determines whether the object is a creature, character, or item, updates the title text, initializes the appropriate sub‑UI component, and activates it if needed.
    /// <code>Offset: 0x004ADE60
    /// void __thiscall gmExaminationUI::SetAppraiseInfo(gmExaminationUI*,unsigned int,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="objid">The unique identifier of the object being examined.</param>
    /// <param name="prof">Pointer to an AppraisalProfile containing information about the object's attributes.</param>
    public void SetAppraiseInfo(uint objid, ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, ACBindings.Internal.AppraisalProfile*, void>)0x004ADE60)(ref this, objid, prof);

    /// <summary>Processes UI element messages for the examination interface, handling special cases such as inscription interactions and component selection before delegating to the base UI element listener.
    /// <code>Offset: 0x004B6CE0
    /// UIElementMessageListenResult __thiscall gmExaminationUI::ListenToElementMessage(gmExaminationUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmExaminationUI instance receiving the message.</param>
    /// <param name="i_rMsg">Structure containing element ID, message type, parameters, and coordinates of the event.</param>
    /// <returns>Result returned by the underlying UIElement::ListenToElementMessage call after any custom handling is performed.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004B6CE0)(ref this, i_rMsg);

    /// <summary>Receives an appraisal notice with object ID and profile, then forwards the information to SetAppraiseInfo for processing.
    /// <code>Offset: 0x004B6E20
    /// void __thiscall gmExaminationUI::RecvNotice_SetAppraiseInfo(gmExaminationUI*,unsigned int,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="i_objid">The identifier of the object being appraised.</param>
    /// <param name="i_prof">Pointer to the AppraisalProfile containing appraisal details.</param>
    public void RecvNotice_SetAppraiseInfo(uint i_objid, ACBindings.Internal.AppraisalProfile* i_prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, ACBindings.Internal.AppraisalProfile*, void>)0x004B6E20)(ref this, i_objid, i_prof);

    /// <summary>
    /// Handles receipt of a spell examination notice by clearing pending appraisal status, updating UI components, and displaying the specified spell’s details.
    /// 
    /// <code>Offset: 0x004B75A0
    /// void __thiscall gmExaminationUI::RecvNotice_ExamineSpell(gmExaminationUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_spellid">Identifier of the spell to examine.</param>
    public void RecvNotice_ExamineSpell(uint i_spellid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExaminationUI, uint, void>)0x004B75A0)(ref this, i_spellid);
}

