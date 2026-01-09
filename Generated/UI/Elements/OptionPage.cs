namespace ACBindings;

// OptionPage
public unsafe struct OptionPage : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement BaseClass_UIElement; // ACBindings.UIElement
    public ACBindings.IOptionChangeHandler BaseClass_IOptionChangeHandler; // ACBindings.IOptionChangeHandler

    // Child Types
    // OptionPage_vtbl
    public unsafe struct OptionPage_vtbl
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
        public System.IntPtr SaveCurrentValues; // function pointer
        public System.IntPtr RestoreDefaultValues; // function pointer
        public System.IntPtr RestoreSavedValues; // function pointer
        public System.IntPtr InitOptions; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SmartArray__UIOption_ptr m_UIOptionArray;

    // Generated Constructor
    public OptionPage(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall OptionPage::SaveCurrentValues(OptionPage*)
    public byte SaveCurrentValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.OptionPage, byte>)0x004F38C0)(ref this);
    // bool __thiscall OptionPage::RestoreDefaultValues(OptionPage*)
    public byte RestoreDefaultValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.OptionPage, byte>)0x004F3910)(ref this);
    // bool __thiscall OptionPage::RestoreSavedValues(OptionPage*)
    public byte RestoreSavedValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.OptionPage, byte>)0x004F3960)(ref this);
    // bool __thiscall OptionPage::Changed(OptionPage*)
    public byte Changed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.OptionPage, byte>)0x004F39C0)(ref this);
    // void __thiscall OptionPage::OptionPage(OptionPage*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.OptionPage, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004F3A00)(ref this, layout, full_desc);
    // void __thiscall OptionPage::~OptionPage(OptionPage*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.OptionPage, void>)0x004F3A50)(ref this);
    // void __thiscall OptionPage::RegisterOption(OptionPage*,UIOption*)
    public void RegisterOption(ACBindings.UIOption* option) => ((delegate* unmanaged[Thiscall]<ref ACBindings.OptionPage, ACBindings.UIOption*, void>)0x004F3AF0)(ref this, option);
}

