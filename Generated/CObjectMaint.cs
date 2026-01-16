namespace ACBindings.Internal;


/// <summary>Manages object lifecycle within the engine, maintaining active status, reference counts, and lookup tables for physics objects, weenie entities, inventories, and destruction events.</summary>
/// <remarks>Tracks lost cells, visibility, and scheduled destructions to coordinate cleanup and resource management across the simulation world.</remarks>
public unsafe struct CObjectMaint : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface
    public ACBindings.Internal.NoticeHandler BaseClass_NoticeHandler; // ACBindings.Internal.NoticeHandler

    // Statics
    public static ACBindings.Internal.CObjectMaint** s_pcInstance = (ACBindings.Internal.CObjectMaint**)0x00842ADC;

    // Child Types
    public unsafe struct CObjectMaint_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.CObjectMaint.Enum5> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public fixed byte gap1C[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, void> CObjectMaint_dtor_20; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.VisualDesc*, void> SetVisualDesc; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.WeenieDesc*, int, void> SetWeenieDesc; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, uint, ACBindings.Internal.VisualDesc*, ACBindings.Internal.PhysicsDesc*, ACBindings.Internal.WeenieDesc*, ACBindings.Internal.CPhysicsObj*> CreateObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.VisualDesc*, void> SetPlayerVisualDesc; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.VisualDesc*> GetPlayerVisualDesc; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, void> OnShutdown; // function pointer

        // Methods
    }
    // CObjectMaint::Enum3
    public enum Enum3 : uint
    {
    }
    // CObjectMaint::Enum4
    public enum Enum4 : uint
    {
    }
    // CObjectMaint::Enum5
    public enum Enum5 : uint
    {
    }
    // CObjectMaint::Enum6
    public enum Enum6 : uint
    {
    }
    // CObjectMaint::Enum7
    public enum Enum7 : uint
    {
    }
    // CObjectMaint::Enum8
    public enum Enum8 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public int is_active;
    public ACBindings.Internal.IntrusiveHashTable__uint___CLostCell_ptr lost_cell_table;
    public ACBindings.Internal.LongHash___CPhysicsObj object_table;
    public ACBindings.Internal.LongHash___CPhysicsObj null_object_table;
    public ACBindings.Internal.LongHash___CWeenieObject weenie_object_table;
    public ACBindings.Internal.LongHash___CWeenieObject null_weenie_object_table;
    public ACBindings.Internal.HashSet__uint visible_object_table;
    public ACBindings.Internal.HashTable__uint__double destruction_object_table;
    public ACBindings.Internal.LongHash___CObjectInventory object_inventory_table;
    public ACBindings.Internal.AC1Legacy.PQueueArray__double object_destruction_queue;

    // Generated Constructor
    public CObjectMaint() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves a requested interface from the current object based on its GUID and reports success or failure in the supplied result structure.
    /// <code>Offset: 0x00508360
    /// TResult* __thiscall CObjectMaint::QueryInterface(CObjectMaint*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Structure that receives the status code: 0 if the interface is found, otherwise an error code such as E_NOINTERFACE.</param>
    /// <param name="i_rcInterface">GUID identifying the desired interface.</param>
    /// <param name="o_ppvInterface">Output parameter that receives a pointer to the requested interface when it is available; left unchanged if not found.</param>
    /// <returns>Pointer to the supplied result structure containing the outcome of the query.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00508360)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Detaches all physics objects in the specified cell that have no parent and are currently not marked as visible, removing them from the active visibility system.
    /// <code>Offset: 0x005086E0
    /// void __thiscall CObjectMaint::ReleaseObjCell(CObjectMaint*,CObjCell*)</code>
    /// </summary>
    /// <param name="cell">The object cell whose contained physics objects should be processed.</param>
    public void ReleaseObjCell(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CObjCell*, void>)0x005086E0)(ref this, cell);

    /// <summary>Unregisters the object from the global interface system and releases its reference during shutdown.
    /// <code>Offset: 0x005087C0
    /// void __thiscall CObjectMaint::OnShutdown(CObjectMaint*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, void>)0x005087C0)(ref this);

    /// <summary>Inserts a physics object into the maintainer's hash table for quick lookup by its unique identifier.
    /// <code>Offset: 0x00508810
    /// void __thiscall CObjectMaint::AddObject(CObjectMaint*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object to be added to the collection.</param>
    public void AddObject(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CPhysicsObj*, void>)0x00508810)(ref this, object_);

    /// <summary>Adds a weenie object to the maintenance system’s internal hash table, enabling efficient look‑up and management of that object.
    /// <code>Offset: 0x00508850
    /// void __thiscall CObjectMaint::AddWeenieObject(CObjectMaint*,CWeenieObject*)</code>
    /// </summary>
    /// <param name="object">The CWeenieObject instance to register.</param>
    public void AddWeenieObject(ACBindings.Internal.CWeenieObject* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CWeenieObject*, void>)0x00508850)(ref this, object_);

    /// <summary>Retrieves a physics object from the object's hash table by its unique identifier.
    /// <code>Offset: 0x00508890
    /// CPhysicsObj* __thiscall CObjectMaint::GetObjectA(CObjectMaint*,unsigned int)</code>
    /// </summary>
    /// <param name="object_id">The unsigned integer ID of the desired object.</param>
    /// <returns>Pointer to the matching <c>CPhysicsObj</c> instance if found; otherwise null.</returns>
    public ACBindings.Internal.CPhysicsObj* GetObjectA(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.CPhysicsObj*>)0x00508890)(ref this, object_id);

    /// <summary>Retrieves the CWeenieObject that matches the specified object ID from the maintainer’s hash table, returning null if no entry exists.
    /// <code>Offset: 0x005088E0
    /// CWeenieObject* __thiscall CObjectMaint::GetWeenieObject(CObjectMaint*,unsigned int)</code>
    /// </summary>
    /// <param name="object_id">The unique identifier of the weenie to locate.</param>
    /// <returns>A pointer to the matching CWeenieObject, or nullptr when the ID is not present in the table.</returns>
    public ACBindings.Internal.CWeenieObject* GetWeenieObject(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.CWeenieObject*>)0x005088E0)(ref this, object_id);

    /// <summary>Retrieves the inventory record associated with a given object identifier from the object's inventory table.
    /// <code>Offset: 0x00508930
    /// CObjectInventory* __thiscall CObjectMaint::GetObjectInventory(CObjectMaint*,unsigned int)</code>
    /// </summary>
    /// <param name="object_id">The unique identifier of the object whose inventory is requested.</param>
    /// <returns>A pointer to the CObjectInventory instance for the specified object, or nullptr if no inventory exists for that ID.</returns>
    public ACBindings.Internal.CObjectInventory* GetObjectInventory(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.CObjectInventory*>)0x00508930)(ref this, object_id);

    /// <summary>Detaches the specified notice handler from every weenie object managed by this CObjectMaint instance.
    /// <code>Offset: 0x00508980
    /// void __thiscall CObjectMaint::UnRegisterAllNoticeHandlers(CObjectMaint*,NoticeHandler*)</code>
    /// </summary>
    /// <param name="handler">The NoticeHandler to remove from objects.</param>
    public void UnRegisterAllNoticeHandlers(ACBindings.Internal.NoticeHandler* handler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.NoticeHandler*, void>)0x00508980)(ref this, handler);

    /// <summary>Retrieves a physics object and its corresponding weenie object for the specified ID, assigning them to the provided output pointers.
    /// <code>Offset: 0x00508A40
    /// int __thiscall CObjectMaint::GetObjectA(CObjectMaint*,unsigned int,CPhysicsObj**,CWeenieObject**)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the target object.</param>
    /// <param name="physobj">Receives pointer to the object's CPhysicsObj instance if found.</param>
    /// <param name="weenieobj">Receives pointer to the object's CWeenieObject instance if found.</param>
    /// <returns>Non‑zero (1) when at least one of the objects is retrieved; zero otherwise.</returns>
    public int GetObjectA(uint object_id, ACBindings.Internal.CPhysicsObj** physobj, ACBindings.Internal.CWeenieObject** weenieobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.CPhysicsObj**, ACBindings.Internal.CWeenieObject**, int>)0x00508A40)(ref this, object_id, physobj, weenieobj);

    /// <summary>Removes a physics object from the lost‑cell table when it has no active cell or parent, cleaning up orphaned objects.
    /// <code>Offset: 0x00508A80
    /// void __thiscall CObjectMaint::RemoveFromLostCell(CObjectMaint*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object to be removed if it is not attached to any cell or parent.</param>
    public void RemoveFromLostCell(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CPhysicsObj*, void>)0x00508A80)(ref this, object_);

    /// <summary>Retrieves the lost cell for a given ID from the object's hash table, creating and inserting a new entry if none exists.
    /// <code>Offset: 0x00508C70
    /// CLostCell* __thiscall CObjectMaint::GetLostCell(CObjectMaint*,unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">The identifier of the cell to retrieve or create.</param>
    /// <returns>A pointer to the CLostCell associated with the specified ID; a newly allocated cell is returned when no existing entry is found.</returns>
    public ACBindings.Internal.CLostCell* GetLostCell(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.CLostCell*>)0x00508C70)(ref this, cell_id);

    /// <summary>Moves an unattached physics object into a lost‑cell container by assigning it the specified cell ID and registering it with the corresponding lost cell's object list.
    /// <code>Offset: 0x00508CE0
    /// void __thiscall CObjectMaint::GotoLostCell(CObjectMaint*,CPhysicsObj*,unsigned int)</code>
    /// </summary>
    /// <param name="object">The physics object to relocate when it has no parent.</param>
    /// <param name="new_cell_id">Identifier for the new cell to assign to the object.</param>
    public void GotoLostCell(ACBindings.Internal.CPhysicsObj* object_, uint new_cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CPhysicsObj*, uint, void>)0x00508CE0)(ref this, object_, new_cell_id);

    /// <summary>Restores a previously lost object cell by re-entering visibility for its contained physics objects and freeing associated resources.
    /// <code>Offset: 0x00508D30
    /// void __thiscall CObjectMaint::InitObjCell(CObjectMaint*,CObjCell*)</code>
    /// </summary>
    /// <param name="cell">The object cell to initialize.</param>
    public void InitObjCell(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CObjCell*, void>)0x00508D30)(ref this, cell);

    /// <summary>Rebuilds the visible object set for the maintenance instance by clearing the current list and adding objects from the internal table that are marked as active.
    /// <code>Offset: 0x00508E60
    /// void __thiscall CObjectMaint::UpdateVisibleObjectList(CObjectMaint*)</code>
    /// </summary>
    /// <param name="this">The CObjectMaint instance whose visibility list is updated.</param>
    public void UpdateVisibleObjectList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, void>)0x00508E60)(ref this);

    /// <summary>Removes an object identified by its ID from the destruction table, deallocating any associated data.
    /// <code>Offset: 0x00508F10
    /// void __thiscall CObjectMaint::RemoveObjectToBeDestroyed(CObjectMaint*,unsigned int)</code>
    /// </summary>
    /// <param name="object_id">The unique identifier of the object to remove.</param>
    public void RemoveObjectToBeDestroyed(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, void>)0x00508F10)(ref this, object_id);

    /// <summary>Removes a physics object from all management structures and detaches it from the world.
    /// <code>Offset: 0x00508F30
    /// void __thiscall CObjectMaint::DeleteObject(CObjectMaint*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object to delete.</param>
    public void DeleteObject(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CPhysicsObj*, void>)0x00508F30)(ref this, object_);

    /// <summary>Removes an object with the given ID from the maintainer's collections, cleaning up physics and weenie data.
    /// <code>Offset: 0x00508FA0
    /// int __thiscall CObjectMaint::DeleteObject(CObjectMaint*,unsigned int)</code>
    /// </summary>
    /// <param name="object_id">The unique identifier of the object to delete.</param>
    /// <returns>1 if the object was found and removed; 0 otherwise.</returns>
    public int DeleteObject(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, int>)0x00508FA0)(ref this, object_id);

    /// <summary>Initializes the CObjectMaint instance by setting reference counters, allocating and configuring hash tables for lost cells, physics objects, weenie objects, visibility, destruction, inventory, and a destruction queue. Registers the class with the global InterfaceSystem to enable interface queries.
    /// <code>Offset: 0x005090A0
    /// void __thiscall CObjectMaint::CObjectMaint(CObjectMaint*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, void>)0x005090A0)(ref this);

    /// <summary>Creates a new physics object with the specified ID and descriptors, registering it in the manager's tables.
    /// <code>Offset: 0x00509410
    /// CPhysicsObj* __thiscall CObjectMaint::CreateObject(CObjectMaint*,unsigned int,VisualDesc*,PhysicsDesc*,WeenieDesc*)</code>
    /// </summary>
    /// <param name="objectID">The unique identifier for the object to be created.</param>
    /// <param name="vdesc">Description of the object's visual representation.</param>
    /// <param name="physicsdesc">Specification of physical properties and initial state.</param>
    /// <param name="wdesc">Descriptor containing game logic or behavior data for the object.</param>
    /// <returns>Pointer to the newly created CPhysicsObj, or nullptr if creation fails.</returns>
    public ACBindings.Internal.CPhysicsObj* CreateObject(uint objectID, ACBindings.Internal.VisualDesc* vdesc, ACBindings.Internal.PhysicsDesc* physicsdesc, ACBindings.Internal.WeenieDesc* wdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.VisualDesc*, ACBindings.Internal.PhysicsDesc*, ACBindings.Internal.WeenieDesc*, ACBindings.Internal.CPhysicsObj*>)0x00509410)(ref this, objectID, vdesc, physicsdesc, wdesc);

    /// <summary>Decrements the object's turbine reference count and releases the base interface when the count reaches zero.
    /// <code>Offset: 0x00509450
    /// unsigned int __thiscall CObjectMaint::Release(CObjectMaint*)</code>
    /// </summary>
    /// <returns>The updated reference count after release; zero indicates the object has been fully released.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint>)0x00509450)(ref this);

    /// <summary>Performs time‑based maintenance tasks, refreshing radar visibility when needed, executing scheduled object deletions, and re‑sending force description messages for stale null or weenie objects.
    /// <code>Offset: 0x00509480
    /// void __thiscall CObjectMaint::UseTime(CObjectMaint*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, void>)0x00509480)(ref this);

    /// <summary>Destroys all physics and weenie objects managed by the object maintenance system, removing them from world simulation, clearing hash tables, and freeing associated resources.
    /// <code>Offset: 0x00509700
    /// void __thiscall CObjectMaint::DestroyObjects(CObjectMaint*)</code>
    /// </summary>
    public void DestroyObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, void>)0x00509700)(ref this);

    /// <summary>Schedules an object for destruction after a fixed delay, recording the scheduled time in the destruction table and inserting it into the destruction queue.
    /// <code>Offset: 0x00509A40
    /// void __thiscall CObjectMaint::AddObjectToBeDestroyed(CObjectMaint*,unsigned int)</code>
    /// </summary>
    /// <param name="object_id">The identifier of the object to be destroyed.</param>
    public void AddObjectToBeDestroyed(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, void>)0x00509A40)(ref this, object_id);

    /// <summary>Retrieves a null physics object by ID from the null object table; creates one if absent and requested.
    /// <code>Offset: 0x00509AB0
    /// CPhysicsObj* __thiscall CObjectMaint::GetNullObject(CObjectMaint*,unsigned int,int)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the desired null object.</param>
    /// <param name="create_new_object">Non‑zero to create a new null object when none exists in the table.</param>
    /// <returns>Pointer to the found or newly created CPhysicsObj, or nullptr if not present and creation was not requested.</returns>
    public ACBindings.Internal.CPhysicsObj* GetNullObject(uint object_id, int create_new_object) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, int, ACBindings.Internal.CPhysicsObj*>)0x00509AB0)(ref this, object_id, create_new_object);

    /// <summary>Retrieves a null weenie object from the table by its identifier; if none exists and create_new_object is non‑zero, creates a new instance, registers it for destruction, and returns it.
    /// <code>Offset: 0x00509B60
    /// CWeenieObject* __thiscall CObjectMaint::GetNullWeenieObject(CObjectMaint*,unsigned int,int)</code>
    /// </summary>
    /// <param name="object_id">The unique identifier of the desired null weenie object.</param>
    /// <param name="create_new_object">When set to true, causes creation of a new CWeenieObject if one does not already exist in the table.</param>
    /// <returns>A pointer to the requested CWeenieObject, or nullptr when it is absent and create_new_object is false.</returns>
    public ACBindings.Internal.CWeenieObject* GetNullWeenieObject(uint object_id, int create_new_object) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, int, ACBindings.Internal.CWeenieObject*>)0x00509B60)(ref this, object_id, create_new_object);

    /// <summary>Destroys the CObjectMaint instance by cleaning up all internal data structures, freeing allocated memory for object tables, visibility sets, destruction queues, and resetting reference counts before the object is removed.
    /// <code>Offset: 0x00509C10
    /// void __thiscall CObjectMaint::~CObjectMaint(CObjectMaint*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, void>)0x00509C10)(ref this);

    /// <summary>Queues a network data blob for the specified object. If the object does not exist, it uses a null placeholder and marks the object for destruction before queuing.
    /// <code>Offset: 0x00509DA0
    /// void __thiscall CObjectMaint::QueueBlobForObject(CObjectMaint*,unsigned int,NetBlob*)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the target object.</param>
    /// <param name="blob">Network blob to be queued for transmission.</param>
    public void QueueBlobForObject(uint object_id, ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.NetBlob*, void>)0x00509DA0)(ref this, object_id, blob);

    /// <summary>Queues a network blob for delivery to the specified weenie object and schedules that object for destruction.
    /// <code>Offset: 0x00509DE0
    /// void __thiscall CObjectMaint::QueueBlobForWeenieObject(CObjectMaint*,unsigned int,unsigned int,NetBlob*)</code>
    /// </summary>
    /// <param name="object_id">The identifier of the target weenie object.</param>
    /// <param name="stamp">A sequence or timestamp used by the queueing system.</param>
    /// <param name="blob">The NetBlob containing data to be sent to the weenie object.</param>
    public void QueueBlobForWeenieObject(uint object_id, uint stamp, ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, uint, ACBindings.Internal.NetBlob*, void>)0x00509DE0)(ref this, object_id, stamp, blob);

    /// <summary>Queues a network blob for the specified weenie object and flags the object for destruction after queuing.
    /// <code>Offset: 0x00509E10
    /// void __thiscall CObjectMaint::QueueBlobForWeenieObject(CObjectMaint*,unsigned int,NetBlob*)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the target weenie object.</param>
    /// <param name="blob">Network data to be queued for transmission.</param>
    public void QueueBlobForWeenieObject(uint object_id, ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.NetBlob*, void>)0x00509E10)(ref this, object_id, blob);

    /// <summary>
    /// Sets the child relationships for a physics object using data from a PhysicsDesc descriptor. Existing children are first unparented; then each specified child ID in the descriptor is resolved from the object's table or replaced with a null object if not found, and linked as a child at the given location index.
    /// 
    /// <code>Offset: 0x00509E40
    /// void __thiscall CObjectMaint::SetChildren(CObjectMaint*,CPhysicsObj*,PhysicsDesc*)</code>
    /// </summary>
    /// <param name="this">The CObjectMaint instance that manages physics objects.</param>
    /// <param name="obj">The target physics object whose children are being updated.</param>
    /// <param name="desc">Descriptor containing the list of child IDs and their desired parent-child relationship data.</param>
    public void SetChildren(ACBindings.Internal.CPhysicsObj* obj, ACBindings.Internal.PhysicsDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.PhysicsDesc*, void>)0x00509E40)(ref this, obj, desc);
}

