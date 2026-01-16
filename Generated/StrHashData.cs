namespace ACBindings.Internal;


/// <summary>Holds a string key and links to the next node in a hash table chain, facilitating efficient lookup of named entries.</summary>
public unsafe struct StrHashData
{
    // Members
    public ACBindings.Internal.StrHashData* hash_next;
    public sbyte* name;

    // Methods
}

