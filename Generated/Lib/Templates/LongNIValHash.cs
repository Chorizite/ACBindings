namespace ACBindings.Internal;


/// <summary>Specializes the generic hash base for unsigned long keys, enabling efficient hashing operations with 4‑byte alignment.</summary>
public unsafe struct LongNIValHash__uint
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods
}


/// <summary>Maps unsigned long keys to LongHash&lt;MotionData&gt;* values in a hash table, enabling fast lookup and management of motion‑data pointers.</summary>
public unsafe struct LongNIValHash___LongHash___MotionData_ptr
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods
}

public unsafe struct LongNIValHash___GlobalVoyeurInfo
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods

    /// <summary>Initializes a LongNIValHash instance with the specified table size, allocating buckets and setting up base hash properties.
    /// <code>Offset: 0x0052C6C0
    /// void*** __thiscall LongNIValHash&lt;GlobalVoyeurInfo&gt;::LongNIValHash&lt;GlobalVoyeurInfo&gt;(void***,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the object being constructed.</param>
    /// <param name="a2">Desired initial capacity for the hash table.</param>
    // void*** __thiscall LongNIValHash<GlobalVoyeurInfo>::LongNIValHash<GlobalVoyeurInfo>(void***,unsigned int) (template type method)

    /// <summary>Adds an entry into the hash table using the supplied key and associated values, inserting it at the computed bucket index.
    /// <code>Offset: 0x0052C700
    /// int __thiscall LongNIValHash&lt;GlobalVoyeurInfo&gt;::add(_DWORD*,int,int,int,int)</code>
    /// </summary>
    /// <param name="a2">First value to store in the new hash node.</param>
    /// <param name="a3">Second value to store in the new hash node.</param>
    /// <param name="a4">Third value to store in the new hash node.</param>
    /// <param name="a5">Key used for hashing; also stored within the entry.</param>
    /// <returns>The index of the bucket where the entry was inserted.</returns>
    // int __thiscall LongNIValHash<GlobalVoyeurInfo>::add(_DWORD*,int,int,int,int) (template type method)

    /// <summary>Destroys a LongNIValHash&lt;GlobalVoyeurInfo&gt;, removing all stored elements and freeing the underlying bucket array when it was not constructed with placement‑new.
    /// <code>Offset: 0x0052CB20
    /// void __thiscall LongNIValHash&lt;GlobalVoyeurInfo&gt;::~LongNIValHash&lt;GlobalVoyeurInfo&gt;(int)</code>
    /// </summary>
    // void __thiscall LongNIValHash<GlobalVoyeurInfo>::~LongNIValHash<GlobalVoyeurInfo>(int) (template type method)
}

public unsafe struct LongNIValHash___CPhysicsObj_CollisionRecord
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods

    /// <summary>
    /// Attempts to insert or update a collision record in the hash table using the supplied key data and an additional integer flag, returning 1 on success.
    /// 
    /// <code>Offset: 0x00514330
    /// int __thiscall LongNIValHash&lt;CPhysicsObj::CollisionRecord&gt;::clobber(_DWORD*,int*,int)</code>
    /// </summary>
    /// <param name="a2">
    /// Pointer to an array of four integers that form the key for the collision record being inserted or updated.
    /// </param>
    /// <param name="a3">
    /// Additional integer value or flag associated with the collision record.
    /// </param>
    /// <returns>
    /// Non‑zero (typically 1) if the operation succeeded; otherwise returns an error code from the base class clobber method. 
    /// </returns>
    // int __thiscall LongNIValHash<CPhysicsObj::CollisionRecord>::clobber(_DWORD*,int*,int) (template type method)
}

public unsafe struct LongNIValHash___SurfInfo_ptr
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods
}

