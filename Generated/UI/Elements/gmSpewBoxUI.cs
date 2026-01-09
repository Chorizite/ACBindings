namespace ACBindings;

// gmSpewBoxUI
public unsafe struct gmSpewBoxUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmSpewBoxUI_vtbl
    public unsafe struct gmSpewBoxUI_vtbl
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
    public ACBindings.UIElement_ListBox* m_listBox;
    public ACBindings.SmartArray__StringInfo m_spewBoxPending;
    public int m_maxConcurrentItems;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // UIElementMessageListenResult __thiscall gmSpewBoxUI::ListenToElementMessage(gmSpewBoxUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpewBoxUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004D6420)(ref this, i_rMsg);
    // UIElement* __thiscall gmSpewBoxUI::DynamicCast(gmSpewBoxUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpewBoxUI, uint, ACBindings.UIElement*>)0x004D66E0)(ref this, i_eType);
    // unsigned int __thiscall gmSpewBoxUI::GetUIElementType(gmSpewBoxUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpewBoxUI, uint>)0x004D6700)(ref this);
    // void __thiscall gmSpewBoxUI::PostInit(gmSpewBoxUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpewBoxUI, void>)0x004D6710)(ref this);
    // void __thiscall gmSpewBoxUI::~gmSpewBoxUI(gmSpewBoxUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpewBoxUI, void>)0x004D6830)(ref this);
    // void __cdecl gmSpewBoxUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D6A30)();
    // void __thiscall gmSpewBoxUI::Update(gmSpewBoxUI*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpewBoxUI, void>)0x004D6A50)(ref this);
    // void __thiscall gmSpewBoxUI::ListenToGlobalMessage(gmSpewBoxUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpewBoxUI, uint, int, void>)0x004D6CF0)(ref this, i_messageID, i_data_int);
    // void __thiscall gmSpewBoxUI::RecvNotice_DisplayFinalStringInfo(gmSpewBoxUI*,unsigned int,const StringInfo*,const StringInfo*,unsigned int)
    public void RecvNotice_DisplayFinalStringInfo(uint i_type, ACBindings.StringInfo* i_siMsg, ACBindings.StringInfo* i_siPrefix, uint i_idDestinationOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpewBoxUI, uint, ACBindings.StringInfo*, ACBindings.StringInfo*, uint, void>)0x004D6D00)(ref this, i_type, i_siMsg, i_siPrefix, i_idDestinationOverride);
}

