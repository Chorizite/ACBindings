namespace ACBindings.Internal;

public unsafe struct UIElement_SmartBoxWrapper
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct UIElement_SmartBoxWrapper_vtbl
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
    // UIElement_SmartBoxWrapper::SearchReason
    public enum SearchReason : byte
    {
        sr_None = 0x0,
        sr_MouseOver = 0x1,
        sr_Select = 0x2,
        sr_Examine = 0x3,
        sr_Use = 0x4,
        sr_Drop = 0x5,
        sr_Drag = 0x6,
        sr_TargetedUse = 0x7
    }

    // Members
    public uint m_cFlipCount;
    public double m_timeNextFlip;
    public uint m_iidUnderMouse;
    public uint m_iidSelectedObject;
    public ACBindings.Internal.UIElement_SmartBoxWrapper.SearchReason m_SearchReason;
    public byte m_fMouseMovementActive;
    public byte m_fMouseMovementInProgress;
    public ACBindings.Internal.SECTION_3D m_CurrentSection;
    public uint m_dropItemID;
    public uint m_targetMode;
    public ACBindings.Internal.UIElement* m_dragIcon;

    // Generated Constructor
    public UIElement_SmartBoxWrapper(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004E5DB0
    /// void __thiscall UIElement_SmartBoxWrapper::UIElement_SmartBoxWrapper(UIElement_SmartBoxWrapper*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004E5DB0)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004E5E60
    /// UIElement* __thiscall UIElement_SmartBoxWrapper::DynamicCast(UIElement_SmartBoxWrapper*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, ACBindings.Internal.UIElement*>)0x004E5E60)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004E5E80
    /// unsigned int __thiscall UIElement_SmartBoxWrapper::GetUIElementType(UIElement_SmartBoxWrapper*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint>)0x004E5E80)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E5EE0
    /// UIElement* __cdecl UIElement_SmartBoxWrapper::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004E5EE0)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004E5F10
    /// void __thiscall UIElement_SmartBoxWrapper::ResizeTo(UIElement_SmartBoxWrapper*,const int,const int)</code>
    /// </summary>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, int, int, void>)0x004E5F10)(ref this, width, height);

    /// <summary>
    /// <code>Offset: 0x004E5F60
    /// void __thiscall UIElement_SmartBoxWrapper::MoveTo(UIElement_SmartBoxWrapper*,const int,const int)</code>
    /// </summary>
    public void MoveTo(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, int, int, void>)0x004E5F60)(ref this, x, y);

    /// <summary>
    /// <code>Offset: 0x004E5FB0
    /// void __thiscall UIElement_SmartBoxWrapper::ApplyLighting(UIElement_SmartBoxWrapper*,unsigned int,LightingMode)</code>
    /// </summary>
    public void ApplyLighting(uint objID, ACBindings.Internal.LightingMode lightingMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, ACBindings.Internal.LightingMode, void>)0x004E5FB0)(ref this, objID, lightingMode);

    /// <summary>
    /// <code>Offset: 0x004E6010
    /// void __thiscall UIElement_SmartBoxWrapper::HandleTargetedUseLeftClick(UIElement_SmartBoxWrapper*,unsigned int,unsigned int)</code>
    /// </summary>
    public void HandleTargetedUseLeftClick(uint itemID, uint mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, uint, void>)0x004E6010)(ref this, itemID, mode);

    /// <summary>
    /// <code>Offset: 0x004E60A0
    /// void __cdecl UIElement_SmartBoxWrapper::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004E60A0)();

    /// <summary>
    /// <code>Offset: 0x004E60C0
    /// void __thiscall UIElement_SmartBoxWrapper::FindObject(UIElement_SmartBoxWrapper*,int,int,bool)</code>
    /// </summary>
    public void FindObject(int i_xWindow, int i_yWindow, byte fAccurate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, int, int, byte, void>)0x004E60C0)(ref this, i_xWindow, i_yWindow, fAccurate);

    /// <summary>
    /// <code>Offset: 0x004E6110
    /// void __thiscall UIElement_SmartBoxWrapper::HandleDropRelease(UIElement_SmartBoxWrapper*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, ACBindings.Internal.UIElementMessageInfo*, void>)0x004E6110)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004E61A0
    /// void __thiscall UIElement_SmartBoxWrapper::PostInit(UIElement_SmartBoxWrapper*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, void>)0x004E61A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E6200
    /// bool __thiscall UIElement_SmartBoxWrapper::InqAvailableProperties(UIElement_SmartBoxWrapper*,AvailablePropertySet*)</code>
    /// </summary>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, ACBindings.Internal.AvailablePropertySet*, byte>)0x004E6200)(ref this, set);

    /// <summary>
    /// <code>Offset: 0x004E6250
    /// UIElementMessageListenResult __thiscall UIElement_SmartBoxWrapper::ListenToElementMessage(UIElement_SmartBoxWrapper*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004E6250)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004E62B0
    /// void __thiscall UIElement_SmartBoxWrapper::Global_Loop(UIElement_SmartBoxWrapper*)</code>
    /// </summary>
    public void Global_Loop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, void>)0x004E62B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E6350
    /// void __thiscall UIElement_SmartBoxWrapper::MouseMove(UIElement_SmartBoxWrapper*,int,int)</code>
    /// </summary>
    public void MouseMove(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, int, int, void>)0x004E6350)(ref this, i_xWindow, i_yWindow);

    /// <summary>
    /// <code>Offset: 0x004E6390
    /// void __thiscall UIElement_SmartBoxWrapper::MouseDown(UIElement_SmartBoxWrapper*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void MouseDown(uint i_xWindow, uint i_yWindow, uint i_button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, uint, uint, void>)0x004E6390)(ref this, i_xWindow, i_yWindow, i_button);

    /// <summary>
    /// <code>Offset: 0x004E64B0
    /// void __thiscall UIElement_SmartBoxWrapper::MouseUp(UIElement_SmartBoxWrapper*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void MouseUp(uint i_xWindow, uint i_yWindow, uint i_button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, uint, uint, void>)0x004E64B0)(ref this, i_xWindow, i_yWindow, i_button);

    /// <summary>
    /// <code>Offset: 0x004E6580
    /// bool __thiscall UIElement_SmartBoxWrapper::PrepareDragIcon(UIElement_SmartBoxWrapper*,unsigned int)</code>
    /// </summary>
    public byte PrepareDragIcon(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, byte>)0x004E6580)(ref this, itemID);

    /// <summary>
    /// <code>Offset: 0x004E6750
    /// void __thiscall UIElement_SmartBoxWrapper::ListenToGlobalMessage(UIElement_SmartBoxWrapper*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, int, void>)0x004E6750)(ref this, messageID, data_int);

    /// <summary>
    /// <code>Offset: 0x004E6760
    /// void __thiscall UIElement_SmartBoxWrapper::RecvNotice_SmartBoxObjectFound(UIElement_SmartBoxWrapper*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_SmartBoxObjectFound(uint iidObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, void>)0x004E6760)(ref this, iidObject);
}

