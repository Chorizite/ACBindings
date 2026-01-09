namespace ACBindings;

// ClientAllegianceSystem
public unsafe struct ClientAllegianceSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.ClientSystem BaseClass_ClientSystem; // ACBindings.ClientSystem

    // Statics
    public static ACBindings.ClientAllegianceSystem* s_pAllegianceSystem = (ACBindings.ClientAllegianceSystem*)0x0086EC74;

    // Child Types
    // ClientAllegianceSystem_vtbl
    public unsafe struct ClientAllegianceSystem_vtbl
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
    // ClientAllegianceSystem::Enum10
    public enum Enum10 : uint
    {
    }
    // ClientAllegianceSystem::Enum11
    public enum Enum11 : uint
    {
    }
    // ClientAllegianceSystem::Enum7
    public enum Enum7 : uint
    {
    }
    // ClientAllegianceSystem::Enum8
    public enum Enum8 : uint
    {
    }
    // ClientAllegianceSystem::Enum9
    public enum Enum9 : uint
    {
    }

    // Members
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.CAllegianceProfile m_allegianceProfile;

    // Generated Constructor
    public ClientAllegianceSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // ClientAllegianceSystem* __cdecl ClientAllegianceSystem::GetAllegianceSystem()
    public static ACBindings.ClientAllegianceSystem* GetAllegianceSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.ClientAllegianceSystem*>)0x0056AD30)();
    // void __thiscall ClientAllegianceSystem::OnEndCharacterSession(ClientAllegianceSystem*)
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientAllegianceSystem, void>)0x0056AD40)(ref this);
    // void __thiscall ClientAllegianceSystem::OnShutdown(ClientAllegianceSystem*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientAllegianceSystem, void>)0x0056AD50)(ref this);
    // unsigned int __thiscall ClientAllegianceSystem::Handle_Allegiance__AllegianceUpdateAborted(ClientAllegianceSystem*,const unsigned int)
    public uint Handle_Allegiance__AllegianceUpdateAborted(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientAllegianceSystem, uint, uint>)0x0056AD70)(ref this, etype);
    // unsigned int __thiscall ClientAllegianceSystem::Handle_Allegiance__AllegianceLoginNotificationEvent(ClientAllegianceSystem*,unsigned int,int)
    public uint Handle_Allegiance__AllegianceLoginNotificationEvent(uint member, int bNowLoggedIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientAllegianceSystem, uint, int, uint>)0x0056AD90)(ref this, member, bNowLoggedIn);
    // void __thiscall ClientAllegianceSystem::~ClientAllegianceSystem(ClientAllegianceSystem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientAllegianceSystem, void>)0x0056ADB0)(ref this);
    // TResult* __thiscall ClientAllegianceSystem::QueryInterface(ClientAllegianceSystem*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientAllegianceSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x0056ADF0)(ref this, result, i_rcInterface, o_ppvInterface);
    // unsigned int __thiscall ClientAllegianceSystem::Handle_Allegiance__AllegianceUpdate(ClientAllegianceSystem*,const CAllegianceProfile*,unsigned int)
    public uint Handle_Allegiance__AllegianceUpdate(ACBindings.CAllegianceProfile* prof, uint rank) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientAllegianceSystem, ACBindings.CAllegianceProfile*, uint, uint>)0x0056AEC0)(ref this, prof, rank);
    // void __thiscall ClientAllegianceSystem::ClientAllegianceSystem(ClientAllegianceSystem*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientAllegianceSystem, void>)0x0056AEF0)(ref this);
    // unsigned int __thiscall ClientAllegianceSystem::Release(ClientAllegianceSystem*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientAllegianceSystem, uint>)0x0056AF40)(ref this);
    // unsigned int __thiscall ClientAllegianceSystem::Handle_Allegiance__AllegianceInfoResponseEvent(ClientAllegianceSystem*,unsigned int,const CAllegianceProfile*)
    public uint Handle_Allegiance__AllegianceInfoResponseEvent(uint target, ACBindings.CAllegianceProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientAllegianceSystem, uint, ACBindings.CAllegianceProfile*, uint>)0x0056AF70)(ref this, target, prof);
}

