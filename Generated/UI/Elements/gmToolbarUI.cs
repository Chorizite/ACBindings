namespace ACBindings;

// gmToolbarUI
public unsafe struct gmToolbarUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.ItemListDragHandler

    // Child Types
    // gmToolbarUI_vtbl
    public unsafe struct gmToolbarUI_vtbl
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
    public ACBindings.SmartArray__PanelButtonInfo m_buttonInfoArray;
    public ACBindings.UIElement* m_pUseObjectButton;
    public ACBindings.UIElement* m_pExamineObjectButton;
    public ACBindings.UIElement* m_pSelObjectField;
    public ACBindings.UIElement_Text* m_pSelObjectName;
    public ACBindings.UIElement_Meter* m_pSelObjectHealthMeter;
    public ACBindings.UIElement_Meter* m_pSelObjectManaMeter;
    public ACBindings.UIElement_Text* m_pStackSizeEntryBox;
    public ACBindings.UIElement_Scrollbar* m_pStackSizeSlider;
    public ACBindings.UIElement* m_pInventoryButtonDragOverlay;
    public uint m_iidSelectedObject;
    public ACBindings.SmartArray__UIElement_ItemList_ptr m_shortcutSlots;
    public uint m_lastShortcutNumDragged;
    public byte m_bToolbarActive;
    public uint m_idAmmoObject;

    // Generated Constructor
    public gmToolbarUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmToolbarUI::RecvNotice_UpdateItemMana(gmToolbarUI*,unsigned int,float,bool)
    public void RecvNotice_UpdateItemMana(uint i_iidTarget, float i_fMana, byte i_bSuccess) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, float, byte, void>)0x004BDD50)(ref this, i_iidTarget, i_fMana, i_bSuccess);
    // void __thiscall gmToolbarUI::RecvNotice_UpdateObjectHealth(gmToolbarUI*,unsigned int,float)
    public void RecvNotice_UpdateObjectHealth(uint i_iidTarget, float i_fHealth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, float, void>)0x004BDDA0)(ref this, i_iidTarget, i_fHealth);
    // void __thiscall gmToolbarUI::HandleInventoryButtonDragOver(gmToolbarUI*,UIElement*)
    public void HandleInventoryButtonDragOver(ACBindings.UIElement* dragElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, ACBindings.UIElement*, void>)0x004BDE10)(ref this, dragElement);
    // bool __thiscall gmToolbarUI::IsShortcutEligible(gmToolbarUI*,ACCWeenieObject*)
    public byte IsShortcutEligible(ACBindings.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, ACBindings.ACCWeenieObject*, byte>)0x004BDE60)(ref this, weenObj);
    // void __thiscall gmToolbarUI::RecvNotice_SplitStack(gmToolbarUI*,unsigned int)
    public void RecvNotice_SplitStack(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, void>)0x004BDF30)(ref this, i_iidItem);
    // void __thiscall gmToolbarUI::RecvNotice_SetPanelVisibility(gmToolbarUI*,unsigned int,bool)
    public void RecvNotice_SetPanelVisibility(uint i_ePanelID, byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, byte, void>)0x004BDF90)(ref this, i_ePanelID, i_bVisible);
    // void __thiscall gmToolbarUI::UseShortcut(gmToolbarUI*,int,bool)
    public void UseShortcut(int slot, byte i_bUse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, int, byte, void>)0x004BDFE0)(ref this, slot, i_bUse);
    // void __thiscall gmToolbarUI::FlushShortcuts(gmToolbarUI*)
    public void FlushShortcuts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, void>)0x004BE0B0)(ref this);
    // int __thiscall gmToolbarUI::RemoveShortcut(gmToolbarUI*,unsigned int,bool)
    public int RemoveShortcut(uint itemID, byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, byte, int>)0x004BE0E0)(ref this, itemID, broadcast);
    // unsigned int __thiscall gmToolbarUI::RemoveShortcutInSlotNum(gmToolbarUI*,int,bool)
    public uint RemoveShortcutInSlotNum(int slot, byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, int, byte, uint>)0x004BE180)(ref this, slot, broadcast);
    // int __thiscall gmToolbarUI::GetFirstEmptyShortcutToTheRightOf(gmToolbarUI*,unsigned int)
    public int GetFirstEmptyShortcutToTheRightOf(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, int>)0x004BE1F0)(ref this, index);
    // bool __thiscall gmToolbarUI::IsShortcutSlotAvailable(gmToolbarUI*,int)
    public byte IsShortcutSlotAvailable(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, int, byte>)0x004BE270)(ref this, slot);
    // void __thiscall gmToolbarUI::RecvNotice_SetCombatMode(gmToolbarUI*,COMBAT_MODE)
    public void RecvNotice_SetCombatMode(ACBindings.COMBAT_MODE i_eCombatMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, ACBindings.COMBAT_MODE, void>)0x004BE2A0)(ref this, i_eCombatMode);
    // void __thiscall gmToolbarUI::gmToolbarUI(gmToolbarUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004BE3A0)(ref this, layout, full_desc);
    // UIElement* __thiscall gmToolbarUI::DynamicCast(gmToolbarUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, ACBindings.UIElement*>)0x004BE460)(ref this, i_eType);
    // unsigned int __thiscall gmToolbarUI::GetUIElementType(gmToolbarUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint>)0x004BE480)(ref this);
    // void __thiscall gmToolbarUI::~gmToolbarUI(gmToolbarUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, void>)0x004BE490)(ref this);
    // UIElement* __cdecl gmToolbarUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004BE550)(layout, full_desc);
    // void __thiscall gmToolbarUI::RecvNotice_RemoveShortcut(gmToolbarUI*,unsigned int)
    public void RecvNotice_RemoveShortcut(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, void>)0x004BE580)(ref this, i_itemID);
    // void __thiscall gmToolbarUI::RecvNotice_UseShortcut(gmToolbarUI*,int)
    public void RecvNotice_UseShortcut(int i_slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, int, void>)0x004BE5A0)(ref this, i_slot);
    // void __thiscall gmToolbarUI::RecvNotice_ItemListBeginDrag(gmToolbarUI*,const UIElement*,int)
    public void RecvNotice_ItemListBeginDrag(ACBindings.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, ACBindings.UIElement*, int, void>)0x004BE5C0)(ref this, i_itemList, i_slotNum);
    // void __thiscall gmToolbarUI::AddShortcut(gmToolbarUI*,unsigned int,int,bool)
    public void AddShortcut(uint itemID, int slot, byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, int, byte, void>)0x004BE630)(ref this, itemID, slot, broadcast);
    // void __cdecl gmToolbarUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004BE730)();
    // void __thiscall gmToolbarUI::CreateShortcutToItem(gmToolbarUI*,unsigned int,int,bool,bool)
    public void CreateShortcutToItem(uint itemID, int shortcutIndex, byte pickUp, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, int, byte, byte, void>)0x004BE750)(ref this, itemID, shortcutIndex, pickUp, silent);
    // void __thiscall gmToolbarUI::InitShortcutArray(gmToolbarUI*)
    public void InitShortcutArray() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, void>)0x004BE9E0)(ref this);
    // void __thiscall gmToolbarUI::ListenToGlobalMessage(gmToolbarUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, int, void>)0x004BF170)(ref this, i_messageID, i_data_int);
    // void __thiscall gmToolbarUI::HandleDropRelease(gmToolbarUI*,const UIElementMessageInfo*)
    public void HandleDropRelease(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, ACBindings.UIElementMessageInfo*, void>)0x004BF450)(ref this, i_rMsg);
    // void __thiscall gmToolbarUI::RecvNotice_AddShortcut(gmToolbarUI*,unsigned int,int)
    public void RecvNotice_AddShortcut(uint i_itemID, int i_slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, int, void>)0x004BF620)(ref this, i_itemID, i_slot);
    // void __thiscall gmToolbarUI::RecvNotice_FullMergingItem(gmToolbarUI*,unsigned int,unsigned int)
    public void RecvNotice_FullMergingItem(uint i_oldObject, uint i_mergeTo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, uint, void>)0x004BF640)(ref this, i_oldObject, i_mergeTo);
    // void __thiscall gmToolbarUI::UpdateAmmoNumber(gmToolbarUI*)
    public void UpdateAmmoNumber() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, void>)0x004BF670)(ref this);
    // void __thiscall gmToolbarUI::PostInit(gmToolbarUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, void>)0x004BF710)(ref this);
    // UIElementMessageListenResult __thiscall gmToolbarUI::ListenToElementMessage(gmToolbarUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004BFB20)(ref this, i_rMsg);
    // void __thiscall gmToolbarUI::UpdateAmmoID(gmToolbarUI*)
    public void UpdateAmmoID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, void>)0x004BFEA0)(ref this);
    // void __thiscall gmToolbarUI::RecvNotice_ServerSaysMoveItem(gmToolbarUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004BFF40)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);
    // void __thiscall gmToolbarUI::HandleSelectionChanged(gmToolbarUI*)
    public void HandleSelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, void>)0x004C0010)(ref this);
    // void __thiscall gmToolbarUI::UpdateFromPlayerDesc(gmToolbarUI*)
    public void UpdateFromPlayerDesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, void>)0x004C04A0)(ref this);
    // void __thiscall gmToolbarUI::RecvNotice_ItemAttributesChanged(gmToolbarUI*,unsigned int,unsigned int)
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, uint, uint, void>)0x004C0580)(ref this, i_target, i_attrib);
    // void __thiscall gmToolbarUI::RecvNotice_SelectionChanged(gmToolbarUI*)
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, void>)0x004C0600)(ref this);
    // void __thiscall gmToolbarUI::RecvNotice_PlayerDescReceived(gmToolbarUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmToolbarUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x004C0610)(ref this, i_playerDesc, i_playerModule);
}

