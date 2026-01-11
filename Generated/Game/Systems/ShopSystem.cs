namespace ACBindings.Internal;

public unsafe struct ShopSystem
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x006B7060
    /// int __cdecl ShopSystem::BuyPrice(int,ITEM_TYPE,float,int)</code>
    /// </summary>
    public static int BuyPrice(int unit_value, ACBindings.Internal.ITEM_TYPE itype, float buy_price, int num_item) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.ITEM_TYPE, float, int, int>)0x006B7060)(unit_value, itype, buy_price, num_item);

    /// <summary>
    /// <code>Offset: 0x006B70C0
    /// int __cdecl ShopSystem::SellPrice(int,ITEM_TYPE,float,int)</code>
    /// </summary>
    public static int SellPrice(int unit_value, ACBindings.Internal.ITEM_TYPE itype, float sell_price, int num_item) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.ITEM_TYPE, float, int, int>)0x006B70C0)(unit_value, itype, sell_price, num_item);
}

