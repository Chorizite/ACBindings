namespace ACBindings.Internal;

public unsafe struct ClientMiniGameSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem

    // Statics
    public static ACBindings.Internal.ClientMiniGameSystem* s_pMiniGameSystem = (ACBindings.Internal.ClientMiniGameSystem*)0x0087190C;

    // Child Types
    public unsafe struct ClientMiniGameSystem_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientMiniGameSystem*, ACBindings.Internal.ClientMiniGameSystem.Enum14> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

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
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;

    // Generated Constructor
    public ClientMiniGameSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005864D0
    /// void __thiscall ClientMiniGameSystem::~ClientMiniGameSystem(ClientMiniGameSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, void>)0x005864D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00586500
    /// void __thiscall ClientMiniGameSystem::OnShutdown(ClientMiniGameSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, void>)0x00586500)(ref this);

    /// <summary>
    /// <code>Offset: 0x00586520
    /// unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_JoinGameResponse(ClientMiniGameSystem*,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Game__Recv_JoinGameResponse(uint idGame, int iTeam) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint, int, uint>)0x00586520)(ref this, idGame, iTeam);

    /// <summary>
    /// <code>Offset: 0x00586540
    /// unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_StartGame(ClientMiniGameSystem*,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Game__Recv_StartGame(uint idGame, int iTeam) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint, int, uint>)0x00586540)(ref this, idGame, iTeam);

    /// <summary>
    /// <code>Offset: 0x00586560
    /// unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_MoveResponse(ClientMiniGameSystem*,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Game__Recv_MoveResponse(uint idGame, int iMoveResult) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint, int, uint>)0x00586560)(ref this, idGame, iMoveResult);

    /// <summary>
    /// <code>Offset: 0x00586580
    /// unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_OpponentTurn(ClientMiniGameSystem*,unsigned int,int,const GameMoveData*)</code>
    /// </summary>
    public uint Handle_Game__Recv_OpponentTurn(uint idGame, int iTeam, ACBindings.Internal.GameMoveData* move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint, int, ACBindings.Internal.GameMoveData*, uint>)0x00586580)(ref this, idGame, iTeam, move);

    /// <summary>
    /// <code>Offset: 0x005865A0
    /// unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_OppenentStalemateState(ClientMiniGameSystem*,unsigned int,int,int)</code>
    /// </summary>
    public uint Handle_Game__Recv_OppenentStalemateState(uint idGame, int iTeam, int fOn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint, int, int, uint>)0x005865A0)(ref this, idGame, iTeam, fOn);

    /// <summary>
    /// <code>Offset: 0x005865C0
    /// unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_GameOver(ClientMiniGameSystem*,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Game__Recv_GameOver(uint idGame, int iTeamWinner) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint, int, uint>)0x005865C0)(ref this, idGame, iTeamWinner);

    /// <summary>
    /// <code>Offset: 0x005865E0
    /// TResult* __thiscall ClientMiniGameSystem::QueryInterface(ClientMiniGameSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x005865E0)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>
    /// <code>Offset: 0x005866B0
    /// unsigned int __thiscall ClientMiniGameSystem::Release(ClientMiniGameSystem*)</code>
    /// </summary>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint>)0x005866B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005866E0
    /// void __thiscall ClientMiniGameSystem::ClientMiniGameSystem(ClientMiniGameSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, void>)0x005866E0)(ref this);
}

