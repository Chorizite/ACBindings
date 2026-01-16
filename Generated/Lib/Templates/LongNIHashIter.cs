namespace ACBindings.Internal;


/// <summary>Iterator over a hash-based container of DetectionInfo items, maintaining the current bucket number, data pointer, and completion flag during traversal.</summary>
public unsafe struct LongNIHashIter___DetectionInfo
{
    // Members
    public System.IntPtr hash;
    public int bucketNo;
    public ACBindings.Internal.LongNIHashData* curDat;
    public int fDone;

    // Methods
}


/// <summary>Iterates over a hash table of DetectionCylsphere entries, keeping track of the current bucket, data pointer, and whether iteration has finished.</summary>
public unsafe struct LongNIHashIter___DetectionCylsphere
{
    // Members
    public System.IntPtr hash;
    public int bucketNo;
    public ACBindings.Internal.LongNIHashData* curDat;
    public int fDone;

    // Methods

    /// <summary>Initializes an iterator over the supplied DetectionCylsphere hash table, locating the first populated bucket.
    /// <code>Offset: 0x0051A270
    /// _DWORD* __thiscall LongNIHashIter&lt;DetectionCylsphere&gt;::LongNIHashIter&lt;DetectionCylsphere&gt;(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="this">Reference to the iterator instance being constructed.</param>
    /// <param name="a2">Pointer to the hash table data structure to iterate through.</param>
    /// <returns>Reference to the initialized iterator object.</returns>
    // _DWORD* __thiscall LongNIHashIter<DetectionCylsphere>::LongNIHashIter<DetectionCylsphere>(_DWORD*,_DWORD*) (template type method)
}


/// <summary>Iterates over entries in a long‑key hash table storing AttackInfo structures, tracking the current bucket and data pointer to enable sequential access.</summary>
public unsafe struct LongNIHashIter___AttackInfo
{
    // Members
    public System.IntPtr hash;
    public int bucketNo;
    public ACBindings.Internal.LongNIHashData* curDat;
    public int fDone;

    // Methods
}


/// <summary>Iterates over entries in a hash table storing TargettedVoyeurInfo records, maintaining bucket index, current data pointer, and completion flag.</summary>
public unsafe struct LongNIHashIter___TargettedVoyeurInfo
{
    // Members
    public System.IntPtr hash;
    public int bucketNo;
    public ACBindings.Internal.LongNIHashData* curDat;
    public int fDone;

    // Methods
}


/// <summary>Provides an iterator over a hash‑based collection of ParticleEmitter objects, maintaining the current bucket, data pointer, and completion flag.</summary>
public unsafe struct LongNIHashIter___ParticleEmitter
{
    // Members
    public System.IntPtr hash;
    public int bucketNo;
    public ACBindings.Internal.LongNIHashData* curDat;
    public int fDone;

    // Methods
}

