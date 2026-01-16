namespace ACBindings.Internal;


/// <summary>Encapsulates a quest contract, storing identifiers, descriptive text, status flags, and positional data for NPCs and the quest area. Provides mechanisms to serialize and deserialize its contents for network transmission or persistent storage.</summary>
public unsafe struct CContract : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CContract_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CContract*, void> CContract_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CContract*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CContract*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CContract*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _version;
    public uint _contract_id;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _contract_name;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _description;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _description_progress;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name_npc_start;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name_npc_end;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _questflag_stamped;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _questflag_started;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _questflag_finished;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _questflag_progress;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _questflag_timer;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _questflag_repeat_time;
    public ACBindings.Internal.Position _location_npc_start;
    public ACBindings.Internal.Position _location_npc_end;
    public ACBindings.Internal.Position _location_quest_area;

    // Generated Constructor
    public CContract() {
        _ConstructorInternal();
    }
    public CContract(ACBindings.Internal.CContract* contract) {
        _ConstructorInternal(contract);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases all string buffers owned by the contract, decrementing their reference counts and freeing them when no longer referenced. Restores base class virtual table pointers to the default PackObj implementation.
    /// <code>Offset: 0x0059AA80
    /// void __thiscall CContract::~CContract(CContract*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContract, void>)0x0059AA80)(ref this);

    /// <summary>Creates a new contract instance, initializing metadata, string fields, and location data to their default empty values.
    /// <code>Offset: 0x0059AFE0
    /// void __thiscall CContract::CContract(CContract*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContract, void>)0x0059AFE0)(ref this);

    /// <summary>Creates a new contract by copying all data from the specified source contract, including identifiers, descriptive strings, quest flags, and positional information. The constructor increments reference counts for shared string buffers to maintain proper lifetime management.
    /// <code>Offset: 0x0059B140
    /// void __thiscall CContract::CContract(CContract*,const CContract*)</code>
    /// </summary>
    /// <param name="contract">The contract instance whose contents are copied into the new object.</param>
    public void _ConstructorInternal(ACBindings.Internal.CContract* contract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContract, ACBindings.Internal.CContract*, void>)0x0059B140)(ref this, contract);

    /// <summary>Calculates the number of bytes required to serialize a CContract instance into a buffer.
    /// <code>Offset: 0x0059B270
    /// unsigned int __thiscall CContract::GetPackSize(CContract*,const unsigned int)</code>
    /// </summary>
    /// <param name="version">Protocol or serialization format version (currently unused).</param>
    /// <returns>The total size, in bytes, needed to pack all contract fields—including strings and positional data—plus an 8‑byte header/footer.</returns>
    public uint GetPackSize(uint version) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContract, uint, uint>)0x0059B270)(ref this, version);

    /// <summary>Packs contract data into a contiguous buffer, writing fields such as ID, strings, and location coordinates sequentially if the supplied buffer is large enough.
    /// <code>Offset: 0x0059B390
    /// unsigned int __thiscall CContract::Pack(CContract*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of the destination buffer pointer; updated to point past the written data upon return.</param>
    /// <param name="size">Maximum number of bytes available in the buffer; packing proceeds only when this value meets or exceeds the required size.</param>
    /// <returns>Byte count needed to pack the contract. If the buffer is sufficient, packed data is written and the pointer advanced; otherwise no data is written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContract, void**, uint, uint>)0x0059B390)(ref this, addr, size);

    /// <summary>Deserializes a CContract from the provided buffer, populating its fields.
    /// <code>Offset: 0x0059B470
    /// int __thiscall CContract::UnPack(CContract*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to pointer pointing to start of packed data; updated as data is read.</param>
    /// <param name="size">Number of bytes available for unpacking.</param>
    /// <returns>Non‑zero if all fields were successfully unpacked; zero if the buffer was too small or a field failed to unpack.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContract, void**, uint, int>)0x0059B470)(ref this, addr, size);
}

