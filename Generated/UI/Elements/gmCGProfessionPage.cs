namespace ACBindings.Internal;

public unsafe struct gmCGProfessionPage
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmCGProfessionPage_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00482260
    /// void __thiscall gmCGProfessionPage::gmCGProfessionPage(gmCGProfessionPage*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00482260)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004822F0
    /// UIElement* __thiscall gmCGProfessionPage::DynamicCast(gmCGProfessionPage*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, uint, ACBindings.Internal.UIElement*>)0x004822F0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x00482310
    /// unsigned int __thiscall gmCGProfessionPage::GetUIElementType(gmCGProfessionPage*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, uint>)0x00482310)(ref this);

    /// <summary>
    /// <code>Offset: 0x00482320
    /// UIElement* __cdecl gmCGProfessionPage::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00482320)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x00482350
    /// int __thiscall gmCGProfessionPage::GetSliderIndex(gmCGProfessionPage*,UIElement*)</code>
    /// </summary>
    public int GetSliderIndex(ACBindings.Internal.UIElement* pSlider) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, ACBindings.Internal.UIElement*, int>)0x00482350)(ref this, pSlider);

    /// <summary>
    /// <code>Offset: 0x004823C0
    /// void __thiscall gmCGProfessionPage::SetLock(gmCGProfessionPage*,UIElement*)</code>
    /// </summary>
    public void SetLock(ACBindings.Internal.UIElement* pSlider) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, ACBindings.Internal.UIElement*, void>)0x004823C0)(ref this, pSlider);

    /// <summary>
    /// <code>Offset: 0x00482490
    /// void __thiscall gmCGProfessionPage::ClearLocks(gmCGProfessionPage*)</code>
    /// </summary>
    public void ClearLocks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, void>)0x00482490)(ref this);

    /// <summary>
    /// <code>Offset: 0x00482550
    /// void __cdecl gmCGProfessionPage::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00482550)();

    /// <summary>
    /// <code>Offset: 0x00482570
    /// void __thiscall gmCGProfessionPage::UpdateProfession(gmCGProfessionPage*)</code>
    /// </summary>
    public void UpdateProfession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, void>)0x00482570)(ref this);

    /// <summary>
    /// <code>Offset: 0x00482810
    /// void __thiscall gmCGProfessionPage::UpdateAttributeValues(gmCGProfessionPage*)</code>
    /// </summary>
    public void UpdateAttributeValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, void>)0x00482810)(ref this);

    /// <summary>
    /// <code>Offset: 0x00482BF0
    /// void __thiscall gmCGProfessionPage::Update(gmCGProfessionPage*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, void>)0x00482BF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00482C20
    /// void __thiscall gmCGProfessionPage::UpdateToDefaultAttributes(gmCGProfessionPage*)</code>
    /// </summary>
    public void UpdateToDefaultAttributes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, void>)0x00482C20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00482C50
    /// void __thiscall gmCGProfessionPage::SetAttribValue(gmCGProfessionPage*,UIElement*,int)</code>
    /// </summary>
    public void SetAttribValue(ACBindings.Internal.UIElement* pSlider, int iPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, ACBindings.Internal.UIElement*, int, void>)0x00482C50)(ref this, pSlider, iPos);

    /// <summary>
    /// <code>Offset: 0x00482D80
    /// UIElementMessageListenResult __thiscall gmCGProfessionPage::ListenToElementMessage(gmCGProfessionPage*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00482D80)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x00483110
    /// void __thiscall gmCGProfessionPage::InitializePage(gmCGProfessionPage*,gmCharGenMainUI*)</code>
    /// </summary>
    public void InitializePage(ACBindings.Internal.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGProfessionPage, ACBindings.Internal.gmCharGenMainUI*, void>)0x00483110)(ref this, pMain);
}

