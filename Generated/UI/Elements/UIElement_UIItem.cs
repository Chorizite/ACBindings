namespace ACBindings.Internal;

public unsafe struct UIElement_UIItem
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct UIElement_UIItem_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_UIItem*, void> DoHeartbeat; // function pointer

        // Methods
    }

    // Members
    public uint itemID;
    public uint spellID;
    public int containerDisplay;
    public ACBindings.Internal.ACCWeenieObject* weenObj;
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
    public ACBindings.Internal.UIElement* m_elem_Icon;
    public ACBindings.Internal.UIElement* m_elem_Icon_Overlays;
    public ACBindings.Internal.UIElement* m_elem_Icon_Selected;
    public ACBindings.Internal.UIElement* m_elem_Icon_Ghosted;
    public ACBindings.Internal.UIElement* m_elem_Icon_ShortcutNum;
    public ACBindings.Internal.UIElement* m_elem_Icon_SellState;
    public ACBindings.Internal.UIElement* m_elem_Icon_TradeState;
    public ACBindings.Internal.UIElement* m_elem_Icon_OpenContainer;
    public ACBindings.Internal.UIElement* m_elem_Icon_DragAccept;
    public ACBindings.Internal.UIElement_Meter* m_elem_Icon_CapacityBar;
    public ACBindings.Internal.UIElement_Meter* m_elem_Icon_StructureBar;
    public ACBindings.Internal.UIElement_Text* m_elem_Icon_Quantity;
    public ACBindings.Internal.UIElement_Text* m_elem_Text;
    public ACBindings.Internal.UIElement* m_dragIcon;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_10;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_20;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_30;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_40;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_50;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_60;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_70;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_80;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_90;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_100;

    // Generated Constructor
    public UIElement_UIItem(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004E1BD0
    /// void __thiscall UIElement_UIItem::UIElement_UIItem(UIElement_UIItem*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004E1BD0)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004E1D40
    /// UIElement* __thiscall UIElement_UIItem::DynamicCast(UIElement_UIItem*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint, ACBindings.Internal.UIElement*>)0x004E1D40)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004E1D60
    /// unsigned int __thiscall UIElement_UIItem::GetUIElementType(UIElement_UIItem*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint>)0x004E1D60)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E1D70
    /// UIElement* __cdecl UIElement_UIItem::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004E1D70)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004E1DA0
    /// void __thiscall UIElement_UIItem::Init_UIItem(UIElement_UIItem*,unsigned int,int)</code>
    /// </summary>
    public void Init_UIItem(uint itemID, int containerDisplay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint, int, void>)0x004E1DA0)(ref this, itemID, containerDisplay);

    /// <summary>
    /// <code>Offset: 0x004E1DD0
    /// void __thiscall UIElement_UIItem::Init_UIItem_Spell_Shortcut(UIElement_UIItem*,unsigned int)</code>
    /// </summary>
    public void Init_UIItem_Spell_Shortcut(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint, void>)0x004E1DD0)(ref this, spellID);

    /// <summary>
    /// <code>Offset: 0x004E1E00
    /// void __thiscall UIElement_UIItem::Clear_UIItem(UIElement_UIItem*)</code>
    /// </summary>
    public void Clear_UIItem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E1E00)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E1E20
    /// unsigned int __thiscall UIElement_UIItem::UIItem_GetState(UIElement_UIItem*)</code>
    /// </summary>
    public uint UIItem_GetState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint>)0x004E1E20)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E1E40
    /// void __thiscall UIElement_UIItem::SetWaitingState(UIElement_UIItem*,int)</code>
    /// </summary>
    public void SetWaitingState(int waiting) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, int, void>)0x004E1E40)(ref this, waiting);

    /// <summary>
    /// <code>Offset: 0x004E1E90
    /// void __thiscall UIElement_UIItem::SetOpenContainerState(UIElement_UIItem*,bool)</code>
    /// </summary>
    public void SetOpenContainerState(byte open) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, byte, void>)0x004E1E90)(ref this, open);

    /// <summary>
    /// <code>Offset: 0x004E1EC0
    /// void __thiscall UIElement_UIItem::SetDelayedShortcutNum(UIElement_UIItem*,int)</code>
    /// </summary>
    public void SetDelayedShortcutNum(int shortcutNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, int, void>)0x004E1EC0)(ref this, shortcutNum);

    /// <summary>
    /// <code>Offset: 0x004E1ED0
    /// void __thiscall UIElement_UIItem::SetSelectedState(UIElement_UIItem*,int)</code>
    /// </summary>
    public void SetSelectedState(int selected) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, int, void>)0x004E1ED0)(ref this, selected);

    /// <summary>
    /// <code>Offset: 0x004E1F10
    /// void __thiscall UIElement_UIItem::SetSelectableState(UIElement_UIItem*,bool)</code>
    /// </summary>
    public void SetSelectableState(byte selectable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, byte, void>)0x004E1F10)(ref this, selectable);

    /// <summary>
    /// <code>Offset: 0x004E1F20
    /// void __thiscall UIElement_UIItem::SetDragAcceptState(UIElement_UIItem*,unsigned int)</code>
    /// </summary>
    public void SetDragAcceptState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint, void>)0x004E1F20)(ref this, state);

    /// <summary>
    /// <code>Offset: 0x004E1F50
    /// void __thiscall UIElement_UIItem::SetQuantity(UIElement_UIItem*,int)</code>
    /// </summary>
    public void SetQuantity(int quantity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, int, void>)0x004E1F50)(ref this, quantity);

    /// <summary>
    /// <code>Offset: 0x004E1F60
    /// void __thiscall UIElement_UIItem::ListenToGlobalMessage(UIElement_UIItem*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint, int, void>)0x004E1F60)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x004E2000
    /// void __cdecl UIElement_UIItem::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004E2000)();

    /// <summary>
    /// <code>Offset: 0x004E2020
    /// UIElementMessageListenResult __thiscall UIElement_UIItem::ListenToElementMessage(UIElement_UIItem*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004E2020)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004E2190
    /// bool __thiscall UIElement_UIItem::UIItem_SetState(UIElement_UIItem*,unsigned int)</code>
    /// </summary>
    public byte UIItem_SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint, byte>)0x004E2190)(ref this, state);

    /// <summary>
    /// <code>Offset: 0x004E2220
    /// void __thiscall UIElement_UIItem::SetShortcutNum(UIElement_UIItem*,int,bool)</code>
    /// </summary>
    public void SetShortcutNum(int shortcutNum, byte ghosted) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, int, byte, void>)0x004E2220)(ref this, shortcutNum, ghosted);

    /// <summary>
    /// <code>Offset: 0x004E2370
    /// void __thiscall UIElement_UIItem::UpdateCapacityDisplay(UIElement_UIItem*)</code>
    /// </summary>
    public void UpdateCapacityDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2370)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E2430
    /// void __thiscall UIElement_UIItem::UpdateStructureDisplay(UIElement_UIItem*)</code>
    /// </summary>
    public void UpdateStructureDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2430)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E2500
    /// void __thiscall UIElement_UIItem::PostInit(UIElement_UIItem*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2500)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E2900
    /// bool __thiscall UIElement_UIItem::InqAvailableProperties(UIElement_UIItem*,AvailablePropertySet*)</code>
    /// </summary>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, ACBindings.Internal.AvailablePropertySet*, byte>)0x004E2900)(ref this, set);

    /// <summary>
    /// <code>Offset: 0x004E2940
    /// void __thiscall UIElement_UIItem::UpdateTooltip(UIElement_UIItem*)</code>
    /// </summary>
    public void UpdateTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2940)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E2A30
    /// void __thiscall UIElement_UIItem::UpdateQuantityDisplay(UIElement_UIItem*)</code>
    /// </summary>
    public void UpdateQuantityDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2A30)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E2AB0
    /// void __thiscall UIElement_UIItem::UpdateCooldownDisplay(UIElement_UIItem*)</code>
    /// </summary>
    public void UpdateCooldownDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2AB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E2D10
    /// bool __thiscall UIElement_UIItem::UIItem_SetIcon(UIElement_UIItem*)</code>
    /// </summary>
    public byte UIItem_SetIcon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, byte>)0x004E2D10)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E2E60
    /// void __thiscall UIElement_UIItem::UIItem_Update(UIElement_UIItem*)</code>
    /// </summary>
    public void UIItem_Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2E60)(ref this);
}

