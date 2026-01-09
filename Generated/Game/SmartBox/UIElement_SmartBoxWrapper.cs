namespace ACBindings;

// UIElement_SmartBoxWrapper
public unsafe struct UIElement_SmartBoxWrapper
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // UIElement_SmartBoxWrapper_vtbl
    public unsafe struct UIElement_SmartBoxWrapper_vtbl
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
    public ACBindings.UIElement_SmartBoxWrapper.SearchReason m_SearchReason;
    public byte m_fMouseMovementActive;
    public byte m_fMouseMovementInProgress;
    public ACBindings.SECTION_3D m_CurrentSection;
    public uint m_dropItemID;
    public uint m_targetMode;
    public ACBindings.UIElement* m_dragIcon;

    // Generated Constructor
    public UIElement_SmartBoxWrapper(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods
    // void __thiscall UIElement_SmartBoxWrapper::UIElement_SmartBoxWrapper(UIElement_SmartBoxWrapper*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004E5DB0)(ref this, layout, full_desc);
    // UIElement* __thiscall UIElement_SmartBoxWrapper::DynamicCast(UIElement_SmartBoxWrapper*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, uint, ACBindings.UIElement*>)0x004E5E60)(ref this, i_eType);
    // unsigned int __thiscall UIElement_SmartBoxWrapper::GetUIElementType(UIElement_SmartBoxWrapper*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, uint>)0x004E5E80)(ref this);
    // UIElement* __cdecl UIElement_SmartBoxWrapper::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004E5EE0)(layout, full_desc);
    // void __thiscall UIElement_SmartBoxWrapper::ResizeTo(UIElement_SmartBoxWrapper*,const int,const int)
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, int, int, void>)0x004E5F10)(ref this, width, height);
    // void __thiscall UIElement_SmartBoxWrapper::MoveTo(UIElement_SmartBoxWrapper*,const int,const int)
    public void MoveTo(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, int, int, void>)0x004E5F60)(ref this, x, y);
    // void __thiscall UIElement_SmartBoxWrapper::ApplyLighting(UIElement_SmartBoxWrapper*,unsigned int,LightingMode)
    public void ApplyLighting(uint objID, ACBindings.LightingMode lightingMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, uint, ACBindings.LightingMode, void>)0x004E5FB0)(ref this, objID, lightingMode);
    // void __thiscall UIElement_SmartBoxWrapper::HandleTargetedUseLeftClick(UIElement_SmartBoxWrapper*,unsigned int,unsigned int)
    public void HandleTargetedUseLeftClick(uint itemID, uint mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, uint, uint, void>)0x004E6010)(ref this, itemID, mode);
    // void __cdecl UIElement_SmartBoxWrapper::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004E60A0)();
    // void __thiscall UIElement_SmartBoxWrapper::FindObject(UIElement_SmartBoxWrapper*,int,int,bool)
    public void FindObject(int i_xWindow, int i_yWindow, byte fAccurate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, int, int, byte, void>)0x004E60C0)(ref this, i_xWindow, i_yWindow, fAccurate);
    // void __thiscall UIElement_SmartBoxWrapper::HandleDropRelease(UIElement_SmartBoxWrapper*,const UIElementMessageInfo*)
    public void HandleDropRelease(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, ACBindings.UIElementMessageInfo*, void>)0x004E6110)(ref this, i_rMsg);
    // void __thiscall UIElement_SmartBoxWrapper::PostInit(UIElement_SmartBoxWrapper*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, void>)0x004E61A0)(ref this);
    // bool __thiscall UIElement_SmartBoxWrapper::InqAvailableProperties(UIElement_SmartBoxWrapper*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, ACBindings.AvailablePropertySet*, byte>)0x004E6200)(ref this, set);
    // UIElementMessageListenResult __thiscall UIElement_SmartBoxWrapper::ListenToElementMessage(UIElement_SmartBoxWrapper*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004E6250)(ref this, i_rMsg);
    // void __thiscall UIElement_SmartBoxWrapper::Global_Loop(UIElement_SmartBoxWrapper*)
    public void Global_Loop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, void>)0x004E62B0)(ref this);
    // void __thiscall UIElement_SmartBoxWrapper::MouseMove(UIElement_SmartBoxWrapper*,int,int)
    public void MouseMove(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, int, int, void>)0x004E6350)(ref this, i_xWindow, i_yWindow);
    // void __thiscall UIElement_SmartBoxWrapper::MouseDown(UIElement_SmartBoxWrapper*,unsigned int,unsigned int,unsigned int)
    public void MouseDown(uint i_xWindow, uint i_yWindow, uint i_button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, uint, uint, uint, void>)0x004E6390)(ref this, i_xWindow, i_yWindow, i_button);
    // void __thiscall UIElement_SmartBoxWrapper::MouseUp(UIElement_SmartBoxWrapper*,unsigned int,unsigned int,unsigned int)
    public void MouseUp(uint i_xWindow, uint i_yWindow, uint i_button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, uint, uint, uint, void>)0x004E64B0)(ref this, i_xWindow, i_yWindow, i_button);
    // bool __thiscall UIElement_SmartBoxWrapper::PrepareDragIcon(UIElement_SmartBoxWrapper*,unsigned int)
    public byte PrepareDragIcon(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, uint, byte>)0x004E6580)(ref this, itemID);
    // void __thiscall UIElement_SmartBoxWrapper::ListenToGlobalMessage(UIElement_SmartBoxWrapper*,unsigned int,int)
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, uint, int, void>)0x004E6750)(ref this, messageID, data_int);
    // void __thiscall UIElement_SmartBoxWrapper::RecvNotice_SmartBoxObjectFound(UIElement_SmartBoxWrapper*,unsigned int)
    public void RecvNotice_SmartBoxObjectFound(uint iidObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_SmartBoxWrapper, uint, void>)0x004E6760)(ref this, iidObject);
}

