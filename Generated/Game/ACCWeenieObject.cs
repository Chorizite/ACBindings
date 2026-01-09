namespace ACBindings;

// ACCWeenieObject
public unsafe struct ACCWeenieObject : System.IDisposable
{
    // Base Classes
    public ACBindings.CWeenieObject BaseClass_CWeenieObject; // ACBindings.CWeenieObject

    // Statics
    public static ACBindings.LongHash__IconData* iconDataTable = (ACBindings.LongHash__IconData*)0x008216CC;
    public static ACBindings.HashSet__uint* m_openedCorpses = (ACBindings.HashSet__uint*)0x00821754;
    public static ACBindings.IDClass___tagDataID* splitClassID = (ACBindings.IDClass___tagDataID*)0x0086E24C;
    public static double* splitTime = (double*)0x0086E31C;
    public static sbyte* nameString = (sbyte*)0x0086E3DC;

    // Child Types
    // ACCWeenieObject_vtbl
    public unsafe struct ACCWeenieObject_vtbl
    {
        // Members
        public System.IntPtr ACCWeenieObject_dtor_0; // function pointer
        public System.IntPtr ObjectBeingDeleted; // function pointer
        public System.IntPtr process_netblobs; // function pointer
        public System.IntPtr SetParentedState; // function pointer
        public System.IntPtr IsPlayer; // function pointer
        public System.IntPtr IsThePlayer; // function pointer
        public System.IntPtr InqType; // function pointer
        public System.IntPtr IsPlayerKiller; // function pointer
        public System.IntPtr IsPK; // function pointer
        public System.IntPtr IsPKLite; // function pointer
        public System.IntPtr IsImpenetrable; // function pointer
        public System.IntPtr IsCreature; // function pointer
        public System.IntPtr InqJumpVelocity; // function pointer
        public System.IntPtr InqRunRate; // function pointer
        public System.IntPtr InqMaxRunRate; // function pointer
        public System.IntPtr CanJump; // function pointer
        public System.IntPtr JumpStaminaCost; // function pointer
        public System.IntPtr CanMoveInto; // function pointer
        public System.IntPtr CanBypassMoveRestrictions; // function pointer
        public fixed byte gap4C[8];
        public System.IntPtr DoCollision; // function pointer
        public System.IntPtr DoCollisionEnd; // function pointer
        public System.IntPtr InqCollisionProfile; // function pointer
        public System.IntPtr ResetCollisions; // function pointer
        public System.IntPtr InqIconID;
        public System.IntPtr PlayScript; // function pointer
        public System.IntPtr GetNumEmitters; // function pointer
        public System.IntPtr GetGlobalVelocity; // function pointer
        public System.IntPtr IsHook; // function pointer
        public System.IntPtr IsStorage; // function pointer
        public System.IntPtr IsCorpse; // function pointer
        public System.IntPtr ResetPlayerDesc; // function pointer

        // Methods
    }

    // Members
    public ACBindings.CObjectInventory* objInventory;
    public int valid;
    public int awaitingAuthentication;
    public int markedForDeletion;
    public int movedWhileMarkedForDeletion;
    public int beingRemoved;
    public ACBindings.PositionState current_state;
    public int selected;
    public int waiting;
    public int sellState;
    public int tradeState;
    public int shortcutNum;
    public byte m_bShortcutGhosted;
    public uint preRemoveContainerID;
    public uint preRemoveWielderID;
    public uint preRemoveLocation;
    public uint preRemoveContainerPlace;
    public ACBindings.CPhysicsObj* _phys_obj;
    public ACBindings.PublicWeenieDesc pwd;
    public ACBindings.ACWTimeStamper* _stamper;
    public ACBindings.PlayerDesc* m_pQualities;

    // Generated Constructor
    public ACCWeenieObject(uint iid) {
        _ConstructorInternal(iid);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall ACCWeenieObject::IsContainer(ACCWeenieObject*)
    public int IsContainer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x004A48A0)(ref this);
    // bool __thiscall ACCWeenieObject::IsCoinstack(ACCWeenieObject*)
    public byte IsCoinstack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, byte>)0x004BDEE0)(ref this);
    // int __thiscall ACCWeenieObject::BlocksUseOfShield(ACCWeenieObject*)
    public int BlocksUseOfShield() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0055E100)(ref this);
    // void __thiscall ACCWeenieObject::SetRestrictions(ACCWeenieObject*,const RestrictionDB*)
    public void SetRestrictions(ACBindings.RestrictionDB* db) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.RestrictionDB*, void>)0x00586720)(ref this, db);
    // int __thiscall ACCWeenieObject::IsComponentPack(ACCWeenieObject*)
    public int IsComponentPack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x00589230)(ref this);
    // void __thiscall ACCWeenieObject::SetOpenable(ACCWeenieObject*,const int)
    public void SetOpenable(int openable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, void>)0x0058CAD0)(ref this, openable);
    // void __thiscall ACCWeenieObject::SetStuck(ACCWeenieObject*,const int)
    public void SetStuck(int stuck) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, void>)0x0058CB00)(ref this, stuck);
    // void __thiscall ACCWeenieObject::SetInscribable(ACCWeenieObject*,const int)
    public void SetInscribable(int inscribable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, void>)0x0058CB30)(ref this, inscribable);
    // void __thiscall ACCWeenieObject::SetHiddenAdmin(ACCWeenieObject*,const int)
    public void SetHiddenAdmin(int hide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, void>)0x0058CB60)(ref this, hide);
    // void __thiscall ACCWeenieObject::SetUIHidden(ACCWeenieObject*,const int)
    public void SetUIHidden(int hide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, void>)0x0058CB90)(ref this, hide);
    // void __thiscall ACCWeenieObject::SetCellBarrierImmune(ACCWeenieObject*,const int)
    public void SetCellBarrierImmune(int b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, void>)0x0058CBC0)(ref this, b);
    // void __thiscall ACCWeenieObject::ResetPlayerDesc(ACCWeenieObject*)
    public void ResetPlayerDesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, void>)0x0058CBF0)(ref this);
    // void __thiscall ACCWeenieObject::SetParentedState(ACCWeenieObject*,int)
    public void SetParentedState(int parentedState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, void>)0x0058CC40)(ref this, parentedState);
    // void __thiscall ACCWeenieObject::ServerSaysContainID(ACCWeenieObject*,unsigned int,int,int)
    public void ServerSaysContainID(uint item, int place, int itemIsContainer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, int, int, void>)0x0058CC70)(ref this, item, place, itemIsContainer);
    // void __thiscall ACCWeenieObject::DeterminePositionState(ACCWeenieObject*)
    public void DeterminePositionState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, void>)0x0058CCA0)(ref this);
    // int __thiscall ACCWeenieObject::GetNumContainedItems(ACCWeenieObject*)
    public int GetNumContainedItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058CCE0)(ref this);
    // int __thiscall ACCWeenieObject::GetNumContainedContainers(ACCWeenieObject*)
    public int GetNumContainedContainers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058CCF0)(ref this);
    // int __thiscall ACCWeenieObject::GetNumEmptyItemSlots(ACCWeenieObject*)
    public int GetNumEmptyItemSlots() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058CD00)(ref this);
    // IDList* __thiscall ACCWeenieObject::GetContainedItemsList(ACCWeenieObject*)
    public ACBindings.IDList* GetContainedItemsList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.IDList*>)0x0058CD20)(ref this);
    // IDList* __thiscall ACCWeenieObject::GetContainedContainersList(ACCWeenieObject*)
    public ACBindings.IDList* GetContainedContainersList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.IDList*>)0x0058CD30)(ref this);
    // IDList* __thiscall ACCWeenieObject::GetExhaustiveContainedItemsList(ACCWeenieObject*,IDList*)
    public ACBindings.IDList* GetExhaustiveContainedItemsList(ACBindings.IDList* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.IDList*, ACBindings.IDList*>)0x0058CD40)(ref this, result);
    // int __thiscall ACCWeenieObject::GetInvPlacementList(_DWORD*)
    public int GetInvPlacementList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058CE20)(ref this);
    // int __thiscall ACCWeenieObject::AllContainedObjectsExist(ACCWeenieObject*)
    public int AllContainedObjectsExist() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058CE30)(ref this);
    // int __thiscall ACCWeenieObject::GetPlaceInItemsList(ACCWeenieObject*,unsigned int)
    public int GetPlaceInItemsList(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, int>)0x0058CEC0)(ref this, id);
    // int __thiscall ACCWeenieObject::GetPlaceInContainersList(ACCWeenieObject*,unsigned int)
    public int GetPlaceInContainersList(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, int>)0x0058CEE0)(ref this, id);
    // void __thiscall ACCWeenieObject::SetWaitingState(ACCWeenieObject*,int)
    public void SetWaitingState(int waiting) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, void>)0x0058CF00)(ref this, waiting);
    // void __thiscall ACCWeenieObject::SetShortcutNum(ACCWeenieObject*,int,bool)
    public void SetShortcutNum(int i_nShortcutNum, byte i_bGhosted) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, byte, void>)0x0058CF30)(ref this, i_nShortcutNum, i_bGhosted);
    // void __thiscall ACCWeenieObject::SetTradeState(ACCWeenieObject*,int)
    public void SetTradeState(int tradeState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, void>)0x0058CF70)(ref this, tradeState);
    // void __thiscall ACCWeenieObject::SetSellState(ACCWeenieObject*,int)
    public void SetSellState(int sellState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, void>)0x0058CFA0)(ref this, sellState);
    // int __cdecl ACCWeenieObject::ObjectsInRange(unsigned int,unsigned int,long double,bool,bool)
    public static int ObjectsInRange(uint ID1, uint ID2, double range, byte use_radii, byte xy_only) => ((delegate* unmanaged[Cdecl]<uint, uint, double, byte, byte, int>)0x0058CFD0)(ID1, ID2, range, use_radii, xy_only);
    // void __cdecl ACCWeenieObject::RecordRequest(unsigned int,InventoryRequest)
    public static void RecordRequest(uint requestObjID, ACBindings.InventoryRequest request) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.InventoryRequest, void>)0x0058D050)(requestObjID, request);
    // int __thiscall ACCWeenieObject::InqShowableOnRadar(ACCWeenieObject*,const AC1Legacy::Vector3*)
    public int InqShowableOnRadar(ACBindings.AC1Legacy.Vector3* cur_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.AC1Legacy.Vector3*, int>)0x0058D080)(ref this, cur_pos);
    // void __thiscall ACCWeenieObject::SetStructure(ACCWeenieObject*,const unsigned int)
    public void SetStructure(uint structure) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, void>)0x0058D0B0)(ref this, structure);
    // void __thiscall ACCWeenieObject::SetMaxStructure(ACCWeenieObject*,const unsigned int)
    public void SetMaxStructure(uint maxStructure) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, void>)0x0058D0D0)(ref this, maxStructure);
    // void __thiscall ACCWeenieObject::SetStackSize(ACCWeenieObject*,const unsigned int)
    public void SetStackSize(uint stackSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, void>)0x0058D0F0)(ref this, stackSize);
    // void __cdecl ACCWeenieObject::SetSelectedObject(unsigned int,int)
    public static void SetSelectedObject(uint selectedID, int reselect) => ((delegate* unmanaged[Cdecl]<uint, int, void>)0x0058D110)(selectedID, reselect);
    // void __cdecl ACCWeenieObject::SetPreviousSelectedObject(unsigned int)
    public static void SetPreviousSelectedObject(uint selectedID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058D1B0)(selectedID);
    // void __cdecl ACCWeenieObject::SetSelectedObjectID(unsigned int)
    public static void SetSelectedObjectID(uint selectedID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058D1C0)(selectedID);
    // int __thiscall ACCWeenieObject::DoCollision(ACCWeenieObject*,const EnvCollisionProfile*)
    public int DoCollision(ACBindings.EnvCollisionProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.EnvCollisionProfile*, int>)0x0058D1D0)(ref this, prof);
    // int __thiscall ACCWeenieObject::IsThePlayer(ACCWeenieObject*)
    public int IsThePlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058D200)(ref this);
    // int __thiscall ACCWeenieObject::IsCreature(ACCWeenieObject*)
    public int IsCreature() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058D220)(ref this);
    // bool __thiscall ACCWeenieObject::CanJump(ACCWeenieObject*,float)
    public byte CanJump(float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, float, byte>)0x0058D230)(ref this, extent);
    // bool __thiscall ACCWeenieObject::JumpStaminaCost(ACCWeenieObject*,float,int*)
    public byte JumpStaminaCost(float extent, int* cost) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, float, int*, byte>)0x0058D270)(ref this, extent, cost);
    // int __thiscall ACCWeenieObject::PlayScript(ACCWeenieObject*,PScriptType,float)
    public int PlayScript(ACBindings.PScriptType script_type, float mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.PScriptType, float, int>)0x0058D2B0)(ref this, script_type, mod);
    // unsigned int __thiscall ACCWeenieObject::GetNumEmitters(ACCWeenieObject*)
    public uint GetNumEmitters() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint>)0x0058D2D0)(ref this);
    // int __thiscall ACCWeenieObject::GetGlobalVelocity(ACCWeenieObject*,AC1Legacy::Vector3*)
    public int GetGlobalVelocity(ACBindings.AC1Legacy.Vector3* velocity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.AC1Legacy.Vector3*, int>)0x0058D2F0)(ref this, velocity);
    // int __thiscall ACCWeenieObject::CanBypassMoveRestrictions(ACCWeenieObject*)
    public int CanBypassMoveRestrictions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058D330)(ref this);
    // bool __thiscall ACCWeenieObject::InqJumpVelocity(ACCWeenieObject*,float,float*)
    public byte InqJumpVelocity(float extent, float* v_z) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, float, float*, byte>)0x0058D350)(ref this, extent, v_z);
    // bool __thiscall ACCWeenieObject::InqRunRate(ACCWeenieObject*,float*)
    public byte InqRunRate(float* rate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, float*, byte>)0x0058D390)(ref this, rate);
    // bool __thiscall ACCWeenieObject::InqMaxRunRate(ACCWeenieObject*,float*)
    public byte InqMaxRunRate(float* rate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, float*, byte>)0x0058D3D0)(ref this, rate);
    // int __thiscall ACCWeenieObject::SetupStamper(ACCWeenieObject*)
    public int SetupStamper() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058D410)(ref this);
    // int __thiscall ACCWeenieObject::IsAllegianceMember(ACCWeenieObject*,ACCWeenieObject*)
    public int IsAllegianceMember(ACBindings.ACCWeenieObject* wobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.ACCWeenieObject*, int>)0x0058D460)(ref this, wobj);
    // int __thiscall ACCWeenieObject::IsHook(ACCWeenieObject*)
    public int IsHook() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058D490)(ref this);
    // void __thiscall ACCWeenieObject::OnStatUpdated(ACCWeenieObject*,unsigned int,int)
    public void OnStatUpdated(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, int, void>)0x0058D4B0)(ref this, stype, val);
    // void __thiscall ACCWeenieObject::ACCWeenieObject(ACCWeenieObject*,unsigned int)
    public void _ConstructorInternal(uint iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, void>)0x0058D5C0)(ref this, iid);
    // int __thiscall ACCWeenieObject::IsPlayer(ACCWeenieObject*)
    public int IsPlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058D6C0)(ref this);
    // int __thiscall ACCWeenieObject::IsPKLite(ACCWeenieObject*)
    public int IsPKLite() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058D6D0)(ref this);
    // int __thiscall ACCWeenieObject::IsPK(ACCWeenieObject*)
    public int IsPK() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058D6E0)(ref this);
    // int __thiscall ACCWeenieObject::IsImpenetrable(ACCWeenieObject*)
    public int IsImpenetrable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058D6F0)(ref this);
    // ITEM_TYPE __thiscall ACCWeenieObject::InqType(ACCWeenieObject*)
    public ACBindings.ITEM_TYPE InqType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.ITEM_TYPE>)0x0058D700)(ref this);
    // int __thiscall ACCWeenieObject::IsCorpse(ACCWeenieObject*)
    public int IsCorpse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058D710)(ref this);
    // _DWORD* __thiscall ACCWeenieObject::InqIconID(_DWORD*,_DWORD*)
    public int* InqIconID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int*, int*>)0x0058D730)(ref this, a2);
    // int __thiscall ACCWeenieObject::IsPlayerKiller(ACCWeenieObject*)
    public int IsPlayerKiller() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058D740)(ref this);
    // void __thiscall ACCWeenieObject::~ACCWeenieObject(ACCWeenieObject*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, void>)0x0058D760)(ref this);
    // void __thiscall ACCWeenieObject::AddContentsToDestructionQueue(ACCWeenieObject*)
    public void AddContentsToDestructionQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, void>)0x0058D7D0)(ref this);
    // void __thiscall ACCWeenieObject::RemoveContentsFromDestructionQueue(ACCWeenieObject*)
    public void RemoveContentsFromDestructionQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, void>)0x0058D850)(ref this);
    // void __cdecl ACCWeenieObject::RecordResponse(unsigned int)
    public static void RecordResponse(uint responseObjID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058D8E0)(responseObjID);
    // int __thiscall ACCWeenieObject::InqCollisionProfile(ACCWeenieObject*,ObjCollisionProfile*)
    public int InqCollisionProfile(ACBindings.ObjCollisionProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.ObjCollisionProfile*, int>)0x0058D910)(ref this, prof);
    // int __thiscall ACCWeenieObject::UpdateHouseRestrictionTS(ACCWeenieObject*,unsigned __int8)
    public int UpdateHouseRestrictionTS(byte ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, byte, int>)0x0058D980)(ref this, ts);
    // int __thiscall ACCWeenieObject::MagicPackIsOwned(_DWORD*,int)
    public int MagicPackIsOwned(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, int>)0x0058D9B0)(ref this, a2);
    // int __thiscall ACCWeenieObject::IsStorage(ACCWeenieObject*)
    public int IsStorage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058DA10)(ref this);
    // void __thiscall ACCWeenieObject::ServerSaysSetStackSize(ACCWeenieObject*,int,unsigned int)
    public void ServerSaysSetStackSize(int size, uint value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, uint, void>)0x0058DA70)(ref this, size, value);
    // void __thiscall ACCWeenieObject::AddContent(ACCWeenieObject*,ACCWeenieObject*,int)
    public void AddContent(ACBindings.ACCWeenieObject* weenObj, int place) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.ACCWeenieObject*, int, void>)0x0058DB10)(ref this, weenObj, place);
    // void __thiscall ACCWeenieObject::RemoveContent(ACCWeenieObject*,ACCWeenieObject*)
    public void RemoveContent(ACBindings.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.ACCWeenieObject*, void>)0x0058DBA0)(ref this, weenObj);
    // unsigned int __thiscall ACCWeenieObject::GetLocationOnObject(ACCWeenieObject*,unsigned int)
    public uint GetLocationOnObject(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, uint>)0x0058DC00)(ref this, id);
    // unsigned int __thiscall ACCWeenieObject::GetObjectAtLocation(ACCWeenieObject*,unsigned int,unsigned int)
    public uint GetObjectAtLocation(uint loc, uint priority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, uint, uint>)0x0058DC30)(ref this, loc, priority);
    // int __thiscall ACCWeenieObject::IsOwnedByTrader(ACCWeenieObject*,unsigned int)
    public int IsOwnedByTrader(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, int>)0x0058DC80)(ref this, id);
    // int __thiscall ACCWeenieObject::IsOwnedByObject(ACCWeenieObject*,unsigned int)
    public int IsOwnedByObject(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, int>)0x0058DCE0)(ref this, id);
    // int __thiscall ACCWeenieObject::GetHousePayment(ACCWeenieObject*)
    public int GetHousePayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058DDB0)(ref this);
    // int __cdecl ACCWeenieObject::IsPlayerReadyToMakeInventoryRequest(int)
    public static int IsPlayerReadyToMakeInventoryRequest(int quiet) => ((delegate* unmanaged[Cdecl]<int, int>)0x0058DE80)(quiet);
    // int __thiscall ACCWeenieObject::IsOwnedByPlayer(ACCWeenieObject*)
    public int IsOwnedByPlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int>)0x0058DF90)(ref this);
    // void __thiscall ACCWeenieObject::UIAttemptWield(ACCWeenieObject*,unsigned int)
    public void UIAttemptWield(uint loc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, void>)0x0058E3C0)(ref this, loc);
    // void __thiscall ACCWeenieObject::UIAttemptGive(ACCWeenieObject*,unsigned int,unsigned int)
    public void UIAttemptGive(uint targetID, uint amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, uint, void>)0x0058E450)(ref this, targetID, amount);
    // void __thiscall ACCWeenieObject::UIAttemptPutInContainer(ACCWeenieObject*,unsigned int,int)
    public void UIAttemptPutInContainer(uint container, int place) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, int, void>)0x0058E4B0)(ref this, container, place);
    // void __thiscall ACCWeenieObject::UIAttemptPutIn3D(ACCWeenieObject*)
    public void UIAttemptPutIn3D() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, void>)0x0058E530)(ref this);
    // void __thiscall ACCWeenieObject::UIAttemptMerge(ACCWeenieObject*,unsigned int,int)
    public void UIAttemptMerge(uint mergeToItem, int amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, int, void>)0x0058E5A0)(ref this, mergeToItem, amount);
    // void __thiscall ACCWeenieObject::UIAttemptSplitToContainer(ACCWeenieObject*,unsigned int,int,int)
    public void UIAttemptSplitToContainer(uint container, int place, int amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, int, int, void>)0x0058E600)(ref this, container, place, amount);
    // void __thiscall ACCWeenieObject::UIAttemptSplitTo3D(ACCWeenieObject*,int)
    public void UIAttemptSplitTo3D(int amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, void>)0x0058E680)(ref this, amount);
    // void __thiscall ACCWeenieObject::SetPlayerWieldLocation(ACCWeenieObject*,const unsigned int)
    public void SetPlayerWieldLocation(uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, void>)0x0058E6F0)(ref this, newLocation);
    // int __thiscall ACCWeenieObject::CanMoveInto(ACCWeenieObject*,CWeenieObject*)
    public int CanMoveInto(ACBindings.CWeenieObject* mover) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.CWeenieObject*, int>)0x0058E870)(ref this, mover);
    // int __cdecl ACCWeenieObject::HasCorpseBeenOpened(const unsigned int)
    public static int HasCorpseBeenOpened(uint corpseID) => ((delegate* unmanaged[Cdecl]<uint, int>)0x0058E9A0)(corpseID);
    // void __thiscall ACCWeenieObject::ServerSaysMoveItem(ACCWeenieObject*,unsigned int,int,unsigned int,unsigned int,int)
    public void ServerSaysMoveItem(uint newContainer, int place, uint newWielder, uint newLocation, int broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, int, uint, uint, int, void>)0x0058E9E0)(ref this, newContainer, place, newWielder, newLocation, broadcast);
    // void __thiscall ACCWeenieObject::Remove(ACCWeenieObject*)
    public void Remove() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, void>)0x0058EB50)(ref this);
    // void __thiscall ACCWeenieObject::IconDataChanged(ACCWeenieObject*)
    public void IconDataChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, void>)0x0058EC00)(ref this);
    // IconData* __thiscall ACCWeenieObject::GetIconData(ACCWeenieObject*)
    public ACBindings.IconData* GetIconData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.IconData*>)0x0058EC60)(ref this);
    // void __thiscall ACCWeenieObject::SetType(ACCWeenieObject*,const ITEM_TYPE)
    public void SetType(ACBindings.ITEM_TYPE type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.ITEM_TYPE, void>)0x0058ECF0)(ref this, type);
    // void __thiscall ACCWeenieObject::SetUseability(ACCWeenieObject*,const ITEM_USEABLE)
    public void SetUseability(ACBindings.ITEM_USEABLE useability) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.ITEM_USEABLE, void>)0x0058ED10)(ref this, useability);
    // void __thiscall ACCWeenieObject::SetEffects(ACCWeenieObject*,const unsigned int)
    public void SetEffects(uint effects) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, void>)0x0058ED30)(ref this, effects);
    // void __thiscall ACCWeenieObject::OnStatUpdated(int,int,int)
    public void OnStatUpdated(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, int, int, void>)0x0058EFB0)(ref this, a2, a3);
    // void __thiscall ACCWeenieObject::OnStatUpdated(ACCWeenieObject*,unsigned int,unsigned int)
    public void OnStatUpdated(uint stype, uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, uint, void>)0x0058F050)(ref this, stype, id);
    // void __thiscall ACCWeenieObject::DeclareValid(ACCWeenieObject*)
    public void DeclareValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, void>)0x0058F170)(ref this);
    // void __thiscall ACCWeenieObject::ObjectBeingDeleted(ACCWeenieObject*)
    public void ObjectBeingDeleted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, void>)0x0058F300)(ref this);
    // Graphic* __thiscall ACCWeenieObject::GetIcon(ACCWeenieObject*)
    public ACBindings.Graphic* GetIcon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.Graphic*>)0x0058F480)(ref this);
    // Graphic* __thiscall ACCWeenieObject::GetDragIcon(ACCWeenieObject*)
    public ACBindings.Graphic* GetDragIcon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.Graphic*>)0x0058F490)(ref this);
    // void __cdecl ACCWeenieObject::SetCorpseOpened(const unsigned int)
    public static void SetCorpseOpened(uint corpseID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058F4A0)(corpseID);
    // void __cdecl ACCWeenieObject::SetCorpseDeleted(const unsigned int)
    public static void SetCorpseDeleted(uint corpseID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058F4F0)(corpseID);
    // char* __thiscall ACCWeenieObject::GetObjectName(ACCWeenieObject*,NameType,int)
    public sbyte* GetObjectName(ACBindings.NameType nameType, int playerIsBackpack) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, ACBindings.NameType, int, sbyte*>)0x0058F510)(ref this, nameType, playerIsBackpack);
    // char* __cdecl ACCWeenieObject::GetObjectName(unsigned int,NameType,int)
    public static sbyte* GetObjectName(uint objID, ACBindings.NameType nameType, int playerIsBackpack) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.NameType, int, sbyte*>)0x0058F840)(objID, nameType, playerIsBackpack);
    // wchar_t** __thiscall ACCWeenieObject::GetObjectNameWide(ACCWeenieObject*,wchar_t**,NameType,int)
    public System.IntPtr GetObjectNameWide(System.IntPtr a2, ACBindings.NameType nameType, int ArgList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, System.IntPtr, ACBindings.NameType, int, System.IntPtr>)0x0058F8B0)(ref this, a2, nameType, ArgList);
    // wchar_t** __cdecl ACCWeenieObject::GetObjectNameWide(wchar_t**,unsigned int,NameType,int)
    public static System.IntPtr GetObjectNameWide(System.IntPtr a1, uint objID, ACBindings.NameType nameType, int playerIsBackpack) => ((delegate* unmanaged[Cdecl]<System.IntPtr, uint, ACBindings.NameType, int, System.IntPtr>)0x0058F8E0)(a1, objID, nameType, playerIsBackpack);
    // void __thiscall ACCWeenieObject::ServerSaysAttemptFailed(ACCWeenieObject*,unsigned int,int)
    public void ServerSaysAttemptFailed(uint etype, int printError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCWeenieObject, uint, int, void>)0x0058F910)(ref this, etype, printError);
}

