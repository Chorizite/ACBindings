namespace ACBindings.Internal;

public unsafe struct IDListNode
{
    // Members
    public uint id;
    public ACBindings.Internal.IDListNode* prev;
    public ACBindings.Internal.IDListNode* next;

    // Methods
}

