namespace ACBindings.Internal;


/// <summary>Manages a hierarchical context menu system in the UI, controlling visibility, submenu relationships, and interaction events.</summary>
/// <remarks>Holds references to parent displays, root element, listbox, mouse child, timing data, and flags for drawing and initialization status.</remarks>
public unsafe struct ContextMenu
{
    // Base Classes
    public ACBindings.Internal.UIListener BaseClass_UIListener; // ACBindings.Internal.UIListener

    // Child Types
    public unsafe struct ContextMenu_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ContextMenu*, void> ContextMenu_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ContextMenu*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ContextMenu*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ContextMenu*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ContextMenu*, uint, int, void> ListenToGlobalMessage; // function pointer

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

    /// <summary>Closes this context menu, recursively closing any open submenus and destroying associated UI elements before marking it as closed.
    /// <code>Offset: 0x00474F30
    /// bool __thiscall ContextMenu::Close(ContextMenu*)</code>
    /// </summary>
    /// <returns>True if the menu was already closed or had no open submenus; false if a submenu was closed during the operation or when the menu has no display element to destroy.</returns>
    public byte Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContextMenu, byte>)0x00474F30)(ref this);

    /// <summary>Shows or hides the context menu, automatically closing it when hiding while currently open.
    /// <code>Offset: 0x00474FF0
    /// void __thiscall ContextMenu::SetVisible(ContextMenu*,bool)</code>
    /// </summary>
    /// <param name="visible">True to display the menu; false to hide it.</param>
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContextMenu, byte, void>)0x00474FF0)(ref this, visible);
}

