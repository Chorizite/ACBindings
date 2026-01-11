namespace ACBindings.Internal;

public unsafe struct ContextMenuData
{
    // Child Types
    public unsafe struct ContextMenuData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ContextMenuData*, void> ContextMenuData_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_entryType;
    public ACBindings.Internal.StringInfo m_siText;
    public ACBindings.Internal.IDClass____tagDataID m_didHandler;
    public uint m_ahtHint;
    public ACBindings.Internal.ContextMenu* m_subMenu;
    public byte m_bActive;
    public byte m_bBoolEntry;
    public byte m_bBoolEntryActive;
    public ACBindings.Internal.IDClass____tagDataID m_didIcon;

    // Methods
}

