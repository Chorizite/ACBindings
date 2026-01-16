namespace ACBindings.Internal;


/// <summary>Stores integer-keyed CAsyncStateHandler pointers in an intrusive hash table with a fixed bucket array, enabling efficient lookup and memory locality for async state handling.</summary>
public unsafe struct IntrusiveHashTable__int___CAsyncStateHandler_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public ACBindings.Internal.CAsyncStateHandler** m_aInplaceBuckets => (ACBindings.Internal.CAsyncStateHandler**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public ACBindings.Internal.CAsyncStateHandler** m_buckets;
    public ACBindings.Internal.CAsyncStateHandler** m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Provides an intrusive hash table for AsyncContext keys, storing CAsyncStateMachine::CAsyncStateData pointers directly within the bucket array. Enables efficient lookup and management of async state data with minimal allocation overhead.</summary>
public unsafe struct IntrusiveHashTable___AsyncContext___CAsyncStateMachine_CAsyncStateData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public ACBindings.Internal.CAsyncStateMachine.CAsyncStateData** m_aInplaceBuckets => (ACBindings.Internal.CAsyncStateMachine.CAsyncStateData**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public ACBindings.Internal.CAsyncStateMachine.CAsyncStateData** m_buckets;
    public ACBindings.Internal.CAsyncStateMachine.CAsyncStateData** m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Represents an intrusive hash table specialized for PStringBase&lt;char&gt; keys and HashTableData&lt;PStringBase&lt;char&gt;, unsigned long&gt;* values, providing fast key-based access while storing data inline. Used within the system to manage collections of string-keyed entries with minimal allocation overhead.</summary>
public unsafe struct IntrusiveHashTable___PStringBase__sbyte___HashTableData___PStringBase__sbyte__uint_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maintains a hash table mapping unsigned long identifiers to LogController::CategoryHandler pointers, using intrusive chaining to minimize memory overhead and support fast lookups in the logging subsystem.</summary>
public unsafe struct IntrusiveHashTable__uint___LogController_CategoryHandler_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public ACBindings.Internal.LogController.CategoryHandler** m_aInplaceBuckets => (ACBindings.Internal.LogController.CategoryHandler**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public ACBindings.Internal.LogController.CategoryHandler** m_buckets;
    public ACBindings.Internal.LogController.CategoryHandler** m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>
/// Stores key/value pairs indexed by case‑insensitive UTF‑16 strings, using an intrusive hash table that holds pointers to HashTableData objects containing the actual long values. Supports efficient lookup, insertion, and removal while keeping bucket metadata compact.
/// </summary>
public unsafe struct IntrusiveHashTable___CaseInsensitiveStringBase___PStringBase__ushort___HashTableData___CaseInsensitiveStringBase___PStringBase__ushort__int_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maps unsigned short keys to HashTableData pointers, providing a lightweight hash table for fast lookup and insertion. The structure holds bucket metadata while actual data objects reside elsewhere, enabling efficient memory usage.</summary>
public unsafe struct IntrusiveHashTable__ushort___HashTableData__ushort__int_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Represents an intrusive hash table mapping unsigned long keys to HashTableData pointers, storing bucket arrays inline for efficient lookup and low allocation overhead.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___StringInfoData_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maintains a mapping from QualifiedDataID keys to DBObjSaveInfo* values using an intrusive hash table that stores bucket pointers inline for fast access and minimal allocation overhead.</summary>
public unsafe struct IntrusiveHashTable___QualifiedDataID___DBObjSaveInfo_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public ACBindings.Internal.DBObjSaveInfo** m_aInplaceBuckets => (ACBindings.Internal.DBObjSaveInfo**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public ACBindings.Internal.DBObjSaveInfo** m_buckets;
    public ACBindings.Internal.DBObjSaveInfo** m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>
/// Provides an intrusive hash table keyed by 32‑bit data identifiers, mapping to DBObj* pointers for efficient storage and retrieval of database objects.
/// </summary>
public unsafe struct IntrusiveHashTable___IDClass____tagDataID___HashTableData___IDClass____tagDataID___DBObj_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maintains a hash table mapping unsigned long keys to float values through intrusive node pointers, enabling efficient insertions, lookups, and removals using an internal bucket array.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint__float_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>
/// Stores a hash table of intrusive linked‑list elements keyed by <see cref="QualifiedDataID"/>, mapping to <see cref="HashSetData{QualifiedDataID}"/> objects for efficient lookup and insertion within the system.
/// </summary>
public unsafe struct IntrusiveHashTable___QualifiedDataID___HashSetData___QualifiedDataID_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>
/// Provides a lightweight intrusive hash table mapping unsigned long keys to ArchiveVersionRow data via HashTableData pointers, facilitating fast lookup and in‑place storage of version metadata.
/// </summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___ArchiveVersionRow_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Intrusive hash table mapping case‑insensitive string keys to unsigned long values, optimized for in‑place bucket storage and fast lookups.</summary>
public unsafe struct IntrusiveHashTable___CaseInsensitiveStringBase___PStringBase__sbyte___HashTableData___CaseInsensitiveStringBase___PStringBase__sbyte__uint_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maps unsigned long identifiers to associated data using an intrusive hash table that embeds bucket metadata directly in the stored nodes, enabling efficient lookups and low allocation overhead.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___CaseInsensitiveStringBase___PStringBase__sbyte_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Provides an intrusive hash table that maps unsigned long identifiers to HashTableData pointers holding IDClass&lt;_tagDataID,32,0&gt; instances. Manages bucket allocation and tracks element count for efficient lookup within the system.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___IDClass____tagDataID_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maps unsigned long keys to associated string data within an intrusive hash table optimized for low allocation overhead.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___PStringBase__sbyte_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Stores and retrieves data pointers keyed by 32‑bit identifiers using an intrusive hash table optimized for fast lookup.</summary>
public unsafe struct IntrusiveHashTable___IDClass____tagDataID___HashTableData___IDClass____tagDataID__uint_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Provides a lightweight, intrusive hash table mapping unsigned long identifiers to BasePropertyValue instances via intrusive smart pointers, enabling efficient property lookup and memory management within the system.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___IntrusiveSmartPointer___BasePropertyValue_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maintains an intrusive hash table mapping unsigned long keys to property descriptors, enabling fast lookup and storage of property data within the system.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___BasePropertyDesc_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Provides a hash table that stores pointers to HashTableData objects keyed by unsigned long identifiers, enabling efficient lookup and management of AvailableProperty entries.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___AvailableProperty_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Stores hash table data objects keyed by unsigned long, using an intrusive bucket layout to enable fast lookups and low allocation overhead.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___StringTableString_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maintains a hash table mapping unsigned long keys to HashTableData objects, storing elements in-place within preallocated bucket arrays for efficient lookup and minimal heap usage.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___PStringBase__ushort_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Provides an intrusive hash table mapping unsigned long keys to linked list entries of string data, optimized for minimal memory overhead and fast lookup. The table manages its own bucket storage and tracks element counts internally.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___List___PStringBase__sbyte_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maps unsigned long identifiers to pointers within a hash list structure, using intrusive bucket storage for efficient lookup and minimal heap usage.</summary>
/// <remarks>The table maintains an internal array of buckets and tracks element counts to support fast insertions and deletions.</remarks>
public unsafe struct IntrusiveHashTable__uint___HashList__uint___ActionMapValue_HashListData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Offers an intrusive hash table specialized for ControlSpecification objects, storing entries within pre-allocated buckets to reduce dynamic allocations and accelerate lookup operations. Tracks element count, bucket array, and a reference to the first non-empty bucket for efficient traversal.</summary>
public unsafe struct IntrusiveHashTable___ControlSpecification___HashList___ControlSpecification__uint_HashListData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Associates unsigned long identifiers with HashListData pointers, employing an intrusive layout that stores elements inline in bucket arrays for fast lookup and reduced allocation overhead.</summary>
public unsafe struct IntrusiveHashTable__uint___HashList__uint___CInputMap_ptr_HashListData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Represents an intrusive hash table mapping unsigned long keys to HashTableData pointers, providing fast lookup and minimal allocation overhead by storing elements inline.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint__uint_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Keyed collection enabling fast lookup of QualityChangeHandler arrays via 64‑bit identifiers.</summary>
public unsafe struct IntrusiveHashTable__ulong___HashTableData__ulong___SmartArray___QualityChangeHandler_ptr_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>
/// Stores an intrusive hash table that maps unsigned long identifiers to CLostCell pointers, enabling fast lookup with minimal memory overhead.
/// </summary>
public unsafe struct IntrusiveHashTable__uint___CLostCell_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public ACBindings.Internal.CLostCell** m_aInplaceBuckets => (ACBindings.Internal.CLostCell**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public ACBindings.Internal.CLostCell** m_buckets;
    public ACBindings.Internal.CLostCell** m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Stores unsigned long keys mapped to HashSetData pointers using an intrusive hash table with a fixed bucket parameter. Provides efficient lookup, insertion, and management of elements for internal data structures.</summary>
public unsafe struct IntrusiveHashTable__uint___HashSetData__uint_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Provides an intrusive hash table mapping unsigned long keys to HashTableData pointers, enabling efficient lookup and minimal memory overhead in the system.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint__double_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maps unsigned long identifiers to collections of BaseProperty data via an intrusive hash table designed for efficient storage and retrieval. Buckets are preallocated to reduce dynamic memory overhead, enabling rapid access in performance‑critical contexts.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___BaseProperty_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Provides a hash table mapping unsigned long identifiers to SoundTableData pointers, optimized with an inline bucket array for small tables and dynamic buckets for larger sizes.</summary>
/// <remarks>Tracks element count, bucket count, and supports fast lookup and iteration within the audio subsystem.</remarks>
public unsafe struct IntrusiveHashTable__uint___SoundTableData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public ACBindings.Internal.SoundTableData** m_aInplaceBuckets => (ACBindings.Internal.SoundTableData**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public ACBindings.Internal.SoundTableData** m_buckets;
    public ACBindings.Internal.SoundTableData** m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Offers a compact, high‑performance hash table implementation tailored for storing physics script data keyed by unsigned long identifiers, leveraging in‑place bucket storage to reduce memory overhead.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___PhysicsScriptTableData_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maps unsigned long identifiers to element descriptors via an intrusive hash table, storing entries in a compact bucket array for fast lookups.</summary>
/// <remarks>Maintains bucket pointers, element count, and provides direct access to stored data without external allocation overhead.</remarks>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___ElementDesc_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Intrusive hash table optimized for UI element collections, storing associations between UIElement instances and their hash set data with minimal overhead.</summary>
public unsafe struct IntrusiveHashTable___UIElement_ptr___HashSetData___UIElement_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>
/// Provides an intrusive hash table for UIRegion objects, storing elements directly within the bucket array to minimize allocations and enable fast lookup by region identity. Manages bucket metadata such as count and element count, utilizing a custom hash list data type for collision handling.
/// </summary>
public unsafe struct IntrusiveHashTable___UIRegion_ptr___HashList___UIRegion_ptr___UIRegion_ptr_HashListData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Intrusive hash table keyed by unsigned long that stores pointers to HashTableData entries, each linking to a StateDesc. Provides fast lookup with minimal overhead in the state management subsystem.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___StateDesc_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>
/// Stores UIListener pointers in an intrusive hash table, enabling fast membership tests and efficient traversal. Uses a fixed bucket array to minimize dynamic allocations and reduce memory overhead.
/// </summary>
public unsafe struct IntrusiveHashTable___UIListener_ptr___HashSetData___UIListener_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Provides an intrusive hash table that maps unsigned long keys to HashTableData entries containing references to Sex_CG objects, enabling fast O(1) lookup and management of these entities within the application.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___Sex_CG_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Provides an intrusive hash table mapping unsigned long keys to HashListData pointers, utilizing inline bucket storage for small tables and dynamic buckets for larger collections.</summary>
public unsafe struct IntrusiveHashTable__uint___HashList__uint___HashList__uint___List__uint_HashListData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maintains a hash table that maps unsigned integer keys to intrusive list nodes, enabling fast lookup and insertion for data structures built on HashListData pointers.</summary>
public unsafe struct IntrusiveHashTable__uint___HashList__uint___List__uint_HashListData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Implements an intrusive hash table that maps 32‑bit unsigned integer keys to pointers of HashTableData&lt;unsigned long, unsigned char&gt;, using inline and dynamic bucket storage for efficient lookups and insertions.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint__byte_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maps case‑insensitive string identifiers to command data pointers, enabling efficient lookup and retrieval of command metadata within the client communication subsystem.</summary>
public unsafe struct IntrusiveHashTable___CaseInsensitiveStringBase___PStringBase__sbyte___ClientCommunicationSystem_CmdHashData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public ACBindings.Internal.ClientCommunicationSystem.CmdHashData** m_aInplaceBuckets => (ACBindings.Internal.ClientCommunicationSystem.CmdHashData**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public ACBindings.Internal.ClientCommunicationSystem.CmdHashData** m_buckets;
    public ACBindings.Internal.ClientCommunicationSystem.CmdHashData** m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Stores a mapping from unsigned long identifiers to HeritageGroup_CG objects in an efficient hash‑based container, enabling rapid lookup and iteration.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___HeritageGroup_CG_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Associates unique identifiers with collections of dialog information, enabling efficient lookup and management within the application's UI system.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___List___DialogInfo_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint__void_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maintains an intrusive hash table mapping data identifiers to element descriptors, storing bucket pointers and count metadata for efficient lookup.</summary>
/// <remarks>Used within a 32‑bit MSVC application to associate IDs with ElementDesc structures via hashed buckets.</remarks>
public unsafe struct IntrusiveHashTable___IDClass____tagDataID___HashTableData___IDClass____tagDataID___HashTable__uint___ElementDesc_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maintains a lightweight, intrusive hash table mapping unsigned long keys to DialogInfo pointers for efficient lookup of dialog data within the application.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___DialogInfo_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Facilitates efficient lookup of image textures by pixel format identifiers, storing references to hash tables that map unique keys to ImgTex objects.</summary>
public unsafe struct IntrusiveHashTable___PixelFormatID___HashTableData___PixelFormatID___HashTable__uint___ImgTex_ptr_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maps unsigned long identifiers to CEnvCell data via an intrusive hash table, enabling fast lookup and minimal allocation overhead.</summary>
/// <remarks>Internally stores bucket pointers and element counts for efficient probing.</remarks>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___CEnvCell_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maintains a mapping from string keys to UIPreferenceItem pointers using an intrusive hash table optimized for the UI preference subsystem.</summary>
public unsafe struct IntrusiveHashTable___PStringBase__sbyte___HashTableData___PStringBase__sbyte___UIPreferenceItem_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maintains a hash table mapping unsigned long identifiers to DBOCache objects, utilizing intrusive buckets for efficient lookup and minimal allocation overhead.</summary>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___DBOCache_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Provides an intrusive hash table mapping UI objects to their corresponding list data, enabling efficient storage and retrieval within the UI subsystem.</summary>
/// <remarks>Utilizes a fixed-size bucket array for small tables, tracking element counts and supporting fast lookup without allocating additional nodes.</remarks>
public unsafe struct IntrusiveHashTable___UIObject_ptr___HashList___UIObject_ptr___UIObject_ptr_HashListData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Stores sound buffer references keyed by data identifiers, enabling fast retrieval and memory‑efficient management within the audio engine.</summary>
public unsafe struct IntrusiveHashTable___IDClass____tagDataID___SoundBufRef_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public ACBindings.Internal.SoundBufRef** m_aInplaceBuckets => (ACBindings.Internal.SoundBufRef**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public ACBindings.Internal.SoundBufRef** m_buckets;
    public ACBindings.Internal.SoundBufRef** m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maps unsigned long keys to DBTypeDef pointers through an intrusive hash table, storing elements directly in bucket structures for efficient access.</summary>
/// <remarks>Maintains a 23-element inline bucket array and a dynamic bucket list; tracks element and bucket counts.</remarks>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___DBTypeDef_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Provides a hash table implementation that stores pointers to HashTableData entries keyed by unsigned 64‑bit values, facilitating efficient retrieval of ImgTex* instances.</summary>
/// <remarks>Employs an intrusive bucket layout with a fixed-size in-place array and a dynamic bucket list, optimizing memory usage and cache locality for frequent lookups.</remarks>
public unsafe struct IntrusiveHashTable__ulong___HashTableData__ulong___ImgTex_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Provides an intrusive hash table that maps ImgTex pointers to associated HashSetData entries, storing elements inline within a fixed-size bucket array for efficient lookup and minimal allocation overhead.</summary>
public unsafe struct IntrusiveHashTable___ImgTex_ptr___HashSetData___ImgTex_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Associates unsigned long identifiers with collections of UIMessageData through an intrusive hash table, enabling efficient lookup, insertion, and iteration over UI messages.</summary>
/// <remarks>Internally manages buckets and elements in a compact format suitable for real‑time UI processing.</remarks>
public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___SmartArray___UIMessageData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Represents an intrusive hash table keyed by unsigned long values, mapping each key to a pointer to AC1Legacy::HashTableData&lt;unsigned long, double&gt;. The structure embeds bucket metadata directly in the object, enabling efficient lookups with reduced memory allocations. It tracks total buckets and elements for dynamic resizing and iteration.</summary>
public unsafe struct IntrusiveHashTable__uint___AC1Legacy_HashTableData__uint__double_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>Maps qualified data identifiers to asynchronous get request descriptors, enabling efficient storage and retrieval of request state within the system.</summary>
public unsafe struct IntrusiveHashTable___QualifiedDataID___HashTableData___QualifiedDataID___CAsyncGetRequest_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}


/// <summary>
/// Associates asynchronous contexts with callback handler data via a hybrid bucket system that stores up to 23 entries inline and expands dynamically as needed, enabling quick lookup and insertion.
/// </summary>
public unsafe struct IntrusiveHashTable___AsyncContext___HashTableData___AsyncContext___AsyncCache_CCallbackHandler_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___QualifiedDataID___HashTableData___QualifiedDataID___MissingIteration_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__ulong___HashTableData__ulong___DiskController_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___QualityHandler_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public ACBindings.Internal.QualityHandler** m_aInplaceBuckets => (ACBindings.Internal.QualityHandler**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public ACBindings.Internal.QualityHandler** m_buckets;
    public ACBindings.Internal.QualityHandler** m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___IDClass____tagDataID___HashList___IDClass____tagDataID__byte_HashListData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___IDClass____tagDataID___HashSetData___IDClass____tagDataID_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___Turbine_GUID___HashTableData___Turbine_GUID___Interface_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashList__uint___HashList__uint___ActionMapValue_HashListData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___InputMapConflictsValue_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__int___HashTableData__int___DataHistory_IterationData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___QualifiedDataID___HashTableData___QualifiedDataID__int_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___AutoGrowHashTable__uint___SmartArray___UIMessageData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___SmartArray___UIElement_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___CaseInsensitiveStringBase___PStringBase__sbyte___HashTableData___CaseInsensitiveStringBase___PStringBase__sbyte___TFileEntry_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___IDClass____tagDataID___HashTableData___IDClass____tagDataID___TFileEntry_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___TDBTypeEntry_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___Interface_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___PStringBase__sbyte___HashTableData___PStringBase__sbyte___GRPCommand_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___PStringBase__sbyte___HashTableData___PStringBase__sbyte___GRPObject_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___QualifiedControl___HashList___QualifiedControl__uint_HashListData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___List___NoticeHandler_ptr_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__ulong___HashTableData__ulong__ulong_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint__int_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___ImgTex_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___SpellSet_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___Graphic_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___IDClass____tagDataID___HashTableData___IDClass____tagDataID___Graphic_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___IDClass____tagVersionHandle___InArchiveVersionStack_VersionRowHolder_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public ACBindings.Internal.InArchiveVersionStack.VersionRowHolder** m_aInplaceBuckets => (ACBindings.Internal.InArchiveVersionStack.VersionRowHolder**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public ACBindings.Internal.InArchiveVersionStack.VersionRowHolder** m_buckets;
    public ACBindings.Internal.InArchiveVersionStack.VersionRowHolder** m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__void_ptr___HashSetData__void_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___PStringBase__sbyte___HashSetData___PStringBase__sbyte_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___QualifiedIteration___HashTableData___QualifiedIteration___IterationKey_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___UILocationData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___IDClass____tagDataID___HashTableData___IDClass____tagDataID___HashTable__uint___UILocationData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___NameFilterLanguageData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___HashTable__uint___List___PStringBase__sbyte_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___ActionState_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public ACBindings.Internal.ActionState** m_aInplaceBuckets => (ACBindings.Internal.ActionState**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public ACBindings.Internal.ActionState** m_buckets;
    public ACBindings.Internal.ActionState** m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___ControlSpecification___HashTableData___ControlSpecification___ControlType_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___ControlSpecification___HashTableData___ControlSpecification___CInputManager_WIN32_RecentControlState_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___ControlSpecification___PriorityHash___ControlSpecification___CInputManager_WIN32_ButtonHistoryEntry_PriorityHashData_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___RenderVertexStreamD3D_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___UIElement_ListBox_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable___IDClass____tagDataID___HashTableData___IDClass____tagDataID___SpellComponentRegion_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___gmCGSkillsPage_tagSkillRecord_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

public unsafe struct IntrusiveHashTable__uint___HashTableData__uint___Logger_ITextFileOutputHandler_ptr_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_aInplaceBuckets_Raw[23 * 4];
    public System.IntPtr* m_aInplaceBuckets => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_aInplaceBuckets_Raw[0]);
    public System.IntPtr m_buckets;
    public System.IntPtr m_firstInterestingBucket;
    public uint m_numBuckets;
    public uint m_numElements;

    // Methods
}

