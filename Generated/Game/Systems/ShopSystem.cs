namespace ACBindings.Internal;


/// <summary>Provides pricing logic for shop transactions, calculating buy and sell values based on item type, quantity, and multipliers while ensuring results stay within valid ranges.</summary>
public unsafe struct ShopSystem
{
    // Methods

    /// <summary>Calculates the total purchase cost for an item based on unit value, type, base price multiplier, and quantity.
    /// <code>Offset: 0x006B7060
    /// int __cdecl ShopSystem::BuyPrice(int,ITEM_TYPE,float,int)</code>
    /// </summary>
    /// <param name="unit_value">The base value per unit to be multiplied with the price factor.</param>
    /// <param name="itype">Enumeration indicating the item’s type; special handling applies to promissory notes.</param>
    /// <param name="buy_price">The price multiplier applied when the item is not a promissory note.</param>
    /// <param name="num_item">The quantity of items being purchased.</param>
    /// <returns>The resulting purchase price as an integer. The value is clamped to at least 1, and if it exceeds the signed 32‑bit range it returns –1.</returns>
    public static int BuyPrice(int unit_value, ACBindings.Internal.ITEM_TYPE itype, float buy_price, int num_item) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.ITEM_TYPE, float, int, int>)0x006B7060)(unit_value, itype, buy_price, num_item);

    /// <summary>Calculates the selling price for an item based on its unit value, type, quantity and a multiplier. For promissory notes a 15 % premium is applied; otherwise the supplied multiplier is used. The result is rounded up after subtracting 0.1.
    /// <code>Offset: 0x006B70C0
    /// int __cdecl ShopSystem::SellPrice(int,ITEM_TYPE,float,int)</code>
    /// </summary>
    /// <param name="unit_value">Base monetary value of one unit of the item.</param>
    /// <param name="itype">The type of the item, determining whether a premium applies.</param>
    /// <param name="sell_price">Multiplier applied for non‑promissory items; ignored when itype is TYPE_PROMISSORY_NOTE.</param>
    /// <param name="num_item">Number of units being sold.</param>
    /// <returns>Positive integer representing the price in currency units. If the calculation evaluates to zero, 1 is returned; if the calculation yields a negative value, –1 is returned.</returns>
    public static int SellPrice(int unit_value, ACBindings.Internal.ITEM_TYPE itype, float sell_price, int num_item) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.ITEM_TYPE, float, int, int>)0x006B70C0)(unit_value, itype, sell_price, num_item);
}

