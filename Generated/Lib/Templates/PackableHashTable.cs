namespace ACBindings.Internal;


/// <summary>Provides a hash table mapping AC1Legacy::PStringBase&lt;char&gt; keys to unsigned long values, optimized for packing and unpacking operations within the AC1Legacy system.</summary>
public unsafe struct PackableHashTable___AC1Legacy_PStringBase__sbyte__uint
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}


/// <summary>Stores SquelchInfo objects keyed by unsigned long, with support for packing and unpacking operations. Handles duplicate keys during deserialization based on a configurable flag.</summary>
public unsafe struct PackableHashTable__uint___SquelchInfo
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}


/// <summary>Associates unsigned long keys with Fellow objects via an internal hash table.</summary>
/// <remarks>Contains a PackObj member that provides packing and unpacking capabilities, and uses m_fThrowawayDuplicateKeysOnUnPack to decide whether duplicate keys are discarded during unpack operations. Maintains bucket pointers, table size, and current element count for efficient lookup.</remarks>
public unsafe struct PackableHashTable__uint___Fellow
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}


/// <summary>Provides a hash table mapping unsigned long keys to long values, optimized for packing and unpacking operations with efficient key lookup and controlled duplicate handling.</summary>
public unsafe struct PackableHashTable__uint__int
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}


/// <summary>Associates unique identifiers with guest information, enabling efficient lookup and serialization within the system.</summary>
public unsafe struct PackableHashTable__uint___GuestInfo
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}


/// <summary>
/// Maintains a hash table mapping unsigned long identifiers to CContractTracker objects, enabling fast lookup and serialization through PackObj. Duplicate key entries are discarded during unpacking when the throwaway flag is enabled.
/// </summary>
public unsafe struct PackableHashTable__uint___CContractTracker
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}


/// <summary>Stores BodyPart objects indexed by 32‑bit integer keys, using an internal hash table that integrates with PackObj to facilitate efficient packing and unpacking of the entries.</summary>
public unsafe struct PackableHashTable__int___BodyPart
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}


/// <summary>Hash table implementation specialized for unsigned long keys mapping to SpellBookPage values, facilitating fast lookup and insertion of spellbook pages during runtime.</summary>
public unsafe struct PackableHashTable__uint___SpellBookPage
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}


/// <summary>
/// Maintains key-value associations between unsigned long identifiers and lists of EmoteSet instances, while providing packing functionality through an embedded PackObj.
/// </summary>
public unsafe struct PackableHashTable__uint___PackableList___EmoteSet
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}


/// <summary>Maintains a hash table mapping unsigned long keys to GeneratorRegistryNode entries that supports packing and unpacking via PackObj. The structure tracks bucket storage, table size, current element count, and optionally suppresses duplicate key insertion during unpack.</summary>
public unsafe struct PackableHashTable__uint___GeneratorRegistryNode
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}


/// <summary>
/// Maps unsigned long identifiers to SkillBase objects using a hash table, providing efficient lookup and supporting serialization through PackObj.
/// </summary>
/// <remarks>
/// Maintains an array of buckets, tracks the current number of entries and total table size, and offers an option to ignore duplicate keys during unpacking.
/// </remarks>
public unsafe struct PackableHashTable__uint___SkillBase
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}


/// <summary>Maintains a hash table mapping unsigned long keys to CContract objects, supporting serialization via PackObj and configurable duplicate‑key handling during unpacking.</summary>
public unsafe struct PackableHashTable__uint___CContract
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}


/// <summary>Maps 32‑bit data identifiers to long integer values in a hash table designed for efficient lookup and binary packing.</summary>
public unsafe struct PackableHashTable___IDClass____tagDataID__int
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable__uint__uint
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable__uint___PackableList__uint
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable__uint__double
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable__uint___AC1Legacy_PStringBase__sbyte
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable__uint__long
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable__uint___IDClass____tagDataID
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable___AC1Legacy_CaseInsensitiveStringBase___AC1Legacy_PStringBase__sbyte___QuestProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable__uint___Position
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable__uint___Skill
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable__uint___CSpellBase
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable__uint___SpellComponentBase
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable___IDClass____tagDataID___ClothingBase
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable__uint___CloPaletteTemplate
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable___AC1Legacy_CaseInsensitiveStringBase___AC1Legacy_PStringBase__sbyte___AC1Legacy_PStringBase__sbyte
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable___AC1Legacy_PStringBase__sbyte___ChatEmoteData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

public unsafe struct PackableHashTable___AC1Legacy_CaseInsensitiveStringBase___AC1Legacy_PStringBase__sbyte___QuestDef
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public int m_fThrowawayDuplicateKeysOnUnPack;
    public System.IntPtr _buckets;
    public uint _table_size;
    public uint _currNum;

    // Methods
}

