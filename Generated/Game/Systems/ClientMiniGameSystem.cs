namespace ACBindings;

// ClientMiniGameSystem
public unsafe struct ClientMiniGameSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.ClientSystem BaseClass_ClientSystem; // ACBindings.ClientSystem

    // Statics
    public static ACBindings.ClientMiniGameSystem* s_pMiniGameSystem = (ACBindings.ClientMiniGameSystem*)0x0086E964;

    // Child Types
    // ClientMiniGameSystem_vtbl
    public unsafe struct ClientMiniGameSystem_vtbl
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
    // ClientMiniGameSystem::Enum13
    public enum Enum13 : uint
    {
    }
    // ClientMiniGameSystem::Enum14
    public enum Enum14 : uint
    {
    }
    // ClientMiniGameSystem::Enum15
    public enum Enum15 : uint
    {
    }
    // ClientMiniGameSystem::Enum16
    public enum Enum16 : uint
    {
    }
    // ClientMiniGameSystem::Enum4
    public enum Enum4 : uint
    {
    }

    // Members
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;

    // Generated Constructor
    public ClientMiniGameSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ClientMiniGameSystem::~ClientMiniGameSystem(ClientMiniGameSystem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMiniGameSystem, void>)0x005864D0)(ref this);
    // void __thiscall ClientMiniGameSystem::OnShutdown(ClientMiniGameSystem*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMiniGameSystem, void>)0x00586500)(ref this);
    // unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_JoinGameResponse(ClientMiniGameSystem*,unsigned int,int)
    public uint Handle_Game__Recv_JoinGameResponse(uint idGame, int iTeam) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMiniGameSystem, uint, int, uint>)0x00586520)(ref this, idGame, iTeam);
    // unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_StartGame(ClientMiniGameSystem*,unsigned int,int)
    public uint Handle_Game__Recv_StartGame(uint idGame, int iTeam) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMiniGameSystem, uint, int, uint>)0x00586540)(ref this, idGame, iTeam);
    // unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_MoveResponse(ClientMiniGameSystem*,unsigned int,int)
    public uint Handle_Game__Recv_MoveResponse(uint idGame, int iMoveResult) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMiniGameSystem, uint, int, uint>)0x00586560)(ref this, idGame, iMoveResult);
    // unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_OpponentTurn(ClientMiniGameSystem*,unsigned int,int,const GameMoveData*)
    public uint Handle_Game__Recv_OpponentTurn(uint idGame, int iTeam, ACBindings.GameMoveData* move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMiniGameSystem, uint, int, ACBindings.GameMoveData*, uint>)0x00586580)(ref this, idGame, iTeam, move);
    // unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_OppenentStalemateState(ClientMiniGameSystem*,unsigned int,int,int)
    public uint Handle_Game__Recv_OppenentStalemateState(uint idGame, int iTeam, int fOn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMiniGameSystem, uint, int, int, uint>)0x005865A0)(ref this, idGame, iTeam, fOn);
    // unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_GameOver(ClientMiniGameSystem*,unsigned int,int)
    public uint Handle_Game__Recv_GameOver(uint idGame, int iTeamWinner) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMiniGameSystem, uint, int, uint>)0x005865C0)(ref this, idGame, iTeamWinner);
    // TResult* __thiscall ClientMiniGameSystem::QueryInterface(ClientMiniGameSystem*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMiniGameSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x005865E0)(ref this, result, i_rcInterface, o_ppvInterface);
    // unsigned int __thiscall ClientMiniGameSystem::Release(ClientMiniGameSystem*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMiniGameSystem, uint>)0x005866B0)(ref this);
    // void __thiscall ClientMiniGameSystem::ClientMiniGameSystem(ClientMiniGameSystem*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMiniGameSystem, void>)0x005866E0)(ref this);
}

