namespace ACBindings.Internal;

public unsafe struct ClientUISystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Statics
    public static ACBindings.Internal.ClientUISystem* s_pUISystem = (ACBindings.Internal.ClientUISystem*)0x00871354;

    // Child Types
    public unsafe struct ClientUISystem_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientUISystem*, ACBindings.Internal.ClientUISystem.Enum6> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientUISystem::Enum17
    public enum Enum17 : uint
    {
    }
    // ClientUISystem::Enum18
    public enum Enum18 : uint
    {
    }
    // ClientUISystem::Enum19
    public enum Enum19 : uint
    {
    }
    // ClientUISystem::Enum6
    public enum Enum6 : uint
    {
    }
    // ClientUISystem::Enum7
    public enum Enum7 : uint
    {
    }
    // ClientUISystem::Enum8
    public enum Enum8 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public uint m_cBusy;
    public uint groundObject;
    public uint requestedGroundObject;
    public uint vendorID;
    public uint attemptOpenVendorID;
    public uint attemptSaleObjectID;
    public ACBindings.Internal.Target_Mode targetMode;
    public ACBindings.Internal.IDClass____tagDataID m_didCurrentCursor;
    public ACBindings.Internal.CSoundTable* soundTable;
    public byte m_bLeaveTargetMode;
    public ACBindings.Internal.CameraSet* m_pCameraSet;
    public byte m_bRadarVisible;
    public byte m_bRadarBlank;

    // Generated Constructor
    public ClientUISystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00564D30
    /// ClientUISystem* __cdecl ClientUISystem::GetUISystem()</code>
    /// </summary>
    public static ACBindings.Internal.ClientUISystem* GetUISystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientUISystem*>)0x00564D30)();

    /// <summary>
    /// <code>Offset: 0x00564D40
    /// void __thiscall ClientUISystem::OnStartup(ClientUISystem*)</code>
    /// </summary>
    public void OnStartup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00564D40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00564D50
    /// const CSoundTable* __thiscall ClientUISystem::GetUISoundTable(ClientUISystem*)</code>
    /// </summary>
    public ACBindings.Internal.CSoundTable* GetUISoundTable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.CSoundTable*>)0x00564D50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00564D80
    /// unsigned int __thiscall ClientUISystem::Handle_Item__QueryItemManaResponse(ClientUISystem*,unsigned int,float,int)</code>
    /// </summary>
    public uint Handle_Item__QueryItemManaResponse(uint target, float mana, int fSuccess) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, float, int, uint>)0x00564D80)(ref this, target, mana, fSuccess);

    /// <summary>
    /// <code>Offset: 0x00564DB0
    /// void __thiscall ClientUISystem::AttemptSellToVendor(ClientUISystem*,unsigned int,unsigned int)</code>
    /// </summary>
    public void AttemptSellToVendor(uint vendorID, uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, uint, void>)0x00564DB0)(ref this, vendorID, objectID);

    /// <summary>
    /// <code>Offset: 0x00564E10
    /// void __thiscall ClientUISystem::CloseVendor(ClientUISystem*,bool)</code>
    /// </summary>
    public void CloseVendor(byte updating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, byte, void>)0x00564E10)(ref this, updating);

    /// <summary>
    /// <code>Offset: 0x00564E40
    /// int __stdcall ClientUISystem::Handle_Character__ConfirmationRequest(int,int,int)</code>
    /// </summary>
    public static int Handle_Character__ConfirmationRequest(int a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<int, int, int, int>)0x00564E40)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00564F20
    /// unsigned int __thiscall ClientUISystem::Handle_Character__ConfirmationDone(ClientUISystem*,int,unsigned int)</code>
    /// </summary>
    public uint Handle_Character__ConfirmationDone(int confirm, uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, int, uint, uint>)0x00564F20)(ref this, confirm, context);

    /// <summary>
    /// <code>Offset: 0x00564F40
    /// int __stdcall ClientUISystem::Handle_Login__WorldInfo(int,int,int)</code>
    /// </summary>
    public static int Handle_Login__WorldInfo(int a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<int, int, int, int>)0x00564F40)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00564F60
    /// void __thiscall ClientUISystem::InitializeCameraSet(ClientUISystem*,SmartBox*)</code>
    /// </summary>
    public void InitializeCameraSet(ACBindings.Internal.SmartBox* i_pSmartBox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.SmartBox*, void>)0x00564F60)(ref this, i_pSmartBox);

    /// <summary>
    /// <code>Offset: 0x00564F90
    /// CameraSet* __thiscall ClientUISystem::AccessCameraSet(ClientUISystem*)</code>
    /// </summary>
    public ACBindings.Internal.CameraSet* AccessCameraSet() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.CameraSet*>)0x00564F90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00564FA0
    /// void __thiscall ClientUISystem::RecvNotice_ToggleChatEntry(ClientUISystem*,bool)</code>
    /// </summary>
    public void RecvNotice_ToggleChatEntry(byte i_bActive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, byte, void>)0x00564FA0)(ref this, i_bActive);

    /// <summary>
    /// <code>Offset: 0x00564FC0
    /// unsigned int __thiscall ClientUISystem::Handle_Social__FriendsUpdate(ClientUISystem*,const FriendDataList*,int)</code>
    /// </summary>
    public uint Handle_Social__FriendsUpdate(ACBindings.Internal.FriendDataList* friendDataList, int updateType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.FriendDataList*, int, uint>)0x00564FC0)(ref this, friendDataList, updateType);

    /// <summary>
    /// <code>Offset: 0x00564FE0
    /// unsigned int __thiscall ClientUISystem::Handle_Social__CharacterTitleTable(ClientUISystem*,const CharacterTitleTable*)</code>
    /// </summary>
    public uint Handle_Social__CharacterTitleTable(ACBindings.Internal.CharacterTitleTable* titleTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.CharacterTitleTable*, uint>)0x00564FE0)(ref this, titleTable);

    /// <summary>
    /// <code>Offset: 0x00565000
    /// unsigned int __thiscall ClientUISystem::Handle_Social__AddOrSetCharacterTitle(ClientUISystem*,unsigned int,int)</code>
    /// </summary>
    public uint Handle_Social__AddOrSetCharacterTitle(uint newTitle, int bSetAsDisplayTitle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, int, uint>)0x00565000)(ref this, newTitle, bSetAsDisplayTitle);

    /// <summary>
    /// <code>Offset: 0x00565030
    /// unsigned int __thiscall ClientUISystem::Handle_Social__SendClientContractTrackerTable(ClientUISystem*,const CContractTrackerTable*)</code>
    /// </summary>
    public uint Handle_Social__SendClientContractTrackerTable(ACBindings.Internal.CContractTrackerTable* contractTrackerTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.CContractTrackerTable*, uint>)0x00565030)(ref this, contractTrackerTable);

    /// <summary>
    /// <code>Offset: 0x00565050
    /// int __stdcall ClientUISystem::Handle_Character__StartBarber(int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int)</code>
    /// </summary>
    public static int Handle_Character__StartBarber(int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12, int a13, int a14, int a15, int a16) => ((delegate* unmanaged[Stdcall]<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>)0x00565050)(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16);

    /// <summary>
    /// <code>Offset: 0x005650B0
    /// void __thiscall ClientUISystem::~ClientUISystem(ClientUISystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x005650B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00565140
    /// unsigned int __thiscall ClientUISystem::Release(ClientUISystem*)</code>
    /// </summary>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint>)0x00565140)(ref this);

    /// <summary>
    /// <code>Offset: 0x00565170
    /// void __thiscall ClientUISystem::OnShutdown(ClientUISystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565170)(ref this);

    /// <summary>
    /// <code>Offset: 0x005651E0
    /// TResult* __thiscall ClientUISystem::QueryInterface(ClientUISystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x005651E0)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>
    /// <code>Offset: 0x005652B0
    /// void __thiscall ClientUISystem::SetGroundObject(ClientUISystem*,unsigned int,bool)</code>
    /// </summary>
    public void SetGroundObject(uint groundObject, byte askServer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, byte, void>)0x005652B0)(ref this, groundObject, askServer);

    /// <summary>
    /// <code>Offset: 0x00565380
    /// void __thiscall ClientUISystem::OnBeginCharacterSession(ClientUISystem*)</code>
    /// </summary>
    public void OnBeginCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565380)(ref this);

    /// <summary>
    /// <code>Offset: 0x005653D0
    /// void __thiscall ClientUISystem::UpdateCursorState(ClientUISystem*)</code>
    /// </summary>
    public void UpdateCursorState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x005653D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005654F0
    /// unsigned int __thiscall ClientUISystem::Handle_Social__SendClientContractTracker(ClientUISystem*,const CContractTracker*,int,int)</code>
    /// </summary>
    public uint Handle_Social__SendClientContractTracker(ACBindings.Internal.CContractTracker* contractTracker, int bDeleteContract, int bSetAsDisplayContract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.CContractTracker*, int, int, uint>)0x005654F0)(ref this, contractTracker, bDeleteContract, bSetAsDisplayContract);

    /// <summary>
    /// <code>Offset: 0x00565540
    /// void __thiscall ClientUISystem::ClientUISystem(ClientUISystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565540)(ref this);

    /// <summary>
    /// <code>Offset: 0x00565610
    /// void __thiscall ClientUISystem::IncrementBusyCount(ClientUISystem*)</code>
    /// </summary>
    public void IncrementBusyCount() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565610)(ref this);

    /// <summary>
    /// <code>Offset: 0x00565630
    /// void __thiscall ClientUISystem::DecrementBusyCount(ClientUISystem*)</code>
    /// </summary>
    public void DecrementBusyCount() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565630)(ref this);

    /// <summary>
    /// <code>Offset: 0x00565640
    /// void __thiscall ClientUISystem::CleanUpGameUI(ClientUISystem*)</code>
    /// </summary>
    public void CleanUpGameUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565640)(ref this);

    /// <summary>
    /// <code>Offset: 0x005656A0
    /// unsigned int __thiscall ClientUISystem::Handle_Item__UseDone(ClientUISystem*,const unsigned int)</code>
    /// </summary>
    public uint Handle_Item__UseDone(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, uint>)0x005656A0)(ref this, etype);

    /// <summary>
    /// <code>Offset: 0x005656E0
    /// void __thiscall ClientUISystem::SetTargetMode(ClientUISystem*,Target_Mode)</code>
    /// </summary>
    public void SetTargetMode(ACBindings.Internal.Target_Mode i_targetMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.Target_Mode, void>)0x005656E0)(ref this, i_targetMode);

    /// <summary>
    /// <code>Offset: 0x00565750
    /// void __thiscall ClientUISystem::UseObject(ClientUISystem*,unsigned int)</code>
    /// </summary>
    public void UseObject(uint i_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, void>)0x00565750)(ref this, i_iid);

    /// <summary>
    /// <code>Offset: 0x005657B0
    /// void __thiscall ClientUISystem::ExamineObject(ClientUISystem*,unsigned int)</code>
    /// </summary>
    public void ExamineObject(uint i_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, void>)0x005657B0)(ref this, i_iid);

    /// <summary>
    /// <code>Offset: 0x00565810
    /// void __thiscall ClientUISystem::ExamineSpell(ClientUISystem*,unsigned int)</code>
    /// </summary>
    public void ExamineSpell(uint i_spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, void>)0x00565810)(ref this, i_spellID);

    /// <summary>
    /// <code>Offset: 0x00565870
    /// void __thiscall ClientUISystem::OnEndCharacterSession(ClientUISystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565870)(ref this);

    /// <summary>
    /// <code>Offset: 0x005658D0
    /// void __thiscall ClientUISystem::ExecuteTargetModeForItem(ClientUISystem*,unsigned int,Target_Mode)</code>
    /// </summary>
    public void ExecuteTargetModeForItem(uint itemID, ACBindings.Internal.Target_Mode mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, ACBindings.Internal.Target_Mode, void>)0x005658D0)(ref this, itemID, mode);

    /// <summary>
    /// <code>Offset: 0x00565910
    /// void __thiscall ClientUISystem::ExecuteTargetModeForSpell(ClientUISystem*,unsigned int,Target_Mode)</code>
    /// </summary>
    public void ExecuteTargetModeForSpell(uint spellID, ACBindings.Internal.Target_Mode mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, ACBindings.Internal.Target_Mode, void>)0x00565910)(ref this, spellID, mode);

    /// <summary>
    /// <code>Offset: 0x00565930
    /// bool __thiscall ClientUISystem::OnAction(ClientUISystem*,const InputEvent*)</code>
    /// </summary>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.InputEvent*, byte>)0x00565930)(ref this, i_evt);

    /// <summary>
    /// <code>Offset: 0x00565CD0
    /// unsigned int __thiscall ClientUISystem::Handle_Misc__PortalStormSubsided(ClientUISystem*)</code>
    /// </summary>
    public uint Handle_Misc__PortalStormSubsided() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint>)0x00565CD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00565D70
    /// unsigned int __thiscall ClientUISystem::Handle_Misc__PortalStormBrewing(ClientUISystem*,float)</code>
    /// </summary>
    public uint Handle_Misc__PortalStormBrewing(float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, float, uint>)0x00565D70)(ref this, extent);

    /// <summary>
    /// <code>Offset: 0x00565E40
    /// unsigned int __thiscall ClientUISystem::Handle_Misc__PortalStormImminent(ClientUISystem*,float)</code>
    /// </summary>
    public uint Handle_Misc__PortalStormImminent(float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, float, uint>)0x00565E40)(ref this, extent);

    /// <summary>
    /// <code>Offset: 0x00565F90
    /// void __thiscall ClientUISystem::UseTime(ClientUISystem*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565F90)(ref this);

    /// <summary>
    /// <code>Offset: 0x005663C0
    /// unsigned int __thiscall ClientUISystem::Handle_Inventory__Recv_SalvageOperationsResultData(ClientUISystem*,const SalvageOperationsResultData*)</code>
    /// </summary>
    public uint Handle_Inventory__Recv_SalvageOperationsResultData(ACBindings.Internal.SalvageOperationsResultData* operationsResultData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.SalvageOperationsResultData*, uint>)0x005663C0)(ref this, operationsResultData);

    /// <summary>
    /// <code>Offset: 0x00566610
    /// void __thiscall ClientUISystem::OnViewContents(_DWORD*,unsigned int,int)</code>
    /// </summary>
    public void OnViewContents(uint object_id, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, int, void>)0x00566610)(ref this, object_id, a3);

    /// <summary>
    /// <code>Offset: 0x00566700
    /// void __cdecl ClientUISystem::TargetedUsageCallback(const PropertyCollection*)</code>
    /// </summary>
    public static void TargetedUsageCallback(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x00566700)(i_rcResults);

    /// <summary>
    /// <code>Offset: 0x005668C0
    /// void __cdecl ClientUISystem::UsageCallback(const PropertyCollection*)</code>
    /// </summary>
    public static void UsageCallback(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x005668C0)(i_rcResults);

    /// <summary>
    /// <code>Offset: 0x00566AB0
    /// void __thiscall ClientUISystem::Handle_VendorInfo(ClientUISystem*,void*,unsigned int)</code>
    /// </summary>
    public void Handle_VendorInfo(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, System.IntPtr, uint, void>)0x00566AB0)(ref this, buff, size);

    /// <summary>
    /// <code>Offset: 0x00566BB0
    /// char __cdecl ClientUISystem::DeltaTimeToString(double,wchar_t**)</code>
    /// </summary>
    public static sbyte DeltaTimeToString(double a1, System.IntPtr a2) => ((delegate* unmanaged[Cdecl]<double, System.IntPtr, sbyte>)0x00566BB0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x00566EE0
    /// bool __thiscall ClientUISystem::TargetedUsageConfirmation_ManaStone(ClientUISystem*,unsigned int,unsigned int)</code>
    /// </summary>
    public byte TargetedUsageConfirmation_ManaStone(uint toolID, uint targetID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, uint, byte>)0x00566EE0)(ref this, toolID, targetID);

    /// <summary>
    /// <code>Offset: 0x005671C0
    /// bool __thiscall ClientUISystem::UsageConfirmation_PKAltar(ClientUISystem*,unsigned int)</code>
    /// </summary>
    public byte UsageConfirmation_PKAltar(uint altarID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, byte>)0x005671C0)(ref this, altarID);

    /// <summary>
    /// <code>Offset: 0x005673B0
    /// bool __thiscall ClientUISystem::UsageConfirmation_NPKAltar(ClientUISystem*,unsigned int)</code>
    /// </summary>
    public byte UsageConfirmation_NPKAltar(uint altarID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, byte>)0x005673B0)(ref this, altarID);

    /// <summary>
    /// <code>Offset: 0x005675A0
    /// bool __thiscall ClientUISystem::UsageConfirmation_VolatileRare(ClientUISystem*,unsigned int)</code>
    /// </summary>
    public byte UsageConfirmation_VolatileRare(uint rareID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, byte>)0x005675A0)(ref this, rareID);

    /// <summary>
    /// <code>Offset: 0x00567790
    /// bool __thiscall ClientUISystem::TargetedUsageConfirmation_Salvage(ClientUISystem*,unsigned int,unsigned int)</code>
    /// </summary>
    public byte TargetedUsageConfirmation_Salvage(uint toolID, uint targetID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, uint, byte>)0x00567790)(ref this, toolID, targetID);

    /// <summary>
    /// <code>Offset: 0x0056F560
    /// unsigned int __thiscall ClientUISystem::AddRef(ClientCommunicationSystem*)</code>
    /// </summary>
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint>)0x0056F560)(ref this);
}

