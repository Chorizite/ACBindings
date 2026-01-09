namespace ACBindings;

// UIElement_ListBox
public unsafe struct UIElement_ListBox : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Scrollable BaseClass_UIElement_Scrollable; // ACBindings.UIElement_Scrollable

    // Child Types
    // UIElement_ListBox_vtbl
    public unsafe struct UIElement_ListBox_vtbl
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
        public System.IntPtr StartUpActive; // function pointer
        public System.IntPtr EndUpActive; // function pointer
        public System.IntPtr StartDownActive; // function pointer
        public System.IntPtr EndDownActive; // function pointer
        public System.IntPtr StartLeftActive; // function pointer
        public System.IntPtr EndLeftActive; // function pointer
        public System.IntPtr StartRightActive; // function pointer
        public System.IntPtr EndRightActive; // function pointer
        public System.IntPtr UpdateLayout; // function pointer

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
    public ACBindings.SmartArray__UIElement_ptr m_listItems;
    public ACBindings.UIElement* m_pSelectedItem;
    public ACBindings.UIElement* m_dragLastOver;
    public uint m_lastDragOverState;
    public int m_nCols;
    public int m_nRows;
    public ACBindings.SmartArray__int m_nItemHeights;
    public ACBindings.SmartArray__int m_nItemWidths;
    public double m_nAnimStartTime;
    public double m_nAnimEndTime;
    public int m_nAnimStartX;
    public int m_nAnimStartY;
    public int m_nAnimEndX;
    public int m_nAnimEndY;
    public uint m_bitField;

    // Generated Constructor
    public UIElement_ListBox(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall UIElement_ListBox::GetSelectedIndex(UIElement_ListBox*)
    public int GetSelectedIndex() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, int>)0x0046CF60)(ref this);
    // bool __thiscall UIElement_ListBox::SetState(UIElement_ListBox*,unsigned int)
    public byte SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, uint, byte>)0x0046D8F0)(ref this, state);
    // void __thiscall UIElement_ListBox::DrawStart(UIElement_ListBox*)
    public void DrawStart() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, void>)0x0046D920)(ref this);
    // void __thiscall UIElement_ListBox::ScrollToY(UIElement_ListBox*,int)
    public void ScrollToY(int i_iY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, int, void>)0x0046D930)(ref this, i_iY);
    // void __thiscall UIElement_ListBox::ScrollToX(UIElement_ListBox*,int)
    public void ScrollToX(int i_iX) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, int, void>)0x0046D950)(ref this, i_iX);
    // void __thiscall UIElement_ListBox::SetHorizontal(UIElement_ListBox*,const bool)
    public void SetHorizontal(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, byte, void>)0x0046D970)(ref this, b);
    // void __thiscall UIElement_ListBox::SetClickSelect(UIElement_ListBox*,const bool)
    public void SetClickSelect(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, byte, void>)0x0046D9A0)(ref this, b);
    // void __thiscall UIElement_ListBox::SetDragSelect(UIElement_ListBox*,const bool)
    public void SetDragSelect(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, byte, void>)0x0046D9D0)(ref this, b);
    // void __thiscall UIElement_ListBox::SetDragRollover(UIElement_ListBox*,const bool)
    public void SetDragRollover(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, byte, void>)0x0046DA00)(ref this, b);
    // void __thiscall UIElement_ListBox::SetSelectedItemStateChange(UIElement_ListBox*,const bool)
    public void SetSelectedItemStateChange(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, byte, void>)0x0046DA30)(ref this, b);
    // void __thiscall UIElement_ListBox::OnSetAttribute(UIElement_ListBox*,const BaseProperty*)
    public void OnSetAttribute(ACBindings.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.BaseProperty*, void>)0x0046DA60)(ref this, attribute);
    // void __thiscall UIElement_ListBox::ResizeTo(UIElement_ListBox*,const int,const int)
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, int, int, void>)0x0046DB70)(ref this, width, height);
    // void __thiscall UIElement_ListBox::UpdateForChildSizeChange(UIElement_ListBox*,UIElement*)
    public void UpdateForChildSizeChange(ACBindings.UIElement* i_pcChild) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.UIElement*, void>)0x0046DBD0)(ref this, i_pcChild);
    // int __thiscall UIElement_ListBox::CalculatePaperSize(UIElement_ListBox*,bool,int)
    public int CalculatePaperSize(byte i_bWidth, int i_iMax) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, byte, int, int>)0x0046DBF0)(ref this, i_bWidth, i_iMax);
    // UIElement* __thiscall UIElement_ListBox::GetItem(UIElement_ListBox*,unsigned int)
    public ACBindings.UIElement* GetItem(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, uint, ACBindings.UIElement*>)0x0046DC50)(ref this, index);
    // void __thiscall UIElement_ListBox::SetSelectedItem(UIElement_ListBox*,UIElement*,bool)
    public void SetSelectedItem(ACBindings.UIElement* pNewSelected, byte bBroadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.UIElement*, byte, void>)0x0046DC70)(ref this, pNewSelected, bBroadcast);
    // bool __thiscall UIElement_ListBox::InqItemIndexAtPoint(UIElement_ListBox*,int,int,unsigned int*)
    public byte InqItemIndexAtPoint(int i_iX, int i_iY, uint* o_iIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, int, int, uint*, byte>)0x0046DD60)(ref this, i_iX, i_iY, o_iIndex);
    // UIElement* __thiscall UIElement_ListBox::RemoveItem(UIElement_ListBox*,unsigned int)
    public ACBindings.UIElement* RemoveItem(uint itemIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, uint, ACBindings.UIElement*>)0x0046DE80)(ref this, itemIndex);
    // void __thiscall UIElement_ListBox::StartDragSelect(UIElement_ListBox*)
    public void StartDragSelect() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, void>)0x0046DF10)(ref this);
    // void __thiscall UIElement_ListBox::StartRollover(UIElement_ListBox*)
    public void StartRollover() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, void>)0x0046DF50)(ref this);
    // void __thiscall UIElement_ListBox::EndRollover(UIElement_ListBox*)
    public void EndRollover() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, void>)0x0046DF70)(ref this);
    // void __thiscall UIElement_ListBox::AdjustToScrollableXYChange(UIElement_ListBox*)
    public void AdjustToScrollableXYChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, void>)0x0046DFC0)(ref this);
    // int __thiscall UIElement_ListBox::InqScrollDelta(UIElement_ListBox*,bool,bool,bool)
    public int InqScrollDelta(byte i_bHorizontal, byte i_bIncrement, byte i_bPage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, byte, byte, byte, int>)0x0046DFD0)(ref this, i_bHorizontal, i_bIncrement, i_bPage);
    // void __thiscall UIElement_ListBox::UIElement_ListBox(UIElement_ListBox*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x0046E070)(ref this, layout, full_desc);
    // UIElement* __thiscall UIElement_ListBox::DynamicCast(UIElement_ListBox*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, uint, ACBindings.UIElement*>)0x0046E120)(ref this, i_eType);
    // void __thiscall UIElement_ListBox::~UIElement_ListBox(UIElement_ListBox*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, void>)0x0046E140)(ref this);
    // UIElement* __cdecl UIElement_ListBox::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0046E210)(layout, full_desc);
    // bool __thiscall UIElement_ListBox::InqAvailableProperties(UIElement_ListBox*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.AvailablePropertySet*, byte>)0x0046E240)(ref this, set);
    // void __thiscall UIElement_ListBox::MouseOverTop(UIElement_ListBox*,bool)
    public void MouseOverTop(byte bOverTop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, byte, void>)0x0046E290)(ref this, bOverTop);
    // void __thiscall UIElement_ListBox::MouseUp(UIElement_ListBox*,unsigned int,unsigned int,unsigned int)
    public void MouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, uint, uint, uint, void>)0x0046E2F0)(ref this, xWindow, yWindow, button);
    // UIElement* __thiscall UIElement_ListBox::GetItemAtPoint(UIElement_ListBox*,int,int)
    public ACBindings.UIElement* GetItemAtPoint(int scrX, int scrY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, int, int, ACBindings.UIElement*>)0x0046E360)(ref this, scrX, scrY);
    // UIElement* __thiscall UIElement_ListBox::RemoveItem(UIElement_ListBox*,UIElement*)
    public ACBindings.UIElement* RemoveItem(ACBindings.UIElement* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.UIElement*, ACBindings.UIElement*>)0x0046E3A0)(ref this, item);
    // bool __thiscall UIElement_ListBox::DeleteItem(UIElement_ListBox*,UIElement*)
    public byte DeleteItem(ACBindings.UIElement* pItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.UIElement*, byte>)0x0046E3E0)(ref this, pItem);
    // bool __thiscall UIElement_ListBox::DeleteItem(UIElement_ListBox*,int)
    public byte DeleteItem(int itemIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, int, byte>)0x0046E430)(ref this, itemIndex);
    // void __thiscall UIElement_ListBox::Flush(UIElement_ListBox*)
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, void>)0x0046E460)(ref this);
    // void __thiscall UIElement_ListBox::InitializeWidthHeightArray(UIElement_ListBox*,bool)
    public void InitializeWidthHeightArray(byte i_bWidth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, byte, void>)0x0046E550)(ref this, i_bWidth);
    // UIElement* __thiscall UIElement_ListBox::GetItemUnderMouse(UIElement_ListBox*)
    public ACBindings.UIElement* GetItemUnderMouse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.UIElement*>)0x0046E5E0)(ref this);
    // void __thiscall UIElement_ListBox::Rollover(UIElement_ListBox*)
    public void Rollover() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, void>)0x0046E650)(ref this);
    // UIElementMessageListenResult __thiscall UIElement_ListBox::ListenToElementMessage(UIElement_ListBox*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0046E710)(ref this, i_rMsg);
    // void __thiscall UIElement_ListBox::MouseDown(UIElement_ListBox*,unsigned int,unsigned int,unsigned int)
    public void MouseDown(uint x, uint y, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, uint, uint, uint, void>)0x0046E760)(ref this, x, y, button);
    // void __thiscall UIElement_ListBox::MouseMove(UIElement_ListBox*,int,int)
    public void MouseMove(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, int, int, void>)0x0046E7D0)(ref this, i_xWindow, i_yWindow);
    // void __thiscall UIElement_ListBox::UpdateLayout(UIElement_ListBox*)
    public void UpdateLayout() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, void>)0x0046E820)(ref this);
    // bool __thiscall UIElement_ListBox::InsertItem(UIElement_ListBox*,UIElement*,int)
    public byte InsertItem(ACBindings.UIElement* insertThis, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.UIElement*, int, byte>)0x0046EB20)(ref this, insertThis, here);
    // void __thiscall UIElement_ListBox::ScrollToShow(UIElement_ListBox*,int)
    public void ScrollToShow(int i_iItemNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, int, void>)0x0046ED00)(ref this, i_iItemNum);
    // void __thiscall UIElement_ListBox::ScrollToView(UIElement_ListBox*,int)
    public void ScrollToView(int i_iItemNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, int, void>)0x0046EDB0)(ref this, i_iItemNum);
    // void __thiscall UIElement_ListBox::ScrollToShow(UIElement_ListBox*,UIElement*)
    public void ScrollToShow(ACBindings.UIElement* i_pcItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.UIElement*, void>)0x0046EF20)(ref this, i_pcItem);
    // void __thiscall UIElement_ListBox::SetSelectedIndex(UIElement_ListBox*,unsigned int,bool)
    public void SetSelectedIndex(uint selectedIndex, byte bBroadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, uint, byte, void>)0x0046EF60)(ref this, selectedIndex, bBroadcast);
    // bool __thiscall UIElement_ListBox::InsertItem(UIElement_ListBox*,UIElement*,UIElement*)
    public byte InsertItem(ACBindings.UIElement* insertThis, ACBindings.UIElement* here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.UIElement*, ACBindings.UIElement*, byte>)0x0046EFC0)(ref this, insertThis, here);
    // bool __thiscall UIElement_ListBox::StartActive(UIElement_ListBox*,const int*)
    public byte StartActive(int* nDelta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, int*, byte>)0x0046F010)(ref this, nDelta);
    // void __thiscall UIElement_ListBox::SetSelectedItemByID(UIElement_ListBox*,unsigned int,bool)
    public void SetSelectedItemByID(uint itemID, byte bBroadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, uint, byte, void>)0x0046F0A0)(ref this, itemID, bBroadcast);
    // bool __thiscall UIElement_ListBox::AddItem(UIElement_ListBox*,UIElement*)
    public byte AddItem(ACBindings.UIElement* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.UIElement*, byte>)0x0046F130)(ref this, item);
    // UIElement* __thiscall UIElement_ListBox::AddItem(UIElement_ListBox*,int,unsigned int,UIElement*)
    public ACBindings.UIElement* AddItem(int a2, uint a3, ACBindings.UIElement* here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, int, uint, ACBindings.UIElement*, ACBindings.UIElement*>)0x0046F180)(ref this, a2, a3, here);
    // bool __thiscall UIElement_ListBox::StartUpActive(UIElement_ListBox*)
    public byte StartUpActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, byte>)0x0046F1E0)(ref this);
    // bool __thiscall UIElement_ListBox::StartDownActive(UIElement_ListBox*)
    public byte StartDownActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, byte>)0x0046F220)(ref this);
    // bool __thiscall UIElement_ListBox::StartLeftActive(UIElement_ListBox*)
    public byte StartLeftActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, byte>)0x0046F250)(ref this);
    // bool __thiscall UIElement_ListBox::StartRightActive(UIElement_ListBox*)
    public byte StartRightActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, byte>)0x0046F290)(ref this);
    // UIElement* __thiscall UIElement_ListBox::AddItemFromTemplateListByID(UIElement_ListBox*,unsigned int,UIElement*)
    public ACBindings.UIElement* AddItemFromTemplateListByID(uint i_item, ACBindings.UIElement* i_pInsertBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, uint, ACBindings.UIElement*, ACBindings.UIElement*>)0x0046F2C0)(ref this, i_item, i_pInsertBefore);
    // UIElement* __thiscall UIElement_ListBox::AddItem(UIElement_ListBox*,const BaseProperty*,UIElement*)
    public ACBindings.UIElement* AddItem(ACBindings.BaseProperty* propEntryStruct, ACBindings.UIElement* i_pInsertBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.BaseProperty*, ACBindings.UIElement*, ACBindings.UIElement*>)0x0046F530)(ref this, propEntryStruct, i_pInsertBefore);
    // UIElement* __thiscall UIElement_ListBox::AddItemFromTemplateList(UIElement_ListBox*,unsigned int,UIElement*)
    public ACBindings.UIElement* AddItemFromTemplateList(uint i_itemIndex, ACBindings.UIElement* i_pInsertBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, uint, ACBindings.UIElement*, ACBindings.UIElement*>)0x0046F670)(ref this, i_itemIndex, i_pInsertBefore);
    // UIElement* __thiscall UIElement_ListBox::AddItemFromTemplateList(UIElement_ListBox*,unsigned int,int)
    public ACBindings.UIElement* AddItemFromTemplateList(uint i_itemIndex, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, uint, int, ACBindings.UIElement*>)0x0046F770)(ref this, i_itemIndex, here);
    // int __thiscall UIElement_ListBox::WhatNum(UIElement_ListBox*,UIElement*)
    public int WhatNum(ACBindings.UIElement* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, ACBindings.UIElement*, int>)0x00480780)(ref this, item);
    // void __thiscall UIElement_ListBox::ScrollToHome(UIElement_ListBox*)
    public void ScrollToHome() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ListBox, void>)0x0048B400)(ref this);
}

