namespace ACBindings.Internal;

public unsafe struct gmSpellcastingUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmSpellcastingUI_vtbl
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
    public ACBindings.Internal.UIElement_Panel* m_spellcastPanel;
    public ACBindings.Internal.UIElement_Text* m_spellName;
    public ACBindings.Internal.UIElement_Button* m_spellcastButton;
    public ACBindings.Internal.UIElement* m_endowmentIcon;
    public ACBindings.Internal.UIElement* m_endowmentIcon_Overlay;
    public ACBindings.Internal.UIElement* m_endowmentIcon_Underlay;
    public ACBindings.Internal.UIElement* m_endowmentIcon_Selected;
    public ACBindings.Internal.UIElement* m_spellcastBackground;
    public byte m_endowmentPresent;
    public uint m_endowmentItemID;
    public uint m_endowmentSpellID;
    public fixed byte m_subMenus_Raw[224];
    public ACBindings.Internal.SpellCastSubMenu* m_subMenus => (ACBindings.Internal.SpellCastSubMenu*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_subMenus_Raw[0]);

    // Generated Constructor
    public gmSpellcastingUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004C6400
    /// unsigned int __thiscall gmSpellcastingUI::GetNextTabID(gmSpellcastingUI*,unsigned int)</code>
    /// </summary>
    public uint GetNextTabID(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, uint>)0x004C6400)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x004C6480
    /// unsigned int __thiscall gmSpellcastingUI::GetPrevTabID(gmSpellcastingUI*,unsigned int)</code>
    /// </summary>
    public uint GetPrevTabID(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, uint>)0x004C6480)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x004C6500
    /// int __thiscall gmSpellcastingUI::GetOpenSubMenuIndex(gmSpellcastingUI*)</code>
    /// </summary>
    public int GetOpenSubMenuIndex() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, int>)0x004C6500)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C65E0
    /// void __thiscall gmSpellcastingUI::~gmSpellcastingUI(gmSpellcastingUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C65E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C6650
    /// UIElement* __thiscall gmSpellcastingUI::DynamicCast(gmSpellcastingUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, ACBindings.Internal.UIElement*>)0x004C6650)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004C6670
    /// unsigned int __thiscall gmSpellcastingUI::GetUIElementType(gmSpellcastingUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint>)0x004C6670)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C6830
    /// void __thiscall gmSpellcastingUI::gmSpellcastingUI(gmSpellcastingUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004C6830)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004C68F0
    /// void __thiscall gmSpellcastingUI::PostInit(gmSpellcastingUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C68F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C6C20
    /// void __cdecl gmSpellcastingUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004C6C20)();

    /// <summary>
    /// <code>Offset: 0x004C6C40
    /// void __thiscall gmSpellcastingUI::Cast(gmSpellcastingUI*)</code>
    /// </summary>
    public void Cast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C6C40)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C6D10
    /// void __thiscall gmSpellcastingUI::UpdateEndowmentIcon(gmSpellcastingUI*)</code>
    /// </summary>
    public void UpdateEndowmentIcon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C6D10)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C6FF0
    /// void __thiscall gmSpellcastingUI::RecvNotice_CastCurrentSpell(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_CastCurrentSpell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C6FF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C7590
    /// void __thiscall gmSpellcastingUI::RecvNotice_PlayerDescReceived(gmSpellcastingUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004C7590)(ref this, i_playerDesc, i_playerModule);

    /// <summary>
    /// <code>Offset: 0x004C75C0
    /// void __thiscall gmSpellcastingUI::RecvNotice_RemoveSpellShortcut(gmSpellcastingUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_RemoveSpellShortcut(uint i_spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, void>)0x004C75C0)(ref this, i_spellID);

    /// <summary>
    /// <code>Offset: 0x004C75F0
    /// void __thiscall gmSpellcastingUI::RecvNotice_SpellRemoved(gmSpellcastingUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_SpellRemoved(uint i_eSpellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, void>)0x004C75F0)(ref this, i_eSpellID);

    /// <summary>
    /// <code>Offset: 0x004C7620
    /// void __thiscall gmSpellcastingUI::UpdateCastButtonTooltip(gmSpellcastingUI*)</code>
    /// </summary>
    public void UpdateCastButtonTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C7620)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C7E60
    /// void __thiscall gmSpellcastingUI::RecvNotice_SelectionChanged(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C7E60)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C7E70
    /// void __thiscall gmSpellcastingUI::RecvNotice_SetCombatMode(gmSpellcastingUI*,COMBAT_MODE)</code>
    /// </summary>
    public void RecvNotice_SetCombatMode(ACBindings.Internal.COMBAT_MODE i_eCombatMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, ACBindings.Internal.COMBAT_MODE, void>)0x004C7E70)(ref this, i_eCombatMode);

    /// <summary>
    /// <code>Offset: 0x004C7EC0
    /// void __thiscall gmSpellcastingUI::RecvNotice_ServerSaysMoveItem(gmSpellcastingUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ServerSaysMoveItem(uint i_itemID, uint i_oldContainer, uint i_oldWielder, uint i_oldLocation, uint i_newContainer, int i_place, uint i_newWielder, uint i_newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004C7EC0)(ref this, i_itemID, i_oldContainer, i_oldWielder, i_oldLocation, i_newContainer, i_place, i_newWielder, i_newLocation);

    /// <summary>
    /// <code>Offset: 0x004C7F10
    /// void __thiscall gmSpellcastingUI::AddSpellShortcut(gmSpellcastingUI*,unsigned int,int,bool)</code>
    /// </summary>
    public void AddSpellShortcut(uint i_spellID, int pos, byte allowReplace) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, int, byte, void>)0x004C7F10)(ref this, i_spellID, pos, allowReplace);

    /// <summary>
    /// <code>Offset: 0x004C7F50
    /// void __thiscall gmSpellcastingUI::RecvNotice_ItemListBeginDrag(gmSpellcastingUI*,const UIElement*,int)</code>
    /// </summary>
    public void RecvNotice_ItemListBeginDrag(ACBindings.Internal.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, ACBindings.Internal.UIElement*, int, void>)0x004C7F50)(ref this, i_itemList, i_slotNum);

    /// <summary>
    /// <code>Offset: 0x004C7FD0
    /// void __thiscall gmSpellcastingUI::RecvNotice_NextSpellTab(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_NextSpellTab() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C7FD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C8010
    /// void __thiscall gmSpellcastingUI::RecvNotice_PrevSpellTab(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_PrevSpellTab() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C8010)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C8050
    /// void __thiscall gmSpellcastingUI::RecvNotice_NextSpellSelection(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_NextSpellSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C8050)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C81C0
    /// void __thiscall gmSpellcastingUI::RecvNotice_PrevSpellSelection(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_PrevSpellSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C81C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C8330
    /// void __thiscall gmSpellcastingUI::RecvNotice_FirstSpellTab(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_FirstSpellTab() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C8330)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C8360
    /// void __thiscall gmSpellcastingUI::RecvNotice_LastSpellTab(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_LastSpellTab() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C8360)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C8390
    /// void __thiscall gmSpellcastingUI::RecvNotice_FirstSpellSelection(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_FirstSpellSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C8390)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C8410
    /// void __thiscall gmSpellcastingUI::RecvNotice_LastSpellSelection(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_LastSpellSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C8410)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C84A0
    /// void __thiscall gmSpellcastingUI::RecvNotice_CastQuickslotSpell(gmSpellcastingUI*,int)</code>
    /// </summary>
    public void RecvNotice_CastQuickslotSpell(int i_slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, int, void>)0x004C84A0)(ref this, i_slot);

    /// <summary>
    /// <code>Offset: 0x004C8520
    /// void __thiscall gmSpellcastingUI::HandleDropRelease(gmSpellcastingUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004C8520)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004C8660
    /// void __thiscall gmSpellcastingUI::RecvNotice_AddSpellShortcut(gmSpellcastingUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_AddSpellShortcut(uint i_spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, void>)0x004C8660)(ref this, i_spellID);

    /// <summary>
    /// <code>Offset: 0x004C86A0
    /// UIElementMessageListenResult __thiscall gmSpellcastingUI::ListenToElementMessage(gmSpellcastingUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004C86A0)(ref this, i_rMsg);
}

