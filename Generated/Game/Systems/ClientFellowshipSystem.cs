namespace ACBindings;

// ClientFellowshipSystem
public unsafe struct ClientFellowshipSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.ClientSystem BaseClass_ClientSystem; // ACBindings.ClientSystem

    // Statics
    public static ACBindings.ClientFellowshipSystem* s_pFellowshipSystem = (ACBindings.ClientFellowshipSystem*)0x0086ED60;

    // Child Types
    // ClientFellowshipSystem_vtbl
    public unsafe struct ClientFellowshipSystem_vtbl
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
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.CFellowship* m_pFellowship;

    // Generated Constructor
    public ClientFellowshipSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ClientFellowshipSystem::~ClientFellowshipSystem(ClientFellowshipSystem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, void>)0x00569E00)(ref this);
    // ClientFellowshipSystem* __cdecl ClientFellowshipSystem::GetFellowshipSystem()
    public static ACBindings.ClientFellowshipSystem* GetFellowshipSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.ClientFellowshipSystem*>)0x00569E30)();
    // void __thiscall ClientFellowshipSystem::OnEndCharacterSession(ClientFellowshipSystem*)
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, void>)0x00569E40)(ref this);
    // unsigned int __thiscall ClientFellowshipSystem::Handle_Fellowship__UpdateFellow(ClientFellowshipSystem*,unsigned int,const Fellow*,unsigned int)
    public uint Handle_Fellowship__UpdateFellow(uint id, ACBindings.Fellow* fellow, uint updateType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, uint, ACBindings.Fellow*, uint, uint>)0x00569E60)(ref this, id, fellow, updateType);
    // bool __thiscall ClientFellowshipSystem::IsFellow(ClientFellowshipSystem*,unsigned int)
    public byte IsFellow(uint i_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, uint, byte>)0x00569ED0)(ref this, i_iid);
    // bool __thiscall ClientFellowshipSystem::IsFellowshipLeader(ClientFellowshipSystem*,unsigned int)
    public byte IsFellowshipLeader(uint i_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, uint, byte>)0x00569EF0)(ref this, i_iid);
    // TResult* __thiscall ClientFellowshipSystem::QueryInterface(ClientFellowshipSystem*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x00569F10)(ref this, result, i_rcInterface, o_ppvInterface);
    // unsigned int __thiscall ClientFellowshipSystem::Release(ClientFellowshipSystem*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, uint>)0x00569FE0)(ref this);
    // void __thiscall ClientFellowshipSystem::ClientFellowshipSystem(ClientFellowshipSystem*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, void>)0x0056A010)(ref this);
    // unsigned int __thiscall ClientFellowshipSystem::Handle_Fellowship__FullUpdate(ClientFellowshipSystem*,const CFellowship*)
    public uint Handle_Fellowship__FullUpdate(ACBindings.CFellowship* fellowship) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, ACBindings.CFellowship*, uint>)0x0056A160)(ref this, fellowship);
    // void __thiscall ClientFellowshipSystem::SelectNextFellow(ClientFellowshipSystem*)
    public void SelectNextFellow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, void>)0x0056A290)(ref this);
    // void __thiscall ClientFellowshipSystem::SelectPreviousFellow(ClientFellowshipSystem*)
    public void SelectPreviousFellow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, void>)0x0056A360)(ref this);
    // void __thiscall ClientFellowshipSystem::DeleteFellowship(ClientFellowshipSystem*)
    public void DeleteFellowship() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, void>)0x0056AB50)(ref this);
    // void __thiscall ClientFellowshipSystem::OnShutdown(ClientFellowshipSystem*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, void>)0x0056ABF0)(ref this);
    // unsigned int __thiscall ClientFellowshipSystem::Handle_Fellowship__Quit(ClientFellowshipSystem*,unsigned int)
    public uint Handle_Fellowship__Quit(uint quitter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, uint, uint>)0x0056AC30)(ref this, quitter);
    // unsigned int __thiscall ClientFellowshipSystem::Handle_Fellowship__Dismiss(ClientFellowshipSystem*,unsigned int)
    public uint Handle_Fellowship__Dismiss(uint dismissed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientFellowshipSystem, uint, uint>)0x0056ACB0)(ref this, dismissed);
}

