namespace ACBindings.Internal;


/// <summary>Specialized hash container for CPhysicsObj instances, providing efficient lookup and management of physics objects via unsigned long identifiers.</summary>
public unsafe struct LongHash___CPhysicsObj
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods
}


/// <summary>Provides hashing functionality for CWeenieObject instances, enabling efficient lookup and storage using an unsigned long key.</summary>
public unsafe struct LongHash___CWeenieObject
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods
}


/// <summary>Provides hashing functionality for CObjectInventory objects, storing them keyed by a 32‑bit identifier. Enables efficient lookup, insertion, and removal within the inventory system.</summary>
public unsafe struct LongHash___CObjectInventory
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods
}


/// <summary>Stores MotionData entries indexed by an unsigned long key, utilizing a hash-based mechanism for rapid insertion and lookup.</summary>
public unsafe struct LongHash___MotionData
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods

    /// <summary>Retrieves a motion data entry from a hash table using its numeric key. Returns a pointer to the entry or zero if no match exists.
    /// <code>Offset: 0x005231D0
    /// int __thiscall LongHash&lt;MotionData&gt;::lookup(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="key">The unsigned integer that identifies the desired motion data in the hash table.</param>
    /// <returns>A pointer (expressed as an int) to the matching motion data, or 0 when the key is not present.</returns>
    // int __thiscall LongHash<MotionData>::lookup(_DWORD*,unsigned int) (template type method)
}


/// <summary>Provides a hash‑based container mapping unsigned long identifiers to IconData entries, enabling efficient lookup and storage of icon resources.</summary>
public unsafe struct LongHash___IconData
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods
}

public unsafe struct LongHash___LocationType
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods
}

public unsafe struct LongHash___PlacementType
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods
}

public unsafe struct LongHash___BlockCreationInfo
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods
}

public unsafe struct LongHash___BlockUpdate
{
    // Base Classes
    public ACBindings.Internal.HashBase__uint BaseClass_HashBase; // ACBindings.Internal.HashBase__uint

    // Methods
}

