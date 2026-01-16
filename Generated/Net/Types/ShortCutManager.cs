namespace ACBindings.Internal;


/// <summary>Manages a fixed-size collection of shortcut entries, providing insertion, removal, serialization and deserialization capabilities. Maintains an array of up to 18 pointers to ShortCutData objects, handling allocation, cleanup, packing into buffers, and reconstruction from serialized data.</summary>
public unsafe struct ShortCutManager
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ShortCutManager_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutManager*, void> ShortCutManager_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutManager*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutManager*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutManager*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public fixed byte shortCuts__Raw[18 * 4];
    public ACBindings.Internal.ShortCutData** shortCuts_ => (ACBindings.Internal.ShortCutData**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref shortCuts__Raw[0]);

    // Generated Constructor
    public ShortCutManager() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Destroys all shortcut data objects held by the manager and clears internal references.
    /// <code>Offset: 0x005D6770
    /// void __thiscall ShortCutManager::Destroy(ShortCutManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, void>)0x005D6770)(ref this);

    /// <summary>Removes the shortcut at the specified index, destroying its associated data and clearing the slot. If the index is out of range or the slot is already empty, no changes occur.
    /// <code>Offset: 0x005D67A0
    /// void __thiscall ShortCutManager::RemoveShortCut(ShortCutManager*,const int)</code>
    /// </summary>
    /// <param name="index">Zero-based position of the shortcut to remove; valid values are 0 through 17.</param>
    public void RemoveShortCut(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, int, void>)0x005D67A0)(ref this, index);

    /// <summary>Computes the total size needed to pack all non‑null shortcuts managed by this instance.
    /// <code>Offset: 0x005D67D0
    /// unsigned int __thiscall ShortCutManager::pack_size(ShortCutManager*)</code>
    /// </summary>
    /// <returns>The cumulative packet size in bytes, including a base overhead of 4 bytes.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, uint>)0x005D67D0)(ref this);

    /// <summary>Packs shortcut data into a preallocated buffer when sufficient space is available. The first four bytes of the buffer store the number of shortcuts packed, followed by each shortcut's serialized representation.
    /// <code>Offset: 0x005D6820
    /// unsigned int __thiscall ShortCutManager::Pack(ShortCutManager*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of the buffer pointer; updated to point past the packed data and used to write the count of shortcuts at its original location.</param>
    /// <param name="size">Maximum size of the buffer in bytes.</param>
    /// <returns>Size required for packing all shortcuts. If the provided buffer is large enough, the function writes the packed data into it; otherwise no data is written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, void**, uint, uint>)0x005D6820)(ref this, addr, size);

    /// <summary>Initializes the manager, setting up its virtual table and clearing all shortcut references.
    /// <code>Offset: 0x005D6880
    /// void __thiscall ShortCutManager::ShortCutManager(ShortCutManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, void>)0x005D6880)(ref this);

    /// <summary>Stores or updates a shortcut at the specified index using data from scData. Returns 1 on success, 0 if the index is out of range.
    /// <code>Offset: 0x005D68A0
    /// int __thiscall ShortCutManager::AddShortCut(ShortCutManager*,const ShortCutData*)</code>
    /// </summary>
    /// <param name="scData">Shortcut information containing the target index, object ID and spell ID.</param>
    /// <returns>Integer: 1 indicates the shortcut was added or updated; 0 indicates failure due to an invalid index.</returns>
    public int AddShortCut(ACBindings.Internal.ShortCutData* scData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, ACBindings.Internal.ShortCutData*, int>)0x005D68A0)(ref this, scData);

    /// <summary>Replaces all shortcuts in the manager by unpacking them from a serialized buffer.
    /// <code>Offset: 0x005D6930
    /// int __thiscall ShortCutManager::UnPack(ShortCutManager*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the buffer; advanced as data is consumed.</param>
    /// <param name="size">Total size of the buffer (unused in this implementation).</param>
    /// <returns>Always returns 1, indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, void**, uint, int>)0x005D6930)(ref this, addr, size);
}

