namespace ACBindings.Internal;

public unsafe struct CObjectMaint : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface
    public ACBindings.Internal.NoticeHandler BaseClass_NoticeHandler; // ACBindings.Internal.NoticeHandler

    // Statics
    public static ACBindings.Internal.CObjectMaint* s_pcInstance = (ACBindings.Internal.CObjectMaint*)0x00842ADC;

    // Child Types
    public unsafe struct CObjectMaint_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.CObjectMaint.Enum5> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public fixed byte gap1C[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, void> CObjectMaint_dtor_20; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.VisualDesc*, void> SetVisualDesc; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.WeenieDesc*, int, void> SetWeenieDesc; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, uint, ACBindings.Internal.VisualDesc*, ACBindings.Internal.PhysicsDesc*, ACBindings.Internal.WeenieDesc*, ACBindings.Internal.CPhysicsObj*> CreateObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.VisualDesc*, void> SetPlayerVisualDesc; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.VisualDesc*> GetPlayerVisualDesc; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, void> OnShutdown; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00508360
    /// TResult* __thiscall CObjectMaint::QueryInterface(CObjectMaint*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00508360)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>
    /// <code>Offset: 0x005086E0
    /// void __thiscall CObjectMaint::ReleaseObjCell(CObjectMaint*,CObjCell*)</code>
    /// </summary>
    public void ReleaseObjCell(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CObjCell*, void>)0x005086E0)(ref this, cell);

    /// <summary>
    /// <code>Offset: 0x005087C0
    /// void __thiscall CObjectMaint::OnShutdown(CObjectMaint*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, void>)0x005087C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00508810
    /// void __thiscall CObjectMaint::AddObject(CObjectMaint*,CPhysicsObj*)</code>
    /// </summary>
    public void AddObject(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CPhysicsObj*, void>)0x00508810)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x00508850
    /// void __thiscall CObjectMaint::AddWeenieObject(CObjectMaint*,CWeenieObject*)</code>
    /// </summary>
    public void AddWeenieObject(ACBindings.Internal.CWeenieObject* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CWeenieObject*, void>)0x00508850)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x00508890
    /// CPhysicsObj* __thiscall CObjectMaint::GetObjectA(CObjectMaint*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CPhysicsObj* GetObjectA(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.CPhysicsObj*>)0x00508890)(ref this, object_id);

    /// <summary>
    /// <code>Offset: 0x005088E0
    /// CWeenieObject* __thiscall CObjectMaint::GetWeenieObject(CObjectMaint*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CWeenieObject* GetWeenieObject(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.CWeenieObject*>)0x005088E0)(ref this, object_id);

    /// <summary>
    /// <code>Offset: 0x00508930
    /// CObjectInventory* __thiscall CObjectMaint::GetObjectInventory(CObjectMaint*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CObjectInventory* GetObjectInventory(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.CObjectInventory*>)0x00508930)(ref this, object_id);

    /// <summary>
    /// <code>Offset: 0x00508980
    /// void __thiscall CObjectMaint::UnRegisterAllNoticeHandlers(CObjectMaint*,NoticeHandler*)</code>
    /// </summary>
    public void UnRegisterAllNoticeHandlers(ACBindings.Internal.NoticeHandler* handler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.NoticeHandler*, void>)0x00508980)(ref this, handler);

    /// <summary>
    /// <code>Offset: 0x00508A40
    /// int __thiscall CObjectMaint::GetObjectA(CObjectMaint*,unsigned int,CPhysicsObj**,CWeenieObject**)</code>
    /// </summary>
    public int GetObjectA(uint object_id, ACBindings.Internal.CPhysicsObj** physobj, ACBindings.Internal.CWeenieObject** weenieobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.CPhysicsObj**, ACBindings.Internal.CWeenieObject**, int>)0x00508A40)(ref this, object_id, physobj, weenieobj);

    /// <summary>
    /// <code>Offset: 0x00508A80
    /// void __thiscall CObjectMaint::RemoveFromLostCell(CObjectMaint*,CPhysicsObj*)</code>
    /// </summary>
    public void RemoveFromLostCell(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CPhysicsObj*, void>)0x00508A80)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x00508C70
    /// CLostCell* __thiscall CObjectMaint::GetLostCell(CObjectMaint*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CLostCell* GetLostCell(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.CLostCell*>)0x00508C70)(ref this, cell_id);

    /// <summary>
    /// <code>Offset: 0x00508CE0
    /// void __thiscall CObjectMaint::GotoLostCell(CObjectMaint*,CPhysicsObj*,unsigned int)</code>
    /// </summary>
    public void GotoLostCell(ACBindings.Internal.CPhysicsObj* object_, uint new_cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CPhysicsObj*, uint, void>)0x00508CE0)(ref this, object_, new_cell_id);

    /// <summary>
    /// <code>Offset: 0x00508D30
    /// void __thiscall CObjectMaint::InitObjCell(CObjectMaint*,CObjCell*)</code>
    /// </summary>
    public void InitObjCell(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CObjCell*, void>)0x00508D30)(ref this, cell);

    /// <summary>
    /// <code>Offset: 0x00508E60
    /// void __thiscall CObjectMaint::UpdateVisibleObjectList(CObjectMaint*)</code>
    /// </summary>
    public void UpdateVisibleObjectList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, void>)0x00508E60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00508F10
    /// void __thiscall CObjectMaint::RemoveObjectToBeDestroyed(CObjectMaint*,unsigned int)</code>
    /// </summary>
    public void RemoveObjectToBeDestroyed(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, void>)0x00508F10)(ref this, object_id);

    /// <summary>
    /// <code>Offset: 0x00508F30
    /// void __thiscall CObjectMaint::DeleteObject(CObjectMaint*,CPhysicsObj*)</code>
    /// </summary>
    public void DeleteObject(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CPhysicsObj*, void>)0x00508F30)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x00508FA0
    /// int __thiscall CObjectMaint::DeleteObject(CObjectMaint*,unsigned int)</code>
    /// </summary>
    public int DeleteObject(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, int>)0x00508FA0)(ref this, object_id);

    /// <summary>
    /// <code>Offset: 0x005090A0
    /// void __thiscall CObjectMaint::CObjectMaint(CObjectMaint*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, void>)0x005090A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00509410
    /// CPhysicsObj* __thiscall CObjectMaint::CreateObject(CObjectMaint*,unsigned int,VisualDesc*,PhysicsDesc*,WeenieDesc*)</code>
    /// </summary>
    public ACBindings.Internal.CPhysicsObj* CreateObject(uint objectID, ACBindings.Internal.VisualDesc* vdesc, ACBindings.Internal.PhysicsDesc* physicsdesc, ACBindings.Internal.WeenieDesc* wdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.VisualDesc*, ACBindings.Internal.PhysicsDesc*, ACBindings.Internal.WeenieDesc*, ACBindings.Internal.CPhysicsObj*>)0x00509410)(ref this, objectID, vdesc, physicsdesc, wdesc);

    /// <summary>
    /// <code>Offset: 0x00509450
    /// unsigned int __thiscall CObjectMaint::Release(CObjectMaint*)</code>
    /// </summary>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint>)0x00509450)(ref this);

    /// <summary>
    /// <code>Offset: 0x00509480
    /// void __thiscall CObjectMaint::UseTime(CObjectMaint*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, void>)0x00509480)(ref this);

    /// <summary>
    /// <code>Offset: 0x00509700
    /// void __thiscall CObjectMaint::DestroyObjects(CObjectMaint*)</code>
    /// </summary>
    public void DestroyObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, void>)0x00509700)(ref this);

    /// <summary>
    /// <code>Offset: 0x00509A40
    /// void __thiscall CObjectMaint::AddObjectToBeDestroyed(CObjectMaint*,unsigned int)</code>
    /// </summary>
    public void AddObjectToBeDestroyed(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, void>)0x00509A40)(ref this, object_id);

    /// <summary>
    /// <code>Offset: 0x00509AB0
    /// CPhysicsObj* __thiscall CObjectMaint::GetNullObject(CObjectMaint*,unsigned int,int)</code>
    /// </summary>
    public ACBindings.Internal.CPhysicsObj* GetNullObject(uint object_id, int create_new_object) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, int, ACBindings.Internal.CPhysicsObj*>)0x00509AB0)(ref this, object_id, create_new_object);

    /// <summary>
    /// <code>Offset: 0x00509B60
    /// CWeenieObject* __thiscall CObjectMaint::GetNullWeenieObject(CObjectMaint*,unsigned int,int)</code>
    /// </summary>
    public ACBindings.Internal.CWeenieObject* GetNullWeenieObject(uint object_id, int create_new_object) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, int, ACBindings.Internal.CWeenieObject*>)0x00509B60)(ref this, object_id, create_new_object);

    /// <summary>
    /// <code>Offset: 0x00509C10
    /// void __thiscall CObjectMaint::~CObjectMaint(CObjectMaint*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, void>)0x00509C10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00509DA0
    /// void __thiscall CObjectMaint::QueueBlobForObject(CObjectMaint*,unsigned int,NetBlob*)</code>
    /// </summary>
    public void QueueBlobForObject(uint object_id, ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.NetBlob*, void>)0x00509DA0)(ref this, object_id, blob);

    /// <summary>
    /// <code>Offset: 0x00509DE0
    /// void __thiscall CObjectMaint::QueueBlobForWeenieObject(CObjectMaint*,unsigned int,unsigned int,NetBlob*)</code>
    /// </summary>
    public void QueueBlobForWeenieObject(uint object_id, uint stamp, ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, uint, ACBindings.Internal.NetBlob*, void>)0x00509DE0)(ref this, object_id, stamp, blob);

    /// <summary>
    /// <code>Offset: 0x00509E10
    /// void __thiscall CObjectMaint::QueueBlobForWeenieObject(CObjectMaint*,unsigned int,NetBlob*)</code>
    /// </summary>
    public void QueueBlobForWeenieObject(uint object_id, ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, uint, ACBindings.Internal.NetBlob*, void>)0x00509E10)(ref this, object_id, blob);

    /// <summary>
    /// <code>Offset: 0x00509E40
    /// void __thiscall CObjectMaint::SetChildren(CObjectMaint*,CPhysicsObj*,PhysicsDesc*)</code>
    /// </summary>
    public void SetChildren(ACBindings.Internal.CPhysicsObj* obj, ACBindings.Internal.PhysicsDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectMaint, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.PhysicsDesc*, void>)0x00509E40)(ref this, obj, desc);
}

