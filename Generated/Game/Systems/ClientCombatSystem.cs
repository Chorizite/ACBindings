namespace ACBindings;

// ClientCombatSystem
public unsafe struct ClientCombatSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.ClientSystem BaseClass_ClientSystem; // ACBindings.ClientSystem
    public ACBindings.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.IInputActionCallback
    public ACBindings.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.QualityChangeHandler

    // Statics
    public static ACBindings.ClientCombatSystem* s_pCombatSystem = (ACBindings.ClientCombatSystem*)0x0086EBBC;

    // Child Types
    // ClientCombatSystem_vtbl
    public unsafe struct ClientCombatSystem_vtbl
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
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public byte jump_pending;
    public byte m_bTrackingTarget;
    public ACBindings.COMBAT_MODE combatMode;
    public ACBindings.COMBAT_MODE pendingCombatMode;
    public ACBindings.ATTACK_HEIGHT requestedAttackHeight;
    public double buildStartTime;
    public byte buildInProgress;
    public ACBindings.PowerBarMode powerBarMode;
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
    // void __thiscall ClientCombatSystem::Begin(ClientCombatSystem*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056B1A0)(ref this);
    // ClientCombatSystem* __cdecl ClientCombatSystem::GetCombatSystem()
    public static ACBindings.ClientCombatSystem* GetCombatSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.ClientCombatSystem*>)0x0056B210)();
    // void __thiscall ClientCombatSystem::OnStartup(ClientCombatSystem*)
    public void OnStartup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056B220)(ref this);
    // void __thiscall ClientCombatSystem::OnShutdown(ClientCombatSystem*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056B250)(ref this);
    // unsigned int __thiscall ClientCombatSystem::Handle_Combat__QueryHealthResponse(ClientCombatSystem*,unsigned int,float)
    public uint Handle_Combat__QueryHealthResponse(uint target, float health) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, uint, float, uint>)0x0056B2A0)(ref this, target, health);
    // bool __thiscall ClientCombatSystem::CompatibleCombatMode(ClientCombatSystem*,COMBAT_MODE)
    public byte CompatibleCombatMode(ACBindings.COMBAT_MODE i_combatMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, ACBindings.COMBAT_MODE, byte>)0x0056B2C0)(ref this, i_combatMode);
    // bool __thiscall ClientCombatSystem::ObjectIsAttackable(ClientCombatSystem*,unsigned int)
    public byte ObjectIsAttackable(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, uint, byte>)0x0056B340)(ref this, objectID);
    // bool __thiscall ClientCombatSystem::RepeatAttackInProgress(ClientCombatSystem*)
    public byte RepeatAttackInProgress() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, byte>)0x0056B5A0)(ref this);
    // void __thiscall ClientCombatSystem::SetPowerBarLevel(ClientCombatSystem*,float)
    public void SetPowerBarLevel(float level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, float, void>)0x0056B5D0)(ref this, level);
    // void __thiscall ClientCombatSystem::HidePowerBar(ClientCombatSystem*)
    public void HidePowerBar() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056B5F0)(ref this);
    // unsigned int __thiscall ClientCombatSystem::GetAttackTarget(ClientCombatSystem*)
    public uint GetAttackTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, uint>)0x0056B630)(ref this);
    // void __thiscall ClientCombatSystem::UpdateTargetTracking(ClientCombatSystem*)
    public void UpdateTargetTracking() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056B690)(ref this);
    // void __thiscall ClientCombatSystem::FinishJump(ClientCombatSystem*)
    public void FinishJump() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056B6F0)(ref this);
    // void __thiscall ClientCombatSystem::RegisterInputMaps(ClientCombatSystem*,COMBAT_MODE,COMBAT_MODE)
    public void RegisterInputMaps(ACBindings.COMBAT_MODE i_CurrentMode, ACBindings.COMBAT_MODE i_PreviousMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, ACBindings.COMBAT_MODE, ACBindings.COMBAT_MODE, void>)0x0056B760)(ref this, i_CurrentMode, i_PreviousMode);
    // void __thiscall ClientCombatSystem::~ClientCombatSystem(ClientCombatSystem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056B8C0)(ref this);
    // unsigned int __thiscall ClientCombatSystem::Release(ClientCombatSystem*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, uint>)0x0056B960)(ref this);
    // TResult* __thiscall ClientCombatSystem::QueryInterface(ClientCombatSystem*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x0056B990)(ref this, result, i_rcInterface, o_ppvInterface);
    // void __thiscall ClientCombatSystem::HandleCommenceAttackEvent(ClientCombatSystem*)
    public void HandleCommenceAttackEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056BA60)(ref this);
    // void __thiscall ClientCombatSystem::StartPowerBarBuild(ClientCombatSystem*)
    public void StartPowerBarBuild() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056BAF0)(ref this);
    // float __thiscall ClientCombatSystem::GetPowerBarLevel(ClientCombatSystem*)
    public float GetPowerBarLevel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, float>)0x0056BB20)(ref this);
    // void __thiscall ClientCombatSystem::AbortAutomaticAttack(ClientCombatSystem*)
    public void AbortAutomaticAttack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056BBD0)(ref this);
    // void __thiscall ClientCombatSystem::TrackTarget(ClientCombatSystem*,bool)
    public void TrackTarget(byte i_bTrackTarget) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, byte, void>)0x0056BC10)(ref this, i_bTrackTarget);
    // void __thiscall ClientCombatSystem::OnBeginCharacterSession(ClientCombatSystem*)
    public void OnBeginCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056BC30)(ref this);
    // void __thiscall ClientCombatSystem::OnEndCharacterSession(ClientCombatSystem*)
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056BC70)(ref this);
    // void __thiscall ClientCombatSystem::CommenceJump(ClientCombatSystem*)
    public void CommenceJump() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056BCD0)(ref this);
    // float __thiscall ClientCombatSystem::GetJumpPowerLevel(ClientCombatSystem*)
    public float GetJumpPowerLevel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, float>)0x0056BD90)(ref this);
    // void __thiscall ClientCombatSystem::ClientCombatSystem(ClientCombatSystem*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056BDD0)(ref this);
    // void __thiscall ClientCombatSystem::DoJump(ClientCombatSystem*,bool)
    public void DoJump(byte autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, byte, void>)0x0056BE50)(ref this, autonomous);
    // COMBAT_MODE __thiscall ClientCombatSystem::GetDefaultCombatMode(ClientCombatSystem*,bool)
    public ACBindings.COMBAT_MODE GetDefaultCombatMode(byte quiet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, byte, ACBindings.COMBAT_MODE>)0x0056C050)(ref this, quiet);
    // LONG __thiscall ClientCombatSystem::HandleAttackerNotificationEvent(void*,int,char*,double,int,int,char,int)
    public int HandleAttackerNotificationEvent(int a2, sbyte* Source, double a4, int a5, int a6, sbyte a7, int a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, int, sbyte*, double, int, int, sbyte, int, int>)0x0056C160)(ref this, a2, Source, a4, a5, a6, a7, a8);
    // bool __thiscall ClientCombatSystem::PlayerInReadyPosition(ClientCombatSystem*,bool)
    public byte PlayerInReadyPosition(byte considerAttackingReady) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, byte, byte>)0x0056C570)(ref this, considerAttackingReady);
    // void __thiscall ClientCombatSystem::AttemptStartBuildingAttack(ClientCombatSystem*)
    public void AttemptStartBuildingAttack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056C850)(ref this);
    // void __thiscall ClientCombatSystem::ExecuteAttack(ClientCombatSystem*,ATTACK_HEIGHT,bool)
    public void ExecuteAttack(ACBindings.ATTACK_HEIGHT attackHeight, byte expectServerResponse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, ACBindings.ATTACK_HEIGHT, byte, void>)0x0056C8C0)(ref this, attackHeight, expectServerResponse);
    // void __thiscall ClientCombatSystem::AutoTarget(ClientCombatSystem*)
    public void AutoTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056C9D0)(ref this);
    // void __thiscall ClientCombatSystem::RecvNotice_SelectionChanged(ClientCombatSystem*)
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056CAD0)(ref this);
    // void __thiscall ClientCombatSystem::SetCombatMode(ClientCombatSystem*,COMBAT_MODE,bool)
    public void SetCombatMode(ACBindings.COMBAT_MODE i_NewCombatMode, byte i_bPlayerRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, ACBindings.COMBAT_MODE, byte, void>)0x0056CB80)(ref this, i_NewCombatMode, i_bPlayerRequested);
    // void __thiscall ClientCombatSystem::StartAttackRequest(ClientCombatSystem*)
    public void StartAttackRequest() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056CD90)(ref this);
    // void __thiscall ClientCombatSystem::EndAttackRequest(ClientCombatSystem*,ATTACK_HEIGHT,float)
    public void EndAttackRequest(ACBindings.ATTACK_HEIGHT attackHeight, float power) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, ACBindings.ATTACK_HEIGHT, float, void>)0x0056CE30)(ref this, attackHeight, power);
    // void __thiscall ClientCombatSystem::OnQualityChanged(ClientCombatSystem*,CWeenieObject*,StatType,unsigned int)
    public void OnQualityChanged(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, ACBindings.CWeenieObject*, ACBindings.StatType, uint, void>)0x0056CF00)(ref this, cwobj, stype, senum);
    // void __thiscall ClientCombatSystem::UseTime(ClientCombatSystem*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056CF40)(ref this);
    // int __thiscall ClientCombatSystem::HandlePlayerDeathEvent(ClientCombatSystem*,void*,unsigned int)
    public int HandlePlayerDeathEvent(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, System.IntPtr, uint, int>)0x0056D070)(ref this, buff, size);
    // int __thiscall ClientCombatSystem::HandleVictimNotificationEvent(ClientCombatSystem*,void*,unsigned int)
    public int HandleVictimNotificationEvent(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, System.IntPtr, uint, int>)0x0056D160)(ref this, buff, size);
    // void __thiscall ClientCombatSystem::HandleAttackDoneEvent(ClientCombatSystem*,const unsigned int)
    public void HandleAttackDoneEvent(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, uint, void>)0x0056D250)(ref this, etype);
    // LONG __thiscall ClientCombatSystem::HandleEvasionDefenderNotificationEvent(ClientCombatSystem*,char*)
    public int HandleEvasionDefenderNotificationEvent(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, sbyte*, int>)0x0056D370)(ref this, a2);
    // LONG __thiscall ClientCombatSystem::HandleEvasionAttackerNotificationEvent(void*,void (__thiscall**a2)(_DWORD, _DWORD))
    public int HandleEvasionAttackerNotificationEvent(delegate* unmanaged[Thiscall]<int, int, void>* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, delegate* unmanaged[Thiscall]<int, int, void>*, int>)0x0056D4F0)(ref this, a2);
    // void __thiscall ClientCombatSystem::ToggleCombatMode(ClientCombatSystem*)
    public void ToggleCombatMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, void>)0x0056D610)(ref this);
    // void __thiscall ClientCombatSystem::SetRequestedAttackHeight(ClientCombatSystem*,ATTACK_HEIGHT)
    public void SetRequestedAttackHeight(ACBindings.ATTACK_HEIGHT height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, ACBindings.ATTACK_HEIGHT, void>)0x0056D640)(ref this, height);
    // LONG __thiscall ClientCombatSystem::HandleDefenderNotificationEvent(ClientCombatSystem*,int*,int,double,int,int,int,char,int)
    public int HandleDefenderNotificationEvent(int* a2, int dtype, double a4, int ArgList, int a6, int a7, sbyte a8, int a9) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCombatSystem, int*, int, double, int, int, int, sbyte, int, int>)0x0056D670)(ref this, a2, dtype, a4, ArgList, a6, a7, a8, a9);
}

