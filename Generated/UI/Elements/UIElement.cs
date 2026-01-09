namespace ACBindings;

// UIElement
public unsafe struct UIElement : System.IDisposable
{
    // Base Classes
    public ACBindings.UIRegion BaseClass_UIRegion; // ACBindings.UIRegion

    // Child Types
    // UIElement_vtbl
    public unsafe struct UIElement_vtbl
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
    // UIElement::FunctionSignatureChanged
    public enum FunctionSignatureChanged : uint
    {
    }
    // UIElement::Intialized_Has_Been_Replaced_With_PostInit
    public enum Intialized_Has_Been_Replaced_With_PostInit : uint
    {
    }

    // Members
    public ACBindings.UIElement* m_itemDragged;
    public ACBindings.UIElement* m_pFocusElement;
    public ACBindings.MediaMachine m_mediaMachine;
    public ACBindings.LayoutDesc* m_layout;
    public ACBindings.ElementDesc m_desc;
    public uint m_state;
    public ACBindings.StateDesc* m_curStateDesc;
    public ACBindings.PropertyCollection m_instanceProperties;
    public ACBindings.BorderLocation m_currentBorder;
    public int m_DragStartX;
    public int m_DragStartY;
    public int m_DragStartHeight;
    public int m_DragStartWidth;
    public int m_mouseInitialX;
    public int m_mouseInitialY;
    public System.IntPtr m_dragDropCallback; // function pointer
    public ACBindings.UILocationData m_defaultLocation;
    public ACBindings.StringInfo m_TTText;
    public byte m_bShouldBeMouseVisible;
    public byte m_bIsMouseVisible;
    public int m_cursorHotX;
    public int m_cursorHotY;
    public ACBindings.IDClass___tagDataID m_cursorDID;
    public ACBindings._7DD0ED236307E660189677EE91B10663 ___u24;
    public uint m_eClampGameView;
    public ACBindings.Box2D m_surfaceBox;
    public ACBindings.HashSet__UIListener_ptr m_hashListeners;
    public ACBindings.HashSetIterator__UIListener_ptr m_iterListeners;
    public uint m_idInputMap;

    // Generated Constructor
    public UIElement(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall UIElement::SetActivatable(UIElement*,bool)
    public void SetActivatable(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x004592D0)(ref this, b);
    // void __thiscall UIElement::SetObjectIsTemporary(UIElement*,bool)
    public void SetObjectIsTemporary(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x004592F0)(ref this, b);
    // void __thiscall UIElement::SetDragable(UIElement*,bool)
    public void SetDragable(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x0045F9D0)(ref this, b);
    // void __thiscall UIElement::SetActivateOnShow(UIElement*,bool)
    public void SetActivateOnShow(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x0045F9F0)(ref this, b);
    // void __thiscall UIElement::SetSaveLocation(UIElement*,bool)
    public void SetSaveLocation(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x0045FA10)(ref this, b);
    // void __thiscall UIElement::SetSaveSize(UIElement*,bool)
    public void SetSaveSize(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x0045FA30)(ref this, b);
    // void __thiscall UIElement::SetNotifyOnResize(UIElement*,bool)
    public void SetNotifyOnResize(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x0045FA50)(ref this, b);
    // void __thiscall UIElement::SetNotifyOnMove(UIElement*,bool)
    public void SetNotifyOnMove(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x0045FA70)(ref this, b);
    // void __thiscall UIElement::SetContextMenu(UIElement*,bool)
    public void SetContextMenu(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x0045FA90)(ref this, b);
    // void __thiscall UIElement::SetNotifyOnCreate(UIElement*,bool)
    public void SetNotifyOnCreate(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x0045FAB0)(ref this, b);
    // UIElement* __thiscall UIElement::GetRootElement(UIElement*)
    public ACBindings.UIElement* GetRootElement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElement*>)0x0045FB30)(ref this);
    // UIElement* __thiscall UIElement::GetAncestorByID(UIElement*,const unsigned int)
    public ACBindings.UIElement* GetAncestorByID(uint i_ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, ACBindings.UIElement*>)0x0045FB80)(ref this, i_ID);
    // bool __thiscall UIElement::IsAncestorOfMe(UIElement*,const UIElement*)
    public byte IsAncestorOfMe(ACBindings.UIElement* i_pAncestor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElement*, byte>)0x0045FBB0)(ref this, i_pAncestor);
    // bool __thiscall UIElement::RegisterInputMaps(UIElement*,int)
    public byte RegisterInputMaps(int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int, byte>)0x0045FBE0)(ref this, i_nPriority);
    // bool __thiscall UIElement::UnregisterInputMaps(UIElement*)
    public byte UnregisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte>)0x0045FC50)(ref this);
    // bool __thiscall UIElement::OnAction(UIElement*,const InputEvent*)
    public byte OnAction(ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.InputEvent*, byte>)0x0045FCA0)(ref this, i_evt);
    // bool __thiscall UIElement::OnChildAction(UIElement*,const UIElement*,const InputEvent*)
    public byte OnChildAction(ACBindings.UIElement* i_pChild, ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElement*, ACBindings.InputEvent*, byte>)0x0045FCE0)(ref this, i_pChild, i_evt);
    // bool __thiscall UIElement::DefElementMessageHandler(UIElement*,const UIElementMessageInfo*)
    public byte DefElementMessageHandler(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElementMessageInfo*, byte>)0x0045FD10)(ref this, i_rMsg);
    // int __thiscall UIElement::CompareZLevel(UIElement*,const UIRegion*)
    public int CompareZLevel(ACBindings.UIRegion* i_pRegion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIRegion*, int>)0x0045FD40)(ref this, i_pRegion);
    // void __thiscall UIElement::StartResizing(UIElement*,BorderLocation,int,int)
    public void StartResizing(ACBindings.BorderLocation border, int xInitialMouse, int yInitialMouse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.BorderLocation, int, int, void>)0x0045FD80)(ref this, border, xInitialMouse, yInitialMouse);
    // void __thiscall UIElement::StopResizing(UIElement*)
    public void StopResizing() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, void>)0x0045FE40)(ref this);
    // void __thiscall UIElement::StartMovement(UIElement*,int,int)
    public void StartMovement(int xInitialMouse, int yInitialMouse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int, int, void>)0x0045FE90)(ref this, xInitialMouse, yInitialMouse);
    // void __thiscall UIElement::StopMovement(UIElement*)
    public void StopMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, void>)0x0045FF00)(ref this);
    // void __thiscall UIElement::MouseMoveElement(UIElement*,int,int)
    public void MouseMoveElement(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int, int, void>)0x0045FF10)(ref this, xWindow, yWindow);
    // void __thiscall UIElement::SetCursor(_DWORD*,int,int,int)
    public void SetCursor(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int, int, int, void>)0x00460030)(ref this, a2, a3, a4);
    // void __thiscall UIElement::UnSetCursor(UIElement*)
    public void UnSetCursor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, void>)0x00460060)(ref this);
    // bool __thiscall UIElement::InqImageSize(UIElement*,int*,int*)
    public byte InqImageSize(int* width, int* height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int*, int*, byte>)0x00460090)(ref this, width, height);
    // void __thiscall UIElement::CenterAt(UIElement*,const int,const int)
    public void CenterAt(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int, int, void>)0x004600D0)(ref this, x, y);
    // void __thiscall UIElement::GetOriginalPosition(UIElement*,Box2D*,int*)
    public void GetOriginalPosition(ACBindings.Box2D* position, int* zlevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.Box2D*, int*, void>)0x00460110)(ref this, position, zlevel);
    // void __thiscall UIElement::GetCurrentPosition(UIElement*,Box2D*,int*)
    public void GetCurrentPosition(ACBindings.Box2D* position, int* zlevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.Box2D*, int*, void>)0x00460180)(ref this, position, zlevel);
    // bool __thiscall UIElement::GetShouldOwnObject(UIElement*)
    public byte GetShouldOwnObject() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte>)0x004601D0)(ref this);
    // void __thiscall UIElement::SetIsRootElement(UIElement*,bool)
    public void SetIsRootElement(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x004601E0)(ref this, b);
    // void __thiscall UIElement::AddToDeleteQueue(UIElement*)
    public void AddToDeleteQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, void>)0x00460250)(ref this);
    // void __cdecl UIElement::RegisterElementClass(unsigned int,UIElement*(__cdecl*createMethod)(const LayoutDesc*, const ElementDesc*))
    public static void RegisterElementClass(uint type, delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*> createMethod) => ((delegate* unmanaged[Cdecl]<uint, delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>, void>)0x00460270)(type, createMethod);
    // bool __thiscall UIElement::GetShouldBeMouseVisible(UIElement*)
    public byte GetShouldBeMouseVisible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte>)0x00460290)(ref this);
    // bool __thiscall UIElement::TakeFocus(UIElement*)
    public byte TakeFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte>)0x004602C0)(ref this);
    // bool __thiscall UIElement::GetHasFocus(UIElement*)
    public byte GetHasFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte>)0x00460310)(ref this);
    // UIElement* __thiscall UIElement::GetFocusDescendant(UIElement*)
    public ACBindings.UIElement* GetFocusDescendant() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElement*>)0x00460330)(ref this);
    // void __thiscall UIElement::UpdateMouseVisibility(UIElement*)
    public void UpdateMouseVisibility() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, void>)0x00460340)(ref this);
    // void __thiscall UIElement::SetClampGameViewEdge(UIElement*,unsigned int)
    public void SetClampGameViewEdge(uint i_eEdge) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, void>)0x00460370)(ref this, i_eEdge);
    // bool __thiscall UIElement::IsVisible(UIElement*)
    public byte IsVisible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte>)0x004603A0)(ref this);
    // bool __thiscall UIElement::BroadcastElementMessage(UIElement*,unsigned int,unsigned int,unsigned int)
    public byte BroadcastElementMessage(uint i_idMessage, uint i_dwParam1, uint i_dwParam2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, uint, uint, byte>)0x00460410)(ref this, i_idMessage, i_dwParam1, i_dwParam2);
    // bool __thiscall UIElement::SetAttribute_Enum(UIElement*,unsigned int,unsigned int)
    public byte SetAttribute_Enum(uint attribute, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, uint, byte>)0x00460470)(ref this, attribute, val);
    // bool __thiscall UIElement::SetAttribute_InstanceID(UIElement*,unsigned int,unsigned int)
    public byte SetAttribute_InstanceID(uint attribute, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, uint, byte>)0x00460530)(ref this, attribute, val);
    // bool __thiscall UIElement::SetAttribute_StringInfo(UIElement*,unsigned int,StringInfo)
    public byte SetAttribute_StringInfo(uint attribute, ACBindings.StringInfo val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, ACBindings.StringInfo, byte>)0x004605F0)(ref this, attribute, val);
    // bool __thiscall UIElement::SetAttribute_Int(UIElement*,unsigned int,int)
    public byte SetAttribute_Int(uint attribute, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, int, byte>)0x004606B0)(ref this, attribute, val);
    // bool __thiscall UIElement::SetAttribute_Float(UIElement*,unsigned int,float)
    public byte SetAttribute_Float(uint attribute, float val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, float, byte>)0x00460760)(ref this, attribute, val);
    // bool __thiscall UIElement::SetAttribute_Bool(UIElement*,unsigned int,bool)
    public byte SetAttribute_Bool(uint attribute, byte val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, byte, byte>)0x00460820)(ref this, attribute, val);
    // bool __thiscall UIElement::SetAttribute_DataID(void*,unsigned int,int)
    public byte SetAttribute_DataID(uint i_eName, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, int, byte>)0x004608D0)(ref this, i_eName, a3);
    // bool __thiscall UIElement::GetAttribute_Enum(UIElement*,unsigned int,unsigned int*)
    public byte GetAttribute_Enum(uint attribute, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, uint*, byte>)0x00460990)(ref this, attribute, val);
    // bool __thiscall UIElement::GetAttribute_InstanceID(UIElement*,unsigned int,unsigned int*)
    public byte GetAttribute_InstanceID(uint attribute, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, uint*, byte>)0x00460A60)(ref this, attribute, val);
    // bool __thiscall UIElement::GetAttribute_Int(UIElement*,unsigned int,int*)
    public byte GetAttribute_Int(uint attribute, int* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, int*, byte>)0x00460B30)(ref this, attribute, val);
    // bool __thiscall UIElement::GetAttribute_Float(UIElement*,unsigned int,float*)
    public byte GetAttribute_Float(uint attribute, float* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, float*, byte>)0x00460BF0)(ref this, attribute, val);
    // bool __thiscall UIElement::GetAttribute_Bool(UIElement*,unsigned int,bool*)
    public byte GetAttribute_Bool(uint attribute, byte* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, byte*, byte>)0x00460CC0)(ref this, attribute, val);
    // bool __thiscall UIElement::GetAttribute_DataID(int*,unsigned int,IDClass<_tagDataID,32,0>*)
    public byte GetAttribute_DataID(uint i_eName, ACBindings.IDClass___tagDataID* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, ACBindings.IDClass___tagDataID*, byte>)0x00460D80)(ref this, i_eName, a3);
    // UIElement* __thiscall UIElement::StartTooltipAtMouse(UIElement*,long double)
    public ACBindings.UIElement* StartTooltipAtMouse(double i_tTooltipDuration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, double, ACBindings.UIElement*>)0x00460E50)(ref this, i_tTooltipDuration);
    // void __thiscall UIElement::MouseDown(UIElement*,unsigned int,unsigned int,unsigned int)
    public void MouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, uint, uint, void>)0x00460FF0)(ref this, xWindow, yWindow, button);
    // void __thiscall UIElement::MouseTap(UIElement*,unsigned int,unsigned int,unsigned int)
    public void MouseTap(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, uint, uint, void>)0x004610C0)(ref this, xWindow, yWindow, button);
    // bool __thiscall UIElement::KeyUp(UIElement*,unsigned int)
    public byte KeyUp(uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, byte>)0x00461140)(ref this, button);
    // bool __thiscall UIElement::KeyDown(UIElement*,unsigned int,float)
    public byte KeyDown(uint button, float i_fExtent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, float, byte>)0x004611A0)(ref this, button, i_fExtent);
    // void __thiscall UIElement::MouseResizeElement(UIElement*,int,int)
    public void MouseResizeElement(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int, int, void>)0x00461210)(ref this, xWindow, yWindow);
    // void __thiscall UIElement::MouseOver(UIElement*,bool)
    public void MouseOver(byte over) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x00461680)(ref this, over);
    // void __thiscall UIElement::MouseOverTop(UIElement*,bool)
    public void MouseOverTop(byte overTop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x004616B0)(ref this, overTop);
    // bool __thiscall UIElement::DragItem(UIElement*,UIElement**)
    public byte DragItem(ACBindings.UIElement** elem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElement**, byte>)0x004616E0)(ref this, elem);
    // UIElement* __thiscall UIElement::GetDragAndDropCatcher(UIElement*,UIElement*)
    public ACBindings.UIElement* GetDragAndDropCatcher(ACBindings.UIElement* elem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElement*, ACBindings.UIElement*>)0x004617D0)(ref this, elem);
    // bool __thiscall UIElement::CatchDroppedItem(UIElement*,DragDropInfo*)
    public byte CatchDroppedItem(ACBindings.DragDropInfo* i_pcDDI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.DragDropInfo*, byte>)0x00461860)(ref this, i_pcDDI);
    // void __thiscall UIElement::DragAndDropComplete(UIElement*,DragDropInfo*)
    public void DragAndDropComplete(ACBindings.DragDropInfo* i_pcDDI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.DragDropInfo*, void>)0x00461880)(ref this, i_pcDDI);
    // void __thiscall UIElement::SetTooltip(UIElement*,const StringInfo*)
    public void SetTooltip(ACBindings.StringInfo* text) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.StringInfo*, void>)0x004618A0)(ref this, text);
    // bool __thiscall UIElement::MakeUIObject(UIElement*,UIObject**)
    public byte MakeUIObject(ACBindings.UIObject** o_pcUIObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIObject**, byte>)0x00461920)(ref this, o_pcUIObject);
    // bool __thiscall UIElement::SetUIObject(UIElement*,UIObject*)
    public byte SetUIObject(ACBindings.UIObject* i_pcUIObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIObject*, byte>)0x00461BA0)(ref this, i_pcUIObject);
    // void __thiscall UIElement::SetShouldOwnObject(UIElement*,bool)
    public void SetShouldOwnObject(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x00461CB0)(ref this, b);
    // bool __thiscall UIElement::Activate(UIElement*)
    public byte Activate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte>)0x00461D60)(ref this);
    // bool __thiscall UIElement::Deactivate(UIElement*)
    public byte Deactivate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte>)0x00461E30)(ref this);
    // bool __thiscall UIElement::RelinquishFocus(UIElement*)
    public byte RelinquishFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte>)0x00461EC0)(ref this);
    // void __thiscall UIElement::SetMouseVisible(UIElement*,bool)
    public void SetMouseVisible(byte i_bShouldBeMouseVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x00461F10)(ref this, i_bShouldBeMouseVisible);
    // void __thiscall UIElement::GetCurrentUIObjectMode(UIElement*,unsigned int*)
    public void GetCurrentUIObjectMode(uint* i_eMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint*, void>)0x00461FB0)(ref this, i_eMode);
    // Vector3* __thiscall UIElement::GetObjectScale(UIElement*,Vector3*)
    public ACBindings.Vector3* GetObjectScale(ACBindings.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.Vector3*, ACBindings.Vector3*>)0x00462040)(ref this, result);
    // bool __thiscall UIElement::UpdateObjectScale(UIElement*)
    public byte UpdateObjectScale() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte>)0x004620C0)(ref this);
    // Box2D* __thiscall UIElement::GetSurfaceBox(UIElement*,Box2D*)
    public ACBindings.Box2D* GetSurfaceBox(ACBindings.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.Box2D*, ACBindings.Box2D*>)0x00462220)(ref this, result);
    // bool __thiscall UIElement::UpdateSurfaceBox(UIElement*,const bool)
    public byte UpdateSurfaceBox(byte i_bPositionUpdate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, byte>)0x00462270)(ref this, i_bPositionUpdate);
    // void __thiscall UIElement::SetVisible(UIElement*,bool)
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x00462390)(ref this, visible);
    // UIElementMessageListenResult __thiscall UIElement::ListenToElementMessage(UIElement*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00462420)(ref this, i_rMsg);
    // bool __thiscall UIElement::InqAvailableProperties(UIElement*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.AvailablePropertySet*, byte>)0x004625B0)(ref this, set);
    // bool __thiscall UIElement::MouseHover(UIElement*,int,int)
    public byte MouseHover(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int, int, byte>)0x00462600)(ref this, xWindow, yWindow);
    // void __thiscall UIElement::ClearTooltip(UIElement*)
    public void ClearTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, void>)0x004626C0)(ref this);
    // bool __thiscall UIElement::UpdateForParentSizeChange(UIElement*)
    public byte UpdateForParentSizeChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte>)0x00462720)(ref this);
    // void __thiscall UIElement::SetParent(UIElement*,UIRegion*)
    public void SetParent(ACBindings.UIRegion* parent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIRegion*, void>)0x00462B30)(ref this, parent);
    // UIElementMessageListenResult __thiscall UIElement::ForwardElementMessage(UIElement*,const UIElementMessageInfo*,UIElementMessageListenResult)
    public ACBindings.UIElementMessageListenResult ForwardElementMessage(ACBindings.UIElementMessageInfo* i_rMsg, ACBindings.UIElementMessageListenResult i_eStatus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult, ACBindings.UIElementMessageListenResult>)0x00462C00)(ref this, i_rMsg, i_eStatus);
    // void __thiscall UIElement::Initialize(UIElement*)
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, void>)0x00462D70)(ref this);
    // void __thiscall UIElement::OnSetAttribute(UIElement*,const BaseProperty*)
    public void OnSetAttribute(ACBindings.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.BaseProperty*, void>)0x00462E60)(ref this, attribute);
    // void __thiscall UIElement::MouseMove(UIElement*,int,int)
    public void MouseMove(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int, int, void>)0x004633F0)(ref this, xWindow, yWindow);
    // void __thiscall UIElement::MoveTo(UIElement*,const int,const int)
    public void MoveTo(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int, int, void>)0x004634C0)(ref this, x, y);
    // UIElement* __thiscall UIElement::GetLastChildElement(UIElement*)
    public ACBindings.UIElement* GetLastChildElement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElement*>)0x00463690)(ref this);
    // void __thiscall UIElement::OnVisibilityChanged(UIElement*,bool)
    public void OnVisibilityChanged(byte i_bVisibleNow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x00463830)(ref this, i_bVisibleNow);
    // void __thiscall UIElement::PostInit(UIElement*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, void>)0x004639A0)(ref this);
    // bool __thiscall UIElement::InqProperty(UIElement*,const unsigned int,BaseProperty*)
    public byte InqProperty(uint name, ACBindings.BaseProperty* property) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, ACBindings.BaseProperty*, byte>)0x00463A00)(ref this, name, property);
    // void __thiscall UIElement::MouseUp(UIElement*,unsigned int,unsigned int,unsigned int)
    public void MouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, uint, uint, void>)0x00463A70)(ref this, xWindow, yWindow, button);
    // UIElement* __thiscall UIElement::GetChild(UIElement*,unsigned int)
    public ACBindings.UIElement* GetChild(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, ACBindings.UIElement*>)0x00463BA0)(ref this, ID);
    // UIElement* __thiscall UIElement::GetChildRecursive(UIElement*,unsigned int)
    public ACBindings.UIElement* GetChildRecursive(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, ACBindings.UIElement*>)0x00463C00)(ref this, ID);
    // void __thiscall UIElement::SetMediaImage(int,int,int)
    public void SetMediaImage(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int, int, void>)0x00463C80)(ref this, a2, a3);
    // void __thiscall UIElement::SetMediaImageForState(int,int,int,unsigned int)
    public void SetMediaImageForState(int a2, int a3, uint stateID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int, int, uint, void>)0x00463D10)(ref this, a2, a3, stateID);
    // void __thiscall UIElement::ResizeTo(UIElement*,const int,const int)
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int, int, void>)0x00463D60)(ref this, width, height);
    // void __thiscall UIElement::UpdateForScreenPositionChange(UIElement*)
    public void UpdateForScreenPositionChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, void>)0x00463FB0)(ref this);
    // void __thiscall UIElement::UpdateForParentVisibilityChange(UIElement*,bool)
    public void UpdateForParentVisibilityChange(byte i_bHeirarchyVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte, void>)0x00464090)(ref this, i_bHeirarchyVisible);
    // UIElement* __thiscall UIElement::GetFirstChildElement(UIElement*)
    public ACBindings.UIElement* GetFirstChildElement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElement*>)0x00464110)(ref this);
    // bool __thiscall UIElement::ContainsProperty(UIElement*,const unsigned int)
    public byte ContainsProperty(uint name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, byte>)0x00464430)(ref this, name);
    // UIElement* __thiscall UIElement::GetNextChildElement(UIElement*,UIElement*)
    public ACBindings.UIElement* GetNextChildElement(ACBindings.UIElement* i_pPrevChild) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElement*, ACBindings.UIElement*>)0x00464490)(ref this, i_pPrevChild);
    // UIElement* __thiscall UIElement::GetPrevChildElement(UIElement*,UIElement*)
    public ACBindings.UIElement* GetPrevChildElement(ACBindings.UIElement* i_pNextChild) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElement*, ACBindings.UIElement*>)0x004644F0)(ref this, i_pNextChild);
    // UIElement* __thiscall UIElement::FindRelative(UIElement*,unsigned int)
    public ACBindings.UIElement* FindRelative(uint relativeID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, ACBindings.UIElement*>)0x00464690)(ref this, relativeID);
    // void __thiscall UIElement::UIElement(UIElement*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x00464900)(ref this, layout, full_desc);
    // bool __thiscall UIElement::GetActivatable(UIElement*)
    public byte GetActivatable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte>)0x00464AA0)(ref this);
    // bool __thiscall UIElement::HasCursor(UIElement*)
    public byte HasCursor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, byte>)0x00464AB0)(ref this);
    // void __thiscall UIElement::RegisterForElementMessages(UIElement*,UIListener*)
    public void RegisterForElementMessages(ACBindings.UIListener* i_pListener) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIListener*, void>)0x00464AD0)(ref this, i_pListener);
    // void __thiscall UIElement::UnregisterForElementMessages(UIElement*,UIListener*)
    public void UnregisterForElementMessages(ACBindings.UIListener* i_pListener) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIListener*, void>)0x00464B00)(ref this, i_pListener);
    // bool __thiscall UIElement::SetProperty(UIElement*,const BaseProperty*)
    public byte SetProperty(ACBindings.BaseProperty* property) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.BaseProperty*, byte>)0x00464C90)(ref this, property);
    // void __thiscall UIElement::DeleteChildren(UIElement*)
    public void DeleteChildren() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, void>)0x00464CD0)(ref this);
    // void __thiscall UIElement::~UIElement(UIElement*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, void>)0x00464E00)(ref this);
    // bool __thiscall UIElement::SetState(UIElement*,unsigned int)
    public byte SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, uint, byte>)0x00464FA0)(ref this, state);
    // void __thiscall UIElement::MatchElement(UIElement*,const UIElement*)
    public void MatchElement(ACBindings.UIElement* elem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElement*, void>)0x00465330)(ref this, elem);
    // void __thiscall UIElement::BringChildToTop(UIElement*,UIElement*)
    public void BringChildToTop(ACBindings.UIElement* i_pChild) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, ACBindings.UIElement*, void>)0x00465610)(ref this, i_pChild);
    // int __stdcall UIElement::GetChildRecursiveTemplate<UIElement_Text>(unsigned int)
    public static int GetChildRecursiveTemplate__UIElement_Text(uint ID) => ((delegate* unmanaged[Stdcall]<uint, int>)0x00476820)(ID);
    // int __stdcall UIElement::GetChildRecursiveTemplate<UIElement_Scrollbar>(unsigned int)
    public static int GetChildRecursiveTemplate__UIElement_Scrollbar(uint ID) => ((delegate* unmanaged[Stdcall]<uint, int>)0x00482770)(ID);
    // int __thiscall UIElement::GetParent(ACCharGenResult*)
    public int GetParent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement, int>)0x005C8120)(ref this);
}

