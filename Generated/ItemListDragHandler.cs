namespace ACBindings;

// ItemListDragHandler
public unsafe struct ItemListDragHandler
{
    // Child Types
    // ItemListDragHandler_vtbl
    public unsafe struct ItemListDragHandler_vtbl
    {
        // Members
        public System.IntPtr OnItemListDragOver; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
    // bool __thiscall ItemListDragHandler::OnItemListDragOver(ItemListDragHandler*,UIElement_UIItem*,unsigned int,unsigned int,DropItemFlags)
    public byte OnItemListDragOver(ACBindings.UIElement_UIItem* catchElement, uint dropItemID, uint dropSpellID, ACBindings.DropItemFlags dropFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemListDragHandler, ACBindings.UIElement_UIItem*, uint, uint, ACBindings.DropItemFlags, byte>)0x004A38F0)(ref this, catchElement, dropItemID, dropSpellID, dropFlags);
}

