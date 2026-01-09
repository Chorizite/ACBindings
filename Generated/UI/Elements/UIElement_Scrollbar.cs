namespace ACBindings;

// UIElement_Scrollbar
public unsafe struct UIElement_Scrollbar : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Button BaseClass_UIElement_Button; // ACBindings.UIElement_Button

    // Child Types
    // UIElement_Scrollbar_vtbl
    public unsafe struct UIElement_Scrollbar_vtbl
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
        public System.IntPtr AdjustToScrollableXYChange; // function pointer
        public System.IntPtr InqScrollDelta; // function pointer

        // Methods
    }
    // UIElement_Scrollbar::UIScrollBar_Flag
    public enum UIScrollBar_Flag : uint
    {
        UISB_NONE = 0x0,
        UISB_HORIZONTAL = 0x1,
        UISB_PROPORTIONAL = 0x2,
        UISB_DISABLED = 0x4,
        UISB_HIDE_DISABLED = 0x8,
        UISB_SMOOTH_MOVEMENT = 0x10,
        UISB_DISALLOW_UPDATING = 0x20,
        UISB_MOVE_TO_TOUCHED = 0x40,
        UISB_BUTTONS_INTERACT = 0x80,
        UISB_HAS_STOP_LOCATIONS = 0x100,
        UISB_MOUSE_PRESSED = 0x8000,
        UISB_OVER_WIDGET = 0x10000,
        UISB_OVER_BAR_LEFT = 0x20000,
        UISB_OVER_BAR_RIGHT = 0x40000,
        UISB_OVER_BAR_TOP = 0x80000,
        UISB_OVER_BAR_BOTTOM = 0x100000,
        UISB_RCV_MOUSEMOVE = 0x200000,
        UISB_ANIMATING = 0x400000,
        UISB_NEED_TO_KIDNAP_BUTTONS = 0x800000,
        UISB_GHOST_WHEN_DISABLED = 0x1000000,
        UISB_FORCEDWORD = 0xFFFFFFFF
    }

    // Members
    public ACBindings.UIElement* m_pWidget;
    public double m_tAnimStartTime;
    public double m_tAnimEndTime;
    public float m_fAnimStartPos;
    public float m_fAnimEndPos;
    public int m_nMouseWidgetXOffset;
    public int m_nMouseWidgetYOffset;
    public double m_nNextPageTime;
    public ACBindings.tagPOINT m_ptDragStart;
    public float m_fResetPosition;
    public byte m_bWidgetDragActive;
    public ACBindings.tagRECT m_rectScrollingArea;
    public uint m_eIncrementButtonID;
    public uint m_eDecrementButtonID;
    public uint m_bitField;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // UIElement* __thiscall UIElement_Scrollbar::DynamicCast(UIElement_Scrollbar*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, uint, ACBindings.UIElement*>)0x00470440)(ref this, i_eType);
    // UIElement* __cdecl UIElement_Scrollbar::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x00470470)(layout, full_desc);
    // bool __thiscall UIElement_Scrollbar::RegisterInputMaps(UIElement_Scrollbar*,int)
    public byte RegisterInputMaps(int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, int, byte>)0x004704A0)(ref this, i_nPriority);
    // bool __thiscall UIElement_Scrollbar::UnregisterInputMaps(UIElement_Scrollbar*)
    public byte UnregisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, byte>)0x004704E0)(ref this);
    // void __thiscall UIElement_Scrollbar::SetupDefaultHotClick(UIElement_Scrollbar*,UIElement*)
    public void SetupDefaultHotClick(ACBindings.UIElement* pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, ACBindings.UIElement*, void>)0x00470510)(ref this, pElement);
    // int __thiscall UIElement_Scrollbar::PositionToStop(UIElement_Scrollbar*,float)
    public int PositionToStop(float i_fNewPosition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, float, int>)0x00470580)(ref this, i_fNewPosition);
    // tagPOINT __thiscall UIElement_Scrollbar::GetScrollbarPositionFromMessage(UIElement_Scrollbar*,const UIElementMessageInfo*)
    public ACBindings.tagPOINT GetScrollbarPositionFromMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, ACBindings.UIElementMessageInfo*, ACBindings.tagPOINT>)0x00470620)(ref this, i_rMsg);
    // tagPOINT __thiscall UIElement_Scrollbar::ComputeActiveSize(UIElement_Scrollbar*)
    public ACBindings.tagPOINT ComputeActiveSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, ACBindings.tagPOINT>)0x00470660)(ref this);
    // void __thiscall UIElement_Scrollbar::SetBitMask(UIElement_Scrollbar*,const bool,const unsigned int)
    public void SetBitMask(byte i_bVal, uint i_nMask) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, byte, uint, void>)0x004706F0)(ref this, i_bVal, i_nMask);
    // void __thiscall UIElement_Scrollbar::SetHorizontal(UIElement_Scrollbar*,const bool)
    public void SetHorizontal(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, byte, void>)0x00470730)(ref this, b);
    // void __thiscall UIElement_Scrollbar::SetProportional(UIElement_Scrollbar*,const bool)
    public void SetProportional(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, byte, void>)0x00470760)(ref this, b);
    // void __thiscall UIElement_Scrollbar::SetDisabled(UIElement_Scrollbar*,const bool)
    public void SetDisabled(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, byte, void>)0x00470790)(ref this, b);
    // void __thiscall UIElement_Scrollbar::SetHideDisabled(UIElement_Scrollbar*,const bool)
    public void SetHideDisabled(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, byte, void>)0x004707C0)(ref this, b);
    // void __thiscall UIElement_Scrollbar::SetSmoothMovement(UIElement_Scrollbar*,const bool)
    public void SetSmoothMovement(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, byte, void>)0x004707F0)(ref this, b);
    // void __thiscall UIElement_Scrollbar::SetDisallowUpdating(UIElement_Scrollbar*,const bool)
    public void SetDisallowUpdating(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, byte, void>)0x00470820)(ref this, b);
    // void __thiscall UIElement_Scrollbar::SetMoveToTouched(UIElement_Scrollbar*,const bool)
    public void SetMoveToTouched(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, byte, void>)0x00470850)(ref this, b);
    // void __thiscall UIElement_Scrollbar::SetHasStopLocations(UIElement_Scrollbar*,const bool)
    public void SetHasStopLocations(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, byte, void>)0x00470880)(ref this, b);
    // int __thiscall UIElement_Scrollbar::GetSecondaryCoordinate(UIElement_Scrollbar*,const tagPOINT*)
    public int GetSecondaryCoordinate(ACBindings.tagPOINT* i_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, ACBindings.tagPOINT*, int>)0x004708B0)(ref this, i_pt);
    // void __thiscall UIElement_Scrollbar::Initialize(UIElement_Scrollbar*)
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, void>)0x004708E0)(ref this);
    // void __thiscall UIElement_Scrollbar::StartAnimation(UIElement_Scrollbar*)
    public void StartAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, void>)0x00470910)(ref this);
    // UIElement_Button* __thiscall UIElement_Scrollbar::GetButtonPointer_(UIElement_Scrollbar*,bool)
    public ACBindings.UIElement_Button* GetButtonPointer_(byte i_bIncrement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, byte, ACBindings.UIElement_Button*>)0x004709E0)(ref this, i_bIncrement);
    // void __thiscall UIElement_Scrollbar::UpdateButtonID_(UIElement_Scrollbar*,bool,unsigned int)
    public void UpdateButtonID_(byte i_bIncrement, uint i_eNewID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, byte, uint, void>)0x00470A40)(ref this, i_bIncrement, i_eNewID);
    // void __thiscall UIElement_Scrollbar::HandlePageClick(UIElement_Scrollbar*,const UIElementMessageInfo*)
    public void HandlePageClick(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, ACBindings.UIElementMessageInfo*, void>)0x00470A90)(ref this, i_rMsg);
    // float __thiscall UIElement_Scrollbar::StopToPosition(UIElement_Scrollbar*,int)
    public float StopToPosition(int i_nNewStop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, int, float>)0x00470B40)(ref this, i_nNewStop);
    // void __thiscall UIElement_Scrollbar::SetScrollbarStop(UIElement_Scrollbar*,int,bool)
    public void SetScrollbarStop(int i_nNewStop, byte i_bAllowSmoothMovement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, int, byte, void>)0x00470BF0)(ref this, i_nNewStop, i_bAllowSmoothMovement);
    // float __thiscall UIElement_Scrollbar::PointToPosition(UIElement_Scrollbar*,const tagPOINT*)
    public float PointToPosition(ACBindings.tagPOINT* i_ptElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, ACBindings.tagPOINT*, float>)0x00470C50)(ref this, i_ptElement);
    // tagPOINT __thiscall UIElement_Scrollbar::PositionToWidgetX0Y0(UIElement_Scrollbar*,float)
    public ACBindings.tagPOINT PositionToWidgetX0Y0(float i_fPosition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, float, ACBindings.tagPOINT>)0x00470D60)(ref this, i_fPosition);
    // void __thiscall UIElement_Scrollbar::UpdateScrollingArea(UIElement_Scrollbar*)
    public void UpdateScrollingArea() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, void>)0x00470E60)(ref this);
    // void __thiscall UIElement_Scrollbar::ValidatePosition(UIElement_Scrollbar*,float*)
    public void ValidatePosition(float* io_fPosition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, float*, void>)0x00470F20)(ref this, io_fPosition);
    // void __thiscall UIElement_Scrollbar::~UIElement_Scrollbar(UIElement_Scrollbar*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, void>)0x00470F80)(ref this);
    // bool __thiscall UIElement_Scrollbar::InqAvailableProperties(UIElement_Scrollbar*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, ACBindings.AvailablePropertySet*, byte>)0x00471010)(ref this, set);
    // void __thiscall UIElement_Scrollbar::Global_Loop(UIElement_Scrollbar*)
    public void Global_Loop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, void>)0x00471060)(ref this);
    // void __thiscall UIElement_Scrollbar::ListenToGlobalMessage(UIElement_Scrollbar*,unsigned int,int)
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, uint, int, void>)0x004711C0)(ref this, messageID, data_int);
    // void __thiscall UIElement_Scrollbar::HandleMoveSteps(UIElement_Scrollbar*,const unsigned int,const int)
    public void HandleMoveSteps(uint attributeID, int nSteps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, uint, int, void>)0x004711F0)(ref this, attributeID, nSteps);
    // void __thiscall UIElement_Scrollbar::HandleButtonClick(UIElement_Scrollbar*,const UIElementMessageInfo*)
    public void HandleButtonClick(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, ACBindings.UIElementMessageInfo*, void>)0x00471250)(ref this, i_rMsg);
    // void __thiscall UIElement_Scrollbar::SetScrollbarPosition(UIElement_Scrollbar*,float,bool)
    public void SetScrollbarPosition(float i_fNewPosition, byte i_bAllowSmoothMovement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, float, byte, void>)0x00471280)(ref this, i_fNewPosition, i_bAllowSmoothMovement);
    // void __thiscall UIElement_Scrollbar::ScrollToPoint(UIElement_Scrollbar*,const UIElementMessageInfo*,bool)
    public void ScrollToPoint(ACBindings.UIElementMessageInfo* i_rMsg, byte i_bAllowSmoothMovement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, ACBindings.UIElementMessageInfo*, byte, void>)0x00471310)(ref this, i_rMsg, i_bAllowSmoothMovement);
    // void __thiscall UIElement_Scrollbar::StartWidgetDrag(UIElement_Scrollbar*,const UIElementMessageInfo*)
    public void StartWidgetDrag(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, ACBindings.UIElementMessageInfo*, void>)0x00471370)(ref this, i_rMsg);
    // void __thiscall UIElement_Scrollbar::ScrollNPixelsFromReset(UIElement_Scrollbar*,const tagPOINT*,bool)
    public void ScrollNPixelsFromReset(ACBindings.tagPOINT* i_ptDelta, byte i_bAllowSmoothScrolling) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, ACBindings.tagPOINT*, byte, void>)0x004713E0)(ref this, i_ptDelta, i_bAllowSmoothScrolling);
    // void __thiscall UIElement_Scrollbar::UpdateLayout(UIElement_Scrollbar*)
    public void UpdateLayout() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, void>)0x00471490)(ref this);
    // void __thiscall UIElement_Scrollbar::ResizeTo(UIElement_Scrollbar*,const int,const int)
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, int, int, void>)0x004717F0)(ref this, width, height);
    // void __thiscall UIElement_Scrollbar::HandleMouseWheel(UIElement_Scrollbar*,unsigned int)
    public void HandleMouseWheel(uint buttonID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, uint, void>)0x00471810)(ref this, buttonID);
    // void __thiscall UIElement_Scrollbar::OnSetAttribute(UIElement_Scrollbar*,const BaseProperty*)
    public void OnSetAttribute(ACBindings.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, ACBindings.BaseProperty*, void>)0x00471890)(ref this, attribute);
    // UIElementMessageListenResult __thiscall UIElement_Scrollbar::ListenToElementMessage(UIElement_Scrollbar*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00471C30)(ref this, i_rMsg);
    // unsigned int __thiscall UIElement_Scrollbar::GetUIElementType(ImgTex*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollbar, uint>)0x00527480)(ref this);
}

