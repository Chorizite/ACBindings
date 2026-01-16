namespace ACBindings.Internal;


/// <summary>Displays character information in the game UI, aggregating player statistics, attributes, skills, augmentations, and load details into a formatted text panel.</summary>
public unsafe struct gmCharacterInfoUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler

    // Child Types
    public unsafe struct gmCharacterInfoUI_vtbl
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
    public ACBindings.Internal.UIElement_Text* m_pMainText;

    // Generated Constructor
    public gmCharacterInfoUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes the character info UI element, locating its main text child, registering a quality change handler, and subscribing to global notice events 5100016 and 5100064.
    /// <code>Offset: 0x004B9310
    /// void __thiscall gmCharacterInfoUI::PostInit(gmCharacterInfoUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, void>)0x004B9310)(ref this);

    /// <summary>Destroys the character information UI component, unregistering its notice handlers and cleaning up the quality change handler before releasing base UI resources.
    /// <code>Offset: 0x004B9370
    /// void __thiscall gmCharacterInfoUI::~gmCharacterInfoUI(gmCharacterInfoUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, void>)0x004B9370)(ref this);

    /// <summary>Attempts to dynamically cast a gmCharacterInfoUI object to the requested UI element type using its integer identifier.
    /// <code>Offset: 0x004B93D0
    /// UIElement* __thiscall gmCharacterInfoUI::DynamicCast(gmCharacterInfoUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The numeric type ID for which a cast is attempted.</param>
    /// <returns>Pointer to the corresponding UIElement if the requested type matches; otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, uint, ACBindings.Internal.UIElement*>)0x004B93D0)(ref this, i_eType);

    /// <summary>Retrieves the unique identifier representing the UI element type for gmCharacterInfoUI.
    /// <code>Offset: 0x004B93F0
    /// unsigned int __thiscall gmCharacterInfoUI::GetUIElementType(gmCharacterInfoUI*)</code>
    /// </summary>
    /// <returns>The unsigned integer ID that identifies this UI element type (268435482).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, uint>)0x004B93F0)(ref this);

    /// <summary>Updates the character info UI with the player’s innate attributes by querying the provided quality descriptor and appending formatted values to the main text element.
    /// <code>Offset: 0x004B9400
    /// bool __thiscall gmCharacterInfoUI::UpdateInnateAttributeInfo(gmCharacterInfoUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="this">The UI instance being updated.</param>
    /// <param name="i_playerDesc">Quality descriptor containing the player's attribute data.</param>
    /// <returns>Always true, indicating success.</returns>
    public byte UpdateInnateAttributeInfo(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, ACBindings.Internal.CACQualities*, byte>)0x004B9400)(ref this, i_playerDesc);

    /// <summary>Updates the character info UI with fake skill values extracted from a player description, appending them to the main text element.
    /// <code>Offset: 0x004B9550
    /// bool __thiscall gmCharacterInfoUI::UpdateFakeSkills(gmCharacterInfoUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player qualities providing the fake Chess rank and Fishing skill values.</param>
    /// <returns>Always true after successfully updating the UI.</returns>
    public byte UpdateFakeSkills(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, ACBindings.Internal.CACQualities*, byte>)0x004B9550)(ref this, i_playerDesc);

    /// <summary>Updates the character info UI text with load and augmentation details from the supplied player qualities.
    /// <code>Offset: 0x004B9640
    /// bool __thiscall gmCharacterInfoUI::UpdateLoad(gmCharacterInfoUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player quality description containing weight, capacity, and augmentations.</param>
    /// <returns>True after updating the UI; function always succeeds.</returns>
    public byte UpdateLoad(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, ACBindings.Internal.CACQualities*, byte>)0x004B9640)(ref this, i_playerDesc);

    /// <summary>
    /// Initializes a character information user interface element by configuring its base UI fields with the specified layout and element description, establishing notice and quality change handlers, and clearing the main text reference.
    /// 
    /// <code>Offset: 0x004B9800
    /// void __thiscall gmCharacterInfoUI::gmCharacterInfoUI(gmCharacterInfoUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining display dimensions and elements for the UI.</param>
    /// <param name="full_desc">Element descriptor providing detailed properties of the root UI element.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004B9800)(ref this, layout, full_desc);

    /// <summary>Registers the character info UI element type with the UI system, enabling instance creation via layout descriptors.
    /// <code>Offset: 0x004B98B0
    /// void __cdecl gmCharacterInfoUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004B98B0)();

    /// <summary>Updates the character information panel with the player’s birth date, current age duration, death statistics, and enlightenment achievements based on the supplied quality data.
    /// <code>Offset: 0x004B98D0
    /// bool __thiscall gmCharacterInfoUI::UpdatePlayerBirthAgeDeaths(gmCharacterInfoUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmCharacterInfoUI instance whose main text element will be updated.</param>
    /// <param name="i_playerDesc">Qualities structure containing the player's attributes used for the information display.</param>
    /// <returns>True after successfully appending all relevant information to the UI element.</returns>
    public byte UpdatePlayerBirthAgeDeaths(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, ACBindings.Internal.CACQualities*, byte>)0x004B98D0)(ref this, i_playerDesc);

    /// <summary>Updates the character info UI with endurance status by reading two quality attributes from the player description, mapping their combined values into descriptive tiers (None, Poor, Mediocre, Hardy, Resilient, Indomitable), and appending this information to the main text element.
    /// <code>Offset: 0x004B9B40
    /// bool __thiscall gmCharacterInfoUI::UpdateEnduranceInfo(gmCharacterInfoUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Pointer to the player's quality data used to query endurance-related attributes.</param>
    /// <returns>True after successfully updating the UI with the endurance information.</returns>
    public byte UpdateEnduranceInfo(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, ACBindings.Internal.CACQualities*, byte>)0x004B9B40)(ref this, i_playerDesc);

    /// <summary>Populates the character information UI with augmentation details derived from the supplied quality data.
    /// <code>Offset: 0x004B9C90
    /// bool __thiscall gmCharacterInfoUI::UpdateAugmentations(gmCharacterInfoUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player's CACQualities object containing current augmentations and mastery levels.</param>
    /// <returns>True when the UI has been updated successfully.</returns>
    public byte UpdateAugmentations(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, ACBindings.Internal.CACQualities*, byte>)0x004B9C90)(ref this, i_playerDesc);

    /// <summary>Refreshes the character information display by updating the main text field with data such as birth age, deaths, endurance, attributes, skills, augmentations, and load.
    /// <code>Offset: 0x004BB420
    /// bool __thiscall gmCharacterInfoUI::Update(gmCharacterInfoUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Qualities describing the player character to display.</param>
    /// <returns>True if the UI was updated; false if the element is not currently active.</returns>
    public byte Update(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, ACBindings.Internal.CACQualities*, byte>)0x004BB420)(ref this, i_playerDesc);

    /// <summary>Receives a player description notice and refreshes the character information display with updated qualities.
    /// <code>Offset: 0x004BB5C0
    /// void __thiscall gmCharacterInfoUI::RecvNotice_PlayerDescReceived(gmCharacterInfoUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="this">The UI component handling the notice.</param>
    /// <param name="i_playerDesc">Qualities of the player to be displayed.</param>
    /// <param name="i_playerModule">Additional module data for the player (unused in this implementation).</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004BB5C0)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Updates the character information UI based on the current player data.
    /// <code>Offset: 0x004BB5E0
    /// bool __thiscall gmCharacterInfoUI::Update(gmCharacterInfoUI*)</code>
    /// </summary>
    /// <returns>True when the UI was successfully updated; otherwise false.</returns>
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, byte>)0x004BB5E0)(ref this);

    /// <summary>Handles UI element messages, updating the character information display when a specific update message is received.
    /// <code>Offset: 0x004BB690
    /// UIElementMessageListenResult __thiscall gmCharacterInfoUI::ListenToElementMessage(gmCharacterInfoUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">The gmCharacterInfoUI instance receiving the message.</param>
    /// <param name="i_rMsg">Information about the UI message being processed.</param>
    /// <returns>The result of delegating to the base UIElement implementation.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004BB690)(ref this, i_rMsg);

    /// <summary>Refreshes the character info display in response to a load change notification by invoking the associated UI update routine.
    /// <code>Offset: 0x004BB6C0
    /// void __thiscall gmCharacterInfoUI::RecvNotice_LoadChanged(gmCharacterInfoUI*,float)</code>
    /// </summary>
    /// <param name="fNewLoad">The updated load value that triggered the notice.</param>
    public void RecvNotice_LoadChanged(float fNewLoad) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, float, void>)0x004BB6C0)(ref this, fNewLoad);

    /// <summary>Updates the character information UI when a related game object changes its quality state.
    /// <code>Offset: 0x004BB6D0
    /// void __thiscall gmCharacterInfoUI::OnQualityChanged(gmCharacterInfoUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="this">The gmCharacterInfoUI instance whose display must be refreshed.</param>
    /// <param name="cwobj">Pointer to the CWeenieObject that triggered the change.</param>
    /// <param name="stype">StatType indicating which statistic caused the update.</param>
    /// <param name="senum">Unsigned integer representing the new quality level or enumeration value.</param>
    public void OnQualityChanged(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterInfoUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004BB6D0)(ref this, cwobj, stype, senum);
}

