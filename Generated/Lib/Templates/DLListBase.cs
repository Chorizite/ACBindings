namespace ACBindings.Internal;


/// <summary>Maintains references to the first and last elements of a doubly linked list, enabling efficient insertion and removal operations from both ends.</summary>
public unsafe struct DLListBase
{
    // Members
    public ACBindings.Internal.DLListData* head_;
    public ACBindings.Internal.DLListData* tail_;

    // Methods

    /// <summary>Adds a node into the list immediately following the specified element; if the reference is null, inserts at the front.
    /// <code>Offset: 0x00410820
    /// void __thiscall DLListBase::InsertAfter(DLListBase*,DLListData*,DLListData*)</code>
    /// </summary>
    /// <param name="to_add">The new node to insert.</param>
    /// <param name="where">Node after which to insert; if null, insertion occurs at the head of the list.</param>
    public void InsertAfter(ACBindings.Internal.DLListData* to_add, ACBindings.Internal.DLListData* where) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DLListBase, ACBindings.Internal.DLListData*, ACBindings.Internal.DLListData*, void>)0x00410820)(ref this, to_add, where);

    /// <summary>Detaches the specified node from the list, adjusting neighboring links and updating the list’s head or tail as necessary.
    /// <code>Offset: 0x00410880
    /// void __thiscall DLListBase::Remove(DLListBase*,DLListData*)</code>
    /// </summary>
    /// <param name="to_remove">Node to be removed from the list.</param>
    public void Remove(ACBindings.Internal.DLListData* to_remove) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DLListBase, ACBindings.Internal.DLListData*, void>)0x00410880)(ref this, to_remove);
}

