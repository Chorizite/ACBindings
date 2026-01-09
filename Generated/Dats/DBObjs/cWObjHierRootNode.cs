namespace ACBindings;

// cWObjHierRootNode
public unsafe struct cWObjHierRootNode
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj
    public ACBindings.cWObjHierNode BaseClass_cWObjHierNode; // ACBindings.cWObjHierNode

    // Child Types
    // cWObjHierRootNode_vtbl
    public unsafe struct cWObjHierRootNode_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer

        // Methods
    }

    // Generated Constructor
    public cWObjHierRootNode(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods
    // DBObj* __cdecl cWObjHierRootNode::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7C40)();
    // int __thiscall cWObjHierRootNode::cWObjHierRootNode(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.cWObjHierRootNode, void**, int>)0x004FD360)(ref this, a2);
    // unsigned int __thiscall cWObjHierRootNode::Pack(cWObjHierRootNode*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.cWObjHierRootNode, void**, uint, uint>)0x004FD720)(ref this, addr, size);
    // int __thiscall cWObjHierRootNode::UnPack(cWObjHierRootNode*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.cWObjHierRootNode, void**, uint, int>)0x004FD750)(ref this, addr, size);
}

