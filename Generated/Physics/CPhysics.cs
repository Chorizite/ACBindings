namespace ACBindings;

// CPhysics
public unsafe struct CPhysics : System.IDisposable
{
    // Statics
    public static ACBindings.AC1Legacy.SmartArray__CPhysicsObj_ptr* static_animating_objects = (ACBindings.AC1Legacy.SmartArray__CPhysicsObj_ptr*)0x00842C50;

    // Members
    public ACBindings.CObjectMaint* obj_maint;
    public ACBindings.SmartBox* smartbox;
    public ACBindings.CPhysicsObj* player;
    public System.IntPtr iter;

    // Generated Constructor
    public CPhysics(ACBindings.CObjectMaint* obj_maint, ACBindings.SmartBox* smartbox) {
        _ConstructorInternal(obj_maint, smartbox);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall CPhysics::SetObjectMovement(CPhysics*,CPhysicsObj*,void*,unsigned int,unsigned __int16,unsigned __int16,int)
    public int SetObjectMovement(ACBindings.CPhysicsObj* object_, System.IntPtr buff, uint size, ushort movement_timestamp, ushort server_control_timestamp, int autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysics, ACBindings.CPhysicsObj*, System.IntPtr, uint, ushort, ushort, int, int>)0x0050A160)(ref this, object_, buff, size, movement_timestamp, server_control_timestamp, autonomous);
    // void __cdecl CPhysics::RemoveStaticAnimatingObject(CPhysicsObj*)
    public static void RemoveStaticAnimatingObject(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, void>)0x0050A230)(object_);
    // int __thiscall CPhysics::SetObjectMovement(CPhysics*,CPhysicsObj*,void*,unsigned int)
    public int SetObjectMovement(ACBindings.CPhysicsObj* object_, System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysics, ACBindings.CPhysicsObj*, System.IntPtr, uint, int>)0x0050A260)(ref this, object_, buff, size);
    // void __cdecl CPhysics::UpdateTexVelocity(float)
    public static void UpdateTexVelocity(float time_delta) => ((delegate* unmanaged[Cdecl]<float, void>)0x0050A2F0)(time_delta);
    // void __thiscall CPhysics::~CPhysics(CPhysics*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysics, void>)0x0050A3E0)(ref this);
    // void __thiscall CPhysics::UseTime(CPhysics*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysics, void>)0x0050A420)(ref this);
    // void __thiscall CPhysics::CPhysics(CPhysics*,CObjectMaint*,SmartBox*)
    public void _ConstructorInternal(ACBindings.CObjectMaint* obj_maint, ACBindings.SmartBox* smartbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysics, ACBindings.CObjectMaint*, ACBindings.SmartBox*, void>)0x0050A530)(ref this, obj_maint, smartbox);
    // void __cdecl CPhysics::AddStaticAnimatingObject(CPhysicsObj*)
    public static void AddStaticAnimatingObject(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, void>)0x0050A5C0)(object_);
    // void __cdecl CPhysics::AddGfxVelocity(int,float,float)
    public static void AddGfxVelocity(int a1, float a2, float a3) => ((delegate* unmanaged[Cdecl]<int, float, float, void>)0x0050A630)(a1, a2, a3);
}

