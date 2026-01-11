namespace ACBindings.Internal;

public unsafe struct ClientHousingSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem

    // Statics
    public static ACBindings.Internal.ClientHousingSystem* s_pHousingSystem = (ACBindings.Internal.ClientHousingSystem*)0x008719BC;

    // Child Types
    public unsafe struct ClientHousingSystem_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientHousingSystem*, ACBindings.Internal.ClientHousingSystem.Enum12> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientHousingSystem::Enum11
    public enum Enum11 : uint
    {
    }
    // ClientHousingSystem::Enum12
    public enum Enum12 : uint
    {
    }
    // ClientHousingSystem::Enum13
    public enum Enum13 : uint
    {
    }
    // ClientHousingSystem::Enum14
    public enum Enum14 : uint
    {
    }
    // ClientHousingSystem::Enum4
    public enum Enum4 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;

    // Generated Constructor
    public ClientHousingSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00586770
    /// void __thiscall ClientHousingSystem::~ClientHousingSystem(ClientHousingSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, void>)0x00586770)(ref this);

    /// <summary>
    /// <code>Offset: 0x005867A0
    /// void __thiscall ClientHousingSystem::OnShutdown(ClientHousingSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, void>)0x005867A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005867C0
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_HouseProfile(ClientHousingSystem*,unsigned int,const HouseProfile*)</code>
    /// </summary>
    public uint Handle_House__Recv_HouseProfile(uint lord, ACBindings.Internal.HouseProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, uint, ACBindings.Internal.HouseProfile*, uint>)0x005867C0)(ref this, lord, prof);

    /// <summary>
    /// <code>Offset: 0x005867E0
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_HouseTransaction(ClientHousingSystem*,unsigned int)</code>
    /// </summary>
    public uint Handle_House__Recv_HouseTransaction(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, uint, uint>)0x005867E0)(ref this, etype);

    /// <summary>
    /// <code>Offset: 0x00586800
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_HouseData(ClientHousingSystem*,const HouseData*)</code>
    /// </summary>
    public uint Handle_House__Recv_HouseData(ACBindings.Internal.HouseData* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, ACBindings.Internal.HouseData*, uint>)0x00586800)(ref this, data);

    /// <summary>
    /// <code>Offset: 0x00586820
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_UpdateRentTime(ClientHousingSystem*,int)</code>
    /// </summary>
    public uint Handle_House__Recv_UpdateRentTime(int rent_time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, int, uint>)0x00586820)(ref this, rent_time);

    /// <summary>
    /// <code>Offset: 0x00586840
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_UpdateRentPayment(ClientHousingSystem*,const HousePaymentList*)</code>
    /// </summary>
    public uint Handle_House__Recv_UpdateRentPayment(ACBindings.Internal.HousePaymentList* rent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, ACBindings.Internal.HousePaymentList*, uint>)0x00586840)(ref this, rent);

    /// <summary>
    /// <code>Offset: 0x00586860
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_UpdateRestrictions(ClientHousingSystem*,unsigned __int8,unsigned int,const RestrictionDB*)</code>
    /// </summary>
    public uint Handle_House__Recv_UpdateRestrictions(byte wts, uint sender, ACBindings.Internal.RestrictionDB* db) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, byte, uint, ACBindings.Internal.RestrictionDB*, uint>)0x00586860)(ref this, wts, sender, db);

    /// <summary>
    /// <code>Offset: 0x005868C0
    /// TResult* __thiscall ClientHousingSystem::QueryInterface(ClientHousingSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x005868C0)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>
    /// <code>Offset: 0x00586990
    /// unsigned int __thiscall ClientHousingSystem::Release(ClientHousingSystem*)</code>
    /// </summary>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, uint>)0x00586990)(ref this);

    /// <summary>
    /// <code>Offset: 0x005869C0
    /// void __thiscall ClientHousingSystem::ClientHousingSystem(ClientHousingSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, void>)0x005869C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00586A00
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_UpdateHAR(ClientHousingSystem*,const HAR*)</code>
    /// </summary>
    public uint Handle_House__Recv_UpdateHAR(ACBindings.Internal.HAR* har) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, ACBindings.Internal.HAR*, uint>)0x00586A00)(ref this, har);

    /// <summary>
    /// <code>Offset: 0x00586AA0
    /// unsigned int* __thiscall ClientHousingSystem::DisplayListOfCoords(void*,int)</code>
    /// </summary>
    public uint* DisplayListOfCoords(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, int, uint*>)0x00586AA0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00586BD0
    /// int __thiscall ClientHousingSystem::Handle_House__Recv_AvailableHouses(ClientSystem*,int,int,int)</code>
    /// </summary>
    public int Handle_House__Recv_AvailableHouses(int a2, int a3, int ArgList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, int, int, int, int>)0x00586BD0)(ref this, a2, a3, ArgList);
}

