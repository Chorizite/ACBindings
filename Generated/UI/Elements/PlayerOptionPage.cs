namespace ACBindings.Internal;


/// <summary>Represents a page of player configuration options, extending the generic OptionPage with a dedicated list box for option items.</summary>
public unsafe struct PlayerOptionPage : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.OptionPage BaseClass_OptionPage; // ACBindings.Internal.OptionPage

    // Child Types
    public unsafe struct PlayerOptionPage_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OptionPage*, byte> SaveCurrentValues; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OptionPage*, byte> RestoreDefaultValues; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OptionPage*, byte> RestoreSavedValues; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OptionPage*, void> InitOptions; // function pointer

        // Methods
    }
    // PlayerOptionPage::OptionListType
    public enum OptionListType : byte
    {
        Header_OptionListType = 0x0,
        Seperator_OptionListType = 0x1,
        Boolean_OptionListType = 0x2,
        Float_OptionListType = 0x3,
        Menu_OptionListType = 0x4,
        BoolAndFloat_OptionListType = 0x5,
        FloatWithLabels_OptionListType = 0x6,
        BoolAndFloatWithLabels_OptionListType = 0x7,
        Bitfield64_OptionListType = 0x8
    }

    // Members
    public ACBindings.Internal.UIElement_ListBox* m_pOptionBox;

    // Generated Constructor
    public PlayerOptionPage(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a PlayerOptionPage instance with the specified layout and element descriptions, setting up base class interfaces and clearing the option box reference.
    /// <code>Offset: 0x004F32E0
    /// void __thiscall PlayerOptionPage::PlayerOptionPage(PlayerOptionPage*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout description containing dimensions and elements for the page.</param>
    /// <param name="full_desc">Element descriptor detailing the root UI element hierarchy.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004F32E0)(ref this, layout, full_desc);

    /// <summary>Destroys the PlayerOptionPage instance, releasing UI elements and option data while properly invoking base class destructors.
    /// <code>Offset: 0x004F3320
    /// void __thiscall PlayerOptionPage::~PlayerOptionPage(PlayerOptionPage*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, void>)0x004F3320)(ref this);

    /// <summary>Handles a change in the page’s visibility, forwarding to the base UI element and adjusting input action callbacks based on the new state.
    /// <code>Offset: 0x004F3340
    /// void __thiscall PlayerOptionPage::OnVisibilityChanged(PlayerOptionPage*,bool)</code>
    /// </summary>
    /// <param name="i_bVisibleNow">The new visibility status of the player option page.</param>
    public void OnVisibilityChanged(byte i_bVisibleNow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, byte, void>)0x004F3340)(ref this, i_bVisibleNow);

    /// <summary>Persists the current option values to the server and then saves them locally via the base class implementation.
    /// <code>Offset: 0x004F3370
    /// bool __thiscall PlayerOptionPage::SaveCurrentValues(PlayerOptionPage*)</code>
    /// </summary>
    /// <returns>True if the options were successfully saved; otherwise, false.</returns>
    public byte SaveCurrentValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, byte>)0x004F3370)(ref this);

    /// <summary>Inserts a separator element into the options list using template ID 1.
    /// <code>Offset: 0x004F3390
    /// bool __thiscall PlayerOptionPage::AddSeperator(PlayerOptionPage*)</code>
    /// </summary>
    /// <returns>True if the separator was added successfully; otherwise, false when the list box is null or the insertion fails.</returns>
    public byte AddSeperator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, byte>)0x004F3390)(ref this);

    /// <summary>Assigns localized label and tooltip strings to the specified checkbox option based on provided token identifiers.
    /// <code>Offset: 0x004F33B0
    /// void __thiscall PlayerOptionPage::SetToggleLabel(PlayerOptionPage*,UIOption_Checkbox*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="this">The PlayerOptionPage instance invoking the operation.</param>
    /// <param name="pToggle">Checkbox whose display text is updated.</param>
    /// <param name="tokLabel">Token ID for the label string in the localization table.</param>
    /// <param name="tokTooltip">Token ID for the tooltip string in the localization table.</param>
    public void SetToggleLabel(ACBindings.Internal.UIOption_Checkbox* pToggle, uint tokLabel, uint tokTooltip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, ACBindings.Internal.UIOption_Checkbox*, uint, uint, void>)0x004F33B0)(ref this, pToggle, tokLabel, tokTooltip);

    /// <summary>Updates child UI elements in response to an option change, enabling or disabling them based on whether the page’s options have been modified.
    /// <code>Offset: 0x004F3430
    /// void __thiscall PlayerOptionPage::OnOptionChanged(PlayerOptionPage*,const UIOption*)</code>
    /// </summary>
    /// <param name="this">The PlayerOptionPage instance whose options changed.</param>
    /// <param name="pOption">The UIOption that triggered the change event.</param>
    public void OnOptionChanged(ACBindings.Internal.UIOption* pOption) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, ACBindings.Internal.UIOption*, void>)0x004F3430)(ref this, pOption);

    /// <summary>Handles a confirmed change to a UI option by invoking its confirmation callback (if any) and then performing standard input action cleanup.
    /// <code>Offset: 0x004F34B0
    /// void __thiscall PlayerOptionPage::OnOptionChangeConfirmed(PlayerOptionPage*,const UIOption*,bool)</code>
    /// </summary>
    /// <param name="pOption">The UI option that was changed and confirmed.</param>
    /// <param name="bConfirm">True when the change has been accepted; otherwise false, causing only cleanup without executing a confirmation routine.</param>
    public void OnOptionChangeConfirmed(ACBindings.Internal.UIOption* pOption, byte bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, ACBindings.Internal.UIOption*, byte, void>)0x004F34B0)(ref this, pOption, bConfirm);

    /// <summary>Attempts to add a header entry to the options list box using the supplied string ID, creating an item from a template and setting its text if valid.
    /// <code>Offset: 0x004F3510
    /// bool __thiscall PlayerOptionPage::AddHeader(PlayerOptionPage*,unsigned int)</code>
    /// </summary>
    /// <param name="st">Identifier of the localized string used for the header's display text.</param>
    /// <returns>Always false; the return value does not indicate success.</returns>
    public byte AddHeader(uint st) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, uint, byte>)0x004F3510)(ref this, st);

    /// <summary>Adds a toggle‑with‑slider option to the player options page, registering it and configuring its preference data.
    /// <code>Offset: 0x004F3590
    /// UIOption* __thiscall PlayerOptionPage::AddToggleWithSliderOption(OptionPage*,int*,char**)</code>
    /// </summary>
    /// <param name="a2">Reference to an integer variable that holds the current value of the option.</param>
    /// <param name="a3">Pointer to an array of strings used as labels for the slider ticks (may be null).</param>
    /// <returns>Pointer to the created UIOption, or null if the option could not be added.</returns>
    public ACBindings.Internal.UIOption* AddToggleWithSliderOption(int* a2, sbyte** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, int*, sbyte**, ACBindings.Internal.UIOption*>)0x004F3590)(ref this, a2, a3);

    /// <summary>Adds a toggle option to the player options page from a predefined template and registers it with the change handler.
    /// <code>Offset: 0x004F35F0
    /// UIOption* __thiscall PlayerOptionPage::AddToggleOption(OptionPage*,int*)</code>
    /// </summary>
    /// <param name="a2">Optional data passed to the new option during initialization.</param>
    /// <returns>Pointer to the created UIOption, or null if the operation fails.</returns>
    public ACBindings.Internal.UIOption* AddToggleOption(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, int*, ACBindings.Internal.UIOption*>)0x004F35F0)(ref this, a2);

    /// <summary>Adds a toggle (checkbox) option to the page and returns its UI element.
    /// <code>Offset: 0x004F3660
    /// UIOption_Checkbox* __thiscall PlayerOptionPage::AddToggleOption(PlayerOptionPage*,PlayerOption)</code>
    /// </summary>
    /// <param name="po">The PlayerOption defining the checkbox’s behavior and state.</param>
    /// <returns>Pointer to the created UIOption_Checkbox, or nullptr if creation fails or no option box is available.</returns>
    public ACBindings.Internal.UIOption_Checkbox* AddToggleOption(ACBindings.Internal.PlayerOption po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, ACBindings.Internal.PlayerOption, ACBindings.Internal.UIOption_Checkbox*>)0x004F3660)(ref this, po);

    /// <summary>Adds a slider UI option to an options page, selecting the appropriate template based on the style flag and linking it to the supplied preference identifiers. Returns the newly created UIOption or null if creation fails.
    /// <code>Offset: 0x004F36D0
    /// UIOption* __thiscall PlayerOptionPage::AddSliderOption(OptionPage*,char**,char)</code>
    /// </summary>
    /// <param name="a2">Pointer to an array of strings identifying the preferences associated with the slider.</param>
    /// <param name="a3">Flag indicating which slider template to use (non‑zero selects alternate style).</param>
    /// <returns>Pointer to the created UIOption, or null if the option could not be added.</returns>
    public ACBindings.Internal.UIOption* AddSliderOption(sbyte** a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, sbyte**, sbyte, ACBindings.Internal.UIOption*>)0x004F36D0)(ref this, a2, a3);

    /// <summary>Creates a new menu option in the associated option page, configures its preference callback based on the flag, registers it with the page, and returns the UIOption instance.
    /// <code>Offset: 0x004F3750
    /// UIOption* __thiscall PlayerOptionPage::AddMenuOption(OptionPage*,bool (__cdecl**a2)(),char)</code>
    /// </summary>
    /// <param name="a2">Pointer to the function that will be invoked when the option changes; passed as the preference handler for the created UIOption.</param>
    /// <param name="a3">Flag indicating which type of preference callback to set: non‑zero selects a UI preference, zero selects a user preference.</param>
    /// <returns>Pointer to the newly added UIOption if successful; otherwise null.</returns>
    public ACBindings.Internal.UIOption* AddMenuOption(delegate* unmanaged[Cdecl]<byte>* a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, delegate* unmanaged[Cdecl]<byte>*, sbyte, ACBindings.Internal.UIOption*>)0x004F3750)(ref this, a2, a3);

    /// <summary>Updates the slider’s minimum and maximum label texts based on supplied token identifiers.
    /// <code>Offset: 0x004F37E0
    /// void __thiscall PlayerOptionPage::SetSliderLabel(PlayerOptionPage*,UIOption_Slider*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="pSlider">The slider control whose labels are updated.</param>
    /// <param name="tokMinLabel">Identifier of the string resource used for the minimum value label.</param>
    /// <param name="tokMaxLabel">Identifier of the string resource used for the maximum value label.</param>
    public void SetSliderLabel(ACBindings.Internal.UIOption_Slider* pSlider, uint tokMinLabel, uint tokMaxLabel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PlayerOptionPage, ACBindings.Internal.UIOption_Slider*, uint, uint, void>)0x004F37E0)(ref this, pSlider, tokMinLabel, tokMaxLabel);
}

