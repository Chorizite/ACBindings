namespace ACBindings.Internal.AC1Legacy;


/// <summary>Represents a linked list of unsigned long values used by AC1Legacy components to store sequences of identifiers or indices. Maintains head and tail pointers for efficient insertion at both ends and tracks element count.</summary>
public unsafe struct List__uint
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}


/// <summary>
/// Manages a doubly linked list of FriendData objects, keeping track of head, tail, and element count to support insertion, removal, lookup, and cleanup operations.
/// </summary>
public unsafe struct List___FriendData
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods

    /// <summary>Cleans the list by destroying all FriendData elements and freeing their related sublists and reference-counted resources.
    /// <code>Offset: 0x0048CE50
    /// void __thiscall AC1Legacy::List&lt;FriendData&gt;::flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall AC1Legacy::List<FriendData>::flush(_DWORD*) (template type method)

    /// <summary>Insert a copy of the provided FriendData into the linked list after the node referenced by a2. If the list is initially empty, the new element becomes both head and tail.
    /// <code>Offset: 0x0048E080
    /// int __thiscall AC1Legacy::List&lt;FriendData&gt;::insert(_DWORD*,int,FriendData*)</code>
    /// </summary>
    /// <param name="a2">Address of the node that will precede the inserted element; ignored when inserting into an empty list.</param>
    /// <param name="rhs">FriendData object to be copied into the new list entry.</param>
    /// <returns>1 if the insertion succeeded, 0 if memory allocation failed.</returns>
    // int __thiscall AC1Legacy::List<FriendData>::insert(_DWORD*,int,FriendData*) (template type method)

    /// <summary>Removes a FriendData instance from the list, destroys the object and deallocates its memory.
    /// <code>Offset: 0x0048E110
    /// int __thiscall AC1Legacy::List&lt;FriendData&gt;::remove(_DWORD*,FriendData*)</code>
    /// </summary>
    /// <param name="a2">FriendData pointer to remove.</param>
    /// <returns>Non‑zero when removal succeeds; zero if the provided pointer or the list is empty.</returns>
    // int __thiscall AC1Legacy::List<FriendData>::remove(_DWORD*,FriendData*) (template type method)

    /// <summary>Finds a friend matching the specified data, copies its contents into the supplied FriendData instance, removes it from the list, and returns whether removal succeeded.
    /// <code>Offset: 0x0048E180
    /// int __thiscall AC1Legacy::List&lt;FriendData&gt;::remove_1(_DWORD*,FriendData*)</code>
    /// </summary>
    /// <param name="this">Pointer to the List of FriendData objects.</param>
    /// <param name="rhs">FriendData instance used for comparison; receives the removed element's data before deletion.</param>
    /// <returns>Zero if no matching friend is found or removal fails; non‑zero otherwise.</returns>
    // int __thiscall AC1Legacy::List<FriendData>::remove_1(_DWORD*,FriendData*) (template type method)
}


/// <summary>Maintains an ordered collection of SpellSetTierList objects, supporting insertion at the back, removal from the front, and complete clearing while tracking element count.</summary>
public unsafe struct List___SpellSetTierList
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods

    /// <summary>Removes the first entry from the spell set tier list and stores it in the supplied pointer.
    /// <code>Offset: 0x00598B70
    /// int __thiscall AC1Legacy::List&lt;SpellSetTierList&gt;::pop_front(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Receives the element removed from the front of the list.</param>
    /// <returns>Non-zero if an element was popped; zero if the list was empty.</returns>
    // int __thiscall AC1Legacy::List<SpellSetTierList>::pop_front(_DWORD*,_DWORD*) (template type method)

    /// <summary>Clears the SpellSetTierList collection, removing every element and freeing associated memory.
    /// <code>Offset: 0x00598BF0
    /// void __thiscall AC1Legacy::List&lt;SpellSetTierList&gt;::flush(_DWORD*)</code>
    /// </summary>
    /// <param name="this">The list instance to flush.</param>
    // void __thiscall AC1Legacy::List<SpellSetTierList>::flush(_DWORD*) (template type method)

    /// <summary>Adds a copy of the specified SpellSetTierList object to the end of the list, allocating storage and updating internal links.
    /// <code>Offset: 0x00598E40
    /// int __thiscall AC1Legacy::List&lt;SpellSetTierList&gt;::push_back(_DWORD*,SpellSetTierList*)</code>
    /// </summary>
    /// <param name="from">The SpellSetTierList instance to be appended.</param>
    /// <returns>Nonzero if the push succeeded; zero if memory allocation failed.</returns>
    // int __thiscall AC1Legacy::List<SpellSetTierList>::push_back(_DWORD*,SpellSetTierList*) (template type method)
}


/// <summary>Represents an ordered container of PStringBase&lt;char&gt; elements, providing head/tail pointers and element count for efficient storage and traversal.</summary>
public unsafe struct List___AC1Legacy_PStringBase__sbyte
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

