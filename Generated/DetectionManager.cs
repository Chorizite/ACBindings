namespace ACBindings;

// DetectionManager
public unsafe struct DetectionManager : System.IDisposable
{
    // Members
    public ACBindings.CPhysicsObj* physobj;
    public System.IntPtr detection_objects;
    public uint num_pending_global_detect_updates;
    public ACBindings.CELLARRAY* cell_array;
    public double last_update_time;
    public ACBindings.Position last_global_update;
    public ACBindings.LongNIHash__DetectionCylsphere detection_table;
    public ACBindings.AC1Legacy.SmartArray__uint pending_deletions;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // DetectionType __thiscall DetectionManager::CheckDetection(DetectionManager*,DetectionCylsphere*,CPhysicsObj*)
    public ACBindings.DetectionType CheckDetection(ACBindings.DetectionCylsphere* detcyl, ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DetectionManager, ACBindings.DetectionCylsphere*, ACBindings.CPhysicsObj*, ACBindings.DetectionType>)0x0051A200)(ref this, detcyl, object_);
    // void __thiscall DetectionManager::FindCellList(DetectionManager*,DetectionCylsphere*,CELLARRAY*)
    public void FindCellList(ACBindings.DetectionCylsphere* detcyl, ACBindings.CELLARRAY* new_cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DetectionManager, ACBindings.DetectionCylsphere*, ACBindings.CELLARRAY*, void>)0x0051A3C0)(ref this, detcyl, new_cell_array);
    // int __thiscall DetectionManager::InitializeGlobalDetection(DetectionManager*,DetectionCylsphere*)
    public int InitializeGlobalDetection(ACBindings.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DetectionManager, ACBindings.DetectionCylsphere*, int>)0x0051A480)(ref this, detcyl);
    // void __thiscall DetectionManager::ReceiveDetectionUpdate(DetectionManager*,const DetectionInfo*)
    public void ReceiveDetectionUpdate(ACBindings.DetectionInfo* incoming_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DetectionManager, ACBindings.DetectionInfo*, void>)0x0051A530)(ref this, incoming_info);
    // void __thiscall DetectionManager::UpdateCellList(DetectionManager*,DetectionCylsphere*)
    public void UpdateCellList(ACBindings.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DetectionManager, ACBindings.DetectionCylsphere*, void>)0x0051A620)(ref this, detcyl);
    // void __thiscall DetectionManager::ReportGlobalDetection(DetectionManager*,unsigned int)
    public void ReportGlobalDetection(uint context_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DetectionManager, uint, void>)0x0051A760)(ref this, context_id);
    // void __thiscall DetectionManager::CleanupGlobalDetection(DetectionManager*,const DetectionCylsphere*)
    public void CleanupGlobalDetection(ACBindings.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DetectionManager, ACBindings.DetectionCylsphere*, void>)0x0051A830)(ref this, detcyl);
    // void __thiscall DetectionManager::ClearPendingDeletions(DetectionManager*)
    public void ClearPendingDeletions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DetectionManager, void>)0x0051A8E0)(ref this);
    // void __thiscall DetectionManager::CheckDetection(DetectionManager*,DetectionCylsphere*)
    public void CheckDetection(ACBindings.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DetectionManager, ACBindings.DetectionCylsphere*, void>)0x0051A940)(ref this, detcyl);
    // void __thiscall DetectionManager::~DetectionManager(DetectionManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DetectionManager, void>)0x0051A9D0)(ref this);
    // int __thiscall DetectionManager::DestroyDetectionCylsphere(DetectionManager*,unsigned int)
    public int DestroyDetectionCylsphere(uint context_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DetectionManager, uint, int>)0x0051AA80)(ref this, context_id);
    // void __thiscall DetectionManager::CheckDetection(DetectionManager*)
    public void CheckDetection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DetectionManager, void>)0x0051AB00)(ref this);
}

