namespace ACBindings.Internal;


/// <summary>Provides the character generation profession interface, coordinating slider controls, lock states, available attribute credits, and template selections to reflect the player’s chosen role.</summary>
public unsafe struct gmCGProfessionPage
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmCGProfessionPage_vtbl
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
    // gmCGProfessionPage::EProfession
    public enum EProfession : byte
    {
        ECG_CUSTOM = 0x0,
        ECG_BOWHUNTER = 0x1,
        ECG_SWASHBUCKLER = 0x2,
        ECG_LIFECASTER = 0x3,
        ECG_WARMAGE = 0x4,
        ECG_WAYFARER = 0x5,
        ECG_SOLDIER = 0x6
    }

    /// <summary>Represents a profession attribute slider on the character generation page, coordinating its UI elements and lock status.</summary>
    public unsafe struct tagSlider
    {
        // Members
        public ACBindings.Internal.UIElement* pAttribField;
        public ACBindings.Internal.UIElement_Button* pLockButton;
        public ACBindings.Internal.UIElement_Text* pAttribText;
        public ACBindings.Internal.UIElement_Scrollbar* pSlider;
        public ACBindings.Internal.UIElement_Text* pAttibValue;
        public byte bLocked;

        // Methods
    }

    // Members
    public ACBindings.Internal.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.Internal.gmCharGenMainUI* m_pMainFramework;
    public ACBindings.Internal.UIElement_Text* m_pAvailableValue;
    public ACBindings.Internal.UIElement_Text* m_pHealthValue;
    public ACBindings.Internal.UIElement_Text* m_pStaminaValue;
    public ACBindings.Internal.UIElement_Text* m_pManaValue;
    public ACBindings.Internal.UIElement_Text* m_pTextBox;
    public ACBindings.Internal.UIElement_Button* m_pCurProfButton;
    public fixed byte m_tSliderArray_Raw[168];
    public ACBindings.Internal.gmCGProfessionPage.tagSlider* m_tSliderArray => (ACBindings.Internal.gmCGProfessionPage.tagSlider*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tSliderArray_Raw[0]);

    // Generated Constructor
    public gmCGProfessionPage(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>Initializes a new profession page UI element, setting up base fields and resetting internal references.
    /// <code>Offset: 0x00482260
    /// void __thiscall gmCGProfessionPage::gmCGProfessionPage(gmCGProfessionPage*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor used for base initialization.</param>
    /// <param name="full_desc">Element description defining the layout's elements.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00482260)(ref this, layout, full_desc);

    /// <summary>Attempts to cast the current gmCGProfessionPage instance to a requested type identifier, returning a UIElement pointer if the cast succeeds or null otherwise.
    /// <code>Offset: 0x004822F0
    /// UIElement* __thiscall gmCGProfessionPage::DynamicCast(gmCGProfessionPage*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The integer type identifier for which the object should be casted.</param>
    /// <returns>A UIElement pointer representing the casted object if the type matches; otherwise, nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, uint, ACBindings.Internal.UIElement*>)0x004822F0)(ref this, i_eType);

    /// <summary>Provides the unique UI element type identifier for the profession page.
    /// <code>Offset: 0x00482310
    /// unsigned int __thiscall gmCGProfessionPage::GetUIElementType(gmCGProfessionPage*)</code>
    /// </summary>
    /// <returns>The unsigned integer representing the UI element type; always returns 268435514 (0x10000002).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, uint>)0x00482310)(ref this);

    /// <summary>Creates a new profession page UI element using the specified layout and element description.
    /// <code>Offset: 0x00482320
    /// UIElement* __cdecl gmCGProfessionPage::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Pointer to a LayoutDesc structure defining screen dimensions and associated elements.</param>
    /// <param name="full_desc">Pointer to an ElementDesc that describes the root UI element for the profession page.</param>
    /// <returns>A pointer to the newly created UIElement instance, or nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00482320)(layout, full_desc);

    /// <summary>Retrieves the internal slider index corresponding to the specified UIElement.
    /// <code>Offset: 0x00482350
    /// int __thiscall gmCGProfessionPage::GetSliderIndex(gmCGProfessionPage*,UIElement*)</code>
    /// </summary>
    /// <param name="pSlider">The UIElement representing a slider whose identifier is mapped to an index.</param>
    /// <returns>The slider index (1–6) associated with the element; returns 0 if the element ID does not match any known slider.</returns>
    public int GetSliderIndex(ACBindings.Internal.UIElement* pSlider) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, ACBindings.Internal.UIElement*, int>)0x00482350)(ref this, pSlider);

    /// <summary>Locks or unlocks a profession slider based on its current state, updating UI components and notifying the character generation system accordingly.
    /// <code>Offset: 0x004823C0
    /// void __thiscall gmCGProfessionPage::SetLock(gmCGProfessionPage*,UIElement*)</code>
    /// </summary>
    /// <param name="pSlider">The UI element representing the slider whose lock status is to be toggled.</param>
    public void SetLock(ACBindings.Internal.UIElement* pSlider) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, ACBindings.Internal.UIElement*, void>)0x004823C0)(ref this, pSlider);

    /// <summary>Resets character‑generation attribute locks and reapplies lock state to any profession‑page sliders that were marked as locked.
    /// <code>Offset: 0x00482490
    /// void __thiscall gmCGProfessionPage::ClearLocks(gmCGProfessionPage*)</code>
    /// </summary>
    public void ClearLocks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, void>)0x00482490)(ref this);

    /// <summary>Registers the UI element class for the profession page, enabling it to be instantiated by the UI system.
    /// <code>Offset: 0x00482550
    /// void __cdecl gmCGProfessionPage::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00482550)();

    /// <summary>Refreshes the profession page by updating the displayed text and selecting the appropriate profession button based on the player’s current character generation state.
    /// <code>Offset: 0x00482570
    /// void __thiscall gmCGProfessionPage::UpdateProfession(gmCGProfessionPage*)</code>
    /// </summary>
    public void UpdateProfession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, void>)0x00482570)(ref this);

    /// <summary>Refreshes the character‑creation UI with current attribute values, updating sliders, text fields for remaining credits, health, stamina, and mana, then applies the selected template to the character and refreshes the profession display.
    /// <code>Offset: 0x00482810
    /// void __thiscall gmCGProfessionPage::UpdateAttributeValues(gmCGProfessionPage*)</code>
    /// </summary>
    public void UpdateAttributeValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, void>)0x00482810)(ref this);

    /// <summary>Synchronizes the profession page with the current character by fitting the template to the character data, updating displayed professions, and refreshing the attribute values shown on the UI.
    /// <code>Offset: 0x00482BF0
    /// void __thiscall gmCGProfessionPage::Update(gmCGProfessionPage*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, void>)0x00482BF0)(ref this);

    /// <summary>Resets all profession-related settings to their defaults by clearing locks, reapplying the current character template, and refreshing both the profession choice and individual attribute displays.
    /// <code>Offset: 0x00482C20
    /// void __thiscall gmCGProfessionPage::UpdateToDefaultAttributes(gmCGProfessionPage*)</code>
    /// </summary>
    public void UpdateToDefaultAttributes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, void>)0x00482C20)(ref this);

    /// <summary>Updates a character attribute based on slider movement, ensuring the new value does not exceed available credits, then refreshes displayed values.
    /// <code>Offset: 0x00482C50
    /// void __thiscall gmCGProfessionPage::SetAttribValue(gmCGProfessionPage*,UIElement*,int)</code>
    /// </summary>
    /// <param name="pSlider">UI element representing the slider whose position triggered the change.</param>
    /// <param name="iPos">Desired new value for the attribute associated with the slider.</param>
    public void SetAttribValue(ACBindings.Internal.UIElement* pSlider, int iPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, ACBindings.Internal.UIElement*, int, void>)0x00482C50)(ref this, pSlider, iPos);

    /// <summary>Handles UI messages on the character profession page, updating locks, attribute values, text input and template selections based on element identifiers and message types.
    /// <code>Offset: 0x00482D80
    /// UIElementMessageListenResult __thiscall gmCGProfessionPage::ListenToElementMessage(gmCGProfessionPage*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information describing the UI element interaction to process.</param>
    /// <returns>The result of handling the message, indicating whether it was consumed by this method or passed to the base class.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00482D80)(ref this, i_rMsg);

    /// <summary>Initializes the profession page UI by linking controls such as sliders, attribute fields, lock buttons, and text displays to their layout elements, retrieving player system data, setting up attribute names, and updating displayed values.
    /// <code>Offset: 0x00483110
    /// void __thiscall gmCGProfessionPage::InitializePage(gmCGProfessionPage*,gmCharGenMainUI*)</code>
    /// </summary>
    /// <param name="pMain">Pointer to the main character generation UI framework that hosts this page.</param>
    public void InitializePage(ACBindings.Internal.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, ACBindings.Internal.gmCharGenMainUI*, void>)0x00483110)(ref this, pMain);
}

