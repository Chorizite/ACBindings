namespace ACBindings.Internal;


/// <summary>Tracks an entity’s allegiance within the system, storing hierarchy details along with counts of total members and vassals for efficient reference.</summary>
public unsafe struct AllegianceProfile : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AllegianceProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceProfile*, void> AllegianceProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AllegianceHierarchy _allegiance;
    public uint _total_members;
    public uint _total_vassals;

    // Generated Constructor
    public AllegianceProfile() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys an AllegianceProfile instance, freeing its internal allegiance hierarchy and restoring the base class virtual function table.
    /// <code>Offset: 0x0055B160
    /// void __thiscall AllegianceProfile::~AllegianceProfile(AllegianceProfile*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, void>)0x0055B160)(ref this);

    /// <summary>Retrieves the current monarch of the allegiance and populates the supplied AllegianceData structure with that monarch’s information.
    /// <code>Offset: 0x005B7B70
    /// unsigned int __thiscall AllegianceProfile::GetMonarch(AllegianceProfile*,AllegianceData*)</code>
    /// </summary>
    /// <param name="retval">Receives the monarch’s AllegianceData; remains unchanged if no monarch is present.</param>
    /// <returns>The ID of the monarch, or 0 when the allegiance has no monarch.</returns>
    public uint GetMonarch(ACBindings.Internal.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, ACBindings.Internal.AllegianceData*, uint>)0x005B7B70)(ref this, retval);

    /// <summary>Fetches the patron data for a given allegiance member ID, populating the provided AllegianceData structure and returning the patron's identifier.
    /// <code>Offset: 0x005B7BA0
    /// unsigned int __thiscall AllegianceProfile::GetPatron(AllegianceProfile*,unsigned int,AllegianceData*)</code>
    /// </summary>
    /// <param name="id">The identifier of the member whose patron information is requested.</param>
    /// <param name="retval">A pointer to an AllegianceData object that will receive the patron's information on success.</param>
    /// <returns>The patron's ID if found; otherwise zero.</returns>
    public uint GetPatron(uint id, ACBindings.Internal.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, uint, ACBindings.Internal.AllegianceData*, uint>)0x005B7BA0)(ref this, id, retval);

    /// <summary>Retrieves the first vassal associated with a specified allegiance node and copies its data into the supplied AllegianceData structure.
    /// <code>Offset: 0x005B7BB0
    /// unsigned int __thiscall AllegianceProfile::GetFirstVassal(AllegianceProfile*,unsigned int,AllegianceData*)</code>
    /// </summary>
    /// <param name="id">Identifier of the target allegiance node whose first vassal is requested.</param>
    /// <param name="retval">Pointer to an AllegianceData instance that receives the vassal's information. Must not be null.</param>
    /// <returns>Returns the ID of the found vassal; zero if no vassal exists or the input id is invalid.</returns>
    public uint GetFirstVassal(uint id, ACBindings.Internal.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, uint, ACBindings.Internal.AllegianceData*, uint>)0x005B7BB0)(ref this, id, retval);

    /// <summary>Retrieves information about the following vassal in an allegiance hierarchy.
    /// <code>Offset: 0x005B7BC0
    /// unsigned int __thiscall AllegianceProfile::GetNextVassal(AllegianceProfile*,unsigned int,AllegianceData*)</code>
    /// </summary>
    /// <param name="vassal_id">Identifier of a vassal whose successor is requested.</param>
    /// <param name="retval">Pointer to an AllegianceData structure where data for the next vassal will be copied if found.</param>
    /// <returns>The ID of the next vassal, or 0 if no subsequent member exists or the search fails.</returns>
    public uint GetNextVassal(uint vassal_id, ACBindings.Internal.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, uint, ACBindings.Internal.AllegianceData*, uint>)0x005B7BC0)(ref this, vassal_id, retval);

    /// <summary>Retrieves data for the specified allegiance ID into the provided AllegianceData structure.
    /// <code>Offset: 0x005B7BD0
    /// int __thiscall AllegianceProfile::GetData(AllegianceProfile*,unsigned int,AllegianceData*)</code>
    /// </summary>
    /// <param name="id">Identifier of the member whose data is requested.</param>
    /// <param name="retval">Pointer to an AllegianceData object that will receive the retrieved information.</param>
    /// <returns>An integer status code; non‑zero indicates success, zero indicates failure or missing entry.</returns>
    public int GetData(uint id, ACBindings.Internal.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, uint, ACBindings.Internal.AllegianceData*, int>)0x005B7BD0)(ref this, id, retval);

    /// <summary>Computes the byte size required to store this allegiance’s pack data, adding a fixed overhead.
    /// <code>Offset: 0x005B7BE0
    /// unsigned int __thiscall AllegianceProfile::GetPackSize(AllegianceProfile*)</code>
    /// </summary>
    /// <returns>The total size in bytes of the pack object, including an 8‑byte header.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, uint>)0x005B7BE0)(ref this);

    /// <summary>Initializes an AllegianceProfile instance by setting up its base class virtual function table, constructing the allegiance hierarchy, and resetting member counts to zero.
    /// <code>Offset: 0x005B7C00
    /// void __thiscall AllegianceProfile::AllegianceProfile(AllegianceProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, void>)0x005B7C00)(ref this);

    /// <summary>Serializes an AllegianceProfile into a contiguous memory block by writing the member and vassal counts followed by the hierarchical data of its allegiance structure. Returns the total number of bytes required to represent this profile.
    /// <code>Offset: 0x005B7C30
    /// unsigned int __thiscall AllegianceProfile::Pack(AllegianceProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the buffer; will be advanced past the packed data if sufficient space is available.</param>
    /// <param name="size">Maximum number of bytes remaining in the buffer at the given address.</param>
    /// <returns>The size, in bytes, needed to pack this AllegianceProfile. If <paramref name="size"/> is insufficient, no data is written but the required size is still returned.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, void**, uint, uint>)0x005B7C30)(ref this, addr, size);

    /// <summary>Unpacks an AllegianceProfile from a serialized buffer, setting member counts and delegating hierarchy unpacking.
    /// <code>Offset: 0x005B7C80
    /// int __thiscall AllegianceProfile::UnPack(AllegianceProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current read position; advanced by the amount of data processed.</param>
    /// <param name="size">Number of bytes remaining in the buffer for unpacking.</param>
    /// <returns>Non‑zero if the profile was successfully unpacked; zero if insufficient data or an error occurs during unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, void**, uint, int>)0x005B7C80)(ref this, addr, size);
}

