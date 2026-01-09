namespace ACBindings;

// BTree
public unsafe struct BTree : System.IDisposable
{
    // Members
    public ACBindings.BTMemNode mem_root_node_m;
    public ACBindings.BTMemNode* mem_nodes_pm;
    public int nodesInMem_;
    public int _time_stamp;
    public ACBindings.CLBlockAllocator* pBlkMan_;
    public ACBindings.DiskFileInfo_t* file_info_pm;
    public ACBindings.LRU_List* lru_man_pm;

    // Generated Constructor
    public BTree(ACBindings.CLBlockAllocator* allocator) {
        _ConstructorInternal(allocator);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall BTree::ExtractEntryShift(BTree*,BTMemNode*,int,BTEntry*)
    public int ExtractEntryShift(ACBindings.BTMemNode* pNode, int index, ACBindings.BTEntry* pOutEntry) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTMemNode*, int, ACBindings.BTEntry*, int>)0x00672BF0)(ref this, pNode, index, pOutEntry);
    // void __thiscall BTree::AddLeast(BTree*,BTMemNode*,BTEntry*,int)
    public void AddLeast(ACBindings.BTMemNode* pNode, ACBindings.BTEntry* newEntry, int newLink) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTMemNode*, ACBindings.BTEntry*, int, void>)0x00672C80)(ref this, pNode, newEntry, newLink);
    // char __stdcall BTree::HasEntry(unsigned int,int,int*)
    public static sbyte HasEntry(uint a1, int a2, int* a3) => ((delegate* unmanaged[Stdcall]<uint, int, int*, sbyte>)0x00672D20)(a1, a2, a3);
    // BTEntry* __thiscall BTree::RemoveLeast(BTree*,BTEntry*,BTMemNode*,int*)
    public ACBindings.BTEntry* RemoveLeast(ACBindings.BTEntry* result, ACBindings.BTMemNode* pNode, int* pOutLink) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTEntry*, ACBindings.BTMemNode*, int*, ACBindings.BTEntry*>)0x00672DA0)(ref this, result, pNode, pOutLink);
    // int __thiscall BTree::UpdateNode(BTree*,BTMemNode*,BTMemNode*)
    public int UpdateNode(ACBindings.BTMemNode* pTarget, ACBindings.BTMemNode* pParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTMemNode*, ACBindings.BTMemNode*, int>)0x00672E30)(ref this, pTarget, pParent);
    // char __thiscall BTree::Restamp_Entry(int,int)
    public sbyte Restamp_Entry(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, int, sbyte>)0x00672EA0)(ref this, a2);
    // void __thiscall BTree::BTree(BTree*,CLBlockAllocator*)
    public void _ConstructorInternal(ACBindings.CLBlockAllocator* allocator) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.CLBlockAllocator*, void>)0x00672F10)(ref this, allocator);
    // void __thiscall BTree::~BTree(BTree*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, void>)0x00672F60)(ref this);
    // int __thiscall BTree::CreateTree(BTree*,DiskFileInfo_t*)
    public int CreateTree(ACBindings.DiskFileInfo_t* pHeaderInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.DiskFileInfo_t*, int>)0x00672FB0)(ref this, pHeaderInfo);
    // int __thiscall BTree::LoadTree(BTree*,DiskFileInfo_t*)
    public int LoadTree(ACBindings.DiskFileInfo_t* pHeaderInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.DiskFileInfo_t*, int>)0x006730F0)(ref this, pHeaderInfo);
    // int __thiscall BTree::SaveDataToFile(BTree*)
    public int SaveDataToFile() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, int>)0x00673220)(ref this);
    // BTMemNode* __thiscall BTree::FindNode(BTree*,int,int*)
    public ACBindings.BTMemNode* FindNode(int offset, int* pOutIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, int, int*, ACBindings.BTMemNode*>)0x006732C0)(ref this, offset, pOutIndex);
    // BTMemNode* __thiscall BTree::AllocateEmptyNode(BTree*)
    public ACBindings.BTMemNode* AllocateEmptyNode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTMemNode*>)0x00673450)(ref this);
    // int __thiscall BTree::SplitNodeExec(BTree*,const SplitNodeTransactInfo*)
    public int SplitNodeExec(ACBindings.SplitNodeTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.SplitNodeTransactInfo*, int>)0x006734E0)(ref this, pTrIn);
    // int __thiscall BTree::InsertEntryExec(BTree*,const AddObjectTransactInfo*,Cache_Pack_t*)
    public int InsertEntryExec(ACBindings.AddObjectTransactInfo* pTrIn, ACBindings.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.AddObjectTransactInfo*, ACBindings.Cache_Pack_t*, int>)0x00673660)(ref this, pTrIn, pack_buf);
    // int __thiscall BTree::UpdateObjectExec(BTree*,const UpdateObjectTransactInfo*,Cache_Pack_t*)
    public int UpdateObjectExec(ACBindings.UpdateObjectTransactInfo* pTrIn, ACBindings.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.UpdateObjectTransactInfo*, ACBindings.Cache_Pack_t*, int>)0x006737D0)(ref this, pTrIn, pack_buf);
    // int __thiscall BTree::MergeNodesExec(BTree*,const MergeNodesTransactInfo*)
    public int MergeNodesExec(ACBindings.MergeNodesTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.MergeNodesTransactInfo*, int>)0x00673960)(ref this, pTrIn);
    // unsigned int* __thiscall BTree::FindMin(BTree*,unsigned int*,BTMemNode*)
    public uint* FindMin(uint* a2, ACBindings.BTMemNode* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, uint*, ACBindings.BTMemNode*, uint*>)0x00673BC0)(ref this, a2, a3);
    // int* __thiscall BTree::FindMax(BTree*,int*,BTMemNode*)
    public int* FindMax(int* a2, ACBindings.BTMemNode* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, int*, ACBindings.BTMemNode*, int*>)0x00673C00)(ref this, a2, a3);
    // int __thiscall BTree::DeleteLeafExec(BTree*,const DeleteLeafTransactInfo*)
    public int DeleteLeafExec(ACBindings.DeleteLeafTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.DeleteLeafTransactInfo*, int>)0x00673C50)(ref this, pTrIn);
    // int __thiscall BTree::DeleteInternalExec(BTree*,const DeleteInternalTransactInfo*)
    public int DeleteInternalExec(ACBindings.DeleteInternalTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.DeleteInternalTransactInfo*, int>)0x00673D00)(ref this, pTrIn);
    // int __thiscall BTree::RotateEntryExec(BTree*,const RotateEntryTransactInfo*)
    public int RotateEntryExec(ACBindings.RotateEntryTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.RotateEntryTransactInfo*, int>)0x00673E20)(ref this, pTrIn);
    // int __thiscall BTree::RecoverTransaction(BTree*,const DiskTransactInfo*)
    public int RecoverTransaction(ACBindings.DiskTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.DiskTransactInfo*, int>)0x00673FC0)(ref this, pTrIn);
    // int __thiscall BTree::Search(BTree*,BTMemNode*,unsigned int,BTMemNode**)
    public int Search(ACBindings.BTMemNode* a2, uint a3, ACBindings.BTMemNode** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTMemNode*, uint, ACBindings.BTMemNode**, int>)0x00674160)(ref this, a2, a3, a4);
    // int __thiscall BTree::SplitNodeTrans(BTree*,BTMemNode*,int,BTMemNode*)
    public int SplitNodeTrans(ACBindings.BTMemNode* pParent, int splitIndex, ACBindings.BTMemNode* pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTMemNode*, int, ACBindings.BTMemNode*, int>)0x006741E0)(ref this, pParent, splitIndex, pNode);
    // int __thiscall BTree::InsertEntryTrans(BTree*,BTMemNode*,BTEntry*,Cache_Pack_t*)
    public int InsertEntryTrans(ACBindings.BTMemNode* pNode, ACBindings.BTEntry* entry, ACBindings.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTMemNode*, ACBindings.BTEntry*, ACBindings.Cache_Pack_t*, int>)0x00674250)(ref this, pNode, entry, pack_buf);
    // int __thiscall BTree::Update_Data_Trans(BTree*,BTMemNode*,BTEntry*,Cache_Pack_t*)
    public int Update_Data_Trans(ACBindings.BTMemNode* pNode, ACBindings.BTEntry* entry, ACBindings.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTMemNode*, ACBindings.BTEntry*, ACBindings.Cache_Pack_t*, int>)0x006742C0)(ref this, pNode, entry, pack_buf);
    // int __thiscall BTree::DescendToAdd(BTree*,BTEntry*,Cache_Pack_t*)
    public int DescendToAdd(ACBindings.BTEntry* entry, ACBindings.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTEntry*, ACBindings.Cache_Pack_t*, int>)0x00674350)(ref this, entry, pack_buf);
    // int __thiscall BTree::MergeNodesTrans(BTree*,BTMemNode*,BTMemNode*,BTMemNode*,int)
    public int MergeNodesTrans(ACBindings.BTMemNode* pNode, ACBindings.BTMemNode* pLeftKid, ACBindings.BTMemNode* pRightKid, int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTMemNode*, ACBindings.BTMemNode*, ACBindings.BTMemNode*, int, int>)0x00674500)(ref this, pNode, pLeftKid, pRightKid, index);
    // int __thiscall BTree::DeleteLeafTrans(BTree*,BTMemNode*,int)
    public int DeleteLeafTrans(ACBindings.BTMemNode* pNode, int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTMemNode*, int, int>)0x00674580)(ref this, pNode, index);
    // int __thiscall BTree::DeleteInternalTrans(BTree*,unsigned int,unsigned int,int,int,int,int)
    public int DeleteInternalTrans(uint a2, uint a3, int a4, int a5, int a6, int a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, uint, uint, int, int, int, int, int>)0x006745E0)(ref this, a2, a3, a4, a5, a6, a7);
    // int __thiscall BTree::RotateEntryTrans(BTree*,BTMemNode*,int,int,int,bool)
    public int RotateEntryTrans(ACBindings.BTMemNode* pParent, int index, int nodeEntryCount, int siblingEntryCount, byte fLeftSibling) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTMemNode*, int, int, int, byte, int>)0x00674650)(ref this, pParent, index, nodeEntryCount, siblingEntryCount, fLeftSibling);
    // int __thiscall BTree::Lookup(BTree*,unsigned int,BTMemNode**)
    public int Lookup(uint a2, ACBindings.BTMemNode** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, uint, ACBindings.BTMemNode**, int>)0x006747A0)(ref this, a2, a3);
    // int __thiscall BTree::DescendToDelete(BTree*,BTMemNode*,unsigned int,BTMemNode**,int*)
    public int DescendToDelete(ACBindings.BTMemNode* pParent, uint a3, ACBindings.BTMemNode** a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, ACBindings.BTMemNode*, uint, ACBindings.BTMemNode**, int*, int>)0x006747D0)(ref this, pParent, a3, a4, a5);
    // int __thiscall BTree::Delete(int,unsigned int,BTMemNode*)
    public int Delete(uint a2, ACBindings.BTMemNode* pLeftKid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, uint, ACBindings.BTMemNode*, int>)0x00674950)(ref this, a2, pLeftKid);
    // bool __thiscall BTree::Remove(BTMemNode*,unsigned int)
    public byte Remove(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, uint, byte>)0x00674AF0)(ref this, a2);
    // bool __thiscall BTree::Try_Delete_Oldest(BTree*)
    public byte Try_Delete_Oldest() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, byte>)0x00674B70)(ref this);
    // _DWORD* __thiscall BTree::Build_Id_List(BTree*,_DWORD*,int,signed int,_DWORD*)
    public int* Build_Id_List(int* a2, int a3, int a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, int*, int, int, int*, int*>)0x00674BC0)(ref this, a2, a3, a4, a5);
    // int __thiscall BTree::Build_Id_List(BTree*,_DWORD*,BTMemNode*)
    public int Build_Id_List(int* a2, ACBindings.BTMemNode* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, int*, ACBindings.BTMemNode*, int>)0x00674CB0)(ref this, a2, a3);
    // char __thiscall BTree::Get_Id_List(BTree*,_DWORD*)
    public sbyte Get_Id_List(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, int*, sbyte>)0x00674DC0)(ref this, a2);
    // bool __thiscall BTree::Get_Id_List_Range(BTree*,_DWORD*,signed int,_DWORD*)
    public byte Get_Id_List_Range(int* a2, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BTree, int*, int, int*, byte>)0x00674DE0)(ref this, a2, a3, a4);
}

