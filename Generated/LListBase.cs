namespace ACBindings.Internal;


/// <summary>Maintains pointers to the first and last elements of a linked list, enabling efficient insertion and traversal operations. Serves as the foundational component for custom list structures in the application.</summary>
public unsafe struct LListBase
{
    // Members
    public ACBindings.Internal.LListData* head_;
    public ACBindings.Internal.LListData* tail_;

    // Methods

    /// <summary>Removes and returns the last element of a singly linked list, updating head and tail pointers as necessary.
    /// <code>Offset: 0x00556490
    /// LListData* __thiscall LListBase::RemoveTail(LListBase*)</code>
    /// </summary>
    /// <returns>The removed tail node, or null if the list is empty.</returns>
    public ACBindings.Internal.LListData* RemoveTail() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LListBase, ACBindings.Internal.LListData*>)0x00556490)(ref this);
}

