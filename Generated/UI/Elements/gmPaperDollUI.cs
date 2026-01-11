namespace ACBindings.Internal;

public unsafe struct gmPaperDollUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct gmPaperDollUI_vtbl
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
    public ACBindings.Internal.UIElement_ItemList* m_neckSlot;
    public ACBindings.Internal.UIElement_ItemList* m_leftWristSlot;
    public ACBindings.Internal.UIElement_ItemList* m_leftRingSlot;
    public ACBindings.Internal.UIElement_ItemList* m_rightWristSlot;
    public ACBindings.Internal.UIElement_ItemList* m_rightRingSlot;
    public ACBindings.Internal.UIElement_ItemList* m_weaponReadySlot;
    public ACBindings.Internal.UIElement_ItemList* m_ammoReadySlot;
    public ACBindings.Internal.UIElement_ItemList* m_shieldReadySlot;
    public ACBindings.Internal.UIElement_ItemList* m_clothesPantsSlot;
    public ACBindings.Internal.UIElement_ItemList* m_clothesShirtSlot;
    public ACBindings.Internal.UIElement_ItemList* m_trinketOneSlot;
    public ACBindings.Internal.UIElement_ItemList* m_cloakSlot;
    public ACBindings.Internal.UIElement_ItemList* m_sigilOneSlot;
    public ACBindings.Internal.UIElement_ItemList* m_sigilTwoSlot;
    public ACBindings.Internal.UIElement_ItemList* m_sigilThreeSlot;
    public ACBindings.Internal.UIElement_ItemList* m_headSlot;
    public ACBindings.Internal.UIElement_ItemList* m_chestSlot;
    public ACBindings.Internal.UIElement_ItemList* m_abdomenSlot;
    public ACBindings.Internal.UIElement_ItemList* m_upperArmSlot;
    public ACBindings.Internal.UIElement_ItemList* m_lowerArmSlot;
    public ACBindings.Internal.UIElement_ItemList* m_handSlot;
    public ACBindings.Internal.UIElement_ItemList* m_upperLegSlot;
    public ACBindings.Internal.UIElement_ItemList* m_lowerLegSlot;
    public ACBindings.Internal.UIElement_ItemList* m_footSlot;
    public ACBindings.Internal.CPhysicsObj* m_pInventoryObject;
    public ACBindings.Internal.UIElement_Viewport* m_pPaperDoll;
    public ACBindings.Internal.IDClass____tagDataID m_didAnimation;
    public ACBindings.Internal.UIElement* m_dragIcon;
    public ACBindings.Internal.UIElement* m_paperDollDragMask;
    public ACBindings.Internal.UIElement* m_paperDollDragOverlay;
    public ACBindings.Internal.UIElement* m_sigilOneItem;
    public ACBindings.Internal.UIElement* m_sigilTwoItem;
    public ACBindings.Internal.UIElement* m_sigilThreeItem;
    public ACBindings.Internal.UIElement_Button* m_SlotCheckbox;
    public ACBindings.Internal.RenderSurface* m_clickMap;
    public uint m_cFlipCount;
    public double m_timeNextFlip;
    public uint m_selectionMask;

    // Generated Constructor
    public gmPaperDollUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004A3900
    /// void __thiscall gmPaperDollUI::~gmPaperDollUI(gmPaperDollUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, void>)0x004A3900)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A3B30
    /// UIElement* __thiscall gmPaperDollUI::DynamicCast(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, ACBindings.Internal.UIElement*>)0x004A3B30)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004A3B50
    /// unsigned int __thiscall gmPaperDollUI::GetUIElementType(gmPaperDollUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint>)0x004A3B50)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A3B60
    /// void __thiscall gmPaperDollUI::GetLocationInfoFromElementID(gmPaperDollUI*,unsigned int,unsigned int*,UI_SLOT_SIDE*)</code>
    /// </summary>
    public void GetLocationInfoFromElementID(uint elemID, uint* loc, ACBindings.Internal.UI_SLOT_SIDE* slotSide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint*, ACBindings.Internal.UI_SLOT_SIDE*, void>)0x004A3B60)(ref this, elemID, loc, slotSide);

    /// <summary>
    /// <code>Offset: 0x004A3DE0
    /// void __thiscall gmPaperDollUI::HandlePaperDollDragOver(gmPaperDollUI*,UIElement*)</code>
    /// </summary>
    public void HandlePaperDollDragOver(ACBindings.Internal.UIElement* dragElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.UIElement*, void>)0x004A3DE0)(ref this, dragElement);

    /// <summary>
    /// <code>Offset: 0x004A3E80
    /// bool __thiscall gmPaperDollUI::AcceptDragObject(gmPaperDollUI*,unsigned int,unsigned int*,UI_SLOT_SIDE*)</code>
    /// </summary>
    public byte AcceptDragObject(uint itemID, uint* loc, ACBindings.Internal.UI_SLOT_SIDE* slotSide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint*, ACBindings.Internal.UI_SLOT_SIDE*, byte>)0x004A3E80)(ref this, itemID, loc, slotSide);

    /// <summary>
    /// <code>Offset: 0x004A3F30
    /// void __thiscall gmPaperDollUI::RedressCreature(gmPaperDollUI*)</code>
    /// </summary>
    public void RedressCreature() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, void>)0x004A3F30)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A4010
    /// void __thiscall gmPaperDollUI::ApplyPartSelectionLighting(gmPaperDollUI*,unsigned int,float,float)</code>
    /// </summary>
    public void ApplyPartSelectionLighting(uint locations, float luminosity, float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, float, float, void>)0x004A4010)(ref this, locations, luminosity, diffuse);

    /// <summary>
    /// <code>Offset: 0x004A41C0
    /// void __thiscall gmPaperDollUI::UpdateAetheria(gmPaperDollUI*,CWeenieObject*)</code>
    /// </summary>
    public void UpdateAetheria(ACBindings.Internal.CWeenieObject* cwobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.CWeenieObject*, void>)0x004A41C0)(ref this, cwobj);

    /// <summary>
    /// <code>Offset: 0x004A4240
    /// void __thiscall gmPaperDollUI::UpdateForRace(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    public void UpdateForRace(uint heritage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, void>)0x004A4240)(ref this, heritage);

    /// <summary>
    /// <code>Offset: 0x004A4430
    /// void __thiscall gmPaperDollUI::gmPaperDollUI(gmPaperDollUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004A4430)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004A45E0
    /// bool __thiscall gmPaperDollUI::OnItemListDragOver(gmPaperDollUI*,UIElement_UIItem*,unsigned int,unsigned int,DropItemFlags)</code>
    /// </summary>
    public byte OnItemListDragOver(ACBindings.Internal.UIElement_UIItem* catchElement, uint dropItemID, uint dropSpellID, ACBindings.Internal.DropItemFlags dropFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.UIElement_UIItem*, uint, uint, ACBindings.Internal.DropItemFlags, byte>)0x004A45E0)(ref this, catchElement, dropItemID, dropSpellID, dropFlags);

    /// <summary>
    /// <code>Offset: 0x004A46C0
    /// void __thiscall gmPaperDollUI::RecvNotice_PlayerObjDescChanged(gmPaperDollUI*)</code>
    /// </summary>
    public void RecvNotice_PlayerObjDescChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, void>)0x004A46C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A46D0
    /// void __thiscall gmPaperDollUI::UpdatePartSelectionLighting(gmPaperDollUI*)</code>
    /// </summary>
    public void UpdatePartSelectionLighting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, void>)0x004A46D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A4750
    /// void __thiscall gmPaperDollUI::RecvNotice_PlayerDescReceived(gmPaperDollUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004A4750)(ref this, i_playerDesc, i_playerModule);

    /// <summary>
    /// <code>Offset: 0x004A4800
    /// void __thiscall gmPaperDollUI::OnQualityChanged(gmPaperDollUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public void OnQualityChanged(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004A4800)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x004A48D0
    /// void __cdecl gmPaperDollUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A48D0)();

    /// <summary>
    /// <code>Offset: 0x004A48F0
    /// bool __thiscall gmPaperDollUI::PrepareDragIcon(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    public byte PrepareDragIcon(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, byte>)0x004A48F0)(ref this, itemID);

    /// <summary>
    /// <code>Offset: 0x004A4AC0
    /// unsigned int __thiscall gmPaperDollUI::GetUpperInvObj(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    public uint GetUpperInvObj(uint locations) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint>)0x004A4AC0)(ref this, locations);

    /// <summary>
    /// <code>Offset: 0x004A4BC0
    /// void __thiscall gmPaperDollUI::CreateClickMap(gmPaperDollUI*)</code>
    /// </summary>
    public void CreateClickMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, void>)0x004A4BC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A4C90
    /// unsigned int __thiscall gmPaperDollUI::GetPaperDollItemUnderMouse(gmPaperDollUI*,int,int)</code>
    /// </summary>
    public uint GetPaperDollItemUnderMouse(int window_mousex, int window_mousey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, int, int, uint>)0x004A4C90)(ref this, window_mousex, window_mousey);

    /// <summary>
    /// <code>Offset: 0x004A4DE0
    /// bool __thiscall gmPaperDollUI::AcceptPaperDollDragObject(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    public byte AcceptPaperDollDragObject(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, byte>)0x004A4DE0)(ref this, itemID);

    /// <summary>
    /// <code>Offset: 0x004A4EC0
    /// unsigned int __thiscall gmPaperDollUI::GetSelectionMaskFromObject(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    public uint GetSelectionMaskFromObject(uint objID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint>)0x004A4EC0)(ref this, objID);

    /// <summary>
    /// <code>Offset: 0x004A4FC0
    /// void __thiscall gmPaperDollUI::BeginPartSelectionLighting(gmPaperDollUI*,unsigned int)</code>
    /// </summary>
    public void BeginPartSelectionLighting(uint objID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, void>)0x004A4FC0)(ref this, objID);

    /// <summary>
    /// <code>Offset: 0x004A5020
    /// void __thiscall gmPaperDollUI::ListenToGlobalMessage(gmPaperDollUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, int, void>)0x004A5020)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x004A50F0
    /// void __thiscall gmPaperDollUI::HandleDropRelease(gmPaperDollUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004A50F0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004A51E0
    /// void __thiscall gmPaperDollUI::RecvNotice_SetSelectedItem(gmPaperDollUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint, void>)0x004A51E0)(ref this, oldSelectedID, selectedID);

    /// <summary>
    /// <code>Offset: 0x004A5200
    /// void __thiscall gmPaperDollUI::UpdateItemSlotTooltip(gmPaperDollUI*,UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    public void UpdateItemSlotTooltip(ACBindings.Internal.UIElement_ItemList* i_pSlot, uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.UIElement_ItemList*, uint, void>)0x004A5200)(ref this, i_pSlot, itemID);

    /// <summary>
    /// <code>Offset: 0x004A56D0
    /// void __thiscall gmPaperDollUI::PostInit(gmPaperDollUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, void>)0x004A56D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A5FA0
    /// UIElementMessageListenResult __thiscall gmPaperDollUI::ListenToElementMessage(gmPaperDollUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004A5FA0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004A6300
    /// void __thiscall gmPaperDollUI::SetUIItemIntoLocation(gmPaperDollUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void SetUIItemIntoLocation(uint itemID, uint location) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint, void>)0x004A6300)(ref this, itemID, location);

    /// <summary>
    /// <code>Offset: 0x004A6810
    /// void __thiscall gmPaperDollUI::ServerSaysMoveItem(gmPaperDollUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004A6810)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>
    /// <code>Offset: 0x004A6930
    /// bool __thiscall gmPaperDollUI::RemakeCharacterInventory(gmPaperDollUI*)</code>
    /// </summary>
    public byte RemakeCharacterInventory() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPaperDollUI, byte>)0x004A6930)(ref this);
}

