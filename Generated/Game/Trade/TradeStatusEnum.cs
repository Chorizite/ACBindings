namespace ACBindings.Internal;

// TradeStatusEnum
public enum TradeStatusEnum : uint
{
    Undef_TradeStatus = 0x0,
    Pending_TradeStatus = 0x1,
    Open_TradeStatus = 0x2,
    WaitingToClose_TradeStatus = 0x4,
    FORCE_TradeStatusEnum_32_BIT = 0x7FFFFFFF
}

