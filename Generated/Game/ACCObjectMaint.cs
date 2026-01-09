namespace ACBindings;

// ACCObjectMaint
public unsafe struct ACCObjectMaint
{
    // Base Classes
    public ACBindings.CObjectMaint BaseClass_CObjectMaint; // ACBindings.CObjectMaint

    // Child Types
    // ACCObjectMaint_vtbl
    public unsafe struct ACCObjectMaint_vtbl
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

    // Members
    public ACBindings.ObjDesc* player_objdesc;

    // Methods
    // void __thiscall ACCObjectMaint::SetVisualDesc(ACCObjectMaint*,CPhysicsObj*,VisualDesc*)
    public void SetVisualDesc(ACBindings.CPhysicsObj* object_, ACBindings.VisualDesc* vdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCObjectMaint, ACBindings.CPhysicsObj*, ACBindings.VisualDesc*, void>)0x005582A0)(ref this, object_, vdesc);
    // void __thiscall ACCObjectMaint::SetPlayerVisualDesc(ACCObjectMaint*,VisualDesc*)
    public void SetPlayerVisualDesc(ACBindings.VisualDesc* new_player_vdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCObjectMaint, ACBindings.VisualDesc*, void>)0x005582C0)(ref this, new_player_vdesc);
    // VisualDesc* __thiscall ACCObjectMaint::GetPlayerVisualDesc(ACCObjectMaint*)
    public ACBindings.VisualDesc* GetPlayerVisualDesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCObjectMaint, ACBindings.VisualDesc*>)0x00558320)(ref this);
    // int __thiscall ACCObjectMaint::DeleteObject(ACCObjectMaint*,unsigned int)
    public int DeleteObject(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCObjectMaint, uint, int>)0x00558330)(ref this, object_id);
    // void __thiscall ACCObjectMaint::SetWeenieDesc(ACCObjectMaint*,CWeenieObject*,WeenieDesc*,int)
    public void SetWeenieDesc(ACBindings.CWeenieObject* wobj, ACBindings.WeenieDesc* wdesc, int recreated) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCObjectMaint, ACBindings.CWeenieObject*, ACBindings.WeenieDesc*, int, void>)0x00558660)(ref this, wobj, wdesc, recreated);
    // CPhysicsObj* __thiscall ACCObjectMaint::CreateObject(ACCObjectMaint*,unsigned int,VisualDesc*,PhysicsDesc*,WeenieDesc*)
    public ACBindings.CPhysicsObj* CreateObject(uint objectID, ACBindings.VisualDesc* vdesc, ACBindings.PhysicsDesc* physicsdesc, ACBindings.WeenieDesc* wdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCObjectMaint, uint, ACBindings.VisualDesc*, ACBindings.PhysicsDesc*, ACBindings.WeenieDesc*, ACBindings.CPhysicsObj*>)0x005594B0)(ref this, objectID, vdesc, physicsdesc, wdesc);
    // void __thiscall ACCObjectMaint::ViewObjectContents(CObjectMaint*,unsigned int,int)
    public void ViewObjectContents(uint object_id, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCObjectMaint, uint, int, void>)0x005596B0)(ref this, object_id, a3);
    // void __thiscall ACCObjectMaint::StopViewingObjectContents(ACCObjectMaint*,unsigned int)
    public void StopViewingObjectContents(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCObjectMaint, uint, void>)0x00559770)(ref this, object_id);
    // _DWORD* __thiscall ACCObjectMaint::UpdateObjectInventory(CObjectMaint*,unsigned int,int)
    public int* UpdateObjectInventory(uint object_id, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCObjectMaint, uint, int, int*>)0x0055A190)(ref this, object_id, a3);
}

