namespace ACBindings.Internal;

public unsafe struct ClientTradeSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem

    // Statics
    public static ACBindings.Internal.ClientTradeSystem* s_pTradeSystem = (ACBindings.Internal.ClientTradeSystem*)0x0087174C;

    // Child Types
    public unsafe struct ClientTradeSystem_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnStartup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> UseTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnBeginCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnEndCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnShutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientTradeSystem*, ACBindings.Internal.ClientTradeSystem.Enum16> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientTradeSystem::Enum15
    public enum Enum15 : uint
    {
    }
    // ClientTradeSystem::Enum16
    public enum Enum16 : uint
    {
    }
    // ClientTradeSystem::Enum17
    public enum Enum17 : uint
    {
    }
    // ClientTradeSystem::Enum4
    public enum Enum4 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.Internal.Trade* m_pTrade;
    public uint m_iidTradeInitiator;
    public uint m_iidTradePartner;
    public uint attemptTradeToPlayerID;
    public uint attemptTradeObjectID;

    // Generated Constructor
    public ClientTradeSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0056E6B0
    /// ClientTradeSystem* __cdecl ClientTradeSystem::GetTradeSystem()</code>
    /// </summary>
    public static ACBindings.Internal.ClientTradeSystem* GetTradeSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientTradeSystem*>)0x0056E6B0)();

    /// <summary>
    /// <code>Offset: 0x0056E6C0
    /// void __thiscall ClientTradeSystem::OnShutdown(ClientTradeSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056E6C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056E6E0
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_OpenTrade(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    public uint Handle_Trade__Recv_OpenTrade(uint source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint>)0x0056E6E0)(ref this, source);

    /// <summary>
    /// <code>Offset: 0x0056E700
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_ResetTrade(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    public uint Handle_Trade__Recv_ResetTrade(uint source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint>)0x0056E700)(ref this, source);

    /// <summary>
    /// <code>Offset: 0x0056E740
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_TradeFailure(ClientTradeSystem*,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Handle_Trade__Recv_TradeFailure(uint i_iidItem, uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint, uint>)0x0056E740)(ref this, i_iidItem, etype);

    /// <summary>
    /// <code>Offset: 0x0056E780
    /// void __thiscall ClientTradeSystem::AddItemToSelfTradeList(ClientTradeSystem*,unsigned int,int)</code>
    /// </summary>
    public void AddItemToSelfTradeList(uint i_iidItem, int i_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, int, void>)0x0056E780)(ref this, i_iidItem, i_nPos);

    /// <summary>
    /// <code>Offset: 0x0056E7A0
    /// void __thiscall ClientTradeSystem::AcceptTrade(ClientTradeSystem*)</code>
    /// </summary>
    public void AcceptTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056E7A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056E7C0
    /// void __thiscall ClientTradeSystem::DeclineTrade(ClientTradeSystem*)</code>
    /// </summary>
    public void DeclineTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056E7C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056E7F0
    /// unsigned int __thiscall ClientTradeSystem::GetNumSelfObjectsInTrade(ClientTradeSystem*)</code>
    /// </summary>
    public uint GetNumSelfObjectsInTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint>)0x0056E7F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056E810
    /// unsigned int __thiscall ClientTradeSystem::GetNumPartnerObjectsInTrade(ClientTradeSystem*)</code>
    /// </summary>
    public uint GetNumPartnerObjectsInTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint>)0x0056E810)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056E830
    /// bool __thiscall ClientTradeSystem::IsPartnerTradingItem(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    public byte IsPartnerTradingItem(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, byte>)0x0056E830)(ref this, i_iidItem);

    /// <summary>
    /// <code>Offset: 0x0056E850
    /// void __thiscall ClientTradeSystem::OnEndCharacterSession(ClientTradeSystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056E850)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056E8A0
    /// void __thiscall ClientTradeSystem::~ClientTradeSystem(ClientTradeSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056E8A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056E8E0
    /// TResult* __thiscall ClientTradeSystem::QueryInterface(ClientTradeSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x0056E8E0)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>
    /// <code>Offset: 0x0056E9B0
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_RemoveFromTrade(ClientTradeSystem*,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Handle_Trade__Recv_RemoveFromTrade(uint i_iidItem, uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint, uint>)0x0056E9B0)(ref this, i_iidItem, id);

    /// <summary>
    /// <code>Offset: 0x0056E9F0
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_AcceptTrade(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    public uint Handle_Trade__Recv_AcceptTrade(uint source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint>)0x0056E9F0)(ref this, source);

    /// <summary>
    /// <code>Offset: 0x0056EA90
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_DeclineTrade(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    public uint Handle_Trade__Recv_DeclineTrade(uint source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint>)0x0056EA90)(ref this, source);

    /// <summary>
    /// <code>Offset: 0x0056EB10
    /// void __thiscall ClientTradeSystem::ClientTradeSystem(ClientTradeSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056EB10)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056EB80
    /// int __thiscall ClientTradeSystem::GetItemLocationInPartnerTradeList(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    public int GetItemLocationInPartnerTradeList(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, int>)0x0056EB80)(ref this, i_iidItem);

    /// <summary>
    /// <code>Offset: 0x0056EBB0
    /// unsigned int __thiscall ClientTradeSystem::Release(ClientTradeSystem*)</code>
    /// </summary>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint>)0x0056EBB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056EBE0
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_CloseTrade(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    public uint Handle_Trade__Recv_CloseTrade(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint>)0x0056EBE0)(ref this, etype);

    /// <summary>
    /// <code>Offset: 0x0056EC90
    /// bool __thiscall ClientTradeSystem::AttemptToOpenTradeNegotiations(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    public byte AttemptToOpenTradeNegotiations(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, byte>)0x0056EC90)(ref this, i_iidPlayer);

    /// <summary>
    /// <code>Offset: 0x0056ED30
    /// void __thiscall ClientTradeSystem::AttemptToTradeItem(ClientTradeSystem*,unsigned int,unsigned int)</code>
    /// </summary>
    public void AttemptToTradeItem(uint idPlayer, uint idObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint, void>)0x0056ED30)(ref this, idPlayer, idObject);

    /// <summary>
    /// <code>Offset: 0x0056EE00
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_RegisterTrade(ClientTradeSystem*,unsigned int,unsigned int,long double)</code>
    /// </summary>
    public uint Handle_Trade__Recv_RegisterTrade(uint initiator, uint partner, double stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint, double, uint>)0x0056EE00)(ref this, initiator, partner, stamp);

    /// <summary>
    /// <code>Offset: 0x0056EEB0
    /// bool __thiscall ClientTradeSystem::AddPartnerItem(ClientTradeSystem*,unsigned int,unsigned int)</code>
    /// </summary>
    public byte AddPartnerItem(uint itemID, uint pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint, byte>)0x0056EEB0)(ref this, itemID, pos);

    /// <summary>
    /// <code>Offset: 0x0056EF90
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_AddToTrade(ClientTradeSystem*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public uint Handle_Trade__Recv_AddToTrade(uint item, uint id, uint loc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint, uint, uint>)0x0056EF90)(ref this, item, id, loc);

    /// <summary>
    /// <code>Offset: 0x0056EFF0
    /// void __thiscall ClientTradeSystem::NotifyServerThatTradeIsOutOfSync(ClientTradeSystem*)</code>
    /// </summary>
    public void NotifyServerThatTradeIsOutOfSync() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056EFF0)(ref this);
}

