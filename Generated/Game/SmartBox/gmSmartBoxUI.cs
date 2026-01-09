namespace ACBindings;

// gmSmartBoxUI
public unsafe struct gmSmartBoxUI
{
    // Base Classes
    public ACBindings.UIElement_SmartBoxWrapper BaseClass_UIElement_SmartBoxWrapper; // ACBindings.UIElement_SmartBoxWrapper

    // Child Types
    // gmSmartBoxUI_vtbl
    public unsafe struct gmSmartBoxUI_vtbl
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
        public System.IntPtr UpdateFromPlayerModule; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SmartBox* m_pSmartBox;
    public ACBindings.CPhysicsObj* teleportObj;
    public double gameVDist;
    public ACBindings.TeleportAnimState teleportAnimState;
    public double teleportRotationStartTime;
    public double teleportRotationDuration;
    public double teleportRotationStartAngle;
    public double teleportRotationEndAngle;
    public double teleportTransitionStartTime;
    public double teleportRotationCurAngle;
    public float teleportCurVDist;
    public ACBindings.UIElement_Text* m_pFPSDisplay;
    public ACBindings.UIElement_Viewport* m_pPortalSpace;
    public ACBindings.VividTargetIndicator m_vti;
    public uint m_eWindowID;
    public ACBindings.UIElement* m_pTopBorder;
    public ACBindings.UIElement* m_pLeftBorder;
    public ACBindings.UIElement* m_pBottomBorder;
    public ACBindings.UIElement* m_pRightBorder;
    public ACBindings.UIElement* m_pTopLeftCorner;
    public ACBindings.UIElement* m_pTopRightCorner;
    public ACBindings.UIElement* m_pBottomLeftCorner;
    public ACBindings.UIElement* m_pBottomRightCorner;

    // Generated Constructor
    public gmSmartBoxUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods
    // void __thiscall gmSmartBoxUI::gmSmartBoxUI(gmSmartBoxUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004D6D20)(ref this, layout, full_desc);
    // UIElement* __thiscall gmSmartBoxUI::DynamicCast(gmSmartBoxUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, uint, ACBindings.UIElement*>)0x004D6E10)(ref this, i_eType);
    // unsigned int __thiscall gmSmartBoxUI::GetUIElementType(gmSmartBoxUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, uint>)0x004D6E40)(ref this);
    // void __thiscall gmSmartBoxUI::RecvNotice_UpdateGameView(gmSmartBoxUI*,unsigned int,unsigned int,unsigned int,unsigned int)
    public void RecvNotice_UpdateGameView(uint i_cxScreen, uint i_cyScreen, uint i_cxWidth, uint i_cyHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, uint, uint, uint, uint, void>)0x004D6F20)(ref this, i_cxScreen, i_cyScreen, i_cxWidth, i_cyHeight);
    // void __thiscall gmSmartBoxUI::BeginTeleportAnimation(gmSmartBoxUI*,TeleportAnimState)
    public void BeginTeleportAnimation(ACBindings.TeleportAnimState animState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, ACBindings.TeleportAnimState, void>)0x004D6F60)(ref this, animState);
    // void __thiscall gmSmartBoxUI::UpdateFPSMeter(gmSmartBoxUI*)
    public void UpdateFPSMeter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, void>)0x004D7000)(ref this);
    // void __thiscall gmSmartBoxUI::UpdateLockedStatus(gmSmartBoxUI*)
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, void>)0x004D70A0)(ref this);
    // void __cdecl gmSmartBoxUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D71E0)();
    // void __thiscall gmSmartBoxUI::EndTeleportAnimation(gmSmartBoxUI*)
    public void EndTeleportAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, void>)0x004D7200)(ref this);
    // void __thiscall gmSmartBoxUI::RecvNotice_SetFramerateDisplay(gmSmartBoxUI*,bool)
    public void RecvNotice_SetFramerateDisplay(byte i_fShow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, byte, void>)0x004D7240)(ref this, i_fShow);
    // void __thiscall gmSmartBoxUI::ResizeTo(gmSmartBoxUI*,const int,const int)
    public void ResizeTo(int i_width, int i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, int, int, void>)0x004D72B0)(ref this, i_width, i_height);
    // void __thiscall gmSmartBoxUI::MoveTo(gmSmartBoxUI*,const int,const int)
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, int, int, void>)0x004D7440)(ref this, i_x, i_y);
    // void __thiscall gmSmartBoxUI::UpdateFromPlayerModule(gmSmartBoxUI*)
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, void>)0x004D7640)(ref this);
    // void __thiscall gmSmartBoxUI::PostInit(gmSmartBoxUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, void>)0x004D77C0)(ref this);
    // void __thiscall gmSmartBoxUI::UseTime(gmSmartBoxUI*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, void>)0x004D7A90)(ref this);
    // void __thiscall gmSmartBoxUI::ListenToGlobalMessage(gmSmartBoxUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSmartBoxUI, uint, int, void>)0x004D8140)(ref this, i_messageID, i_data_int);
}

