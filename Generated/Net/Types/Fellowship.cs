namespace ACBindings.Internal;


/// <summary>Manages a collection of fellow members within the system, tracking membership, leadership, experience sharing settings, and departure history.</summary>
public unsafe struct Fellowship : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Fellowship_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellowship*, void> Fellowship_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellowship*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellowship*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellowship*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable__uint___Fellow _fellowship_table;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public uint _leader;
    public int _share_xp;
    public int _even_xp_split;
    public int _open_fellow;
    public int _locked;
    public ACBindings.Internal.PackableHashTable__uint__int _fellows_departed;

    // Generated Constructor
    public Fellowship(ACBindings.Internal.Fellowship* that) {
        _ConstructorInternal(that);
    }
    public Fellowship() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// Retrieves the Fellow corresponding to the given ID from the fellowship's hash table; returns nullptr if not found.
    /// 
    /// <code>Offset: 0x0048EDA0
    /// Fellow* __thiscall Fellowship::GetFellow(Fellowship*,unsigned int)</code>
    /// </summary>
    /// <param name="fellow">The unique identifier of the fellow to locate.</param>
    /// <returns>A pointer to the Fellow, or nullptr when no entry matches the provided ID.</returns>
    public ACBindings.Internal.Fellow* GetFellow(uint fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, ACBindings.Internal.Fellow*>)0x0048EDA0)(ref this, fellow);

    /// <summary>Destroys a Fellowship object by clearing its member hash tables, releasing any allocated buffers for the fellowship table and departed fellows list, decrementing the reference count of the name string buffer, and resetting all internal state to safe defaults.
    /// <code>Offset: 0x0056AA40
    /// void __thiscall Fellowship::~Fellowship(Fellowship*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, void>)0x0056AA40)(ref this);

    /// <summary>Creates a new Fellowship by duplicating all members and tables from another Fellowship, including reference‑counted name storage.
    /// <code>Offset: 0x0056AAD0
    /// void __thiscall Fellowship::Fellowship(Fellowship*,const Fellowship*)</code>
    /// </summary>
    /// <param name="that">The Fellowship instance to copy data from.</param>
    public void _ConstructorInternal(ACBindings.Internal.Fellowship* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, ACBindings.Internal.Fellowship*, void>)0x0056AAD0)(ref this, that);

    /// <summary>Determines whether the fellowship has reached its maximum member limit of nine.
    /// <code>Offset: 0x005BA1B0
    /// int __thiscall Fellowship::IsFull(Fellowship*)</code>
    /// </summary>
    /// <returns>True (non‑zero) if the number of current members is at least nine; otherwise false.</returns>
    public int IsFull() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, int>)0x005BA1B0)(ref this);

    /// <summary>Checks if a fellow with the given ID exists in the fellowship's hash table.
    /// <code>Offset: 0x005BA1C0
    /// int __thiscall Fellowship::IsFellow(Fellowship*,unsigned int)</code>
    /// </summary>
    /// <param name="fellow">The unique identifier of the fellow to look for.</param>
    /// <returns>Non‑zero if the fellow is present; zero otherwise.</returns>
    public int IsFellow(uint fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, int>)0x005BA1C0)(ref this, fellow);

    /// <summary>Retrieves a fellow from the fellowship using its unique identifier and writes the result into the provided Fellow object.
    /// <code>Offset: 0x005BA210
    /// int __thiscall Fellowship::InqFellow(Fellowship*,unsigned int,Fellow*)</code>
    /// </summary>
    /// <param name="fellow">The unique identifier of the fellow to query.</param>
    /// <param name="retval">Pointer to a Fellow structure that receives the retrieved data if the query succeeds.</param>
    /// <returns>1 when the fellow is found and retval populated; 0 if no such fellow exists.</returns>
    public int InqFellow(uint fellow, ACBindings.Internal.Fellow* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, ACBindings.Internal.Fellow*, int>)0x005BA210)(ref this, fellow, retval);

    /// <summary>Computes the aggregate experience proportion of all fellows in the fellowship when XP sharing is active.
    /// <code>Offset: 0x005BA270
    /// unsigned int __thiscall Fellowship::CalculateExperienceProportionSum(Fellowship*)</code>
    /// </summary>
    /// <param name="this">The Fellowship instance whose members are evaluated.</param>
    /// <returns>The summed experience proportions of all fellows, or 0 if XP sharing is disabled.</returns>
    public uint CalculateExperienceProportionSum() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint>)0x005BA270)(ref this);

    /// <summary>Retrieves the level of the fellowship’s leader from its hash table, returning that value or –1 if the leader is not present.
    /// <code>Offset: 0x005BA2F0
    /// unsigned int __thiscall Fellowship::GetLeadersLevel(Fellowship*)</code>
    /// </summary>
    /// <returns>The leader’s level as an unsigned integer; returns –1 when the leader cannot be located in the table.</returns>
    public uint GetLeadersLevel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint>)0x005BA2F0)(ref this);

    /// <summary>Retrieves the identifier of a fellowship member that is not the leader.
    /// <code>Offset: 0x005BA340
    /// unsigned int __thiscall Fellowship::GetNonLeaderFellowID(Fellowship*)</code>
    /// </summary>
    /// <returns>The unique identifier of a non‑leader fellow, or zero if no such member exists.</returns>
    public uint GetNonLeaderFellowID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint>)0x005BA340)(ref this);

    /// <summary>Logs the removal of a fellowship member when the group is locked, updating the departure timestamp in the internal hash table.
    /// <code>Offset: 0x005BA3B0
    /// void __thiscall Fellowship::HandleLockedRemoveFellow(Fellowship*,unsigned int)</code>
    /// </summary>
    /// <param name="fellow_id">Identifier of the fellow to remove from the locked fellowship.</param>
    public void HandleLockedRemoveFellow(uint fellow_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, void>)0x005BA3B0)(ref this, fellow_id);

    /// <summary>Recalculates whether experience points should be divided evenly among fellowship members, updating the _even_xp_split flag according to shared‑XP status and level disparity between the leader and other fellows.
    /// <code>Offset: 0x005BA420
    /// void __thiscall Fellowship::RecalculateEvenXPSplitting(Fellowship*)</code>
    /// </summary>
    public void RecalculateEvenXPSplitting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, void>)0x005BA420)(ref this);

    /// <summary>Calculates the number of bytes needed to serialize the Fellowship object, accounting for its name, departed fellows, and current members, plus a fixed overhead.
    /// <code>Offset: 0x005BA4E0
    /// unsigned int __thiscall Fellowship::GetPackSize(Fellowship*)</code>
    /// </summary>
    /// <returns>The total byte count required for packing.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint>)0x005BA4E0)(ref this);

    /// <summary>Serializes the fellowship data into a contiguous memory block, writing tables and primitive fields sequentially.
    /// <code>Offset: 0x005BA530
    /// unsigned int __thiscall Fellowship::Pack(Fellowship*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; advanced as data is written.</param>
    /// <param name="size">Number of bytes available for packing; if insufficient, no data is written.</param>
    /// <returns>Required size in bytes for fully packing the fellowship object.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, void**, uint, uint>)0x005BA530)(ref this, addr, size);

    /// <summary>Adds the specified fellow to the fellowship if not locked or recently departed, then recalculates XP splitting.
    /// <code>Offset: 0x005BA5C0
    /// int __thiscall Fellowship::AddFellow(Fellowship*,unsigned int,const Fellow*)</code>
    /// </summary>
    /// <param name="fellow_id">Identifier for the fellow to add.</param>
    /// <param name="fellow">Pointer to the Fellow structure containing details of the member.</param>
    /// <returns>1 on success; 0 if addition failed due to lock or departure timing.</returns>
    public int AddFellow(uint fellow_id, ACBindings.Internal.Fellow* fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, ACBindings.Internal.Fellow*, int>)0x005BA5C0)(ref this, fellow_id, fellow);

    /// <summary>Deserializes a Fellowship object from the supplied buffer, filling its members and advancing the buffer pointer.
    /// <code>Offset: 0x005BA630
    /// int __thiscall Fellowship::UnPack(Fellowship*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a memory address that will be updated as data is consumed during unpacking.</param>
    /// <param name="size">Number of bytes remaining in the buffer; updated to reflect unused bytes after unpacking.</param>
    /// <returns>Non‑zero if all fields were successfully unpacked; zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, void**, uint, int>)0x005BA630)(ref this, addr, size);

    /// <summary>Removes a fellow identified by its ID from the fellowship, updating XP distribution and handling reference counts.
    /// <code>Offset: 0x005BA7C0
    /// int __thiscall Fellowship::RemoveFellow(Fellowship*,unsigned int)</code>
    /// </summary>
    /// <param name="fellow">The unique identifier of the fellow to remove from the group.</param>
    /// <returns>1 if the fellow was found and removed; otherwise 0.</returns>
    public int RemoveFellow(uint fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, int>)0x005BA7C0)(ref this, fellow);

    /// <summary>Updates the data for a fellowship member identified by <paramref name="fellow_id"/>; if no such member exists, adds it to the group.
    /// <code>Offset: 0x005BA870
    /// int __thiscall Fellowship::UpdateFellow(Fellowship*,unsigned int,const Fellow*)</code>
    /// </summary>
    /// <param name="fellow_id">Identifier of the member to be updated or added.</param>
    /// <param name="fellow">New information for the member, copied into the table when an existing entry is found.</param>
    /// <returns>Non‑zero if the operation succeeded (either by updating or adding); zero if the addition failed.</returns>
    public int UpdateFellow(uint fellow_id, ACBindings.Internal.Fellow* fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, ACBindings.Internal.Fellow*, int>)0x005BA870)(ref this, fellow_id, fellow);

    /// <summary>Initializes a new Fellowship instance, configuring internal hash tables, default name buffer, leader, experience sharing settings, and related state flags to their default values.
    /// <code>Offset: 0x005BA8E0
    /// void __thiscall Fellowship::Fellowship(Fellowship*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, void>)0x005BA8E0)(ref this);
}

