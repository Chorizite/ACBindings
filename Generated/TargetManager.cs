namespace ACBindings;

// TargetManager
public unsafe struct TargetManager : System.IDisposable
{
    // Members
    public ACBindings.CPhysicsObj* physobj;
    public ACBindings.TargetInfo* target_info;
    public System.IntPtr voyeur_table;
    public double last_update_time;

    // Generated Constructor
    public TargetManager(ACBindings.CPhysicsObj* object_) {
        _ConstructorInternal(object_);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall TargetManager::TargetManager(TargetManager*,CPhysicsObj*)
    public void _ConstructorInternal(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetManager, ACBindings.CPhysicsObj*, void>)0x0051AF50)(ref this, object_);
    // void __thiscall TargetManager::SetTargetQuantum(TargetManager*,long double)
    public void SetTargetQuantum(double new_quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetManager, double, void>)0x0051B040)(ref this, new_quantum);
    // void __thiscall TargetManager::SendVoyeurUpdate(TargetManager*,TargettedVoyeurInfo*,const Position*,TargetStatus)
    public void SendVoyeurUpdate(ACBindings.TargettedVoyeurInfo* voyeur, ACBindings.Position* p, ACBindings.TargetStatus status) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetManager, ACBindings.TargettedVoyeurInfo*, ACBindings.Position*, ACBindings.TargetStatus, void>)0x0051B090)(ref this, voyeur, p, status);
    // void __thiscall TargetManager::GetInterpolatedPosition(TargetManager*,long double,Position*)
    public void GetInterpolatedPosition(double quantum, ACBindings.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetManager, double, ACBindings.Position*, void>)0x0051B180)(ref this, quantum, p);
    // void __thiscall TargetManager::CheckAndUpdateVoyeur(TargetManager*,TargettedVoyeurInfo*)
    public void CheckAndUpdateVoyeur(ACBindings.TargettedVoyeurInfo* voyeur) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetManager, ACBindings.TargettedVoyeurInfo*, void>)0x0051B1F0)(ref this, voyeur);
    // void __thiscall TargetManager::NotifyVoyeurOfEvent(TargetManager*,TargetStatus)
    public void NotifyVoyeurOfEvent(ACBindings.TargetStatus event_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetManager, ACBindings.TargetStatus, void>)0x0051B290)(ref this, event_);
    // void __thiscall TargetManager::ClearTarget(TargetManager*)
    public void ClearTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetManager, void>)0x0051B310)(ref this);
    // void __thiscall TargetManager::AddVoyeur(TargetManager*,unsigned int,float,long double)
    public void AddVoyeur(uint object_id, float radius, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetManager, uint, float, double, void>)0x0051B360)(ref this, object_id, radius, quantum);
    // void __thiscall TargetManager::ReceiveUpdate(TargetManager*,const TargetInfo*)
    public void ReceiveUpdate(ACBindings.TargetInfo* target_update) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetManager, ACBindings.TargetInfo*, void>)0x0051B460)(ref this, target_update);
    // void __thiscall TargetManager::HandleTargetting(TargetManager*)
    public void HandleTargetting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetManager, void>)0x0051B5C0)(ref this);
    // void __thiscall TargetManager::~TargetManager(TargetManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetManager, void>)0x0051B700)(ref this);
    // void __thiscall TargetManager::SetTarget(TargetManager*,unsigned int,unsigned int,float,long double)
    public void SetTarget(uint context_id, uint object_id, float radius, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetManager, uint, uint, float, double, void>)0x0051B760)(ref this, context_id, object_id, radius, quantum);
}

