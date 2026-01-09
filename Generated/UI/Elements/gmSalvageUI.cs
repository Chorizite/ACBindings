namespace ACBindings;

// gmSalvageUI
public unsafe struct gmSalvageUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.ItemListDragHandler

    // Child Types
    // gmSalvageUI_vtbl
    public unsafe struct gmSalvageUI_vtbl
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
    public ACBindings.UIElement_ItemList* m_salvageList;
    public ACBindings.UIElement* m_salvageButton;
    public uint m_toolID;
    public uint m_material;

    // Generated Constructor
    public gmSalvageUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmSalvageUI::~gmSalvageUI(gmSalvageUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, void>)0x004CBB30)(ref this);
    // UIElement* __thiscall gmSalvageUI::DynamicCast(gmSalvageUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, uint, ACBindings.UIElement*>)0x004CBB90)(ref this, i_eType);
    // unsigned int __thiscall gmSalvageUI::GetUIElementType(gmSalvageUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, uint>)0x004CBBB0)(ref this);
    // void __thiscall gmSalvageUI::RemoveItem(gmSalvageUI*,unsigned int)
    public void RemoveItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, uint, void>)0x004CBBC0)(ref this, itemID);
    // bool __thiscall gmSalvageUI::IsItemSuitable(gmSalvageUI*,ACCWeenieObject*)
    public byte IsItemSuitable(ACBindings.ACCWeenieObject* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, ACBindings.ACCWeenieObject*, byte>)0x004CBC30)(ref this, item);
    // void __thiscall gmSalvageUI::gmSalvageUI(gmSalvageUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004CBCA0)(ref this, layout, full_desc);
    // void __thiscall gmSalvageUI::PostInit(gmSalvageUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, void>)0x004CBD30)(ref this);
    // void __thiscall gmSalvageUI::RecvNotice_RemoveSalvageItem(gmSalvageUI*,unsigned int)
    public void RecvNotice_RemoveSalvageItem(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, uint, void>)0x004CBE00)(ref this, i_itemID);
    // void __thiscall gmSalvageUI::RecvNotice_ItemListBeginDrag(gmSalvageUI*,const UIElement*,int)
    public void RecvNotice_ItemListBeginDrag(ACBindings.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, ACBindings.UIElement*, int, void>)0x004CBE10)(ref this, i_itemList, i_slotNum);
    // void __thiscall gmSalvageUI::ClearAllTradeStates(gmSlumlordUI*,UIElement_ItemList*)
    public void ClearAllTradeStates(ACBindings.UIElement_ItemList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, ACBindings.UIElement_ItemList*, void>)0x004CBE60)(ref this, list);
    // bool __thiscall gmSalvageUI::_AddItem(gmSalvageUI*,ACCWeenieObject*)
    public byte _AddItem(ACBindings.ACCWeenieObject* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, ACBindings.ACCWeenieObject*, byte>)0x004CBEC0)(ref this, item);
    // void __cdecl gmSalvageUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CBF50)();
    // void __thiscall gmSalvageUI::CloseSalvagePanel(gmSalvageUI*)
    public void CloseSalvagePanel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, void>)0x004CBFD0)(ref this);
    // bool __thiscall gmSalvageUI::AddNewItem(gmSalvageUI*,unsigned int)
    public byte AddNewItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, uint, byte>)0x004CC020)(ref this, itemID);
    // void __thiscall gmSalvageUI::OnVisibilityChanged(gmSalvageUI*,bool)
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, byte, void>)0x004CC060)(ref this, i_bVisible);
    // void __thiscall gmSalvageUI::RecvNotice_OpenSalvagePanel(gmSalvageUI*,unsigned int)
    public void RecvNotice_OpenSalvagePanel(uint i_toolID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, uint, void>)0x004CC090)(ref this, i_toolID);
    // void __thiscall gmSalvageUI::RecvNotice_AddSalvageItem(gmSalvageUI*,unsigned int)
    public void RecvNotice_AddSalvageItem(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, uint, void>)0x004CC0A0)(ref this, i_itemID);
    // bool __thiscall gmSalvageUI::_AddContainedItems(gmSalvageUI*,ACCWeenieObject*)
    public byte _AddContainedItems(ACBindings.ACCWeenieObject* container) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, ACBindings.ACCWeenieObject*, byte>)0x004CC0E0)(ref this, container);
    // bool __thiscall gmSalvageUI::DragItemAcceptable(gmSalvageUI*,unsigned int,bool)
    public byte DragItemAcceptable(uint itemID, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, uint, byte, byte>)0x004CC240)(ref this, itemID, silent);
    // bool __thiscall gmSalvageUI::AcceptDragObject(gmSalvageUI*,unsigned int)
    public byte AcceptDragObject(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, uint, byte>)0x004CC380)(ref this, itemID);
    // void __thiscall gmSalvageUI::HandleDropRelease(gmSalvageUI*,const UIElementMessageInfo*)
    public void HandleDropRelease(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, ACBindings.UIElementMessageInfo*, void>)0x004CC3C0)(ref this, i_rMsg);
    // bool __thiscall gmSalvageUI::Salvage(gmSalvageUI*)
    public byte Salvage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, byte>)0x004CC430)(ref this);
    // UIElementMessageListenResult __thiscall gmSalvageUI::ListenToElementMessage(gmSalvageUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSalvageUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004CC540)(ref this, i_rMsg);
}

