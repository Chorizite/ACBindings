namespace ACBindings;

// gmExternalContainerUI
public unsafe struct gmExternalContainerUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.ObjectRangeHandler
    public ACBindings.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.ItemListDragHandler

    // Child Types
    // gmExternalContainerUI_vtbl
    public unsafe struct gmExternalContainerUI_vtbl
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
    public ACBindings.UIElement_ItemList* m_topContainer;
    public ACBindings.UIElement_ItemList* m_containerList;
    public ACBindings.UIElement_ItemList* m_itemList;
    public uint groundObjectID;

    // Generated Constructor
    public gmExternalContainerUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmExternalContainerUI::~gmExternalContainerUI(gmExternalContainerUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExternalContainerUI, void>)0x004CC610)(ref this);
    // UIElement* __thiscall gmExternalContainerUI::DynamicCast(gmExternalContainerUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExternalContainerUI, uint, ACBindings.UIElement*>)0x004CC690)(ref this, i_eType);
    // unsigned int __thiscall gmExternalContainerUI::GetUIElementType(CombatManeuverTable*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExternalContainerUI, uint>)0x004CC6B0)(ref this);
    // UIElementMessageListenResult __thiscall gmExternalContainerUI::ListenToElementMessage(gmExternalContainerUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExternalContainerUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004CC6C0)(ref this, i_rMsg);
    // void __thiscall gmExternalContainerUI::RecvNotice_StopViewingObject(gmExternalContainerUI*,unsigned int)
    public void RecvNotice_StopViewingObject(uint i_objid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExternalContainerUI, uint, void>)0x004CC6F0)(ref this, i_objid);
    // void __thiscall gmExternalContainerUI::RecvNotice_ServerSaysMoveItem(gmExternalContainerUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExternalContainerUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004CC720)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);
    // bool __thiscall gmExternalContainerUI::DragItemAcceptable(gmExternalContainerUI*,unsigned int,bool)
    public byte DragItemAcceptable(uint itemID, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExternalContainerUI, uint, byte, byte>)0x004CC750)(ref this, itemID, silent);
    // void __thiscall gmExternalContainerUI::CloseCurrentContainer(gmExternalContainerUI*)
    public void CloseCurrentContainer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExternalContainerUI, void>)0x004CC8A0)(ref this);
    // void __thiscall gmExternalContainerUI::gmExternalContainerUI(gmExternalContainerUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExternalContainerUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004CC930)(ref this, layout, full_desc);
    // void __thiscall gmExternalContainerUI::PostInit(gmExternalContainerUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExternalContainerUI, void>)0x004CC9D0)(ref this);
    // void __thiscall gmExternalContainerUI::OnVisibilityChanged(gmExternalContainerUI*,bool)
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExternalContainerUI, byte, void>)0x004CCB40)(ref this, i_bVisible);
    // void __thiscall gmExternalContainerUI::RecvNotice_SetGroundObject(gmExternalContainerUI*,unsigned int)
    public void RecvNotice_SetGroundObject(uint i_objid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmExternalContainerUI, uint, void>)0x004CCBC0)(ref this, i_objid);
    // void __cdecl gmExternalContainerUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CCBD0)();
}

