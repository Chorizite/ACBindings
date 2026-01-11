namespace ACBindings.Internal;

public unsafe struct ACCObjectMaint
{
    // Base Classes
    public ACBindings.Internal.CObjectMaint BaseClass_CObjectMaint; // ACBindings.Internal.CObjectMaint

    // Child Types
    public unsafe struct ACCObjectMaint_vtbl
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

    // Members
    public ACBindings.Internal.ObjDesc* player_objdesc;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005582A0
    /// void __thiscall ACCObjectMaint::SetVisualDesc(ACCObjectMaint*,CPhysicsObj*,VisualDesc*)</code>
    /// </summary>
    public void SetVisualDesc(ACBindings.Internal.CPhysicsObj* object_, ACBindings.Internal.VisualDesc* vdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.VisualDesc*, void>)0x005582A0)(ref this, object_, vdesc);

    /// <summary>
    /// <code>Offset: 0x005582C0
    /// void __thiscall ACCObjectMaint::SetPlayerVisualDesc(ACCObjectMaint*,VisualDesc*)</code>
    /// </summary>
    public void SetPlayerVisualDesc(ACBindings.Internal.VisualDesc* new_player_vdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, ACBindings.Internal.VisualDesc*, void>)0x005582C0)(ref this, new_player_vdesc);

    /// <summary>
    /// <code>Offset: 0x00558320
    /// VisualDesc* __thiscall ACCObjectMaint::GetPlayerVisualDesc(ACCObjectMaint*)</code>
    /// </summary>
    public ACBindings.Internal.VisualDesc* GetPlayerVisualDesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, ACBindings.Internal.VisualDesc*>)0x00558320)(ref this);

    /// <summary>
    /// <code>Offset: 0x00558330
    /// int __thiscall ACCObjectMaint::DeleteObject(ACCObjectMaint*,unsigned int)</code>
    /// </summary>
    public int DeleteObject(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, uint, int>)0x00558330)(ref this, object_id);

    /// <summary>
    /// <code>Offset: 0x00558660
    /// void __thiscall ACCObjectMaint::SetWeenieDesc(ACCObjectMaint*,CWeenieObject*,WeenieDesc*,int)</code>
    /// </summary>
    public void SetWeenieDesc(ACBindings.Internal.CWeenieObject* wobj, ACBindings.Internal.WeenieDesc* wdesc, int recreated) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.WeenieDesc*, int, void>)0x00558660)(ref this, wobj, wdesc, recreated);

    /// <summary>
    /// <code>Offset: 0x005594B0
    /// CPhysicsObj* __thiscall ACCObjectMaint::CreateObject(ACCObjectMaint*,unsigned int,VisualDesc*,PhysicsDesc*,WeenieDesc*)</code>
    /// </summary>
    public ACBindings.Internal.CPhysicsObj* CreateObject(uint objectID, ACBindings.Internal.VisualDesc* vdesc, ACBindings.Internal.PhysicsDesc* physicsdesc, ACBindings.Internal.WeenieDesc* wdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, uint, ACBindings.Internal.VisualDesc*, ACBindings.Internal.PhysicsDesc*, ACBindings.Internal.WeenieDesc*, ACBindings.Internal.CPhysicsObj*>)0x005594B0)(ref this, objectID, vdesc, physicsdesc, wdesc);

    /// <summary>
    /// <code>Offset: 0x005596B0
    /// void __thiscall ACCObjectMaint::ViewObjectContents(CObjectMaint*,unsigned int,int)</code>
    /// </summary>
    public void ViewObjectContents(uint object_id, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, uint, int, void>)0x005596B0)(ref this, object_id, a3);

    /// <summary>
    /// <code>Offset: 0x00559770
    /// void __thiscall ACCObjectMaint::StopViewingObjectContents(ACCObjectMaint*,unsigned int)</code>
    /// </summary>
    public void StopViewingObjectContents(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, uint, void>)0x00559770)(ref this, object_id);

    /// <summary>
    /// <code>Offset: 0x0055A190
    /// _DWORD* __thiscall ACCObjectMaint::UpdateObjectInventory(CObjectMaint*,unsigned int,int)</code>
    /// </summary>
    public int* UpdateObjectInventory(uint object_id, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, uint, int, int*>)0x0055A190)(ref this, object_id, a3);
}

