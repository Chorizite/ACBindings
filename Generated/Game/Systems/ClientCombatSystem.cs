namespace ACBindings.Internal;

public unsafe struct ClientCombatSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler

    // Statics
    public static ACBindings.Internal.ClientCombatSystem* s_pCombatSystem = (ACBindings.Internal.ClientCombatSystem*)0x0087166C;

    // Child Types
    public unsafe struct ClientCombatSystem_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientCombatSystem*, ACBindings.Internal.ClientCombatSystem.Enum9> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientCombatSystem::Enum10
    public enum Enum10 : uint
    {
    }
    // ClientCombatSystem::Enum11
    public enum Enum11 : uint
    {
    }
    // ClientCombatSystem::Enum12
    public enum Enum12 : uint
    {
    }
    // ClientCombatSystem::Enum4
    public enum Enum4 : uint
    {
    }
    // ClientCombatSystem::Enum8
    public enum Enum8 : uint
    {
    }
    // ClientCombatSystem::Enum9
    public enum Enum9 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public byte jump_pending;
    public byte m_bTrackingTarget;
    public ACBindings.Internal.COMBAT_MODE combatMode;
    public ACBindings.Internal.COMBAT_MODE pendingCombatMode;
    public ACBindings.Internal.ATTACK_HEIGHT requestedAttackHeight;
    public double buildStartTime;
    public byte buildInProgress;
    public ACBindings.Internal.PowerBarMode powerBarMode;
    public float latestPowerBarLevel;
    public byte attackInProgress;
    public byte attackServerResponsePending;
    public byte attackRequestInProgress;
    public float requestedAttackPower;
    public byte repeatAttacking;
    public byte currentBuildIsAutomatic;
    public byte targetWillinglyLost;
    public byte attackWhenResponseReceived;
    public float attackWhenResponseReceived_Power;
    public float m_rUIRequestedPower;
    public byte m_bAdvancedCombatMode;
    public double lastAttackedTime;

    // Generated Constructor
    public ClientCombatSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0056B1A0
    /// void __thiscall ClientCombatSystem::Begin(ClientCombatSystem*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B1A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056B210
    /// ClientCombatSystem* __cdecl ClientCombatSystem::GetCombatSystem()</code>
    /// </summary>
    public static ACBindings.Internal.ClientCombatSystem* GetCombatSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientCombatSystem*>)0x0056B210)();

    /// <summary>
    /// <code>Offset: 0x0056B220
    /// void __thiscall ClientCombatSystem::OnStartup(ClientCombatSystem*)</code>
    /// </summary>
    public void OnStartup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B220)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056B250
    /// void __thiscall ClientCombatSystem::OnShutdown(ClientCombatSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B250)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056B2A0
    /// unsigned int __thiscall ClientCombatSystem::Handle_Combat__QueryHealthResponse(ClientCombatSystem*,unsigned int,float)</code>
    /// </summary>
    public uint Handle_Combat__QueryHealthResponse(uint target, float health) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, uint, float, uint>)0x0056B2A0)(ref this, target, health);

    /// <summary>
    /// <code>Offset: 0x0056B2C0
    /// bool __thiscall ClientCombatSystem::CompatibleCombatMode(ClientCombatSystem*,COMBAT_MODE)</code>
    /// </summary>
    public byte CompatibleCombatMode(ACBindings.Internal.COMBAT_MODE i_combatMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.COMBAT_MODE, byte>)0x0056B2C0)(ref this, i_combatMode);

    /// <summary>
    /// <code>Offset: 0x0056B340
    /// bool __thiscall ClientCombatSystem::ObjectIsAttackable(ClientCombatSystem*,unsigned int)</code>
    /// </summary>
    public byte ObjectIsAttackable(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, uint, byte>)0x0056B340)(ref this, objectID);

    /// <summary>
    /// <code>Offset: 0x0056B5A0
    /// bool __thiscall ClientCombatSystem::RepeatAttackInProgress(ClientCombatSystem*)</code>
    /// </summary>
    public byte RepeatAttackInProgress() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, byte>)0x0056B5A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056B5D0
    /// void __thiscall ClientCombatSystem::SetPowerBarLevel(ClientCombatSystem*,float)</code>
    /// </summary>
    public void SetPowerBarLevel(float level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, float, void>)0x0056B5D0)(ref this, level);

    /// <summary>
    /// <code>Offset: 0x0056B5F0
    /// void __thiscall ClientCombatSystem::HidePowerBar(ClientCombatSystem*)</code>
    /// </summary>
    public void HidePowerBar() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B5F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056B630
    /// unsigned int __thiscall ClientCombatSystem::GetAttackTarget(ClientCombatSystem*)</code>
    /// </summary>
    public uint GetAttackTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, uint>)0x0056B630)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056B690
    /// void __thiscall ClientCombatSystem::UpdateTargetTracking(ClientCombatSystem*)</code>
    /// </summary>
    public void UpdateTargetTracking() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B690)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056B6F0
    /// void __thiscall ClientCombatSystem::FinishJump(ClientCombatSystem*)</code>
    /// </summary>
    public void FinishJump() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B6F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056B760
    /// void __thiscall ClientCombatSystem::RegisterInputMaps(ClientCombatSystem*,COMBAT_MODE,COMBAT_MODE)</code>
    /// </summary>
    public void RegisterInputMaps(ACBindings.Internal.COMBAT_MODE i_CurrentMode, ACBindings.Internal.COMBAT_MODE i_PreviousMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.COMBAT_MODE, ACBindings.Internal.COMBAT_MODE, void>)0x0056B760)(ref this, i_CurrentMode, i_PreviousMode);

    /// <summary>
    /// <code>Offset: 0x0056B8C0
    /// void __thiscall ClientCombatSystem::~ClientCombatSystem(ClientCombatSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B8C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056B960
    /// unsigned int __thiscall ClientCombatSystem::Release(ClientCombatSystem*)</code>
    /// </summary>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, uint>)0x0056B960)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056B990
    /// TResult* __thiscall ClientCombatSystem::QueryInterface(ClientCombatSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x0056B990)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>
    /// <code>Offset: 0x0056BA60
    /// void __thiscall ClientCombatSystem::HandleCommenceAttackEvent(ClientCombatSystem*)</code>
    /// </summary>
    public void HandleCommenceAttackEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BA60)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056BAF0
    /// void __thiscall ClientCombatSystem::StartPowerBarBuild(ClientCombatSystem*)</code>
    /// </summary>
    public void StartPowerBarBuild() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BAF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056BB20
    /// float __thiscall ClientCombatSystem::GetPowerBarLevel(ClientCombatSystem*)</code>
    /// </summary>
    public float GetPowerBarLevel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, float>)0x0056BB20)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056BBD0
    /// void __thiscall ClientCombatSystem::AbortAutomaticAttack(ClientCombatSystem*)</code>
    /// </summary>
    public void AbortAutomaticAttack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BBD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056BC10
    /// void __thiscall ClientCombatSystem::TrackTarget(ClientCombatSystem*,bool)</code>
    /// </summary>
    public void TrackTarget(byte i_bTrackTarget) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, byte, void>)0x0056BC10)(ref this, i_bTrackTarget);

    /// <summary>
    /// <code>Offset: 0x0056BC30
    /// void __thiscall ClientCombatSystem::OnBeginCharacterSession(ClientCombatSystem*)</code>
    /// </summary>
    public void OnBeginCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BC30)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056BC70
    /// void __thiscall ClientCombatSystem::OnEndCharacterSession(ClientCombatSystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BC70)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056BCD0
    /// void __thiscall ClientCombatSystem::CommenceJump(ClientCombatSystem*)</code>
    /// </summary>
    public void CommenceJump() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BCD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056BD90
    /// float __thiscall ClientCombatSystem::GetJumpPowerLevel(ClientCombatSystem*)</code>
    /// </summary>
    public float GetJumpPowerLevel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, float>)0x0056BD90)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056BDD0
    /// void __thiscall ClientCombatSystem::ClientCombatSystem(ClientCombatSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BDD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056BE50
    /// void __thiscall ClientCombatSystem::DoJump(ClientCombatSystem*,bool)</code>
    /// </summary>
    public void DoJump(byte autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, byte, void>)0x0056BE50)(ref this, autonomous);

    /// <summary>
    /// <code>Offset: 0x0056C050
    /// COMBAT_MODE __thiscall ClientCombatSystem::GetDefaultCombatMode(ClientCombatSystem*,bool)</code>
    /// </summary>
    public ACBindings.Internal.COMBAT_MODE GetDefaultCombatMode(byte quiet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, byte, ACBindings.Internal.COMBAT_MODE>)0x0056C050)(ref this, quiet);

    /// <summary>
    /// <code>Offset: 0x0056C160
    /// LONG __thiscall ClientCombatSystem::HandleAttackerNotificationEvent(void*,int,char*,double,int,int,char,int)</code>
    /// </summary>
    public int HandleAttackerNotificationEvent(int a2, sbyte* Source, double a4, int a5, int a6, sbyte a7, int a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, int, sbyte*, double, int, int, sbyte, int, int>)0x0056C160)(ref this, a2, Source, a4, a5, a6, a7, a8);

    /// <summary>
    /// <code>Offset: 0x0056C570
    /// bool __thiscall ClientCombatSystem::PlayerInReadyPosition(ClientCombatSystem*,bool)</code>
    /// </summary>
    public byte PlayerInReadyPosition(byte considerAttackingReady) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, byte, byte>)0x0056C570)(ref this, considerAttackingReady);

    /// <summary>
    /// <code>Offset: 0x0056C850
    /// void __thiscall ClientCombatSystem::AttemptStartBuildingAttack(ClientCombatSystem*)</code>
    /// </summary>
    public void AttemptStartBuildingAttack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056C850)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056C8C0
    /// void __thiscall ClientCombatSystem::ExecuteAttack(ClientCombatSystem*,ATTACK_HEIGHT,bool)</code>
    /// </summary>
    public void ExecuteAttack(ACBindings.Internal.ATTACK_HEIGHT attackHeight, byte expectServerResponse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.ATTACK_HEIGHT, byte, void>)0x0056C8C0)(ref this, attackHeight, expectServerResponse);

    /// <summary>
    /// <code>Offset: 0x0056C9D0
    /// void __thiscall ClientCombatSystem::AutoTarget(ClientCombatSystem*)</code>
    /// </summary>
    public void AutoTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056C9D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056CAD0
    /// void __thiscall ClientCombatSystem::RecvNotice_SelectionChanged(ClientCombatSystem*)</code>
    /// </summary>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056CAD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056CB80
    /// void __thiscall ClientCombatSystem::SetCombatMode(ClientCombatSystem*,COMBAT_MODE,bool)</code>
    /// </summary>
    public void SetCombatMode(ACBindings.Internal.COMBAT_MODE i_NewCombatMode, byte i_bPlayerRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.COMBAT_MODE, byte, void>)0x0056CB80)(ref this, i_NewCombatMode, i_bPlayerRequested);

    /// <summary>
    /// <code>Offset: 0x0056CD90
    /// void __thiscall ClientCombatSystem::StartAttackRequest(ClientCombatSystem*)</code>
    /// </summary>
    public void StartAttackRequest() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056CD90)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056CE30
    /// void __thiscall ClientCombatSystem::EndAttackRequest(ClientCombatSystem*,ATTACK_HEIGHT,float)</code>
    /// </summary>
    public void EndAttackRequest(ACBindings.Internal.ATTACK_HEIGHT attackHeight, float power) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.ATTACK_HEIGHT, float, void>)0x0056CE30)(ref this, attackHeight, power);

    /// <summary>
    /// <code>Offset: 0x0056CF00
    /// void __thiscall ClientCombatSystem::OnQualityChanged(ClientCombatSystem*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public void OnQualityChanged(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x0056CF00)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x0056CF40
    /// void __thiscall ClientCombatSystem::UseTime(ClientCombatSystem*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056CF40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056D070
    /// int __thiscall ClientCombatSystem::HandlePlayerDeathEvent(ClientCombatSystem*,void*,unsigned int)</code>
    /// </summary>
    public int HandlePlayerDeathEvent(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, System.IntPtr, uint, int>)0x0056D070)(ref this, buff, size);

    /// <summary>
    /// <code>Offset: 0x0056D160
    /// int __thiscall ClientCombatSystem::HandleVictimNotificationEvent(ClientCombatSystem*,void*,unsigned int)</code>
    /// </summary>
    public int HandleVictimNotificationEvent(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, System.IntPtr, uint, int>)0x0056D160)(ref this, buff, size);

    /// <summary>
    /// <code>Offset: 0x0056D250
    /// void __thiscall ClientCombatSystem::HandleAttackDoneEvent(ClientCombatSystem*,const unsigned int)</code>
    /// </summary>
    public void HandleAttackDoneEvent(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, uint, void>)0x0056D250)(ref this, etype);

    /// <summary>
    /// <code>Offset: 0x0056D370
    /// LONG __thiscall ClientCombatSystem::HandleEvasionDefenderNotificationEvent(ClientCombatSystem*,char*)</code>
    /// </summary>
    public int HandleEvasionDefenderNotificationEvent(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, sbyte*, int>)0x0056D370)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0056D4F0
    /// LONG __thiscall ClientCombatSystem::HandleEvasionAttackerNotificationEvent(void*,void (__thiscall**a2)(_DWORD, _DWORD))</code>
    /// </summary>
    public int HandleEvasionAttackerNotificationEvent(delegate* unmanaged[Thiscall]<int, int, void>* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, delegate* unmanaged[Thiscall]<int, int, void>*, int>)0x0056D4F0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0056D610
    /// void __thiscall ClientCombatSystem::ToggleCombatMode(ClientCombatSystem*)</code>
    /// </summary>
    public void ToggleCombatMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056D610)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056D640
    /// void __thiscall ClientCombatSystem::SetRequestedAttackHeight(ClientCombatSystem*,ATTACK_HEIGHT)</code>
    /// </summary>
    public void SetRequestedAttackHeight(ACBindings.Internal.ATTACK_HEIGHT height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.ATTACK_HEIGHT, void>)0x0056D640)(ref this, height);

    /// <summary>
    /// <code>Offset: 0x0056D670
    /// LONG __thiscall ClientCombatSystem::HandleDefenderNotificationEvent(ClientCombatSystem*,int*,int,double,int,int,int,char,int)</code>
    /// </summary>
    public int HandleDefenderNotificationEvent(int* a2, int dtype, double a4, int ArgList, int a6, int a7, sbyte a8, int a9) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, int*, int, double, int, int, int, sbyte, int, int>)0x0056D670)(ref this, a2, dtype, a4, ArgList, a6, a7, a8, a9);
}

