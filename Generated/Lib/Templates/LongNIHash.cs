namespace ACBindings.Internal;


/// <summary>Provides a hash table implementation for DetectionCylsphere objects keyed by long integers, managing bucket storage and table sizing within the system.</summary>
public unsafe struct LongNIHash___DetectionCylsphere
{
    // Members
    public ACBindings.Internal.LongNIHashData** buckets;
    public int table_size;

    // Methods

    /// <summary>Clears every entry in the hash table, freeing all stored nodes and resetting each bucket to empty.
    /// <code>Offset: 0x0051A370
    /// _DWORD** __thiscall LongNIHash&lt;DetectionCylsphere&gt;::flush(_DWORD*)</code>
    /// </summary>
    /// <returns>The original number of buckets contained in the hash table before it was cleared.</returns>
    // _DWORD** __thiscall LongNIHash<DetectionCylsphere>::flush(_DWORD*) (template type method)
}


/// <summary>Specialized hash table storing AttackInfo objects, mapping long integer keys to values through a bucket array for efficient lookup and retrieval.</summary>
public unsafe struct LongNIHash___AttackInfo
{
    // Members
    public ACBindings.Internal.LongNIHashData** buckets;
    public int table_size;

    // Methods
}


/// <summary>Maintains a hash map of ParticleEmitter objects, mapping long keys to buckets for efficient lookup and dynamic table sizing.</summary>
public unsafe struct LongNIHash___ParticleEmitter
{
    // Members
    public ACBindings.Internal.LongNIHashData** buckets;
    public int table_size;

    // Methods

    /// <summary>Adds an entry to the hash table, allocating a new node and inserting it at the head of the bucket determined by the key.
    /// <code>Offset: 0x0051A430
    /// int __thiscall LongNIHash&lt;ParticleEmitter&gt;::add(_DWORD*,int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The integer value associated with the key (e.g., identifier or pointer index for ParticleEmitter).</param>
    /// <param name="a3">The unsigned int key used to compute the hash bucket.</param>
    /// <returns>Non‑zero if the entry was added successfully; zero if memory allocation failed.</returns>
    // int __thiscall LongNIHash<ParticleEmitter>::add(_DWORD*,int,unsigned int) (template type method)
}

public unsafe struct LongNIHash___BlockListEntry
{
    // Members
    public ACBindings.Internal.LongNIHashData** buckets;
    public int table_size;

    // Methods
}

public unsafe struct LongNIHash___DetectionInfo
{
    // Members
    public ACBindings.Internal.LongNIHashData** buckets;
    public int table_size;

    // Methods

    /// <summary>Creates a hash table with the requested number of buckets, allocating storage and zero‑initializing each bucket.
    /// <code>Offset: 0x0051A2D0
    /// _DWORD* __thiscall LongNIHash&lt;DetectionInfo&gt;::LongNIHash&lt;DetectionInfo&gt;(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Number of buckets for the hash table.</param>
    /// <returns>Pointer to the initialized LongNIHash instance.</returns>
    // _DWORD* __thiscall LongNIHash<DetectionInfo>::LongNIHash<DetectionInfo>(_DWORD*,int) (template type method)

    /// <summary>Destroys all entries in the hash table, freeing allocated memory for each detection info entry and clearing bucket pointers.
    /// <code>Offset: 0x0051A310
    /// void** __thiscall LongNIHash&lt;DetectionInfo&gt;::destroy_contents(void***)</code>
    /// </summary>
    /// <returns>The total number of buckets that were present before destruction.</returns>
    // void** __thiscall LongNIHash<DetectionInfo>::destroy_contents(void***) (template type method)
}

public unsafe struct LongNIHash___TargettedVoyeurInfo
{
    // Members
    public ACBindings.Internal.LongNIHashData** buckets;
    public int table_size;

    // Methods

    /// <summary>Removes the element whose key matches the supplied unsigned integer from the hash table, freeing its node and returning the stored value.
    /// <code>Offset: 0x0051AD60
    /// _DWORD* __thiscall LongNIHash&lt;TargettedVoyeurInfo&gt;::remove(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The key of the entry to remove.</param>
    /// <returns>A pointer representing the value that was associated with the removed key, or null if no matching entry existed.</returns>
    // _DWORD* __thiscall LongNIHash<TargettedVoyeurInfo>::remove(_DWORD*,unsigned int) (template type method)

    /// <summary>Destroys all entries stored in the hash table, freeing memory for each node and clearing bucket pointers.
    /// <code>Offset: 0x0051B690
    /// _DWORD** __thiscall LongNIHash&lt;TargettedVoyeurInfo&gt;::destroy_contents(_DWORD*)</code>
    /// </summary>
    /// <param name="this">Pointer to the LongNIHash instance whose contents are destroyed.</param>
    /// <returns>The original value of this[1] (the table size), returned after cleanup.</returns>
    // _DWORD** __thiscall LongNIHash<TargettedVoyeurInfo>::destroy_contents(_DWORD*) (template type method)
}

public unsafe struct LongNIHash__int
{
    // Members
    public ACBindings.Internal.LongNIHashData** buckets;
    public int table_size;

    // Methods
}

