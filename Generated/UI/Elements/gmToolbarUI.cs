namespace ACBindings.Internal;

public unsafe struct gmToolbarUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct gmToolbarUI_vtbl
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
    public ACBindings.Internal.SmartArray___PanelButtonInfo m_buttonInfoArray;
    public ACBindings.Internal.UIElement* m_pUseObjectButton;
    public ACBindings.Internal.UIElement* m_pExamineObjectButton;
    public ACBindings.Internal.UIElement* m_pSelObjectField;
    public ACBindings.Internal.UIElement_Text* m_pSelObjectName;
    public ACBindings.Internal.UIElement_Meter* m_pSelObjectHealthMeter;
    public ACBindings.Internal.UIElement_Meter* m_pSelObjectManaMeter;
    public ACBindings.Internal.UIElement_Text* m_pStackSizeEntryBox;
    public ACBindings.Internal.UIElement_Scrollbar* m_pStackSizeSlider;
    public ACBindings.Internal.UIElement* m_pInventoryButtonDragOverlay;
    public uint m_iidSelectedObject;
    public ACBindings.Internal.SmartArray___UIElement_ItemList_ptr m_shortcutSlots;
    public uint m_lastShortcutNumDragged;
    public byte m_bToolbarActive;
    public uint m_idAmmoObject;

    // Generated Constructor
    public gmToolbarUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004BDD50
    /// void __thiscall gmToolbarUI::RecvNotice_UpdateItemMana(gmToolbarUI*,unsigned int,float,bool)</code>
    /// </summary>
    public void RecvNotice_UpdateItemMana(uint i_iidTarget, float i_fMana, byte i_bSuccess) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, float, byte, void>)0x004BDD50)(ref this, i_iidTarget, i_fMana, i_bSuccess);

    /// <summary>
    /// <code>Offset: 0x004BDDA0
    /// void __thiscall gmToolbarUI::RecvNotice_UpdateObjectHealth(gmToolbarUI*,unsigned int,float)</code>
    /// </summary>
    public void RecvNotice_UpdateObjectHealth(uint i_iidTarget, float i_fHealth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, float, void>)0x004BDDA0)(ref this, i_iidTarget, i_fHealth);

    /// <summary>
    /// <code>Offset: 0x004BDE10
    /// void __thiscall gmToolbarUI::HandleInventoryButtonDragOver(gmToolbarUI*,UIElement*)</code>
    /// </summary>
    public void HandleInventoryButtonDragOver(ACBindings.Internal.UIElement* dragElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.UIElement*, void>)0x004BDE10)(ref this, dragElement);

    /// <summary>
    /// <code>Offset: 0x004BDE60
    /// bool __thiscall gmToolbarUI::IsShortcutEligible(gmToolbarUI*,ACCWeenieObject*)</code>
    /// </summary>
    public byte IsShortcutEligible(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004BDE60)(ref this, weenObj);

    /// <summary>
    /// <code>Offset: 0x004BDF30
    /// void __thiscall gmToolbarUI::RecvNotice_SplitStack(gmToolbarUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_SplitStack(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, void>)0x004BDF30)(ref this, i_iidItem);

    /// <summary>
    /// <code>Offset: 0x004BDF90
    /// void __thiscall gmToolbarUI::RecvNotice_SetPanelVisibility(gmToolbarUI*,unsigned int,bool)</code>
    /// </summary>
    public void RecvNotice_SetPanelVisibility(uint i_ePanelID, byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, byte, void>)0x004BDF90)(ref this, i_ePanelID, i_bVisible);

    /// <summary>
    /// <code>Offset: 0x004BDFE0
    /// void __thiscall gmToolbarUI::UseShortcut(gmToolbarUI*,int,bool)</code>
    /// </summary>
    public void UseShortcut(int slot, byte i_bUse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, int, byte, void>)0x004BDFE0)(ref this, slot, i_bUse);

    /// <summary>
    /// <code>Offset: 0x004BE0B0
    /// void __thiscall gmToolbarUI::FlushShortcuts(gmToolbarUI*)</code>
    /// </summary>
    public void FlushShortcuts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004BE0B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BE0E0
    /// int __thiscall gmToolbarUI::RemoveShortcut(gmToolbarUI*,unsigned int,bool)</code>
    /// </summary>
    public int RemoveShortcut(uint itemID, byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, byte, int>)0x004BE0E0)(ref this, itemID, broadcast);

    /// <summary>
    /// <code>Offset: 0x004BE180
    /// unsigned int __thiscall gmToolbarUI::RemoveShortcutInSlotNum(gmToolbarUI*,int,bool)</code>
    /// </summary>
    public uint RemoveShortcutInSlotNum(int slot, byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, int, byte, uint>)0x004BE180)(ref this, slot, broadcast);

    /// <summary>
    /// <code>Offset: 0x004BE1F0
    /// int __thiscall gmToolbarUI::GetFirstEmptyShortcutToTheRightOf(gmToolbarUI*,unsigned int)</code>
    /// </summary>
    public int GetFirstEmptyShortcutToTheRightOf(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, int>)0x004BE1F0)(ref this, index);

    /// <summary>
    /// <code>Offset: 0x004BE270
    /// bool __thiscall gmToolbarUI::IsShortcutSlotAvailable(gmToolbarUI*,int)</code>
    /// </summary>
    public byte IsShortcutSlotAvailable(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, int, byte>)0x004BE270)(ref this, slot);

    /// <summary>
    /// <code>Offset: 0x004BE2A0
    /// void __thiscall gmToolbarUI::RecvNotice_SetCombatMode(gmToolbarUI*,COMBAT_MODE)</code>
    /// </summary>
    public void RecvNotice_SetCombatMode(ACBindings.Internal.COMBAT_MODE i_eCombatMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.COMBAT_MODE, void>)0x004BE2A0)(ref this, i_eCombatMode);

    /// <summary>
    /// <code>Offset: 0x004BE3A0
    /// void __thiscall gmToolbarUI::gmToolbarUI(gmToolbarUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004BE3A0)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004BE460
    /// UIElement* __thiscall gmToolbarUI::DynamicCast(gmToolbarUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, ACBindings.Internal.UIElement*>)0x004BE460)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004BE480
    /// unsigned int __thiscall gmToolbarUI::GetUIElementType(gmToolbarUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint>)0x004BE480)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BE490
    /// void __thiscall gmToolbarUI::~gmToolbarUI(gmToolbarUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004BE490)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BE550
    /// UIElement* __cdecl gmToolbarUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004BE550)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004BE580
    /// void __thiscall gmToolbarUI::RecvNotice_RemoveShortcut(gmToolbarUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_RemoveShortcut(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, void>)0x004BE580)(ref this, i_itemID);

    /// <summary>
    /// <code>Offset: 0x004BE5A0
    /// void __thiscall gmToolbarUI::RecvNotice_UseShortcut(gmToolbarUI*,int)</code>
    /// </summary>
    public void RecvNotice_UseShortcut(int i_slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, int, void>)0x004BE5A0)(ref this, i_slot);

    /// <summary>
    /// <code>Offset: 0x004BE5C0
    /// void __thiscall gmToolbarUI::RecvNotice_ItemListBeginDrag(gmToolbarUI*,const UIElement*,int)</code>
    /// </summary>
    public void RecvNotice_ItemListBeginDrag(ACBindings.Internal.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.UIElement*, int, void>)0x004BE5C0)(ref this, i_itemList, i_slotNum);

    /// <summary>
    /// <code>Offset: 0x004BE630
    /// void __thiscall gmToolbarUI::AddShortcut(gmToolbarUI*,unsigned int,int,bool)</code>
    /// </summary>
    public void AddShortcut(uint itemID, int slot, byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, int, byte, void>)0x004BE630)(ref this, itemID, slot, broadcast);

    /// <summary>
    /// <code>Offset: 0x004BE730
    /// void __cdecl gmToolbarUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004BE730)();

    /// <summary>
    /// <code>Offset: 0x004BE750
    /// void __thiscall gmToolbarUI::CreateShortcutToItem(gmToolbarUI*,unsigned int,int,bool,bool)</code>
    /// </summary>
    public void CreateShortcutToItem(uint itemID, int shortcutIndex, byte pickUp, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, int, byte, byte, void>)0x004BE750)(ref this, itemID, shortcutIndex, pickUp, silent);

    /// <summary>
    /// <code>Offset: 0x004BE9E0
    /// void __thiscall gmToolbarUI::InitShortcutArray(gmToolbarUI*)</code>
    /// </summary>
    public void InitShortcutArray() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004BE9E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BF170
    /// void __thiscall gmToolbarUI::ListenToGlobalMessage(gmToolbarUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, int, void>)0x004BF170)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x004BF450
    /// void __thiscall gmToolbarUI::HandleDropRelease(gmToolbarUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004BF450)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004BF620
    /// void __thiscall gmToolbarUI::RecvNotice_AddShortcut(gmToolbarUI*,unsigned int,int)</code>
    /// </summary>
    public void RecvNotice_AddShortcut(uint i_itemID, int i_slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, int, void>)0x004BF620)(ref this, i_itemID, i_slot);

    /// <summary>
    /// <code>Offset: 0x004BF640
    /// void __thiscall gmToolbarUI::RecvNotice_FullMergingItem(gmToolbarUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_FullMergingItem(uint i_oldObject, uint i_mergeTo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, uint, void>)0x004BF640)(ref this, i_oldObject, i_mergeTo);

    /// <summary>
    /// <code>Offset: 0x004BF670
    /// void __thiscall gmToolbarUI::UpdateAmmoNumber(gmToolbarUI*)</code>
    /// </summary>
    public void UpdateAmmoNumber() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004BF670)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BF710
    /// void __thiscall gmToolbarUI::PostInit(gmToolbarUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004BF710)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BFB20
    /// UIElementMessageListenResult __thiscall gmToolbarUI::ListenToElementMessage(gmToolbarUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004BFB20)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004BFEA0
    /// void __thiscall gmToolbarUI::UpdateAmmoID(gmToolbarUI*)</code>
    /// </summary>
    public void UpdateAmmoID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004BFEA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BFF40
    /// void __thiscall gmToolbarUI::RecvNotice_ServerSaysMoveItem(gmToolbarUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004BFF40)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>
    /// <code>Offset: 0x004C0010
    /// void __thiscall gmToolbarUI::HandleSelectionChanged(gmToolbarUI*)</code>
    /// </summary>
    public void HandleSelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004C0010)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C04A0
    /// void __thiscall gmToolbarUI::UpdateFromPlayerDesc(gmToolbarUI*)</code>
    /// </summary>
    public void UpdateFromPlayerDesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004C04A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C0580
    /// void __thiscall gmToolbarUI::RecvNotice_ItemAttributesChanged(gmToolbarUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, uint, void>)0x004C0580)(ref this, i_target, i_attrib);

    /// <summary>
    /// <code>Offset: 0x004C0600
    /// void __thiscall gmToolbarUI::RecvNotice_SelectionChanged(gmToolbarUI*)</code>
    /// </summary>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004C0600)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C0610
    /// void __thiscall gmToolbarUI::RecvNotice_PlayerDescReceived(gmToolbarUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004C0610)(ref this, i_playerDesc, i_playerModule);
}

