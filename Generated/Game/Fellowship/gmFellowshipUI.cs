namespace ACBindings.Internal;

public unsafe struct gmFellowshipUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmFellowshipUI_vtbl
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

    // Members
    public ACBindings.Internal.CFellowship* m_pFellowship;
    public uint m_iidSelectedFellow;
    public uint m_uiAcceptFellowRequestServerContextID;
    public uint m_fellowRequestContext;
    public ACBindings.Internal.UIElement* m_pNotInAFellowshipFrame;
    public ACBindings.Internal.UIElement* m_pInAFellowshipFrame;
    public ACBindings.Internal.UIElement_Text* m_pFellowshipNameEntryBox;
    public ACBindings.Internal.UIElement_Button* m_pCreateFellowshipButton;
    public ACBindings.Internal.UIElement_Text* m_pFellowshipName;
    public ACBindings.Internal.UIElement_ListBox* m_pFellowsListBox;
    public ACBindings.Internal.UIElement_Button* m_pFellowLeaderButton;
    public ACBindings.Internal.UIElement_Button* m_pFellowQuitButton;
    public ACBindings.Internal.UIElement_Button* m_pFellowOpenButton;
    public ACBindings.Internal.UIElement_Button* m_pFellowRecruitButton;
    public ACBindings.Internal.UIElement_Button* m_pFellowDismissButton;
    public ACBindings.Internal.UIElement_Button* m_pFellowDisbandButton;

    // Generated Constructor
    public gmFellowshipUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0048E610
    /// void __thiscall gmFellowshipUI::gmFellowshipUI(gmFellowshipUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0048E610)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0048E6B0
    /// UIElement* __thiscall gmFellowshipUI::DynamicCast(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, ACBindings.Internal.UIElement*>)0x0048E6B0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x0048E6D0
    /// unsigned int __thiscall gmFellowshipUI::GetUIElementType(gmFellowshipUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint>)0x0048E6D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048E6E0
    /// UIElement* __cdecl gmFellowshipUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0048E6E0)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0048E710
    /// void __thiscall gmFellowshipUI::RecvNotice_AbortConfirmationRequest(gmFellowshipUI*,int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_AbortConfirmationRequest(int confirmationType, uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, int, uint, void>)0x0048E710)(ref this, confirmationType, context);

    /// <summary>
    /// <code>Offset: 0x0048E740
    /// void __thiscall gmFellowshipUI::OnVisibilityChanged(gmFellowshipUI*,bool)</code>
    /// </summary>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, byte, void>)0x0048E740)(ref this, i_bVisible);

    /// <summary>
    /// <code>Offset: 0x0048E750
    /// void __thiscall gmFellowshipUI::DismissFellow(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    public void DismissFellow(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x0048E750)(ref this, i_iidPlayer);

    /// <summary>
    /// <code>Offset: 0x0048E810
    /// void __thiscall gmFellowshipUI::RecruitFellow(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    public void RecruitFellow(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x0048E810)(ref this, i_iidPlayer);

    /// <summary>
    /// <code>Offset: 0x0048E910
    /// void __thiscall gmFellowshipUI::~gmFellowshipUI(gmFellowshipUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x0048E910)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048E980
    /// void __cdecl gmFellowshipUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0048E980)();

    /// <summary>
    /// <code>Offset: 0x0048E9A0
    /// void __thiscall gmFellowshipUI::UpdateButtons(gmFellowshipUI*)</code>
    /// </summary>
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x0048E9A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048EE00
    /// void __thiscall gmFellowshipUI::UpdateFellowStats(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    public void UpdateFellowStats(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x0048EE00)(ref this, i_iidPlayer);

    /// <summary>
    /// <code>Offset: 0x0048F040
    /// void __thiscall gmFellowshipUI::UpdateFellowVitals(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    public void UpdateFellowVitals(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x0048F040)(ref this, i_iidPlayer);

    /// <summary>
    /// <code>Offset: 0x0048F3D0
    /// void __thiscall gmFellowshipUI::UpdateFellowSelection(gmFellowshipUI*)</code>
    /// </summary>
    public void UpdateFellowSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x0048F3D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048F4A0
    /// void __thiscall gmFellowshipUI::RecvNotice_SelectionChanged(gmFellowshipUI*)</code>
    /// </summary>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x0048F4A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048F4C0
    /// void __thiscall gmFellowshipUI::AssignLeadershipToFellow(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    public void AssignLeadershipToFellow(uint i_iidFellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x0048F4C0)(ref this, i_iidFellow);

    /// <summary>
    /// <code>Offset: 0x0048F5A0
    /// void __thiscall gmFellowshipUI::RecvNotice_CloseDialog(gmFellowshipUI*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, ACBindings.Internal.PropertyCollection*, void>)0x0048F5A0)(ref this, context, data);

    /// <summary>
    /// <code>Offset: 0x0048F720
    /// void __thiscall gmFellowshipUI::Update(gmFellowshipUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x0048F720)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048FA10
    /// void __thiscall gmFellowshipUI::CreateFellowship(gmFellowshipUI*)</code>
    /// </summary>
    public void CreateFellowship() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x0048FA10)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048FF00
    /// void __thiscall gmFellowshipUI::FellowAdded(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    public void FellowAdded(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x0048FF00)(ref this, i_iidPlayer);

    /// <summary>
    /// <code>Offset: 0x00490020
    /// void __thiscall gmFellowshipUI::PostInit(gmFellowshipUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x00490020)(ref this);

    /// <summary>
    /// <code>Offset: 0x004904A0
    /// UIElementMessageListenResult __thiscall gmFellowshipUI::ListenToElementMessage(gmFellowshipUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004904A0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x00490770
    /// void __thiscall gmFellowshipUI::RecvNotice_FellowshipUpdate(gmFellowshipUI*,const CFellowship*)</code>
    /// </summary>
    public void RecvNotice_FellowshipUpdate(ACBindings.Internal.CFellowship* i_fellowship) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, ACBindings.Internal.CFellowship*, void>)0x00490770)(ref this, i_fellowship);

    /// <summary>
    /// <code>Offset: 0x004908B0
    /// void __thiscall gmFellowshipUI::RecvNotice_FellowshipDisbanded(gmFellowshipUI*)</code>
    /// </summary>
    public void RecvNotice_FellowshipDisbanded() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, void>)0x004908B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004908C0
    /// void __thiscall gmFellowshipUI::RecvNotice_FellowQuit(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_FellowQuit(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x004908C0)(ref this, i_iidPlayer);

    /// <summary>
    /// <code>Offset: 0x004908D0
    /// void __thiscall gmFellowshipUI::RecvNotice_FellowDismissed(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_FellowDismissed(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x004908D0)(ref this, i_iidPlayer);

    /// <summary>
    /// <code>Offset: 0x004908E0
    /// void __thiscall gmFellowshipUI::RecvNotice_FellowAdded(gmFellowshipUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_FellowAdded(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, void>)0x004908E0)(ref this, i_iidPlayer);

    /// <summary>
    /// <code>Offset: 0x004908F0
    /// void __thiscall gmFellowshipUI::RecvNotice_FellowUpdated(gmFellowshipUI*,unsigned int,const Fellow*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_FellowUpdated(uint i_iidPlayer, ACBindings.Internal.Fellow* i_fellow, uint i_uiUpdateType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, uint, ACBindings.Internal.Fellow*, uint, void>)0x004908F0)(ref this, i_iidPlayer, i_fellow, i_uiUpdateType);

    /// <summary>
    /// <code>Offset: 0x00490900
    /// char __thiscall gmFellowshipUI::MakeFellowRequestDialog(_DWORD*,const char*,int)</code>
    /// </summary>
    public sbyte MakeFellowRequestDialog(sbyte* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, sbyte*, int, sbyte>)0x00490900)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00490B60
    /// char __thiscall gmFellowshipUI::RecvNotice_FellowshipRequest(_DWORD*,int*,const char*)</code>
    /// </summary>
    public sbyte RecvNotice_FellowshipRequest(int* a2, sbyte* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFellowshipUI, int*, sbyte*, sbyte>)0x00490B60)(ref this, a2, a3);
}

