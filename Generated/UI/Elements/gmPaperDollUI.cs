namespace ACBindings;

// gmPaperDollUI
public unsafe struct gmPaperDollUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.QualityChangeHandler
    public ACBindings.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.ItemListDragHandler

    // Child Types
    // gmPaperDollUI_vtbl
    public unsafe struct gmPaperDollUI_vtbl
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
    public ACBindings.UIElement_ItemList* m_neckSlot;
    public ACBindings.UIElement_ItemList* m_leftWristSlot;
    public ACBindings.UIElement_ItemList* m_leftRingSlot;
    public ACBindings.UIElement_ItemList* m_rightWristSlot;
    public ACBindings.UIElement_ItemList* m_rightRingSlot;
    public ACBindings.UIElement_ItemList* m_weaponReadySlot;
    public ACBindings.UIElement_ItemList* m_ammoReadySlot;
    public ACBindings.UIElement_ItemList* m_shieldReadySlot;
    public ACBindings.UIElement_ItemList* m_clothesPantsSlot;
    public ACBindings.UIElement_ItemList* m_clothesShirtSlot;
    public ACBindings.UIElement_ItemList* m_trinketOneSlot;
    public ACBindings.UIElement_ItemList* m_cloakSlot;
    public ACBindings.UIElement_ItemList* m_sigilOneSlot;
    public ACBindings.UIElement_ItemList* m_sigilTwoSlot;
    public ACBindings.UIElement_ItemList* m_sigilThreeSlot;
    public ACBindings.UIElement_ItemList* m_headSlot;
    public ACBindings.UIElement_ItemList* m_chestSlot;
    public ACBindings.UIElement_ItemList* m_abdomenSlot;
    public ACBindings.UIElement_ItemList* m_upperArmSlot;
    public ACBindings.UIElement_ItemList* m_lowerArmSlot;
    public ACBindings.UIElement_ItemList* m_handSlot;
    public ACBindings.UIElement_ItemList* m_upperLegSlot;
    public ACBindings.UIElement_ItemList* m_lowerLegSlot;
    public ACBindings.UIElement_ItemList* m_footSlot;
    public ACBindings.CPhysicsObj* m_pInventoryObject;
    public ACBindings.UIElement_Viewport* m_pPaperDoll;
    public ACBindings.IDClass___tagDataID m_didAnimation;
    public ACBindings.UIElement* m_dragIcon;
    public ACBindings.UIElement* m_paperDollDragMask;
    public ACBindings.UIElement* m_paperDollDragOverlay;
    public ACBindings.UIElement* m_sigilOneItem;
    public ACBindings.UIElement* m_sigilTwoItem;
    public ACBindings.UIElement* m_sigilThreeItem;
    public ACBindings.UIElement_Button* m_SlotCheckbox;
    public ACBindings.RenderSurface* m_clickMap;
    public uint m_cFlipCount;
    public double m_timeNextFlip;
    public uint m_selectionMask;

    // Generated Constructor
    public gmPaperDollUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmPaperDollUI::~gmPaperDollUI(gmPaperDollUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, void>)0x004A3900)(ref this);
    // UIElement* __thiscall gmPaperDollUI::DynamicCast(gmPaperDollUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, ACBindings.UIElement*>)0x004A3B30)(ref this, i_eType);
    // unsigned int __thiscall gmPaperDollUI::GetUIElementType(gmPaperDollUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint>)0x004A3B50)(ref this);
    // void __thiscall gmPaperDollUI::GetLocationInfoFromElementID(gmPaperDollUI*,unsigned int,unsigned int*,UI_SLOT_SIDE*)
    public void GetLocationInfoFromElementID(uint elemID, uint* loc, ACBindings.UI_SLOT_SIDE* slotSide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, uint*, ACBindings.UI_SLOT_SIDE*, void>)0x004A3B60)(ref this, elemID, loc, slotSide);
    // void __thiscall gmPaperDollUI::HandlePaperDollDragOver(gmPaperDollUI*,UIElement*)
    public void HandlePaperDollDragOver(ACBindings.UIElement* dragElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, ACBindings.UIElement*, void>)0x004A3DE0)(ref this, dragElement);
    // bool __thiscall gmPaperDollUI::AcceptDragObject(gmPaperDollUI*,unsigned int,unsigned int*,UI_SLOT_SIDE*)
    public byte AcceptDragObject(uint itemID, uint* loc, ACBindings.UI_SLOT_SIDE* slotSide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, uint*, ACBindings.UI_SLOT_SIDE*, byte>)0x004A3E80)(ref this, itemID, loc, slotSide);
    // void __thiscall gmPaperDollUI::RedressCreature(gmPaperDollUI*)
    public void RedressCreature() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, void>)0x004A3F30)(ref this);
    // void __thiscall gmPaperDollUI::ApplyPartSelectionLighting(gmPaperDollUI*,unsigned int,float,float)
    public void ApplyPartSelectionLighting(uint locations, float luminosity, float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, float, float, void>)0x004A4010)(ref this, locations, luminosity, diffuse);
    // void __thiscall gmPaperDollUI::UpdateAetheria(gmPaperDollUI*,CWeenieObject*)
    public void UpdateAetheria(ACBindings.CWeenieObject* cwobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, ACBindings.CWeenieObject*, void>)0x004A41C0)(ref this, cwobj);
    // void __thiscall gmPaperDollUI::UpdateForRace(gmPaperDollUI*,unsigned int)
    public void UpdateForRace(uint heritage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, void>)0x004A4240)(ref this, heritage);
    // void __thiscall gmPaperDollUI::gmPaperDollUI(gmPaperDollUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004A4430)(ref this, layout, full_desc);
    // bool __thiscall gmPaperDollUI::OnItemListDragOver(gmPaperDollUI*,UIElement_UIItem*,unsigned int,unsigned int,DropItemFlags)
    public byte OnItemListDragOver(ACBindings.UIElement_UIItem* catchElement, uint dropItemID, uint dropSpellID, ACBindings.DropItemFlags dropFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, ACBindings.UIElement_UIItem*, uint, uint, ACBindings.DropItemFlags, byte>)0x004A45E0)(ref this, catchElement, dropItemID, dropSpellID, dropFlags);
    // void __thiscall gmPaperDollUI::RecvNotice_PlayerObjDescChanged(gmPaperDollUI*)
    public void RecvNotice_PlayerObjDescChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, void>)0x004A46C0)(ref this);
    // void __thiscall gmPaperDollUI::UpdatePartSelectionLighting(gmPaperDollUI*)
    public void UpdatePartSelectionLighting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, void>)0x004A46D0)(ref this);
    // void __thiscall gmPaperDollUI::RecvNotice_PlayerDescReceived(gmPaperDollUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x004A4750)(ref this, i_playerDesc, i_playerModule);
    // void __thiscall gmPaperDollUI::OnQualityChanged(gmPaperDollUI*,CWeenieObject*,StatType,unsigned int)
    public void OnQualityChanged(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, ACBindings.CWeenieObject*, ACBindings.StatType, uint, void>)0x004A4800)(ref this, cwobj, stype, senum);
    // void __cdecl gmPaperDollUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A48D0)();
    // bool __thiscall gmPaperDollUI::PrepareDragIcon(gmPaperDollUI*,unsigned int)
    public byte PrepareDragIcon(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, byte>)0x004A48F0)(ref this, itemID);
    // unsigned int __thiscall gmPaperDollUI::GetUpperInvObj(gmPaperDollUI*,unsigned int)
    public uint GetUpperInvObj(uint locations) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, uint>)0x004A4AC0)(ref this, locations);
    // void __thiscall gmPaperDollUI::CreateClickMap(gmPaperDollUI*)
    public void CreateClickMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, void>)0x004A4BC0)(ref this);
    // unsigned int __thiscall gmPaperDollUI::GetPaperDollItemUnderMouse(gmPaperDollUI*,int,int)
    public uint GetPaperDollItemUnderMouse(int window_mousex, int window_mousey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, int, int, uint>)0x004A4C90)(ref this, window_mousex, window_mousey);
    // bool __thiscall gmPaperDollUI::AcceptPaperDollDragObject(gmPaperDollUI*,unsigned int)
    public byte AcceptPaperDollDragObject(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, byte>)0x004A4DE0)(ref this, itemID);
    // unsigned int __thiscall gmPaperDollUI::GetSelectionMaskFromObject(gmPaperDollUI*,unsigned int)
    public uint GetSelectionMaskFromObject(uint objID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, uint>)0x004A4EC0)(ref this, objID);
    // void __thiscall gmPaperDollUI::BeginPartSelectionLighting(gmPaperDollUI*,unsigned int)
    public void BeginPartSelectionLighting(uint objID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, void>)0x004A4FC0)(ref this, objID);
    // void __thiscall gmPaperDollUI::ListenToGlobalMessage(gmPaperDollUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, int, void>)0x004A5020)(ref this, i_messageID, i_data_int);
    // void __thiscall gmPaperDollUI::HandleDropRelease(gmPaperDollUI*,const UIElementMessageInfo*)
    public void HandleDropRelease(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, ACBindings.UIElementMessageInfo*, void>)0x004A50F0)(ref this, i_rMsg);
    // void __thiscall gmPaperDollUI::RecvNotice_SetSelectedItem(gmPaperDollUI*,unsigned int,unsigned int)
    public void RecvNotice_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, uint, void>)0x004A51E0)(ref this, oldSelectedID, selectedID);
    // void __thiscall gmPaperDollUI::UpdateItemSlotTooltip(gmPaperDollUI*,UIElement_ItemList*,unsigned int)
    public void UpdateItemSlotTooltip(ACBindings.UIElement_ItemList* i_pSlot, uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, ACBindings.UIElement_ItemList*, uint, void>)0x004A5200)(ref this, i_pSlot, itemID);
    // void __thiscall gmPaperDollUI::PostInit(gmPaperDollUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, void>)0x004A56D0)(ref this);
    // UIElementMessageListenResult __thiscall gmPaperDollUI::ListenToElementMessage(gmPaperDollUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004A5FA0)(ref this, i_rMsg);
    // void __thiscall gmPaperDollUI::SetUIItemIntoLocation(gmPaperDollUI*,unsigned int,unsigned int)
    public void SetUIItemIntoLocation(uint itemID, uint location) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, uint, void>)0x004A6300)(ref this, itemID, location);
    // void __thiscall gmPaperDollUI::ServerSaysMoveItem(gmPaperDollUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004A6810)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);
    // bool __thiscall gmPaperDollUI::RemakeCharacterInventory(gmPaperDollUI*)
    public byte RemakeCharacterInventory() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPaperDollUI, byte>)0x004A6930)(ref this);
}

