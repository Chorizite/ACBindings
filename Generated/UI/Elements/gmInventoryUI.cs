namespace ACBindings;

// gmInventoryUI
public unsafe struct gmInventoryUI
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmInventoryUI_vtbl
    public unsafe struct gmInventoryUI_vtbl
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
    public ACBindings.gmPaperDollUI* m_paperDollUI;
    public ACBindings.gmBackpackUI* m_backpackUI;
    public ACBindings.gm3DItemsUI* m_3DItemsUI;
    public ACBindings.UIElement_Text* m_titleText;

    // Generated Constructor
    public gmInventoryUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods
    // void __thiscall gmInventoryUI::gmInventoryUI(gmInventoryUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmInventoryUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004A69E0)(ref this, layout, full_desc);
    // UIElement* __thiscall gmInventoryUI::DynamicCast(gmInventoryUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmInventoryUI, uint, ACBindings.UIElement*>)0x004A6A30)(ref this, i_eType);
    // unsigned int __thiscall gmInventoryUI::GetUIElementType(gmInventoryUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmInventoryUI, uint>)0x004A6A50)(ref this);
    // UIElement* __cdecl gmInventoryUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004A6A60)(layout, full_desc);
    // void __thiscall gmInventoryUI::RecvNotice_UpdateCharacterInformation(gmInventoryUI*,const CACQualities*)
    public void RecvNotice_UpdateCharacterInformation(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmInventoryUI, ACBindings.CACQualities*, void>)0x004A6A90)(ref this, i_playerDesc);
    // void __thiscall gmInventoryUI::RecvNotice_SetDisplayInventory(gmInventoryUI*,int)
    public void RecvNotice_SetDisplayInventory(int display) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmInventoryUI, int, void>)0x004A6AC0)(ref this, display);
    // void __thiscall gmInventoryUI::RecvNotice_ItemAttributesChanged(gmInventoryUI*,unsigned int,unsigned int)
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmInventoryUI, uint, uint, void>)0x004A6B80)(ref this, i_target, i_attrib);
    // void __thiscall gmInventoryUI::RecvNotice_ServerSaysMoveItem(gmInventoryUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmInventoryUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004A6BB0)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);
    // void __thiscall gmInventoryUI::RecvNotice_EndPendingInPlayer(gmInventoryUI*)
    public void RecvNotice_EndPendingInPlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmInventoryUI, void>)0x004A6C20)(ref this);
    // void __thiscall gmInventoryUI::PostInit(gmInventoryUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmInventoryUI, void>)0x004A6CB0)(ref this);
    // void __cdecl gmInventoryUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A6DD0)();
    // void __thiscall gmInventoryUI::RecvNotice_OpenContainedContainer(gmInventoryUI*,unsigned int)
    public void RecvNotice_OpenContainedContainer(uint i_containerID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmInventoryUI, uint, void>)0x004A6DF0)(ref this, i_containerID);
    // void __thiscall gmInventoryUI::RecvNotice_ShowPendingInPlayer(gmInventoryUI*,unsigned int)
    public void RecvNotice_ShowPendingInPlayer(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmInventoryUI, uint, void>)0x004A6EC0)(ref this, i_itemID);
    // void __thiscall gmInventoryUI::RecvNotice_PlayerDescReceived(gmInventoryUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmInventoryUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x004A6F30)(ref this, i_playerDesc, i_playerModule);
    // void __thiscall gmInventoryUI::RecvNotice_NewParentContainer(gmInventoryUI*,unsigned int)
    public void RecvNotice_NewParentContainer(uint i_newContainerID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmInventoryUI, uint, void>)0x004A7000)(ref this, i_newContainerID);
}

