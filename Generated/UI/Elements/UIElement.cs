namespace ACBindings.Internal;

public unsafe struct UIElement : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIRegion BaseClass_UIRegion; // ACBindings.Internal.UIRegion

    // Child Types
    public unsafe struct UIElement_vtbl
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
    // UIElement::FunctionSignatureChanged
    public enum FunctionSignatureChanged : uint
    {
    }
    // UIElement::Intialized_Has_Been_Replaced_With_PostInit
    public enum Intialized_Has_Been_Replaced_With_PostInit : uint
    {
    }

    // Members
    public ACBindings.Internal.UIElement* m_itemDragged;
    public ACBindings.Internal.UIElement* m_pFocusElement;
    public ACBindings.Internal.MediaMachine m_mediaMachine;
    public ACBindings.Internal.LayoutDesc* m_layout;
    public ACBindings.Internal.ElementDesc m_desc;
    public uint m_state;
    public ACBindings.Internal.StateDesc* m_curStateDesc;
    public ACBindings.Internal.PropertyCollection m_instanceProperties;
    public ACBindings.Internal.BorderLocation m_currentBorder;
    public int m_DragStartX;
    public int m_DragStartY;
    public int m_DragStartHeight;
    public int m_DragStartWidth;
    public int m_mouseInitialX;
    public int m_mouseInitialY;
    public delegate* unmanaged[Cdecl]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte> m_dragDropCallback; // function pointer
    public ACBindings.Internal.UILocationData m_defaultLocation;
    public ACBindings.Internal.StringInfo m_TTText;
    public byte m_bShouldBeMouseVisible;
    public byte m_bIsMouseVisible;
    public int m_cursorHotX;
    public int m_cursorHotY;
    public ACBindings.Internal.IDClass____tagDataID m_cursorDID;
    public ACBindings.Internal._7DD0ED236307E660189677EE91B10663 ___u24;
    public uint m_eClampGameView;
    public ACBindings.Internal.Box2D m_surfaceBox;
    public ACBindings.Internal.HashSet___UIListener_ptr m_hashListeners;
    public ACBindings.Internal.HashSetIterator___UIListener_ptr m_iterListeners;
    public uint m_idInputMap;

    // Generated Constructor
    public UIElement(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004592D0
    /// void __thiscall UIElement::SetActivatable(UIElement*,bool)</code>
    /// </summary>
    public void SetActivatable(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x004592D0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x004592F0
    /// void __thiscall UIElement::SetObjectIsTemporary(UIElement*,bool)</code>
    /// </summary>
    public void SetObjectIsTemporary(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x004592F0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0045F9D0
    /// void __thiscall UIElement::SetDragable(UIElement*,bool)</code>
    /// </summary>
    public void SetDragable(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045F9D0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0045F9F0
    /// void __thiscall UIElement::SetActivateOnShow(UIElement*,bool)</code>
    /// </summary>
    public void SetActivateOnShow(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045F9F0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0045FA10
    /// void __thiscall UIElement::SetSaveLocation(UIElement*,bool)</code>
    /// </summary>
    public void SetSaveLocation(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045FA10)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0045FA30
    /// void __thiscall UIElement::SetSaveSize(UIElement*,bool)</code>
    /// </summary>
    public void SetSaveSize(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045FA30)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0045FA50
    /// void __thiscall UIElement::SetNotifyOnResize(UIElement*,bool)</code>
    /// </summary>
    public void SetNotifyOnResize(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045FA50)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0045FA70
    /// void __thiscall UIElement::SetNotifyOnMove(UIElement*,bool)</code>
    /// </summary>
    public void SetNotifyOnMove(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045FA70)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0045FA90
    /// void __thiscall UIElement::SetContextMenu(UIElement*,bool)</code>
    /// </summary>
    public void SetContextMenu(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045FA90)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0045FAB0
    /// void __thiscall UIElement::SetNotifyOnCreate(UIElement*,bool)</code>
    /// </summary>
    public void SetNotifyOnCreate(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045FAB0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0045FB30
    /// UIElement* __thiscall UIElement::GetRootElement(UIElement*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetRootElement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*>)0x0045FB30)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045FB80
    /// UIElement* __thiscall UIElement::GetAncestorByID(UIElement*,const unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetAncestorByID(uint i_ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.UIElement*>)0x0045FB80)(ref this, i_ID);

    /// <summary>
    /// <code>Offset: 0x0045FBB0
    /// bool __thiscall UIElement::IsAncestorOfMe(UIElement*,const UIElement*)</code>
    /// </summary>
    public byte IsAncestorOfMe(ACBindings.Internal.UIElement* i_pAncestor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, byte>)0x0045FBB0)(ref this, i_pAncestor);

    /// <summary>
    /// <code>Offset: 0x0045FBE0
    /// bool __thiscall UIElement::RegisterInputMaps(UIElement*,int)</code>
    /// </summary>
    public byte RegisterInputMaps(int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, byte>)0x0045FBE0)(ref this, i_nPriority);

    /// <summary>
    /// <code>Offset: 0x0045FC50
    /// bool __thiscall UIElement::UnregisterInputMaps(UIElement*)</code>
    /// </summary>
    public byte UnregisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x0045FC50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045FCA0
    /// bool __thiscall UIElement::OnAction(UIElement*,const InputEvent*)</code>
    /// </summary>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.InputEvent*, byte>)0x0045FCA0)(ref this, i_evt);

    /// <summary>
    /// <code>Offset: 0x0045FCE0
    /// bool __thiscall UIElement::OnChildAction(UIElement*,const UIElement*,const InputEvent*)</code>
    /// </summary>
    public byte OnChildAction(ACBindings.Internal.UIElement* i_pChild, ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte>)0x0045FCE0)(ref this, i_pChild, i_evt);

    /// <summary>
    /// <code>Offset: 0x0045FD10
    /// bool __thiscall UIElement::DefElementMessageHandler(UIElement*,const UIElementMessageInfo*)</code>
    /// </summary>
    public byte DefElementMessageHandler(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElementMessageInfo*, byte>)0x0045FD10)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x0045FD40
    /// int __thiscall UIElement::CompareZLevel(UIElement*,const UIRegion*)</code>
    /// </summary>
    public int CompareZLevel(ACBindings.Internal.UIRegion* i_pRegion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIRegion*, int>)0x0045FD40)(ref this, i_pRegion);

    /// <summary>
    /// <code>Offset: 0x0045FD80
    /// void __thiscall UIElement::StartResizing(UIElement*,BorderLocation,int,int)</code>
    /// </summary>
    public void StartResizing(ACBindings.Internal.BorderLocation border, int xInitialMouse, int yInitialMouse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.BorderLocation, int, int, void>)0x0045FD80)(ref this, border, xInitialMouse, yInitialMouse);

    /// <summary>
    /// <code>Offset: 0x0045FE40
    /// void __thiscall UIElement::StopResizing(UIElement*)</code>
    /// </summary>
    public void StopResizing() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x0045FE40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045FE90
    /// void __thiscall UIElement::StartMovement(UIElement*,int,int)</code>
    /// </summary>
    public void StartMovement(int xInitialMouse, int yInitialMouse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x0045FE90)(ref this, xInitialMouse, yInitialMouse);

    /// <summary>
    /// <code>Offset: 0x0045FF00
    /// void __thiscall UIElement::StopMovement(UIElement*)</code>
    /// </summary>
    public void StopMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x0045FF00)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045FF10
    /// void __thiscall UIElement::MouseMoveElement(UIElement*,int,int)</code>
    /// </summary>
    public void MouseMoveElement(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x0045FF10)(ref this, xWindow, yWindow);

    /// <summary>
    /// <code>Offset: 0x00460030
    /// void __thiscall UIElement::SetCursor(_DWORD*,int,int,int)</code>
    /// </summary>
    public void SetCursor(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, int, void>)0x00460030)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00460060
    /// void __thiscall UIElement::UnSetCursor(UIElement*)</code>
    /// </summary>
    public void UnSetCursor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00460060)(ref this);

    /// <summary>
    /// <code>Offset: 0x00460090
    /// bool __thiscall UIElement::InqImageSize(UIElement*,int*,int*)</code>
    /// </summary>
    public byte InqImageSize(int* width, int* height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int*, int*, byte>)0x00460090)(ref this, width, height);

    /// <summary>
    /// <code>Offset: 0x004600D0
    /// void __thiscall UIElement::CenterAt(UIElement*,const int,const int)</code>
    /// </summary>
    public void CenterAt(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x004600D0)(ref this, x, y);

    /// <summary>
    /// <code>Offset: 0x00460110
    /// void __thiscall UIElement::GetOriginalPosition(UIElement*,Box2D*,int*)</code>
    /// </summary>
    public void GetOriginalPosition(ACBindings.Internal.Box2D* position, int* zlevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.Box2D*, int*, void>)0x00460110)(ref this, position, zlevel);

    /// <summary>
    /// <code>Offset: 0x00460180
    /// void __thiscall UIElement::GetCurrentPosition(UIElement*,Box2D*,int*)</code>
    /// </summary>
    public void GetCurrentPosition(ACBindings.Internal.Box2D* position, int* zlevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.Box2D*, int*, void>)0x00460180)(ref this, position, zlevel);

    /// <summary>
    /// <code>Offset: 0x004601D0
    /// bool __thiscall UIElement::GetShouldOwnObject(UIElement*)</code>
    /// </summary>
    public byte GetShouldOwnObject() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x004601D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004601E0
    /// void __thiscall UIElement::SetIsRootElement(UIElement*,bool)</code>
    /// </summary>
    public void SetIsRootElement(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x004601E0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00460250
    /// void __thiscall UIElement::AddToDeleteQueue(UIElement*)</code>
    /// </summary>
    public void AddToDeleteQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00460250)(ref this);

    /// <summary>
    /// <code>Offset: 0x00460270
    /// void __cdecl UIElement::RegisterElementClass(unsigned int,UIElement*(__cdecl*createMethod)(const LayoutDesc*, const ElementDesc*))</code>
    /// </summary>
    public static void RegisterElementClass(uint type, delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*> createMethod) => ((delegate* unmanaged[Cdecl]<uint, delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>, void>)0x00460270)(type, createMethod);

    /// <summary>
    /// <code>Offset: 0x00460290
    /// bool __thiscall UIElement::GetShouldBeMouseVisible(UIElement*)</code>
    /// </summary>
    public byte GetShouldBeMouseVisible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00460290)(ref this);

    /// <summary>
    /// <code>Offset: 0x004602C0
    /// bool __thiscall UIElement::TakeFocus(UIElement*)</code>
    /// </summary>
    public byte TakeFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x004602C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00460310
    /// bool __thiscall UIElement::GetHasFocus(UIElement*)</code>
    /// </summary>
    public byte GetHasFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00460310)(ref this);

    /// <summary>
    /// <code>Offset: 0x00460330
    /// UIElement* __thiscall UIElement::GetFocusDescendant(UIElement*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetFocusDescendant() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*>)0x00460330)(ref this);

    /// <summary>
    /// <code>Offset: 0x00460340
    /// void __thiscall UIElement::UpdateMouseVisibility(UIElement*)</code>
    /// </summary>
    public void UpdateMouseVisibility() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00460340)(ref this);

    /// <summary>
    /// <code>Offset: 0x00460370
    /// void __thiscall UIElement::SetClampGameViewEdge(UIElement*,unsigned int)</code>
    /// </summary>
    public void SetClampGameViewEdge(uint i_eEdge) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, void>)0x00460370)(ref this, i_eEdge);

    /// <summary>
    /// <code>Offset: 0x004603A0
    /// bool __thiscall UIElement::IsVisible(UIElement*)</code>
    /// </summary>
    public byte IsVisible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x004603A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00460410
    /// bool __thiscall UIElement::BroadcastElementMessage(UIElement*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public byte BroadcastElementMessage(uint i_idMessage, uint i_dwParam1, uint i_dwParam2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint, uint, byte>)0x00460410)(ref this, i_idMessage, i_dwParam1, i_dwParam2);

    /// <summary>
    /// <code>Offset: 0x00460470
    /// bool __thiscall UIElement::SetAttribute_Enum(UIElement*,unsigned int,unsigned int)</code>
    /// </summary>
    public byte SetAttribute_Enum(uint attribute, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint, byte>)0x00460470)(ref this, attribute, val);

    /// <summary>
    /// <code>Offset: 0x00460530
    /// bool __thiscall UIElement::SetAttribute_InstanceID(UIElement*,unsigned int,unsigned int)</code>
    /// </summary>
    public byte SetAttribute_InstanceID(uint attribute, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint, byte>)0x00460530)(ref this, attribute, val);

    /// <summary>
    /// <code>Offset: 0x004605F0
    /// bool __thiscall UIElement::SetAttribute_StringInfo(UIElement*,unsigned int,StringInfo)</code>
    /// </summary>
    public byte SetAttribute_StringInfo(uint attribute, ACBindings.Internal.StringInfo val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.StringInfo, byte>)0x004605F0)(ref this, attribute, val);

    /// <summary>
    /// <code>Offset: 0x004606B0
    /// bool __thiscall UIElement::SetAttribute_Int(UIElement*,unsigned int,int)</code>
    /// </summary>
    public byte SetAttribute_Int(uint attribute, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, int, byte>)0x004606B0)(ref this, attribute, val);

    /// <summary>
    /// <code>Offset: 0x00460760
    /// bool __thiscall UIElement::SetAttribute_Float(UIElement*,unsigned int,float)</code>
    /// </summary>
    public byte SetAttribute_Float(uint attribute, float val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, float, byte>)0x00460760)(ref this, attribute, val);

    /// <summary>
    /// <code>Offset: 0x00460820
    /// bool __thiscall UIElement::SetAttribute_Bool(UIElement*,unsigned int,bool)</code>
    /// </summary>
    public byte SetAttribute_Bool(uint attribute, byte val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, byte, byte>)0x00460820)(ref this, attribute, val);

    /// <summary>
    /// <code>Offset: 0x004608D0
    /// bool __thiscall UIElement::SetAttribute_DataID(void*,unsigned int,int)</code>
    /// </summary>
    public byte SetAttribute_DataID(uint i_eName, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, int, byte>)0x004608D0)(ref this, i_eName, a3);

    /// <summary>
    /// <code>Offset: 0x00460990
    /// bool __thiscall UIElement::GetAttribute_Enum(UIElement*,unsigned int,unsigned int*)</code>
    /// </summary>
    public byte GetAttribute_Enum(uint attribute, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint*, byte>)0x00460990)(ref this, attribute, val);

    /// <summary>
    /// <code>Offset: 0x00460A60
    /// bool __thiscall UIElement::GetAttribute_InstanceID(UIElement*,unsigned int,unsigned int*)</code>
    /// </summary>
    public byte GetAttribute_InstanceID(uint attribute, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint*, byte>)0x00460A60)(ref this, attribute, val);

    /// <summary>
    /// <code>Offset: 0x00460B30
    /// bool __thiscall UIElement::GetAttribute_Int(UIElement*,unsigned int,int*)</code>
    /// </summary>
    public byte GetAttribute_Int(uint attribute, int* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, int*, byte>)0x00460B30)(ref this, attribute, val);

    /// <summary>
    /// <code>Offset: 0x00460BF0
    /// bool __thiscall UIElement::GetAttribute_Float(UIElement*,unsigned int,float*)</code>
    /// </summary>
    public byte GetAttribute_Float(uint attribute, float* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, float*, byte>)0x00460BF0)(ref this, attribute, val);

    /// <summary>
    /// <code>Offset: 0x00460CC0
    /// bool __thiscall UIElement::GetAttribute_Bool(UIElement*,unsigned int,bool*)</code>
    /// </summary>
    public byte GetAttribute_Bool(uint attribute, byte* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, byte*, byte>)0x00460CC0)(ref this, attribute, val);

    /// <summary>
    /// <code>Offset: 0x00460D80
    /// bool __thiscall UIElement::GetAttribute_DataID(int*,unsigned int,IDClass&lt;_tagDataID,32,0&gt;*)</code>
    /// </summary>
    public byte GetAttribute_DataID(uint i_eName, ACBindings.Internal.IDClass____tagDataID* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.IDClass____tagDataID*, byte>)0x00460D80)(ref this, i_eName, a3);

    /// <summary>
    /// <code>Offset: 0x00460E50
    /// UIElement* __thiscall UIElement::StartTooltipAtMouse(UIElement*,long double)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* StartTooltipAtMouse(double i_tTooltipDuration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, double, ACBindings.Internal.UIElement*>)0x00460E50)(ref this, i_tTooltipDuration);

    /// <summary>
    /// <code>Offset: 0x00460FF0
    /// void __thiscall UIElement::MouseDown(UIElement*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void MouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint, uint, void>)0x00460FF0)(ref this, xWindow, yWindow, button);

    /// <summary>
    /// <code>Offset: 0x004610C0
    /// void __thiscall UIElement::MouseTap(UIElement*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void MouseTap(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint, uint, void>)0x004610C0)(ref this, xWindow, yWindow, button);

    /// <summary>
    /// <code>Offset: 0x00461140
    /// bool __thiscall UIElement::KeyUp(UIElement*,unsigned int)</code>
    /// </summary>
    public byte KeyUp(uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, byte>)0x00461140)(ref this, button);

    /// <summary>
    /// <code>Offset: 0x004611A0
    /// bool __thiscall UIElement::KeyDown(UIElement*,unsigned int,float)</code>
    /// </summary>
    public byte KeyDown(uint button, float i_fExtent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, float, byte>)0x004611A0)(ref this, button, i_fExtent);

    /// <summary>
    /// <code>Offset: 0x00461210
    /// void __thiscall UIElement::MouseResizeElement(UIElement*,int,int)</code>
    /// </summary>
    public void MouseResizeElement(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x00461210)(ref this, xWindow, yWindow);

    /// <summary>
    /// <code>Offset: 0x00461680
    /// void __thiscall UIElement::MouseOver(UIElement*,bool)</code>
    /// </summary>
    public void MouseOver(byte over) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x00461680)(ref this, over);

    /// <summary>
    /// <code>Offset: 0x004616B0
    /// void __thiscall UIElement::MouseOverTop(UIElement*,bool)</code>
    /// </summary>
    public void MouseOverTop(byte overTop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x004616B0)(ref this, overTop);

    /// <summary>
    /// <code>Offset: 0x004616E0
    /// bool __thiscall UIElement::DragItem(UIElement*,UIElement**)</code>
    /// </summary>
    public byte DragItem(ACBindings.Internal.UIElement** elem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement**, byte>)0x004616E0)(ref this, elem);

    /// <summary>
    /// <code>Offset: 0x004617D0
    /// UIElement* __thiscall UIElement::GetDragAndDropCatcher(UIElement*,UIElement*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetDragAndDropCatcher(ACBindings.Internal.UIElement* elem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x004617D0)(ref this, elem);

    /// <summary>
    /// <code>Offset: 0x00461860
    /// bool __thiscall UIElement::CatchDroppedItem(UIElement*,DragDropInfo*)</code>
    /// </summary>
    public byte CatchDroppedItem(ACBindings.Internal.DragDropInfo* i_pcDDI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.DragDropInfo*, byte>)0x00461860)(ref this, i_pcDDI);

    /// <summary>
    /// <code>Offset: 0x00461880
    /// void __thiscall UIElement::DragAndDropComplete(UIElement*,DragDropInfo*)</code>
    /// </summary>
    public void DragAndDropComplete(ACBindings.Internal.DragDropInfo* i_pcDDI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.DragDropInfo*, void>)0x00461880)(ref this, i_pcDDI);

    /// <summary>
    /// <code>Offset: 0x004618A0
    /// void __thiscall UIElement::SetTooltip(UIElement*,const StringInfo*)</code>
    /// </summary>
    public void SetTooltip(ACBindings.Internal.StringInfo* text) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.StringInfo*, void>)0x004618A0)(ref this, text);

    /// <summary>
    /// <code>Offset: 0x00461920
    /// bool __thiscall UIElement::MakeUIObject(UIElement*,UIObject**)</code>
    /// </summary>
    public byte MakeUIObject(ACBindings.Internal.UIObject** o_pcUIObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIObject**, byte>)0x00461920)(ref this, o_pcUIObject);

    /// <summary>
    /// <code>Offset: 0x00461BA0
    /// bool __thiscall UIElement::SetUIObject(UIElement*,UIObject*)</code>
    /// </summary>
    public byte SetUIObject(ACBindings.Internal.UIObject* i_pcUIObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIObject*, byte>)0x00461BA0)(ref this, i_pcUIObject);

    /// <summary>
    /// <code>Offset: 0x00461CB0
    /// void __thiscall UIElement::SetShouldOwnObject(UIElement*,bool)</code>
    /// </summary>
    public void SetShouldOwnObject(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x00461CB0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00461D60
    /// bool __thiscall UIElement::Activate(UIElement*)</code>
    /// </summary>
    public byte Activate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00461D60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00461E30
    /// bool __thiscall UIElement::Deactivate(UIElement*)</code>
    /// </summary>
    public byte Deactivate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00461E30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00461EC0
    /// bool __thiscall UIElement::RelinquishFocus(UIElement*)</code>
    /// </summary>
    public byte RelinquishFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00461EC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00461F10
    /// void __thiscall UIElement::SetMouseVisible(UIElement*,bool)</code>
    /// </summary>
    public void SetMouseVisible(byte i_bShouldBeMouseVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x00461F10)(ref this, i_bShouldBeMouseVisible);

    /// <summary>
    /// <code>Offset: 0x00461FB0
    /// void __thiscall UIElement::GetCurrentUIObjectMode(UIElement*,unsigned int*)</code>
    /// </summary>
    public void GetCurrentUIObjectMode(uint* i_eMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint*, void>)0x00461FB0)(ref this, i_eMode);

    /// <summary>
    /// <code>Offset: 0x00462040
    /// Vector3* __thiscall UIElement::GetObjectScale(UIElement*,Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.Vector3* GetObjectScale(ACBindings.Internal.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*>)0x00462040)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x004620C0
    /// bool __thiscall UIElement::UpdateObjectScale(UIElement*)</code>
    /// </summary>
    public byte UpdateObjectScale() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x004620C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00462220
    /// Box2D* __thiscall UIElement::GetSurfaceBox(UIElement*,Box2D*)</code>
    /// </summary>
    public ACBindings.Internal.Box2D* GetSurfaceBox(ACBindings.Internal.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*>)0x00462220)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x00462270
    /// bool __thiscall UIElement::UpdateSurfaceBox(UIElement*,const bool)</code>
    /// </summary>
    public byte UpdateSurfaceBox(byte i_bPositionUpdate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, byte>)0x00462270)(ref this, i_bPositionUpdate);

    /// <summary>
    /// <code>Offset: 0x00462390
    /// void __thiscall UIElement::SetVisible(UIElement*,bool)</code>
    /// </summary>
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x00462390)(ref this, visible);

    /// <summary>
    /// <code>Offset: 0x00462420
    /// UIElementMessageListenResult __thiscall UIElement::ListenToElementMessage(UIElement*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00462420)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004625B0
    /// bool __thiscall UIElement::InqAvailableProperties(UIElement*,AvailablePropertySet*)</code>
    /// </summary>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.AvailablePropertySet*, byte>)0x004625B0)(ref this, set);

    /// <summary>
    /// <code>Offset: 0x00462600
    /// bool __thiscall UIElement::MouseHover(UIElement*,int,int)</code>
    /// </summary>
    public byte MouseHover(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, byte>)0x00462600)(ref this, xWindow, yWindow);

    /// <summary>
    /// <code>Offset: 0x004626C0
    /// void __thiscall UIElement::ClearTooltip(UIElement*)</code>
    /// </summary>
    public void ClearTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x004626C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00462720
    /// bool __thiscall UIElement::UpdateForParentSizeChange(UIElement*)</code>
    /// </summary>
    public byte UpdateForParentSizeChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00462720)(ref this);

    /// <summary>
    /// <code>Offset: 0x00462B30
    /// void __thiscall UIElement::SetParent(UIElement*,UIRegion*)</code>
    /// </summary>
    public void SetParent(ACBindings.Internal.UIRegion* parent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIRegion*, void>)0x00462B30)(ref this, parent);

    /// <summary>
    /// <code>Offset: 0x00462C00
    /// UIElementMessageListenResult __thiscall UIElement::ForwardElementMessage(UIElement*,const UIElementMessageInfo*,UIElementMessageListenResult)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ForwardElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg, ACBindings.Internal.UIElementMessageListenResult i_eStatus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult>)0x00462C00)(ref this, i_rMsg, i_eStatus);

    /// <summary>
    /// <code>Offset: 0x00462D70
    /// void __thiscall UIElement::Initialize(UIElement*)</code>
    /// </summary>
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00462D70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00462E60
    /// void __thiscall UIElement::OnSetAttribute(UIElement*,const BaseProperty*)</code>
    /// </summary>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.BaseProperty*, void>)0x00462E60)(ref this, attribute);

    /// <summary>
    /// <code>Offset: 0x004633F0
    /// void __thiscall UIElement::MouseMove(UIElement*,int,int)</code>
    /// </summary>
    public void MouseMove(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x004633F0)(ref this, xWindow, yWindow);

    /// <summary>
    /// <code>Offset: 0x004634C0
    /// void __thiscall UIElement::MoveTo(UIElement*,const int,const int)</code>
    /// </summary>
    public void MoveTo(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x004634C0)(ref this, x, y);

    /// <summary>
    /// <code>Offset: 0x00463690
    /// UIElement* __thiscall UIElement::GetLastChildElement(UIElement*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetLastChildElement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*>)0x00463690)(ref this);

    /// <summary>
    /// <code>Offset: 0x00463830
    /// void __thiscall UIElement::OnVisibilityChanged(UIElement*,bool)</code>
    /// </summary>
    public void OnVisibilityChanged(byte i_bVisibleNow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x00463830)(ref this, i_bVisibleNow);

    /// <summary>
    /// <code>Offset: 0x004639A0
    /// void __thiscall UIElement::PostInit(UIElement*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x004639A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00463A00
    /// bool __thiscall UIElement::InqProperty(UIElement*,const unsigned int,BaseProperty*)</code>
    /// </summary>
    public byte InqProperty(uint name, ACBindings.Internal.BaseProperty* property) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.BaseProperty*, byte>)0x00463A00)(ref this, name, property);

    /// <summary>
    /// <code>Offset: 0x00463A70
    /// void __thiscall UIElement::MouseUp(UIElement*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void MouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint, uint, void>)0x00463A70)(ref this, xWindow, yWindow, button);

    /// <summary>
    /// <code>Offset: 0x00463BA0
    /// UIElement* __thiscall UIElement::GetChild(UIElement*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetChild(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.UIElement*>)0x00463BA0)(ref this, ID);

    /// <summary>
    /// <code>Offset: 0x00463C00
    /// UIElement* __thiscall UIElement::GetChildRecursive(UIElement*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetChildRecursive(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.UIElement*>)0x00463C00)(ref this, ID);

    /// <summary>
    /// <code>Offset: 0x00463C80
    /// void __thiscall UIElement::SetMediaImage(int,int,int)</code>
    /// </summary>
    public void SetMediaImage(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x00463C80)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00463D10
    /// void __thiscall UIElement::SetMediaImageForState(int,int,int,unsigned int)</code>
    /// </summary>
    public void SetMediaImageForState(int a2, int a3, uint stateID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, uint, void>)0x00463D10)(ref this, a2, a3, stateID);

    /// <summary>
    /// <code>Offset: 0x00463D60
    /// void __thiscall UIElement::ResizeTo(UIElement*,const int,const int)</code>
    /// </summary>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x00463D60)(ref this, width, height);

    /// <summary>
    /// <code>Offset: 0x00463FB0
    /// void __thiscall UIElement::UpdateForScreenPositionChange(UIElement*)</code>
    /// </summary>
    public void UpdateForScreenPositionChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00463FB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00464090
    /// void __thiscall UIElement::UpdateForParentVisibilityChange(UIElement*,bool)</code>
    /// </summary>
    public void UpdateForParentVisibilityChange(byte i_bHeirarchyVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x00464090)(ref this, i_bHeirarchyVisible);

    /// <summary>
    /// <code>Offset: 0x00464110
    /// UIElement* __thiscall UIElement::GetFirstChildElement(UIElement*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetFirstChildElement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*>)0x00464110)(ref this);

    /// <summary>
    /// <code>Offset: 0x00464430
    /// bool __thiscall UIElement::ContainsProperty(UIElement*,const unsigned int)</code>
    /// </summary>
    public byte ContainsProperty(uint name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, byte>)0x00464430)(ref this, name);

    /// <summary>
    /// <code>Offset: 0x00464490
    /// UIElement* __thiscall UIElement::GetNextChildElement(UIElement*,UIElement*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetNextChildElement(ACBindings.Internal.UIElement* i_pPrevChild) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x00464490)(ref this, i_pPrevChild);

    /// <summary>
    /// <code>Offset: 0x004644F0
    /// UIElement* __thiscall UIElement::GetPrevChildElement(UIElement*,UIElement*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetPrevChildElement(ACBindings.Internal.UIElement* i_pNextChild) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x004644F0)(ref this, i_pNextChild);

    /// <summary>
    /// <code>Offset: 0x00464690
    /// UIElement* __thiscall UIElement::FindRelative(UIElement*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* FindRelative(uint relativeID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.UIElement*>)0x00464690)(ref this, relativeID);

    /// <summary>
    /// <code>Offset: 0x00464900
    /// void __thiscall UIElement::UIElement(UIElement*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00464900)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x00464AA0
    /// bool __thiscall UIElement::GetActivatable(UIElement*)</code>
    /// </summary>
    public byte GetActivatable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00464AA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00464AB0
    /// bool __thiscall UIElement::HasCursor(UIElement*)</code>
    /// </summary>
    public byte HasCursor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00464AB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00464AD0
    /// void __thiscall UIElement::RegisterForElementMessages(UIElement*,UIListener*)</code>
    /// </summary>
    public void RegisterForElementMessages(ACBindings.Internal.UIListener* i_pListener) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIListener*, void>)0x00464AD0)(ref this, i_pListener);

    /// <summary>
    /// <code>Offset: 0x00464B00
    /// void __thiscall UIElement::UnregisterForElementMessages(UIElement*,UIListener*)</code>
    /// </summary>
    public void UnregisterForElementMessages(ACBindings.Internal.UIListener* i_pListener) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIListener*, void>)0x00464B00)(ref this, i_pListener);

    /// <summary>
    /// <code>Offset: 0x00464C90
    /// bool __thiscall UIElement::SetProperty(UIElement*,const BaseProperty*)</code>
    /// </summary>
    public byte SetProperty(ACBindings.Internal.BaseProperty* property) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.BaseProperty*, byte>)0x00464C90)(ref this, property);

    /// <summary>
    /// <code>Offset: 0x00464CD0
    /// void __thiscall UIElement::DeleteChildren(UIElement*)</code>
    /// </summary>
    public void DeleteChildren() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00464CD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00464E00
    /// void __thiscall UIElement::~UIElement(UIElement*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00464E00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00464FA0
    /// bool __thiscall UIElement::SetState(UIElement*,unsigned int)</code>
    /// </summary>
    public byte SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, byte>)0x00464FA0)(ref this, state);

    /// <summary>
    /// <code>Offset: 0x00465330
    /// void __thiscall UIElement::MatchElement(UIElement*,const UIElement*)</code>
    /// </summary>
    public void MatchElement(ACBindings.Internal.UIElement* elem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, void>)0x00465330)(ref this, elem);

    /// <summary>
    /// <code>Offset: 0x00465610
    /// void __thiscall UIElement::BringChildToTop(UIElement*,UIElement*)</code>
    /// </summary>
    public void BringChildToTop(ACBindings.Internal.UIElement* i_pChild) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, void>)0x00465610)(ref this, i_pChild);

    /// <summary>
    /// <code>Offset: 0x00476820
    /// int __stdcall UIElement::GetChildRecursiveTemplate&lt;UIElement_Text&gt;(unsigned int)</code>
    /// </summary>
    public static int GetChildRecursiveTemplate__UIElement_Text(uint ID) => ((delegate* unmanaged[Stdcall]<uint, int>)0x00476820)(ID);

    /// <summary>
    /// <code>Offset: 0x00482770
    /// int __stdcall UIElement::GetChildRecursiveTemplate&lt;UIElement_Scrollbar&gt;(unsigned int)</code>
    /// </summary>
    public static int GetChildRecursiveTemplate__UIElement_Scrollbar(uint ID) => ((delegate* unmanaged[Stdcall]<uint, int>)0x00482770)(ID);

    /// <summary>
    /// <code>Offset: 0x005C8120
    /// int __thiscall UIElement::GetParent(ACCharGenResult*)</code>
    /// </summary>
    public int GetParent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int>)0x005C8120)(ref this);
}

