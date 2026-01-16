namespace ACBindings.Internal;


/// <summary>
/// Manages client‑side mini‑game functionality, handling game events and interface queries while maintaining a Turbine reference count.
/// Serves as the central system for mini‑game interactions within the client application.
/// </summary>
public unsafe struct ClientMiniGameSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem

    // Statics
    public static ACBindings.Internal.ClientMiniGameSystem** s_pMiniGameSystem = (ACBindings.Internal.ClientMiniGameSystem**)0x0087190C;

    // Child Types
    public unsafe struct ClientMiniGameSystem_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnStartup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnBeginCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnEndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnShutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientMiniGameSystem*, ACBindings.Internal.ClientMiniGameSystem.Enum14> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

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

    /// <summary>Releases all resources owned by a ClientMiniGameSystem, including its Turbine reference count and notice handler, and restores base class virtual tables before destruction.
    /// <code>Offset: 0x005864D0
    /// void __thiscall ClientMiniGameSystem::~ClientMiniGameSystem(ClientMiniGameSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, void>)0x005864D0)(ref this);

    /// <summary>Shuts down the client mini‑game system by invoking its cleanup routine when a singleton instance exists, then clears the global reference.
    /// <code>Offset: 0x00586500
    /// void __thiscall ClientMiniGameSystem::OnShutdown(ClientMiniGameSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, void>)0x00586500)(ref this);

    /// <summary>Sends a join‑game response notice for the specified mini‑game ID and team assignment.
    /// <code>Offset: 0x00586520
    /// unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_JoinGameResponse(ClientMiniGameSystem*,unsigned int,int)</code>
    /// </summary>
    /// <param name="idGame">Identifier of the mini‑game to join.</param>
    /// <param name="iTeam">Index or identifier of the team selected by the player.</param>
    /// <returns>Zero, indicating successful handling.</returns>
    public uint Handle_Game__Recv_JoinGameResponse(uint idGame, int iTeam) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint, int, uint>)0x00586520)(ref this, idGame, iTeam);

    /// <summary>Receives notification that a mini‑game has started and forwards it to the local system via CM_Game::SendNotice_StartGame.
    /// <code>Offset: 0x00586540
    /// unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_StartGame(ClientMiniGameSystem*,unsigned int,int)</code>
    /// </summary>
    /// <param name="idGame">Identifier of the game being started.</param>
    /// <param name="iTeam">Index or identifier of the team initiating the start.</param>
    /// <returns>Zero, indicating successful handling.</returns>
    public uint Handle_Game__Recv_StartGame(uint idGame, int iTeam) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint, int, uint>)0x00586540)(ref this, idGame, iTeam);

    /// <summary>Handles the server's move response for a mini‑game by dispatching a notice with the result.
    /// <code>Offset: 0x00586560
    /// unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_MoveResponse(ClientMiniGameSystem*,unsigned int,int)</code>
    /// </summary>
    /// <param name="idGame">Identifier of the mini‑game receiving the move response.</param>
    /// <param name="iMoveResult">Integer code representing the outcome of the move attempt.</param>
    /// <returns>Zero, indicating that processing completed successfully.</returns>
    public uint Handle_Game__Recv_MoveResponse(uint idGame, int iMoveResult) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint, int, uint>)0x00586560)(ref this, idGame, iMoveResult);

    /// <summary>Processes an opponent’s turn during a mini‑game and broadcasts a corresponding notice to interested systems.
    /// <code>Offset: 0x00586580
    /// unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_OpponentTurn(ClientMiniGameSystem*,unsigned int,int,const GameMoveData*)</code>
    /// </summary>
    /// <param name="idGame">Identifier of the active game session.</param>
    /// <param name="iTeam">Index or identifier of the team that performed the move.</param>
    /// <param name="move">Details of the opponent's move, including type and target coordinates.</param>
    /// <returns>Zero indicating successful handling of the turn notification.</returns>
    public uint Handle_Game__Recv_OpponentTurn(uint idGame, int iTeam, ACBindings.Internal.GameMoveData* move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint, int, ACBindings.Internal.GameMoveData*, uint>)0x00586580)(ref this, idGame, iTeam, move);

    /// <summary>Handles reception of an opponent stalemate state notification and forwards it to the game's notice system.
    /// <code>Offset: 0x005865A0
    /// unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_OppenentStalemateState(ClientMiniGameSystem*,unsigned int,int,int)</code>
    /// </summary>
    /// <param name="idGame">Identifier of the game instance.</param>
    /// <param name="iTeam">Index or ID of the team involved in the stalemate offer.</param>
    /// <param name="fOn">Flag indicating whether the stalemate offer is active (non-zero) or withdrawn (zero).</param>
    /// <returns>Zero to indicate successful handling.</returns>
    public uint Handle_Game__Recv_OppenentStalemateState(uint idGame, int iTeam, int fOn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint, int, int, uint>)0x005865A0)(ref this, idGame, iTeam, fOn);

    /// <summary>Notifies the system that a mini‑game has finished and announces the winning team.
    /// <code>Offset: 0x005865C0
    /// unsigned int __thiscall ClientMiniGameSystem::Handle_Game__Recv_GameOver(ClientMiniGameSystem*,unsigned int,int)</code>
    /// </summary>
    /// <param name="idGame">Identifier of the mini‑game that ended.</param>
    /// <param name="iTeamWinner">Index or identifier of the team that won the game.</param>
    /// <returns>Zero indicating successful handling of the game‑over event.</returns>
    public uint Handle_Game__Recv_GameOver(uint idGame, int iTeamWinner) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint, int, uint>)0x005865C0)(ref this, idGame, iTeamWinner);

    /// <summary>Attempts to retrieve an interface implementation matching the specified GUID from a mini‑game system.
    /// <code>Offset: 0x005865E0
    /// TResult* __thiscall ClientMiniGameSystem::QueryInterface(ClientMiniGameSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="this">The ClientMiniGameSystem instance on which QueryInterface is invoked.</param>
    /// <param name="result">Receives a status code: zero for success, or E_NOINTERFACE (-2147467262) if no match is found.</param>
    /// <param name="i_rcInterface">GUID identifying the interface requested.</param>
    /// <param name="o_ppvInterface">Output pointer that receives the address of the requested interface; may be null if only a status check is desired.</param>
    /// <returns>Returns the same TResult* supplied in result, allowing for chaining or direct use of the status code.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x005865E0)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Releases a reference to the mini‑game system, destroying it when its reference count reaches zero.
    /// <code>Offset: 0x005866B0
    /// unsigned int __thiscall ClientMiniGameSystem::Release(ClientMiniGameSystem*)</code>
    /// </summary>
    /// <returns>The remaining reference count after release; zero indicates the object has been freed.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, uint>)0x005866B0)(ref this);

    /// <summary>Initializes a ClientMiniGameSystem object by configuring its interface and notice handler virtual tables, establishing a reference count, and setting the static pointer to the created instance.
    /// <code>Offset: 0x005866E0
    /// void __thiscall ClientMiniGameSystem::ClientMiniGameSystem(ClientMiniGameSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMiniGameSystem, void>)0x005866E0)(ref this);
}

