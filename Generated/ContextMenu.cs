namespace ACBindings.Internal;

public unsafe struct ContextMenu
{
    // Base Classes
    public ACBindings.Internal.UIListener BaseClass_UIListener; // ACBindings.Internal.UIListener

    // Child Types
    public unsafe struct ContextMenu_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ContextMenu*, void> ContextMenu_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ContextMenu*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ContextMenu*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ContextMenu*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ContextMenu*, uint, int, void> ListenToGlobalMessage; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.InstanceID m_weenieTarget;
    public ACBindings.Internal.UIElement* m_pParentDisplay;
    public ACBindings.Internal.UIElement* m_pRoot;
    public ACBindings.Internal.SmartArray___ContextMenuData m_data;
    public ACBindings.Internal.StringInfo m_siInfoText;
    public byte m_bDrawInactive;
    public byte m_initted;
    public ACBindings.Internal.UIElement* m_display;
    public ACBindings.Internal.UIElement_ListBox* m_listbox;
    public ACBindings.Internal.UIElement* m_mouseChild;
    public ACBindings.Internal.ContextMenu* m_pOpenSubMenu;
    public double m_mouseTime;
    public float m_openDelay;
    public byte m_open;
    public byte m_bTopLevel;
    public byte m_bUpperLeftSet;
    public byte m_bLowerLeftSet;
    public int m_iX0;
    public int m_iY0;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00474F30
    /// bool __thiscall ContextMenu::Close(ContextMenu*)</code>
    /// </summary>
    public byte Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContextMenu, byte>)0x00474F30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00474FF0
    /// void __thiscall ContextMenu::SetVisible(ContextMenu*,bool)</code>
    /// </summary>
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContextMenu, byte, void>)0x00474FF0)(ref this, visible);
}

