namespace ACBindings.Internal;

public unsafe struct gmInventoryUI
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmInventoryUI_vtbl
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
    public ACBindings.Internal.gmPaperDollUI* m_paperDollUI;
    public ACBindings.Internal.gmBackpackUI* m_backpackUI;
    public ACBindings.Internal.gm3DItemsUI* m_3DItemsUI;
    public ACBindings.Internal.UIElement_Text* m_titleText;

    // Generated Constructor
    public gmInventoryUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004A69E0
    /// void __thiscall gmInventoryUI::gmInventoryUI(gmInventoryUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmInventoryUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004A69E0)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004A6A30
    /// UIElement* __thiscall gmInventoryUI::DynamicCast(gmInventoryUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmInventoryUI, uint, ACBindings.Internal.UIElement*>)0x004A6A30)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004A6A50
    /// unsigned int __thiscall gmInventoryUI::GetUIElementType(gmInventoryUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmInventoryUI, uint>)0x004A6A50)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A6A60
    /// UIElement* __cdecl gmInventoryUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004A6A60)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004A6A90
    /// void __thiscall gmInventoryUI::RecvNotice_UpdateCharacterInformation(gmInventoryUI*,const CACQualities*)</code>
    /// </summary>
    public void RecvNotice_UpdateCharacterInformation(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmInventoryUI, ACBindings.Internal.CACQualities*, void>)0x004A6A90)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004A6AC0
    /// void __thiscall gmInventoryUI::RecvNotice_SetDisplayInventory(gmInventoryUI*,int)</code>
    /// </summary>
    public void RecvNotice_SetDisplayInventory(int display) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmInventoryUI, int, void>)0x004A6AC0)(ref this, display);

    /// <summary>
    /// <code>Offset: 0x004A6B80
    /// void __thiscall gmInventoryUI::RecvNotice_ItemAttributesChanged(gmInventoryUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmInventoryUI, uint, uint, void>)0x004A6B80)(ref this, i_target, i_attrib);

    /// <summary>
    /// <code>Offset: 0x004A6BB0
    /// void __thiscall gmInventoryUI::RecvNotice_ServerSaysMoveItem(gmInventoryUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmInventoryUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004A6BB0)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>
    /// <code>Offset: 0x004A6C20
    /// void __thiscall gmInventoryUI::RecvNotice_EndPendingInPlayer(gmInventoryUI*)</code>
    /// </summary>
    public void RecvNotice_EndPendingInPlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmInventoryUI, void>)0x004A6C20)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A6CB0
    /// void __thiscall gmInventoryUI::PostInit(gmInventoryUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmInventoryUI, void>)0x004A6CB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A6DD0
    /// void __cdecl gmInventoryUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A6DD0)();

    /// <summary>
    /// <code>Offset: 0x004A6DF0
    /// void __thiscall gmInventoryUI::RecvNotice_OpenContainedContainer(gmInventoryUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_OpenContainedContainer(uint i_containerID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmInventoryUI, uint, void>)0x004A6DF0)(ref this, i_containerID);

    /// <summary>
    /// <code>Offset: 0x004A6EC0
    /// void __thiscall gmInventoryUI::RecvNotice_ShowPendingInPlayer(gmInventoryUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ShowPendingInPlayer(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmInventoryUI, uint, void>)0x004A6EC0)(ref this, i_itemID);

    /// <summary>
    /// <code>Offset: 0x004A6F30
    /// void __thiscall gmInventoryUI::RecvNotice_PlayerDescReceived(gmInventoryUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmInventoryUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004A6F30)(ref this, i_playerDesc, i_playerModule);

    /// <summary>
    /// <code>Offset: 0x004A7000
    /// void __thiscall gmInventoryUI::RecvNotice_NewParentContainer(gmInventoryUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_NewParentContainer(uint i_newContainerID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmInventoryUI, uint, void>)0x004A7000)(ref this, i_newContainerID);
}

