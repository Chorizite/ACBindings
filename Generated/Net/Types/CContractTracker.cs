namespace ACBindings.Internal;


/// <summary>Represents a game contract state with identifiers, stages, and timing information for completion and repetition, providing serialization support via packing and unpacking operations.</summary>
public unsafe struct CContractTracker
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CContractTracker_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CContractTracker*, void> CContractTracker_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CContractTracker*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CContractTracker*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CContractTracker*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _version;
    public uint _contract_id;
    public uint _contract_stage;
    public double _time_when_done;
    public double _time_when_repeats;
    public double _time_of_server_update;

    // Generated Constructor
    public CContractTracker() {
        _ConstructorInternal();
    }
    public CContractTracker(ACBindings.Internal.CContractTracker* contract) {
        _ConstructorInternal(contract);
    }

    // Methods

    /// <summary>Creates a new contract tracker, initializing all fields to zero and setting the virtual table pointer.
    /// <code>Offset: 0x0059A100
    /// void __thiscall CContractTracker::CContractTracker(CContractTracker*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTracker, void>)0x0059A100)(ref this);

    /// <summary>Creates a new contract tracker initialized with the values of an existing tracker.
    /// <code>Offset: 0x0059A130
    /// void __thiscall CContractTracker::CContractTracker(CContractTracker*,const CContractTracker*)</code>
    /// </summary>
    /// <param name="contract">The source tracker whose state is duplicated into the new instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.CContractTracker* contract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTracker, ACBindings.Internal.CContractTracker*, void>)0x0059A130)(ref this, contract);

    /// <summary>Packs contract tracker fields into a binary stream, advancing the destination pointer.
    /// <code>Offset: 0x0059A180
    /// unsigned int __thiscall CContractTracker::Pack(CContractTracker*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; after packing it points past the written data.</param>
    /// <param name="size">Maximum number of bytes available in the buffer. Packing occurs only when at least 28 bytes are available.</param>
    /// <returns>The size of the packed data, which is always 28 bytes regardless of whether the data was actually written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTracker, void**, uint, uint>)0x0059A180)(ref this, addr, size);

    /// <summary>Unpacks contract information from a serialized buffer into the CContractTracker instance.
    /// <code>Offset: 0x0059A1E0
    /// int __thiscall CContractTracker::UnPack(CContractTracker*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a buffer pointer; advanced past the read data on success.</param>
    /// <param name="size">Number of bytes available at *addr; must be at least 28 for valid unpacking.</param>
    /// <returns>1 if unpack succeeded, 0 otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTracker, void**, uint, int>)0x0059A1E0)(ref this, addr, size);
}

