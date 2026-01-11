namespace ACBindings.Internal;

public unsafe struct gmSalvageUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct gmSalvageUI_vtbl
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
    public ACBindings.Internal.UIElement_ItemList* m_salvageList;
    public ACBindings.Internal.UIElement* m_salvageButton;
    public uint m_toolID;
    public uint m_material;

    // Generated Constructor
    public gmSalvageUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004CBB30
    /// void __thiscall gmSalvageUI::~gmSalvageUI(gmSalvageUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, void>)0x004CBB30)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CBB90
    /// UIElement* __thiscall gmSalvageUI::DynamicCast(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, ACBindings.Internal.UIElement*>)0x004CBB90)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004CBBB0
    /// unsigned int __thiscall gmSalvageUI::GetUIElementType(gmSalvageUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint>)0x004CBBB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CBBC0
    /// void __thiscall gmSalvageUI::RemoveItem(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    public void RemoveItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, void>)0x004CBBC0)(ref this, itemID);

    /// <summary>
    /// <code>Offset: 0x004CBC30
    /// bool __thiscall gmSalvageUI::IsItemSuitable(gmSalvageUI*,ACCWeenieObject*)</code>
    /// </summary>
    public byte IsItemSuitable(ACBindings.Internal.ACCWeenieObject* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004CBC30)(ref this, item);

    /// <summary>
    /// <code>Offset: 0x004CBCA0
    /// void __thiscall gmSalvageUI::gmSalvageUI(gmSalvageUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004CBCA0)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004CBD30
    /// void __thiscall gmSalvageUI::PostInit(gmSalvageUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, void>)0x004CBD30)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CBE00
    /// void __thiscall gmSalvageUI::RecvNotice_RemoveSalvageItem(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_RemoveSalvageItem(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, void>)0x004CBE00)(ref this, i_itemID);

    /// <summary>
    /// <code>Offset: 0x004CBE10
    /// void __thiscall gmSalvageUI::RecvNotice_ItemListBeginDrag(gmSalvageUI*,const UIElement*,int)</code>
    /// </summary>
    public void RecvNotice_ItemListBeginDrag(ACBindings.Internal.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.UIElement*, int, void>)0x004CBE10)(ref this, i_itemList, i_slotNum);

    /// <summary>
    /// <code>Offset: 0x004CBE60
    /// void __thiscall gmSalvageUI::ClearAllTradeStates(gmSlumlordUI*,UIElement_ItemList*)</code>
    /// </summary>
    public void ClearAllTradeStates(ACBindings.Internal.UIElement_ItemList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.UIElement_ItemList*, void>)0x004CBE60)(ref this, list);

    /// <summary>
    /// <code>Offset: 0x004CBEC0
    /// bool __thiscall gmSalvageUI::_AddItem(gmSalvageUI*,ACCWeenieObject*)</code>
    /// </summary>
    public byte _AddItem(ACBindings.Internal.ACCWeenieObject* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004CBEC0)(ref this, item);

    /// <summary>
    /// <code>Offset: 0x004CBF50
    /// void __cdecl gmSalvageUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CBF50)();

    /// <summary>
    /// <code>Offset: 0x004CBFD0
    /// void __thiscall gmSalvageUI::CloseSalvagePanel(gmSalvageUI*)</code>
    /// </summary>
    public void CloseSalvagePanel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, void>)0x004CBFD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CC020
    /// bool __thiscall gmSalvageUI::AddNewItem(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    public byte AddNewItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, byte>)0x004CC020)(ref this, itemID);

    /// <summary>
    /// <code>Offset: 0x004CC060
    /// void __thiscall gmSalvageUI::OnVisibilityChanged(gmSalvageUI*,bool)</code>
    /// </summary>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, byte, void>)0x004CC060)(ref this, i_bVisible);

    /// <summary>
    /// <code>Offset: 0x004CC090
    /// void __thiscall gmSalvageUI::RecvNotice_OpenSalvagePanel(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_OpenSalvagePanel(uint i_toolID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, void>)0x004CC090)(ref this, i_toolID);

    /// <summary>
    /// <code>Offset: 0x004CC0A0
    /// void __thiscall gmSalvageUI::RecvNotice_AddSalvageItem(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_AddSalvageItem(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, void>)0x004CC0A0)(ref this, i_itemID);

    /// <summary>
    /// <code>Offset: 0x004CC0E0
    /// bool __thiscall gmSalvageUI::_AddContainedItems(gmSalvageUI*,ACCWeenieObject*)</code>
    /// </summary>
    public byte _AddContainedItems(ACBindings.Internal.ACCWeenieObject* container) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004CC0E0)(ref this, container);

    /// <summary>
    /// <code>Offset: 0x004CC240
    /// bool __thiscall gmSalvageUI::DragItemAcceptable(gmSalvageUI*,unsigned int,bool)</code>
    /// </summary>
    public byte DragItemAcceptable(uint itemID, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, byte, byte>)0x004CC240)(ref this, itemID, silent);

    /// <summary>
    /// <code>Offset: 0x004CC380
    /// bool __thiscall gmSalvageUI::AcceptDragObject(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    public byte AcceptDragObject(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, byte>)0x004CC380)(ref this, itemID);

    /// <summary>
    /// <code>Offset: 0x004CC3C0
    /// void __thiscall gmSalvageUI::HandleDropRelease(gmSalvageUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004CC3C0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004CC430
    /// bool __thiscall gmSalvageUI::Salvage(gmSalvageUI*)</code>
    /// </summary>
    public byte Salvage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, byte>)0x004CC430)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CC540
    /// UIElementMessageListenResult __thiscall gmSalvageUI::ListenToElementMessage(gmSalvageUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004CC540)(ref this, i_rMsg);
}

