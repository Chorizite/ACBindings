namespace ACBindings.Internal;


/// <summary>Provides an efficient container for storing and accessing QualifiedDataID elements via an intrusive hash table, enabling rapid insertion, removal, and lookup operations.</summary>
public unsafe struct HashSet___QualifiedDataID
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IntrusiveHashTable___QualifiedDataID___HashSetData___QualifiedDataID_ptr m_intrusiveTable;

    // Methods

    /// <summary>Adds the specified QualifiedDataID to the set, allocating a new entry when it is not already present.
    /// <code>Offset: 0x00414D80
    /// char __thiscall HashSet&lt;QualifiedDataID&gt;::add(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="qualifiedId">Pointer to the QualifiedDataID to be inserted into the hash set.</param>
    /// <returns>Non‑zero if the element was added; zero if an equivalent element already existed in the set.</returns>
    // char __thiscall HashSet<QualifiedDataID>::add(_DWORD*,_DWORD*) (template type method)

    /// <summary>Removes the element identified by the specified key from this hash set, freeing its associated memory when found.
    /// <code>Offset: 0x00414F50
    /// char __thiscall HashSet&lt;QualifiedDataID&gt;::erase(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">The identifier of the element to remove.</param>
    /// <returns>Non-zero if an element was removed; zero otherwise.</returns>
    // char __thiscall HashSet<QualifiedDataID>::erase(_DWORD*,_DWORD*) (template type method)
}


/// <summary>Maintains a collection of unique unsigned long values, enabling efficient insertion, lookup, and removal through an intrusive hash table implementation.</summary>
public unsafe struct HashSet__uint
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IntrusiveHashTable__uint___HashSetData__uint_ptr m_intrusiveTable;

    // Methods
}


/// <summary>Manages a set of UIElement pointers, offering efficient insertion, lookup, and removal through an intrusive hash table implementation.</summary>
public unsafe struct HashSet___UIElement_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IntrusiveHashTable___UIElement_ptr___HashSetData___UIElement_ptr_ptr m_intrusiveTable;

    // Methods
}


/// <summary>Holds unique UIListener* objects in a hash set for efficient lookup and management within the UI system.</summary>
public unsafe struct HashSet___UIListener_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IntrusiveHashTable___UIListener_ptr___HashSetData___UIListener_ptr_ptr m_intrusiveTable;

    // Methods
}


/// <summary>Provides a container for unique ImgTex pointers, backed by an intrusive hash table that enables fast insertion, lookup, and removal.</summary>
public unsafe struct HashSet___ImgTex_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IntrusiveHashTable___ImgTex_ptr___HashSetData___ImgTex_ptr_ptr m_intrusiveTable;

    // Methods
}

public unsafe struct HashSet___IDClass____tagDataID
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IntrusiveHashTable___IDClass____tagDataID___HashSetData___IDClass____tagDataID_ptr m_intrusiveTable;

    // Methods
}

public unsafe struct HashSet__void_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IntrusiveHashTable__void_ptr___HashSetData__void_ptr_ptr m_intrusiveTable;

    // Methods
}

public unsafe struct HashSet___PStringBase__sbyte
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IntrusiveHashTable___PStringBase__sbyte___HashSetData___PStringBase__sbyte_ptr m_intrusiveTable;

    // Methods

    /// <summary>Destroys a HashSet&lt;PStringBase&lt;char&gt;&gt; instance, freeing its internal intrusive hash table and deallocating any allocated memory.
    /// <code>Offset: 0x004136E0
    /// int __thiscall HashSet&lt;PStringBase&lt;char&gt;&gt;::~HashSet&lt;PStringBase&lt;char&gt;&gt;(void***)</code>
    /// </summary>
    /// <returns>Zero on successful completion.</returns>
    // int __thiscall HashSet<PStringBase<char>>::~HashSet<PStringBase<char>>(void***) (template type method)
}

