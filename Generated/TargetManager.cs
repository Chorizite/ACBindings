namespace ACBindings.Internal;

public unsafe struct TargetManager : System.IDisposable
{
    // Members
    public ACBindings.Internal.CPhysicsObj* physobj;
    public ACBindings.Internal.TargetInfo* target_info;
    public System.IntPtr voyeur_table;
    public double last_update_time;

    // Generated Constructor
    public TargetManager(ACBindings.Internal.CPhysicsObj* object_) {
        _ConstructorInternal(object_);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0051AF50
    /// void __thiscall TargetManager::TargetManager(TargetManager*,CPhysicsObj*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, ACBindings.Internal.CPhysicsObj*, void>)0x0051AF50)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x0051B040
    /// void __thiscall TargetManager::SetTargetQuantum(TargetManager*,long double)</code>
    /// </summary>
    public void SetTargetQuantum(double new_quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, double, void>)0x0051B040)(ref this, new_quantum);

    /// <summary>
    /// <code>Offset: 0x0051B090
    /// void __thiscall TargetManager::SendVoyeurUpdate(TargetManager*,TargettedVoyeurInfo*,const Position*,TargetStatus)</code>
    /// </summary>
    public void SendVoyeurUpdate(ACBindings.Internal.TargettedVoyeurInfo* voyeur, ACBindings.Internal.Position* p, ACBindings.Internal.TargetStatus status) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, ACBindings.Internal.TargettedVoyeurInfo*, ACBindings.Internal.Position*, ACBindings.Internal.TargetStatus, void>)0x0051B090)(ref this, voyeur, p, status);

    /// <summary>
    /// <code>Offset: 0x0051B180
    /// void __thiscall TargetManager::GetInterpolatedPosition(TargetManager*,long double,Position*)</code>
    /// </summary>
    public void GetInterpolatedPosition(double quantum, ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, double, ACBindings.Internal.Position*, void>)0x0051B180)(ref this, quantum, p);

    /// <summary>
    /// <code>Offset: 0x0051B1F0
    /// void __thiscall TargetManager::CheckAndUpdateVoyeur(TargetManager*,TargettedVoyeurInfo*)</code>
    /// </summary>
    public void CheckAndUpdateVoyeur(ACBindings.Internal.TargettedVoyeurInfo* voyeur) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, ACBindings.Internal.TargettedVoyeurInfo*, void>)0x0051B1F0)(ref this, voyeur);

    /// <summary>
    /// <code>Offset: 0x0051B290
    /// void __thiscall TargetManager::NotifyVoyeurOfEvent(TargetManager*,TargetStatus)</code>
    /// </summary>
    public void NotifyVoyeurOfEvent(ACBindings.Internal.TargetStatus event_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, ACBindings.Internal.TargetStatus, void>)0x0051B290)(ref this, event_);

    /// <summary>
    /// <code>Offset: 0x0051B310
    /// void __thiscall TargetManager::ClearTarget(TargetManager*)</code>
    /// </summary>
    public void ClearTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, void>)0x0051B310)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051B360
    /// void __thiscall TargetManager::AddVoyeur(TargetManager*,unsigned int,float,long double)</code>
    /// </summary>
    public void AddVoyeur(uint object_id, float radius, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, uint, float, double, void>)0x0051B360)(ref this, object_id, radius, quantum);

    /// <summary>
    /// <code>Offset: 0x0051B460
    /// void __thiscall TargetManager::ReceiveUpdate(TargetManager*,const TargetInfo*)</code>
    /// </summary>
    public void ReceiveUpdate(ACBindings.Internal.TargetInfo* target_update) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, ACBindings.Internal.TargetInfo*, void>)0x0051B460)(ref this, target_update);

    /// <summary>
    /// <code>Offset: 0x0051B5C0
    /// void __thiscall TargetManager::HandleTargetting(TargetManager*)</code>
    /// </summary>
    public void HandleTargetting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, void>)0x0051B5C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051B700
    /// void __thiscall TargetManager::~TargetManager(TargetManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, void>)0x0051B700)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051B760
    /// void __thiscall TargetManager::SetTarget(TargetManager*,unsigned int,unsigned int,float,long double)</code>
    /// </summary>
    public void SetTarget(uint context_id, uint object_id, float radius, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, uint, uint, float, double, void>)0x0051B760)(ref this, context_id, object_id, radius, quantum);
}

