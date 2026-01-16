namespace ACBindings.Internal;


/// <summary>Facilitates item exchange between two participants by maintaining separate inventories for each side, tracking trade status, timestamps, and acceptance flags.</summary>
public unsafe struct Trade
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Trade_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Trade*, void> Trade_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Trade*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Trade*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Trade*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableList___ContentProfile _self_list;
    public ACBindings.Internal.PackableList___ContentProfile _partner_list;
    public uint _partner;
    public double _stamp;
    public uint _status;
    public int _initiator;
    public int _accepted;
    public int _p_accepted;

    // Generated Constructor
    public Trade() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Registers a trade with the given partner ID and timestamp, setting the trade status to initialized.
    /// <code>Offset: 0x005BB030
    /// int __thiscall Trade::Register(Trade*,unsigned int,long double)</code>
    /// </summary>
    /// <param name="partner">The identifier of the trade partner; must be non‑zero for registration to succeed.</param>
    /// <param name="stamp">Timestamp indicating when the trade is registered.</param>
    /// <returns>Non‑zero (1) if the registration succeeds; zero if an invalid partner ID is supplied.</returns>
    public int Register(uint partner, double stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint, double, int>)0x005BB030)(ref this, partner, stamp);

    /// <summary>Computes the total serialized size for a trade, combining the sizes of the local and partner content profile lists with protocol overhead.
    /// <code>Offset: 0x005BB060
    /// unsigned int __thiscall Trade::GetPackSize(Trade*)</code>
    /// </summary>
    /// <returns>The number of bytes required to transmit the trade data.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint>)0x005BB060)(ref this);

    /// <summary>Checks if the partner's trading list contains the specified item.
    /// <code>Offset: 0x005BB0E0
    /// int __thiscall Trade::IsPartnerTradingItem(Trade*,unsigned int)</code>
    /// </summary>
    /// <param name="item">The identifier of the item to look for in the partner's trade list.</param>
    /// <returns>Non-zero (true) when the item is present; zero (false) otherwise.</returns>
    public int IsPartnerTradingItem(uint item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint, int>)0x005BB0E0)(ref this, item);

    /// <summary>Serializes the trade object's state into a buffer and returns the number of bytes required.
    /// <code>Offset: 0x005BB130
    /// unsigned int __thiscall Trade::Pack(Trade*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer where packed data will be written; updated to point after the last byte written.</param>
    /// <param name="size">Size in bytes of the buffer at *addr. Packing proceeds only if this size is sufficient.</param>
    /// <returns>Number of bytes needed to pack the trade object, including its content lists.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, void**, uint, uint>)0x005BB130)(ref this, addr, size);

    /// <summary>Gets the number of valid items the local participant has placed into the trade.
    /// <code>Offset: 0x005BB1C0
    /// unsigned int __thiscall Trade::GetNumItems(Trade*)</code>
    /// </summary>
    /// <returns>The quantity of items currently stored in the trade’s personal item list.</returns>
    public uint GetNumItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint>)0x005BB1C0)(ref this);

    /// <summary>Counts and returns the number of containers within the caller’s self list that contain data.
    /// <code>Offset: 0x005BB1E0
    /// unsigned int __thiscall Trade::GetNumContainers(Trade*)</code>
    /// </summary>
    /// <returns>The count of non‑empty container entries in the trade’s self list.</returns>
    public uint GetNumContainers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint>)0x005BB1E0)(ref this);

    /// <summary>Returns the count of partner items currently present in the trade.
    /// <code>Offset: 0x005BB200
    /// unsigned int __thiscall Trade::GetNumPartnerItems(Trade*)</code>
    /// </summary>
    /// <returns>The number of partner items in the partner list that are not marked as removed or inactive.</returns>
    public uint GetNumPartnerItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint>)0x005BB200)(ref this);

    /// <summary>Returns the number of partner containers currently present in the trade's partner list.
    /// <code>Offset: 0x005BB220
    /// unsigned int __thiscall Trade::GetNumPartnerContainers(Trade*)</code>
    /// </summary>
    /// <returns>The count of partner containers that contain valid data.</returns>
    public uint GetNumPartnerContainers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint>)0x005BB220)(ref this);

    /// <summary>Adds an item to the trade list at the specified position if it does not already exist and there is available space.
    /// <code>Offset: 0x005BB2F0
    /// int __stdcall Trade::AddItem(unsigned int,_DWORD*,int)</code>
    /// </summary>
    /// <param name="iid">The unique identifier of the content profile to add.</param>
    /// <param name="a2">Pointer to the packable list representing the trade's current items.</param>
    /// <param name="a3">Index at which to insert the new item within the list.</param>
    /// <returns>1 if the item was added successfully; 0 otherwise (e.g., invalid ID, duplicate, or capacity exceeded).</returns>
    public static int AddItem(uint iid, int* a2, int a3) => ((delegate* unmanaged[Stdcall]<uint, int*, int, int>)0x005BB2F0)(iid, a2, a3);

    /// <summary>Adds an item to the trade inventory for a specified participant while preventing duplicate entries on that side of the trade.
    /// <code>Offset: 0x005BB450
    /// int __thiscall Trade::AddItem(Trade*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="item">Identifier of the content profile to add.</param>
    /// <param name="id">Side indicator: 1 denotes the partner side, 2 denotes the initiating party’s side.</param>
    /// <param name="loc">Position or slot index within the participant's list where the item should be inserted.</param>
    /// <returns>Non‑zero if the item was added successfully; zero if the item already exists on that side or the id is invalid.</returns>
    public int AddItem(uint item, uint id, uint loc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint, uint, uint, int>)0x005BB450)(ref this, item, id, loc);

    /// <summary>Removes an item from a trade list identified by the given id. The function deletes the specified item from either the initiator’s or partner’s list, depending on whether id is 1 or 2.
    /// <code>Offset: 0x005BB4E0
    /// int __thiscall Trade::RemoveItem(Trade*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="item">The identifier of the item to remove.</param>
    /// <param name="id">Specifies which party’s list to modify: 1 for the initiator’s list, 2 for the partner’s list.</param>
    /// <returns>Non‑zero if the item was successfully removed; zero otherwise.</returns>
    public int RemoveItem(uint item, uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint, uint, int>)0x005BB4E0)(ref this, item, id);

    /// <summary>Resets trade state by clearing the participant content profile lists and resetting acceptance flags.
    /// <code>Offset: 0x005BB570
    /// int __thiscall Trade::Reset(Trade*)</code>
    /// </summary>
    /// <returns>An integer indicating successful reset, always 1.</returns>
    public int Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, int>)0x005BB570)(ref this);

    /// <summary>Deserializes a Trade object from the supplied buffer, reading its fields and delegating list deserialization to _self_list and _partner_list.
    /// <code>Offset: 0x005BB5A0
    /// int __thiscall Trade::UnPack(Trade*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the buffer; updated as data is consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer before this call.</param>
    /// <returns>Non‑zero on successful unpacking of all fields and lists; zero if the buffer is too small or an error occurs.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, void**, uint, int>)0x005BB5A0)(ref this, addr, size);

    /// <summary>Initializes a new trade instance by resetting all lists, status flags, timestamps, and partner information to their default values.
    /// <code>Offset: 0x005BB6A0
    /// void __thiscall Trade::Trade(Trade*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, void>)0x005BB6A0)(ref this);
}

