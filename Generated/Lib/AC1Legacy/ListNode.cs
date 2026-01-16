namespace ACBindings.Internal.AC1Legacy;


/// <summary>Holds an unsigned int value within a doubly linked list node, providing next and previous pointers for traversal.</summary>
public unsafe struct ListNode__uint
{
    // Members
    public uint data;
    public System.IntPtr next;
    public System.IntPtr prev;

    // Methods
}


/// <summary>Links FriendData objects into a doubly linked list for efficient navigation, insertion, and deletion within AC1Legacy.</summary>
public unsafe struct ListNode___FriendData
{
    // Members
    public ACBindings.Internal.FriendData data;
    public System.IntPtr next;
    public System.IntPtr prev;

    // Methods
}


/// <summary>Encapsulates a SpellSetTierList within a doubly linked list node, providing next and previous pointers for efficient bidirectional traversal.</summary>
public unsafe struct ListNode___SpellSetTierList
{
    // Members
    public ACBindings.Internal.SpellSetTierList data;
    public System.IntPtr next;
    public System.IntPtr prev;

    // Methods
}


/// <summary>Represents a node in a doubly‑linked list that stores a string value. Provides forward and backward traversal links used by legacy AC1 components.</summary>
public unsafe struct ListNode___AC1Legacy_PStringBase__sbyte
{
    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte data;
    public System.IntPtr next;
    public System.IntPtr prev;

    // Methods
}

