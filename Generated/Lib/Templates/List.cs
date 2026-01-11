namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00682BD0
    /// void __thiscall List&lt;PStringBase&lt;char&gt;&gt;::Serialize(_DWORD*,Archive*)</code>
    /// </summary>
    // void __thiscall List<PStringBase<char>>::Serialize(_DWORD*,Archive*) (template type method)
}

public unsafe struct List___StringTableMetaLanguage_Node_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

public unsafe struct List___PFileNode_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

public unsafe struct List__uint
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

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

public unsafe struct List___Glyph
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00472D20
    /// char __thiscall List&lt;Glyph&gt;::push_back(_DWORD*,Glyph*)</code>
    /// </summary>
    // char __thiscall List<Glyph>::push_back(_DWORD*,Glyph*) (template type method)

    /// <summary>
    /// <code>Offset: 0x00472D90
    /// char __thiscall List&lt;Glyph&gt;::insert(_DWORD*,int,Glyph*)</code>
    /// </summary>
    // char __thiscall List<Glyph>::insert(_DWORD*,int,Glyph*) (template type method)

    /// <summary>
    /// <code>Offset: 0x00473020
    /// char __thiscall List&lt;Glyph&gt;::remove(_DWORD*,Glyph*)</code>
    /// </summary>
    // char __thiscall List<Glyph>::remove(_DWORD*,Glyph*) (template type method)

    /// <summary>
    /// <code>Offset: 0x00473370
    /// void __thiscall List&lt;Glyph&gt;::flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall List<Glyph>::flush(_DWORD*) (template type method)
}

public unsafe struct List___DialogInfo
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004771D0
    /// char __thiscall List&lt;DialogInfo&gt;::pop_front(_DWORD*,_DWORD*)</code>
    /// </summary>
    // char __thiscall List<DialogInfo>::pop_front(_DWORD*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x00477240
    /// char __thiscall List&lt;DialogInfo&gt;::remove(_DWORD*,PropertyCollection*)</code>
    /// </summary>
    // char __thiscall List<DialogInfo>::remove(_DWORD*,PropertyCollection*) (template type method)

    /// <summary>
    /// <code>Offset: 0x004772D0
    /// void __thiscall List&lt;DialogInfo&gt;::flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall List<DialogInfo>::flush(_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x00477B80
    /// char __thiscall List&lt;DialogInfo&gt;::insert(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    // char __thiscall List<DialogInfo>::insert(_DWORD*,int,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x00477C70
    /// char __thiscall List&lt;DialogInfo&gt;::push_back(_DWORD*,_DWORD*)</code>
    /// </summary>
    // char __thiscall List<DialogInfo>::push_back(_DWORD*,_DWORD*) (template type method)
}

public unsafe struct List___QualifiedControl
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004874F0
    /// char __thiscall List&lt;QualifiedControl&gt;::push_back(_DWORD*,_DWORD*)</code>
    /// </summary>
    // char __thiscall List<QualifiedControl>::push_back(_DWORD*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x00487570
    /// QualifiedControl* __thiscall List&lt;QualifiedControl&gt;::find(_DWORD*,QualifiedControl*)</code>
    /// </summary>
    // QualifiedControl* __thiscall List<QualifiedControl>::find(_DWORD*,QualifiedControl*) (template type method)

    /// <summary>
    /// <code>Offset: 0x004878A0
    /// int __thiscall List&lt;QualifiedControl&gt;::get_data(_DWORD*,unsigned int)</code>
    /// </summary>
    // int __thiscall List<QualifiedControl>::get_data(_DWORD*,unsigned int) (template type method)
}

public unsafe struct List___PStringBase__ushort
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr _head;
    public System.IntPtr _tail;
    public uint _num_elements;

    // Methods
}

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

    /// <summary>
    /// <code>Offset: 0x00542170
    /// char __thiscall List&lt;PerfMonCounterInfo::PerfMonCounterNameHelp&gt;::pop_front(_DWORD*,_DWORD*)</code>
    /// </summary>
    // char __thiscall List<PerfMonCounterInfo::PerfMonCounterNameHelp>::pop_front(_DWORD*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x00542200
    /// char __thiscall List&lt;PerfMonCounterInfo::PerfMonCounterNameHelp&gt;::pop_head(_DWORD*)</code>
    /// </summary>
    // char __thiscall List<PerfMonCounterInfo::PerfMonCounterNameHelp>::pop_head(_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x00683C60
    /// char __thiscall List&lt;PerfMonCounterInfo::PerfMonCounterNameHelp&gt;::insert(_DWORD*,int,int)</code>
    /// </summary>
    // char __thiscall List<PerfMonCounterInfo::PerfMonCounterNameHelp>::insert(_DWORD*,int,int) (template type method)

    /// <summary>
    /// <code>Offset: 0x00683CE0
    /// char __thiscall List&lt;PerfMonCounterInfo::PerfMonCounterNameHelp&gt;::insert_sort(_DWORD*,_WORD*)</code>
    /// </summary>
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

    /// <summary>
    /// <code>Offset: 0x0055F470
    /// char __thiscall List&lt;ObjectRangeInfo&gt;::insert(_DWORD*,int,const void*)</code>
    /// </summary>
    // char __thiscall List<ObjectRangeInfo>::insert(_DWORD*,int,const void*) (template type method)

    /// <summary>
    /// <code>Offset: 0x0055F9F0
    /// char __thiscall List&lt;ObjectRangeInfo&gt;::remove(_DWORD*,_DWORD*)</code>
    /// </summary>
    // char __thiscall List<ObjectRangeInfo>::remove(_DWORD*,_DWORD*) (template type method)

    /// <summary>
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

    /// <summary>
    /// <code>Offset: 0x00459EC0
    /// char __thiscall List&lt;UIElementMessageInfo&gt;::pop_front(_DWORD*,_DWORD*)</code>
    /// </summary>
    // char __thiscall List<UIElementMessageInfo>::pop_front(_DWORD*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x0045A3B0
    /// char __thiscall List&lt;UIElementMessageInfo&gt;::remove(_DWORD*,_DWORD*)</code>
    /// </summary>
    // char __thiscall List<UIElementMessageInfo>::remove(_DWORD*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x0045A9B0
    /// char __thiscall List&lt;UIElementMessageInfo&gt;::push_back(_DWORD*,_DWORD*)</code>
    /// </summary>
    // char __thiscall List<UIElementMessageInfo>::push_back(_DWORD*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x0045B110
    /// void** __thiscall List&lt;UIElementMessageInfo&gt;::~List&lt;UIElementMessageInfo&gt;(void***)</code>
    /// </summary>
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

