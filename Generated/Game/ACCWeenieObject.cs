namespace ACBindings.Internal;

public unsafe struct ACCWeenieObject : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CWeenieObject BaseClass_CWeenieObject; // ACBindings.Internal.CWeenieObject

    // Statics
    public static uint* prevSelectedID = (uint*)0x00871E58;
    public static uint* prevSelectedValidID = (uint*)0x00871E5C;
    public static sbyte* nameString = (sbyte*)0x00871E60;
    public static uint* splitStackSize = (uint*)0x00871EC4;
    public static double* splitTime = (double*)0x00871EC8;
    public static ACBindings.Internal.InventoryRequest* prevRequest = (ACBindings.Internal.InventoryRequest*)0x00871ED0;
    public static uint* prevRequestObjectID = (uint*)0x00871ED4;
    public static double* prevRequestTime = (double*)0x00871ED8;
    public static int* attackInProgress = (int*)0x00871EE0;

    // Child Types
    public unsafe struct ACCWeenieObject_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, void> ACCWeenieObject_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, void> ObjectBeingDeleted; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, void> process_netblobs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int, void> SetParentedState; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsThePlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.ITEM_TYPE> InqType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsPlayerKiller; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsPK; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsPKLite; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsImpenetrable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsCreature; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, float, float*, byte> InqJumpVelocity; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, float*, byte> InqRunRate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, float*, byte> InqMaxRunRate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, float, byte> CanJump; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, float, int*, byte> JumpStaminaCost; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.CWeenieObject*, int> CanMoveInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> CanBypassMoveRestrictions; // function pointer
        public fixed byte gap4C[8];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.AtkCollisionProfile*, int> DoCollision; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, uint, void> DoCollisionEnd; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.ObjCollisionProfile*, int> InqCollisionProfile; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, void> ResetCollisions; // function pointer
        public System.IntPtr InqIconID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.PScriptType, float, int> PlayScript; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, uint> GetNumEmitters; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.AC1Legacy.Vector3*, int> GetGlobalVelocity; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsHook; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsStorage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsCorpse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, void> ResetPlayerDesc; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.CObjectInventory* objInventory;
    public int valid;
    public int awaitingAuthentication;
    public int markedForDeletion;
    public int movedWhileMarkedForDeletion;
    public int beingRemoved;
    public ACBindings.Internal.PositionState current_state;
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
    public ACBindings.Internal.CPhysicsObj* _phys_obj;
    public ACBindings.Internal.PublicWeenieDesc pwd;
    public ACBindings.Internal.ACWTimeStamper* _stamper;
    public ACBindings.Internal.PlayerDesc* m_pQualities;

    // Generated Constructor
    public ACCWeenieObject(uint iid) {
        _ConstructorInternal(iid);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004A48A0
    /// int __thiscall ACCWeenieObject::IsContainer(ACCWeenieObject*)</code>
    /// </summary>
    public int IsContainer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x004A48A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BDEE0
    /// bool __thiscall ACCWeenieObject::IsCoinstack(ACCWeenieObject*)</code>
    /// </summary>
    public byte IsCoinstack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, byte>)0x004BDEE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0055E100
    /// int __thiscall ACCWeenieObject::BlocksUseOfShield(ACCWeenieObject*)</code>
    /// </summary>
    public int BlocksUseOfShield() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0055E100)(ref this);

    /// <summary>
    /// <code>Offset: 0x00586720
    /// void __thiscall ACCWeenieObject::SetRestrictions(ACCWeenieObject*,const RestrictionDB*)</code>
    /// </summary>
    public void SetRestrictions(ACBindings.Internal.RestrictionDB* db) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.RestrictionDB*, void>)0x00586720)(ref this, db);

    /// <summary>
    /// <code>Offset: 0x00589230
    /// int __thiscall ACCWeenieObject::IsComponentPack(ACCWeenieObject*)</code>
    /// </summary>
    public int IsComponentPack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x00589230)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058CAD0
    /// void __thiscall ACCWeenieObject::SetOpenable(ACCWeenieObject*,const int)</code>
    /// </summary>
    public void SetOpenable(int openable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CAD0)(ref this, openable);

    /// <summary>
    /// <code>Offset: 0x0058CB00
    /// void __thiscall ACCWeenieObject::SetStuck(ACCWeenieObject*,const int)</code>
    /// </summary>
    public void SetStuck(int stuck) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CB00)(ref this, stuck);

    /// <summary>
    /// <code>Offset: 0x0058CB30
    /// void __thiscall ACCWeenieObject::SetInscribable(ACCWeenieObject*,const int)</code>
    /// </summary>
    public void SetInscribable(int inscribable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CB30)(ref this, inscribable);

    /// <summary>
    /// <code>Offset: 0x0058CB60
    /// void __thiscall ACCWeenieObject::SetHiddenAdmin(ACCWeenieObject*,const int)</code>
    /// </summary>
    public void SetHiddenAdmin(int hide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CB60)(ref this, hide);

    /// <summary>
    /// <code>Offset: 0x0058CB90
    /// void __thiscall ACCWeenieObject::SetUIHidden(ACCWeenieObject*,const int)</code>
    /// </summary>
    public void SetUIHidden(int hide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CB90)(ref this, hide);

    /// <summary>
    /// <code>Offset: 0x0058CBC0
    /// void __thiscall ACCWeenieObject::SetCellBarrierImmune(ACCWeenieObject*,const int)</code>
    /// </summary>
    public void SetCellBarrierImmune(int b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CBC0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x0058CBF0
    /// void __thiscall ACCWeenieObject::ResetPlayerDesc(ACCWeenieObject*)</code>
    /// </summary>
    public void ResetPlayerDesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058CBF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058CC40
    /// void __thiscall ACCWeenieObject::SetParentedState(ACCWeenieObject*,int)</code>
    /// </summary>
    public void SetParentedState(int parentedState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CC40)(ref this, parentedState);

    /// <summary>
    /// <code>Offset: 0x0058CC70
    /// void __thiscall ACCWeenieObject::ServerSaysContainID(ACCWeenieObject*,unsigned int,int,int)</code>
    /// </summary>
    public void ServerSaysContainID(uint item, int place, int itemIsContainer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, int, void>)0x0058CC70)(ref this, item, place, itemIsContainer);

    /// <summary>
    /// <code>Offset: 0x0058CCA0
    /// void __thiscall ACCWeenieObject::DeterminePositionState(ACCWeenieObject*)</code>
    /// </summary>
    public void DeterminePositionState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058CCA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058CCE0
    /// int __thiscall ACCWeenieObject::GetNumContainedItems(ACCWeenieObject*)</code>
    /// </summary>
    public int GetNumContainedItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058CCE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058CCF0
    /// int __thiscall ACCWeenieObject::GetNumContainedContainers(ACCWeenieObject*)</code>
    /// </summary>
    public int GetNumContainedContainers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058CCF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058CD00
    /// int __thiscall ACCWeenieObject::GetNumEmptyItemSlots(ACCWeenieObject*)</code>
    /// </summary>
    public int GetNumEmptyItemSlots() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058CD00)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058CD20
    /// IDList* __thiscall ACCWeenieObject::GetContainedItemsList(ACCWeenieObject*)</code>
    /// </summary>
    public ACBindings.Internal.IDList* GetContainedItemsList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.IDList*>)0x0058CD20)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058CD30
    /// IDList* __thiscall ACCWeenieObject::GetContainedContainersList(ACCWeenieObject*)</code>
    /// </summary>
    public ACBindings.Internal.IDList* GetContainedContainersList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.IDList*>)0x0058CD30)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058CD40
    /// IDList* __thiscall ACCWeenieObject::GetExhaustiveContainedItemsList(ACCWeenieObject*,IDList*)</code>
    /// </summary>
    public ACBindings.Internal.IDList* GetExhaustiveContainedItemsList(ACBindings.Internal.IDList* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.IDList*, ACBindings.Internal.IDList*>)0x0058CD40)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x0058CE20
    /// int __thiscall ACCWeenieObject::GetInvPlacementList(_DWORD*)</code>
    /// </summary>
    public int GetInvPlacementList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058CE20)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058CE30
    /// int __thiscall ACCWeenieObject::AllContainedObjectsExist(ACCWeenieObject*)</code>
    /// </summary>
    public int AllContainedObjectsExist() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058CE30)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058CEC0
    /// int __thiscall ACCWeenieObject::GetPlaceInItemsList(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    public int GetPlaceInItemsList(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int>)0x0058CEC0)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x0058CEE0
    /// int __thiscall ACCWeenieObject::GetPlaceInContainersList(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    public int GetPlaceInContainersList(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int>)0x0058CEE0)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x0058CF00
    /// void __thiscall ACCWeenieObject::SetWaitingState(ACCWeenieObject*,int)</code>
    /// </summary>
    public void SetWaitingState(int waiting) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CF00)(ref this, waiting);

    /// <summary>
    /// <code>Offset: 0x0058CF30
    /// void __thiscall ACCWeenieObject::SetShortcutNum(ACCWeenieObject*,int,bool)</code>
    /// </summary>
    public void SetShortcutNum(int i_nShortcutNum, byte i_bGhosted) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, byte, void>)0x0058CF30)(ref this, i_nShortcutNum, i_bGhosted);

    /// <summary>
    /// <code>Offset: 0x0058CF70
    /// void __thiscall ACCWeenieObject::SetTradeState(ACCWeenieObject*,int)</code>
    /// </summary>
    public void SetTradeState(int tradeState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CF70)(ref this, tradeState);

    /// <summary>
    /// <code>Offset: 0x0058CFA0
    /// void __thiscall ACCWeenieObject::SetSellState(ACCWeenieObject*,int)</code>
    /// </summary>
    public void SetSellState(int sellState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CFA0)(ref this, sellState);

    /// <summary>
    /// <code>Offset: 0x0058CFD0
    /// int __cdecl ACCWeenieObject::ObjectsInRange(unsigned int,unsigned int,long double,bool,bool)</code>
    /// </summary>
    public static int ObjectsInRange(uint ID1, uint ID2, double range, byte use_radii, byte xy_only) => ((delegate* unmanaged[Cdecl]<uint, uint, double, byte, byte, int>)0x0058CFD0)(ID1, ID2, range, use_radii, xy_only);

    /// <summary>
    /// <code>Offset: 0x0058D050
    /// void __cdecl ACCWeenieObject::RecordRequest(unsigned int,InventoryRequest)</code>
    /// </summary>
    public static void RecordRequest(uint requestObjID, ACBindings.Internal.InventoryRequest request) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.InventoryRequest, void>)0x0058D050)(requestObjID, request);

    /// <summary>
    /// <code>Offset: 0x0058D080
    /// int __thiscall ACCWeenieObject::InqShowableOnRadar(ACCWeenieObject*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int InqShowableOnRadar(ACBindings.Internal.AC1Legacy.Vector3* cur_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0058D080)(ref this, cur_pos);

    /// <summary>
    /// <code>Offset: 0x0058D0B0
    /// void __thiscall ACCWeenieObject::SetStructure(ACCWeenieObject*,const unsigned int)</code>
    /// </summary>
    public void SetStructure(uint structure) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058D0B0)(ref this, structure);

    /// <summary>
    /// <code>Offset: 0x0058D0D0
    /// void __thiscall ACCWeenieObject::SetMaxStructure(ACCWeenieObject*,const unsigned int)</code>
    /// </summary>
    public void SetMaxStructure(uint maxStructure) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058D0D0)(ref this, maxStructure);

    /// <summary>
    /// <code>Offset: 0x0058D0F0
    /// void __thiscall ACCWeenieObject::SetStackSize(ACCWeenieObject*,const unsigned int)</code>
    /// </summary>
    public void SetStackSize(uint stackSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058D0F0)(ref this, stackSize);

    /// <summary>
    /// <code>Offset: 0x0058D110
    /// void __cdecl ACCWeenieObject::SetSelectedObject(unsigned int,int)</code>
    /// </summary>
    public static void SetSelectedObject(uint selectedID, int reselect) => ((delegate* unmanaged[Cdecl]<uint, int, void>)0x0058D110)(selectedID, reselect);

    /// <summary>
    /// <code>Offset: 0x0058D1B0
    /// void __cdecl ACCWeenieObject::SetPreviousSelectedObject(unsigned int)</code>
    /// </summary>
    public static void SetPreviousSelectedObject(uint selectedID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058D1B0)(selectedID);

    /// <summary>
    /// <code>Offset: 0x0058D1C0
    /// void __cdecl ACCWeenieObject::SetSelectedObjectID(unsigned int)</code>
    /// </summary>
    public static void SetSelectedObjectID(uint selectedID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058D1C0)(selectedID);

    /// <summary>
    /// <code>Offset: 0x0058D1D0
    /// int __thiscall ACCWeenieObject::DoCollision(ACCWeenieObject*,const EnvCollisionProfile*)</code>
    /// </summary>
    public int DoCollision(ACBindings.Internal.EnvCollisionProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.EnvCollisionProfile*, int>)0x0058D1D0)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x0058D200
    /// int __thiscall ACCWeenieObject::IsThePlayer(ACCWeenieObject*)</code>
    /// </summary>
    public int IsThePlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D200)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D220
    /// int __thiscall ACCWeenieObject::IsCreature(ACCWeenieObject*)</code>
    /// </summary>
    public int IsCreature() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D220)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D230
    /// bool __thiscall ACCWeenieObject::CanJump(ACCWeenieObject*,float)</code>
    /// </summary>
    public byte CanJump(float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, float, byte>)0x0058D230)(ref this, extent);

    /// <summary>
    /// <code>Offset: 0x0058D270
    /// bool __thiscall ACCWeenieObject::JumpStaminaCost(ACCWeenieObject*,float,int*)</code>
    /// </summary>
    public byte JumpStaminaCost(float extent, int* cost) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, float, int*, byte>)0x0058D270)(ref this, extent, cost);

    /// <summary>
    /// <code>Offset: 0x0058D2B0
    /// int __thiscall ACCWeenieObject::PlayScript(ACCWeenieObject*,PScriptType,float)</code>
    /// </summary>
    public int PlayScript(ACBindings.Internal.PScriptType script_type, float mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.PScriptType, float, int>)0x0058D2B0)(ref this, script_type, mod);

    /// <summary>
    /// <code>Offset: 0x0058D2D0
    /// unsigned int __thiscall ACCWeenieObject::GetNumEmitters(ACCWeenieObject*)</code>
    /// </summary>
    public uint GetNumEmitters() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint>)0x0058D2D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D2F0
    /// int __thiscall ACCWeenieObject::GetGlobalVelocity(ACCWeenieObject*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public int GetGlobalVelocity(ACBindings.Internal.AC1Legacy.Vector3* velocity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0058D2F0)(ref this, velocity);

    /// <summary>
    /// <code>Offset: 0x0058D330
    /// int __thiscall ACCWeenieObject::CanBypassMoveRestrictions(ACCWeenieObject*)</code>
    /// </summary>
    public int CanBypassMoveRestrictions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D330)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D350
    /// bool __thiscall ACCWeenieObject::InqJumpVelocity(ACCWeenieObject*,float,float*)</code>
    /// </summary>
    public byte InqJumpVelocity(float extent, float* v_z) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, float, float*, byte>)0x0058D350)(ref this, extent, v_z);

    /// <summary>
    /// <code>Offset: 0x0058D390
    /// bool __thiscall ACCWeenieObject::InqRunRate(ACCWeenieObject*,float*)</code>
    /// </summary>
    public byte InqRunRate(float* rate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, float*, byte>)0x0058D390)(ref this, rate);

    /// <summary>
    /// <code>Offset: 0x0058D3D0
    /// bool __thiscall ACCWeenieObject::InqMaxRunRate(ACCWeenieObject*,float*)</code>
    /// </summary>
    public byte InqMaxRunRate(float* rate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, float*, byte>)0x0058D3D0)(ref this, rate);

    /// <summary>
    /// <code>Offset: 0x0058D410
    /// int __thiscall ACCWeenieObject::SetupStamper(ACCWeenieObject*)</code>
    /// </summary>
    public int SetupStamper() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D410)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D460
    /// int __thiscall ACCWeenieObject::IsAllegianceMember(ACCWeenieObject*,ACCWeenieObject*)</code>
    /// </summary>
    public int IsAllegianceMember(ACBindings.Internal.ACCWeenieObject* wobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ACCWeenieObject*, int>)0x0058D460)(ref this, wobj);

    /// <summary>
    /// <code>Offset: 0x0058D490
    /// int __thiscall ACCWeenieObject::IsHook(ACCWeenieObject*)</code>
    /// </summary>
    public int IsHook() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D490)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D4B0
    /// void __thiscall ACCWeenieObject::OnStatUpdated(ACCWeenieObject*,unsigned int,int)</code>
    /// </summary>
    public void OnStatUpdated(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, void>)0x0058D4B0)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x0058D5C0
    /// void __thiscall ACCWeenieObject::ACCWeenieObject(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(uint iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058D5C0)(ref this, iid);

    /// <summary>
    /// <code>Offset: 0x0058D6C0
    /// int __thiscall ACCWeenieObject::IsPlayer(ACCWeenieObject*)</code>
    /// </summary>
    public int IsPlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D6C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D6D0
    /// int __thiscall ACCWeenieObject::IsPKLite(ACCWeenieObject*)</code>
    /// </summary>
    public int IsPKLite() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D6D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D6E0
    /// int __thiscall ACCWeenieObject::IsPK(ACCWeenieObject*)</code>
    /// </summary>
    public int IsPK() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D6E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D6F0
    /// int __thiscall ACCWeenieObject::IsImpenetrable(ACCWeenieObject*)</code>
    /// </summary>
    public int IsImpenetrable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D6F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D700
    /// ITEM_TYPE __thiscall ACCWeenieObject::InqType(ACCWeenieObject*)</code>
    /// </summary>
    public ACBindings.Internal.ITEM_TYPE InqType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ITEM_TYPE>)0x0058D700)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D710
    /// int __thiscall ACCWeenieObject::IsCorpse(ACCWeenieObject*)</code>
    /// </summary>
    public int IsCorpse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D710)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D730
    /// _DWORD* __thiscall ACCWeenieObject::InqIconID(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int* InqIconID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int*, int*>)0x0058D730)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0058D740
    /// int __thiscall ACCWeenieObject::IsPlayerKiller(ACCWeenieObject*)</code>
    /// </summary>
    public int IsPlayerKiller() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D740)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D760
    /// void __thiscall ACCWeenieObject::~ACCWeenieObject(ACCWeenieObject*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058D760)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D7D0
    /// void __thiscall ACCWeenieObject::AddContentsToDestructionQueue(ACCWeenieObject*)</code>
    /// </summary>
    public void AddContentsToDestructionQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058D7D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D850
    /// void __thiscall ACCWeenieObject::RemoveContentsFromDestructionQueue(ACCWeenieObject*)</code>
    /// </summary>
    public void RemoveContentsFromDestructionQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058D850)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058D8E0
    /// void __cdecl ACCWeenieObject::RecordResponse(unsigned int)</code>
    /// </summary>
    public static void RecordResponse(uint responseObjID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058D8E0)(responseObjID);

    /// <summary>
    /// <code>Offset: 0x0058D910
    /// int __thiscall ACCWeenieObject::InqCollisionProfile(ACCWeenieObject*,ObjCollisionProfile*)</code>
    /// </summary>
    public int InqCollisionProfile(ACBindings.Internal.ObjCollisionProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ObjCollisionProfile*, int>)0x0058D910)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x0058D980
    /// int __thiscall ACCWeenieObject::UpdateHouseRestrictionTS(ACCWeenieObject*,unsigned __int8)</code>
    /// </summary>
    public int UpdateHouseRestrictionTS(byte ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, byte, int>)0x0058D980)(ref this, ts);

    /// <summary>
    /// <code>Offset: 0x0058D9B0
    /// int __thiscall ACCWeenieObject::MagicPackIsOwned(_DWORD*,int)</code>
    /// </summary>
    public int MagicPackIsOwned(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, int>)0x0058D9B0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0058DA10
    /// int __thiscall ACCWeenieObject::IsStorage(ACCWeenieObject*)</code>
    /// </summary>
    public int IsStorage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058DA10)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058DA70
    /// void __thiscall ACCWeenieObject::ServerSaysSetStackSize(ACCWeenieObject*,int,unsigned int)</code>
    /// </summary>
    public void ServerSaysSetStackSize(int size, uint value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, uint, void>)0x0058DA70)(ref this, size, value);

    /// <summary>
    /// <code>Offset: 0x0058DB10
    /// void __thiscall ACCWeenieObject::AddContent(ACCWeenieObject*,ACCWeenieObject*,int)</code>
    /// </summary>
    public void AddContent(ACBindings.Internal.ACCWeenieObject* weenObj, int place) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ACCWeenieObject*, int, void>)0x0058DB10)(ref this, weenObj, place);

    /// <summary>
    /// <code>Offset: 0x0058DBA0
    /// void __thiscall ACCWeenieObject::RemoveContent(ACCWeenieObject*,ACCWeenieObject*)</code>
    /// </summary>
    public void RemoveContent(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ACCWeenieObject*, void>)0x0058DBA0)(ref this, weenObj);

    /// <summary>
    /// <code>Offset: 0x0058DC00
    /// unsigned int __thiscall ACCWeenieObject::GetLocationOnObject(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    public uint GetLocationOnObject(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, uint>)0x0058DC00)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x0058DC30
    /// unsigned int __thiscall ACCWeenieObject::GetObjectAtLocation(ACCWeenieObject*,unsigned int,unsigned int)</code>
    /// </summary>
    public uint GetObjectAtLocation(uint loc, uint priority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, uint, uint>)0x0058DC30)(ref this, loc, priority);

    /// <summary>
    /// <code>Offset: 0x0058DC80
    /// int __thiscall ACCWeenieObject::IsOwnedByTrader(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    public int IsOwnedByTrader(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int>)0x0058DC80)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x0058DCE0
    /// int __thiscall ACCWeenieObject::IsOwnedByObject(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    public int IsOwnedByObject(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int>)0x0058DCE0)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x0058DDB0
    /// int __thiscall ACCWeenieObject::GetHousePayment(ACCWeenieObject*)</code>
    /// </summary>
    public int GetHousePayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058DDB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058DE80
    /// int __cdecl ACCWeenieObject::IsPlayerReadyToMakeInventoryRequest(int)</code>
    /// </summary>
    public static int IsPlayerReadyToMakeInventoryRequest(int quiet) => ((delegate* unmanaged[Cdecl]<int, int>)0x0058DE80)(quiet);

    /// <summary>
    /// <code>Offset: 0x0058DF90
    /// int __thiscall ACCWeenieObject::IsOwnedByPlayer(ACCWeenieObject*)</code>
    /// </summary>
    public int IsOwnedByPlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058DF90)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058E3C0
    /// void __thiscall ACCWeenieObject::UIAttemptWield(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    public void UIAttemptWield(uint loc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058E3C0)(ref this, loc);

    /// <summary>
    /// <code>Offset: 0x0058E450
    /// void __thiscall ACCWeenieObject::UIAttemptGive(ACCWeenieObject*,unsigned int,unsigned int)</code>
    /// </summary>
    public void UIAttemptGive(uint targetID, uint amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, uint, void>)0x0058E450)(ref this, targetID, amount);

    /// <summary>
    /// <code>Offset: 0x0058E4B0
    /// void __thiscall ACCWeenieObject::UIAttemptPutInContainer(ACCWeenieObject*,unsigned int,int)</code>
    /// </summary>
    public void UIAttemptPutInContainer(uint container, int place) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, void>)0x0058E4B0)(ref this, container, place);

    /// <summary>
    /// <code>Offset: 0x0058E530
    /// void __thiscall ACCWeenieObject::UIAttemptPutIn3D(ACCWeenieObject*)</code>
    /// </summary>
    public void UIAttemptPutIn3D() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058E530)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058E5A0
    /// void __thiscall ACCWeenieObject::UIAttemptMerge(ACCWeenieObject*,unsigned int,int)</code>
    /// </summary>
    public void UIAttemptMerge(uint mergeToItem, int amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, void>)0x0058E5A0)(ref this, mergeToItem, amount);

    /// <summary>
    /// <code>Offset: 0x0058E600
    /// void __thiscall ACCWeenieObject::UIAttemptSplitToContainer(ACCWeenieObject*,unsigned int,int,int)</code>
    /// </summary>
    public void UIAttemptSplitToContainer(uint container, int place, int amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, int, void>)0x0058E600)(ref this, container, place, amount);

    /// <summary>
    /// <code>Offset: 0x0058E680
    /// void __thiscall ACCWeenieObject::UIAttemptSplitTo3D(ACCWeenieObject*,int)</code>
    /// </summary>
    public void UIAttemptSplitTo3D(int amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058E680)(ref this, amount);

    /// <summary>
    /// <code>Offset: 0x0058E6F0
    /// void __thiscall ACCWeenieObject::SetPlayerWieldLocation(ACCWeenieObject*,const unsigned int)</code>
    /// </summary>
    public void SetPlayerWieldLocation(uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058E6F0)(ref this, newLocation);

    /// <summary>
    /// <code>Offset: 0x0058E870
    /// int __thiscall ACCWeenieObject::CanMoveInto(ACCWeenieObject*,CWeenieObject*)</code>
    /// </summary>
    public int CanMoveInto(ACBindings.Internal.CWeenieObject* mover) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.CWeenieObject*, int>)0x0058E870)(ref this, mover);

    /// <summary>
    /// <code>Offset: 0x0058E9A0
    /// int __cdecl ACCWeenieObject::HasCorpseBeenOpened(const unsigned int)</code>
    /// </summary>
    public static int HasCorpseBeenOpened(uint corpseID) => ((delegate* unmanaged[Cdecl]<uint, int>)0x0058E9A0)(corpseID);

    /// <summary>
    /// <code>Offset: 0x0058E9E0
    /// void __thiscall ACCWeenieObject::ServerSaysMoveItem(ACCWeenieObject*,unsigned int,int,unsigned int,unsigned int,int)</code>
    /// </summary>
    public void ServerSaysMoveItem(uint newContainer, int place, uint newWielder, uint newLocation, int broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, uint, uint, int, void>)0x0058E9E0)(ref this, newContainer, place, newWielder, newLocation, broadcast);

    /// <summary>
    /// <code>Offset: 0x0058EB50
    /// void __thiscall ACCWeenieObject::Remove(ACCWeenieObject*)</code>
    /// </summary>
    public void Remove() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058EB50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058EC00
    /// void __thiscall ACCWeenieObject::IconDataChanged(ACCWeenieObject*)</code>
    /// </summary>
    public void IconDataChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058EC00)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058EC60
    /// IconData* __thiscall ACCWeenieObject::GetIconData(ACCWeenieObject*)</code>
    /// </summary>
    public ACBindings.Internal.IconData* GetIconData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.IconData*>)0x0058EC60)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058ECF0
    /// void __thiscall ACCWeenieObject::SetType(ACCWeenieObject*,const ITEM_TYPE)</code>
    /// </summary>
    public void SetType(ACBindings.Internal.ITEM_TYPE type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ITEM_TYPE, void>)0x0058ECF0)(ref this, type);

    /// <summary>
    /// <code>Offset: 0x0058ED10
    /// void __thiscall ACCWeenieObject::SetUseability(ACCWeenieObject*,const ITEM_USEABLE)</code>
    /// </summary>
    public void SetUseability(ACBindings.Internal.ITEM_USEABLE useability) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ITEM_USEABLE, void>)0x0058ED10)(ref this, useability);

    /// <summary>
    /// <code>Offset: 0x0058ED30
    /// void __thiscall ACCWeenieObject::SetEffects(ACCWeenieObject*,const unsigned int)</code>
    /// </summary>
    public void SetEffects(uint effects) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058ED30)(ref this, effects);

    /// <summary>
    /// <code>Offset: 0x0058ED50
    /// void __thiscall ACCWeenieObject::OnStatUpdated_1(ACCWeenieObject*,unsigned int,int)</code>
    /// </summary>
    public void OnStatUpdated_1(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, void>)0x0058ED50)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x0058EFB0
    /// void __thiscall ACCWeenieObject::OnStatUpdated(int,int,int)</code>
    /// </summary>
    public void OnStatUpdated(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, int, void>)0x0058EFB0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0058F050
    /// void __thiscall ACCWeenieObject::OnStatUpdated(ACCWeenieObject*,unsigned int,unsigned int)</code>
    /// </summary>
    public void OnStatUpdated(uint stype, uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, uint, void>)0x0058F050)(ref this, stype, id);

    /// <summary>
    /// <code>Offset: 0x0058F170
    /// void __thiscall ACCWeenieObject::DeclareValid(ACCWeenieObject*)</code>
    /// </summary>
    public void DeclareValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058F170)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058F300
    /// void __thiscall ACCWeenieObject::ObjectBeingDeleted(ACCWeenieObject*)</code>
    /// </summary>
    public void ObjectBeingDeleted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058F300)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058F480
    /// Graphic* __thiscall ACCWeenieObject::GetIcon(ACCWeenieObject*)</code>
    /// </summary>
    public ACBindings.Internal.Graphic* GetIcon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.Graphic*>)0x0058F480)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058F490
    /// Graphic* __thiscall ACCWeenieObject::GetDragIcon(ACCWeenieObject*)</code>
    /// </summary>
    public ACBindings.Internal.Graphic* GetDragIcon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.Graphic*>)0x0058F490)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058F4A0
    /// void __cdecl ACCWeenieObject::SetCorpseOpened(const unsigned int)</code>
    /// </summary>
    public static void SetCorpseOpened(uint corpseID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058F4A0)(corpseID);

    /// <summary>
    /// <code>Offset: 0x0058F4F0
    /// void __cdecl ACCWeenieObject::SetCorpseDeleted(const unsigned int)</code>
    /// </summary>
    public static void SetCorpseDeleted(uint corpseID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058F4F0)(corpseID);

    /// <summary>
    /// <code>Offset: 0x0058F510
    /// char* __thiscall ACCWeenieObject::GetObjectName(ACCWeenieObject*,NameType,int)</code>
    /// </summary>
    public sbyte* GetObjectName(ACBindings.Internal.NameType nameType, int playerIsBackpack) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.NameType, int, sbyte*>)0x0058F510)(ref this, nameType, playerIsBackpack);

    /// <summary>
    /// <code>Offset: 0x0058F840
    /// char* __cdecl ACCWeenieObject::GetObjectName(unsigned int,NameType,int)</code>
    /// </summary>
    public static sbyte* GetObjectName(uint objID, ACBindings.Internal.NameType nameType, int playerIsBackpack) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.NameType, int, sbyte*>)0x0058F840)(objID, nameType, playerIsBackpack);

    /// <summary>
    /// <code>Offset: 0x0058F8B0
    /// wchar_t** __thiscall ACCWeenieObject::GetObjectNameWide(ACCWeenieObject*,wchar_t**,NameType,int)</code>
    /// </summary>
    public System.IntPtr GetObjectNameWide(System.IntPtr a2, ACBindings.Internal.NameType nameType, int ArgList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, System.IntPtr, ACBindings.Internal.NameType, int, System.IntPtr>)0x0058F8B0)(ref this, a2, nameType, ArgList);

    /// <summary>
    /// <code>Offset: 0x0058F8E0
    /// wchar_t** __cdecl ACCWeenieObject::GetObjectNameWide(wchar_t**,unsigned int,NameType,int)</code>
    /// </summary>
    public static System.IntPtr GetObjectNameWide(System.IntPtr a1, uint objID, ACBindings.Internal.NameType nameType, int playerIsBackpack) => ((delegate* unmanaged[Cdecl]<System.IntPtr, uint, ACBindings.Internal.NameType, int, System.IntPtr>)0x0058F8E0)(a1, objID, nameType, playerIsBackpack);

    /// <summary>
    /// <code>Offset: 0x0058F910
    /// void __thiscall ACCWeenieObject::ServerSaysAttemptFailed(ACCWeenieObject*,unsigned int,int)</code>
    /// </summary>
    public void ServerSaysAttemptFailed(uint etype, int printError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, void>)0x0058F910)(ref this, etype, printError);
}

