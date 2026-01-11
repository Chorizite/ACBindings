namespace ACBindings.Internal;

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
    /// <code>Offset: 0x0051A200
    /// DetectionType __thiscall DetectionManager::CheckDetection(DetectionManager*,DetectionCylsphere*,CPhysicsObj*)</code>
    /// </summary>
    public ACBindings.Internal.DetectionType CheckDetection(ACBindings.Internal.DetectionCylsphere* detcyl, ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionCylsphere*, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.DetectionType>)0x0051A200)(ref this, detcyl, object_);

    /// <summary>
    /// <code>Offset: 0x0051A3C0
    /// void __thiscall DetectionManager::FindCellList(DetectionManager*,DetectionCylsphere*,CELLARRAY*)</code>
    /// </summary>
    public void FindCellList(ACBindings.Internal.DetectionCylsphere* detcyl, ACBindings.Internal.CELLARRAY* new_cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionCylsphere*, ACBindings.Internal.CELLARRAY*, void>)0x0051A3C0)(ref this, detcyl, new_cell_array);

    /// <summary>
    /// <code>Offset: 0x0051A480
    /// int __thiscall DetectionManager::InitializeGlobalDetection(DetectionManager*,DetectionCylsphere*)</code>
    /// </summary>
    public int InitializeGlobalDetection(ACBindings.Internal.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionCylsphere*, int>)0x0051A480)(ref this, detcyl);

    /// <summary>
    /// <code>Offset: 0x0051A530
    /// void __thiscall DetectionManager::ReceiveDetectionUpdate(DetectionManager*,const DetectionInfo*)</code>
    /// </summary>
    public void ReceiveDetectionUpdate(ACBindings.Internal.DetectionInfo* incoming_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionInfo*, void>)0x0051A530)(ref this, incoming_info);

    /// <summary>
    /// <code>Offset: 0x0051A620
    /// void __thiscall DetectionManager::UpdateCellList(DetectionManager*,DetectionCylsphere*)</code>
    /// </summary>
    public void UpdateCellList(ACBindings.Internal.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionCylsphere*, void>)0x0051A620)(ref this, detcyl);

    /// <summary>
    /// <code>Offset: 0x0051A760
    /// void __thiscall DetectionManager::ReportGlobalDetection(DetectionManager*,unsigned int)</code>
    /// </summary>
    public void ReportGlobalDetection(uint context_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, uint, void>)0x0051A760)(ref this, context_id);

    /// <summary>
    /// <code>Offset: 0x0051A830
    /// void __thiscall DetectionManager::CleanupGlobalDetection(DetectionManager*,const DetectionCylsphere*)</code>
    /// </summary>
    public void CleanupGlobalDetection(ACBindings.Internal.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionCylsphere*, void>)0x0051A830)(ref this, detcyl);

    /// <summary>
    /// <code>Offset: 0x0051A8E0
    /// void __thiscall DetectionManager::ClearPendingDeletions(DetectionManager*)</code>
    /// </summary>
    public void ClearPendingDeletions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, void>)0x0051A8E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051A940
    /// void __thiscall DetectionManager::CheckDetection(DetectionManager*,DetectionCylsphere*)</code>
    /// </summary>
    public void CheckDetection(ACBindings.Internal.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, ACBindings.Internal.DetectionCylsphere*, void>)0x0051A940)(ref this, detcyl);

    /// <summary>
    /// <code>Offset: 0x0051A9D0
    /// void __thiscall DetectionManager::~DetectionManager(DetectionManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, void>)0x0051A9D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051AA80
    /// int __thiscall DetectionManager::DestroyDetectionCylsphere(DetectionManager*,unsigned int)</code>
    /// </summary>
    public int DestroyDetectionCylsphere(uint context_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, uint, int>)0x0051AA80)(ref this, context_id);

    /// <summary>
    /// <code>Offset: 0x0051AB00
    /// void __thiscall DetectionManager::CheckDetection(DetectionManager*)</code>
    /// </summary>
    public void CheckDetection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DetectionManager, void>)0x0051AB00)(ref this);
}

