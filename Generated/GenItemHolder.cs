namespace ACBindings;

// GenItemHolder
public unsafe struct GenItemHolder
{
    // Statics
    public static uint* splitSize = (uint*)0x0081D7EC;
    public static uint* maxSplitSize = (uint*)0x0081D7F0;

    // Methods
    // void __cdecl GenItemHolder::ServerSaysMoveItem_s(unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public static void ServerSaysMoveItem_s(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Cdecl]<uint, uint, uint, uint, uint, int, uint, uint, void>)0x004FD0F0)(itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);
}

