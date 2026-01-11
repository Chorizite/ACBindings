namespace ACBindings.Internal;

public unsafe struct UIElement_Scrollable
{
    // Base Classes
    public ACBindings.Internal.UIElement BaseClass_UIElement; // ACBindings.Internal.UIElement

    // Child Types
    public unsafe struct UIElement_Scrollable_vtbl
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

    // Members
    public uint m_eHorizonalScrollbarID;
    public uint m_eVerticalScrollbarID;
    public int m_iScrollableX;
    public int m_iScrollableY;
    public int m_iScrollableWidth;
    public int m_iScrollableHeight;

    // Generated Constructor
    public UIElement_Scrollable(ACBindings.Internal.LayoutDesc* i_rcLayout, ACBindings.Internal.ElementDesc* i_rcFullDesc) {
        _ConstructorInternal(i_rcLayout, i_rcFullDesc);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00474150
    /// void __thiscall UIElement_Scrollable::UIElement_Scrollable(UIElement_Scrollable*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* i_rcLayout, ACBindings.Internal.ElementDesc* i_rcFullDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00474150)(ref this, i_rcLayout, i_rcFullDesc);

    /// <summary>
    /// <code>Offset: 0x004741A0
    /// UIElement* __thiscall UIElement_Scrollable::DynamicCast(UIElement_Scrollable*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, uint, ACBindings.Internal.UIElement*>)0x004741A0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004741C0
    /// void __thiscall UIElement_Scrollable::MouseDown(UIElement_Scrollable*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void MouseDown(uint i_xWindow, uint i_yWindow, uint i_eButton) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, uint, uint, uint, void>)0x004741C0)(ref this, i_xWindow, i_yWindow, i_eButton);

    /// <summary>
    /// <code>Offset: 0x00474210
    /// bool __thiscall UIElement_Scrollable::RegisterInputMaps(UIElement_Scrollable*,int)</code>
    /// </summary>
    public byte RegisterInputMaps(int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, int, byte>)0x00474210)(ref this, i_nPriority);

    /// <summary>
    /// <code>Offset: 0x00474250
    /// bool __thiscall UIElement_Scrollable::UnregisterInputMaps(UIElement_Scrollable*)</code>
    /// </summary>
    public byte UnregisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, byte>)0x00474250)(ref this);

    /// <summary>
    /// <code>Offset: 0x00474280
    /// UIElement_Scrollbar* __thiscall UIElement_Scrollable::GetScrollbarPointer_(UIElement_Scrollable*,bool)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_Scrollbar* GetScrollbarPointer_(byte i_bHorizontal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, byte, ACBindings.Internal.UIElement_Scrollbar*>)0x00474280)(ref this, i_bHorizontal);

    /// <summary>
    /// <code>Offset: 0x004742E0
    /// void __thiscall UIElement_Scrollable::UpdateScrollbarPosition_(UIElement_Scrollable*,bool)</code>
    /// </summary>
    public void UpdateScrollbarPosition_(byte i_bHorizontal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, byte, void>)0x004742E0)(ref this, i_bHorizontal);

    /// <summary>
    /// <code>Offset: 0x00474430
    /// bool __thiscall UIElement_Scrollable::InqAvailableProperties(UIElement_Scrollable*,AvailablePropertySet*)</code>
    /// </summary>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* o_rcSet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, ACBindings.Internal.AvailablePropertySet*, byte>)0x00474430)(ref this, o_rcSet);

    /// <summary>
    /// <code>Offset: 0x00474480
    /// void __thiscall UIElement_Scrollable::SetScrollableXY(UIElement_Scrollable*,int,int,bool)</code>
    /// </summary>
    public void SetScrollableXY(int i_iX, int i_iY, byte i_bForce) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, int, int, byte, void>)0x00474480)(ref this, i_iX, i_iY, i_bForce);

    /// <summary>
    /// <code>Offset: 0x00474560
    /// void __thiscall UIElement_Scrollable::UpdateScrollbarSize_(UIElement_Scrollable*,bool)</code>
    /// </summary>
    public void UpdateScrollbarSize_(byte i_bHorizontal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, byte, void>)0x00474560)(ref this, i_bHorizontal);

    /// <summary>
    /// <code>Offset: 0x00474730
    /// void __thiscall UIElement_Scrollable::HandleScrollbarMessage_(UIElement_Scrollable*,bool,const unsigned int,UIElement_Scrollbar*)</code>
    /// </summary>
    public void HandleScrollbarMessage_(byte i_bHorizontal, uint i_eMessageID, ACBindings.Internal.UIElement_Scrollbar* i_pcScrollbar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, byte, uint, ACBindings.Internal.UIElement_Scrollbar*, void>)0x00474730)(ref this, i_bHorizontal, i_eMessageID, i_pcScrollbar);

    /// <summary>
    /// <code>Offset: 0x00474870
    /// void __thiscall UIElement_Scrollable::PostInit(UIElement_Scrollable*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, void>)0x00474870)(ref this);

    /// <summary>
    /// <code>Offset: 0x00474920
    /// UIElementMessageListenResult __thiscall UIElement_Scrollable::ListenToElementMessage(UIElement_Scrollable*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00474920)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004749F0
    /// void __thiscall UIElement_Scrollable::OnSetAttribute(UIElement_Scrollable*,const BaseProperty*)</code>
    /// </summary>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* i_rcProperty) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, ACBindings.Internal.BaseProperty*, void>)0x004749F0)(ref this, i_rcProperty);

    /// <summary>
    /// <code>Offset: 0x00474A80
    /// void __thiscall UIElement_Scrollable::ResizeTo(UIElement_Scrollable*,const int,const int)</code>
    /// </summary>
    public void ResizeTo(int i_iWidth, int i_iHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, int, int, void>)0x00474A80)(ref this, i_iWidth, i_iHeight);

    /// <summary>
    /// <code>Offset: 0x00474AF0
    /// void __thiscall UIElement_Scrollable::ResizeScrollableArea(UIElement_Scrollable*,int,int)</code>
    /// </summary>
    public void ResizeScrollableArea(int i_iWidth, int i_iHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, int, int, void>)0x00474AF0)(ref this, i_iWidth, i_iHeight);
}

