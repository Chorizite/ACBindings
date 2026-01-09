namespace ACBindings;

// ClientHousingSystem
public unsafe struct ClientHousingSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.ClientSystem BaseClass_ClientSystem; // ACBindings.ClientSystem

    // Statics
    public static ACBindings.ClientHousingSystem* s_pHousingSystem = (ACBindings.ClientHousingSystem*)0x0086E864;

    // Child Types
    // ClientHousingSystem_vtbl
    public unsafe struct ClientHousingSystem_vtbl
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
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;

    // Generated Constructor
    public ClientHousingSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ClientHousingSystem::~ClientHousingSystem(ClientHousingSystem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, void>)0x00586770)(ref this);
    // void __thiscall ClientHousingSystem::OnShutdown(ClientHousingSystem*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, void>)0x005867A0)(ref this);
    // unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_HouseProfile(ClientHousingSystem*,unsigned int,const HouseProfile*)
    public uint Handle_House__Recv_HouseProfile(uint lord, ACBindings.HouseProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, uint, ACBindings.HouseProfile*, uint>)0x005867C0)(ref this, lord, prof);
    // unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_HouseTransaction(ClientHousingSystem*,unsigned int)
    public uint Handle_House__Recv_HouseTransaction(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, uint, uint>)0x005867E0)(ref this, etype);
    // unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_HouseData(ClientHousingSystem*,const HouseData*)
    public uint Handle_House__Recv_HouseData(ACBindings.HouseData* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, ACBindings.HouseData*, uint>)0x00586800)(ref this, data);
    // unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_UpdateRentTime(ClientHousingSystem*,int)
    public uint Handle_House__Recv_UpdateRentTime(int rent_time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, int, uint>)0x00586820)(ref this, rent_time);
    // unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_UpdateRentPayment(ClientHousingSystem*,const HousePaymentList*)
    public uint Handle_House__Recv_UpdateRentPayment(ACBindings.HousePaymentList* rent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, ACBindings.HousePaymentList*, uint>)0x00586840)(ref this, rent);
    // unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_UpdateRestrictions(ClientHousingSystem*,unsigned __int8,unsigned int,const RestrictionDB*)
    public uint Handle_House__Recv_UpdateRestrictions(byte wts, uint sender, ACBindings.RestrictionDB* db) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, byte, uint, ACBindings.RestrictionDB*, uint>)0x00586860)(ref this, wts, sender, db);
    // TResult* __thiscall ClientHousingSystem::QueryInterface(ClientHousingSystem*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x005868C0)(ref this, result, i_rcInterface, o_ppvInterface);
    // unsigned int __thiscall ClientHousingSystem::Release(ClientHousingSystem*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, uint>)0x00586990)(ref this);
    // void __thiscall ClientHousingSystem::ClientHousingSystem(ClientHousingSystem*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, void>)0x005869C0)(ref this);
    // unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_UpdateHAR(ClientHousingSystem*,const HAR*)
    public uint Handle_House__Recv_UpdateHAR(ACBindings.HAR* har) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, ACBindings.HAR*, uint>)0x00586A00)(ref this, har);
    // unsigned int* __thiscall ClientHousingSystem::DisplayListOfCoords(void*,int)
    public uint* DisplayListOfCoords(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, int, uint*>)0x00586AA0)(ref this, a2);
    // int __thiscall ClientHousingSystem::Handle_House__Recv_AvailableHouses(ClientSystem*,int,int,int)
    public int Handle_House__Recv_AvailableHouses(int a2, int a3, int ArgList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientHousingSystem, int, int, int, int>)0x00586BD0)(ref this, a2, a3, ArgList);
}

