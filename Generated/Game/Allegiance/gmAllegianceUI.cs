namespace ACBindings.Internal;

public unsafe struct gmAllegianceUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler

    // Child Types
    public unsafe struct gmAllegianceUI_vtbl
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
    public byte m_bAwaitingUpdate;
    public uint m_iidSelectedVassal;
    public uint m_iidPossibleNewPatron;
    public uint m_iidPossibleKickedVassal;
    public uint m_uiAcceptSwearServerContextID;
    public ACBindings.Internal.UIElement_Text* m_pAllegianceName;
    public ACBindings.Internal.UIElement_Text* m_pPlayerFollowers;
    public ACBindings.Internal.UIElement_Text* m_pPlayerRank;
    public ACBindings.Internal.UIElement* m_pMonarchField;
    public ACBindings.Internal.UIElement_Text* m_pMonarchLabel;
    public ACBindings.Internal.UIElement_Text* m_pMonarchName;
    public ACBindings.Internal.UIElement_Text* m_pMonarchFollowers;
    public ACBindings.Internal.UIElement* m_pPatronField;
    public ACBindings.Internal.UIElement_Text* m_pPatronName;
    public ACBindings.Internal.UIElement_ListBox* m_pVassalListBox;
    public ACBindings.Internal.UIElement_Button* m_pSwearButton;
    public ACBindings.Internal.UIElement_Button* m_pBreakButton;
    public ACBindings.Internal.UIElement_Button* m_pKickButton;
    public uint m_swearContext;
    public uint m_acceptSwearContext;
    public uint m_breakContext;
    public uint m_kickContext;

    // Generated Constructor
    public gmAllegianceUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00490B90
    /// void __thiscall gmAllegianceUI::ListenToGlobalMessage(gmAllegianceUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, uint, int, void>)0x00490B90)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x00490BC0
    /// void __thiscall gmAllegianceUI::UpdateSwearButton(gmAllegianceUI*)</code>
    /// </summary>
    public void UpdateSwearButton() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00490BC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00490CB0
    /// void __thiscall gmAllegianceUI::UpdateBreakButton(gmAllegianceUI*)</code>
    /// </summary>
    public void UpdateBreakButton() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00490CB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00490D30
    /// bool __thiscall gmAllegianceUI::CloseAcceptSwearConfirmationDialog(gmAllegianceUI*,bool)</code>
    /// </summary>
    public byte CloseAcceptSwearConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte, byte>)0x00490D30)(ref this, i_bConfirm);

    /// <summary>
    /// <code>Offset: 0x00490D70
    /// bool __thiscall gmAllegianceUI::CloseBreakConfirmationDialog(gmAllegianceUI*,bool)</code>
    /// </summary>
    public byte CloseBreakConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte, byte>)0x00490D70)(ref this, i_bConfirm);

    /// <summary>
    /// <code>Offset: 0x00490DE0
    /// bool __thiscall gmAllegianceUI::CloseKickConfirmationDialog(gmAllegianceUI*,bool)</code>
    /// </summary>
    public byte CloseKickConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte, byte>)0x00490DE0)(ref this, i_bConfirm);

    /// <summary>
    /// <code>Offset: 0x00490E20
    /// void __thiscall gmAllegianceUI::gmAllegianceUI(gmAllegianceUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00490E20)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x00490EF0
    /// UIElement* __thiscall gmAllegianceUI::DynamicCast(gmAllegianceUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, uint, ACBindings.Internal.UIElement*>)0x00490EF0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x00490F10
    /// unsigned int __thiscall gmAllegianceUI::GetUIElementType(gmAllegianceUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, uint>)0x00490F10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00490F20
    /// void __thiscall gmAllegianceUI::~gmAllegianceUI(gmAllegianceUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00490F20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00490FF0
    /// UIElement* __cdecl gmAllegianceUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00490FF0)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x00491020
    /// void __thiscall gmAllegianceUI::RecvNotice_PlayerDescReceived(gmAllegianceUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x00491020)(ref this, i_playerDesc, i_playerModule);

    /// <summary>
    /// <code>Offset: 0x00491050
    /// void __thiscall gmAllegianceUI::RecvNotice_SelectionChanged(gmAllegianceUI*)</code>
    /// </summary>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00491050)(ref this);

    /// <summary>
    /// <code>Offset: 0x00491060
    /// void __thiscall gmAllegianceUI::RecvNotice_AbortConfirmationRequest(gmAllegianceUI*,int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_AbortConfirmationRequest(int confirmationType, uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, int, uint, void>)0x00491060)(ref this, confirmationType, context);

    /// <summary>
    /// <code>Offset: 0x00491090
    /// void __thiscall gmAllegianceUI::OnQualityRemoved(gmAllegianceUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public void OnQualityRemoved(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x00491090)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x00491170
    /// void __thiscall gmAllegianceUI::PostInit(gmAllegianceUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00491170)(ref this);

    /// <summary>
    /// <code>Offset: 0x004914D0
    /// void __cdecl gmAllegianceUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004914D0)();

    /// <summary>
    /// <code>Offset: 0x00491520
    /// void __thiscall gmAllegianceUI::OnVisibilityChanged(gmAllegianceUI*,bool)</code>
    /// </summary>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte, void>)0x00491520)(ref this, i_bVisible);

    /// <summary>
    /// <code>Offset: 0x00491610
    /// void __thiscall gmAllegianceUI::UpdatePlayerData(gmAllegianceUI*)</code>
    /// </summary>
    public void UpdatePlayerData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00491610)(ref this);

    /// <summary>
    /// <code>Offset: 0x00491AA0
    /// void __thiscall gmAllegianceUI::UpdatePatronData(gmAllegianceUI*)</code>
    /// </summary>
    public void UpdatePatronData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00491AA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00491E20
    /// void __thiscall gmAllegianceUI::UpdateMonarchData(gmAllegianceUI*)</code>
    /// </summary>
    public void UpdateMonarchData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00491E20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00492330
    /// void __thiscall gmAllegianceUI::RecvNotice_EnchantmentsChanged(gmAllegianceUI*)</code>
    /// </summary>
    public void RecvNotice_EnchantmentsChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00492330)(ref this);

    /// <summary>
    /// <code>Offset: 0x00492340
    /// void __thiscall gmAllegianceUI::RecvNotice_CloseDialog(gmAllegianceUI*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, uint, ACBindings.Internal.PropertyCollection*, void>)0x00492340)(ref this, context, data);

    /// <summary>
    /// <code>Offset: 0x00492500
    /// void __thiscall gmAllegianceUI::RecvNotice_AllegianceLogin(gmAllegianceUI*,unsigned int,bool)</code>
    /// </summary>
    public void RecvNotice_AllegianceLogin(uint i_iidMember, byte i_bNowLoggedIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, uint, byte, void>)0x00492500)(ref this, i_iidMember, i_bNowLoggedIn);

    /// <summary>
    /// <code>Offset: 0x00492620
    /// void __thiscall gmAllegianceUI::UpdateVassalsData(gmAllegianceUI*)</code>
    /// </summary>
    public void UpdateVassalsData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00492620)(ref this);

    /// <summary>
    /// <code>Offset: 0x00492950
    /// void __thiscall gmAllegianceUI::Update(gmAllegianceUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, void>)0x00492950)(ref this);

    /// <summary>
    /// <code>Offset: 0x00492A60
    /// void __thiscall gmAllegianceUI::RecvNotice_AllegianceUpdate(gmAllegianceUI*,const CAllegianceProfile*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_AllegianceUpdate(ACBindings.Internal.CAllegianceProfile* i_prof, uint i_uiRank) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, ACBindings.Internal.CAllegianceProfile*, uint, void>)0x00492A60)(ref this, i_prof, i_uiRank);

    /// <summary>
    /// <code>Offset: 0x00492A70
    /// void __thiscall gmAllegianceUI::RecvNotice_AllegianceUpdateAborted(gmAllegianceUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_AllegianceUpdateAborted(uint i_etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, uint, void>)0x00492A70)(ref this, i_etype);

    /// <summary>
    /// <code>Offset: 0x00492A90
    /// bool __thiscall gmAllegianceUI::MakeSwearConfirmationDialog(gmAllegianceUI*)</code>
    /// </summary>
    public byte MakeSwearConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte>)0x00492A90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00492C70
    /// char __thiscall gmAllegianceUI::MakeAcceptSwearConfirmationDialog(_DWORD*,const char*,int)</code>
    /// </summary>
    public sbyte MakeAcceptSwearConfirmationDialog(sbyte* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, sbyte*, int, sbyte>)0x00492C70)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00492ED0
    /// bool __thiscall gmAllegianceUI::MakeBreakConfirmationDialog(gmAllegianceUI*)</code>
    /// </summary>
    public byte MakeBreakConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte>)0x00492ED0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004930F0
    /// bool __thiscall gmAllegianceUI::MakeKickConfirmationDialog(gmAllegianceUI*)</code>
    /// </summary>
    public byte MakeKickConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, byte>)0x004930F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00493310
    /// UIElementMessageListenResult __thiscall gmAllegianceUI::ListenToElementMessage(gmAllegianceUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00493310)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004933F0
    /// char __thiscall gmAllegianceUI::RecvNotice_SwearAllegianceRequest(_DWORD*,int*,const char*)</code>
    /// </summary>
    public sbyte RecvNotice_SwearAllegianceRequest(int* a2, sbyte* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAllegianceUI, int*, sbyte*, sbyte>)0x004933F0)(ref this, a2, a3);
}

