namespace ACBindings.Internal;

public unsafe struct gmSkillUI
{
    // Base Classes
    public ACBindings.Internal.gmStatManagementUI BaseClass_gmStatManagementUI; // ACBindings.Internal.gmStatManagementUI

    // Child Types
    public unsafe struct gmSkillUI_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmSkillUI*, ACBindings.Internal.CACQualities*, uint> GetCostToRaise10; // function pointer

        // Methods
    }

    // Members
    public uint m_SelectedSkill;
    public int m_SelectedIndex;

    // Generated Constructor
    public gmSkillUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0049B040
    /// void __thiscall gmSkillUI::gmSkillUI(gmSkillUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0049B040)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0049B090
    /// UIElement* __thiscall gmSkillUI::DynamicCast(gmSkillUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, uint, ACBindings.Internal.UIElement*>)0x0049B090)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x0049B0B0
    /// unsigned int __thiscall gmSkillUI::GetUIElementType(gmSkillUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, uint>)0x0049B0B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049B0C0
    /// void __thiscall gmSkillUI::PostInit(gmSkillUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, void>)0x0049B0C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049B100
    /// UIElement* __cdecl gmSkillUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0049B100)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0049B130
    /// unsigned int __thiscall gmSkillUI::GetCostToRaise10(gmSkillUI*,const CACQualities*)</code>
    /// </summary>
    public uint GetCostToRaise10(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, uint>)0x0049B130)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x0049B210
    /// bool __thiscall gmSkillUI::MessageIsFromSelectedElement(gmSkillUI*,StatType,unsigned int)</code>
    /// </summary>
    public byte MessageIsFromSelectedElement(ACBindings.Internal.StatType i_statType, uint i_statEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.StatType, uint, byte>)0x0049B210)(ref this, i_statType, i_statEnum);

    /// <summary>
    /// <code>Offset: 0x0049B290
    /// void __cdecl gmSkillUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0049B290)();

    /// <summary>
    /// <code>Offset: 0x0049B2B0
    /// bool __thiscall gmSkillUI::SetSelection(gmSkillUI*,UIElement*)</code>
    /// </summary>
    public byte SetSelection(ACBindings.Internal.UIElement* selectedUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.UIElement*, byte>)0x0049B2B0)(ref this, selectedUI);

    /// <summary>
    /// <code>Offset: 0x0049B380
    /// bool __thiscall gmSkillUI::DisplayDefaultFooter(gmSkillUI*,const CACQualities*)</code>
    /// </summary>
    public byte DisplayDefaultFooter(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, byte>)0x0049B380)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x0049B5C0
    /// bool __thiscall gmSkillUI::DisplaySelectionFooter_Untrained(gmSkillUI*,const CACQualities*)</code>
    /// </summary>
    public byte DisplaySelectionFooter_Untrained(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, byte>)0x0049B5C0)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x0049B8F0
    /// unsigned int __thiscall gmSkillUI::GetCostToRaise(gmSkillUI*,const CACQualities*)</code>
    /// </summary>
    public uint GetCostToRaise(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, uint>)0x0049B8F0)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x0049B9D0
    /// bool __thiscall gmSkillUI::Raise10Selection(gmSkillUI*)</code>
    /// </summary>
    public byte Raise10Selection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, byte>)0x0049B9D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049BAD0
    /// bool __thiscall gmSkillUI::DisplaySelectionFooter_Trained(gmSkillUI*,const CACQualities*)</code>
    /// </summary>
    public byte DisplaySelectionFooter_Trained(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, byte>)0x0049BAD0)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x0049C040
    /// bool __thiscall gmSkillUI::AddSortedSkill(gmSkillUI*,unsigned int,const SkillBase*,UIElement*,UIElement*)</code>
    /// </summary>
    public byte AddSortedSkill(uint i_SkillID, ACBindings.Internal.SkillBase* i_SkillBase, ACBindings.Internal.UIElement* i_pAfter, ACBindings.Internal.UIElement* i_pBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, uint, ACBindings.Internal.SkillBase*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte>)0x0049C040)(ref this, i_SkillID, i_SkillBase, i_pAfter, i_pBefore);

    /// <summary>
    /// <code>Offset: 0x0049C310
    /// bool __thiscall gmSkillUI::UpdateSelection(gmSkillUI*)</code>
    /// </summary>
    public byte UpdateSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, byte>)0x0049C310)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049C480
    /// void __cdecl gmSkillUI::TrainSkillDialogCallback(const PropertyCollection*)</code>
    /// </summary>
    public static void TrainSkillDialogCallback(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x0049C480)(i_rcResults);

    /// <summary>
    /// <code>Offset: 0x0049C610
    /// bool __thiscall gmSkillUI::RebuildSkillList(gmSkillUI*)</code>
    /// </summary>
    public byte RebuildSkillList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, byte>)0x0049C610)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049C840
    /// void __thiscall gmSkillUI::RecvNotice_PlayerDescReceived(gmSkillUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x0049C840)(ref this, i_playerDesc, i_playerModule);

    /// <summary>
    /// <code>Offset: 0x0049C850
    /// void __thiscall gmSkillUI::RecvNotice_SkillAdvancementClassChanged(gmSkillUI*)</code>
    /// </summary>
    public void RecvNotice_SkillAdvancementClassChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, void>)0x0049C850)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049C860
    /// bool __thiscall gmSkillUI::TrainSkill(gmSkillUI*,const CACQualities*)</code>
    /// </summary>
    public byte TrainSkill(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, ACBindings.Internal.CACQualities*, byte>)0x0049C860)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x0049CB30
    /// bool __thiscall gmSkillUI::RaiseSelection(gmSkillUI*)</code>
    /// </summary>
    public byte RaiseSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSkillUI, byte>)0x0049CB30)(ref this);
}

