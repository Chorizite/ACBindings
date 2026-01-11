namespace ACBindings.Internal;

public unsafe struct gmSmartBoxUI
{
    // Base Classes
    public ACBindings.Internal.UIElement_SmartBoxWrapper BaseClass_UIElement_SmartBoxWrapper; // ACBindings.Internal.UIElement_SmartBoxWrapper

    // Child Types
    public unsafe struct gmSmartBoxUI_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmSmartBoxUI*, void> UpdateFromPlayerModule; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartBox* m_pSmartBox;
    public ACBindings.Internal.CPhysicsObj* teleportObj;
    public double gameVDist;
    public ACBindings.Internal.TeleportAnimState teleportAnimState;
    public double teleportRotationStartTime;
    public double teleportRotationDuration;
    public double teleportRotationStartAngle;
    public double teleportRotationEndAngle;
    public double teleportTransitionStartTime;
    public double teleportRotationCurAngle;
    public float teleportCurVDist;
    public ACBindings.Internal.UIElement_Text* m_pFPSDisplay;
    public ACBindings.Internal.UIElement_Viewport* m_pPortalSpace;
    public ACBindings.Internal.VividTargetIndicator m_vti;
    public uint m_eWindowID;
    public ACBindings.Internal.UIElement* m_pTopBorder;
    public ACBindings.Internal.UIElement* m_pLeftBorder;
    public ACBindings.Internal.UIElement* m_pBottomBorder;
    public ACBindings.Internal.UIElement* m_pRightBorder;
    public ACBindings.Internal.UIElement* m_pTopLeftCorner;
    public ACBindings.Internal.UIElement* m_pTopRightCorner;
    public ACBindings.Internal.UIElement* m_pBottomLeftCorner;
    public ACBindings.Internal.UIElement* m_pBottomRightCorner;

    // Generated Constructor
    public gmSmartBoxUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004D6D20
    /// void __thiscall gmSmartBoxUI::gmSmartBoxUI(gmSmartBoxUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004D6D20)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004D6E10
    /// UIElement* __thiscall gmSmartBoxUI::DynamicCast(gmSmartBoxUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, uint, ACBindings.Internal.UIElement*>)0x004D6E10)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004D6E40
    /// unsigned int __thiscall gmSmartBoxUI::GetUIElementType(gmSmartBoxUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, uint>)0x004D6E40)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D6F20
    /// void __thiscall gmSmartBoxUI::RecvNotice_UpdateGameView(gmSmartBoxUI*,unsigned int,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_UpdateGameView(uint i_cxScreen, uint i_cyScreen, uint i_cxWidth, uint i_cyHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, uint, uint, uint, uint, void>)0x004D6F20)(ref this, i_cxScreen, i_cyScreen, i_cxWidth, i_cyHeight);

    /// <summary>
    /// <code>Offset: 0x004D6F60
    /// void __thiscall gmSmartBoxUI::BeginTeleportAnimation(gmSmartBoxUI*,TeleportAnimState)</code>
    /// </summary>
    public void BeginTeleportAnimation(ACBindings.Internal.TeleportAnimState animState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, ACBindings.Internal.TeleportAnimState, void>)0x004D6F60)(ref this, animState);

    /// <summary>
    /// <code>Offset: 0x004D7000
    /// void __thiscall gmSmartBoxUI::UpdateFPSMeter(gmSmartBoxUI*)</code>
    /// </summary>
    public void UpdateFPSMeter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, void>)0x004D7000)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D70A0
    /// void __thiscall gmSmartBoxUI::UpdateLockedStatus(gmSmartBoxUI*)</code>
    /// </summary>
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, void>)0x004D70A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D71E0
    /// void __cdecl gmSmartBoxUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D71E0)();

    /// <summary>
    /// <code>Offset: 0x004D7200
    /// void __thiscall gmSmartBoxUI::EndTeleportAnimation(gmSmartBoxUI*)</code>
    /// </summary>
    public void EndTeleportAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, void>)0x004D7200)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D7240
    /// void __thiscall gmSmartBoxUI::RecvNotice_SetFramerateDisplay(gmSmartBoxUI*,bool)</code>
    /// </summary>
    public void RecvNotice_SetFramerateDisplay(byte i_fShow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, byte, void>)0x004D7240)(ref this, i_fShow);

    /// <summary>
    /// <code>Offset: 0x004D72B0
    /// void __thiscall gmSmartBoxUI::ResizeTo(gmSmartBoxUI*,const int,const int)</code>
    /// </summary>
    public void ResizeTo(int i_width, int i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, int, int, void>)0x004D72B0)(ref this, i_width, i_height);

    /// <summary>
    /// <code>Offset: 0x004D7440
    /// void __thiscall gmSmartBoxUI::MoveTo(gmSmartBoxUI*,const int,const int)</code>
    /// </summary>
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, int, int, void>)0x004D7440)(ref this, i_x, i_y);

    /// <summary>
    /// <code>Offset: 0x004D7640
    /// void __thiscall gmSmartBoxUI::UpdateFromPlayerModule(gmSmartBoxUI*)</code>
    /// </summary>
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, void>)0x004D7640)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D77C0
    /// void __thiscall gmSmartBoxUI::PostInit(gmSmartBoxUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, void>)0x004D77C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D7A90
    /// void __thiscall gmSmartBoxUI::UseTime(gmSmartBoxUI*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, void>)0x004D7A90)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D8140
    /// void __thiscall gmSmartBoxUI::ListenToGlobalMessage(gmSmartBoxUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, uint, int, void>)0x004D8140)(ref this, i_messageID, i_data_int);
}

