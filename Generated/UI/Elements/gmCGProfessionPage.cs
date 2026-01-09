namespace ACBindings;

// gmCGProfessionPage
public unsafe struct gmCGProfessionPage
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmCGProfessionPage_vtbl
    public unsafe struct gmCGProfessionPage_vtbl
    {
        // Members
        public System.IntPtr UIListener_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer
        public System.IntPtr SetVisible; // function pointer
        public System.IntPtr SetShouldBlockClicks; // function pointer
        public System.IntPtr SetShouldEraseBackground; // function pointer
        public System.IntPtr SetClampGameViewEdge; // function pointer
        public System.IntPtr CheckOverOverride; // function pointer
        public System.IntPtr MoveTo; // function pointer
        public System.IntPtr ResizeTo; // function pointer
        public System.IntPtr GetSurfaceBox; // function pointer
        public System.IntPtr CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public System.IntPtr SetParent; // function pointer
        public fixed byte gap48[4];
        public System.IntPtr MouseMove; // function pointer
        public System.IntPtr MouseOver; // function pointer
        public System.IntPtr MouseOverTop; // function pointer
        public System.IntPtr MouseHover; // function pointer
        public System.IntPtr MouseUnhover; // function pointer
        public System.IntPtr MouseDown; // function pointer
        public System.IntPtr MouseUp; // function pointer
        public System.IntPtr HasCursor; // function pointer
        public System.IntPtr AddChild; // function pointer
        public System.IntPtr RemoveChild; // function pointer
        public System.IntPtr DrawStart; // function pointer
        public System.IntPtr EraseBackground; // function pointer
        public System.IntPtr PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public System.IntPtr PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public System.IntPtr DrawDone; // function pointer
        public System.IntPtr MouseTap; // function pointer
        public System.IntPtr DynamicCast; // function pointer
        public System.IntPtr GetUIElementType; // function pointer
        public System.IntPtr SetState; // function pointer
        public System.IntPtr GetParent; // function pointer
        public System.IntPtr GetAncestorByID; // function pointer
        public System.IntPtr KeyUp; // function pointer
        public System.IntPtr KeyDown; // function pointer
        public System.IntPtr RegisterInputMaps; // function pointer
        public System.IntPtr UnregisterInputMaps; // function pointer
        public System.IntPtr OnChildAction; // function pointer
        public System.IntPtr Initialize; // function pointer
        public System.IntPtr PostInit; // function pointer
        public System.IntPtr InqAvailableProperties; // function pointer
        public System.IntPtr OnSetAttribute; // function pointer
        public System.IntPtr ContainsProperty; // function pointer
        public System.IntPtr InqProperty; // function pointer
        public System.IntPtr SetProperty; // function pointer
        public fixed byte gapD8[4];
        public System.IntPtr CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public System.IntPtr DragAndDropComplete; // function pointer
        public System.IntPtr DragItem; // function pointer
        public System.IntPtr GetDragAndDropCatcher; // function pointer
        public System.IntPtr MatchElement; // function pointer
        public System.IntPtr UpdateForChildSizeChange; // function pointer
        public System.IntPtr UpdateForParentVisibilityChange; // function pointer
        public System.IntPtr Activate; // function pointer
        public System.IntPtr Deactivate; // function pointer
        public System.IntPtr TakeFocus; // function pointer
        public System.IntPtr RelinquishFocus; // function pointer
        public System.IntPtr GetActivatable; // function pointer
        public System.IntPtr SetMouseVisible; // function pointer
        public System.IntPtr UpdateForScreenPositionChange; // function pointer
        public System.IntPtr SetUIObject; // function pointer
        public System.IntPtr MakeUIObject; // function pointer
        public System.IntPtr OnChildActivationChanged; // function pointer
        public System.IntPtr GetShouldBeMouseVisible; // function pointer
        public System.IntPtr ForwardElementMessage; // function pointer
        public System.IntPtr DefElementMessageHandler; // function pointer
        public System.IntPtr OnVisibilityChanged; // function pointer
        public System.IntPtr Initialized; // function pointer

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
    // gmCGProfessionPage::tagSlider
    public unsafe struct tagSlider
    {
        // Members
        public ACBindings.UIElement* pAttribField;
        public ACBindings.UIElement_Button* pLockButton;
        public ACBindings.UIElement_Text* pAttribText;
        public ACBindings.UIElement_Scrollbar* pSlider;
        public ACBindings.UIElement_Text* pAttibValue;
        public byte bLocked;

        // Methods
    }

    // Members
    public ACBindings.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.gmCharGenMainUI* m_pMainFramework;
    public ACBindings.UIElement_Text* m_pAvailableValue;
    public ACBindings.UIElement_Text* m_pHealthValue;
    public ACBindings.UIElement_Text* m_pStaminaValue;
    public ACBindings.UIElement_Text* m_pManaValue;
    public ACBindings.UIElement_Text* m_pTextBox;
    public ACBindings.UIElement_Button* m_pCurProfButton;
    public fixed byte m_tSliderArray_Raw[168];
    public ACBindings.gmCGProfessionPage.tagSlider* m_tSliderArray => (ACBindings.gmCGProfessionPage.tagSlider*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tSliderArray_Raw[0]);

    // Generated Constructor
    public gmCGProfessionPage(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods
    // void __thiscall gmCGProfessionPage::gmCGProfessionPage(gmCGProfessionPage*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGProfessionPage, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x00482260)(ref this, layout, full_desc);
    // UIElement* __thiscall gmCGProfessionPage::DynamicCast(gmCGProfessionPage*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGProfessionPage, uint, ACBindings.UIElement*>)0x004822F0)(ref this, i_eType);
    // unsigned int __thiscall gmCGProfessionPage::GetUIElementType(gmCGProfessionPage*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGProfessionPage, uint>)0x00482310)(ref this);
    // UIElement* __cdecl gmCGProfessionPage::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x00482320)(layout, full_desc);
    // int __thiscall gmCGProfessionPage::GetSliderIndex(gmCGProfessionPage*,UIElement*)
    public int GetSliderIndex(ACBindings.UIElement* pSlider) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGProfessionPage, ACBindings.UIElement*, int>)0x00482350)(ref this, pSlider);
    // void __thiscall gmCGProfessionPage::SetLock(gmCGProfessionPage*,UIElement*)
    public void SetLock(ACBindings.UIElement* pSlider) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGProfessionPage, ACBindings.UIElement*, void>)0x004823C0)(ref this, pSlider);
    // void __thiscall gmCGProfessionPage::ClearLocks(gmCGProfessionPage*)
    public void ClearLocks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGProfessionPage, void>)0x00482490)(ref this);
    // void __cdecl gmCGProfessionPage::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00482550)();
    // void __thiscall gmCGProfessionPage::UpdateProfession(gmCGProfessionPage*)
    public void UpdateProfession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGProfessionPage, void>)0x00482570)(ref this);
    // void __thiscall gmCGProfessionPage::UpdateAttributeValues(gmCGProfessionPage*)
    public void UpdateAttributeValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGProfessionPage, void>)0x00482810)(ref this);
    // void __thiscall gmCGProfessionPage::Update(gmCGProfessionPage*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGProfessionPage, void>)0x00482BF0)(ref this);
    // void __thiscall gmCGProfessionPage::UpdateToDefaultAttributes(gmCGProfessionPage*)
    public void UpdateToDefaultAttributes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGProfessionPage, void>)0x00482C20)(ref this);
    // void __thiscall gmCGProfessionPage::SetAttribValue(gmCGProfessionPage*,UIElement*,int)
    public void SetAttribValue(ACBindings.UIElement* pSlider, int iPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGProfessionPage, ACBindings.UIElement*, int, void>)0x00482C50)(ref this, pSlider, iPos);
    // UIElementMessageListenResult __thiscall gmCGProfessionPage::ListenToElementMessage(gmCGProfessionPage*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGProfessionPage, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00482D80)(ref this, i_rMsg);
    // void __thiscall gmCGProfessionPage::InitializePage(gmCGProfessionPage*,gmCharGenMainUI*)
    public void InitializePage(ACBindings.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGProfessionPage, ACBindings.gmCharGenMainUI*, void>)0x00483110)(ref this, pMain);
}

