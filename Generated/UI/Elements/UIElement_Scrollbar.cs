namespace ACBindings.Internal;

public unsafe struct UIElement_Scrollbar : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Button BaseClass_UIElement_Button; // ACBindings.Internal.UIElement_Button

    // Child Types
    public unsafe struct UIElement_Scrollbar_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_Scrollable*, void> AdjustToScrollableXYChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_Scrollable*, byte, byte, byte, int> InqScrollDelta; // function pointer

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
    public ACBindings.Internal.UIElement* m_pWidget;
    public double m_tAnimStartTime;
    public double m_tAnimEndTime;
    public float m_fAnimStartPos;
    public float m_fAnimEndPos;
    public int m_nMouseWidgetXOffset;
    public int m_nMouseWidgetYOffset;
    public double m_nNextPageTime;
    public ACBindings.Internal.tagPOINT m_ptDragStart;
    public float m_fResetPosition;
    public byte m_bWidgetDragActive;
    public ACBindings.Internal.tagRECT m_rectScrollingArea;
    public uint m_eIncrementButtonID;
    public uint m_eDecrementButtonID;
    public uint m_bitField;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00470440
    /// UIElement* __thiscall UIElement_Scrollbar::DynamicCast(UIElement_Scrollbar*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, uint, ACBindings.Internal.UIElement*>)0x00470440)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x00470470
    /// UIElement* __cdecl UIElement_Scrollbar::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00470470)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004704A0
    /// bool __thiscall UIElement_Scrollbar::RegisterInputMaps(UIElement_Scrollbar*,int)</code>
    /// </summary>
    public byte RegisterInputMaps(int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, int, byte>)0x004704A0)(ref this, i_nPriority);

    /// <summary>
    /// <code>Offset: 0x004704E0
    /// bool __thiscall UIElement_Scrollbar::UnregisterInputMaps(UIElement_Scrollbar*)</code>
    /// </summary>
    public byte UnregisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte>)0x004704E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00470510
    /// void __thiscall UIElement_Scrollbar::SetupDefaultHotClick(UIElement_Scrollbar*,UIElement*)</code>
    /// </summary>
    public void SetupDefaultHotClick(ACBindings.Internal.UIElement* pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElement*, void>)0x00470510)(ref this, pElement);

    /// <summary>
    /// <code>Offset: 0x00470580
    /// int __thiscall UIElement_Scrollbar::PositionToStop(UIElement_Scrollbar*,float)</code>
    /// </summary>
    public int PositionToStop(float i_fNewPosition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, float, int>)0x00470580)(ref this, i_fNewPosition);

    /// <summary>
    /// <code>Offset: 0x00470620
    /// tagPOINT __thiscall UIElement_Scrollbar::GetScrollbarPositionFromMessage(UIElement_Scrollbar*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.tagPOINT GetScrollbarPositionFromMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.tagPOINT>)0x00470620)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x00470660
    /// tagPOINT __thiscall UIElement_Scrollbar::ComputeActiveSize(UIElement_Scrollbar*)</code>
    /// </summary>
    public ACBindings.Internal.tagPOINT ComputeActiveSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.tagPOINT>)0x00470660)(ref this);

    /// <summary>
    /// <code>Offset: 0x004706F0
    /// void __thiscall UIElement_Scrollbar::SetBitMask(UIElement_Scrollbar*,const bool,const unsigned int)</code>
    /// </summary>
    public void SetBitMask(byte i_bVal, uint i_nMask) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, uint, void>)0x004706F0)(ref this, i_bVal, i_nMask);

    /// <summary>
    /// <code>Offset: 0x00470730
    /// void __thiscall UIElement_Scrollbar::SetHorizontal(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    public void SetHorizontal(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x00470730)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00470760
    /// void __thiscall UIElement_Scrollbar::SetProportional(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    public void SetProportional(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x00470760)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00470790
    /// void __thiscall UIElement_Scrollbar::SetDisabled(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    public void SetDisabled(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x00470790)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x004707C0
    /// void __thiscall UIElement_Scrollbar::SetHideDisabled(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    public void SetHideDisabled(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x004707C0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x004707F0
    /// void __thiscall UIElement_Scrollbar::SetSmoothMovement(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    public void SetSmoothMovement(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x004707F0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00470820
    /// void __thiscall UIElement_Scrollbar::SetDisallowUpdating(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    public void SetDisallowUpdating(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x00470820)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00470850
    /// void __thiscall UIElement_Scrollbar::SetMoveToTouched(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    public void SetMoveToTouched(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x00470850)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00470880
    /// void __thiscall UIElement_Scrollbar::SetHasStopLocations(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    public void SetHasStopLocations(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x00470880)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x004708B0
    /// int __thiscall UIElement_Scrollbar::GetSecondaryCoordinate(UIElement_Scrollbar*,const tagPOINT*)</code>
    /// </summary>
    public int GetSecondaryCoordinate(ACBindings.Internal.tagPOINT* i_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.tagPOINT*, int>)0x004708B0)(ref this, i_pt);

    /// <summary>
    /// <code>Offset: 0x004708E0
    /// void __thiscall UIElement_Scrollbar::Initialize(UIElement_Scrollbar*)</code>
    /// </summary>
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, void>)0x004708E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00470910
    /// void __thiscall UIElement_Scrollbar::StartAnimation(UIElement_Scrollbar*)</code>
    /// </summary>
    public void StartAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, void>)0x00470910)(ref this);

    /// <summary>
    /// <code>Offset: 0x004709E0
    /// UIElement_Button* __thiscall UIElement_Scrollbar::GetButtonPointer_(UIElement_Scrollbar*,bool)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_Button* GetButtonPointer_(byte i_bIncrement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, ACBindings.Internal.UIElement_Button*>)0x004709E0)(ref this, i_bIncrement);

    /// <summary>
    /// <code>Offset: 0x00470A40
    /// void __thiscall UIElement_Scrollbar::UpdateButtonID_(UIElement_Scrollbar*,bool,unsigned int)</code>
    /// </summary>
    public void UpdateButtonID_(byte i_bIncrement, uint i_eNewID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, uint, void>)0x00470A40)(ref this, i_bIncrement, i_eNewID);

    /// <summary>
    /// <code>Offset: 0x00470A90
    /// void __thiscall UIElement_Scrollbar::HandlePageClick(UIElement_Scrollbar*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void HandlePageClick(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElementMessageInfo*, void>)0x00470A90)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x00470B40
    /// float __thiscall UIElement_Scrollbar::StopToPosition(UIElement_Scrollbar*,int)</code>
    /// </summary>
    public float StopToPosition(int i_nNewStop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, int, float>)0x00470B40)(ref this, i_nNewStop);

    /// <summary>
    /// <code>Offset: 0x00470BF0
    /// void __thiscall UIElement_Scrollbar::SetScrollbarStop(UIElement_Scrollbar*,int,bool)</code>
    /// </summary>
    public void SetScrollbarStop(int i_nNewStop, byte i_bAllowSmoothMovement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, int, byte, void>)0x00470BF0)(ref this, i_nNewStop, i_bAllowSmoothMovement);

    /// <summary>
    /// <code>Offset: 0x00470C50
    /// float __thiscall UIElement_Scrollbar::PointToPosition(UIElement_Scrollbar*,const tagPOINT*)</code>
    /// </summary>
    public float PointToPosition(ACBindings.Internal.tagPOINT* i_ptElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.tagPOINT*, float>)0x00470C50)(ref this, i_ptElement);

    /// <summary>
    /// <code>Offset: 0x00470D60
    /// tagPOINT __thiscall UIElement_Scrollbar::PositionToWidgetX0Y0(UIElement_Scrollbar*,float)</code>
    /// </summary>
    public ACBindings.Internal.tagPOINT PositionToWidgetX0Y0(float i_fPosition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, float, ACBindings.Internal.tagPOINT>)0x00470D60)(ref this, i_fPosition);

    /// <summary>
    /// <code>Offset: 0x00470E60
    /// void __thiscall UIElement_Scrollbar::UpdateScrollingArea(UIElement_Scrollbar*)</code>
    /// </summary>
    public void UpdateScrollingArea() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, void>)0x00470E60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00470F20
    /// void __thiscall UIElement_Scrollbar::ValidatePosition(UIElement_Scrollbar*,float*)</code>
    /// </summary>
    public void ValidatePosition(float* io_fPosition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, float*, void>)0x00470F20)(ref this, io_fPosition);

    /// <summary>
    /// <code>Offset: 0x00470F80
    /// void __thiscall UIElement_Scrollbar::~UIElement_Scrollbar(UIElement_Scrollbar*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, void>)0x00470F80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00471010
    /// bool __thiscall UIElement_Scrollbar::InqAvailableProperties(UIElement_Scrollbar*,AvailablePropertySet*)</code>
    /// </summary>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.AvailablePropertySet*, byte>)0x00471010)(ref this, set);

    /// <summary>
    /// <code>Offset: 0x00471060
    /// void __thiscall UIElement_Scrollbar::Global_Loop(UIElement_Scrollbar*)</code>
    /// </summary>
    public void Global_Loop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, void>)0x00471060)(ref this);

    /// <summary>
    /// <code>Offset: 0x004711C0
    /// void __thiscall UIElement_Scrollbar::ListenToGlobalMessage(UIElement_Scrollbar*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, uint, int, void>)0x004711C0)(ref this, messageID, data_int);

    /// <summary>
    /// <code>Offset: 0x004711F0
    /// void __thiscall UIElement_Scrollbar::HandleMoveSteps(UIElement_Scrollbar*,const unsigned int,const int)</code>
    /// </summary>
    public void HandleMoveSteps(uint attributeID, int nSteps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, uint, int, void>)0x004711F0)(ref this, attributeID, nSteps);

    /// <summary>
    /// <code>Offset: 0x00471250
    /// void __thiscall UIElement_Scrollbar::HandleButtonClick(UIElement_Scrollbar*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void HandleButtonClick(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElementMessageInfo*, void>)0x00471250)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x00471280
    /// void __thiscall UIElement_Scrollbar::SetScrollbarPosition(UIElement_Scrollbar*,float,bool)</code>
    /// </summary>
    public void SetScrollbarPosition(float i_fNewPosition, byte i_bAllowSmoothMovement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, float, byte, void>)0x00471280)(ref this, i_fNewPosition, i_bAllowSmoothMovement);

    /// <summary>
    /// <code>Offset: 0x00471310
    /// void __thiscall UIElement_Scrollbar::ScrollToPoint(UIElement_Scrollbar*,const UIElementMessageInfo*,bool)</code>
    /// </summary>
    public void ScrollToPoint(ACBindings.Internal.UIElementMessageInfo* i_rMsg, byte i_bAllowSmoothMovement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElementMessageInfo*, byte, void>)0x00471310)(ref this, i_rMsg, i_bAllowSmoothMovement);

    /// <summary>
    /// <code>Offset: 0x00471370
    /// void __thiscall UIElement_Scrollbar::StartWidgetDrag(UIElement_Scrollbar*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void StartWidgetDrag(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElementMessageInfo*, void>)0x00471370)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004713E0
    /// void __thiscall UIElement_Scrollbar::ScrollNPixelsFromReset(UIElement_Scrollbar*,const tagPOINT*,bool)</code>
    /// </summary>
    public void ScrollNPixelsFromReset(ACBindings.Internal.tagPOINT* i_ptDelta, byte i_bAllowSmoothScrolling) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.tagPOINT*, byte, void>)0x004713E0)(ref this, i_ptDelta, i_bAllowSmoothScrolling);

    /// <summary>
    /// <code>Offset: 0x00471490
    /// void __thiscall UIElement_Scrollbar::UpdateLayout(UIElement_Scrollbar*)</code>
    /// </summary>
    public void UpdateLayout() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, void>)0x00471490)(ref this);

    /// <summary>
    /// <code>Offset: 0x004717F0
    /// void __thiscall UIElement_Scrollbar::ResizeTo(UIElement_Scrollbar*,const int,const int)</code>
    /// </summary>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, int, int, void>)0x004717F0)(ref this, width, height);

    /// <summary>
    /// <code>Offset: 0x00471810
    /// void __thiscall UIElement_Scrollbar::HandleMouseWheel(UIElement_Scrollbar*,unsigned int)</code>
    /// </summary>
    public void HandleMouseWheel(uint buttonID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, uint, void>)0x00471810)(ref this, buttonID);

    /// <summary>
    /// <code>Offset: 0x00471890
    /// void __thiscall UIElement_Scrollbar::OnSetAttribute(UIElement_Scrollbar*,const BaseProperty*)</code>
    /// </summary>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.BaseProperty*, void>)0x00471890)(ref this, attribute);

    /// <summary>
    /// <code>Offset: 0x00471C30
    /// UIElementMessageListenResult __thiscall UIElement_Scrollbar::ListenToElementMessage(UIElement_Scrollbar*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00471C30)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x00527480
    /// unsigned int __thiscall UIElement_Scrollbar::GetUIElementType(ImgTex*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, uint>)0x00527480)(ref this);
}

