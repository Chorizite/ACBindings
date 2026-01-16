namespace ACBindings.Internal;


/// <summary>Node in a doubly linked list that stores an unsigned identifier and links to adjacent nodes.</summary>
public unsafe struct IDListNode
{
    // Members
    public uint id;
    public ACBindings.Internal.IDListNode* prev;
    public ACBindings.Internal.IDListNode* next;

    // Methods
}

