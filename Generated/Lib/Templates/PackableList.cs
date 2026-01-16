namespace ACBindings.Internal;


/// <summary>Maintains a linked list of AdminAccountData objects, tracking head, tail, and element count for efficient packed data handling.</summary>
public unsafe struct PackableList___AdminAccountData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Adds the specified AdminAccountData item to the tail of the list, updating links and maintaining a reference count.
    /// <code>Offset: 0x006AEED0
    /// int __thiscall PackableList&lt;AdminAccountData&gt;::InsertTail(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the AdminAccountData object to insert.</param>
    /// <returns>The new total number of elements in the list after insertion.</returns>
    // int __thiscall PackableList<AdminAccountData>::InsertTail(_DWORD*,int) (template type method)

    /// <summary>Removes the first element from a PackableList of AdminAccountData objects, copies its contents into a provided destination, updates internal links, and frees the removed node.
    /// <code>Offset: 0x006AEFD0
    /// int __thiscall PackableList&lt;AdminAccountData&gt;::RemoveHead(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an AdminPlayerData (AdminAccountData) object that will receive the data of the removed head.</param>
    /// <returns>1 if an element was removed; 0 if the list is empty.</returns>
    // int __thiscall PackableList<AdminAccountData>::RemoveHead(_DWORD*,_DWORD*) (template type method)

    /// <summary>Empties the list, then decrements the reference count of the accountName buffer from the last removed element and releases it if that count reaches zero. Returns the remaining reference count or the result of the release callback.
    /// <code>Offset: 0x006AF0D0
    /// LONG __thiscall PackableList&lt;AdminAccountData&gt;::Flush(_DWORD*)</code>
    /// </summary>
    /// <returns>The updated reference count after decrementing, or the value returned by the release callback when the count becomes zero.</returns>
    // LONG __thiscall PackableList<AdminAccountData>::Flush(_DWORD*) (template type method)

    /// <summary>Unpacks a list of AdminAccountData objects from serialized data into this PackableList, first clearing any existing contents.
    /// <code>Offset: 0x006AF190
    /// int __thiscall PackableList&lt;AdminAccountData&gt;::UnPack(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Reference to a pointer positioned at the start of the data buffer; it is advanced as data is consumed during unpacking.</param>
    /// <param name="a3">Number of bytes remaining in the buffer that may be read for unpacking.</param>
    /// <returns>1 if the entire list was unpacked successfully, 0 otherwise (e.g., insufficient data or a parsing error).</returns>
    // int __thiscall PackableList<AdminAccountData>::UnPack(_DWORD*,void**,unsigned int) (template type method)
}


/// <summary>PackableList specialized for AdminPlayerData, storing elements in a packed linked structure with head, tail pointers and count of current entries.</summary>
public unsafe struct PackableList___AdminPlayerData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Inserts the specified admin player data into the tail of the packable list and returns the updated element count.
    /// <code>Offset: 0x006AEF50
    /// int __thiscall PackableList&lt;AdminPlayerData&gt;::InsertTail(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the AdminPlayerData instance to add to the list.</param>
    /// <returns>The new total number of elements in the list after insertion.</returns>
    // int __thiscall PackableList<AdminPlayerData>::InsertTail(_DWORD*,int) (template type method)

    /// <summary>Removes the first element from the list and copies its data into the supplied output parameter. Returns 1 if an element was removed; otherwise returns 0 when the list is empty.
    /// <code>Offset: 0x006AF050
    /// int __thiscall PackableList&lt;AdminPlayerData&gt;::RemoveHead(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Reference to an AdminPlayerData object that receives the data of the removed element.</param>
    /// <returns>1 if an element was successfully removed; 0 if the list was empty.</returns>
    // int __thiscall PackableList<AdminPlayerData>::RemoveHead(_DWORD*,_DWORD*) (template type method)

    /// <summary>Removes all entries from the packable list, releases associated resources, and updates the internal reference counter for the backing buffer.
    /// <code>Offset: 0x006AF130
    /// LONG __thiscall PackableList&lt;AdminPlayerData&gt;::Flush(_DWORD*)</code>
    /// </summary>
    /// <returns>The updated reference count after decrementing; zero indicates that the underlying buffer has been fully released.</returns>
    // LONG __thiscall PackableList<AdminPlayerData>::Flush(_DWORD*) (template type method)

    /// <summary>Unpacks a sequence of AdminPlayerData objects from the supplied byte buffer, clearing the current list first and inserting each successfully unpacked item at the tail.
    /// <code>Offset: 0x006AF260
    /// int __thiscall PackableList&lt;AdminPlayerData&gt;::UnPack(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Reference to a pointer that points to the beginning of the input data; it is advanced as bytes are consumed during unpacking.</param>
    /// <param name="a3">The number of bytes remaining in the buffer from the current position.</param>
    /// <returns>Non‑zero if all requested items were read and inserted successfully; zero if an error occurs or fewer items than expected are available.</returns>
    // int __thiscall PackableList<AdminPlayerData>::UnPack(_DWORD*,void**,unsigned int) (template type method)
}


/// <summary>Container for a collection of packable string objects, managing them as a linked list while maintaining the current element count.</summary>
public unsafe struct PackableList___AC1Legacy_PStringBase__sbyte
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Appends a string to the end of the list, incrementing its reference count and updating link pointers.
    /// <code>Offset: 0x006A5680
    /// int __thiscall PackableList&lt;AC1Legacy::PStringBase&lt;char&gt;&gt;::InsertTail(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the string object to be inserted into the list.</param>
    /// <returns>The updated number of elements in the list after insertion.</returns>
    // int __thiscall PackableList<AC1Legacy::PStringBase<char>>::InsertTail(_DWORD*,int*) (template type method)

    /// <summary>Serializes a list of strings into the supplied buffer, writing the element count followed by each string's packed form when enough space is available, and returns the total byte size required for serialization.
    /// <code>Offset: 0x006A6070
    /// unsigned int __thiscall PackableList&lt;AC1Legacy::PStringBase&lt;char&gt;&gt;::Pack(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Address of a pointer to the output buffer; advanced past written data upon return.</param>
    /// <param name="a3">Size in bytes of the destination buffer.</param>
    /// <returns>Number of bytes needed to serialize the entire list.</returns>
    // unsigned int __thiscall PackableList<AC1Legacy::PStringBase<char>>::Pack(_DWORD*,void**,unsigned int) (template type method)

    /// <summary>Computes the number of bytes required to serialize this PackableList of PStringBase&lt;char&gt; objects, including list header information.
    /// <code>Offset: 0x006A60C0
    /// int __thiscall PackableList&lt;AC1Legacy::PStringBase&lt;char&gt;&gt;::pack_size(_DWORD*)</code>
    /// </summary>
    /// <returns>The total size in bytes needed for packing the entire list.</returns>
    // int __thiscall PackableList<AC1Legacy::PStringBase<char>>::pack_size(_DWORD*) (template type method)

    /// <summary>Removes the first element from the list and updates internal pointers and reference counts.
    /// <code>Offset: 0x006A6100
    /// int __thiscall PackableList&lt;AC1Legacy::PStringBase&lt;char&gt;&gt;::RemoveHead(_DWORD*,volatile LONG**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a volatile LONG* that holds a reference to the current head node; updated to point to the new head after removal.</param>
    /// <returns>Non‑zero if an item was removed; zero if the list was empty.</returns>
    // int __thiscall PackableList<AC1Legacy::PStringBase<char>>::RemoveHead(_DWORD*,volatile LONG**) (template type method)

    /// <summary>Flushes all elements from the packable string list and decrements a global reference counter. When the counter reaches zero, a cleanup routine is invoked to release associated resources.
    /// <code>Offset: 0x006A61A0
    /// LONG __thiscall PackableList&lt;AC1Legacy::PStringBase&lt;char&gt;&gt;::Flush(_DWORD*)</code>
    /// </summary>
    /// <returns>The resulting reference count after flushing; zero indicates that cleanup has been performed.</returns>
    // LONG __thiscall PackableList<AC1Legacy::PStringBase<char>>::Flush(_DWORD*) (template type method)

    /// <summary>Unpacks a sequence of PStringBase objects from the supplied data buffer into this list.
    /// <code>Offset: 0x006A6200
    /// int __thiscall PackableList&lt;AC1Legacy::PStringBase&lt;char&gt;&gt;::UnPack(_DWORD*,int,unsigned int)</code>
    /// </summary>
    /// <param name="this">The PackableList instance to populate.</param>
    /// <param name="a2">Pointer to the serialized data buffer; advanced as items are read.</param>
    /// <param name="a3">Number of bytes remaining in the buffer.</param>
    /// <returns>1 if all items were successfully unpacked and inserted; 0 on failure or insufficient data.</returns>
    // int __thiscall PackableList<AC1Legacy::PStringBase<char>>::UnPack(_DWORD*,int,unsigned int) (template type method)
}


/// <summary>Represents a linked list of unsigned long values managed by PackObj, maintaining head and tail pointers along with an element count for efficient packing operations. Provides serialization support through alignment helpers.</summary>
public unsafe struct PackableList__uint
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods
}


/// <summary>Implements a linked list of HousePayment objects, leveraging the PackObj base class to provide packing and alignment support while keeping track of head, tail, and item count for efficient serialization.</summary>
public unsafe struct PackableList___HousePayment
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Removes the first element from a PackableList of HousePayment objects, copying its value into the supplied buffer and updating internal links.
    /// <code>Offset: 0x004A2CA0
    /// int __thiscall PackableList&lt;HousePayment&gt;::RemoveHead(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a HousePayment object where the removed payment data will be copied.</param>
    /// <returns>1 if an item was successfully removed; 0 if the list was empty.</returns>
    // int __thiscall PackableList<HousePayment>::RemoveHead(_DWORD*,_DWORD*) (template type method)

    /// <summary>Removes all HousePayment objects from the list, releasing each item and updating associated reference counters.
    /// <code>Offset: 0x004A2D40
    /// LONG __thiscall PackableList&lt;HousePayment&gt;::Flush(_DWORD*)</code>
    /// </summary>
    /// <returns>The resulting reference count after flushing; a value of zero indicates that all resources have been successfully released.</returns>
    // LONG __thiscall PackableList<HousePayment>::Flush(_DWORD*) (template type method)

    /// <summary>Unpacks a sequence of HousePayment objects from the supplied data stream into this PackableList, clearing any existing entries first.
    /// <code>Offset: 0x005BBE20
    /// int __thiscall PackableList&lt;HousePayment&gt;::UnPack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the packed data buffer; it is advanced as each item is read.</param>
    /// <param name="a3">Number of bytes remaining in the data buffer.</param>
    /// <returns>Non‑zero if all items were unpacked successfully; zero otherwise.</returns>
    // int __thiscall PackableList<HousePayment>::UnPack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>Calculates the total size in bytes required to serialize all HousePayment objects stored in this list.
    /// <code>Offset: 0x005CA8A0
    /// int __thiscall PackableList&lt;HousePayment&gt;::pack_size(_DWORD*)</code>
    /// </summary>
    /// <returns>The number of bytes needed to pack the entire list.</returns>
    // int __thiscall PackableList<HousePayment>::pack_size(_DWORD*) (template type method)
}


/// <summary>Maintains an ordered collection of SalvageResult objects, providing tail‑insertion, binary packing, unpacking, and automated cleanup of allocated nodes.</summary>
public unsafe struct PackableList___SalvageResult
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Packs the current list of salvage results into the provided buffer if sufficient space is available, otherwise only calculates the required byte count.
    /// <code>Offset: 0x005BBDD0
    /// unsigned int __thiscall PackableList&lt;SalvageResult&gt;::Pack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a buffer pointer that will receive packed data; it is advanced as items are written.</param>
    /// <param name="a3">Size of the remaining buffer in bytes. If this value is less than the required size, no data is written but the necessary size is still returned.</param>
    /// <returns>The total number of bytes that would be written to the buffer.</returns>
    // unsigned int __thiscall PackableList<SalvageResult>::Pack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>Clears all entries from the packable list, freeing allocated memory and resetting internal pointers.
    /// <code>Offset: 0x005CA8E0
    /// void __thiscall PackableList&lt;SalvageResult&gt;::Flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall PackableList<SalvageResult>::Flush(_DWORD*) (template type method)

    /// <summary>Destructs a PackableList of SalvageResult objects, flushing its contents and restoring base class vtables for proper cleanup.
    /// <code>Offset: 0x005CA930
    /// void __thiscall PackableList&lt;SalvageResult&gt;::~PackableList&lt;SalvageResult&gt;(void***)</code>
    /// </summary>
    // void __thiscall PackableList<SalvageResult>::~PackableList<SalvageResult>(void***) (template type method)

    /// <summary>Unpacks a sequence of SalvageResult objects from the supplied binary buffer into this list, clearing any existing entries first. The method reads an initial 32‑bit count and then deserializes each item until all expected entries are processed.
    /// <code>Offset: 0x005CA950
    /// int __thiscall PackableList&lt;SalvageResult&gt;::UnPack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the buffer containing serialized SalvageResult data; the function consumes bytes as it deserializes items.</param>
    /// <param name="a3">Size, in bytes, of the remaining data available in a2. At least four bytes must be present for the item count.</param>
    /// <returns>Non‑zero if all expected items were successfully unpacked (or zero items), otherwise zero indicating an incomplete or invalid stream.</returns>
    // int __thiscall PackableList<SalvageResult>::UnPack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>Appends a new SalvageResult node at the end of the packable list by allocating memory and copying data from the supplied source array, then increments and returns the list's element count.
    /// <code>Offset: 0x005CA9E0
    /// int __thiscall PackableList&lt;SalvageResult&gt;::InsertTail(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an array containing SalvageResult fields (indices 1‑4) to copy into the new node.</param>
    /// <returns>The updated number of elements in the list after insertion.</returns>
    // int __thiscall PackableList<SalvageResult>::InsertTail(_DWORD*,_DWORD*) (template type method)
}


/// <summary>Maintains a linked list of Enchantment objects, enabling fast insertion, removal, and serialization for use in game item effects. Acts as the primary container through which enchantments are added to or removed from items during gameplay and persistence operations.</summary>
public unsafe struct PackableList___Enchantment
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Packs the Enchantment list into a contiguous buffer, writing an optional header containing the item count when the depth limit allows. If the provided depth is less than the number of items, no data is written. The function always returns the total number of items in the list.
    /// <code>Offset: 0x004B8360
    /// unsigned int __thiscall PackableList&lt;Enchantment&gt;::Pack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the destination buffer; each packed element writes its data into *a2 and increments this pointer as data is produced.</param>
    /// <param name="a3">Maximum depth or item count allowed for packing. Only packs when a3 is greater than or equal to the list size; includes a header if a3 ≥ 4.</param>
    /// <returns>The total number of Enchantment items in the list.</returns>
    // unsigned int __thiscall PackableList<Enchantment>::Pack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>Deletes all nodes in the packable list, freeing each node’s memory and resetting internal pointers.
    /// <code>Offset: 0x004B86F0
    /// void* __thiscall PackableList&lt;Enchantment&gt;::Flush(_DWORD*)</code>
    /// </summary>
    /// <returns>A void* value derived from the updated element count after the list has been flushed.</returns>
    // void* __thiscall PackableList<Enchantment>::Flush(_DWORD*) (template type method)

    /// <summary>Unpacks Enchantment objects from a binary buffer into the list, clearing any existing contents first. Reads an item count and sequentially deserializes each Enchantment, adding them to the collection.
    /// <code>Offset: 0x004B8910
    /// int __thiscall PackableList&lt;Enchantment&gt;::UnPack(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the source buffer; the function advances this pointer as data is consumed during unpacking.</param>
    /// <param name="a3">Number of bytes remaining in the buffer that may be read for unpacking.</param>
    /// <returns>Nonzero if all expected items were successfully unpacked and added; zero on error or insufficient data.</returns>
    // int __thiscall PackableList<Enchantment>::UnPack(_DWORD*,void**,unsigned int) (template type method)

    /// <summary>Creates a new node from the provided enchantment, inserts it at the front of the packable list, and updates element count.
    /// <code>Offset: 0x00594BD0
    /// int __thiscall PackableList&lt;Enchantment&gt;::InsertHead(_DWORD*,Enchantment*)</code>
    /// </summary>
    /// <param name="this">Reference to the PackableList instance.</param>
    /// <param name="that">Enchantment object to copy into the list.</param>
    /// <returns>The updated total number of elements in the list after insertion.</returns>
    // int __thiscall PackableList<Enchantment>::InsertHead(_DWORD*,Enchantment*) (template type method)

    /// <summary>Removes the specified enchantment from the list if present. Returns non‑zero on success, zero when the enchantment is not found.
    /// <code>Offset: 0x00595030
    /// int __thiscall PackableList&lt;Enchantment&gt;::Remove(_DWORD*,Enchantment*)</code>
    /// </summary>
    /// <param name="rhs">The enchantment to remove.</param>
    /// <returns>Non‑zero if removal succeeded; otherwise zero.</returns>
    // int __thiscall PackableList<Enchantment>::Remove(_DWORD*,Enchantment*) (template type method)
}


/// <summary>Maintains an ordered collection of GeneratorProfile objects with a linked‑list structure, tracking head, tail, and element count for efficient traversal.</summary>
public unsafe struct PackableList___GeneratorProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Adds a generator profile to the end of the packable list, allocating and linking a new node while updating head/tail pointers and element count.
    /// <code>Offset: 0x005D10C0
    /// int __thiscall PackableList&lt;GeneratorProfile&gt;::InsertTail(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the data representing the generator profile to append.</param>
    /// <returns>The updated number of elements in the list after insertion.</returns>
    // int __thiscall PackableList<GeneratorProfile>::InsertTail(_DWORD*,_DWORD*) (template type method)

    /// <summary>Packs the contents of the GeneratorProfile list into a provided buffer if space permits, returning the total size required.
    /// <code>Offset: 0x005D1120
    /// unsigned int __thiscall PackableList&lt;GeneratorProfile&gt;::Pack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the current write position in the output buffer; advanced as data is written.</param>
    /// <param name="a3">Number of bytes remaining in the buffer; determines whether packing can occur.</param>
    /// <returns>The total number of bytes needed to pack the list, regardless of actual writing.</returns>
    // unsigned int __thiscall PackableList<GeneratorProfile>::Pack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>Computes total byte count needed to serialize the list of generator profiles, accounting for a 4‑byte header and each element’s individual pack size.
    /// <code>Offset: 0x005D1170
    /// int __thiscall PackableList&lt;GeneratorProfile&gt;::pack_size(_DWORD*)</code>
    /// </summary>
    /// <returns>The cumulative size in bytes required to pack the entire list.</returns>
    // int __thiscall PackableList<GeneratorProfile>::pack_size(_DWORD*) (template type method)

    /// <summary>Removes all generator profiles from the list, freeing each node’s resources and resetting the element count to zero.
    /// <code>Offset: 0x005D11B0
    /// void __thiscall PackableList&lt;GeneratorProfile&gt;::Flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall PackableList<GeneratorProfile>::Flush(_DWORD*) (template type method)

    /// <summary>Deserializes a sequence of GeneratorProfile objects from the provided buffer into this list, clearing any existing entries before populating.
    /// <code>Offset: 0x005D1230
    /// int __thiscall PackableList&lt;GeneratorProfile&gt;::UnPack(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the current position in the data buffer; advanced as each profile is unpacked.</param>
    /// <param name="a3">Number of bytes remaining in the buffer.</param>
    /// <returns>Non‑zero if all requested profiles were unpacked successfully; zero on error or insufficient data.</returns>
    // int __thiscall PackableList<GeneratorProfile>::UnPack(_DWORD*,void**,unsigned int) (template type method)
}


/// <summary>
/// Stores and manages a chain of generator queue nodes, providing tail insertion, bulk unpacking from serialized data, and cleanup while maintaining head/tail pointers and node count for efficient runtime list operations.
/// </summary>
public unsafe struct PackableList___GeneratorQueueNode
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Inserts a copy of the specified queue node at the tail of the packable list and updates internal pointers.
    /// <code>Offset: 0x005D16E0
    /// int __thiscall PackableList&lt;GeneratorQueueNode&gt;::InsertTail(_DWORD*,GeneratorQueueNode*)</code>
    /// </summary>
    /// <param name="rhs">The generator queue node to append.</param>
    /// <returns>The updated number of nodes in the list after insertion.</returns>
    // int __thiscall PackableList<GeneratorQueueNode>::InsertTail(_DWORD*,GeneratorQueueNode*) (template type method)

    /// <summary>Removes all items from the list, freeing each node and resetting the internal state.
    /// <code>Offset: 0x005D1750
    /// void __thiscall PackableList&lt;GeneratorQueueNode&gt;::Flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall PackableList<GeneratorQueueNode>::Flush(_DWORD*) (template type method)

    /// <summary>Unpacks a serialized sequence of GeneratorQueueNode objects into the list, replacing any existing contents.
    /// <code>Offset: 0x005D17C0
    /// int __thiscall PackableList&lt;GeneratorQueueNode&gt;::UnPack(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">The PackableList instance to populate.</param>
    /// <param name="bufferPtr">Pointer to the buffer location from which node data will be read; advances as data is consumed.</param>
    /// <param name="size">Remaining size of the data stream in bytes.</param>
    /// <returns>Non‑zero if all nodes were unpacked successfully; zero if insufficient data or an unpack error occurs.</returns>
    // int __thiscall PackableList<GeneratorQueueNode>::UnPack(_DWORD*,void**,unsigned int) (template type method)
}


/// <summary>Maintains an ordered collection of InventoryPlacement entries in a doubly‑linked list, providing efficient insertion, deletion, and serialization support for network or file persistence.</summary>
public unsafe struct PackableList___InventoryPlacement
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Inserts a new inventory placement node at the tail of the list and returns the updated total count.
    /// <code>Offset: 0x00558850
    /// int __thiscall PackableList&lt;InventoryPlacement&gt;::InsertTail(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an InventoryPlacement structure whose data will be copied into the newly created node.</param>
    /// <returns>The number of placements in the list after insertion.</returns>
    // int __thiscall PackableList<InventoryPlacement>::InsertTail(_DWORD*,_DWORD*) (template type method)

    /// <summary>Cleans the packable list of inventory placements by freeing each node and resetting head, tail, and item count to zero.
    /// <code>Offset: 0x0055A0C0
    /// void __thiscall PackableList&lt;InventoryPlacement&gt;::Flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall PackableList<InventoryPlacement>::Flush(_DWORD*) (template type method)

    /// <summary>Serializes an InventoryPlacement PackableList into a buffer when sufficient space is available; otherwise only reports the required size.
    /// <code>Offset: 0x0055F420
    /// unsigned int __thiscall PackableList&lt;InventoryPlacement&gt;::Pack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the current position in the output buffer; data will be written here and the pointer advanced.</param>
    /// <param name="a3">Number of bytes remaining in the buffer for this serialization operation.</param>
    /// <returns>The total byte count needed to fully serialize the list, regardless of whether any data was actually written.</returns>
    // unsigned int __thiscall PackableList<InventoryPlacement>::Pack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>Unpacks serialized inventory placements from a memory buffer and populates the list with them.
    /// <code>Offset: 0x005610F0
    /// int __thiscall PackableList&lt;InventoryPlacement&gt;::UnPack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the source data buffer that will be advanced as items are read.</param>
    /// <param name="a3">Size of the remaining data in the buffer, expressed in bytes.</param>
    /// <returns>Non‑zero if all expected items were unpacked successfully; zero if an error occurs or insufficient data is available.</returns>
    // int __thiscall PackableList<InventoryPlacement>::UnPack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>Inserts a new inventory placement into the list at the specified zero‑based index. If the index exceeds the current size, the node is appended to the end. The function allocates a new node, copies three data fields from the supplied array, and links it into the doubly‑linked list.
    /// <code>Offset: 0x0058DDC0
    /// int __thiscall PackableList&lt;InventoryPlacement&gt;::InsertPos(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">The index at which to insert the new node.</param>
    /// <param name="a3">Pointer to an array containing the placement data (three consecutive values) that will be stored in the new node.</param>
    /// <returns>The index where the node was inserted, or the previous list size if it was appended to the end. Returns 0 when inserting into an empty list.</returns>
    // int __thiscall PackableList<InventoryPlacement>::InsertPos(_DWORD*,int,_DWORD*) (template type method)

    /// <summary>Removes an InventoryPlacement from the packable list that matches the key provided in the second argument, copying the removed node’s fields into that buffer and updating internal links.
    /// <code>Offset: 0x0058E2D0
    /// int __thiscall PackableList&lt;InventoryPlacement&gt;::Remove(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Buffer containing the lookup key at indices 1 and 2; on success receives the removed node’s data.</param>
    /// <returns>1 if a matching item was found and removed; 0 otherwise.</returns>
    // int __thiscall PackableList<InventoryPlacement>::Remove(_DWORD*,_DWORD*) (template type method)

    /// <summary>Calculates the total number of bytes required to serialize the inventory placement list, including a 4‑byte header and the packed size of each element.
    /// <code>Offset: 0x005D16A0
    /// int __thiscall PackableList&lt;InventoryPlacement&gt;::pack_size(_DWORD*)</code>
    /// </summary>
    /// <returns>The cumulative byte count needed for packing.</returns>
    // int __thiscall PackableList<InventoryPlacement>::pack_size(_DWORD*) (template type method)
}


/// <summary>Represents a dynamic collection of ItemProfile objects that supports serialization, maintaining head and tail references along with an element count.</summary>
/// <remarks>Provides insertion at the head or tail, removal by value or from the tail, and pack/unpack functionality for persistence or transmission.</remarks>
public unsafe struct PackableList___ItemProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Inserts a copy of the specified ItemProfile at the beginning of the PackableList, updating head and tail accordingly.
    /// <code>Offset: 0x004C14C0
    /// int __thiscall PackableList&lt;ItemProfile&gt;::InsertHead(_DWORD*,ItemProfile*)</code>
    /// </summary>
    /// <param name="rhs">The ItemProfile to insert as the new head element.</param>
    /// <returns>The updated item count after insertion.</returns>
    // int __thiscall PackableList<ItemProfile>::InsertHead(_DWORD*,ItemProfile*) (template type method)

    /// <summary>Appends a copy of an ItemProfile to the end of the list, updating head/tail links and returning the new item count.
    /// <code>Offset: 0x004C1520
    /// int __thiscall PackableList&lt;ItemProfile&gt;::InsertTail(_DWORD*,ItemProfile*)</code>
    /// </summary>
    /// <param name="rhs">The ItemProfile instance whose data is copied into the newly created node.</param>
    /// <returns>The updated number of items in the PackableList after insertion.</returns>
    // int __thiscall PackableList<ItemProfile>::InsertTail(_DWORD*,ItemProfile*) (template type method)

    /// <summary>Removes the tail ItemProfile from the list, copies it into the supplied buffer, deletes the original node, updates internal pointers, and decrements the element count.
    /// <code>Offset: 0x004C1B60
    /// int __thiscall PackableList&lt;ItemProfile&gt;::RemoveTail(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="this">The PackableList instance on which to perform the removal.</param>
    /// <param name="a2">Pointer where the removed ItemProfile will be copied.</param>
    /// <returns>1 if an item was successfully removed; 0 if the list is empty.</returns>
    // int __thiscall PackableList<ItemProfile>::RemoveTail(_DWORD*,_DWORD*) (template type method)

    /// <summary>Removes an ItemProfile from the PackableList that equals the specified profile, unlinking it from the internal list and freeing its resources.
    /// <code>Offset: 0x004C1BC0
    /// int __thiscall PackableList&lt;ItemProfile&gt;::Remove(_DWORD*,ItemProfile*)</code>
    /// </summary>
    /// <param name="rhs">The ItemProfile instance to match for removal.</param>
    /// <returns>1 if a matching item was found and removed; otherwise 0.</returns>
    // int __thiscall PackableList<ItemProfile>::Remove(_DWORD*,ItemProfile*) (template type method)

    /// <summary>Clears the list by destroying and deallocating every contained ItemProfile, resetting internal pointers and count.
    /// <code>Offset: 0x004C1CA0
    /// void __thiscall PackableList&lt;ItemProfile&gt;::Flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall PackableList<ItemProfile>::Flush(_DWORD*) (template type method)

    /// <summary>Deserializes ItemProfile objects from the supplied byte stream into this list.
    /// <code>Offset: 0x004C1D10
    /// int __thiscall PackableList&lt;ItemProfile&gt;::UnPack(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Reference to a pointer that marks the current position in the input buffer; advanced as items are read.</param>
    /// <param name="a3">Number of bytes remaining in the input buffer.</param>
    /// <returns>1 if all items were unpacked successfully; 0 on failure (e.g., insufficient data or unpack error).</returns>
    // int __thiscall PackableList<ItemProfile>::UnPack(_DWORD*,void**,unsigned int) (template type method)
}


/// <summary>Maintains an ordered collection of ContentProfile objects, supporting insertion, removal, search, and serialization operations.</summary>
public unsafe struct PackableList___ContentProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Packs the contents of this PackableList into a contiguous array starting at *a2 when sufficient space (a3) is available, returning the total number of bytes required.
    /// <code>Offset: 0x0055B4A0
    /// unsigned int __thiscall PackableList&lt;ContentProfile&gt;::Pack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the buffer where packed data will be written; the pointer is advanced past each written element.</param>
    /// <param name="a3">Maximum number of bytes that may be written into the buffer. If this value is less than the required pack size, packing is skipped but the function still returns the needed size.</param>
    /// <returns>Number of bytes necessary to pack the entire list, regardless of whether the actual write occurred.</returns>
    // unsigned int __thiscall PackableList<ContentProfile>::Pack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>Computes total byte size needed to serialize the content profile list, including a header and all elements.
    /// <code>Offset: 0x0055B4F0
    /// int __thiscall PackableList&lt;ContentProfile&gt;::pack_size(_DWORD*)</code>
    /// </summary>
    /// <returns>The cumulative size in bytes required for packing the entire list.</returns>
    // int __thiscall PackableList<ContentProfile>::pack_size(_DWORD*) (template type method)

    /// <summary>Inserts a new ContentProfile at the tail of the list, initializing it with data supplied via the second argument.
    /// <code>Offset: 0x0055B5E0
    /// int __thiscall PackableList&lt;ContentProfile&gt;::InsertTail(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a struct containing profile information; values located at offsets 4 and 8 are copied into the new node.</param>
    /// <returns>The updated number of elements in the list after insertion.</returns>
    // int __thiscall PackableList<ContentProfile>::InsertTail(_DWORD*,int) (template type method)

    /// <summary>Removes all elements from the packable list, deallocating each node and updating internal counters.
    /// <code>Offset: 0x0055B780
    /// void*** __thiscall PackableList&lt;ContentProfile&gt;::Flush(_DWORD*)</code>
    /// </summary>
    /// <returns>A null pointer indicating the list has been emptied after flushing.</returns>
    // void*** __thiscall PackableList<ContentProfile>::Flush(_DWORD*) (template type method)

    /// <summary>Destroys a PackableList of ContentProfile objects by clearing all stored items and resetting its virtual function table.
    /// <code>Offset: 0x0055BC00
    /// void*** __thiscall PackableList&lt;ContentProfile&gt;::~PackableList&lt;ContentProfile&gt;(void***)</code>
    /// </summary>
    // void*** __thiscall PackableList<ContentProfile>::~PackableList<ContentProfile>(void***) (template type method)

    /// <summary>Replaces this PackableList's contents with ContentProfile objects read from the supplied buffer, which begins with a 32‑bit count of items to unpack.
    /// <code>Offset: 0x0055BC20
    /// int __thiscall PackableList&lt;ContentProfile&gt;::UnPack(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Address of the source buffer pointer; it is advanced as data is consumed during unpacking.</param>
    /// <param name="a3">Maximum number of bytes available for reading from the buffer, used to guard against overruns.</param>
    /// <returns>1 if all expected profiles were successfully unpacked and inserted; 0 if an error occurs (e.g., insufficient data or premature unpack failure).</returns>
    // int __thiscall PackableList<ContentProfile>::UnPack(_DWORD*,void**,unsigned int) (template type method)

    /// <summary>Searches the list for an Enchantment matching the specified target and reports whether it exists.
    /// <code>Offset: 0x005BB0A0
    /// int __thiscall PackableList&lt;ContentProfile&gt;::Search(_DWORD*,Enchantment*)</code>
    /// </summary>
    /// <param name="rhs">The Enchantment to search for within the list.</param>
    /// <returns>Non‑zero if a match is found; zero otherwise.</returns>
    // int __thiscall PackableList<ContentProfile>::Search(_DWORD*,Enchantment*) (template type method)

    /// <summary>Inserts a new ContentProfile into the list at the specified position, allocating a node from the data pointed to by sourcePtr.
    /// <code>Offset: 0x005BB240
    /// int __thiscall PackableList&lt;ContentProfile&gt;::InsertPos(_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="index">Zero‑based position at which to insert; if equal to the current count, the element is appended.</param>
    /// <param name="sourcePtr">Pointer to the source object whose fields are copied into the new node.</param>
    /// <returns>The zero‑based index where the node was inserted.</returns>
    // int __thiscall PackableList<ContentProfile>::InsertPos(_DWORD*,int,int) (template type method)

    /// <summary>Removes a content profile that matches the given enchantment from the list.
    /// <code>Offset: 0x005BB360
    /// int __thiscall PackableList&lt;ContentProfile&gt;::Remove(_DWORD*,Enchantment*)</code>
    /// </summary>
    /// <param name="rhs">The enchantment whose matching profile should be removed.</param>
    /// <returns>Non‑zero if removal succeeded; zero if the list is empty or no matching element was found.</returns>
    // int __thiscall PackableList<ContentProfile>::Remove(_DWORD*,Enchantment*) (template type method)
}


/// <summary>Maintains an ordered collection of Emote objects for serialization and deserialization, providing efficient insertion, packing size calculation, and buffer packing operations.</summary>
public unsafe struct PackableList___Emote
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Adds a copy of the specified Emote to the end of the list and returns the updated element count.
    /// <code>Offset: 0x005971F0
    /// int __thiscall PackableList&lt;Emote&gt;::InsertTail(_DWORD*,Emote*)</code>
    /// </summary>
    /// <param name="rhs">The Emote object to append; it will be duplicated into a new node.</param>
    /// <returns>The total number of elements in the list after insertion.</returns>
    // int __thiscall PackableList<Emote>::InsertTail(_DWORD*,Emote*) (template type method)

    /// <summary>Packs an Emote list into a contiguous buffer, writing data only when the supplied capacity is sufficient.
    /// <code>Offset: 0x00597270
    /// unsigned int __thiscall PackableList&lt;Emote&gt;::Pack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the destination buffer; updated to point past the last written element after packing.</param>
    /// <param name="a3">Maximum number of elements that may be written into the buffer.</param>
    /// <returns>The total size required to pack the entire list, including all nested objects. If the provided capacity a3 is insufficient, no data is written.</returns>
    // unsigned int __thiscall PackableList<Emote>::Pack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>Calculates the total byte count required to serialize the PackableList, including its header and each contained Emote element.
    /// <code>Offset: 0x005972C0
    /// int __thiscall PackableList&lt;Emote&gt;::pack_size(_DWORD*)</code>
    /// </summary>
    /// <returns>The combined size in bytes for packing the entire list.</returns>
    // int __thiscall PackableList<Emote>::pack_size(_DWORD*) (template type method)

    /// <summary>Removes all Emote items from the list, deallocating each node and resetting internal counters.
    /// <code>Offset: 0x005974A0
    /// void __thiscall PackableList&lt;Emote&gt;::Flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall PackableList<Emote>::Flush(_DWORD*) (template type method)

    /// <summary>Deserializes a sequence of Emote objects from the supplied buffer into this list, replacing any existing contents.
    /// <code>Offset: 0x00597670
    /// int __thiscall PackableList&lt;Emote&gt;::UnPack(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Reference to a pointer marking the current position in the input data; advanced as bytes are consumed.</param>
    /// <param name="a3">Number of bytes remaining in the buffer referenced by *a2.</param>
    /// <returns>Returns 1 when all emotes have been unpacked successfully; returns 0 if there is insufficient data or an Emote fails to unpack. On failure, any emotes that were unpacked before the error remain in the list.</returns>
    // int __thiscall PackableList<Emote>::UnPack(_DWORD*,void**,unsigned int) (template type method)
}


/// <summary>Manages an ordered collection of EmoteSet instances, providing insertion, traversal, and binary serialization support via the PackObj base class.</summary>
public unsafe struct PackableList___EmoteSet
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Adds a copy of the specified EmoteSet to the end of the PackableList, updating head and tail pointers as well as the element count.
    /// <code>Offset: 0x00595CA0
    /// int __thiscall PackableList&lt;EmoteSet&gt;::InsertTail(_DWORD*,EmoteSet*)</code>
    /// </summary>
    /// <param name="rhs">The EmoteSet instance that will be duplicated into the list.</param>
    /// <returns>The new total number of elements in the list after insertion.</returns>
    // int __thiscall PackableList<EmoteSet>::InsertTail(_DWORD*,EmoteSet*) (template type method)

    /// <summary>Serializes each EmoteSet in this list into the buffer referenced by <paramref name="a2"/>. Packing proceeds only when the supplied size <paramref name="a3"/> is large enough for all items; if that size is at least four, the element count is written first, followed by each item’s own packed data.
    /// <code>Offset: 0x00595DA0
    /// unsigned int __thiscall PackableList&lt;EmoteSet&gt;::Pack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a buffer pointer that receives packed data; the pointer is advanced as elements are written.</param>
    /// <param name="a3">Maximum number of items the buffer can accommodate. Packing occurs only if this value is greater than or equal to the list’s element count, and the count itself is written only when <paramref name="a3"/> is at least four.</param>
    /// <returns>The total number of EmoteSet objects contained in the list.</returns>
    // unsigned int __thiscall PackableList<EmoteSet>::Pack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>Deletes every emote set in the list, freeing its memory and resetting the internal counter to zero.
    /// <code>Offset: 0x00595E30
    /// void __thiscall PackableList&lt;EmoteSet&gt;::Flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall PackableList<EmoteSet>::Flush(_DWORD*) (template type method)

    /// <summary>Destroys the PackableList by clearing its elements and resetting virtual table pointers.
    /// <code>Offset: 0x00595F10
    /// void __thiscall PackableList&lt;EmoteSet&gt;::~PackableList&lt;EmoteSet&gt;(void***)</code>
    /// </summary>
    // void __thiscall PackableList<EmoteSet>::~PackableList<EmoteSet>(void***) (template type method)

    /// <summary>Replaces the current list with emotes unpacked from a binary buffer. Reads a count followed by that many EmoteSet objects, inserting each into the list in order.
    /// <code>Offset: 0x00595F30
    /// int __thiscall PackableList&lt;EmoteSet&gt;::UnPack(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Address of a pointer to the serialized data; the function advances this pointer past processed bytes.</param>
    /// <param name="a3">Number of bytes remaining in the buffer to read from.</param>
    /// <returns>1 if all objects were unpacked successfully, 0 otherwise (including insufficient data or individual unpack failure).</returns>
    // int __thiscall PackableList<EmoteSet>::UnPack(_DWORD*,void**,unsigned int) (template type method)
}

public unsafe struct PackableList___AllegianceRankData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods
}

public unsafe struct PackableList___CreationProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods

    /// <summary>Adds a copy of the supplied CreationProfile to the end of the packable list and returns the updated element count.
    /// <code>Offset: 0x005902E0
    /// int __thiscall PackableList&lt;CreationProfile&gt;::InsertTail(_DWORD*,CreationProfile*)</code>
    /// </summary>
    /// <param name="rhs">The CreationProfile instance to append.</param>
    /// <returns>The total number of items in the list after the insertion.</returns>
    // int __thiscall PackableList<CreationProfile>::InsertTail(_DWORD*,CreationProfile*) (template type method)

    /// <summary>Packs a CreationProfile list into a memory buffer when sufficient space is available; always returns the total number of bytes needed for serialization.
    /// <code>Offset: 0x00590350
    /// unsigned int __thiscall PackableList&lt;CreationProfile&gt;::Pack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="this">The PackableList instance to serialize.</param>
    /// <param name="a2">Pointer to the current write position in the output buffer, advanced as data is written.</param>
    /// <param name="a3">Remaining size of the output buffer (in bytes).</param>
    /// <returns>Byte count required to pack the entire list.</returns>
    // unsigned int __thiscall PackableList<CreationProfile>::Pack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>Computes the total byte size required to serialize the list of CreationProfile objects, including a fixed 4‑byte header and each element's serialized length.
    /// <code>Offset: 0x005903A0
    /// int __thiscall PackableList&lt;CreationProfile&gt;::pack_size(_DWORD*)</code>
    /// </summary>
    /// <returns>The cumulative packed size in bytes.</returns>
    // int __thiscall PackableList<CreationProfile>::pack_size(_DWORD*) (template type method)

    /// <summary>Clears all entries from the packable list of <c>CreationProfile</c> objects, freeing each node's memory and resetting head, tail, and element count to zero.
    /// <code>Offset: 0x005905E0
    /// void __thiscall PackableList&lt;CreationProfile&gt;::Flush(_DWORD*)</code>
    /// </summary>
    // void __thiscall PackableList<CreationProfile>::Flush(_DWORD*) (template type method)

    /// <summary>Deserializes CreationProfile objects from the supplied buffer into this list after clearing existing entries.
    /// <code>Offset: 0x00590880
    /// int __thiscall PackableList&lt;CreationProfile&gt;::UnPack(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Reference to a pointer pointing at the current position in the buffer; advanced as data is consumed.</param>
    /// <param name="a3">Number of bytes remaining in the buffer that may be read.</param>
    /// <returns>Non‑zero if all requested items are unpacked successfully; zero if insufficient data or an item fails to unpack.</returns>
    // int __thiscall PackableList<CreationProfile>::UnPack(_DWORD*,void**,unsigned int) (template type method)
}

public unsafe struct PackableList___HouseWHouseData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public System.IntPtr head;
    public System.IntPtr tail;
    public uint curNum;

    // Methods
}

