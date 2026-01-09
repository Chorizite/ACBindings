namespace ACBindings;

// ContextMenuData
public unsafe struct ContextMenuData
{
    // Child Types
    // ContextMenuData_vtbl
    public unsafe struct ContextMenuData_vtbl
    {
        // Members
        public System.IntPtr ContextMenuData_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_entryType;
    public ACBindings.StringInfo m_siText;
    public ACBindings.IDClass___tagDataID m_didHandler;
    public uint m_ahtHint;
    public ACBindings.ContextMenu* m_subMenu;
    public byte m_bActive;
    public byte m_bBoolEntry;
    public byte m_bBoolEntryActive;
    public ACBindings.IDClass___tagDataID m_didIcon;

    // Methods
}

