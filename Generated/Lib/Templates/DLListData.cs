namespace ACBindings.Internal;


/// <summary>Represents a node within a doubly‑linked list, providing pointers to the next and previous elements for bidirectional navigation.</summary>
public unsafe struct DLListData
{
    // Members
    public ACBindings.Internal.DLListData* dllist_next;
    public ACBindings.Internal.DLListData* dllist_prev;

    // Methods
}

