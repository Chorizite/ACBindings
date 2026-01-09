namespace ACBindings;

// CObjectMaint
public unsafe struct CObjectMaint : System.IDisposable
{
    // Base Classes
    public ACBindings.Interface BaseClass_Interface; // ACBindings.Interface
    public ACBindings.NoticeHandler BaseClass_NoticeHandler; // ACBindings.NoticeHandler

    // Statics
    public static ACBindings.CObjectMaint* s_pcInstance = (ACBindings.CObjectMaint*)0x00842ADC;

    // Child Types
    // CObjectMaint_vtbl
    public unsafe struct CObjectMaint_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public fixed byte gap1C[4];
        public System.IntPtr CObjectMaint_dtor_20; // function pointer
        public System.IntPtr SetVisualDesc; // function pointer
        public System.IntPtr SetWeenieDesc; // function pointer
        public System.IntPtr CreateObject; // function pointer
        public System.IntPtr SetPlayerVisualDesc; // function pointer
        public System.IntPtr GetPlayerVisualDesc; // function pointer
        public System.IntPtr OnShutdown; // function pointer

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
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public int is_active;
    public ACBindings.IntrusiveHashTable__uint__CLostCell_ptr lost_cell_table;
    public ACBindings.LongHash__CPhysicsObj object_table;
    public ACBindings.LongHash__CPhysicsObj null_object_table;
    public ACBindings.LongHash__CWeenieObject weenie_object_table;
    public ACBindings.LongHash__CWeenieObject null_weenie_object_table;
    public ACBindings.HashSet__uint visible_object_table;
    public ACBindings.HashTable__uint__double destruction_object_table;
    public ACBindings.LongHash__CObjectInventory object_inventory_table;
    public ACBindings.AC1Legacy.PQueueArray__double object_destruction_queue;

    // Generated Constructor
    public CObjectMaint() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // TResult* __thiscall CObjectMaint::QueryInterface(CObjectMaint*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x00508360)(ref this, result, i_rcInterface, o_ppvInterface);
    // void __thiscall CObjectMaint::ReleaseObjCell(CObjectMaint*,CObjCell*)
    public void ReleaseObjCell(ACBindings.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, ACBindings.CObjCell*, void>)0x005086E0)(ref this, cell);
    // void __thiscall CObjectMaint::OnShutdown(CObjectMaint*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, void>)0x005087C0)(ref this);
    // void __thiscall CObjectMaint::AddObject(CObjectMaint*,CPhysicsObj*)
    public void AddObject(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, ACBindings.CPhysicsObj*, void>)0x00508810)(ref this, object_);
    // void __thiscall CObjectMaint::AddWeenieObject(CObjectMaint*,CWeenieObject*)
    public void AddWeenieObject(ACBindings.CWeenieObject* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, ACBindings.CWeenieObject*, void>)0x00508850)(ref this, object_);
    // CPhysicsObj* __thiscall CObjectMaint::GetObjectA(CObjectMaint*,unsigned int)
    public ACBindings.CPhysicsObj* GetObjectA(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, ACBindings.CPhysicsObj*>)0x00508890)(ref this, object_id);
    // CWeenieObject* __thiscall CObjectMaint::GetWeenieObject(CObjectMaint*,unsigned int)
    public ACBindings.CWeenieObject* GetWeenieObject(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, ACBindings.CWeenieObject*>)0x005088E0)(ref this, object_id);
    // CObjectInventory* __thiscall CObjectMaint::GetObjectInventory(CObjectMaint*,unsigned int)
    public ACBindings.CObjectInventory* GetObjectInventory(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, ACBindings.CObjectInventory*>)0x00508930)(ref this, object_id);
    // void __thiscall CObjectMaint::UnRegisterAllNoticeHandlers(CObjectMaint*,NoticeHandler*)
    public void UnRegisterAllNoticeHandlers(ACBindings.NoticeHandler* handler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, ACBindings.NoticeHandler*, void>)0x00508980)(ref this, handler);
    // int __thiscall CObjectMaint::GetObjectA(CObjectMaint*,unsigned int,CPhysicsObj**,CWeenieObject**)
    public int GetObjectA(uint object_id, ACBindings.CPhysicsObj** physobj, ACBindings.CWeenieObject** weenieobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, ACBindings.CPhysicsObj**, ACBindings.CWeenieObject**, int>)0x00508A40)(ref this, object_id, physobj, weenieobj);
    // void __thiscall CObjectMaint::RemoveFromLostCell(CObjectMaint*,CPhysicsObj*)
    public void RemoveFromLostCell(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, ACBindings.CPhysicsObj*, void>)0x00508A80)(ref this, object_);
    // CLostCell* __thiscall CObjectMaint::GetLostCell(CObjectMaint*,unsigned int)
    public ACBindings.CLostCell* GetLostCell(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, ACBindings.CLostCell*>)0x00508C70)(ref this, cell_id);
    // void __thiscall CObjectMaint::GotoLostCell(CObjectMaint*,CPhysicsObj*,unsigned int)
    public void GotoLostCell(ACBindings.CPhysicsObj* object_, uint new_cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, ACBindings.CPhysicsObj*, uint, void>)0x00508CE0)(ref this, object_, new_cell_id);
    // void __thiscall CObjectMaint::InitObjCell(CObjectMaint*,CObjCell*)
    public void InitObjCell(ACBindings.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, ACBindings.CObjCell*, void>)0x00508D30)(ref this, cell);
    // void __thiscall CObjectMaint::UpdateVisibleObjectList(CObjectMaint*)
    public void UpdateVisibleObjectList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, void>)0x00508E60)(ref this);
    // void __thiscall CObjectMaint::RemoveObjectToBeDestroyed(CObjectMaint*,unsigned int)
    public void RemoveObjectToBeDestroyed(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, void>)0x00508F10)(ref this, object_id);
    // void __thiscall CObjectMaint::DeleteObject(CObjectMaint*,CPhysicsObj*)
    public void DeleteObject(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, ACBindings.CPhysicsObj*, void>)0x00508F30)(ref this, object_);
    // int __thiscall CObjectMaint::DeleteObject(CObjectMaint*,unsigned int)
    public int DeleteObject(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, int>)0x00508FA0)(ref this, object_id);
    // void __thiscall CObjectMaint::CObjectMaint(CObjectMaint*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, void>)0x005090A0)(ref this);
    // CPhysicsObj* __thiscall CObjectMaint::CreateObject(CObjectMaint*,unsigned int,VisualDesc*,PhysicsDesc*,WeenieDesc*)
    public ACBindings.CPhysicsObj* CreateObject(uint objectID, ACBindings.VisualDesc* vdesc, ACBindings.PhysicsDesc* physicsdesc, ACBindings.WeenieDesc* wdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, ACBindings.VisualDesc*, ACBindings.PhysicsDesc*, ACBindings.WeenieDesc*, ACBindings.CPhysicsObj*>)0x00509410)(ref this, objectID, vdesc, physicsdesc, wdesc);
    // unsigned int __thiscall CObjectMaint::Release(CObjectMaint*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint>)0x00509450)(ref this);
    // void __thiscall CObjectMaint::UseTime(CObjectMaint*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, void>)0x00509480)(ref this);
    // void __thiscall CObjectMaint::DestroyObjects(CObjectMaint*)
    public void DestroyObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, void>)0x00509700)(ref this);
    // void __thiscall CObjectMaint::AddObjectToBeDestroyed(CObjectMaint*,unsigned int)
    public void AddObjectToBeDestroyed(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, void>)0x00509A40)(ref this, object_id);
    // CPhysicsObj* __thiscall CObjectMaint::GetNullObject(CObjectMaint*,unsigned int,int)
    public ACBindings.CPhysicsObj* GetNullObject(uint object_id, int create_new_object) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, int, ACBindings.CPhysicsObj*>)0x00509AB0)(ref this, object_id, create_new_object);
    // CWeenieObject* __thiscall CObjectMaint::GetNullWeenieObject(CObjectMaint*,unsigned int,int)
    public ACBindings.CWeenieObject* GetNullWeenieObject(uint object_id, int create_new_object) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, int, ACBindings.CWeenieObject*>)0x00509B60)(ref this, object_id, create_new_object);
    // void __thiscall CObjectMaint::~CObjectMaint(CObjectMaint*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, void>)0x00509C10)(ref this);
    // void __thiscall CObjectMaint::QueueBlobForObject(CObjectMaint*,unsigned int,NetBlob*)
    public void QueueBlobForObject(uint object_id, ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, ACBindings.NetBlob*, void>)0x00509DA0)(ref this, object_id, blob);
    // void __thiscall CObjectMaint::QueueBlobForWeenieObject(CObjectMaint*,unsigned int,unsigned int,NetBlob*)
    public void QueueBlobForWeenieObject(uint object_id, uint stamp, ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, uint, ACBindings.NetBlob*, void>)0x00509DE0)(ref this, object_id, stamp, blob);
    // void __thiscall CObjectMaint::QueueBlobForWeenieObject(CObjectMaint*,unsigned int,NetBlob*)
    public void QueueBlobForWeenieObject(uint object_id, ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, uint, ACBindings.NetBlob*, void>)0x00509E10)(ref this, object_id, blob);
    // void __thiscall CObjectMaint::SetChildren(CObjectMaint*,CPhysicsObj*,PhysicsDesc*)
    public void SetChildren(ACBindings.CPhysicsObj* obj, ACBindings.PhysicsDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectMaint, ACBindings.CPhysicsObj*, ACBindings.PhysicsDesc*, void>)0x00509E40)(ref this, obj, desc);
}

