namespace ACBindings;

// ClientTradeSystem
public unsafe struct ClientTradeSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.ClientSystem BaseClass_ClientSystem; // ACBindings.ClientSystem

    // Statics
    public static ACBindings.ClientTradeSystem* s_pTradeSystem = (ACBindings.ClientTradeSystem*)0x0086EAE0;

    // Child Types
    // ClientTradeSystem_vtbl
    public unsafe struct ClientTradeSystem_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr OnStartup; // function pointer
        public System.IntPtr UseTime; // function pointer
        public System.IntPtr OnBeginCharacterSession; // function pointer
        public System.IntPtr OnEndCharacterSession; // function pointer
        public System.IntPtr OnShutdown; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

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
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.Trade* m_pTrade;
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
    // ClientTradeSystem* __cdecl ClientTradeSystem::GetTradeSystem()
    public static ACBindings.ClientTradeSystem* GetTradeSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.ClientTradeSystem*>)0x0056E6B0)();
    // void __thiscall ClientTradeSystem::OnShutdown(ClientTradeSystem*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, void>)0x0056E6C0)(ref this);
    // unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_OpenTrade(ClientTradeSystem*,unsigned int)
    public uint Handle_Trade__Recv_OpenTrade(uint source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, uint>)0x0056E6E0)(ref this, source);
    // unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_ResetTrade(ClientTradeSystem*,unsigned int)
    public uint Handle_Trade__Recv_ResetTrade(uint source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, uint>)0x0056E700)(ref this, source);
    // unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_TradeFailure(ClientTradeSystem*,unsigned int,unsigned int)
    public uint Handle_Trade__Recv_TradeFailure(uint i_iidItem, uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, uint, uint>)0x0056E740)(ref this, i_iidItem, etype);
    // void __thiscall ClientTradeSystem::AddItemToSelfTradeList(ClientTradeSystem*,unsigned int,int)
    public void AddItemToSelfTradeList(uint i_iidItem, int i_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, int, void>)0x0056E780)(ref this, i_iidItem, i_nPos);
    // void __thiscall ClientTradeSystem::AcceptTrade(ClientTradeSystem*)
    public void AcceptTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, void>)0x0056E7A0)(ref this);
    // void __thiscall ClientTradeSystem::DeclineTrade(ClientTradeSystem*)
    public void DeclineTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, void>)0x0056E7C0)(ref this);
    // unsigned int __thiscall ClientTradeSystem::GetNumSelfObjectsInTrade(ClientTradeSystem*)
    public uint GetNumSelfObjectsInTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint>)0x0056E7F0)(ref this);
    // unsigned int __thiscall ClientTradeSystem::GetNumPartnerObjectsInTrade(ClientTradeSystem*)
    public uint GetNumPartnerObjectsInTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint>)0x0056E810)(ref this);
    // bool __thiscall ClientTradeSystem::IsPartnerTradingItem(ClientTradeSystem*,unsigned int)
    public byte IsPartnerTradingItem(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, byte>)0x0056E830)(ref this, i_iidItem);
    // void __thiscall ClientTradeSystem::OnEndCharacterSession(ClientTradeSystem*)
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, void>)0x0056E850)(ref this);
    // void __thiscall ClientTradeSystem::~ClientTradeSystem(ClientTradeSystem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, void>)0x0056E8A0)(ref this);
    // TResult* __thiscall ClientTradeSystem::QueryInterface(ClientTradeSystem*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x0056E8E0)(ref this, result, i_rcInterface, o_ppvInterface);
    // unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_RemoveFromTrade(ClientTradeSystem*,unsigned int,unsigned int)
    public uint Handle_Trade__Recv_RemoveFromTrade(uint i_iidItem, uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, uint, uint>)0x0056E9B0)(ref this, i_iidItem, id);
    // unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_AcceptTrade(ClientTradeSystem*,unsigned int)
    public uint Handle_Trade__Recv_AcceptTrade(uint source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, uint>)0x0056E9F0)(ref this, source);
    // unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_DeclineTrade(ClientTradeSystem*,unsigned int)
    public uint Handle_Trade__Recv_DeclineTrade(uint source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, uint>)0x0056EA90)(ref this, source);
    // void __thiscall ClientTradeSystem::ClientTradeSystem(ClientTradeSystem*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, void>)0x0056EB10)(ref this);
    // int __thiscall ClientTradeSystem::GetItemLocationInPartnerTradeList(ClientTradeSystem*,unsigned int)
    public int GetItemLocationInPartnerTradeList(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, int>)0x0056EB80)(ref this, i_iidItem);
    // unsigned int __thiscall ClientTradeSystem::Release(ClientTradeSystem*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint>)0x0056EBB0)(ref this);
    // unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_CloseTrade(ClientTradeSystem*,unsigned int)
    public uint Handle_Trade__Recv_CloseTrade(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, uint>)0x0056EBE0)(ref this, etype);
    // bool __thiscall ClientTradeSystem::AttemptToOpenTradeNegotiations(ClientTradeSystem*,unsigned int)
    public byte AttemptToOpenTradeNegotiations(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, byte>)0x0056EC90)(ref this, i_iidPlayer);
    // void __thiscall ClientTradeSystem::AttemptToTradeItem(ClientTradeSystem*,unsigned int,unsigned int)
    public void AttemptToTradeItem(uint idPlayer, uint idObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, uint, void>)0x0056ED30)(ref this, idPlayer, idObject);
    // unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_RegisterTrade(ClientTradeSystem*,unsigned int,unsigned int,long double)
    public uint Handle_Trade__Recv_RegisterTrade(uint initiator, uint partner, double stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, uint, double, uint>)0x0056EE00)(ref this, initiator, partner, stamp);
    // bool __thiscall ClientTradeSystem::AddPartnerItem(ClientTradeSystem*,unsigned int,unsigned int)
    public byte AddPartnerItem(uint itemID, uint pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, uint, byte>)0x0056EEB0)(ref this, itemID, pos);
    // unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_AddToTrade(ClientTradeSystem*,unsigned int,unsigned int,unsigned int)
    public uint Handle_Trade__Recv_AddToTrade(uint item, uint id, uint loc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, uint, uint, uint, uint>)0x0056EF90)(ref this, item, id, loc);
    // void __thiscall ClientTradeSystem::NotifyServerThatTradeIsOutOfSync(ClientTradeSystem*)
    public void NotifyServerThatTradeIsOutOfSync() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientTradeSystem, void>)0x0056EFF0)(ref this);
}

