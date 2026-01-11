namespace ACBindings.Internal;

public unsafe struct ClientFellowshipSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem

    // Statics
    public static ACBindings.Internal.ClientFellowshipSystem* s_pFellowshipSystem = (ACBindings.Internal.ClientFellowshipSystem*)0x0087150C;

    // Child Types
    public unsafe struct ClientFellowshipSystem_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFellowshipSystem*, ACBindings.Internal.ClientFellowshipSystem.Enum11> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientFellowshipSystem::Enum10
    public enum Enum10 : uint
    {
    }
    // ClientFellowshipSystem::Enum11
    public enum Enum11 : uint
    {
    }
    // ClientFellowshipSystem::Enum12
    public enum Enum12 : uint
    {
    }
    // ClientFellowshipSystem::Enum13
    public enum Enum13 : uint
    {
    }
    // ClientFellowshipSystem::Enum4
    public enum Enum4 : uint
    {
    }
    // ClientFellowshipSystem::Enum7
    public enum Enum7 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.Internal.CFellowship* m_pFellowship;

    // Generated Constructor
    public ClientFellowshipSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00569E00
    /// void __thiscall ClientFellowshipSystem::~ClientFellowshipSystem(ClientFellowshipSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x00569E00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00569E30
    /// ClientFellowshipSystem* __cdecl ClientFellowshipSystem::GetFellowshipSystem()</code>
    /// </summary>
    public static ACBindings.Internal.ClientFellowshipSystem* GetFellowshipSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientFellowshipSystem*>)0x00569E30)();

    /// <summary>
    /// <code>Offset: 0x00569E40
    /// void __thiscall ClientFellowshipSystem::OnEndCharacterSession(ClientFellowshipSystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x00569E40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00569E60
    /// unsigned int __thiscall ClientFellowshipSystem::Handle_Fellowship__UpdateFellow(ClientFellowshipSystem*,unsigned int,const Fellow*,unsigned int)</code>
    /// </summary>
    public uint Handle_Fellowship__UpdateFellow(uint id, ACBindings.Internal.Fellow* fellow, uint updateType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, uint, ACBindings.Internal.Fellow*, uint, uint>)0x00569E60)(ref this, id, fellow, updateType);

    /// <summary>
    /// <code>Offset: 0x00569ED0
    /// bool __thiscall ClientFellowshipSystem::IsFellow(ClientFellowshipSystem*,unsigned int)</code>
    /// </summary>
    public byte IsFellow(uint i_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, uint, byte>)0x00569ED0)(ref this, i_iid);

    /// <summary>
    /// <code>Offset: 0x00569EF0
    /// bool __thiscall ClientFellowshipSystem::IsFellowshipLeader(ClientFellowshipSystem*,unsigned int)</code>
    /// </summary>
    public byte IsFellowshipLeader(uint i_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, uint, byte>)0x00569EF0)(ref this, i_iid);

    /// <summary>
    /// <code>Offset: 0x00569F10
    /// TResult* __thiscall ClientFellowshipSystem::QueryInterface(ClientFellowshipSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00569F10)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>
    /// <code>Offset: 0x00569FE0
    /// unsigned int __thiscall ClientFellowshipSystem::Release(ClientFellowshipSystem*)</code>
    /// </summary>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, uint>)0x00569FE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056A010
    /// void __thiscall ClientFellowshipSystem::ClientFellowshipSystem(ClientFellowshipSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x0056A010)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056A160
    /// unsigned int __thiscall ClientFellowshipSystem::Handle_Fellowship__FullUpdate(ClientFellowshipSystem*,const CFellowship*)</code>
    /// </summary>
    public uint Handle_Fellowship__FullUpdate(ACBindings.Internal.CFellowship* fellowship) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, ACBindings.Internal.CFellowship*, uint>)0x0056A160)(ref this, fellowship);

    /// <summary>
    /// <code>Offset: 0x0056A290
    /// void __thiscall ClientFellowshipSystem::SelectNextFellow(ClientFellowshipSystem*)</code>
    /// </summary>
    public void SelectNextFellow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x0056A290)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056A360
    /// void __thiscall ClientFellowshipSystem::SelectPreviousFellow(ClientFellowshipSystem*)</code>
    /// </summary>
    public void SelectPreviousFellow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x0056A360)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056AB50
    /// void __thiscall ClientFellowshipSystem::DeleteFellowship(ClientFellowshipSystem*)</code>
    /// </summary>
    public void DeleteFellowship() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x0056AB50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056ABF0
    /// void __thiscall ClientFellowshipSystem::OnShutdown(ClientFellowshipSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x0056ABF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056AC30
    /// unsigned int __thiscall ClientFellowshipSystem::Handle_Fellowship__Quit(ClientFellowshipSystem*,unsigned int)</code>
    /// </summary>
    public uint Handle_Fellowship__Quit(uint quitter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, uint, uint>)0x0056AC30)(ref this, quitter);

    /// <summary>
    /// <code>Offset: 0x0056ACB0
    /// unsigned int __thiscall ClientFellowshipSystem::Handle_Fellowship__Dismiss(ClientFellowshipSystem*,unsigned int)</code>
    /// </summary>
    public uint Handle_Fellowship__Dismiss(uint dismissed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, uint, uint>)0x0056ACB0)(ref this, dismissed);
}

