namespace ACBindings;

// ClientUISystem
public unsafe struct ClientUISystem : System.IDisposable
{
    // Base Classes
    public ACBindings.ClientSystem BaseClass_ClientSystem; // ACBindings.ClientSystem
    public ACBindings.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.IInputActionCallback

    // Statics
    public static ACBindings.ClientUISystem* s_pUISystem = (ACBindings.ClientUISystem*)0x0086EF1C;

    // Child Types
    // ClientUISystem_vtbl
    public unsafe struct ClientUISystem_vtbl
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
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public uint m_cBusy;
    public uint groundObject;
    public uint requestedGroundObject;
    public uint vendorID;
    public uint attemptOpenVendorID;
    public uint attemptSaleObjectID;
    public ACBindings.Target_Mode targetMode;
    public ACBindings.IDClass___tagDataID m_didCurrentCursor;
    public ACBindings.CSoundTable* soundTable;
    public byte m_bLeaveTargetMode;
    public ACBindings.CameraSet* m_pCameraSet;
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
    // ClientUISystem* __cdecl ClientUISystem::GetUISystem()
    public static ACBindings.ClientUISystem* GetUISystem() => ((delegate* unmanaged[Cdecl]<ACBindings.ClientUISystem*>)0x00564D30)();
    // void __thiscall ClientUISystem::OnStartup(ClientUISystem*)
    public void OnStartup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, void>)0x00564D40)(ref this);
    // const CSoundTable* __thiscall ClientUISystem::GetUISoundTable(ClientUISystem*)
    public ACBindings.CSoundTable* GetUISoundTable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, ACBindings.CSoundTable*>)0x00564D50)(ref this);
    // unsigned int __thiscall ClientUISystem::Handle_Item__QueryItemManaResponse(ClientUISystem*,unsigned int,float,int)
    public uint Handle_Item__QueryItemManaResponse(uint target, float mana, int fSuccess) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, float, int, uint>)0x00564D80)(ref this, target, mana, fSuccess);
    // void __thiscall ClientUISystem::AttemptSellToVendor(ClientUISystem*,unsigned int,unsigned int)
    public void AttemptSellToVendor(uint vendorID, uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, uint, void>)0x00564DB0)(ref this, vendorID, objectID);
    // void __thiscall ClientUISystem::CloseVendor(ClientUISystem*,bool)
    public void CloseVendor(byte updating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, byte, void>)0x00564E10)(ref this, updating);
    // int __stdcall ClientUISystem::Handle_Character__ConfirmationRequest(int,int,int)
    public static int Handle_Character__ConfirmationRequest(int a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<int, int, int, int>)0x00564E40)(a1, a2, a3);
    // unsigned int __thiscall ClientUISystem::Handle_Character__ConfirmationDone(ClientUISystem*,int,unsigned int)
    public uint Handle_Character__ConfirmationDone(int confirm, uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, int, uint, uint>)0x00564F20)(ref this, confirm, context);
    // int __stdcall ClientUISystem::Handle_Login__WorldInfo(int,int,int)
    public static int Handle_Login__WorldInfo(int a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<int, int, int, int>)0x00564F40)(a1, a2, a3);
    // void __thiscall ClientUISystem::InitializeCameraSet(ClientUISystem*,SmartBox*)
    public void InitializeCameraSet(ACBindings.SmartBox* i_pSmartBox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, ACBindings.SmartBox*, void>)0x00564F60)(ref this, i_pSmartBox);
    // CameraSet* __thiscall ClientUISystem::AccessCameraSet(ClientUISystem*)
    public ACBindings.CameraSet* AccessCameraSet() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, ACBindings.CameraSet*>)0x00564F90)(ref this);
    // void __thiscall ClientUISystem::RecvNotice_ToggleChatEntry(ClientUISystem*,bool)
    public void RecvNotice_ToggleChatEntry(byte i_bActive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, byte, void>)0x00564FA0)(ref this, i_bActive);
    // unsigned int __thiscall ClientUISystem::Handle_Social__FriendsUpdate(ClientUISystem*,const FriendDataList*,int)
    public uint Handle_Social__FriendsUpdate(ACBindings.FriendDataList* friendDataList, int updateType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, ACBindings.FriendDataList*, int, uint>)0x00564FC0)(ref this, friendDataList, updateType);
    // unsigned int __thiscall ClientUISystem::Handle_Social__CharacterTitleTable(ClientUISystem*,const CharacterTitleTable*)
    public uint Handle_Social__CharacterTitleTable(ACBindings.CharacterTitleTable* titleTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, ACBindings.CharacterTitleTable*, uint>)0x00564FE0)(ref this, titleTable);
    // unsigned int __thiscall ClientUISystem::Handle_Social__AddOrSetCharacterTitle(ClientUISystem*,unsigned int,int)
    public uint Handle_Social__AddOrSetCharacterTitle(uint newTitle, int bSetAsDisplayTitle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, int, uint>)0x00565000)(ref this, newTitle, bSetAsDisplayTitle);
    // unsigned int __thiscall ClientUISystem::Handle_Social__SendClientContractTrackerTable(ClientUISystem*,const CContractTrackerTable*)
    public uint Handle_Social__SendClientContractTrackerTable(ACBindings.CContractTrackerTable* contractTrackerTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, ACBindings.CContractTrackerTable*, uint>)0x00565030)(ref this, contractTrackerTable);
    // int __stdcall ClientUISystem::Handle_Character__StartBarber(int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int)
    public static int Handle_Character__StartBarber(int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12, int a13, int a14, int a15, int a16) => ((delegate* unmanaged[Stdcall]<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>)0x00565050)(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16);
    // void __thiscall ClientUISystem::~ClientUISystem(ClientUISystem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, void>)0x005650B0)(ref this);
    // unsigned int __thiscall ClientUISystem::Release(ClientUISystem*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint>)0x00565140)(ref this);
    // void __thiscall ClientUISystem::OnShutdown(ClientUISystem*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, void>)0x00565170)(ref this);
    // TResult* __thiscall ClientUISystem::QueryInterface(ClientUISystem*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x005651E0)(ref this, result, i_rcInterface, o_ppvInterface);
    // void __thiscall ClientUISystem::SetGroundObject(ClientUISystem*,unsigned int,bool)
    public void SetGroundObject(uint groundObject, byte askServer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, byte, void>)0x005652B0)(ref this, groundObject, askServer);
    // void __thiscall ClientUISystem::OnBeginCharacterSession(ClientUISystem*)
    public void OnBeginCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, void>)0x00565380)(ref this);
    // void __thiscall ClientUISystem::UpdateCursorState(ClientUISystem*)
    public void UpdateCursorState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, void>)0x005653D0)(ref this);
    // unsigned int __thiscall ClientUISystem::Handle_Social__SendClientContractTracker(ClientUISystem*,const CContractTracker*,int,int)
    public uint Handle_Social__SendClientContractTracker(ACBindings.CContractTracker* contractTracker, int bDeleteContract, int bSetAsDisplayContract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, ACBindings.CContractTracker*, int, int, uint>)0x005654F0)(ref this, contractTracker, bDeleteContract, bSetAsDisplayContract);
    // void __thiscall ClientUISystem::ClientUISystem(ClientUISystem*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, void>)0x00565540)(ref this);
    // void __thiscall ClientUISystem::IncrementBusyCount(ClientUISystem*)
    public void IncrementBusyCount() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, void>)0x00565610)(ref this);
    // void __thiscall ClientUISystem::DecrementBusyCount(ClientUISystem*)
    public void DecrementBusyCount() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, void>)0x00565630)(ref this);
    // void __thiscall ClientUISystem::CleanUpGameUI(ClientUISystem*)
    public void CleanUpGameUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, void>)0x00565640)(ref this);
    // unsigned int __thiscall ClientUISystem::Handle_Item__UseDone(ClientUISystem*,const unsigned int)
    public uint Handle_Item__UseDone(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, uint>)0x005656A0)(ref this, etype);
    // void __thiscall ClientUISystem::SetTargetMode(ClientUISystem*,Target_Mode)
    public void SetTargetMode(ACBindings.Target_Mode i_targetMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, ACBindings.Target_Mode, void>)0x005656E0)(ref this, i_targetMode);
    // void __thiscall ClientUISystem::UseObject(ClientUISystem*,unsigned int)
    public void UseObject(uint i_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, void>)0x00565750)(ref this, i_iid);
    // void __thiscall ClientUISystem::ExamineObject(ClientUISystem*,unsigned int)
    public void ExamineObject(uint i_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, void>)0x005657B0)(ref this, i_iid);
    // void __thiscall ClientUISystem::ExamineSpell(ClientUISystem*,unsigned int)
    public void ExamineSpell(uint i_spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, void>)0x00565810)(ref this, i_spellID);
    // void __thiscall ClientUISystem::OnEndCharacterSession(ClientUISystem*)
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, void>)0x00565870)(ref this);
    // void __thiscall ClientUISystem::ExecuteTargetModeForItem(ClientUISystem*,unsigned int,Target_Mode)
    public void ExecuteTargetModeForItem(uint itemID, ACBindings.Target_Mode mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, ACBindings.Target_Mode, void>)0x005658D0)(ref this, itemID, mode);
    // void __thiscall ClientUISystem::ExecuteTargetModeForSpell(ClientUISystem*,unsigned int,Target_Mode)
    public void ExecuteTargetModeForSpell(uint spellID, ACBindings.Target_Mode mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, ACBindings.Target_Mode, void>)0x00565910)(ref this, spellID, mode);
    // bool __thiscall ClientUISystem::OnAction(ClientUISystem*,const InputEvent*)
    public byte OnAction(ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, ACBindings.InputEvent*, byte>)0x00565930)(ref this, i_evt);
    // unsigned int __thiscall ClientUISystem::Handle_Misc__PortalStormSubsided(ClientUISystem*)
    public uint Handle_Misc__PortalStormSubsided() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint>)0x00565CD0)(ref this);
    // unsigned int __thiscall ClientUISystem::Handle_Misc__PortalStormBrewing(ClientUISystem*,float)
    public uint Handle_Misc__PortalStormBrewing(float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, float, uint>)0x00565D70)(ref this, extent);
    // unsigned int __thiscall ClientUISystem::Handle_Misc__PortalStormImminent(ClientUISystem*,float)
    public uint Handle_Misc__PortalStormImminent(float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, float, uint>)0x00565E40)(ref this, extent);
    // void __thiscall ClientUISystem::UseTime(ClientUISystem*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, void>)0x00565F90)(ref this);
    // unsigned int __thiscall ClientUISystem::Handle_Inventory__Recv_SalvageOperationsResultData(ClientUISystem*,const SalvageOperationsResultData*)
    public uint Handle_Inventory__Recv_SalvageOperationsResultData(ACBindings.SalvageOperationsResultData* operationsResultData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, ACBindings.SalvageOperationsResultData*, uint>)0x005663C0)(ref this, operationsResultData);
    // void __thiscall ClientUISystem::OnViewContents(_DWORD*,unsigned int,int)
    public void OnViewContents(uint object_id, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, int, void>)0x00566610)(ref this, object_id, a3);
    // void __cdecl ClientUISystem::TargetedUsageCallback(const PropertyCollection*)
    public static void TargetedUsageCallback(ACBindings.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.PropertyCollection*, void>)0x00566700)(i_rcResults);
    // void __cdecl ClientUISystem::UsageCallback(const PropertyCollection*)
    public static void UsageCallback(ACBindings.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.PropertyCollection*, void>)0x005668C0)(i_rcResults);
    // void __thiscall ClientUISystem::Handle_VendorInfo(ClientUISystem*,void*,unsigned int)
    public void Handle_VendorInfo(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, System.IntPtr, uint, void>)0x00566AB0)(ref this, buff, size);
    // char __cdecl ClientUISystem::DeltaTimeToString(double,wchar_t**)
    public static sbyte DeltaTimeToString(double a1, System.IntPtr a2) => ((delegate* unmanaged[Cdecl]<double, System.IntPtr, sbyte>)0x00566BB0)(a1, a2);
    // bool __thiscall ClientUISystem::TargetedUsageConfirmation_ManaStone(ClientUISystem*,unsigned int,unsigned int)
    public byte TargetedUsageConfirmation_ManaStone(uint toolID, uint targetID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, uint, byte>)0x00566EE0)(ref this, toolID, targetID);
    // bool __thiscall ClientUISystem::UsageConfirmation_PKAltar(ClientUISystem*,unsigned int)
    public byte UsageConfirmation_PKAltar(uint altarID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, byte>)0x005671C0)(ref this, altarID);
    // bool __thiscall ClientUISystem::UsageConfirmation_NPKAltar(ClientUISystem*,unsigned int)
    public byte UsageConfirmation_NPKAltar(uint altarID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, byte>)0x005673B0)(ref this, altarID);
    // bool __thiscall ClientUISystem::UsageConfirmation_VolatileRare(ClientUISystem*,unsigned int)
    public byte UsageConfirmation_VolatileRare(uint rareID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, byte>)0x005675A0)(ref this, rareID);
    // bool __thiscall ClientUISystem::TargetedUsageConfirmation_Salvage(ClientUISystem*,unsigned int,unsigned int)
    public byte TargetedUsageConfirmation_Salvage(uint toolID, uint targetID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint, uint, byte>)0x00567790)(ref this, toolID, targetID);
    // unsigned int __thiscall ClientUISystem::AddRef(ClientCommunicationSystem*)
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientUISystem, uint>)0x0056F560)(ref this);
}

