namespace ACBindings.Internal;


/// <summary>Maps emote identifiers to their corresponding sets, storing the data in an efficient hash table that can be packed or unpacked via an internal PackObj instance.</summary>
/// <remarks>Contains a PackObj member for handling binary serialization of the hash table rather than inheriting from PackObj.</remarks>
public unsafe struct CEmoteTable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public ACBindings.Internal.PackableHashTable__uint___PackableList___EmoteSet _emote_table;

    // Methods

    /// <summary>Deserializes the emote table data from a buffer into this instance's hash table.
    /// <code>Offset: 0x00595C90
    /// int __thiscall CEmoteTable::UnPack(CEmoteTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the source buffer containing packed data.</param>
    /// <param name="size">Size, in bytes, of the data available at addr.</param>
    /// <returns>The result code returned by the underlying UnPack operation (e.g., number of bytes processed or error flag).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEmoteTable, void**, uint, int>)0x00595C90)(ref this, addr, size);
}

