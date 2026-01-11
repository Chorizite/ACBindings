namespace ACBindings.Internal;

public unsafe struct CPhysics : System.IDisposable
{
    // Members
    public ACBindings.Internal.CObjectMaint* obj_maint;
    public ACBindings.Internal.SmartBox* smartbox;
    public ACBindings.Internal.CPhysicsObj* player;
    public System.IntPtr iter;

    // Generated Constructor
    public CPhysics(ACBindings.Internal.CObjectMaint* obj_maint, ACBindings.Internal.SmartBox* smartbox) {
        _ConstructorInternal(obj_maint, smartbox);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0050A160
    /// int __thiscall CPhysics::SetObjectMovement(CPhysics*,CPhysicsObj*,void*,unsigned int,unsigned __int16,unsigned __int16,int)</code>
    /// </summary>
    public int SetObjectMovement(ACBindings.Internal.CPhysicsObj* object_, System.IntPtr buff, uint size, ushort movement_timestamp, ushort server_control_timestamp, int autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysics, ACBindings.Internal.CPhysicsObj*, System.IntPtr, uint, ushort, ushort, int, int>)0x0050A160)(ref this, object_, buff, size, movement_timestamp, server_control_timestamp, autonomous);

    /// <summary>
    /// <code>Offset: 0x0050A230
    /// void __cdecl CPhysics::RemoveStaticAnimatingObject(CPhysicsObj*)</code>
    /// </summary>
    public static void RemoveStaticAnimatingObject(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, void>)0x0050A230)(object_);

    /// <summary>
    /// <code>Offset: 0x0050A260
    /// int __thiscall CPhysics::SetObjectMovement(CPhysics*,CPhysicsObj*,void*,unsigned int)</code>
    /// </summary>
    public int SetObjectMovement(ACBindings.Internal.CPhysicsObj* object_, System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysics, ACBindings.Internal.CPhysicsObj*, System.IntPtr, uint, int>)0x0050A260)(ref this, object_, buff, size);

    /// <summary>
    /// <code>Offset: 0x0050A2F0
    /// void __cdecl CPhysics::UpdateTexVelocity(float)</code>
    /// </summary>
    public static void UpdateTexVelocity(float time_delta) => ((delegate* unmanaged[Cdecl]<float, void>)0x0050A2F0)(time_delta);

    /// <summary>
    /// <code>Offset: 0x0050A3E0
    /// void __thiscall CPhysics::~CPhysics(CPhysics*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysics, void>)0x0050A3E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050A420
    /// void __thiscall CPhysics::UseTime(CPhysics*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysics, void>)0x0050A420)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050A530
    /// void __thiscall CPhysics::CPhysics(CPhysics*,CObjectMaint*,SmartBox*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CObjectMaint* obj_maint, ACBindings.Internal.SmartBox* smartbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysics, ACBindings.Internal.CObjectMaint*, ACBindings.Internal.SmartBox*, void>)0x0050A530)(ref this, obj_maint, smartbox);

    /// <summary>
    /// <code>Offset: 0x0050A5C0
    /// void __cdecl CPhysics::AddStaticAnimatingObject(CPhysicsObj*)</code>
    /// </summary>
    public static void AddStaticAnimatingObject(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, void>)0x0050A5C0)(object_);

    /// <summary>
    /// <code>Offset: 0x0050A630
    /// void __cdecl CPhysics::AddGfxVelocity(int,float,float)</code>
    /// </summary>
    public static void AddGfxVelocity(int a1, float a2, float a3) => ((delegate* unmanaged[Cdecl]<int, float, float, void>)0x0050A630)(a1, a2, a3);
}

