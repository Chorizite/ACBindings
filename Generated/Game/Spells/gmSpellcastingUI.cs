namespace ACBindings;

// gmSpellcastingUI
public unsafe struct gmSpellcastingUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmSpellcastingUI_vtbl
    public unsafe struct gmSpellcastingUI_vtbl
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
    public ACBindings.UIElement_Panel* m_spellcastPanel;
    public ACBindings.UIElement_Text* m_spellName;
    public ACBindings.UIElement_Button* m_spellcastButton;
    public ACBindings.UIElement* m_endowmentIcon;
    public ACBindings.UIElement* m_endowmentIcon_Overlay;
    public ACBindings.UIElement* m_endowmentIcon_Underlay;
    public ACBindings.UIElement* m_endowmentIcon_Selected;
    public ACBindings.UIElement* m_spellcastBackground;
    public byte m_endowmentPresent;
    public uint m_endowmentItemID;
    public uint m_endowmentSpellID;
    public fixed byte m_subMenus_Raw[224];
    public ACBindings.SpellCastSubMenu* m_subMenus => (ACBindings.SpellCastSubMenu*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_subMenus_Raw[0]);

    // Generated Constructor
    public gmSpellcastingUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall gmSpellcastingUI::GetNextTabID(gmSpellcastingUI*,unsigned int)
    public uint GetNextTabID(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, uint, uint>)0x004C6400)(ref this, id);
    // unsigned int __thiscall gmSpellcastingUI::GetPrevTabID(gmSpellcastingUI*,unsigned int)
    public uint GetPrevTabID(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, uint, uint>)0x004C6480)(ref this, id);
    // int __thiscall gmSpellcastingUI::GetOpenSubMenuIndex(gmSpellcastingUI*)
    public int GetOpenSubMenuIndex() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, int>)0x004C6500)(ref this);
    // void __thiscall gmSpellcastingUI::~gmSpellcastingUI(gmSpellcastingUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C65E0)(ref this);
    // UIElement* __thiscall gmSpellcastingUI::DynamicCast(gmSpellcastingUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, uint, ACBindings.UIElement*>)0x004C6650)(ref this, i_eType);
    // unsigned int __thiscall gmSpellcastingUI::GetUIElementType(gmSpellcastingUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, uint>)0x004C6670)(ref this);
    // void __thiscall gmSpellcastingUI::gmSpellcastingUI(gmSpellcastingUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004C6830)(ref this, layout, full_desc);
    // void __thiscall gmSpellcastingUI::PostInit(gmSpellcastingUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C68F0)(ref this);
    // void __cdecl gmSpellcastingUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004C6C20)();
    // void __thiscall gmSpellcastingUI::Cast(gmSpellcastingUI*)
    public void Cast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C6C40)(ref this);
    // void __thiscall gmSpellcastingUI::UpdateEndowmentIcon(gmSpellcastingUI*)
    public void UpdateEndowmentIcon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C6D10)(ref this);
    // void __thiscall gmSpellcastingUI::RecvNotice_CastCurrentSpell(gmSpellcastingUI*)
    public void RecvNotice_CastCurrentSpell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C6FF0)(ref this);
    // void __thiscall gmSpellcastingUI::RecvNotice_PlayerDescReceived(gmSpellcastingUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x004C7590)(ref this, i_playerDesc, i_playerModule);
    // void __thiscall gmSpellcastingUI::RecvNotice_RemoveSpellShortcut(gmSpellcastingUI*,unsigned int)
    public void RecvNotice_RemoveSpellShortcut(uint i_spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, uint, void>)0x004C75C0)(ref this, i_spellID);
    // void __thiscall gmSpellcastingUI::RecvNotice_SpellRemoved(gmSpellcastingUI*,unsigned int)
    public void RecvNotice_SpellRemoved(uint i_eSpellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, uint, void>)0x004C75F0)(ref this, i_eSpellID);
    // void __thiscall gmSpellcastingUI::UpdateCastButtonTooltip(gmSpellcastingUI*)
    public void UpdateCastButtonTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C7620)(ref this);
    // void __thiscall gmSpellcastingUI::RecvNotice_SelectionChanged(gmSpellcastingUI*)
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C7E60)(ref this);
    // void __thiscall gmSpellcastingUI::RecvNotice_SetCombatMode(gmSpellcastingUI*,COMBAT_MODE)
    public void RecvNotice_SetCombatMode(ACBindings.COMBAT_MODE i_eCombatMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, ACBindings.COMBAT_MODE, void>)0x004C7E70)(ref this, i_eCombatMode);
    // void __thiscall gmSpellcastingUI::RecvNotice_ServerSaysMoveItem(gmSpellcastingUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void RecvNotice_ServerSaysMoveItem(uint i_itemID, uint i_oldContainer, uint i_oldWielder, uint i_oldLocation, uint i_newContainer, int i_place, uint i_newWielder, uint i_newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004C7EC0)(ref this, i_itemID, i_oldContainer, i_oldWielder, i_oldLocation, i_newContainer, i_place, i_newWielder, i_newLocation);
    // void __thiscall gmSpellcastingUI::AddSpellShortcut(gmSpellcastingUI*,unsigned int,int,bool)
    public void AddSpellShortcut(uint i_spellID, int pos, byte allowReplace) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, uint, int, byte, void>)0x004C7F10)(ref this, i_spellID, pos, allowReplace);
    // void __thiscall gmSpellcastingUI::RecvNotice_ItemListBeginDrag(gmSpellcastingUI*,const UIElement*,int)
    public void RecvNotice_ItemListBeginDrag(ACBindings.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, ACBindings.UIElement*, int, void>)0x004C7F50)(ref this, i_itemList, i_slotNum);
    // void __thiscall gmSpellcastingUI::RecvNotice_NextSpellTab(gmSpellcastingUI*)
    public void RecvNotice_NextSpellTab() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C7FD0)(ref this);
    // void __thiscall gmSpellcastingUI::RecvNotice_PrevSpellTab(gmSpellcastingUI*)
    public void RecvNotice_PrevSpellTab() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C8010)(ref this);
    // void __thiscall gmSpellcastingUI::RecvNotice_NextSpellSelection(gmSpellcastingUI*)
    public void RecvNotice_NextSpellSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C8050)(ref this);
    // void __thiscall gmSpellcastingUI::RecvNotice_PrevSpellSelection(gmSpellcastingUI*)
    public void RecvNotice_PrevSpellSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C81C0)(ref this);
    // void __thiscall gmSpellcastingUI::RecvNotice_FirstSpellTab(gmSpellcastingUI*)
    public void RecvNotice_FirstSpellTab() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C8330)(ref this);
    // void __thiscall gmSpellcastingUI::RecvNotice_LastSpellTab(gmSpellcastingUI*)
    public void RecvNotice_LastSpellTab() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C8360)(ref this);
    // void __thiscall gmSpellcastingUI::RecvNotice_FirstSpellSelection(gmSpellcastingUI*)
    public void RecvNotice_FirstSpellSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C8390)(ref this);
    // void __thiscall gmSpellcastingUI::RecvNotice_LastSpellSelection(gmSpellcastingUI*)
    public void RecvNotice_LastSpellSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, void>)0x004C8410)(ref this);
    // void __thiscall gmSpellcastingUI::RecvNotice_CastQuickslotSpell(gmSpellcastingUI*,int)
    public void RecvNotice_CastQuickslotSpell(int i_slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, int, void>)0x004C84A0)(ref this, i_slot);
    // void __thiscall gmSpellcastingUI::HandleDropRelease(gmSpellcastingUI*,const UIElementMessageInfo*)
    public void HandleDropRelease(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, ACBindings.UIElementMessageInfo*, void>)0x004C8520)(ref this, i_rMsg);
    // void __thiscall gmSpellcastingUI::RecvNotice_AddSpellShortcut(gmSpellcastingUI*,unsigned int)
    public void RecvNotice_AddSpellShortcut(uint i_spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, uint, void>)0x004C8660)(ref this, i_spellID);
    // UIElementMessageListenResult __thiscall gmSpellcastingUI::ListenToElementMessage(gmSpellcastingUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellcastingUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004C86A0)(ref this, i_rMsg);
}

