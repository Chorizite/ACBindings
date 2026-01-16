namespace ACBindings.Internal;


/// <summary>Manages item transfer notifications between containers and wielders, ensuring client updates and attribute changes are propagated.</summary>
public unsafe struct GenItemHolder
{
    // Statics
    public static uint* splitSize = (uint*)0x0081D7EC;
    public static uint* maxSplitSize = (uint*)0x0081D7F0;

    // Methods

    /// <summary>Relays a server‑initiated move of an item between containers or wielders, notifying clients and marking affected containers as having updated attributes.
    /// <code>Offset: 0x004FD0F0
    /// void __cdecl GenItemHolder::ServerSaysMoveItem_s(unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">The unique identifier of the moved item.</param>
    /// <param name="oldContainer">Identifier of the source container that held the item before the move (zero if none).</param>
    /// <param name="oldWielder">Identifier of the entity that originally wielded the item before the move (zero if none).</param>
    /// <param name="oldLocation">Slot or index within the source container/wielder where the item was located.</param>
    /// <param name="newContainer">Identifier of the destination container after the move (zero if none).</param>
    /// <param name="place">Target slot index within the destination container.</param>
    /// <param name="newWielder">Identifier of the entity now wielding the item after the move (zero if none).</param>
    /// <param name="newLocation">Slot or index within the destination container/wielder where the item is placed.</param>
    public static void ServerSaysMoveItem_s(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Cdecl]<uint, uint, uint, uint, uint, int, uint, uint, void>)0x004FD0F0)(itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);
}

