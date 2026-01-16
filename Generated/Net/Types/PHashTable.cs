namespace ACBindings.Internal;


/// <summary>Provides an aligned hash table mapping unsigned long keys to unsigned long values, incorporating stream packing capabilities for efficient serialization and memory access.</summary>
public unsafe struct PHashTable__uint__uint
{
    // Base Classes
    public ACBindings.Internal.HashTable__uint__uint BaseClass_HashTable; // ACBindings.Internal.HashTable__uint__uint
    public ACBindings.Internal.StreamPackObj BaseClass_StreamPackObj; // ACBindings.Internal.StreamPackObj

    // Methods
}


/// <summary>PHashTable holds a hash table mapping unsigned long keys to unsigned char values, leveraging serialization capabilities through its StreamPackObj base class.</summary>
public unsafe struct PHashTable__uint__byte
{
    // Base Classes
    public ACBindings.Internal.HashTable__uint__byte BaseClass_HashTable; // ACBindings.Internal.HashTable__uint__byte
    public ACBindings.Internal.StreamPackObj BaseClass_StreamPackObj; // ACBindings.Internal.StreamPackObj

    // Methods
}

public unsafe struct PHashTable__uint___SpellSet
{
    // Base Classes
    public ACBindings.Internal.HashTable__uint___SpellSet BaseClass_HashTable; // ACBindings.Internal.HashTable__uint___SpellSet
    public ACBindings.Internal.StreamPackObj BaseClass_StreamPackObj; // ACBindings.Internal.StreamPackObj

    // Methods
}

