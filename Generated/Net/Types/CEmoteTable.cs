namespace ACBindings;

// CEmoteTable
public unsafe struct CEmoteTable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Members
    public ACBindings.PackableHashTable__uint__PackableList__EmoteSet _emote_table;

    // Methods
    // int __thiscall CEmoteTable::UnPack(CEmoteTable*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEmoteTable, void**, uint, int>)0x00595C90)(ref this, addr, size);
}

