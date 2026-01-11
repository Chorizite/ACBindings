namespace ACBindings.Internal;

public unsafe struct CEmoteTable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Members
    public ACBindings.Internal.PackableHashTable__uint___PackableList___EmoteSet _emote_table;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00595C90
    /// int __thiscall CEmoteTable::UnPack(CEmoteTable*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEmoteTable, void**, uint, int>)0x00595C90)(ref this, addr, size);
}

