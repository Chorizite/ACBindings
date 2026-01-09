namespace ACBindings;

// UIElement_UIItem
public unsafe struct UIElement_UIItem
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // UIElement_UIItem_vtbl
    public unsafe struct UIElement_UIItem_vtbl
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
        public System.IntPtr DoHeartbeat; // function pointer

        // Methods
    }

    // Members
    public uint itemID;
    public uint spellID;
    public int containerDisplay;
    public ACBindings.ACCWeenieObject* weenObj;
    public uint effects;
    public int waiting;
    public int selected;
    public int isOpenable;
    public int isContainer;
    public int isContainerHolder;
    public int valid;
    public int dragOverState;
    public int unghostable;
    public int isSlot;
    public int shortcutState;
    public int m_sellState;
    public int m_tradeState;
    public byte m_selectable;
    public int m_shortcutNum;
    public int m_delayedShortcutNum;
    public byte m_shortcutGhosted;
    public int m_quantity;
    public int openState;
    public double m_heartbeatInterval;
    public double m_lastHeartbeat;
    public ACBindings.UIElement* m_elem_Icon;
    public ACBindings.UIElement* m_elem_Icon_Overlays;
    public ACBindings.UIElement* m_elem_Icon_Selected;
    public ACBindings.UIElement* m_elem_Icon_Ghosted;
    public ACBindings.UIElement* m_elem_Icon_ShortcutNum;
    public ACBindings.UIElement* m_elem_Icon_SellState;
    public ACBindings.UIElement* m_elem_Icon_TradeState;
    public ACBindings.UIElement* m_elem_Icon_OpenContainer;
    public ACBindings.UIElement* m_elem_Icon_DragAccept;
    public ACBindings.UIElement_Meter* m_elem_Icon_CapacityBar;
    public ACBindings.UIElement_Meter* m_elem_Icon_StructureBar;
    public ACBindings.UIElement_Text* m_elem_Icon_Quantity;
    public ACBindings.UIElement_Text* m_elem_Text;
    public ACBindings.UIElement* m_dragIcon;
    public ACBindings.UIElement* m_elem_Icon_Cooldown_10;
    public ACBindings.UIElement* m_elem_Icon_Cooldown_20;
    public ACBindings.UIElement* m_elem_Icon_Cooldown_30;
    public ACBindings.UIElement* m_elem_Icon_Cooldown_40;
    public ACBindings.UIElement* m_elem_Icon_Cooldown_50;
    public ACBindings.UIElement* m_elem_Icon_Cooldown_60;
    public ACBindings.UIElement* m_elem_Icon_Cooldown_70;
    public ACBindings.UIElement* m_elem_Icon_Cooldown_80;
    public ACBindings.UIElement* m_elem_Icon_Cooldown_90;
    public ACBindings.UIElement* m_elem_Icon_Cooldown_100;

    // Generated Constructor
    public UIElement_UIItem(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods
    // void __thiscall UIElement_UIItem::UIElement_UIItem(UIElement_UIItem*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004E1BD0)(ref this, layout, full_desc);
    // UIElement* __thiscall UIElement_UIItem::DynamicCast(UIElement_UIItem*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, uint, ACBindings.UIElement*>)0x004E1D40)(ref this, i_eType);
    // unsigned int __thiscall UIElement_UIItem::GetUIElementType(UIElement_UIItem*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, uint>)0x004E1D60)(ref this);
    // UIElement* __cdecl UIElement_UIItem::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004E1D70)(layout, full_desc);
    // void __thiscall UIElement_UIItem::Init_UIItem(UIElement_UIItem*,unsigned int,int)
    public void Init_UIItem(uint itemID, int containerDisplay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, uint, int, void>)0x004E1DA0)(ref this, itemID, containerDisplay);
    // void __thiscall UIElement_UIItem::Init_UIItem_Spell_Shortcut(UIElement_UIItem*,unsigned int)
    public void Init_UIItem_Spell_Shortcut(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, uint, void>)0x004E1DD0)(ref this, spellID);
    // void __thiscall UIElement_UIItem::Clear_UIItem(UIElement_UIItem*)
    public void Clear_UIItem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, void>)0x004E1E00)(ref this);
    // unsigned int __thiscall UIElement_UIItem::UIItem_GetState(UIElement_UIItem*)
    public uint UIItem_GetState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, uint>)0x004E1E20)(ref this);
    // void __thiscall UIElement_UIItem::SetWaitingState(UIElement_UIItem*,int)
    public void SetWaitingState(int waiting) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, int, void>)0x004E1E40)(ref this, waiting);
    // void __thiscall UIElement_UIItem::SetOpenContainerState(UIElement_UIItem*,bool)
    public void SetOpenContainerState(byte open) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, byte, void>)0x004E1E90)(ref this, open);
    // void __thiscall UIElement_UIItem::SetDelayedShortcutNum(UIElement_UIItem*,int)
    public void SetDelayedShortcutNum(int shortcutNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, int, void>)0x004E1EC0)(ref this, shortcutNum);
    // void __thiscall UIElement_UIItem::SetSelectedState(UIElement_UIItem*,int)
    public void SetSelectedState(int selected) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, int, void>)0x004E1ED0)(ref this, selected);
    // void __thiscall UIElement_UIItem::SetSelectableState(UIElement_UIItem*,bool)
    public void SetSelectableState(byte selectable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, byte, void>)0x004E1F10)(ref this, selectable);
    // void __thiscall UIElement_UIItem::SetDragAcceptState(UIElement_UIItem*,unsigned int)
    public void SetDragAcceptState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, uint, void>)0x004E1F20)(ref this, state);
    // void __thiscall UIElement_UIItem::SetQuantity(UIElement_UIItem*,int)
    public void SetQuantity(int quantity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, int, void>)0x004E1F50)(ref this, quantity);
    // void __thiscall UIElement_UIItem::ListenToGlobalMessage(UIElement_UIItem*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, uint, int, void>)0x004E1F60)(ref this, i_messageID, i_data_int);
    // void __cdecl UIElement_UIItem::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004E2000)();
    // UIElementMessageListenResult __thiscall UIElement_UIItem::ListenToElementMessage(UIElement_UIItem*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004E2020)(ref this, i_rMsg);
    // bool __thiscall UIElement_UIItem::UIItem_SetState(UIElement_UIItem*,unsigned int)
    public byte UIItem_SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, uint, byte>)0x004E2190)(ref this, state);
    // void __thiscall UIElement_UIItem::SetShortcutNum(UIElement_UIItem*,int,bool)
    public void SetShortcutNum(int shortcutNum, byte ghosted) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, int, byte, void>)0x004E2220)(ref this, shortcutNum, ghosted);
    // void __thiscall UIElement_UIItem::UpdateCapacityDisplay(UIElement_UIItem*)
    public void UpdateCapacityDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, void>)0x004E2370)(ref this);
    // void __thiscall UIElement_UIItem::UpdateStructureDisplay(UIElement_UIItem*)
    public void UpdateStructureDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, void>)0x004E2430)(ref this);
    // void __thiscall UIElement_UIItem::PostInit(UIElement_UIItem*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, void>)0x004E2500)(ref this);
    // bool __thiscall UIElement_UIItem::InqAvailableProperties(UIElement_UIItem*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, ACBindings.AvailablePropertySet*, byte>)0x004E2900)(ref this, set);
    // void __thiscall UIElement_UIItem::UpdateTooltip(UIElement_UIItem*)
    public void UpdateTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, void>)0x004E2940)(ref this);
    // void __thiscall UIElement_UIItem::UpdateQuantityDisplay(UIElement_UIItem*)
    public void UpdateQuantityDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, void>)0x004E2A30)(ref this);
    // void __thiscall UIElement_UIItem::UpdateCooldownDisplay(UIElement_UIItem*)
    public void UpdateCooldownDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, void>)0x004E2AB0)(ref this);
    // bool __thiscall UIElement_UIItem::UIItem_SetIcon(UIElement_UIItem*)
    public byte UIItem_SetIcon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, byte>)0x004E2D10)(ref this);
    // void __thiscall UIElement_UIItem::UIItem_Update(UIElement_UIItem*)
    public void UIItem_Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_UIItem, void>)0x004E2E60)(ref this);
}

