namespace ACBindings.Internal;


/// <summary>Maintains a hash‑based collection of ActionMapValue entries keyed by unsigned long, leveraging an intrusive list for efficient memory usage and fast access.</summary>
public unsafe struct HashList__uint___ActionMapValue
{
    // Child Types

    /// <summary>Represents a node in an intrusive hash list keyed by unsigned long, storing associated ActionMapValue data and linkage information. Facilitates efficient insertion, deletion, and lookup within the HashList container.</summary>
    public unsafe struct HashListData
    {
        // Base Classes
        public ACBindings.Internal.IntrusiveHashListData__uint___HashList__uint___ActionMapValue_HashListData_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData__uint___HashList__uint___ActionMapValue_HashListData_ptr

        // Members
        public ACBindings.Internal.ActionMapValue m_data;

        // Methods
    }

    // Members
    public ACBindings.Internal.IntrusiveHashList__uint___HashList__uint___ActionMapValue_HashListData_ptr m_ihlIntrusive;

    // Methods
}


/// <summary>
/// Provides an intrusive hash list container for ControlSpecification objects keyed by unsigned long values with a single bucket (1). Facilitates efficient lookup, insertion, and removal of ControlSpecifications within the system.
/// </summary>
/// <remarks>
/// Internally uses IntrusiveHashList to store elements of type ControlSpecification with associated hash data.
/// </remarks>
public unsafe struct HashList___ControlSpecification__uint
{
    // Child Types

    /// <summary>Represents an entry within a hash list of ControlSpecification objects, storing linkage data for intrusive hashing and an associated unsigned integer value.</summary>
    public unsafe struct HashListData
    {
        // Base Classes
        public ACBindings.Internal.IntrusiveHashListData___ControlSpecification___HashList___ControlSpecification__uint_HashListData_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData___ControlSpecification___HashList___ControlSpecification__uint_HashListData_ptr

        // Members
        public uint m_data;

        // Methods
    }

    // Members
    public ACBindings.Internal.IntrusiveHashList___ControlSpecification___HashList___ControlSpecification__uint_HashListData_ptr m_ihlIntrusive;

    // Methods
}


/// <summary>Encapsulates a hash-based collection mapping unsigned long identifiers to CInputMap pointers, enabling fast lookup of input configurations within the system.</summary>
public unsafe struct HashList__uint___CInputMap_ptr
{
    // Child Types

    /// <summary>Links an unsigned long key to a CInputMap instance within an intrusive hash list, enabling efficient hash‑based retrieval and ordered iteration of input maps.</summary>
    public unsafe struct HashListData
    {
        // Base Classes
        public ACBindings.Internal.IntrusiveHashListData__uint___HashList__uint___CInputMap_ptr_HashListData_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData__uint___HashList__uint___CInputMap_ptr_HashListData_ptr

        // Members
        public ACBindings.Internal.CInputMap* m_data;

        // Methods
    }

    // Members
    public ACBindings.Internal.IntrusiveHashList__uint___HashList__uint___CInputMap_ptr_HashListData_ptr m_ihlIntrusive;

    // Methods
}


/// <summary>Provides an intrusive hash list over UIRegion objects, enabling rapid access and traversal of region data.</summary>
public unsafe struct HashList___UIRegion_ptr___UIRegion_ptr
{
    // Child Types

    /// <summary>
    /// Represents an individual node in a hash-based collection that tracks UI region objects, linking each region and storing its pointer for quick lookup.
    /// </summary>
    public unsafe struct HashListData
    {
        // Base Classes
        public ACBindings.Internal.IntrusiveHashListData___UIRegion_ptr___HashList___UIRegion_ptr___UIRegion_ptr_HashListData_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData___UIRegion_ptr___HashList___UIRegion_ptr___UIRegion_ptr_HashListData_ptr

        // Members
        public ACBindings.Internal.UIRegion* m_data;

        // Methods
    }

    // Members
    public ACBindings.Internal.IntrusiveHashList___UIRegion_ptr___HashList___UIRegion_ptr___UIRegion_ptr_HashListData_ptr m_ihlIntrusive;

    // Methods
}


/// <summary>Organizes collections of unsigned long identifiers into an intrusive hash list structure, enabling nested grouping and efficient key-based access.</summary>
/// <remarks>The outer list maps keys to inner HashLists that encapsulate further lists of unsigned longs, supporting hierarchical data management within the application.</remarks>
public unsafe struct HashList__uint___HashList__uint___List__uint
{
    // Child Types

    /// <summary>Serves as a node within an intrusive hash list used by HashList; contains linkage information and holds nested data (a list of unsigned longs) associated with a key.</summary>
    public unsafe struct HashListData
    {
        // Base Classes
        public ACBindings.Internal.IntrusiveHashListData__uint___HashList__uint___HashList__uint___List__uint_HashListData_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData__uint___HashList__uint___HashList__uint___List__uint_HashListData_ptr

        // Members
        public ACBindings.Internal.HashList__uint___List__uint m_data;

        // Methods
    }

    // Members
    public ACBindings.Internal.IntrusiveHashList__uint___HashList__uint___HashList__uint___List__uint_HashListData_ptr m_ihlIntrusive;

    // Methods
}


/// <summary>Provides a hash-based container that maps unsigned long keys to lists of unsigned long values, storing entries in an intrusive linked list for efficient insertion and lookup.</summary>
public unsafe struct HashList__uint___List__uint
{
    // Child Types

    /// <summary>Represents an intrusive hash list node containing a collection of unsigned long values and linking to adjacent nodes through its base class structure.</summary>
    public unsafe struct HashListData
    {
        // Base Classes
        public ACBindings.Internal.IntrusiveHashListData__uint___HashList__uint___List__uint_HashListData_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData__uint___HashList__uint___List__uint_HashListData_ptr

        // Members
        public ACBindings.Internal.List__uint m_data;

        // Methods
    }

    // Members
    public ACBindings.Internal.IntrusiveHashList__uint___HashList__uint___List__uint_HashListData_ptr m_ihlIntrusive;

    // Methods
}


/// <summary>Maintains a hash-based collection of UIObject pointers and their associated data using an intrusive list, enabling efficient insertion, deletion, and lookup operations within the UI system.</summary>
public unsafe struct HashList___UIObject_ptr___UIObject_ptr
{
    // Child Types

    /// <summary>Represents an element of an intrusive hash list keyed by a UIObject pointer, linking via its baseclass_0 field and storing the associated UIObject in m_data.</summary>
    public unsafe struct HashListData
    {
        // Base Classes
        public ACBindings.Internal.IntrusiveHashListData___UIObject_ptr___HashList___UIObject_ptr___UIObject_ptr_HashListData_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData___UIObject_ptr___HashList___UIObject_ptr___UIObject_ptr_HashListData_ptr

        // Members
        public ACBindings.Internal.UIObject* m_data;

        // Methods
    }

    // Members
    public ACBindings.Internal.IntrusiveHashList___UIObject_ptr___HashList___UIObject_ptr___UIObject_ptr_HashListData_ptr m_ihlIntrusive;

    // Methods
}

public unsafe struct HashList___IDClass____tagDataID__byte
{
    // Child Types

    /// <summary>Represents a node within an intrusive hash list, storing a boolean flag and the linkage information required for efficient lookup based on IDClass&lt;_tagDataID,32,0&gt;. Used internally by HashList to manage entries with constant‑time operations.</summary>
    public unsafe struct HashListData
    {
        // Base Classes
        public ACBindings.Internal.IntrusiveHashListData___IDClass____tagDataID___HashList___IDClass____tagDataID__byte_HashListData_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData___IDClass____tagDataID___HashList___IDClass____tagDataID__byte_HashListData_ptr

        // Members
        public byte m_data;

        // Methods
    }

    // Members
    public ACBindings.Internal.IntrusiveHashList___IDClass____tagDataID___HashList___IDClass____tagDataID__byte_HashListData_ptr m_ihlIntrusive;

    // Methods
}

public unsafe struct HashList__uint___HashList__uint___ActionMapValue
{
    // Child Types

    /// <summary>Maintains linkage information and value container for an element in a hash list keyed by unsigned long, where each value is a nested hash list mapping to ActionMapValue. The baseclass_0 field links nodes together in the intrusive list, while m_data holds the actual mapped data.</summary>
    public unsafe struct HashListData
    {
        // Base Classes
        public ACBindings.Internal.IntrusiveHashListData__uint___HashList__uint___HashList__uint___ActionMapValue_HashListData_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData__uint___HashList__uint___HashList__uint___ActionMapValue_HashListData_ptr

        // Members
        public ACBindings.Internal.HashList__uint___ActionMapValue m_data;

        // Methods
    }

    // Members
    public ACBindings.Internal.IntrusiveHashList__uint___HashList__uint___HashList__uint___ActionMapValue_HashListData_ptr m_ihlIntrusive;

    // Methods
}

public unsafe struct HashList___QualifiedControl__uint
{
    // Child Types

    /// <summary>Represents a storage node within a hash list that holds QualifiedControl elements, containing intrusive linkage data and an auxiliary unsigned integer field used for internal bookkeeping.</summary>
    public unsafe struct HashListData
    {
        // Base Classes
        public ACBindings.Internal.IntrusiveHashListData___QualifiedControl___HashList___QualifiedControl__uint_HashListData_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData___QualifiedControl___HashList___QualifiedControl__uint_HashListData_ptr

        // Members
        public uint m_data;

        // Methods
    }

    // Members
    public ACBindings.Internal.IntrusiveHashList___QualifiedControl___HashList___QualifiedControl__uint_HashListData_ptr m_ihlIntrusive;

    // Methods
}

