namespace ACBindings.Internal;

public unsafe struct UIElement_ListBox : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Scrollable BaseClass_UIElement_Scrollable; // ACBindings.Internal.UIElement_Scrollable

    // Child Types
    public unsafe struct UIElement_ListBox_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartUpActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndUpActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartDownActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndDownActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartLeftActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndLeftActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartRightActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndRightActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, void> UpdateLayout; // function pointer

        // Methods
    }
    // UIElement_ListBox::UIListBox_Flag
    public enum UIListBox_Flag : ushort
    {
        UILB_NONE = 0x0,
        UILB_HORIZONTAL = 0x1,
        UILB_CLICK_SELECT = 0x2,
        UILB_DRAG_SELECT = 0x4,
        UILB_DRAG_ROLLOVER = 0x8,
        UILB_ALLOW_UPDATING = 0x10,
        UILB_SELECTED_ITEM_STATE_CHANGE = 0x20,
        UILB_DRAG_SELECTING = 0x40,
        UILB_SET_VIEW_STOP = 0x80,
        UILB_ROLLING_OVER = 0x100,
        UILB_DIRTY = 0x200
    }

    // Members
    public ACBindings.Internal.SmartArray___UIElement_ptr m_listItems;
    public ACBindings.Internal.UIElement* m_pSelectedItem;
    public ACBindings.Internal.UIElement* m_dragLastOver;
    public uint m_lastDragOverState;
    public int m_nCols;
    public int m_nRows;
    public ACBindings.Internal.SmartArray__int m_nItemHeights;
    public ACBindings.Internal.SmartArray__int m_nItemWidths;
    public double m_nAnimStartTime;
    public double m_nAnimEndTime;
    public int m_nAnimStartX;
    public int m_nAnimStartY;
    public int m_nAnimEndX;
    public int m_nAnimEndY;
    public uint m_bitField;

    // Generated Constructor
    public UIElement_ListBox(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0046CF60
    /// int __thiscall UIElement_ListBox::GetSelectedIndex(UIElement_ListBox*)</code>
    /// </summary>
    public int GetSelectedIndex() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int>)0x0046CF60)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046D8F0
    /// bool __thiscall UIElement_ListBox::SetState(UIElement_ListBox*,unsigned int)</code>
    /// </summary>
    public byte SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, byte>)0x0046D8F0)(ref this, state);

    /// <summary>
    /// <code>Offset: 0x0046D920
    /// void __thiscall UIElement_ListBox::DrawStart(UIElement_ListBox*)</code>
    /// </summary>
    public void DrawStart() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046D920)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046D930
    /// void __thiscall UIElement_ListBox::ScrollToY(UIElement_ListBox*,int)</code>
    /// </summary>
    public void ScrollToY(int i_iY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, void>)0x0046D930)(ref this, i_iY);

    /// <summary>
    /// <code>Offset: 0x0046D950
    /// void __thiscall UIElement_ListBox::ScrollToX(UIElement_ListBox*,int)</code>
    /// </summary>
    public void ScrollToX(int i_iX) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, void>)0x0046D950)(ref this, i_iX);

    /// <summary>
    /// <code>Offset: 0x0046D970
    /// void __thiscall UIElement_ListBox::SetHorizontal(UIElement_ListBox*,const bool)</code>
    /// </summary>
    public void SetHorizontal(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046D970)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0046D9A0
    /// void __thiscall UIElement_ListBox::SetClickSelect(UIElement_ListBox*,const bool)</code>
    /// </summary>
    public void SetClickSelect(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046D9A0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0046D9D0
    /// void __thiscall UIElement_ListBox::SetDragSelect(UIElement_ListBox*,const bool)</code>
    /// </summary>
    public void SetDragSelect(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046D9D0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0046DA00
    /// void __thiscall UIElement_ListBox::SetDragRollover(UIElement_ListBox*,const bool)</code>
    /// </summary>
    public void SetDragRollover(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046DA00)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0046DA30
    /// void __thiscall UIElement_ListBox::SetSelectedItemStateChange(UIElement_ListBox*,const bool)</code>
    /// </summary>
    public void SetSelectedItemStateChange(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046DA30)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0046DA60
    /// void __thiscall UIElement_ListBox::OnSetAttribute(UIElement_ListBox*,const BaseProperty*)</code>
    /// </summary>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.BaseProperty*, void>)0x0046DA60)(ref this, attribute);

    /// <summary>
    /// <code>Offset: 0x0046DB70
    /// void __thiscall UIElement_ListBox::ResizeTo(UIElement_ListBox*,const int,const int)</code>
    /// </summary>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, int, void>)0x0046DB70)(ref this, width, height);

    /// <summary>
    /// <code>Offset: 0x0046DBD0
    /// void __thiscall UIElement_ListBox::UpdateForChildSizeChange(UIElement_ListBox*,UIElement*)</code>
    /// </summary>
    public void UpdateForChildSizeChange(ACBindings.Internal.UIElement* i_pcChild) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, void>)0x0046DBD0)(ref this, i_pcChild);

    /// <summary>
    /// <code>Offset: 0x0046DBF0
    /// int __thiscall UIElement_ListBox::CalculatePaperSize(UIElement_ListBox*,bool,int)</code>
    /// </summary>
    public int CalculatePaperSize(byte i_bWidth, int i_iMax) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, int, int>)0x0046DBF0)(ref this, i_bWidth, i_iMax);

    /// <summary>
    /// <code>Offset: 0x0046DC50
    /// UIElement* __thiscall UIElement_ListBox::GetItem(UIElement_ListBox*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetItem(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, ACBindings.Internal.UIElement*>)0x0046DC50)(ref this, index);

    /// <summary>
    /// <code>Offset: 0x0046DC70
    /// void __thiscall UIElement_ListBox::SetSelectedItem(UIElement_ListBox*,UIElement*,bool)</code>
    /// </summary>
    public void SetSelectedItem(ACBindings.Internal.UIElement* pNewSelected, byte bBroadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, byte, void>)0x0046DC70)(ref this, pNewSelected, bBroadcast);

    /// <summary>
    /// <code>Offset: 0x0046DD60
    /// bool __thiscall UIElement_ListBox::InqItemIndexAtPoint(UIElement_ListBox*,int,int,unsigned int*)</code>
    /// </summary>
    public byte InqItemIndexAtPoint(int i_iX, int i_iY, uint* o_iIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, int, uint*, byte>)0x0046DD60)(ref this, i_iX, i_iY, o_iIndex);

    /// <summary>
    /// <code>Offset: 0x0046DE80
    /// UIElement* __thiscall UIElement_ListBox::RemoveItem(UIElement_ListBox*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* RemoveItem(uint itemIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, ACBindings.Internal.UIElement*>)0x0046DE80)(ref this, itemIndex);

    /// <summary>
    /// <code>Offset: 0x0046DF10
    /// void __thiscall UIElement_ListBox::StartDragSelect(UIElement_ListBox*)</code>
    /// </summary>
    public void StartDragSelect() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046DF10)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046DF50
    /// void __thiscall UIElement_ListBox::StartRollover(UIElement_ListBox*)</code>
    /// </summary>
    public void StartRollover() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046DF50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046DF70
    /// void __thiscall UIElement_ListBox::EndRollover(UIElement_ListBox*)</code>
    /// </summary>
    public void EndRollover() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046DF70)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046DFC0
    /// void __thiscall UIElement_ListBox::AdjustToScrollableXYChange(UIElement_ListBox*)</code>
    /// </summary>
    public void AdjustToScrollableXYChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046DFC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046DFD0
    /// int __thiscall UIElement_ListBox::InqScrollDelta(UIElement_ListBox*,bool,bool,bool)</code>
    /// </summary>
    public int InqScrollDelta(byte i_bHorizontal, byte i_bIncrement, byte i_bPage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, byte, byte, int>)0x0046DFD0)(ref this, i_bHorizontal, i_bIncrement, i_bPage);

    /// <summary>
    /// <code>Offset: 0x0046E070
    /// void __thiscall UIElement_ListBox::UIElement_ListBox(UIElement_ListBox*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0046E070)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0046E120
    /// UIElement* __thiscall UIElement_ListBox::DynamicCast(UIElement_ListBox*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, ACBindings.Internal.UIElement*>)0x0046E120)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x0046E140
    /// void __thiscall UIElement_ListBox::~UIElement_ListBox(UIElement_ListBox*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046E140)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046E210
    /// UIElement* __cdecl UIElement_ListBox::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0046E210)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0046E240
    /// bool __thiscall UIElement_ListBox::InqAvailableProperties(UIElement_ListBox*,AvailablePropertySet*)</code>
    /// </summary>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.AvailablePropertySet*, byte>)0x0046E240)(ref this, set);

    /// <summary>
    /// <code>Offset: 0x0046E290
    /// void __thiscall UIElement_ListBox::MouseOverTop(UIElement_ListBox*,bool)</code>
    /// </summary>
    public void MouseOverTop(byte bOverTop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046E290)(ref this, bOverTop);

    /// <summary>
    /// <code>Offset: 0x0046E2F0
    /// void __thiscall UIElement_ListBox::MouseUp(UIElement_ListBox*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void MouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, uint, uint, void>)0x0046E2F0)(ref this, xWindow, yWindow, button);

    /// <summary>
    /// <code>Offset: 0x0046E360
    /// UIElement* __thiscall UIElement_ListBox::GetItemAtPoint(UIElement_ListBox*,int,int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetItemAtPoint(int scrX, int scrY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, int, ACBindings.Internal.UIElement*>)0x0046E360)(ref this, scrX, scrY);

    /// <summary>
    /// <code>Offset: 0x0046E3A0
    /// UIElement* __thiscall UIElement_ListBox::RemoveItem(UIElement_ListBox*,UIElement*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* RemoveItem(ACBindings.Internal.UIElement* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x0046E3A0)(ref this, item);

    /// <summary>
    /// <code>Offset: 0x0046E3E0
    /// bool __thiscall UIElement_ListBox::DeleteItem(UIElement_ListBox*,UIElement*)</code>
    /// </summary>
    public byte DeleteItem(ACBindings.Internal.UIElement* pItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, byte>)0x0046E3E0)(ref this, pItem);

    /// <summary>
    /// <code>Offset: 0x0046E430
    /// bool __thiscall UIElement_ListBox::DeleteItem(UIElement_ListBox*,int)</code>
    /// </summary>
    public byte DeleteItem(int itemIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, byte>)0x0046E430)(ref this, itemIndex);

    /// <summary>
    /// <code>Offset: 0x0046E460
    /// void __thiscall UIElement_ListBox::Flush(UIElement_ListBox*)</code>
    /// </summary>
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046E460)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046E550
    /// void __thiscall UIElement_ListBox::InitializeWidthHeightArray(UIElement_ListBox*,bool)</code>
    /// </summary>
    public void InitializeWidthHeightArray(byte i_bWidth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046E550)(ref this, i_bWidth);

    /// <summary>
    /// <code>Offset: 0x0046E5E0
    /// UIElement* __thiscall UIElement_ListBox::GetItemUnderMouse(UIElement_ListBox*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetItemUnderMouse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*>)0x0046E5E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046E650
    /// void __thiscall UIElement_ListBox::Rollover(UIElement_ListBox*)</code>
    /// </summary>
    public void Rollover() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046E650)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046E710
    /// UIElementMessageListenResult __thiscall UIElement_ListBox::ListenToElementMessage(UIElement_ListBox*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0046E710)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x0046E760
    /// void __thiscall UIElement_ListBox::MouseDown(UIElement_ListBox*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void MouseDown(uint x, uint y, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, uint, uint, void>)0x0046E760)(ref this, x, y, button);

    /// <summary>
    /// <code>Offset: 0x0046E7D0
    /// void __thiscall UIElement_ListBox::MouseMove(UIElement_ListBox*,int,int)</code>
    /// </summary>
    public void MouseMove(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, int, void>)0x0046E7D0)(ref this, i_xWindow, i_yWindow);

    /// <summary>
    /// <code>Offset: 0x0046E820
    /// void __thiscall UIElement_ListBox::UpdateLayout(UIElement_ListBox*)</code>
    /// </summary>
    public void UpdateLayout() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046E820)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046EB20
    /// bool __thiscall UIElement_ListBox::InsertItem(UIElement_ListBox*,UIElement*,int)</code>
    /// </summary>
    public byte InsertItem(ACBindings.Internal.UIElement* insertThis, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, int, byte>)0x0046EB20)(ref this, insertThis, here);

    /// <summary>
    /// <code>Offset: 0x0046ED00
    /// void __thiscall UIElement_ListBox::ScrollToShow(UIElement_ListBox*,int)</code>
    /// </summary>
    public void ScrollToShow(int i_iItemNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, void>)0x0046ED00)(ref this, i_iItemNum);

    /// <summary>
    /// <code>Offset: 0x0046EDB0
    /// void __thiscall UIElement_ListBox::ScrollToView(UIElement_ListBox*,int)</code>
    /// </summary>
    public void ScrollToView(int i_iItemNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, void>)0x0046EDB0)(ref this, i_iItemNum);

    /// <summary>
    /// <code>Offset: 0x0046EF20
    /// void __thiscall UIElement_ListBox::ScrollToShow(UIElement_ListBox*,UIElement*)</code>
    /// </summary>
    public void ScrollToShow(ACBindings.Internal.UIElement* i_pcItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, void>)0x0046EF20)(ref this, i_pcItem);

    /// <summary>
    /// <code>Offset: 0x0046EF60
    /// void __thiscall UIElement_ListBox::SetSelectedIndex(UIElement_ListBox*,unsigned int,bool)</code>
    /// </summary>
    public void SetSelectedIndex(uint selectedIndex, byte bBroadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, byte, void>)0x0046EF60)(ref this, selectedIndex, bBroadcast);

    /// <summary>
    /// <code>Offset: 0x0046EFC0
    /// bool __thiscall UIElement_ListBox::InsertItem(UIElement_ListBox*,UIElement*,UIElement*)</code>
    /// </summary>
    public byte InsertItem(ACBindings.Internal.UIElement* insertThis, ACBindings.Internal.UIElement* here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte>)0x0046EFC0)(ref this, insertThis, here);

    /// <summary>
    /// <code>Offset: 0x0046F010
    /// bool __thiscall UIElement_ListBox::StartActive(UIElement_ListBox*,const int*)</code>
    /// </summary>
    public byte StartActive(int* nDelta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int*, byte>)0x0046F010)(ref this, nDelta);

    /// <summary>
    /// <code>Offset: 0x0046F0A0
    /// void __thiscall UIElement_ListBox::SetSelectedItemByID(UIElement_ListBox*,unsigned int,bool)</code>
    /// </summary>
    public void SetSelectedItemByID(uint itemID, byte bBroadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, byte, void>)0x0046F0A0)(ref this, itemID, bBroadcast);

    /// <summary>
    /// <code>Offset: 0x0046F130
    /// bool __thiscall UIElement_ListBox::AddItem(UIElement_ListBox*,UIElement*)</code>
    /// </summary>
    public byte AddItem(ACBindings.Internal.UIElement* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, byte>)0x0046F130)(ref this, item);

    /// <summary>
    /// <code>Offset: 0x0046F180
    /// UIElement* __thiscall UIElement_ListBox::AddItem(UIElement_ListBox*,int,unsigned int,UIElement*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* AddItem(int a2, uint a3, ACBindings.Internal.UIElement* here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, uint, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x0046F180)(ref this, a2, a3, here);

    /// <summary>
    /// <code>Offset: 0x0046F1E0
    /// bool __thiscall UIElement_ListBox::StartUpActive(UIElement_ListBox*)</code>
    /// </summary>
    public byte StartUpActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte>)0x0046F1E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046F220
    /// bool __thiscall UIElement_ListBox::StartDownActive(UIElement_ListBox*)</code>
    /// </summary>
    public byte StartDownActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte>)0x0046F220)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046F250
    /// bool __thiscall UIElement_ListBox::StartLeftActive(UIElement_ListBox*)</code>
    /// </summary>
    public byte StartLeftActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte>)0x0046F250)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046F290
    /// bool __thiscall UIElement_ListBox::StartRightActive(UIElement_ListBox*)</code>
    /// </summary>
    public byte StartRightActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte>)0x0046F290)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046F2C0
    /// UIElement* __thiscall UIElement_ListBox::AddItemFromTemplateListByID(UIElement_ListBox*,unsigned int,UIElement*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* AddItemFromTemplateListByID(uint i_item, ACBindings.Internal.UIElement* i_pInsertBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x0046F2C0)(ref this, i_item, i_pInsertBefore);

    /// <summary>
    /// <code>Offset: 0x0046F530
    /// UIElement* __thiscall UIElement_ListBox::AddItem(UIElement_ListBox*,const BaseProperty*,UIElement*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* AddItem(ACBindings.Internal.BaseProperty* propEntryStruct, ACBindings.Internal.UIElement* i_pInsertBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.BaseProperty*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x0046F530)(ref this, propEntryStruct, i_pInsertBefore);

    /// <summary>
    /// <code>Offset: 0x0046F670
    /// UIElement* __thiscall UIElement_ListBox::AddItemFromTemplateList(UIElement_ListBox*,unsigned int,UIElement*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* AddItemFromTemplateList(uint i_itemIndex, ACBindings.Internal.UIElement* i_pInsertBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x0046F670)(ref this, i_itemIndex, i_pInsertBefore);

    /// <summary>
    /// <code>Offset: 0x0046F770
    /// UIElement* __thiscall UIElement_ListBox::AddItemFromTemplateList(UIElement_ListBox*,unsigned int,int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* AddItemFromTemplateList(uint i_itemIndex, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, int, ACBindings.Internal.UIElement*>)0x0046F770)(ref this, i_itemIndex, here);

    /// <summary>
    /// <code>Offset: 0x00480780
    /// int __thiscall UIElement_ListBox::WhatNum(UIElement_ListBox*,UIElement*)</code>
    /// </summary>
    public int WhatNum(ACBindings.Internal.UIElement* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, int>)0x00480780)(ref this, item);

    /// <summary>
    /// <code>Offset: 0x0048B400
    /// void __thiscall UIElement_ListBox::ScrollToHome(UIElement_ListBox*)</code>
    /// </summary>
    public void ScrollToHome() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0048B400)(ref this);
}

