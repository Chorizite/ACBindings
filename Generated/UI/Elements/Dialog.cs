namespace ACBindings;

// Dialog
public unsafe struct Dialog : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field

    // Child Types
    // Dialog_vtbl
    public unsafe struct Dialog_vtbl
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
        public System.IntPtr SetContext; // function pointer
        public System.IntPtr SetData; // function pointer
        public System.IntPtr CancelDialog; // function pointer
        public System.IntPtr UpdatePopupSizeAndPosition; // function pointer

        // Methods
    }

    // Members
    public uint m_nContext;
    public ACBindings.PropertyCollection m_cData;
    public double m_tNow;
    public double m_tExpiration;
    public ACBindings.UIElement* m_pcPendingDisplay;
    public ACBindings.UIElement_Text* m_pcPendingDisplayText;

    // Generated Constructor
    public Dialog(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall Dialog::SetContext(Dialog*,unsigned int)
    public void SetContext(uint i_nContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Dialog, uint, void>)0x00475020)(ref this, i_nContext);
    // void __thiscall Dialog::Dialog(Dialog*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Dialog, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x00476BF0)(ref this, layout, full_desc);
    // void __thiscall Dialog::~Dialog(Dialog*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Dialog, void>)0x00476C60)(ref this);
    // UIElementMessageListenResult __thiscall Dialog::ListenToElementMessage(Dialog*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Dialog, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00476C80)(ref this, i_rMsg);
    // void __thiscall Dialog::UpdatePendingDialogDisplay(Dialog*,unsigned int)
    public void UpdatePendingDialogDisplay(uint i_iNumPending) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Dialog, uint, void>)0x00476CF0)(ref this, i_iNumPending);
    // void __thiscall Dialog::UpdatePopupSizeAndPosition(Dialog*)
    public void UpdatePopupSizeAndPosition() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Dialog, void>)0x00476D70)(ref this);
    // void __thiscall Dialog::UpdateDialogText(Dialog*)
    public void UpdateDialogText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Dialog, void>)0x00476E10)(ref this);
    // void __thiscall Dialog::ListenToGlobalMessage(Dialog*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_eMessageID, int i_nData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Dialog, uint, int, void>)0x00476F50)(ref this, i_eMessageID, i_nData);
    // void __thiscall Dialog::SetData(Dialog*,const PropertyCollection*)
    public void SetData(ACBindings.PropertyCollection* i_cData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Dialog, ACBindings.PropertyCollection*, void>)0x00476FA0)(ref this, i_cData);
}

