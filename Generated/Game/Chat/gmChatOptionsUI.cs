namespace ACBindings;

// gmChatOptionsUI
public unsafe struct gmChatOptionsUI : System.IDisposable
{
    // Base Classes
    public ACBindings.PlayerOptionPage BaseClass_PlayerOptionPage; // ACBindings.PlayerOptionPage
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmChatOptionsUI_vtbl
    public unsafe struct gmChatOptionsUI_vtbl
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
        public System.IntPtr SaveCurrentValues; // function pointer
        public System.IntPtr RestoreDefaultValues; // function pointer
        public System.IntPtr RestoreSavedValues; // function pointer
        public System.IntPtr InitOptions; // function pointer

        // Methods
    }

    // Members
    public ACBindings.DualHash__UIOption_Slider_ptr__UIOption_Slider_ptr m_hashSliderLinks;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // UIElementMessageListenResult __thiscall gmChatOptionsUI::ListenToElementMessage(gmConfigUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmChatOptionsUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0049E620)(ref this, i_rMsg);
    // UIOption_CheckboxBitfield64* __thiscall gmChatOptionsUI::AddCheckboxBitfield64Option(gmChatOptionsUI*,const unsigned int*,unsigned int)
    public ACBindings.UIOption_CheckboxBitfield64* AddCheckboxBitfield64Option(uint* i_ePropName, uint i_nUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmChatOptionsUI, uint*, uint, ACBindings.UIOption_CheckboxBitfield64*>)0x0049F020)(ref this, i_ePropName, i_nUserData);
    // void __thiscall gmChatOptionsUI::PostInit(gmChatOptionsUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmChatOptionsUI, void>)0x0049F380)(ref this);
    // void __thiscall gmChatOptionsUI::OnOptionChanged(gmChatOptionsUI*,const UIOption*)
    public void OnOptionChanged(ACBindings.UIOption* pOption) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmChatOptionsUI, ACBindings.UIOption*, void>)0x0049F890)(ref this, pOption);
    // UIElement* __thiscall gmChatOptionsUI::DynamicCast(gmChatOptionsUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmChatOptionsUI, uint, ACBindings.UIElement*>)0x0049FDA0)(ref this, i_eType);
    // unsigned int __thiscall gmChatOptionsUI::GetUIElementType(gmChatOptionsUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmChatOptionsUI, uint>)0x0049FDC0)(ref this);
    // void __thiscall gmChatOptionsUI::~gmChatOptionsUI(gmChatOptionsUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmChatOptionsUI, void>)0x0049FDD0)(ref this);
    // void __cdecl gmChatOptionsUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0049FF00)();
    // void __thiscall gmChatOptionsUI::InitOptions(gmChatOptionsUI*)
    public void InitOptions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmChatOptionsUI, void>)0x0049FF20)(ref this);
}

