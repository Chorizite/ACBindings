namespace ACBindings.Internal;


/// <summary>Represents an instance of an in‑game object in the client, holding its identity, physics component, inventory contents, descriptive attributes, and state flags used for movement, interaction, and network synchronization.</summary>
public unsafe struct ACCWeenieObject : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CWeenieObject BaseClass_CWeenieObject; // ACBindings.Internal.CWeenieObject

    // Statics
    public static ACBindings.Internal.HashSet__uint* m_openedCorpses = (ACBindings.Internal.HashSet__uint*)0x008216E8;
    public static uint* selectedID = (uint*)0x00871E54;
    public static uint* prevSelectedID = (uint*)0x00871E58;
    public static uint* prevSelectedValidID = (uint*)0x00871E5C;
    public static sbyte** nameString = (sbyte**)0x00871E60;
    public static uint* splitStackSize = (uint*)0x00871EC4;
    public static double* splitTime = (double*)0x00871EC8;
    public static ACBindings.Internal.InventoryRequest* prevRequest = (ACBindings.Internal.InventoryRequest*)0x00871ED0;
    public static uint* prevRequestObjectID = (uint*)0x00871ED4;
    public static double* prevRequestTime = (double*)0x00871ED8;
    public static int* attackInProgress = (int*)0x00871EE0;
    public static ACBindings.Internal.IDClass____tagDataID* splitClassID = (ACBindings.Internal.IDClass____tagDataID*)0x00871F88;

    // Child Types

    /// <summary>Defines the virtual function table for an ACCWeenieObject, mapping function pointers to runtime behaviors such as movement, collision handling, and player state queries within the game engine.</summary>
    public unsafe struct ACCWeenieObject_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, void> ACCWeenieObject_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, void> ObjectBeingDeleted; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, void> process_netblobs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int, void> SetParentedState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsThePlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.ITEM_TYPE> InqType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsPlayerKiller; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsPK; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsPKLite; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsImpenetrable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsCreature; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, float, float*, byte> InqJumpVelocity; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, float*, byte> InqRunRate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, float*, byte> InqMaxRunRate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, float, byte> CanJump; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, float, int*, byte> JumpStaminaCost; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.CWeenieObject*, int> CanMoveInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> CanBypassMoveRestrictions; // function pointer
        public fixed byte gap4C[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.AtkCollisionProfile*, int> DoCollision; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, uint, void> DoCollisionEnd; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.ObjCollisionProfile*, int> InqCollisionProfile; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, void> ResetCollisions; // function pointer
        public System.IntPtr InqIconID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.PScriptType, float, int> PlayScript; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, uint> GetNumEmitters; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.AC1Legacy.Vector3*, int> GetGlobalVelocity; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsHook; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsStorage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, int> IsCorpse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCWeenieObject*, void> ResetPlayerDesc; // function pointer

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

    /// <summary>Determines whether the weenie object can function as a container by inspecting its activation type bits and capacity fields.
    /// <code>Offset: 0x004A48A0
    /// int __thiscall ACCWeenieObject::IsContainer(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non‑zero if the object is a container; zero otherwise.</returns>
    public int IsContainer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x004A48A0)(ref this);

    /// <summary>Determines whether this object represents a coin stack by comparing its WClass ID to the globally defined coin‑stack identifier.
    /// <code>Offset: 0x004BDEE0
    /// bool __thiscall ACCWeenieObject::IsCoinstack(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>True if the object's WClass ID equals the coin‑stack ID; otherwise, false.</returns>
    public byte IsCoinstack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, byte>)0x004BDEE0)(ref this);

    /// <summary>Determines whether the character is prevented from using a shield based on its combat properties.
    /// <code>Offset: 0x0055E100
    /// int __thiscall ACCWeenieObject::BlocksUseOfShield(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non‑zero (1) if the item blocks shield usage, zero otherwise.</returns>
    public int BlocksUseOfShield() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0055E100)(ref this);

    /// <summary>Assigns a restriction database to the object, copying data from the supplied source or allocating a new instance when none exists.
    /// <code>Offset: 0x00586720
    /// void __thiscall ACCWeenieObject::SetRestrictions(ACCWeenieObject*,const RestrictionDB*)</code>
    /// </summary>
    /// <param name="db">The restriction database to apply to the object.</param>
    public void SetRestrictions(ACBindings.Internal.RestrictionDB* db) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.RestrictionDB*, void>)0x00586720)(ref this, db);

    /// <summary>Determines whether the current object is classified as a component pack by looking up its ID in the database of component packs.
    /// <code>Offset: 0x00589230
    /// int __thiscall ACCWeenieObject::IsComponentPack(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non‑zero if the object's ID matches an entry in the component pack list; otherwise zero.</returns>
    public int IsComponentPack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x00589230)(ref this);

    /// <summary>Sets the object's openable status by updating its public descriptor bit field.
    /// <code>Offset: 0x0058CAD0
    /// void __thiscall ACCWeenieObject::SetOpenable(ACCWeenieObject*,const int)</code>
    /// </summary>
    /// <param name="openable">Non‑zero to mark the object as openable; zero removes that flag.</param>
    public void SetOpenable(int openable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CAD0)(ref this, openable);

    /// <summary>Sets or clears the object's stuck status by updating a flag in its description bitfield.
    /// <code>Offset: 0x0058CB00
    /// void __thiscall ACCWeenieObject::SetStuck(ACCWeenieObject*,const int)</code>
    /// </summary>
    /// <param name="stuck">Non‑zero to mark the object as stuck; zero clears the flag.</param>
    public void SetStuck(int stuck) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CB00)(ref this, stuck);

    /// <summary>Enables or disables the object's ability to be inscribed by setting a flag in its description bitfield.
    /// <code>Offset: 0x0058CB30
    /// void __thiscall ACCWeenieObject::SetInscribable(ACCWeenieObject*,const int)</code>
    /// </summary>
    /// <param name="inscribable">True to mark the object as inscribable; false to clear that flag.</param>
    public void SetInscribable(int inscribable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CB30)(ref this, inscribable);

    /// <summary>Sets or clears the hidden‑admin flag in this object's public description, determining whether it is visible to administrators.
    /// <code>Offset: 0x0058CB60
    /// void __thiscall ACCWeenieObject::SetHiddenAdmin(ACCWeenieObject*,const int)</code>
    /// </summary>
    /// <param name="hide">Non‑zero value enables the hidden status; zero disables it.</param>
    public void SetHiddenAdmin(int hide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CB60)(ref this, hide);

    /// <summary>Sets or clears the UI hidden flag for this object.
    /// <code>Offset: 0x0058CB90
    /// void __thiscall ACCWeenieObject::SetUIHidden(ACCWeenieObject*,const int)</code>
    /// </summary>
    /// <param name="hide">Non‑zero to hide the UI, zero to show it.</param>
    public void SetUIHidden(int hide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CB90)(ref this, hide);

    /// <summary>Updates the cell‑barrier immunity flag for this object.
    /// <code>Offset: 0x0058CBC0
    /// void __thiscall ACCWeenieObject::SetCellBarrierImmune(ACCWeenieObject*,const int)</code>
    /// </summary>
    /// <param name="b">Non‑zero enables immunity; zero disables it.</param>
    public void SetCellBarrierImmune(int b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CBC0)(ref this, b);

    /// <summary>Releases any existing player qualities and assigns a new PlayerDesc instance, resetting the object's state to default. If allocation fails, the description pointer is set to null.
    /// <code>Offset: 0x0058CBF0
    /// void __thiscall ACCWeenieObject::ResetPlayerDesc(ACCWeenieObject*)</code>
    /// </summary>
    public void ResetPlayerDesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058CBF0)(ref this);

    /// <summary>Updates the object's location flag to match its parented state.
    /// <code>Offset: 0x0058CC40
    /// void __thiscall ACCWeenieObject::SetParentedState(ACCWeenieObject*,int)</code>
    /// </summary>
    /// <param name="parentedState">Non‑zero sets the object’s location to its predefined valid locations; zero clears all location flags.</param>
    public void SetParentedState(int parentedState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CC40)(ref this, parentedState);

    /// <summary>Adds an object identifier to this weenie's inventory at a specific index, selecting between the items or containers sublist based on the supplied flag.
    /// <code>Offset: 0x0058CC70
    /// void __thiscall ACCWeenieObject::ServerSaysContainID(ACCWeenieObject*,unsigned int,int,int)</code>
    /// </summary>
    /// <param name="item">Identifier of the item or container to insert.</param>
    /// <param name="place">Zero‑based position within the chosen list where the identifier should be added.</param>
    /// <param name="itemIsContainer">Non‑zero if the ID represents a container; otherwise treated as an ordinary item.</param>
    public void ServerSaysContainID(uint item, int place, int itemIsContainer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, int, void>)0x0058CC70)(ref this, item, place, itemIsContainer);

    /// <summary>Updates the object's position state based on its removal status, container association, or location information.
    /// <code>Offset: 0x0058CCA0
    /// void __thiscall ACCWeenieObject::DeterminePositionState(ACCWeenieObject*)</code>
    /// </summary>
    public void DeterminePositionState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058CCA0)(ref this);

    /// <summary>Returns the count of items stored in this object's inventory.
    /// <code>Offset: 0x0058CCE0
    /// int __thiscall ACCWeenieObject::GetNumContainedItems(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>The number of contained item entries; returns 0 when the object has no inventory.</returns>
    public int GetNumContainedItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058CCE0)(ref this);

    /// <summary>Returns the count of containers stored within the object’s inventory.
    /// <code>Offset: 0x0058CCF0
    /// int __thiscall ACCWeenieObject::GetNumContainedContainers(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>An integer representing the number of container IDs; returns 0 if the inventory is absent.</returns>
    public int GetNumContainedContainers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058CCF0)(ref this);

    /// <summary>Determines how many item slots remain available for the object, considering its capacity and current inventory contents.
    /// <code>Offset: 0x0058CD00
    /// int __thiscall ACCWeenieObject::GetNumEmptyItemSlots(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>The count of empty slots; a value of –1 indicates unlimited capacity.</returns>
    public int GetNumEmptyItemSlots() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058CD00)(ref this);

    /// <summary>Retrieves the list of item identifiers contained within the object's inventory.
    /// <code>Offset: 0x0058CD20
    /// IDList* __thiscall ACCWeenieObject::GetContainedItemsList(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>A pointer to an <c>IDList</c> representing the container's items, or <c>nullptr</c> if no inventory is present.</returns>
    public ACBindings.Internal.IDList* GetContainedItemsList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.IDList*>)0x0058CD20)(ref this);

    /// <summary>Obtains the list of container IDs nested within this object’s inventory, or null when no inventory exists.
    /// <code>Offset: 0x0058CD30
    /// IDList* __thiscall ACCWeenieObject::GetContainedContainersList(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>A pointer to the IDList of contained containers, or nullptr if the object has no inventory.</returns>
    public ACBindings.Internal.IDList* GetContainedContainersList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.IDList*>)0x0058CD30)(ref this);

    /// <summary>Collects all item identifiers stored directly in this object's inventory and those inside any contained containers, storing them into the supplied result list.
    /// <code>Offset: 0x0058CD40
    /// IDList* __thiscall ACCWeenieObject::GetExhaustiveContainedItemsList(ACCWeenieObject*,IDList*)</code>
    /// </summary>
    /// <param name="result">Pre‑allocated IDList to receive the aggregated item IDs.</param>
    /// <returns>The same result pointer for chaining convenience.</returns>
    public ACBindings.Internal.IDList* GetExhaustiveContainedItemsList(ACBindings.Internal.IDList* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.IDList*, ACBindings.Internal.IDList*>)0x0058CD40)(ref this, result);

    /// <summary>Returns the address of the inventory placement list for this object, or zero when unavailable.
    /// <code>Offset: 0x0058CE20
    /// int __thiscall ACCWeenieObject::GetInvPlacementList(_DWORD*)</code>
    /// </summary>
    /// <returns>The base address of the inventory placement list, or 0 if none exists.</returns>
    public int GetInvPlacementList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058CE20)(ref this);

    /// <summary>Verifies that every item and container stored in the object’s inventory refers to a valid object. Recursively checks nested containers; returns true if all contained objects exist.
    /// <code>Offset: 0x0058CE30
    /// int __thiscall ACCWeenieObject::AllContainedObjectsExist(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non‑zero (1) when all contained objects are present, zero (0) otherwise.</returns>
    public int AllContainedObjectsExist() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058CE30)(ref this);

    /// <summary>Searches the object's inventory list for an item ID and returns its zero‑based index.
    /// <code>Offset: 0x0058CEC0
    /// int __thiscall ACCWeenieObject::GetPlaceInItemsList(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    /// <param name="id">The identifier of the item to locate.</param>
    /// <returns>The position of the matching item if present; 0 when the object has no inventory, or –1 when the item is not found in the list.</returns>
    public int GetPlaceInItemsList(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int>)0x0058CEC0)(ref this, id);

    /// <summary>Searches an object's inventory for a container matching the given identifier and returns its zero‑based position in the internal list.
    /// <code>Offset: 0x0058CEE0
    /// int __thiscall ACCWeenieObject::GetPlaceInContainersList(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    /// <param name="id">The unique ID of the container to locate.</param>
    /// <returns>The index of the container within the inventory; 0 if the object has no inventory, or –1 if the ID is not present.</returns>
    public int GetPlaceInContainersList(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int>)0x0058CEE0)(ref this, id);

    /// <summary>Sets the object's waiting state, triggering an item attribute refresh when the object is valid.
    /// <code>Offset: 0x0058CF00
    /// void __thiscall ACCWeenieObject::SetWaitingState(ACCWeenieObject*,int)</code>
    /// </summary>
    /// <param name="waiting">The new waiting flag value.</param>
    public void SetWaitingState(int waiting) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CF00)(ref this, waiting);

    /// <summary>Updates the object's shortcut number and ghost status, and triggers an attribute change notification if the object is currently valid.
    /// <code>Offset: 0x0058CF30
    /// void __thiscall ACCWeenieObject::SetShortcutNum(ACCWeenieObject*,int,bool)</code>
    /// </summary>
    /// <param name="i_nShortcutNum">The new shortcut slot number to assign.</param>
    /// <param name="i_bGhosted">Whether the shortcut should be displayed as a ghost (invisible or placeholder).</param>
    public void SetShortcutNum(int i_nShortcutNum, byte i_bGhosted) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, byte, void>)0x0058CF30)(ref this, i_nShortcutNum, i_bGhosted);

    /// <summary>Sets the object's trade state and, when modified on a valid object, signals that its item attributes have changed.
    /// <code>Offset: 0x0058CF70
    /// void __thiscall ACCWeenieObject::SetTradeState(ACCWeenieObject*,int)</code>
    /// </summary>
    /// <param name="tradeState">The new trade state to assign to the object.</param>
    public void SetTradeState(int tradeState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CF70)(ref this, tradeState);

    /// <summary>Updates the object’s selling status and notifies listeners when the state changes.
    /// <code>Offset: 0x0058CFA0
    /// void __thiscall ACCWeenieObject::SetSellState(ACCWeenieObject*,int)</code>
    /// </summary>
    /// <param name="sellState">The desired new sell state value to assign to this object.</param>
    public void SetSellState(int sellState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058CFA0)(ref this, sellState);

    /// <summary>Determines whether two game objects are within a specified distance of each other.
    /// <code>Offset: 0x0058CFD0
    /// int __cdecl ACCWeenieObject::ObjectsInRange(unsigned int,unsigned int,long double,bool,bool)</code>
    /// </summary>
    /// <param name="ID1">Identifier for the first object to test.</param>
    /// <param name="ID2">Identifier for the second object to test.</param>
    /// <param name="range">Maximum allowed distance between the objects.</param>
    /// <param name="use_radii">If true, include each object's radius when computing distance; otherwise compare centers only.</param>
    /// <param name="xy_only">If true, evaluate only XY-plane separation and ignore vertical difference.</param>
    /// <returns>1 if the objects are within the specified range; 0 otherwise.</returns>
    public static int ObjectsInRange(uint ID1, uint ID2, double range, byte use_radii, byte xy_only) => ((delegate* unmanaged[Cdecl]<uint, uint, double, byte, byte, int>)0x0058CFD0)(ID1, ID2, range, use_radii, xy_only);

    /// <summary>Stores the specified inventory request and its object identifier, along with the current timestamp, for later processing.
    /// <code>Offset: 0x0058D050
    /// void __cdecl ACCWeenieObject::RecordRequest(unsigned int,InventoryRequest)</code>
    /// </summary>
    /// <param name="requestObjID">Identifier of the requested object.</param>
    /// <param name="request">Details of the inventory request to be recorded.</param>
    public static void RecordRequest(uint requestObjID, ACBindings.Internal.InventoryRequest request) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.InventoryRequest, void>)0x0058D050)(requestObjID, request);

    /// <summary>Determines whether the object should be shown on the radar based on its radar visibility settings.
    /// <code>Offset: 0x0058D080
    /// int __thiscall ACCWeenieObject::InqShowableOnRadar(ACCWeenieObject*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="cur_pos">The object's current position used for radar determination (unused in this implementation).</param>
    /// <returns>Non-zero if the object is visible on radar; zero otherwise.</returns>
    public int InqShowableOnRadar(ACBindings.Internal.AC1Legacy.Vector3* cur_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0058D080)(ref this, cur_pos);

    /// <summary>Assigns the given structure identifier to the object and signals that its attributes have changed.
    /// <code>Offset: 0x0058D0B0
    /// void __thiscall ACCWeenieObject::SetStructure(ACCWeenieObject*,const unsigned int)</code>
    /// </summary>
    /// <param name="structure">The new structure identifier for the object.</param>
    public void SetStructure(uint structure) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058D0B0)(ref this, structure);

    /// <summary>Sets the object's maximum structure and signals an attribute change event to update dependent systems.
    /// <code>Offset: 0x0058D0D0
    /// void __thiscall ACCWeenieObject::SetMaxStructure(ACCWeenieObject*,const unsigned int)</code>
    /// </summary>
    /// <param name="maxStructure">The new maximum structural integrity value for the object.</param>
    public void SetMaxStructure(uint maxStructure) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058D0D0)(ref this, maxStructure);

    /// <summary>Sets the stack size for this item, updating internal state and broadcasting a change notification.
    /// <code>Offset: 0x0058D0F0
    /// void __thiscall ACCWeenieObject::SetStackSize(ACCWeenieObject*,const unsigned int)</code>
    /// </summary>
    /// <param name="stackSize">The new number of units in the stack.</param>
    public void SetStackSize(uint stackSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058D0F0)(ref this, stackSize);

    /// <summary>Updates the current selected object in the client system, clearing any previous selection and applying the new one. If the selection changes or a forced reselection occurs, it notifies the UI and registered plugins of the change.
    /// <code>Offset: 0x0058D110
    /// void __cdecl ACCWeenieObject::SetSelectedObject(unsigned int,int)</code>
    /// </summary>
    /// <param name="selectedID">The unique identifier of the object to select; zero clears the selection.</param>
    /// <param name="reselect">If non‑zero forces the selection process even when the same ID is already selected.</param>
    public static void SetSelectedObject(uint selectedID, int reselect) => ((delegate* unmanaged[Cdecl]<uint, int, void>)0x0058D110)(selectedID, reselect);

    /// <summary>Records the supplied identifier as the most recent selection for future reference.
    /// <code>Offset: 0x0058D1B0
    /// void __cdecl ACCWeenieObject::SetPreviousSelectedObject(unsigned int)</code>
    /// </summary>
    /// <param name="selectedID">The unique identifier of the object that was previously selected.</param>
    public static void SetPreviousSelectedObject(uint selectedID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058D1B0)(selectedID);

    /// <summary>Assigns a new identifier to mark the object that is currently selected.
    /// <code>Offset: 0x0058D1C0
    /// void __cdecl ACCWeenieObject::SetSelectedObjectID(unsigned int)</code>
    /// </summary>
    /// <param name="selectedID">The unique ID of the object being selected.</param>
    public static void SetSelectedObjectID(uint selectedID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058D1C0)(selectedID);

    /// <summary>Handles a collision event by invoking the default script on the object’s physics component when it is present and in an active state.
    /// <code>Offset: 0x0058D1D0
    /// int __thiscall ACCWeenieObject::DoCollision(ACCWeenieObject*,const EnvCollisionProfile*)</code>
    /// </summary>
    /// <param name="prof">Collision profile containing velocity and flags; currently not processed directly by this routine.</param>
    /// <returns>Always 1 to indicate that the collision was handled successfully.</returns>
    public int DoCollision(ACBindings.Internal.EnvCollisionProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.EnvCollisionProfile*, int>)0x0058D1D0)(ref this, prof);

    /// <summary>Checks whether the current ACCWeenieObject instance represents the player controlled by the client.
    /// <code>Offset: 0x0058D200
    /// int __thiscall ACCWeenieObject::IsThePlayer(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non‑zero if the object's ID matches the global player identifier stored at SmartBox::smartbox + 244; otherwise zero.</returns>
    public int IsThePlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D200)(ref this);

    /// <summary>Determines whether the current object represents a creature.
    /// <code>Offset: 0x0058D220
    /// int __thiscall ACCWeenieObject::IsCreature(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non‑zero if the object is a creature; zero otherwise.</returns>
    public int IsCreature() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D220)(ref this);

    /// <summary>Determines whether this weenie can perform a jump action, considering its current state and quality settings. The supplied extent value indicates the desired jump magnitude or threshold to be evaluated against the object's capabilities.
    /// <code>Offset: 0x0058D230
    /// bool __thiscall ACCWeenieObject::CanJump(ACCWeenieObject*,float)</code>
    /// </summary>
    /// <param name="extent">Desired jump extent that must be supported by the object's qualities.</param>
    /// <returns>True if both the base object allows jumping and the player’s qualities permit a jump with the specified extent; otherwise, false.</returns>
    public byte CanJump(float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, float, byte>)0x0058D230)(ref this, extent);

    /// <summary>Calculates stamina cost required to perform a jump of specified extent and indicates whether the jump is permissible.
    /// <code>Offset: 0x0058D270
    /// bool __thiscall ACCWeenieObject::JumpStaminaCost(ACCWeenieObject*,float,int*)</code>
    /// </summary>
    /// <param name="extent">The desired jump distance or height in game units.</param>
    /// <param name="cost">Pointer to an integer that receives the computed stamina cost if the calculation succeeds.</param>
    /// <returns>True if the object is valid, quality information is available, and a stamina cost can be calculated; otherwise false.</returns>
    public byte JumpStaminaCost(float extent, int* cost) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, float, int*, byte>)0x0058D270)(ref this, extent, cost);

    /// <summary>Forwards a script command to this object's physics component, executing with an optional modifier.
    /// <code>Offset: 0x0058D2B0
    /// int __thiscall ACCWeenieObject::PlayScript(ACCWeenieObject*,PScriptType,float)</code>
    /// </summary>
    /// <param name="script_type">The identifier of the script to play.</param>
    /// <param name="mod">A floating‑point modifier applied during script execution.</param>
    /// <returns>The result from CPhysicsObj::play_script, or 0 if the object has no physics component.</returns>
    public int PlayScript(ACBindings.Internal.PScriptType script_type, float mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.PScriptType, float, int>)0x0058D2B0)(ref this, script_type, mod);

    /// <summary>Retrieves the count of particle emitters associated with the object's physics component, returning zero if none exist.
    /// <code>Offset: 0x0058D2D0
    /// unsigned int __thiscall ACCWeenieObject::GetNumEmitters(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>The number of active emitters; 0 when the object lacks a physics object or particle manager.</returns>
    public uint GetNumEmitters() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint>)0x0058D2D0)(ref this);

    /// <summary>Retrieves the object's current global velocity vector from its physics component.
    /// <code>Offset: 0x0058D2F0
    /// int __thiscall ACCWeenieObject::GetGlobalVelocity(ACCWeenieObject*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="velocity">Output parameter receiving the velocity in world space.</param>
    /// <returns>Non‑zero (typically 1) when a physics object exists and the velocity is obtained; otherwise zero.</returns>
    public int GetGlobalVelocity(ACBindings.Internal.AC1Legacy.Vector3* velocity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0058D2F0)(ref this, velocity);

    /// <summary>Determines whether the object is permitted to ignore movement restrictions by checking specific internal flags.
    /// <code>Offset: 0x0058D330
    /// int __thiscall ACCWeenieObject::CanBypassMoveRestrictions(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Returns non‑zero (true) if both required bits are set in the object's description bitfield, indicating that move restrictions can be bypassed; otherwise returns zero (false).</returns>
    public int CanBypassMoveRestrictions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D330)(ref this);

    /// <summary>Determines whether the object can perform a jump of the requested extent and retrieves the upward velocity component.
    /// <code>Offset: 0x0058D350
    /// bool __thiscall ACCWeenieObject::InqJumpVelocity(ACCWeenieObject*,float,float*)</code>
    /// </summary>
    /// <param name="extent">The desired horizontal distance or jump extent to evaluate.</param>
    /// <param name="v_z">Pointer receiving the calculated vertical velocity if the query succeeds.</param>
    /// <returns>True when the object is capable of such a jump and the vertical velocity was successfully obtained; otherwise false.</returns>
    public byte InqJumpVelocity(float extent, float* v_z) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, float, float*, byte>)0x0058D350)(ref this, extent, v_z);

    /// <summary>Retrieves the object’s current run rate and writes it to the supplied output parameter.
    /// <code>Offset: 0x0058D390
    /// bool __thiscall ACCWeenieObject::InqRunRate(ACCWeenieObject*,float*)</code>
    /// </summary>
    /// <param name="rate">Pointer that receives the run rate value when the query succeeds.</param>
    /// <returns>true if the run rate was successfully retrieved; otherwise, false.</returns>
    public byte InqRunRate(float* rate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, float*, byte>)0x0058D390)(ref this, rate);

    /// <summary>Obtains the object’s maximum run rate by querying its underlying quality data.
    /// <code>Offset: 0x0058D3D0
    /// bool __thiscall ACCWeenieObject::InqMaxRunRate(ACCWeenieObject*,float*)</code>
    /// </summary>
    /// <param name="rate">Pointer to a float where the retrieved maximum run rate will be stored if successful.</param>
    /// <returns>True when the run rate was successfully obtained; otherwise false.</returns>
    public byte InqMaxRunRate(float* rate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, float*, byte>)0x0058D3D0)(ref this, rate);

    /// <summary>Initializes the object's time stamper component if it has not been configured yet, ensuring subsequent operations can rely on a valid stamper instance.
    /// <code>Offset: 0x0058D410
    /// int __thiscall ACCWeenieObject::SetupStamper(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non‑zero when a stamper is present after the call (either already set up or newly created); zero if memory allocation fails and no stamper is available.</returns>
    public int SetupStamper() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D410)(ref this);

    /// <summary>Checks whether the specified object belongs to the same allegiance as this object by comparing monarch identifiers.
    /// <code>Offset: 0x0058D460
    /// int __thiscall ACCWeenieObject::IsAllegianceMember(ACCWeenieObject*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="wobj">The other object to compare against.</param>
    /// <returns>Non-zero if both objects share the same monarch; zero otherwise.</returns>
    public int IsAllegianceMember(ACBindings.Internal.ACCWeenieObject* wobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ACCWeenieObject*, int>)0x0058D460)(ref this, wobj);

    /// <summary>Determines whether the weenie functions as a hook by examining its hook properties.
    /// <code>Offset: 0x0058D490
    /// int __thiscall ACCWeenieObject::IsHook(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non‑zero if the object has a defined hook type and item types; zero otherwise.</returns>
    public int IsHook() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D490)(ref this);

    /// <summary>Updates internal flags of the object when specific stat types change.
    /// <code>Offset: 0x0058D4B0
    /// void __thiscall ACCWeenieObject::OnStatUpdated(ACCWeenieObject*,unsigned int,int)</code>
    /// </summary>
    /// <param name="stype">Identifier for the stat being updated (e.g., 1 = stuck, 3 = openable).</param>
    /// <param name="val">New value for the stat; interpreted as a boolean or integer depending on the stat type.</param>
    public void OnStatUpdated(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, void>)0x0058D4B0)(ref this, stype, val);

    /// <summary>Initializes an ACCWeenieObject with the specified identifier, setting up base class data, inventory pointers, state flags, and allocating player quality storage when required.
    /// <code>Offset: 0x0058D5C0
    /// void __thiscall ACCWeenieObject::ACCWeenieObject(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    /// <param name="iid">The unique identifier assigned to this object instance.</param>
    public void _ConstructorInternal(uint iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058D5C0)(ref this, iid);

    /// <summary>Determines whether this weenie represents a player based on its public descriptor bitfield.
    /// <code>Offset: 0x0058D6C0
    /// int __thiscall ACCWeenieObject::IsPlayer(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non‑zero (true) when the object is a player; zero (false) otherwise.</returns>
    public int IsPlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D6C0)(ref this);

    /// <summary>Checks whether the object's PublicWeenieDesc has the PK Lite flag set.
    /// <code>Offset: 0x0058D6D0
    /// int __thiscall ACCWeenieObject::IsPKLite(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non-zero if the PK Lite bit is enabled; otherwise zero.</returns>
    public int IsPKLite() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D6D0)(ref this);

    /// <summary>Determines whether the object is flagged as a player killer.
    /// <code>Offset: 0x0058D6E0
    /// int __thiscall ACCWeenieObject::IsPK(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non‑zero if the PK flag is set; otherwise zero.</returns>
    public int IsPK() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D6E0)(ref this);

    /// <summary>Indicates whether this object is flagged as impenetrable by examining an internal flag.
    /// <code>Offset: 0x0058D6F0
    /// int __thiscall ACCWeenieObject::IsImpenetrable(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non‑zero if the impenetrability flag (bit 21) is set; otherwise zero.</returns>
    public int IsImpenetrable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D6F0)(ref this);

    /// <summary>Retrieves the type identifier of the Weenie object.
    /// <code>Offset: 0x0058D700
    /// ITEM_TYPE __thiscall ACCWeenieObject::InqType(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>The object's ITEM_TYPE value from its PublicWeenieDesc.</returns>
    public ACBindings.Internal.ITEM_TYPE InqType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ITEM_TYPE>)0x0058D700)(ref this);

    /// <summary>Determines whether this object represents a corpse based on its internal flag.
    /// <code>Offset: 0x0058D710
    /// int __thiscall ACCWeenieObject::IsCorpse(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non‑zero if the object is a corpse; zero otherwise.</returns>
    public int IsCorpse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D710)(ref this);

    /// <summary>Retrieves the icon identifier associated with this object and writes it to the supplied address.
    /// <code>Offset: 0x0058D730
    /// _DWORD* __thiscall ACCWeenieObject::InqIconID(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Address where the retrieved icon ID should be stored.</param>
    /// <returns>Pointer to the output location containing the icon ID.</returns>
    public int* InqIconID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int*, int*>)0x0058D730)(ref this, a2);

    /// <summary>Determines if the object’s quality descriptor contains either of two specific flag bits.
    /// <code>Offset: 0x0058D740
    /// int __thiscall ACCWeenieObject::IsPlayerKiller(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non-zero when either flag bit (0x20 or 0x2000000) is set; otherwise zero.</returns>
    public int IsPlayerKiller() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058D740)(ref this);

    /// <summary>Destroys an ACCWeenieObject instance, releasing its PlayerDesc, PublicWeenieDesc, and cleaning up inherited resources while resetting base‑class virtual tables and hash data.
    /// <code>Offset: 0x0058D760
    /// void __thiscall ACCWeenieObject::~ACCWeenieObject(ACCWeenieObject*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058D760)(ref this);

    /// <summary>Adds all containers and items stored in this object's inventory to the destruction queue for cleanup.
    /// <code>Offset: 0x0058D7D0
    /// void __thiscall ACCWeenieObject::AddContentsToDestructionQueue(ACCWeenieObject*)</code>
    /// </summary>
    public void AddContentsToDestructionQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058D7D0)(ref this);

    /// <summary>Removes all objects in the inventory from the destruction queue, ensuring that containers and their contents are no longer scheduled for deletion. Recursively processes nested containers to clean up the entire hierarchy.
    /// <code>Offset: 0x0058D850
    /// void __thiscall ACCWeenieObject::RemoveContentsFromDestructionQueue(ACCWeenieObject*)</code>
    /// </summary>
    public void RemoveContentsFromDestructionQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058D850)(ref this);

    /// <summary>Records receipt of a response by clearing pending request state when the supplied ID matches the expected one.
    /// <code>Offset: 0x0058D8E0
    /// void __cdecl ACCWeenieObject::RecordResponse(unsigned int)</code>
    /// </summary>
    /// <param name="responseObjID">Identifier of the response object to validate against stored request.</param>
    public static void RecordResponse(uint responseObjID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058D8E0)(responseObjID);

    /// <summary>Populates an ObjCollisionProfile structure with data derived from this object, including identifiers and flags relevant to collision detection.
    /// <code>Offset: 0x0058D910
    /// int __thiscall ACCWeenieObject::InqCollisionProfile(ACCWeenieObject*,ObjCollisionProfile*)</code>
    /// </summary>
    /// <param name="prof">The profile structure to be filled with collision information.</param>
    /// <returns>An integer status code (always 1) indicating successful population of the profile.</returns>
    public int InqCollisionProfile(ACBindings.Internal.ObjCollisionProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ObjCollisionProfile*, int>)0x0058D910)(ref this, prof);

    /// <summary>Ensures the object's time stamper is initialized and updates the house‑restriction timestamp with the supplied value.
    /// <code>Offset: 0x0058D980
    /// int __thiscall ACCWeenieObject::UpdateHouseRestrictionTS(ACCWeenieObject*,unsigned __int8)</code>
    /// </summary>
    /// <param name="ts">The new timestamp to apply to the house restriction.</param>
    /// <returns>The result of SetupStamper if initialization fails, otherwise the result of WTimeStamper::UpdateHouseRestrictionTS; callers can inspect this value for error status.</returns>
    public int UpdateHouseRestrictionTS(byte ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, byte, int>)0x0058D980)(ref this, ts);

    /// <summary>Determines whether the object's magic pack contains an item of the specified baseclass ID.
    /// <code>Offset: 0x0058D9B0
    /// int __thiscall ACCWeenieObject::MagicPackIsOwned(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Baseclass identifier to search for within the magic pack.</param>
    /// <returns>Non‑zero (1) if an item with the given ID exists; zero otherwise.</returns>
    public int MagicPackIsOwned(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, int>)0x0058D9B0)(ref this, a2);

    /// <summary>Determines whether the object is a storage container by comparing its ID to the predefined storage identifier.
    /// <code>Offset: 0x0058DA10
    /// int __thiscall ACCWeenieObject::IsStorage(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>Non‑zero when the object's ID matches the storage ID; otherwise zero.</returns>
    public int IsStorage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058DA10)(ref this);

    /// <summary>Updates the object's stack size and value according to a server message, applying the changes immediately and notifying observers of attribute updates.
    /// <code>Offset: 0x0058DA70
    /// void __thiscall ACCWeenieObject::ServerSaysSetStackSize(ACCWeenieObject*,int,unsigned int)</code>
    /// </summary>
    /// <param name="size">The new stack size to assign to the object.</param>
    /// <param name="value">The new value (e.g., monetary amount) associated with the object.</param>
    public void ServerSaysSetStackSize(int size, uint value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, uint, void>)0x0058DA70)(ref this, size, value);

    /// <summary>Adds a weenObj's ID into this object's inventory or container list at the specified position when activation type or capacity permits and it is not already present.
    /// <code>Offset: 0x0058DB10
    /// void __thiscall ACCWeenieObject::AddContent(ACCWeenieObject*,ACCWeenieObject*,int)</code>
    /// </summary>
    /// <param name="weenObj">The object to add as content.</param>
    /// <param name="place">Index in the list where the object should be inserted; if larger than the current size, the item is appended.</param>
    public void AddContent(ACBindings.Internal.ACCWeenieObject* weenObj, int place) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ACCWeenieObject*, int, void>)0x0058DB10)(ref this, weenObj, place);

    /// <summary>Removes the specified weenie object from this object's inventory or container list and signals attribute changes.
    /// <code>Offset: 0x0058DBA0
    /// void __thiscall ACCWeenieObject::RemoveContent(ACCWeenieObject*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="weenObj">The weenie object to be removed.</param>
    public void RemoveContent(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ACCWeenieObject*, void>)0x0058DBA0)(ref this, weenObj);

    /// <summary>Searches this object's inventory for an entry whose ID matches the supplied value and returns its associated location identifier. Returns 0 when the inventory is missing or the ID does not exist.
    /// <code>Offset: 0x0058DC00
    /// unsigned int __thiscall ACCWeenieObject::GetLocationOnObject(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    /// <param name="id">The unique identifier of the item to locate within the inventory.</param>
    /// <returns>The unsigned integer representing the item's location on the object, or zero if no matching entry is found.</returns>
    public uint GetLocationOnObject(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, uint>)0x0058DC00)(ref this, id);

    /// <summary>Searches an object's inventory for an item whose location flags match <paramref name="loc"/> and whose priority bits intersect with <paramref name="priority"/>, returning its identifier or 0 if none are found.
    /// <code>Offset: 0x0058DC30
    /// unsigned int __thiscall ACCWeenieObject::GetObjectAtLocation(ACCWeenieObject*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="loc">Bitmask representing the desired object location.</param>
    /// <param name="priority">Mask specifying acceptable priority bits; a value of zero disables priority filtering.</param>
    /// <returns>Identifier of the matching inventory item, or 0 when no suitable object exists.</returns>
    public uint GetObjectAtLocation(uint loc, uint priority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, uint, uint>)0x0058DC30)(ref this, loc, priority);

    /// <summary>Determines whether the current weenie is owned or controlled by the trader identified by id.
    /// <code>Offset: 0x0058DC80
    /// int __thiscall ACCWeenieObject::IsOwnedByTrader(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    /// <param name="id">The unique identifier of a trader to test ownership against.</param>
    /// <returns>1 if the weenie belongs to the specified trader; otherwise 0.</returns>
    public int IsOwnedByTrader(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int>)0x0058DC80)(ref this, id);

    /// <summary>Determines whether this weenie is owned by the specified object id through direct identity, containment, or location relationships.
    /// <code>Offset: 0x0058DCE0
    /// int __thiscall ACCWeenieObject::IsOwnedByObject(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    /// <param name="id">The identifier of the potential owning object.</param>
    /// <returns>Non‑zero if the weenie is owned by the given id; zero otherwise.</returns>
    public int IsOwnedByObject(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int>)0x0058DCE0)(ref this, id);

    /// <summary>Retrieves the size of the house payment stack, defaulting to 1 when none is specified.
    /// <code>Offset: 0x0058DDB0
    /// int __thiscall ACCWeenieObject::GetHousePayment(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>The number of units in the house payment stack, or 1 if the stack size is zero.</returns>
    public int GetHousePayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058DDB0)(ref this);

    /// <summary>Checks whether the player can initiate an inventory request based on current game state.
    /// <code>Offset: 0x0058DE80
    /// int __cdecl ACCWeenieObject::IsPlayerReadyToMakeInventoryRequest(int)</code>
    /// </summary>
    /// <param name="quiet">If true, suppresses user interface notifications when the request cannot be made.</param>
    /// <returns>Non‑zero if the player is ready to make an inventory request; zero otherwise.</returns>
    public static int IsPlayerReadyToMakeInventoryRequest(int quiet) => ((delegate* unmanaged[Cdecl]<int, int>)0x0058DE80)(quiet);

    /// <summary>Checks whether this object is owned by the current player.
    /// <code>Offset: 0x0058DF90
    /// int __thiscall ACCWeenieObject::IsOwnedByPlayer(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>An integer value of 1 if the object belongs to the player, 0 otherwise.</returns>
    public int IsOwnedByPlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int>)0x0058DF90)(ref this);

    /// <summary>Attempts to wield the object at the specified inventory location, handling normal and stackable items.
    /// <code>Offset: 0x0058E3C0
    /// void __thiscall ACCWeenieObject::UIAttemptWield(ACCWeenieObject*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The weenie instance initiating the action.</param>
    /// <param name="loc">Inventory slot index from which to attempt wielding.</param>
    public void UIAttemptWield(uint loc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058E3C0)(ref this, loc);

    /// <summary>Initiates an item transfer to the specified target when the player is prepared for an inventory action.
    /// <code>Offset: 0x0058E450
    /// void __thiscall ACCWeenieObject::UIAttemptGive(ACCWeenieObject*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="targetID">Identifier of the receiving entity.</param>
    /// <param name="amount">Number of items to transfer.</param>
    public void UIAttemptGive(uint targetID, uint amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, uint, void>)0x0058E450)(ref this, targetID, amount);

    /// <summary>Attempts to move the current object into a specified container at a given position, sending an inventory event if the player is ready to make a request. Depending on the object's current state, records the request as either a put-in-container action or sets up a pickup request with timestamp.
    /// <code>Offset: 0x0058E4B0
    /// void __thiscall ACCWeenieObject::UIAttemptPutInContainer(ACCWeenieObject*,unsigned int,int)</code>
    /// </summary>
    /// <param name="container">The ID of the target container.</param>
    /// <param name="place">The slot position within the container where the item should be placed.</param>
    public void UIAttemptPutInContainer(uint container, int place) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, void>)0x0058E4B0)(ref this, container, place);

    /// <summary>Attempts to drop the current object into the 3‑D world by firing a drop event and logging the request according to the object’s state when the player is prepared for inventory actions.
    /// <code>Offset: 0x0058E530
    /// void __thiscall ACCWeenieObject::UIAttemptPutIn3D(ACCWeenieObject*)</code>
    /// </summary>
    public void UIAttemptPutIn3D() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058E530)(ref this);

    /// <summary>Attempts to merge a specified quantity of stackable items from this object into another, queuing the operation when the player is ready.
    /// <code>Offset: 0x0058E5A0
    /// void __thiscall ACCWeenieObject::UIAttemptMerge(ACCWeenieObject*,unsigned int,int)</code>
    /// </summary>
    /// <param name="mergeToItem">The identifier of the item that will receive the merged stack.</param>
    /// <param name="amount">The number of items to transfer from this object to the target item.</param>
    public void UIAttemptMerge(uint mergeToItem, int amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, void>)0x0058E5A0)(ref this, mergeToItem, amount);

    /// <summary>Attempts to initiate a stack split request from the player into a specified container and slot, recording the operation only when the player is ready for inventory actions.
    /// <code>Offset: 0x0058E600
    /// void __thiscall ACCWeenieObject::UIAttemptSplitToContainer(ACCWeenieObject*,unsigned int,int,int)</code>
    /// </summary>
    /// <param name="container">Identifier of the destination container.</param>
    /// <param name="place">Slot or position within the container where items should be placed.</param>
    /// <param name="amount">Number of items to split from the stack.</param>
    public void UIAttemptSplitToContainer(uint container, int place, int amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, int, void>)0x0058E600)(ref this, container, place, amount);

    /// <summary>Initiates a stack split operation by converting part of an inventory item into a separate 3‑dimensional object and records the request state.
    /// <code>Offset: 0x0058E680
    /// void __thiscall ACCWeenieObject::UIAttemptSplitTo3D(ACCWeenieObject*,int)</code>
    /// </summary>
    /// <param name="amount">The number of items to transfer from the original stack to the new 3‑D instance.</param>
    public void UIAttemptSplitTo3D(int amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, void>)0x0058E680)(ref this, amount);

    /// <summary>Changes an object's wield location by removing its current inventory placement and inserting it at the specified slot. If the object has a physics component, translucency is cleared when detached.
    /// <code>Offset: 0x0058E6F0
    /// void __thiscall ACCWeenieObject::SetPlayerWieldLocation(ACCWeenieObject*,const unsigned int)</code>
    /// </summary>
    /// <param name="newLocation">The desired slot index for the object; zero removes the object from any wielded position.</param>
    public void SetPlayerWieldLocation(uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058E6F0)(ref this, newLocation);

    /// <summary>Verifies whether a given object can enter the environment represented by this ACCWeenieObject, enforcing house ownership and restriction database rules. If movement is disallowed, script handling is triggered and house‑restriction effects are disabled before returning zero; otherwise returns one to allow entry.
    /// <code>Offset: 0x0058E870
    /// int __thiscall ACCWeenieObject::CanMoveInto(ACCWeenieObject*,CWeenieObject*)</code>
    /// </summary>
    /// <param name="mover">The object attempting to move into the environment.</param>
    /// <returns>Non-zero (typically 1) if movement is permitted; zero if denied due to house ownership or restriction rules.</returns>
    public int CanMoveInto(ACBindings.Internal.CWeenieObject* mover) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.CWeenieObject*, int>)0x0058E870)(ref this, mover);

    /// <summary>Determines whether the corpse identified by the supplied ID has already been opened.
    /// <code>Offset: 0x0058E9A0
    /// int __cdecl ACCWeenieObject::HasCorpseBeenOpened(const unsigned int)</code>
    /// </summary>
    /// <param name="corpseID">The unique identifier of the corpse to check.</param>
    /// <returns>Non‑zero if the corpse was previously opened; zero otherwise.</returns>
    public static int HasCorpseBeenOpened(uint corpseID) => ((delegate* unmanaged[Cdecl]<uint, int>)0x0058E9A0)(corpseID);

    /// <summary>Moves an object between containers or positions, updating its container ID, wield status, and world location while adjusting internal state accordingly. Optionally broadcasts the move to notify other systems.
    /// <code>Offset: 0x0058E9E0
    /// void __thiscall ACCWeenieObject::ServerSaysMoveItem(ACCWeenieObject*,unsigned int,int,unsigned int,unsigned int,int)</code>
    /// </summary>
    /// <param name="newContainer">The identifier of the target container; zero indicates no container.</param>
    /// <param name="place">The slot position within the new container where the object should reside.</param>
    /// <param name="newWielder">The identifier of the player wielding the item, used to set or clear wield location.</param>
    /// <param name="newLocation">The new world location ID for the object.</param>
    /// <param name="broadcast">Flag indicating whether a server broadcast about this move should be sent (non‑zero means broadcast).</param>
    public void ServerSaysMoveItem(uint newContainer, int place, uint newWielder, uint newLocation, int broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, uint, uint, int, void>)0x0058E9E0)(ref this, newContainer, place, newWielder, newLocation, broadcast);

    /// <summary>Prepares an ACCWeenieObject for removal by recording its current container and location information, notifying the server that it has moved to an invalid state, and clearing global selection if this object was selected.
    /// <code>Offset: 0x0058EB50
    /// void __thiscall ACCWeenieObject::Remove(ACCWeenieObject*)</code>
    /// </summary>
    public void Remove() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058EB50)(ref this);

    /// <summary>Refreshes the object's icon information by finding its record in the global icon table and, if an update occurs, informs dependent components that item attributes have changed.
    /// <code>Offset: 0x0058EC00
    /// void __thiscall ACCWeenieObject::IconDataChanged(ACCWeenieObject*)</code>
    /// </summary>
    public void IconDataChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058EC00)(ref this);

    /// <summary>Retrieves the icon data for this object, creating a new entry if none exists in the shared cache.
    /// <code>Offset: 0x0058EC60
    /// IconData* __thiscall ACCWeenieObject::GetIconData(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>A pointer to an IconData structure that holds the object's visual identifiers; returns null when memory allocation fails.</returns>
    public ACBindings.Internal.IconData* GetIconData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.IconData*>)0x0058EC60)(ref this);

    /// <summary>Assigns a new ITEM_TYPE to this object and refreshes its icon data when the object is valid.
    /// <code>Offset: 0x0058ECF0
    /// void __thiscall ACCWeenieObject::SetType(ACCWeenieObject*,const ITEM_TYPE)</code>
    /// </summary>
    /// <param name="type">The ITEM_TYPE value to apply.</param>
    public void SetType(ACBindings.Internal.ITEM_TYPE type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ITEM_TYPE, void>)0x0058ECF0)(ref this, type);

    /// <summary>Updates the object's use‑ability status and refreshes icon data when the object is valid.
    /// <code>Offset: 0x0058ED10
    /// void __thiscall ACCWeenieObject::SetUseability(ACCWeenieObject*,const ITEM_USEABLE)</code>
    /// </summary>
    /// <param name="useability">New use‑ability setting for the object.</param>
    public void SetUseability(ACBindings.Internal.ITEM_USEABLE useability) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.ITEM_USEABLE, void>)0x0058ED10)(ref this, useability);

    /// <summary>Assigns a new set of effect flags to the object and refreshes its icon data when currently valid.
    /// <code>Offset: 0x0058ED30
    /// void __thiscall ACCWeenieObject::SetEffects(ACCWeenieObject*,const unsigned int)</code>
    /// </summary>
    /// <param name="effects">Bitmask representing the effects to apply.</param>
    public void SetEffects(uint effects) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, void>)0x0058ED30)(ref this, effects);

    /// <summary>Updates the object's attributes according to a statistic type identifier and its new value, handling properties such as item type, priority, capacities, location, stack size, useability, effects, value, ammo/combat use, structure limits, blip color, radar enum, killer status, and hooks.
    /// <code>Offset: 0x0058ED50
    /// void __thiscall ACCWeenieObject::OnStatUpdated_1(ACCWeenieObject*,unsigned int,int)</code>
    /// </summary>
    /// <param name="stype">Identifier of the stat to update.</param>
    /// <param name="val">New value for the specified stat.</param>
    public void OnStatUpdated_1(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, void>)0x0058ED50)(ref this, stype, val);

    /// <summary>Updates internal stat fields of the object based on the provided stat identifier, and triggers an icon refresh when necessary.
    /// <code>Offset: 0x0058EFB0
    /// void __thiscall ACCWeenieObject::OnStatUpdated(int,int,int)</code>
    /// </summary>
    /// <param name="statIndex">Identifier of the statistic being updated (e.g., 8, 44, 50, 52).</param>
    /// <param name="newValue">The new value to assign to the specified statistic.</param>
    public void OnStatUpdated(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, int, int, void>)0x0058EFB0)(ref this, a2, a3);

    /// <summary>Responds to stat update events by updating internal descriptors and, when appropriate, notifying the server of item movements.
    /// <code>Offset: 0x0058F050
    /// void __thiscall ACCWeenieObject::OnStatUpdated(ACCWeenieObject*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="stype">The statistic type indicating which attribute has changed (e.g., 2 for container ID, 3 for wielder ID).</param>
    /// <param name="id">The new value associated with the stat update.</param>
    public void OnStatUpdated(uint stype, uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, uint, void>)0x0058F050)(ref this, stype, id);

    /// <summary>Marks the object as valid, cleans up any pending destruction of inventory items and containers, updates icon rendering when attributes change, and manages split‑class logic based on time and stack size.
    /// <code>Offset: 0x0058F170
    /// void __thiscall ACCWeenieObject::DeclareValid(ACCWeenieObject*)</code>
    /// </summary>
    public void DeclareValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058F170)(ref this);

    /// <summary>Prepares an AccWeenieObject for deletion by clearing its physical representation, removing contained items and containers that no longer belong to it, updating icon data tables, disposing of any attached time stamper, cleaning up network blob lists, and notifying the physics system about its removal.
    /// <code>Offset: 0x0058F300
    /// void __thiscall ACCWeenieObject::ObjectBeingDeleted(ACCWeenieObject*)</code>
    /// </summary>
    public void ObjectBeingDeleted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, void>)0x0058F300)(ref this);

    /// <summary>Retrieves the icon graphic associated with this object.
    /// <code>Offset: 0x0058F480
    /// Graphic* __thiscall ACCWeenieObject::GetIcon(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>A pointer to the Graphic representing the object's icon.</returns>
    public ACBindings.Internal.Graphic* GetIcon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.Graphic*>)0x0058F480)(ref this);

    /// <summary>Retrieves the graphic used when dragging this object in the interface.
    /// <code>Offset: 0x0058F490
    /// Graphic* __thiscall ACCWeenieObject::GetDragIcon(ACCWeenieObject*)</code>
    /// </summary>
    /// <returns>The Graphic representing the object's drag icon, or nullptr if none is defined.</returns>
    public ACBindings.Internal.Graphic* GetDragIcon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.Graphic*>)0x0058F490)(ref this);

    /// <summary>Records that the specified corpse has been opened, adding its ID to the global set of opened corpses if not already present.
    /// <code>Offset: 0x0058F4A0
    /// void __cdecl ACCWeenieObject::SetCorpseOpened(const unsigned int)</code>
    /// </summary>
    /// <param name="corpseID">Identifier of the corpse whose open state should be recorded.</param>
    public static void SetCorpseOpened(uint corpseID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058F4A0)(corpseID);

    /// <summary>Removes the specified corpse ID from the object's opened corpses table and frees its allocated memory if present.
    /// <code>Offset: 0x0058F4F0
    /// void __cdecl ACCWeenieObject::SetCorpseDeleted(const unsigned int)</code>
    /// </summary>
    /// <param name="corpseID">The unique identifier of the corpse to delete.</param>
    public static void SetCorpseDeleted(uint corpseID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0058F4F0)(corpseID);

    /// <summary>Returns a human‑readable name for the object, optionally pluralized or prefixed by its material type.
    /// <code>Offset: 0x0058F510
    /// char* __thiscall ACCWeenieObject::GetObjectName(ACCWeenieObject*,NameType,int)</code>
    /// </summary>
    /// <param name="nameType">Specifies whether to return the singular or plural form of the base name. If NAME_APPROPRIATE is supplied and the item has more than one stack, the plural form will be used.</param>
    /// <param name="playerIsBackpack">When non‑zero and the object represents a backpack, the function returns the literal string "Backpack".</param>
    /// <returns>Pointer to a statically allocated buffer containing the formatted name. The returned pointer may refer to an offset within that buffer if the name is marked for special display.</returns>
    public sbyte* GetObjectName(ACBindings.Internal.NameType nameType, int playerIsBackpack) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, ACBindings.Internal.NameType, int, sbyte*>)0x0058F510)(ref this, nameType, playerIsBackpack);

    /// <summary>Returns the display name of an object identified by <paramref name="objID"/>, handling a special “Backpack” case when requested for the player’s backpack.
    /// <code>Offset: 0x0058F840
    /// char* __cdecl ACCWeenieObject::GetObjectName(unsigned int,NameType,int)</code>
    /// </summary>
    /// <param name="objID">The unique identifier of the target object.</param>
    /// <param name="nameType">Specifies how the object's name should be formatted (e.g., full or short).</param>
    /// <param name="playerIsBackpack">True if the caller is requesting the name for a player’s backpack; when true and <paramref name="objID"/> matches the current backpack ID, “Backpack” is returned.</param>
    /// <returns>Pointer to a static character buffer containing the object's name; an empty string if no object exists for the given ID.</returns>
    public static sbyte* GetObjectName(uint objID, ACBindings.Internal.NameType nameType, int playerIsBackpack) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.NameType, int, sbyte*>)0x0058F840)(objID, nameType, playerIsBackpack);

    /// <summary>Retrieves the object's name in Unicode format by converting an internally stored narrow string based on the requested <paramref name="nameType"/> and optional formatting arguments.
    /// <code>Offset: 0x0058F8B0
    /// wchar_t** __thiscall ACCWeenieObject::GetObjectNameWide(ACCWeenieObject*,wchar_t**,NameType,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a wide‑character buffer that will receive the converted name; the returned value is the same pointer.</param>
    /// <param name="nameType">Specifies which form of the object's name to return (e.g., full, short, display).</param>
    /// <param name="ArgList">Optional additional arguments used when formatting the name string.</param>
    /// <returns>The wide‑character buffer containing the object's name.</returns>
    public System.IntPtr GetObjectNameWide(System.IntPtr a2, ACBindings.Internal.NameType nameType, int ArgList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, System.IntPtr, ACBindings.Internal.NameType, int, System.IntPtr>)0x0058F8B0)(ref this, a2, nameType, ArgList);

    /// <summary>Retrieves the name of a game object in UTF‑16 format, storing it in the supplied buffer.
    /// <code>Offset: 0x0058F8E0
    /// wchar_t** __cdecl ACCWeenieObject::GetObjectNameWide(wchar_t**,unsigned int,NameType,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to a wide‑character string buffer that will receive the object's name.</param>
    /// <param name="objID">Identifier of the target object whose name is requested.</param>
    /// <param name="nameType">Specifies which variant of the object’s name to obtain (e.g., display name, full name).</param>
    /// <param name="playerIsBackpack">Flag indicating whether the caller is accessing the player’s backpack context.</param>
    /// <returns>Pointer to the buffer containing the object's name in wide characters.</returns>
    public static System.IntPtr GetObjectNameWide(System.IntPtr a1, uint objID, ACBindings.Internal.NameType nameType, int playerIsBackpack) => ((delegate* unmanaged[Cdecl]<System.IntPtr, uint, ACBindings.Internal.NameType, int, System.IntPtr>)0x0058F8E0)(a1, objID, nameType, playerIsBackpack);

    /// <summary>Handles server notifications that an action attempt failed, clearing pending status and displaying a context‑specific failure message.
    /// <code>Offset: 0x0058F910
    /// void __thiscall ACCWeenieObject::ServerSaysAttemptFailed(ACCWeenieObject*,unsigned int,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the object instance whose operation failed.</param>
    /// <param name="etype">Error type code indicating reason for failure (e.g., merge, split, move).</param>
    /// <param name="printError">Flag determining whether to display a user‑visible error message; non‑zero shows message.</param>
    public void ServerSaysAttemptFailed(uint etype, int printError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCWeenieObject, uint, int, void>)0x0058F910)(ref this, etype, printError);
}

