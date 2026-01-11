namespace ACBindings.Internal;

public unsafe struct ClientAllegianceSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem

    // Statics
    public static ACBindings.Internal.ClientAllegianceSystem* s_pAllegianceSystem = (ACBindings.Internal.ClientAllegianceSystem*)0x008715BC;

    // Child Types
    public unsafe struct ClientAllegianceSystem_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientAllegianceSystem*, ACBindings.Internal.ClientAllegianceSystem.Enum8> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

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
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.Internal.CAllegianceProfile m_allegianceProfile;

    // Generated Constructor
    public ClientAllegianceSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0056AD30
    /// ClientAllegianceSystem* __cdecl ClientAllegianceSystem::GetAllegianceSystem()</code>
    /// </summary>
    public static ACBindings.Internal.ClientAllegianceSystem* GetAllegianceSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientAllegianceSystem*>)0x0056AD30)();

    /// <summary>
    /// <code>Offset: 0x0056AD40
    /// void __thiscall ClientAllegianceSystem::OnEndCharacterSession(ClientAllegianceSystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientAllegianceSystem, void>)0x0056AD40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056AD50
    /// void __thiscall ClientAllegianceSystem::OnShutdown(ClientAllegianceSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientAllegianceSystem, void>)0x0056AD50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056AD70
    /// unsigned int __thiscall ClientAllegianceSystem::Handle_Allegiance__AllegianceUpdateAborted(ClientAllegianceSystem*,const unsigned int)</code>
    /// </summary>
    public uint Handle_Allegiance__AllegianceUpdateAborted(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientAllegianceSystem, uint, uint>)0x0056AD70)(ref this, etype);

    /// <summary>
    /// <code>Offset: 0x0056AD90
    /// unsigned int __thiscall ClientAllegianceSystem::Handle_Allegiance__AllegianceLoginNotificationEvent(ClientAllegianceSystem*,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Allegiance__AllegianceLoginNotificationEvent(uint member, int bNowLoggedIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientAllegianceSystem, uint, int, uint>)0x0056AD90)(ref this, member, bNowLoggedIn);

    /// <summary>
    /// <code>Offset: 0x0056ADB0
    /// void __thiscall ClientAllegianceSystem::~ClientAllegianceSystem(ClientAllegianceSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientAllegianceSystem, void>)0x0056ADB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056ADF0
    /// TResult* __thiscall ClientAllegianceSystem::QueryInterface(ClientAllegianceSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientAllegianceSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x0056ADF0)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>
    /// <code>Offset: 0x0056AEC0
    /// unsigned int __thiscall ClientAllegianceSystem::Handle_Allegiance__AllegianceUpdate(ClientAllegianceSystem*,const CAllegianceProfile*,unsigned int)</code>
    /// </summary>
    public uint Handle_Allegiance__AllegianceUpdate(ACBindings.Internal.CAllegianceProfile* prof, uint rank) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientAllegianceSystem, ACBindings.Internal.CAllegianceProfile*, uint, uint>)0x0056AEC0)(ref this, prof, rank);

    /// <summary>
    /// <code>Offset: 0x0056AEF0
    /// void __thiscall ClientAllegianceSystem::ClientAllegianceSystem(ClientAllegianceSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientAllegianceSystem, void>)0x0056AEF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056AF40
    /// unsigned int __thiscall ClientAllegianceSystem::Release(ClientAllegianceSystem*)</code>
    /// </summary>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientAllegianceSystem, uint>)0x0056AF40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056AF70
    /// unsigned int __thiscall ClientAllegianceSystem::Handle_Allegiance__AllegianceInfoResponseEvent(ClientAllegianceSystem*,unsigned int,const CAllegianceProfile*)</code>
    /// </summary>
    public uint Handle_Allegiance__AllegianceInfoResponseEvent(uint target, ACBindings.Internal.CAllegianceProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientAllegianceSystem, uint, ACBindings.Internal.CAllegianceProfile*, uint>)0x0056AF70)(ref this, target, prof);
}

