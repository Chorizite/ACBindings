namespace ACBindings;

// gmFellowshipUI
public unsafe struct gmFellowshipUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmFellowshipUI_vtbl
    public unsafe struct gmFellowshipUI_vtbl
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
    public ACBindings.CFellowship* m_pFellowship;
    public uint m_iidSelectedFellow;
    public uint m_uiAcceptFellowRequestServerContextID;
    public uint m_fellowRequestContext;
    public ACBindings.UIElement* m_pNotInAFellowshipFrame;
    public ACBindings.UIElement* m_pInAFellowshipFrame;
    public ACBindings.UIElement_Text* m_pFellowshipNameEntryBox;
    public ACBindings.UIElement_Button* m_pCreateFellowshipButton;
    public ACBindings.UIElement_Text* m_pFellowshipName;
    public ACBindings.UIElement_ListBox* m_pFellowsListBox;
    public ACBindings.UIElement_Button* m_pFellowLeaderButton;
    public ACBindings.UIElement_Button* m_pFellowQuitButton;
    public ACBindings.UIElement_Button* m_pFellowOpenButton;
    public ACBindings.UIElement_Button* m_pFellowRecruitButton;
    public ACBindings.UIElement_Button* m_pFellowDismissButton;
    public ACBindings.UIElement_Button* m_pFellowDisbandButton;

    // Generated Constructor
    public gmFellowshipUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmFellowshipUI::gmFellowshipUI(gmFellowshipUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x0048E610)(ref this, layout, full_desc);
    // UIElement* __thiscall gmFellowshipUI::DynamicCast(gmFellowshipUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, uint, ACBindings.UIElement*>)0x0048E6B0)(ref this, i_eType);
    // unsigned int __thiscall gmFellowshipUI::GetUIElementType(gmFellowshipUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, uint>)0x0048E6D0)(ref this);
    // UIElement* __cdecl gmFellowshipUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0048E6E0)(layout, full_desc);
    // void __thiscall gmFellowshipUI::RecvNotice_AbortConfirmationRequest(gmFellowshipUI*,int,unsigned int)
    public void RecvNotice_AbortConfirmationRequest(int confirmationType, uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, int, uint, void>)0x0048E710)(ref this, confirmationType, context);
    // void __thiscall gmFellowshipUI::OnVisibilityChanged(gmFellowshipUI*,bool)
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, byte, void>)0x0048E740)(ref this, i_bVisible);
    // void __thiscall gmFellowshipUI::DismissFellow(gmFellowshipUI*,unsigned int)
    public void DismissFellow(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, uint, void>)0x0048E750)(ref this, i_iidPlayer);
    // void __thiscall gmFellowshipUI::RecruitFellow(gmFellowshipUI*,unsigned int)
    public void RecruitFellow(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, uint, void>)0x0048E810)(ref this, i_iidPlayer);
    // void __thiscall gmFellowshipUI::~gmFellowshipUI(gmFellowshipUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, void>)0x0048E910)(ref this);
    // void __cdecl gmFellowshipUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0048E980)();
    // void __thiscall gmFellowshipUI::UpdateButtons(gmFellowshipUI*)
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, void>)0x0048E9A0)(ref this);
    // void __thiscall gmFellowshipUI::UpdateFellowStats(gmFellowshipUI*,unsigned int)
    public void UpdateFellowStats(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, uint, void>)0x0048EE00)(ref this, i_iidPlayer);
    // void __thiscall gmFellowshipUI::UpdateFellowVitals(gmFellowshipUI*,unsigned int)
    public void UpdateFellowVitals(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, uint, void>)0x0048F040)(ref this, i_iidPlayer);
    // void __thiscall gmFellowshipUI::UpdateFellowSelection(gmFellowshipUI*)
    public void UpdateFellowSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, void>)0x0048F3D0)(ref this);
    // void __thiscall gmFellowshipUI::RecvNotice_SelectionChanged(gmFellowshipUI*)
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, void>)0x0048F4A0)(ref this);
    // void __thiscall gmFellowshipUI::AssignLeadershipToFellow(gmFellowshipUI*,unsigned int)
    public void AssignLeadershipToFellow(uint i_iidFellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, uint, void>)0x0048F4C0)(ref this, i_iidFellow);
    // void __thiscall gmFellowshipUI::RecvNotice_CloseDialog(gmFellowshipUI*,unsigned int,const PropertyCollection*)
    public void RecvNotice_CloseDialog(uint context, ACBindings.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, uint, ACBindings.PropertyCollection*, void>)0x0048F5A0)(ref this, context, data);
    // void __thiscall gmFellowshipUI::Update(gmFellowshipUI*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, void>)0x0048F720)(ref this);
    // void __thiscall gmFellowshipUI::CreateFellowship(gmFellowshipUI*)
    public void CreateFellowship() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, void>)0x0048FA10)(ref this);
    // void __thiscall gmFellowshipUI::FellowAdded(gmFellowshipUI*,unsigned int)
    public void FellowAdded(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, uint, void>)0x0048FF00)(ref this, i_iidPlayer);
    // void __thiscall gmFellowshipUI::PostInit(gmFellowshipUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, void>)0x00490020)(ref this);
    // UIElementMessageListenResult __thiscall gmFellowshipUI::ListenToElementMessage(gmFellowshipUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004904A0)(ref this, i_rMsg);
    // void __thiscall gmFellowshipUI::RecvNotice_FellowshipUpdate(gmFellowshipUI*,const CFellowship*)
    public void RecvNotice_FellowshipUpdate(ACBindings.CFellowship* i_fellowship) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, ACBindings.CFellowship*, void>)0x00490770)(ref this, i_fellowship);
    // void __thiscall gmFellowshipUI::RecvNotice_FellowshipDisbanded(gmFellowshipUI*)
    public void RecvNotice_FellowshipDisbanded() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, void>)0x004908B0)(ref this);
    // void __thiscall gmFellowshipUI::RecvNotice_FellowQuit(gmFellowshipUI*,unsigned int)
    public void RecvNotice_FellowQuit(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, uint, void>)0x004908C0)(ref this, i_iidPlayer);
    // void __thiscall gmFellowshipUI::RecvNotice_FellowDismissed(gmFellowshipUI*,unsigned int)
    public void RecvNotice_FellowDismissed(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, uint, void>)0x004908D0)(ref this, i_iidPlayer);
    // void __thiscall gmFellowshipUI::RecvNotice_FellowAdded(gmFellowshipUI*,unsigned int)
    public void RecvNotice_FellowAdded(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, uint, void>)0x004908E0)(ref this, i_iidPlayer);
    // void __thiscall gmFellowshipUI::RecvNotice_FellowUpdated(gmFellowshipUI*,unsigned int,const Fellow*,unsigned int)
    public void RecvNotice_FellowUpdated(uint i_iidPlayer, ACBindings.Fellow* i_fellow, uint i_uiUpdateType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, uint, ACBindings.Fellow*, uint, void>)0x004908F0)(ref this, i_iidPlayer, i_fellow, i_uiUpdateType);
    // char __thiscall gmFellowshipUI::MakeFellowRequestDialog(_DWORD*,const char*,int)
    public sbyte MakeFellowRequestDialog(sbyte* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, sbyte*, int, sbyte>)0x00490900)(ref this, a2, a3);
    // char __thiscall gmFellowshipUI::RecvNotice_FellowshipRequest(_DWORD*,int*,const char*)
    public sbyte RecvNotice_FellowshipRequest(int* a2, sbyte* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFellowshipUI, int*, sbyte*, sbyte>)0x00490B60)(ref this, a2, a3);
}

