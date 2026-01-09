namespace ACBindings;

// gmAbuseUI
public unsafe struct gmAbuseUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmAbuseUI_vtbl
    public unsafe struct gmAbuseUI_vtbl
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

    // Members
    public ACBindings.UIElement_Text* m_pNameBox;
    public ACBindings.UIElement_Text* m_pEntryBox;
    public ACBindings.UIElement_Text* m_pResultText;
    public ACBindings.UIElement_Button* m_pContinueButton;

    // Generated Constructor
    public gmAbuseUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmAbuseUI::gmAbuseUI(gmAbuseUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAbuseUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004BCB40)(ref this, layout, full_desc);
    // UIElement* __thiscall gmAbuseUI::DynamicCast(gmAbuseUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAbuseUI, uint, ACBindings.UIElement*>)0x004BCB90)(ref this, i_eType);
    // unsigned int __thiscall gmAbuseUI::GetUIElementType(gmAbuseUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAbuseUI, uint>)0x004BCBB0)(ref this);
    // void __thiscall gmAbuseUI::PostInit(gmAbuseUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAbuseUI, void>)0x004BCBC0)(ref this);
    // void __thiscall gmAbuseUI::~gmAbuseUI(gmAbuseUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAbuseUI, void>)0x004BCC30)(ref this);
    // UIElement* __cdecl gmAbuseUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004BCC90)(layout, full_desc);
    // void __cdecl gmAbuseUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004BCCE0)();
    // bool __thiscall gmAbuseUI::HandleTextEntry(gmAbuseUI*)
    public byte HandleTextEntry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAbuseUI, byte>)0x004BCD00)(ref this);
    // bool __thiscall gmAbuseUI::SetPageThreeText(gmAbuseUI*,const unsigned int)
    public byte SetPageThreeText(uint token) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAbuseUI, uint, byte>)0x004BCDC0)(ref this, token);
    // void __thiscall gmAbuseUI::RecvNotice_AbuseReportResponse(gmAbuseUI*,unsigned int)
    public void RecvNotice_AbuseReportResponse(uint error) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAbuseUI, uint, void>)0x004BCE40)(ref this, error);
    // bool __thiscall gmAbuseUI::Reset(gmAbuseUI*)
    public byte Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAbuseUI, byte>)0x004BCE90)(ref this);
    // bool __thiscall gmAbuseUI::HandleSelection(gmAbuseUI*)
    public byte HandleSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAbuseUI, byte>)0x004BCF50)(ref this);
    // bool __thiscall gmAbuseUI::ReportAbuse(gmAbuseUI*)
    public byte ReportAbuse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAbuseUI, byte>)0x004BD010)(ref this);
    // UIElementMessageListenResult __thiscall gmAbuseUI::ListenToElementMessage(gmAbuseUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAbuseUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004BD250)(ref this, i_rMsg);
}

