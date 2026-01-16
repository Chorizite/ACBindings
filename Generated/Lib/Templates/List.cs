namespace ACBindings.Internal;


/// <summary>Maintains an ordered collection of PStringBase&lt;char&gt; objects, supporting efficient addition and traversal through head and tail pointers.</summary>
public unsafe struct List___PStringBase__sbyte
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods

    /// <summary>Removes the first node from a linked list of string objects and returns its value through the supplied pointer.
    /// <code>Offset: 0x00405120
    /// char __thiscall List&lt;PStringBase&lt;char&gt;&gt;::pop_front(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Address that receives the popped element’s data pointer; reference counts are adjusted for any previous value stored at *a2 and for the new one.</param>
    /// <returns>Non‑zero when an element was removed; zero if the list is empty.</returns>
    // char __thiscall List<PStringBase<char>>::pop_front(_DWORD*,int*) (template type method)

    /// <summary>Empties the list by removing all elements and releasing any associated resources such as reference‑counted buffers until no items remain.
    /// <code>Offset: 0x00405210
    /// int __thiscall List&lt;PStringBase&lt;char&gt;&gt;::flush(_DWORD*)</code>
    /// </summary>
    /// <returns>Zero upon successful completion; this value does not indicate the number of flushed items.</returns>
    // int __thiscall List<PStringBase<char>>::flush(_DWORD*) (template type method)

    /// <summary>Adds a new string to the tail of the list, allocating a node and updating links.
    /// <code>Offset: 0x0040B720
    /// char __thiscall List&lt;PStringBase&lt;char&gt;&gt;::push_back(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the string to append.</param>
    /// <returns>Non‑zero if the element was added; zero on failure.</returns>
    // char __thiscall List<PStringBase<char>>::push_back(_DWORD*,int*) (template type method)

    /// <summary>Serializes a list of PStringBase&lt;char&gt; into an Archive, or rebuilds it from serialized data depending on the archive’s flags.
    /// <code>Offset: 0x00682BD0
    /// void __thiscall List&lt;PStringBase&lt;char&gt;&gt;::Serialize(_DWORD*,Archive*)</code>
    /// </summary>
    /// <param name="m_charbuffer">The Archive used for serialization or deserialization.</param>
    // void __thiscall List<PStringBase<char>>::Serialize(_DWORD*,Archive*) (template type method)
}


/// <summary>Maintains an ordered collection of constant Node pointers within the StringTableMetaLanguage system, enabling efficient traversal and manipulation of string table entries.</summary>
public unsafe struct List___StringTableMetaLanguage_Node_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}


/// <summary>Maintains an ordered collection of file node pointers, enabling efficient insertion, removal, and traversal while tracking head, tail, and element count.</summary>
public unsafe struct List___PFileNode_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}


/// <summary>Represents a dynamically resizable list of unsigned long values, maintaining head and tail pointers for efficient traversal and storing the element count.</summary>
public unsafe struct List__uint
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}


/// <summary>Maintains an ordered collection of input mapping entries, tracking head and tail pointers and the number of elements in the list.</summary>
public unsafe struct List___CInputManager_InputMapEntry
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods

    /// <summary>Appends a copy of an input mapping entry to the end of the list, allocating storage for the new node.
    /// <code>Offset: 0x00431250
    /// char __thiscall List&lt;CInputManager::InputMapEntry&gt;::push_back(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the InputMapEntry whose data is copied into the newly added node.</param>
    /// <returns>Non‑zero on success; zero if memory allocation fails.</returns>
    // char __thiscall List<CInputManager::InputMapEntry>::push_back(_DWORD*,_DWORD*) (template type method)

    /// <summary>Inserts a new input map entry into the list after the specified node, copying data from the provided entry and updating links.
    /// <code>Offset: 0x004312C0
    /// char __thiscall List&lt;CInputManager::InputMapEntry&gt;::insert(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Address of the node after which the new entry will be inserted; ignored when inserting into an empty list.</param>
    /// <param name="a3">Pointer to an InputMapEntry containing the data to copy into the new node.</param>
    /// <returns>1 if insertion succeeds, 0 if memory allocation fails.</returns>
    // char __thiscall List<CInputManager::InputMapEntry>::insert(_DWORD*,int,_DWORD*) (template type method)

    /// <summary>Removes a specified InputMapEntry node from this list, updating head or tail links as necessary and freeing the node’s memory.
    /// <code>Offset: 0x00431480
    /// char __thiscall List&lt;CInputManager::InputMapEntry&gt;::remove(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="entry">Pointer to the node to remove; must belong to this list.</param>
    /// <returns>Non‑zero if the entry was successfully removed; zero if the entry is null or not present in the list.</returns>
    // char __thiscall List<CInputManager::InputMapEntry>::remove(_DWORD*,_DWORD*) (template type method)

    /// <summary>Inserts a new InputMapEntry into the list while preserving descending order based on the entry's key field.
    /// <code>Offset: 0x004316B0
    /// char __thiscall List&lt;CInputManager::InputMapEntry&gt;::insert_sort(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the InputMapEntry to be inserted.</param>
    /// <returns>Non‑zero if insertion succeeded; zero otherwise.</returns>
    // char __thiscall List<CInputManager::InputMapEntry>::insert_sort(_DWORD*,_DWORD*) (template type method)

    /// <summary>Searches the list for an input map entry whose three fields match those of the provided entry.
    /// <code>Offset: 0x004316F0
    /// bool __thiscall List&lt;CInputManager::InputMapEntry&gt;::contains(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the InputMapEntry to locate within the list.</param>
    /// <returns>True if a matching entry is found; otherwise, false.</returns>
    // bool __thiscall List<CInputManager::InputMapEntry>::contains(_DWORD*,_DWORD*) (template type method)

    /// <summary>Removes all entries from the list, freeing each node and resetting head, tail, and element count.
    /// <code>Offset: 0x00431730
    /// void __thiscall List&lt;CInputManager::InputMapEntry&gt;::flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall List<CInputManager::InputMapEntry>::flush(_DWORD*) (template type method)
}


/// <summary>Stores a sequence of Glyph objects, maintaining head and tail references and element count.</summary>
public unsafe struct List___Glyph
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods

    /// <summary>Adds a copy of the specified Glyph to the end of the list.
    /// <code>Offset: 0x00472D20
    /// char __thiscall List&lt;Glyph&gt;::push_back(_DWORD*,Glyph*)</code>
    /// </summary>
    /// <param name="rhs">The Glyph to append.</param>
    /// <returns>1 if the glyph was successfully added; otherwise, 0 if memory allocation failed.</returns>
    // char __thiscall List<Glyph>::push_back(_DWORD*,Glyph*) (template type method)

    /// <summary>Inserts a copy of the specified Glyph after the given node within the list, updating linkage pointers and element count.
    /// <code>Offset: 0x00472D90
    /// char __thiscall List&lt;Glyph&gt;::insert(_DWORD*,int,Glyph*)</code>
    /// </summary>
    /// <param name="a2">Address of the existing node that will precede the newly inserted glyph; if this is null, the new glyph becomes both head and tail of an empty list.</param>
    /// <param name="rhs">Glyph to duplicate into the new list element.</param>
    /// <returns>Non‑zero on success; zero if memory allocation fails.</returns>
    // char __thiscall List<Glyph>::insert(_DWORD*,int,Glyph*) (template type method)

    /// <summary>Removes the specified Glyph from the list, adjusting head and tail pointers and decreasing element count.
    /// <code>Offset: 0x00473020
    /// char __thiscall List&lt;Glyph&gt;::remove(_DWORD*,Glyph*)</code>
    /// </summary>
    /// <param name="a2">The Glyph instance to be removed.</param>
    /// <returns>1 if removal succeeded; 0 if the glyph is null or not found in the list.</returns>
    // char __thiscall List<Glyph>::remove(_DWORD*,Glyph*) (template type method)

    /// <summary>Destroys every Glyph element contained in the list, freeing its allocated memory and resetting all list pointers to represent an empty collection.
    /// <code>Offset: 0x00473370
    /// void __thiscall List&lt;Glyph&gt;::flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall List<Glyph>::flush(_DWORD*) (template type method)
}


/// <summary>Collects DialogInfo objects for the dialog system, facilitating ordered access and manipulation.</summary>
/// <remarks>Internally uses head and tail pointers to track list boundaries and a count of elements.</remarks>
public unsafe struct List___DialogInfo
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods

    /// <summary>Removes the first DialogInfo entry from the list and copies its contents into the supplied buffer. If the list is empty, no action occurs.
    /// <code>Offset: 0x004771D0
    /// char __thiscall List&lt;DialogInfo&gt;::pop_front(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="this">Pointer to the List instance whose front element will be popped.</param>
    /// <param name="a2">Buffer that receives the removed DialogInfo data.</param>
    /// <returns>1 if an element was successfully removed; 0 if the list was already empty.</returns>
    // char __thiscall List<DialogInfo>::pop_front(_DWORD*,_DWORD*) (template type method)

    /// <summary>Removes the given PropertyCollection from this List, updating links and decreasing element count before destroying the object.
    /// <code>Offset: 0x00477240
    /// char __thiscall List&lt;DialogInfo&gt;::remove(_DWORD*,PropertyCollection*)</code>
    /// </summary>
    /// <param name="a2">PropertyCollection instance to remove from the list.</param>
    /// <returns>Non‑zero if removal succeeded; zero if the collection was null or the list was empty.</returns>
    // char __thiscall List<DialogInfo>::remove(_DWORD*,PropertyCollection*) (template type method)

    /// <summary>Cleanses the dialog information list by iteratively removing each entry, deallocating associated resources, and resetting head, tail, and element count to represent an empty list.
    /// <code>Offset: 0x004772D0
    /// void __thiscall List&lt;DialogInfo&gt;::flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall List<DialogInfo>::flush(_DWORD*) (template type method)

    /// <summary>Inserts a DialogInfo element into the list immediately after the specified node.
    /// <code>Offset: 0x00477B80
    /// char __thiscall List&lt;DialogInfo&gt;::insert(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the node following which the new DialogInfo will be inserted.</param>
    /// <param name="a3">Pointer to the DialogInfo data to be stored in the newly created node.</param>
    /// <returns>1 if insertion succeeded; 0 if memory allocation failed.</returns>
    // char __thiscall List<DialogInfo>::insert(_DWORD*,int,_DWORD*) (template type method)

    /// <summary>Adds a DialogInfo item to the end of the list.
    /// <code>Offset: 0x00477C70
    /// char __thiscall List&lt;DialogInfo&gt;::push_back(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the DialogInfo data to append.</param>
    /// <returns>Non‑zero (typically 1) if the element was added successfully; zero if memory allocation failed.</returns>
    // char __thiscall List<DialogInfo>::push_back(_DWORD*,_DWORD*) (template type method)
}


/// <summary>Stores an ordered collection of QualifiedControl instances, supporting appending new controls, locating a control by value, and retrieving elements by index.</summary>
public unsafe struct List___QualifiedControl
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods

    /// <summary>Appends a QualifiedControl instance to the end of the list, allocating a new node and updating head, tail, and element count.
    /// <code>Offset: 0x004874F0
    /// char __thiscall List&lt;QualifiedControl&gt;::push_back(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the QualifiedControl to be added.</param>
    /// <returns>Non‑zero if the operation succeeded; zero if memory allocation failed.</returns>
    // char __thiscall List<QualifiedControl>::push_back(_DWORD*,_DWORD*) (template type method)

    /// <summary>Finds a QualifiedControl in the list that matches the supplied rhs using equality comparison, returning a pointer to the matching element or null if none is found.
    /// <code>Offset: 0x00487570
    /// QualifiedControl* __thiscall List&lt;QualifiedControl&gt;::find(_DWORD*,QualifiedControl*)</code>
    /// </summary>
    /// <param name="this">The List instance on which the search operates.</param>
    /// <param name="rhs">The QualifiedControl to locate within the list.</param>
    /// <returns>A pointer to the matching QualifiedControl, or nullptr if no match exists.</returns>
    // QualifiedControl* __thiscall List<QualifiedControl>::find(_DWORD*,QualifiedControl*) (template type method)

    /// <summary>Retrieves a pointer to the element at the specified zero‑based position in the list. If the position is outside the bounds of the list, null is returned.
    /// <code>Offset: 0x004878A0
    /// int __thiscall List&lt;QualifiedControl&gt;::get_data(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Zero‑based index of the desired element.</param>
    /// <returns>The address of the element node, or 0 when the index is invalid or the list is empty.</returns>
    // int __thiscall List<QualifiedControl>::get_data(_DWORD*,unsigned int) (template type method)
}


/// <summary>Maintains an ordered collection of PStringBase&lt;unsigned short&gt; objects, enabling efficient traversal from head to tail while keeping track of the total element count.</summary>
public unsafe struct List___PStringBase__ushort
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}


/// <summary>Container managing a collection of PerfMonCounterInfo pointers, maintaining references to the first and last elements while tracking total count.</summary>
public unsafe struct List___PerfMonCounterInfo_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

public unsafe struct List___AsyncCache_CAsyncRequest_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

public unsafe struct List___WinInetAsyncHttpClient_HttpDownloadEvent_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

public unsafe struct List___WinInetAsyncHttpClient_HttpDownloadRequest_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

public unsafe struct List___NoticeHandler_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

public unsafe struct List___PerfMonCounterInfo_PerfMonCounterNameHelp
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods

    /// <summary>Removes the first element from the list, copies its contents into the supplied buffer, updates internal pointers and reference counts, and frees the removed node. Returns 1 on success; 0 if the list was empty.
    /// <code>Offset: 0x00542170
    /// char __thiscall List&lt;PerfMonCounterInfo::PerfMonCounterNameHelp&gt;::pop_front(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Reference to an object that will receive a copy of the popped element.</param>
    /// <returns>Non‑zero if an element was successfully removed; otherwise zero.</returns>
    // char __thiscall List<PerfMonCounterInfo::PerfMonCounterNameHelp>::pop_front(_DWORD*,_DWORD*) (template type method)

    /// <summary>Removes the first element from the list, updating reference counts on a shared null buffer, and returns a status flag.
    /// <code>Offset: 0x00542200
    /// char __thiscall List&lt;PerfMonCounterInfo::PerfMonCounterNameHelp&gt;::pop_head(_DWORD*)</code>
    /// </summary>
    /// <returns>A character value indicating whether an element was successfully removed (non‑zero) or not (zero).</returns>
    // char __thiscall List<PerfMonCounterInfo::PerfMonCounterNameHelp>::pop_head(_DWORD*) (template type method)

    /// <summary>Inserts a new PerfMonCounterNameHelp element into the list after the specified node; creates head and tail if the list was empty.
    /// <code>Offset: 0x00683C60
    /// char __thiscall List&lt;PerfMonCounterInfo::PerfMonCounterNameHelp&gt;::insert(_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the node after which the new element should be inserted; ignored when inserting into an empty list.</param>
    /// <param name="a3">Pointer to the PerfMonCounterNameHelp data to store in the new node.</param>
    /// <returns>Nonzero on success, zero if memory allocation fails or node construction fails.</returns>
    // char __thiscall List<PerfMonCounterInfo::PerfMonCounterNameHelp>::insert(_DWORD*,int,int) (template type method)

    /// <summary>Inserts a PerfMonCounterNameHelp entry into the list in ascending order according to its key. Returns success status.
    /// <code>Offset: 0x00683CE0
    /// char __thiscall List&lt;PerfMonCounterInfo::PerfMonCounterNameHelp&gt;::insert_sort(_DWORD*,_WORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the counter information to insert.</param>
    /// <returns>1 if the entry was inserted successfully; 0 on failure (e.g., memory allocation error).</returns>
    // char __thiscall List<PerfMonCounterInfo::PerfMonCounterNameHelp>::insert_sort(_DWORD*,_WORD*) (template type method)
}

public unsafe struct List___ODBCRequest_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

public unsafe struct List___SkillRecord_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

public unsafe struct List___ObjectRangeInfo
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods

    /// <summary>Inserts a new ObjectRangeInfo element immediately after the specified node, or as the sole entry when the list is empty.
    /// <code>Offset: 0x0055F470
    /// char __thiscall List&lt;ObjectRangeInfo&gt;::insert(_DWORD*,int,const void*)</code>
    /// </summary>
    /// <param name="a2">Address of an existing node after which the new element will be inserted; ignored if the list currently contains no elements.</param>
    /// <param name="a3">Pointer to a 0x40‑byte block holding the data for the new element, which is copied into the freshly allocated node.</param>
    /// <returns>Non‑zero on success, zero if memory allocation fails.</returns>
    // char __thiscall List<ObjectRangeInfo>::insert(_DWORD*,int,const void*) (template type method)

    /// <summary>Removes the specified element from this doubly‑linked list, updates head and tail links, frees the node, and decrements the element count.
    /// <code>Offset: 0x0055F9F0
    /// char __thiscall List&lt;ObjectRangeInfo&gt;::remove(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the element to remove; must not be null and should belong to this list.</param>
    /// <returns>Non‑zero if removal succeeded; zero if a2 is null or the list contains no elements.</returns>
    // char __thiscall List<ObjectRangeInfo>::remove(_DWORD*,_DWORD*) (template type method)

    /// <summary>Releases all ObjectRangeInfo elements from the list, freeing memory and updating internal links and element count to reflect an empty collection.
    /// <code>Offset: 0x0055FFE0
    /// void __thiscall List&lt;ObjectRangeInfo&gt;::flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall List<ObjectRangeInfo>::flush(_DWORD*) (template type method)
}

public unsafe struct List___UIElementMessageInfo
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods

    /// <summary>Removes the first element from the list and copies its contents into the supplied buffer.
    /// <code>Offset: 0x00459EC0
    /// char __thiscall List&lt;UIElementMessageInfo&gt;::pop_front(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a UIElementMessageInfo structure that receives the removed node's data.</param>
    /// <returns>Non‑zero if an element was popped; zero if the list is empty.</returns>
    // char __thiscall List<UIElementMessageInfo>::pop_front(_DWORD*,_DWORD*) (template type method)

    /// <summary>Removes the specified node from the doubly‑linked list, adjusting head and tail pointers and freeing its memory.
    /// <code>Offset: 0x0045A3B0
    /// char __thiscall List&lt;UIElementMessageInfo&gt;::remove(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="this">The List instance containing the nodes.</param>
    /// <param name="a2">Pointer to the UIElementMessageInfo node to remove.</param>
    /// <returns>Non‑zero if removal succeeds; zero if the list is empty or the supplied pointer is null.</returns>
    // char __thiscall List<UIElementMessageInfo>::remove(_DWORD*,_DWORD*) (template type method)

    /// <summary>Adds a new UIElementMessageInfo node to the list by allocating memory and copying data from the provided source.
    /// <code>Offset: 0x0045A9B0
    /// char __thiscall List&lt;UIElementMessageInfo&gt;::push_back(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="this">Reference to the list instance where the element will be appended.</param>
    /// <param name="a2">Pointer to the UIElementMessageInfo data to copy into the new node.</param>
    /// <returns>Non-zero if the operation succeeds; zero on allocation failure.</returns>
    // char __thiscall List<UIElementMessageInfo>::push_back(_DWORD*,_DWORD*) (template type method)

    /// <summary>Destroys the list, removing all UIElementMessageInfo entries and resetting its internal pointers.
    /// <code>Offset: 0x0045B110
    /// void** __thiscall List&lt;UIElementMessageInfo&gt;::~List&lt;UIElementMessageInfo&gt;(void***)</code>
    /// </summary>
    /// <param name="this">Reference to the List instance that is being destroyed.</param>
    /// <returns>A null pointer after the list has been cleared.</returns>
    // void** __thiscall List<UIElementMessageInfo>::~List<UIElementMessageInfo>(void***) (template type method)
}

public unsafe struct List__ushort
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

public unsafe struct List___CInputHandler_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

public unsafe struct List___UIElement_UIItem_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

public unsafe struct List___DualHashData___UIOption_Slider_ptr___UIOption_Slider_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

