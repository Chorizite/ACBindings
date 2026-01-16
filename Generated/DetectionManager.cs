namespace ACBindings.Internal;


/// <summary>
/// Handles detection objects in the physics engine, tracking pending updates, global changes, and scheduled deletions.
/// </summary>
public unsafe struct DetectionManager : System.IDisposable
{
    // Members
    public ACBindings.Internal.CPhysicsObj* physobj;
    public System.IntPtr detection_objects;
    public uint num_pending_global_detect_updates;
    public ACBindings.Internal.CELLARRAY* cell_array;
    public double last_update_time;
    public ACBindings.Internal.Position last_global_update;
    public ACBindings.Internal.LongNIHash___DetectionCylsphere detection_table;
    public ACBindings.Internal.AC1Legacy.SmartArray__uint pending_deletions;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// Evaluates whether a physics object has entered or exited the cylindrical detection zone,
    /// updating the cylinder’s internal flag accordingly.
    /// 
    /// <code>Offset: 0x0051A200
    /// DetectionType __thiscall DetectionManager::CheckDetection(DetectionManager*,DetectionCylsphere*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="this">The DetectionManager instance whose global state is used during evaluation.</param>
    /// <param name="detcyl">DetectionCylsphere defining the radius of the detection region and tracking whether an object was previously inside it.</param>
    /// <param name="object">The CPhysicsObj to test against the detection zone.</param>
    /// <returns>0 when no entry or exit is detected, EnteredDetection when the object enters the zone, and 2 when the object exits the zone (previously flagged as detected).</returns>
    public ACBindings.Internal.DetectionType CheckDetection(ACBindings.Internal.DetectionCylsphere* detcyl, ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionCylsphere*, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.DetectionType>)0x0051A200)(ref this, detcyl, object_);

    /// <summary>Populates the supplied CELLARRAY with cells surrounding the detection object's position, using the cylinder's radius as a spherical search distance and preventing further cell loading.
    /// <code>Offset: 0x0051A3C0
    /// void __thiscall DetectionManager::FindCellList(DetectionManager*,DetectionCylsphere*,CELLARRAY*)</code>
    /// </summary>
    /// <param name="detcyl">The DetectionCylsphere providing the radius for the search area.</param>
    /// <param name="new_cell_array">The CELLARRAY to receive the list of nearby cells; its do_not_load_cells flag is set to true during the operation.</param>
    public void FindCellList(ACBindings.Internal.DetectionCylsphere* detcyl, ACBindings.Internal.CELLARRAY* new_cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionCylsphere*, ACBindings.Internal.CELLARRAY*, void>)0x0051A3C0)(ref this, detcyl, new_cell_array);

    /// <summary>Initializes global detection structures for a cylindrical detection object, populating the internal cell array and adding voyeur references to relevant cells.
    /// <code>Offset: 0x0051A480
    /// int __thiscall DetectionManager::InitializeGlobalDetection(DetectionManager*,DetectionCylsphere*)</code>
    /// </summary>
    /// <param name="detcyl">The detection cylinder used to locate cells in the environment.</param>
    /// <returns>1 if initialization succeeded; 0 if detection objects or cell array were already set up.</returns>
    public int InitializeGlobalDetection(ACBindings.Internal.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionCylsphere*, int>)0x0051A480)(ref this, detcyl);

    /// <summary>Processes an incoming detection update, updating the internal detection table and adjusting the pending global update count accordingly.
    /// <code>Offset: 0x0051A530
    /// void __thiscall DetectionManager::ReceiveDetectionUpdate(DetectionManager*,const DetectionInfo*)</code>
    /// </summary>
    /// <param name="incoming_info">The detection information containing object ID and status to process.</param>
    public void ReceiveDetectionUpdate(ACBindings.Internal.DetectionInfo* incoming_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionInfo*, void>)0x0051A530)(ref this, incoming_info);

    /// <summary>Updates the internal list of cells monitored by the detection manager when its associated physics object has moved sufficiently, adding and removing the specified detection cylinder from relevant cells.
    /// <code>Offset: 0x0051A620
    /// void __thiscall DetectionManager::UpdateCellList(DetectionManager*,DetectionCylsphere*)</code>
    /// </summary>
    /// <param name="detcyl">The detection cylinder whose visibility associations are refreshed.</param>
    public void UpdateCellList(ACBindings.Internal.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionCylsphere*, void>)0x0051A620)(ref this, detcyl);

    /// <summary>Iterates over the manager's pending global detection objects, dispatches a notification for each active detection to the user interface, and removes any fully processed detections from the table.
    /// <code>Offset: 0x0051A760
    /// void __thiscall DetectionManager::ReportGlobalDetection(DetectionManager*,unsigned int)</code>
    /// </summary>
    /// <param name="context_id">Identifier used when notifying the UI about the detection event.</param>
    public void ReportGlobalDetection(uint context_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, uint, void>)0x0051A760)(ref this, context_id);

    /// <summary>Removes all global detection data associated with the manager and clears cell references to the specified detection cylinder. Releases memory used by detection objects and cell array, resetting counters. Ensures that any visible cells stop tracking the given cylinder.
    /// <code>Offset: 0x0051A830
    /// void __thiscall DetectionManager::CleanupGlobalDetection(DetectionManager*,const DetectionCylsphere*)</code>
    /// </summary>
    /// <param name="detcyl">The detection cylinder whose voyeur relationships should be removed from visible cells before cleanup.</param>
    public void CleanupGlobalDetection(ACBindings.Internal.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionCylsphere*, void>)0x0051A830)(ref this, detcyl);

    /// <summary>Removes all entries queued for deletion from the detection table, deallocates their memory, and clears the pending deletions list.
    /// <code>Offset: 0x0051A8E0
    /// void __thiscall DetectionManager::ClearPendingDeletions(DetectionManager*)</code>
    /// </summary>
    public void ClearPendingDeletions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, void>)0x0051A8E0)(ref this);

    /// <summary>Processes a cylindrical detection region. If an associated physics object is present, it updates the cylinder’s status and notifies the UI when the object enters detection. When the cylinder has no linked object, it refreshes the spatial cell list and broadcasts a global detection report.
    /// <code>Offset: 0x0051A940
    /// void __thiscall DetectionManager::CheckDetection(DetectionManager*,DetectionCylsphere*)</code>
    /// </summary>
    /// <param name="detcyl">The DetectionCylsphere to evaluate.</param>
    public void CheckDetection(ACBindings.Internal.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionCylsphere*, void>)0x0051A940)(ref this, detcyl);

    /// <summary>Releases all resources owned by the detection manager, including pending deletions and global detection entries, flushes its internal hash table, deallocates associated memory, and restores the object to a clean state.
    /// <code>Offset: 0x0051A9D0
    /// void __thiscall DetectionManager::~DetectionManager(DetectionManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, void>)0x0051A9D0)(ref this);

    /// <summary>Marks a cylindrical detection object identified by the supplied context id for removal, queuing it in the manager’s pending deletions list.
    /// <code>Offset: 0x0051AA80
    /// int __thiscall DetectionManager::DestroyDetectionCylsphere(DetectionManager*,unsigned int)</code>
    /// </summary>
    /// <param name="context_id">Identifier of the detection object to be destroyed.</param>
    /// <returns>Non-zero if the object was found and queued for deletion; zero otherwise.</returns>
    public int DestroyDetectionCylsphere(uint context_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, uint, int>)0x0051AA80)(ref this, context_id);

    /// <summary>Checks all registered detection objects once per second, clearing pending deletions beforehand.
    /// <code>Offset: 0x0051AB00
    /// void __thiscall DetectionManager::CheckDetection(DetectionManager*)</code>
    /// </summary>
    public void CheckDetection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, void>)0x0051AB00)(ref this);
}

