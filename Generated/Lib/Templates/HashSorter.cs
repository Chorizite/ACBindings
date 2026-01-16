namespace ACBindings.Internal;

public unsafe struct HashSorter__int___DataHistory_IterationData
{
    // Child Types

    /// <summary>Indicates ascending ordering of DataHistory::IterationData items within a hash‑based collection.</summary>
    /// <remarks>Serves as a policy tag for the HashSorter template specialization.</remarks>
    public unsafe struct AscendingByData
    {
        // Methods
    }

    /// <summary>Enables ascending ordering of hash keys for DataHistory iteration data by defining a comparator.</summary>
    /// <remarks>Used in HashSorter to sort entries during retrieval or iteration over history records.</remarks>
    public unsafe struct AscendingByKey
    {
        // Methods
    }

    /// <summary>Defines descending ordering policy for DataHistory::IterationData items accessed via long keys in HashSorter.</summary>
    /// <remarks>Empty implementation indicates the comparator behavior is supplied by surrounding template machinery or specialized functions.</remarks>
    public unsafe struct DescendingByData
    {
        // Methods
    }

    /// <summary>Marker type indicating descending key ordering in the specialized HashSorter for long keys and DataHistory::IterationData values.</summary>
    /// <remarks>This struct is intentionally empty, serving solely as a compile‑time policy indicator to select the appropriate sorting strategy within HashSorter.</remarks>
    public unsafe struct DescendingByKey
    {
        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___HashSorterNode__int___DataHistory_IterationData m_list;

    // Methods
}

public unsafe struct HashSorter__uint___ElementDesc
{
    // Child Types

    /// <summary>Provides a comparator for sorting ElementDesc instances by the value of their data field in ascending order, used internally by HashSorter.</summary>
    public unsafe struct AscendingByData
    {
        // Methods
    }

    /// <summary>Sorts ElementDesc entries by their unsigned long key in ascending order for use within HashSorter.</summary>
    public unsafe struct AscendingByKey
    {
        // Methods
    }

    /// <summary>Compares ElementDesc objects by their data field in descending order for sorting operations.</summary>
    public unsafe struct DescendingByData
    {
        // Methods
    }

    /// <summary>Orders ElementDesc items by descending unsigned long keys for hash‑sorted collections.</summary>
    public unsafe struct DescendingByKey
    {
        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___HashSorterNode__uint___ElementDesc m_list;

    // Methods
}

public unsafe struct HashSorter__uint___StringTableString_ptr
{
    // Child Types

    /// <summary>Enables ordering of hash entries by their associated data values in ascending order, typically used within HashSorter to arrange results.</summary>
    public unsafe struct AscendingByData
    {
        // Methods
    }

    /// <summary>Compares hash table entries by their unsigned long keys in ascending order, facilitating ordered traversal and sorting operations within the HashSorter mechanism.</summary>
    public unsafe struct AscendingByKey
    {
        // Methods
    }

    /// <summary>Orders hash entries mapping unsigned long keys to StringTableString* values by the string data they point to, from greatest to least.</summary>
    /// <remarks>Acts as a comparison functor for HashSorter, enabling descending sorting based on the content of StringTableString* rather than their numeric keys.</remarks>
    public unsafe struct DescendingByData
    {
        // Methods
    }

    /// <summary>Compares and orders hash table entries by unsigned long key in decreasing order, enabling reverse‑key sorting within the HashSorter container.</summary>
    public unsafe struct DescendingByKey
    {
        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___HashSorterNode__uint___StringTableString_ptr m_list;

    // Methods
}

