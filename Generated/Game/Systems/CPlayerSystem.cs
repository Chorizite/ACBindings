namespace ACBindings;

// CPlayerSystem
public unsafe struct CPlayerSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.ClientSystem BaseClass_ClientSystem; // ACBindings.ClientSystem
    public ACBindings.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.IInputActionCallback
    public ACBindings.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.QualityChangeHandler
    public ACBindings.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.ObjectRangeHandler

    // Statics
    public static ACBindings.CPlayerSystem* s_pPlayerSystem = (ACBindings.CPlayerSystem*)0x0086F0E4;

    // Child Types
    // CPlayerSystem_vtbl
    public unsafe struct CPlayerSystem_vtbl
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
    // CPlayerSystem::Enum14
    public enum Enum14 : uint
    {
    }
    // CPlayerSystem::Enum15
    public enum Enum15 : uint
    {
    }
    // CPlayerSystem::Enum16
    public enum Enum16 : uint
    {
    }
    // CPlayerSystem::Enum5
    public enum Enum5 : uint
    {
    }
    // CPlayerSystem::Enum6
    public enum Enum6 : uint
    {
    }
    // CPlayerSystem::Enum7
    public enum Enum7 : uint
    {
    }
    // CPlayerSystem::Enum8
    public enum Enum8 : uint
    {
    }

    // Members
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.accountID account_;
    public ACBindings.ClientCharGenState* m_pCharGenState;
    public ACBindings.CPlayerModule playerModule;
    public uint playerID;
    public byte m_accountHasThroneofDestiny;
    public double logOnRequestTime;
    public double logOffRequestTime;
    public double logOffTime;
    public double deleteCharRequestTime;
    public byte fReadyToEnterGame;
    public byte awaitingLogOn;
    public byte sendLoginCompletePending;
    public byte initialLoginComplete;
    public byte allContainedObjectsReceived;
    public byte player_initialized;
    public byte player_desc_received;
    public double playerInitTime;
    public byte loggingOff;
    public byte logOffRequested;
    public byte connectionLost;
    public byte awaitingExpiration;
    public double expirationTime;
    public uint inventoryMask;
    public uint clothingPriorityMask;
    public byte teleportInProgress;
    public float m_fLoad;
    public byte m_layoutFromFile;
    public uint lastFullyMergedSrcID;
    public uint lastFullyMergedDstID;
    public ACBindings.CInvSlotModule m_invSlotModule;
    public uint blockingID;
    public uint blockedID;
    public uint blockingDestID;
    public uint blockedSpellTargetID;
    public uint blockedSpellID;
    public ACBindings.UI_SLOT_SIDE blockedSide;
    public int unblockAttemptNum;
    public uint mOpenContainerID;
    public ACBindings.NIList__uint pending_components_list;
    public ACBindings.ComponentTracker* componentTracker;
    public ACBindings.List__ObjectRangeInfo m_objectRangeCheckList;
    public ACBindings.CContractTrackerTable m_contractTrackerTable;

    // Generated Constructor
    public CPlayerSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CPlayerSystem::Begin(CPlayerSystem*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x0055E130)(ref this);
    // CPlayerSystem* __cdecl CPlayerSystem::GetPlayerSystem()
    public static ACBindings.CPlayerSystem* GetPlayerSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.CPlayerSystem*>)0x0055E1D0)();
    // ClientCharGenState* __thiscall CPlayerSystem::GetCharGenState(CPlayerSystem*)
    public ACBindings.ClientCharGenState* GetCharGenState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, ACBindings.ClientCharGenState*>)0x0055E1E0)(ref this);
    // ComponentTracker* __thiscall CPlayerSystem::GetComponentTracker(CPlayerSystem*)
    public ACBindings.ComponentTracker* GetComponentTracker() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, ACBindings.ComponentTracker*>)0x0055E220)(ref this);
    // void __thiscall CPlayerSystem::RecvNotice_NewParentContainer(CPlayerSystem*,unsigned int)
    public void RecvNotice_NewParentContainer(uint i_newContainerID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, void>)0x0055E270)(ref this, i_newContainerID);
    // void __thiscall CPlayerSystem::SetTeleportInProgress(CPlayerSystem*,bool)
    public void SetTeleportInProgress(byte bInProgress) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, byte, void>)0x0055E2A0)(ref this, bInProgress);
    // void __thiscall CPlayerSystem::Handle_CharacterError(CPlayerSystem*,charError)
    public void Handle_CharacterError(ACBindings.charError error) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, ACBindings.charError, void>)0x0055E2F0)(ref this, error);
    // void __thiscall CPlayerSystem::Handle_CharacterDelete(CPlayerSystem*)
    public void Handle_CharacterDelete() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x0055E310)(ref this);
    // void __thiscall CPlayerSystem::Handle_AwaitingSubscriptionExpiration(CPlayerSystem*,unsigned int)
    public void Handle_AwaitingSubscriptionExpiration(uint secondsRemaining) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, void>)0x0055E380)(ref this, secondsRemaining);
    // bool __thiscall CPlayerSystem::AccountHasThroneOfDestiny(CPlayerSystem*)
    public byte AccountHasThroneOfDestiny() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, byte>)0x0055E470)(ref this);
    // void __thiscall CPlayerSystem::RestoreCharacter(CPlayerSystem*,unsigned int)
    public void RestoreCharacter(uint i_iidAvatar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, void>)0x0055E480)(ref this, i_iidAvatar);
    // void __thiscall CPlayerSystem::ExecuteLogOff(CPlayerSystem*)
    public void ExecuteLogOff() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x0055E4A0)(ref this);
    // void __thiscall CPlayerSystem::SetLogOffStarted(CPlayerSystem*)
    public void SetLogOffStarted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x0055E4F0)(ref this);
    // bool __thiscall CPlayerSystem::Farther(CPlayerSystem*,long double,unsigned int,long double,unsigned int)
    public byte Farther(double dist_a, uint id_a, double dist_b, uint id_b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, double, uint, double, uint, byte>)0x0055E550)(ref this, dist_a, id_a, dist_b, id_b);
    // float __thiscall CPlayerSystem::GetRadarRadius(CPlayerSystem*)
    public float GetRadarRadius() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, float>)0x0055E5A0)(ref this);
    // bool __thiscall CPlayerSystem::IsOutside(CPlayerSystem*)
    public byte IsOutside() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, byte>)0x0055E5C0)(ref this);
    // bool __thiscall CPlayerSystem::PlaceInBackpack(CPlayerSystem*,unsigned int,bool)
    public byte PlaceInBackpack(uint i_iidItem, byte bPlaceInMainPack) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, byte, byte>)0x0055E5E0)(ref this, i_iidItem, bPlaceInMainPack);
    // void __thiscall CPlayerSystem::ResetUnblocking(CPlayerSystem*)
    public void ResetUnblocking() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x0055E660)(ref this);
    // void __thiscall CPlayerSystem::RegisterInputMaps(CPlayerSystem*)
    public void RegisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x0055EAA0)(ref this);
    // void __thiscall CPlayerSystem::SetDisplayContractTracker(CPlayerSystem*,CContractTracker)
    public void SetDisplayContractTracker(ACBindings.CContractTracker contractTracker) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, ACBindings.CContractTracker, void>)0x0055EB30)(ref this, contractTracker);
    // unsigned int __thiscall CPlayerSystem::AddRef(CPlayerSystem*)
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint>)0x0055F0D0)(ref this);
    // TResult* __thiscall CPlayerSystem::QueryInterface(CPlayerSystem*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x0055F0E0)(ref this, result, i_rcInterface, o_ppvInterface);
    // void __thiscall CPlayerSystem::RecvNotice_ServerSaysAttemptFailed(CPlayerSystem*,unsigned int)
    public void RecvNotice_ServerSaysAttemptFailed(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, void>)0x0055F1B0)(ref this, itemID);
    // void __thiscall CPlayerSystem::Handle_CharGenVerificationResponse(CPlayerSystem*,void*,unsigned int)
    public void Handle_CharGenVerificationResponse(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, System.IntPtr, uint, void>)0x0055F620)(ref this, buff, size);
    // ComponentTrackerUpdate __thiscall CPlayerSystem::UpdateSpellComponent(CPlayerSystem*,ACCWeenieObject*,int)
    public ACBindings.ComponentTrackerUpdate UpdateSpellComponent(ACBindings.ACCWeenieObject* weenObj, int updateUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, ACBindings.ACCWeenieObject*, int, ACBindings.ComponentTrackerUpdate>)0x0055F870)(ref this, weenObj, updateUI);
    // void __thiscall CPlayerSystem::UnregisterObjectRangeHandler(CPlayerSystem*,ObjectRangeHandler*,unsigned int)
    public void UnregisterObjectRangeHandler(ACBindings.ObjectRangeHandler* handler, uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, ACBindings.ObjectRangeHandler*, uint, void>)0x0055F900)(ref this, handler, objectID);
    // void __thiscall CPlayerSystem::UnregisterAllObjectRangeHandlers(CPlayerSystem*,ObjectRangeHandler*)
    public void UnregisterAllObjectRangeHandlers(ACBindings.ObjectRangeHandler* handler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, ACBindings.ObjectRangeHandler*, void>)0x0055F930)(ref this, handler);
    // void __thiscall CPlayerSystem::OnShutdown(CPlayerSystem*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x0055FA60)(ref this);
    // bool __thiscall CPlayerSystem::AutoWieldIsLegal(CPlayerSystem*,unsigned int,int)
    public byte AutoWieldIsLegal(uint item, int quiet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, int, byte>)0x0055FAD0)(ref this, item, quiet);
    // bool __thiscall CPlayerSystem::AutoWearIsLegal(CPlayerSystem*,unsigned int,int*,int)
    public byte AutoWearIsLegal(uint item, int* blockedBySelf, int quiet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, int*, int, byte>)0x0055FCB0)(ref this, item, blockedBySelf, quiet);
    // void __thiscall CPlayerSystem::UpdateContractTrackerTable(CPlayerSystem*,const CContractTrackerTable*)
    public void UpdateContractTrackerTable(ACBindings.CContractTrackerTable* contractTrackerTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, ACBindings.CContractTrackerTable*, void>)0x0055FE30)(ref this, contractTrackerTable);
    // void __thiscall CPlayerSystem::UpdateContractTracker(CPlayerSystem*,CContractTracker,int)
    public void UpdateContractTracker(ACBindings.CContractTracker contractTracker, int deleteContract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, ACBindings.CContractTracker, int, void>)0x0055FF00)(ref this, contractTracker, deleteContract);
    // void __thiscall CPlayerSystem::CalculateObjectRangeChecks(CPlayerSystem*)
    public void CalculateObjectRangeChecks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x005600D0)(ref this);
    // void __thiscall CPlayerSystem::RecvNotice_ItemAttributesChanged(CPlayerSystem*,unsigned int,unsigned int)
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, uint, void>)0x005601D0)(ref this, i_target, i_attrib);
    // bool __thiscall CPlayerSystem::OnLoadChanged(CPlayerSystem*)
    public byte OnLoadChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, byte>)0x00560280)(ref this);
    // void __thiscall CPlayerSystem::Handle_Login__CharacterSet(CPlayerSystem*,void*,unsigned int)
    public void Handle_Login__CharacterSet(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, System.IntPtr, uint, void>)0x00560440)(ref this, buff, size);
    // void __thiscall CPlayerSystem::DeleteCharacter(CPlayerSystem*,unsigned int)
    public void DeleteCharacter(uint i_iidAvatar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, void>)0x005605A0)(ref this, i_iidAvatar);
    // bool __thiscall CPlayerSystem::LogOnCharacter(CPlayerSystem*,unsigned int)
    public byte LogOnCharacter(uint i_iidAvatar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, byte>)0x00560600)(ref this, i_iidAvatar);
    // void __thiscall CPlayerSystem::SelectNext(CPlayerSystem*,bool,bool,UI_SELECTION_TYPE,bool)
    public void SelectNext(byte closer, byte extreme, ACBindings.UI_SELECTION_TYPE sel_type, byte ignore_wielded) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, byte, byte, ACBindings.UI_SELECTION_TYPE, byte, void>)0x00560710)(ref this, closer, extreme, sel_type, ignore_wielded);
    // bool __thiscall CPlayerSystem::ObjectIsWithinRadarRange(CPlayerSystem*,unsigned int)
    public byte ObjectIsWithinRadarRange(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, byte>)0x00560CE0)(ref this, objectID);
    // bool __thiscall CPlayerSystem::InqPlayerCoords(CPlayerSystem*,long double*,long double*)
    public byte InqPlayerCoords(double* x, double* y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, double*, double*, byte>)0x00560E00)(ref this, x, y);
    // bool __thiscall CPlayerSystem::AutoWear(CPlayerSystem*,unsigned int,int*,int)
    public byte AutoWear(uint item, int* blockedBySelf, int quiet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, int*, int, byte>)0x00560F30)(ref this, item, blockedBySelf, quiet);
    // int __cdecl CPlayerSystem::IsOlthoi()
    public static int IsOlthoi() => ((delegate* unmanaged[Cdecl]<int>)0x00560F80)();
    // void __thiscall CPlayerSystem::RegisterObjectRangeHandler(CPlayerSystem*,ObjectRangeHandler*,unsigned int,long double,bool,bool,long double,long double)
    public void RegisterObjectRangeHandler(ACBindings.ObjectRangeHandler* handler, uint objectID, double range, byte useRadii, byte ignoreZDelta, double timeInterval, double timeOut) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, ACBindings.ObjectRangeHandler*, uint, double, byte, byte, double, double, void>)0x00561040)(ref this, handler, objectID, range, useRadii, ignoreZDelta, timeInterval, timeOut);
    // void __thiscall CPlayerSystem::CPlayerSystem(CPlayerSystem*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x005611E0)(ref this);
    // unsigned int __thiscall CPlayerSystem::Release(CPlayerSystem*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint>)0x00561400)(ref this);
    // void __thiscall CPlayerSystem::End(CPlayerSystem*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x00561430)(ref this);
    // void __thiscall CPlayerSystem::RecvNotice_SetSelectedItem(CPlayerSystem*,unsigned int,unsigned int)
    public void RecvNotice_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, uint, void>)0x00561490)(ref this, oldSelectedID, selectedID);
    // void __thiscall CPlayerSystem::RecvNotice_EnchantmentsChanged(CPlayerSystem*)
    public void RecvNotice_EnchantmentsChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x005615D0)(ref this);
    // void __thiscall CPlayerSystem::OnObjectRangeExit(CPlayerSystem*,unsigned int)
    public void OnObjectRangeExit(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, void>)0x005615E0)(ref this, objectID);
    // void __thiscall CPlayerSystem::OnQualityRemoved(CPlayerSystem*,CWeenieObject*,StatType,unsigned int)
    public void OnQualityRemoved(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, ACBindings.CWeenieObject*, ACBindings.StatType, uint, void>)0x00561660)(ref this, cwobj, stype, senum);
    // void __thiscall CPlayerSystem::SendQueryPluginData(CPlayerSystem*,unsigned int)
    public void SendQueryPluginData(uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, void>)0x00561670)(ref this, context);
    // bool __thiscall CPlayerSystem::AutoSort(CPlayerSystem*,unsigned int,int,int)
    public byte AutoSort(uint item, int wield, int quiet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, int, int, byte>)0x00561710)(ref this, item, wield, quiet);
    // bool __thiscall CPlayerSystem::AutoWield(CPlayerSystem*,unsigned int,UI_SLOT_SIDE,int,int,int,int)
    public byte AutoWield(uint item, ACBindings.UI_SLOT_SIDE slotSide, int quiet, int unblock, int autosortOnFail, int trySecondChoiceSide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, ACBindings.UI_SLOT_SIDE, int, int, int, int, byte>)0x005617D0)(ref this, item, slotSide, quiet, unblock, autosortOnFail, trySecondChoiceSide);
    // bool __thiscall CPlayerSystem::OnAction(CPlayerSystem*,const InputEvent*)
    public byte OnAction(ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, ACBindings.InputEvent*, byte>)0x00562600)(ref this, i_evt);
    // void __thiscall CPlayerSystem::OnEndCharacterSession(CPlayerSystem*)
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x00563610)(ref this);
    // void __thiscall CPlayerSystem::~CPlayerSystem(CPlayerSystem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x00563660)(ref this);
    // void __thiscall CPlayerSystem::Handle_AccountBooted(CPlayerSystem*,void*,unsigned int)
    public void Handle_AccountBooted(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, System.IntPtr, uint, void>)0x00563810)(ref this, buff, size);
    // void __thiscall CPlayerSystem::Handle_AccountBanned(CPlayerSystem*,void*,unsigned int)
    public void Handle_AccountBanned(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, System.IntPtr, uint, void>)0x00563970)(ref this, buff, size);
    // void __thiscall CPlayerSystem::RequestLogOff(CPlayerSystem*)
    public void RequestLogOff() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x00563B70)(ref this);
    // void __thiscall CPlayerSystem::SendLoginCompleteNotification(CPlayerSystem*)
    public void SendLoginCompleteNotification() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x00563C30)(ref this);
    // void __thiscall CPlayerSystem::AttemptSendLoginCompleteNotification(CPlayerSystem*)
    public void AttemptSendLoginCompleteNotification() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x00563CC0)(ref this);
    // bool __thiscall CPlayerSystem::UsingItem(CPlayerSystem*,unsigned int,int,int)
    public byte UsingItem(uint itemID, int useable, int forceUse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, int, int, byte>)0x00563D10)(ref this, itemID, useable, forceUse);
    // void __thiscall CPlayerSystem::UseTime(CPlayerSystem*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x00563EB0)(ref this);
    // void __thiscall CPlayerSystem::RecvNotice_ServerSaysMoveItem(CPlayerSystem*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, uint, uint, uint, uint, uint, int, uint, uint, void>)0x00564000)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);
    // void __thiscall CPlayerSystem::LogOffCharacter(CPlayerSystem*,bool)
    public void LogOffCharacter(byte immediate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, byte, void>)0x005642C0)(ref this, immediate);
    // void __thiscall CPlayerSystem::InitializePlayer(CPlayerSystem*)
    public void InitializePlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, void>)0x00564310)(ref this);
    // void __thiscall CPlayerSystem::Handle_PlayerDescription(CPlayerSystem*,void*,unsigned int)
    public void Handle_PlayerDescription(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerSystem, System.IntPtr, uint, void>)0x00564440)(ref this, buff, size);
}

