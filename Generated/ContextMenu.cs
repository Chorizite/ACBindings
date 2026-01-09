namespace ACBindings;

// ContextMenu
public unsafe struct ContextMenu
{
    // Base Classes
    public ACBindings.UIListener BaseClass_UIListener; // ACBindings.UIListener

    // Child Types
    // ContextMenu_vtbl
    public unsafe struct ContextMenu_vtbl
    {
        // Members
        public System.IntPtr ContextMenu_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer

        // Methods
    }

    // Members
    public ACBindings.InstanceID m_weenieTarget;
    public ACBindings.UIElement* m_pParentDisplay;
    public ACBindings.UIElement* m_pRoot;
    public ACBindings.SmartArray__ContextMenuData m_data;
    public ACBindings.StringInfo m_siInfoText;
    public byte m_bDrawInactive;
    public byte m_initted;
    public ACBindings.UIElement* m_display;
    public ACBindings.UIElement_ListBox* m_listbox;
    public ACBindings.UIElement* m_mouseChild;
    public ACBindings.ContextMenu* m_pOpenSubMenu;
    public double m_mouseTime;
    public float m_openDelay;
    public byte m_open;
    public byte m_bTopLevel;
    public byte m_bUpperLeftSet;
    public byte m_bLowerLeftSet;
    public int m_iX0;
    public int m_iY0;

    // Methods
    // bool __thiscall ContextMenu::Close(ContextMenu*)
    public byte Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ContextMenu, byte>)0x00474F30)(ref this);
    // void __thiscall ContextMenu::SetVisible(ContextMenu*,bool)
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ContextMenu, byte, void>)0x00474FF0)(ref this, visible);
}

