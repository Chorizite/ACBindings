namespace ACBindings;

// gmSpellbookUI
public unsafe struct gmSpellbookUI
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmSpellbookUI_vtbl
    public unsafe struct gmSpellbookUI_vtbl
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
    public ACBindings.UIElement_ItemList* m_spellList;
    public uint m_selectedSpellID;
    public ACBindings.UIElement* m_btnSchool_Creature;
    public ACBindings.UIElement* m_btnSchool_Item;
    public ACBindings.UIElement* m_btnSchool_Life;
    public ACBindings.UIElement* m_btnSchool_War;
    public ACBindings.UIElement* m_btnSchool_Void;
    public ACBindings.UIElement* m_btnLevel_1;
    public ACBindings.UIElement* m_btnLevel_2;
    public ACBindings.UIElement* m_btnLevel_3;
    public ACBindings.UIElement* m_btnLevel_4;
    public ACBindings.UIElement* m_btnLevel_5;
    public ACBindings.UIElement* m_btnLevel_6;
    public ACBindings.UIElement* m_btnLevel_7;
    public ACBindings.UIElement* m_btnLevel_8;

    // Methods
    // UIElement* __thiscall gmSpellbookUI::DynamicCast(gmSpellbookUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, uint, ACBindings.UIElement*>)0x0048B100)(ref this, i_eType);
    // unsigned int __thiscall gmSpellbookUI::GetUIElementType(gmSpellbookUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, uint>)0x0048B120)(ref this);
    // UIElement* __cdecl gmSpellbookUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0048B130)(layout, full_desc);
    // bool __thiscall gmSpellbookUI::IsFilteredOut(gmSpellbookUI*,CSpellBase*)
    public byte IsFilteredOut(ACBindings.CSpellBase* spellBase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, ACBindings.CSpellBase*, byte>)0x0048B190)(ref this, spellBase);
    // void __thiscall gmSpellbookUI::ResetFilterButtons(gmSpellbookUI*)
    public void ResetFilterButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, void>)0x0048B270)(ref this);
    // void __thiscall gmSpellbookUI::PostInit(gmSpellbookUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, void>)0x0048B590)(ref this);
    // void __cdecl gmSpellbookUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0048B700)();
    // unsigned int __thiscall gmSpellbookUI::GetSortedInsertionPlace(gmSpellbookUI*,CSpellBase*)
    public uint GetSortedInsertionPlace(ACBindings.CSpellBase* spellBase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, ACBindings.CSpellBase*, uint>)0x0048B720)(ref this, spellBase);
    // void __thiscall gmSpellbookUI::SetSelected(gmSpellbookUI*,unsigned int)
    public void SetSelected(uint selectedSpellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, uint, void>)0x0048B820)(ref this, selectedSpellID);
    // void __thiscall gmSpellbookUI::UpdateFilter(gmSpellbookUI*,unsigned int)
    public void UpdateFilter(uint buttonID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, uint, void>)0x0048B8C0)(ref this, buttonID);
    // void __thiscall gmSpellbookUI::AddSpell(gmSpellbookUI*,unsigned int)
    public void AddSpell(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, uint, void>)0x0048BA80)(ref this, spellID);
    // void __thiscall gmSpellbookUI::RecvNotice_SpellAdded(gmSpellbookUI*,unsigned int)
    public void RecvNotice_SpellAdded(uint i_eSpellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, uint, void>)0x0048BBB0)(ref this, i_eSpellID);
    // void __thiscall gmSpellbookUI::UpdateFromPlayerDesc(gmSpellbookUI*)
    public void UpdateFromPlayerDesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, void>)0x0048BDD0)(ref this);
    // void __thiscall gmSpellbookUI::RecvNotice_SpellRemoved(gmSpellbookUI*,unsigned int)
    public void RecvNotice_SpellRemoved(uint i_eSpellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, uint, void>)0x0048BEE0)(ref this, i_eSpellID);
    // void __cdecl gmSpellbookUI::DeleteSpellDialogCallback(const PropertyCollection*)
    public static void DeleteSpellDialogCallback(ACBindings.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.PropertyCollection*, void>)0x0048BEF0)(i_rcResults);
    // void __thiscall gmSpellbookUI::RecvNotice_PlayerDescReceived(gmSpellbookUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x0048C020)(ref this, i_playerDesc, i_playerModule);
    // bool __thiscall gmSpellbookUI::DeleteSpell(gmSpellbookUI*)
    public byte DeleteSpell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, byte>)0x0048C030)(ref this);
    // UIElementMessageListenResult __thiscall gmSpellbookUI::ListenToElementMessage(gmSpellbookUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellbookUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0048C2B0)(ref this, i_rMsg);
}

