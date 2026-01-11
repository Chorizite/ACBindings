namespace ACBindings.Internal;

public unsafe struct gmStatManagementUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler

    // Child Types
    public unsafe struct gmStatManagementUI_vtbl
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
        public fixed byte gap138[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> Update; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, byte> UpdateCharacterInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, byte> UpdatePKStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, byte> UpdateExperience; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.UIElement*, byte> SetSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> UpdateSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> RaiseSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, byte> Raise10Selection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.CACQualities*, uint> GetCostToRaise; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmStatManagementUI*, ACBindings.Internal.StatType, uint, byte> MessageIsFromSelectedElement; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_Text* m_pNameText;
    public ACBindings.Internal.UIElement_Text* m_pHeritageText;
    public ACBindings.Internal.UIElement_Text* m_pPKStatusText;
    public ACBindings.Internal.UIElement_Text* m_pLevelText;
    public ACBindings.Internal.UIElement_Text* m_pTotalXPText;
    public ACBindings.Internal.UIElement_Text* m_pXPToLevelText;
    public ACBindings.Internal.UIElement_Text* m_pLuminanceLabelText;
    public ACBindings.Internal.UIElement_Text* m_pLuminanceText;
    public ACBindings.Internal.UIElement_Meter* m_pXPToLevelMeter;
    public ACBindings.Internal.UIElement_ListBox* m_pListBox;
    public ACBindings.Internal.SmartArray___InfoRegion_ptr m_rgTokens;
    public byte m_bAwaitingRaise;
    public uint m_titleID;

    // Generated Constructor
    public gmStatManagementUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F0870
    /// UIElementMessageListenResult __thiscall gmStatManagementUI::ListenToElementMessage(gmStatManagementUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004F0870)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004F0980
    /// void __thiscall gmStatManagementUI::RecvNotice_PlayerDescReceived(gmStatManagementUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004F0980)(ref this, i_playerDesc, i_playerModule);

    /// <summary>
    /// <code>Offset: 0x004F09A0
    /// void __thiscall gmStatManagementUI::RecvNotice_EnchantmentsChanged(gmStatManagementUI*)</code>
    /// </summary>
    public void RecvNotice_EnchantmentsChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, void>)0x004F09A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F09C0
    /// void __thiscall gmStatManagementUI::RecvNotice_UpdateCharacterTitleTable(gmStatManagementUI*,const CharacterTitleTable*)</code>
    /// </summary>
    public void RecvNotice_UpdateCharacterTitleTable(ACBindings.Internal.CharacterTitleTable* i_titleTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CharacterTitleTable*, void>)0x004F09C0)(ref this, i_titleTable);

    /// <summary>
    /// <code>Offset: 0x004F09E0
    /// void __thiscall gmStatManagementUI::RecvNotice_SetDisplayCharacterTitle(gmStatManagementUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_SetDisplayCharacterTitle(uint i_title) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, uint, void>)0x004F09E0)(ref this, i_title);

    /// <summary>
    /// <code>Offset: 0x004F0A00
    /// void __thiscall gmStatManagementUI::OnQualityRemoved(gmStatManagementUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public void OnQualityRemoved(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004F0A00)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x004F0A20
    /// void __thiscall gmStatManagementUI::PostInit(gmStatManagementUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, void>)0x004F0A20)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F0CB0
    /// bool __thiscall gmStatManagementUI::Update(gmStatManagementUI*,const CACQualities*)</code>
    /// </summary>
    public byte Update(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CACQualities*, byte>)0x004F0CB0)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004F0D30
    /// bool __thiscall gmStatManagementUI::UpdatePKStatus(gmStatManagementUI*,const CACQualities*)</code>
    /// </summary>
    public byte UpdatePKStatus(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CACQualities*, byte>)0x004F0D30)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004F0E00
    /// UIElement_Text* __thiscall gmStatManagementUI::GetFooterTitleLabel(gmStatManagementUI*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_Text* GetFooterTitleLabel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Text*>)0x004F0E00)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F0E50
    /// UIElement_Text* __thiscall gmStatManagementUI::GetFooterLineOneLabel(gmStatManagementUI*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_Text* GetFooterLineOneLabel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Text*>)0x004F0E50)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F0EA0
    /// UIElement_Text* __thiscall gmStatManagementUI::GetFooterLineOneValue(gmStatManagementUI*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_Text* GetFooterLineOneValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Text*>)0x004F0EA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F0EF0
    /// UIElement_Meter* __thiscall gmStatManagementUI::GetFooterMeter(gmStatManagementUI*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_Meter* GetFooterMeter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Meter*>)0x004F0EF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F0F40
    /// UIElement_Text* __thiscall gmStatManagementUI::GetFooterLineTwoLabel(gmStatManagementUI*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_Text* GetFooterLineTwoLabel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Text*>)0x004F0F40)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F0F90
    /// UIElement_Text* __thiscall gmStatManagementUI::GetFooterLineTwoValue(gmStatManagementUI*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_Text* GetFooterLineTwoValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Text*>)0x004F0F90)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F0FE0
    /// UIElement_Button* __thiscall gmStatManagementUI::GetFooterButton(gmStatManagementUI*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_Button* GetFooterButton() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Button*>)0x004F0FE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F1030
    /// UIElement_Button* __thiscall gmStatManagementUI::GetFooter10Button(gmStatManagementUI*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_Button* GetFooter10Button() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.UIElement_Button*>)0x004F1030)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F1080
    /// void __thiscall gmStatManagementUI::gmStatManagementUI(gmStatManagementUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004F1080)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004F1130
    /// bool __thiscall gmStatManagementUI::Update(gmStatManagementUI*)</code>
    /// </summary>
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, byte>)0x004F1130)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F11E0
    /// bool __thiscall gmStatManagementUI::FlushList(gmStatManagementUI*)</code>
    /// </summary>
    public byte FlushList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, byte>)0x004F11E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F1270
    /// void __thiscall gmStatManagementUI::~gmStatManagementUI(gmStatManagementUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, void>)0x004F1270)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F1400
    /// bool __thiscall gmStatManagementUI::UpdateCharacterInfo(gmStatManagementUI*,const CACQualities*)</code>
    /// </summary>
    public byte UpdateCharacterInfo(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CACQualities*, byte>)0x004F1400)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004F1700
    /// bool __thiscall gmStatManagementUI::UpdateExperience(gmStatManagementUI*,const CACQualities*)</code>
    /// </summary>
    public byte UpdateExperience(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmStatManagementUI, ACBindings.Internal.CACQualities*, byte>)0x004F1700)(ref this, i_playerDesc);
}

