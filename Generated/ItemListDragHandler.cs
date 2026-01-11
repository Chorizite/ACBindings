namespace ACBindings.Internal;

public unsafe struct ItemListDragHandler
{
    // Child Types
    public unsafe struct ItemListDragHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemListDragHandler*, ACBindings.Internal.UIElement_UIItem*, uint, uint, ACBindings.Internal.DropItemFlags, byte> OnItemListDragOver; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods

    /// <summary>
    /// <code>Offset: 0x004A38F0
    /// bool __thiscall ItemListDragHandler::OnItemListDragOver(ItemListDragHandler*,UIElement_UIItem*,unsigned int,unsigned int,DropItemFlags)</code>
    /// </summary>
    public byte OnItemListDragOver(ACBindings.Internal.UIElement_UIItem* catchElement, uint dropItemID, uint dropSpellID, ACBindings.Internal.DropItemFlags dropFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemListDragHandler, ACBindings.Internal.UIElement_UIItem*, uint, uint, ACBindings.Internal.DropItemFlags, byte>)0x004A38F0)(ref this, catchElement, dropItemID, dropSpellID, dropFlags);
}

