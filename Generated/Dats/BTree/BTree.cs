namespace ACBindings.Internal;

public unsafe struct BTree : System.IDisposable
{
    // Members
    public ACBindings.Internal.BTMemNode mem_root_node_m;
    public ACBindings.Internal.BTMemNode* mem_nodes_pm;
    public int nodesInMem_;
    public int _time_stamp;
    public ACBindings.Internal.CLBlockAllocator* pBlkMan_;
    public ACBindings.Internal.DiskFileInfo_t* file_info_pm;
    public ACBindings.Internal.LRU_List* lru_man_pm;

    // Generated Constructor
    public BTree(ACBindings.Internal.CLBlockAllocator* allocator) {
        _ConstructorInternal(allocator);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00672BF0
    /// int __thiscall BTree::ExtractEntryShift(BTree*,BTMemNode*,int,BTEntry*)</code>
    /// </summary>
    public int ExtractEntryShift(ACBindings.Internal.BTMemNode* pNode, int index, ACBindings.Internal.BTEntry* pOutEntry) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, int, ACBindings.Internal.BTEntry*, int>)0x00672BF0)(ref this, pNode, index, pOutEntry);

    /// <summary>
    /// <code>Offset: 0x00672C80
    /// void __thiscall BTree::AddLeast(BTree*,BTMemNode*,BTEntry*,int)</code>
    /// </summary>
    public void AddLeast(ACBindings.Internal.BTMemNode* pNode, ACBindings.Internal.BTEntry* newEntry, int newLink) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, ACBindings.Internal.BTEntry*, int, void>)0x00672C80)(ref this, pNode, newEntry, newLink);

    /// <summary>
    /// <code>Offset: 0x00672D20
    /// char __stdcall BTree::HasEntry(unsigned int,int,int*)</code>
    /// </summary>
    public static sbyte HasEntry(uint a1, int a2, int* a3) => ((delegate* unmanaged[Stdcall]<uint, int, int*, sbyte>)0x00672D20)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00672DA0
    /// BTEntry* __thiscall BTree::RemoveLeast(BTree*,BTEntry*,BTMemNode*,int*)</code>
    /// </summary>
    public ACBindings.Internal.BTEntry* RemoveLeast(ACBindings.Internal.BTEntry* result, ACBindings.Internal.BTMemNode* pNode, int* pOutLink) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTEntry*, ACBindings.Internal.BTMemNode*, int*, ACBindings.Internal.BTEntry*>)0x00672DA0)(ref this, result, pNode, pOutLink);

    /// <summary>
    /// <code>Offset: 0x00672E30
    /// int __thiscall BTree::UpdateNode(BTree*,BTMemNode*,BTMemNode*)</code>
    /// </summary>
    public int UpdateNode(ACBindings.Internal.BTMemNode* pTarget, ACBindings.Internal.BTMemNode* pParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, ACBindings.Internal.BTMemNode*, int>)0x00672E30)(ref this, pTarget, pParent);

    /// <summary>
    /// <code>Offset: 0x00672EA0
    /// char __thiscall BTree::Restamp_Entry(int,int)</code>
    /// </summary>
    public sbyte Restamp_Entry(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int, sbyte>)0x00672EA0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00672F10
    /// void __thiscall BTree::BTree(BTree*,CLBlockAllocator*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CLBlockAllocator* allocator) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.CLBlockAllocator*, void>)0x00672F10)(ref this, allocator);

    /// <summary>
    /// <code>Offset: 0x00672F60
    /// void __thiscall BTree::~BTree(BTree*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, void>)0x00672F60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00672FB0
    /// int __thiscall BTree::CreateTree(BTree*,DiskFileInfo_t*)</code>
    /// </summary>
    public int CreateTree(ACBindings.Internal.DiskFileInfo_t* pHeaderInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.DiskFileInfo_t*, int>)0x00672FB0)(ref this, pHeaderInfo);

    /// <summary>
    /// <code>Offset: 0x006730F0
    /// int __thiscall BTree::LoadTree(BTree*,DiskFileInfo_t*)</code>
    /// </summary>
    public int LoadTree(ACBindings.Internal.DiskFileInfo_t* pHeaderInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.DiskFileInfo_t*, int>)0x006730F0)(ref this, pHeaderInfo);

    /// <summary>
    /// <code>Offset: 0x00673220
    /// int __thiscall BTree::SaveDataToFile(BTree*)</code>
    /// </summary>
    public int SaveDataToFile() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int>)0x00673220)(ref this);

    /// <summary>
    /// <code>Offset: 0x006732C0
    /// BTMemNode* __thiscall BTree::FindNode(BTree*,int,int*)</code>
    /// </summary>
    public ACBindings.Internal.BTMemNode* FindNode(int offset, int* pOutIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int, int*, ACBindings.Internal.BTMemNode*>)0x006732C0)(ref this, offset, pOutIndex);

    /// <summary>
    /// <code>Offset: 0x00673450
    /// BTMemNode* __thiscall BTree::AllocateEmptyNode(BTree*)</code>
    /// </summary>
    public ACBindings.Internal.BTMemNode* AllocateEmptyNode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*>)0x00673450)(ref this);

    /// <summary>
    /// <code>Offset: 0x006734E0
    /// int __thiscall BTree::SplitNodeExec(BTree*,const SplitNodeTransactInfo*)</code>
    /// </summary>
    public int SplitNodeExec(ACBindings.Internal.SplitNodeTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.SplitNodeTransactInfo*, int>)0x006734E0)(ref this, pTrIn);

    /// <summary>
    /// <code>Offset: 0x00673660
    /// int __thiscall BTree::InsertEntryExec(BTree*,const AddObjectTransactInfo*,Cache_Pack_t*)</code>
    /// </summary>
    public int InsertEntryExec(ACBindings.Internal.AddObjectTransactInfo* pTrIn, ACBindings.Internal.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.AddObjectTransactInfo*, ACBindings.Internal.Cache_Pack_t*, int>)0x00673660)(ref this, pTrIn, pack_buf);

    /// <summary>
    /// <code>Offset: 0x006737D0
    /// int __thiscall BTree::UpdateObjectExec(BTree*,const UpdateObjectTransactInfo*,Cache_Pack_t*)</code>
    /// </summary>
    public int UpdateObjectExec(ACBindings.Internal.UpdateObjectTransactInfo* pTrIn, ACBindings.Internal.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.UpdateObjectTransactInfo*, ACBindings.Internal.Cache_Pack_t*, int>)0x006737D0)(ref this, pTrIn, pack_buf);

    /// <summary>
    /// <code>Offset: 0x00673960
    /// int __thiscall BTree::MergeNodesExec(BTree*,const MergeNodesTransactInfo*)</code>
    /// </summary>
    public int MergeNodesExec(ACBindings.Internal.MergeNodesTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.MergeNodesTransactInfo*, int>)0x00673960)(ref this, pTrIn);

    /// <summary>
    /// <code>Offset: 0x00673BC0
    /// unsigned int* __thiscall BTree::FindMin(BTree*,unsigned int*,BTMemNode*)</code>
    /// </summary>
    public uint* FindMin(uint* a2, ACBindings.Internal.BTMemNode* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, uint*, ACBindings.Internal.BTMemNode*, uint*>)0x00673BC0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00673C00
    /// int* __thiscall BTree::FindMax(BTree*,int*,BTMemNode*)</code>
    /// </summary>
    public int* FindMax(int* a2, ACBindings.Internal.BTMemNode* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int*, ACBindings.Internal.BTMemNode*, int*>)0x00673C00)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00673C50
    /// int __thiscall BTree::DeleteLeafExec(BTree*,const DeleteLeafTransactInfo*)</code>
    /// </summary>
    public int DeleteLeafExec(ACBindings.Internal.DeleteLeafTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.DeleteLeafTransactInfo*, int>)0x00673C50)(ref this, pTrIn);

    /// <summary>
    /// <code>Offset: 0x00673D00
    /// int __thiscall BTree::DeleteInternalExec(BTree*,const DeleteInternalTransactInfo*)</code>
    /// </summary>
    public int DeleteInternalExec(ACBindings.Internal.DeleteInternalTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.DeleteInternalTransactInfo*, int>)0x00673D00)(ref this, pTrIn);

    /// <summary>
    /// <code>Offset: 0x00673E20
    /// int __thiscall BTree::RotateEntryExec(BTree*,const RotateEntryTransactInfo*)</code>
    /// </summary>
    public int RotateEntryExec(ACBindings.Internal.RotateEntryTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.RotateEntryTransactInfo*, int>)0x00673E20)(ref this, pTrIn);

    /// <summary>
    /// <code>Offset: 0x00673FC0
    /// int __thiscall BTree::RecoverTransaction(BTree*,const DiskTransactInfo*)</code>
    /// </summary>
    public int RecoverTransaction(ACBindings.Internal.DiskTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.DiskTransactInfo*, int>)0x00673FC0)(ref this, pTrIn);

    /// <summary>
    /// <code>Offset: 0x00674160
    /// int __thiscall BTree::Search(BTree*,BTMemNode*,unsigned int,BTMemNode**)</code>
    /// </summary>
    public int Search(ACBindings.Internal.BTMemNode* a2, uint a3, ACBindings.Internal.BTMemNode** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, uint, ACBindings.Internal.BTMemNode**, int>)0x00674160)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x006741E0
    /// int __thiscall BTree::SplitNodeTrans(BTree*,BTMemNode*,int,BTMemNode*)</code>
    /// </summary>
    public int SplitNodeTrans(ACBindings.Internal.BTMemNode* pParent, int splitIndex, ACBindings.Internal.BTMemNode* pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, int, ACBindings.Internal.BTMemNode*, int>)0x006741E0)(ref this, pParent, splitIndex, pNode);

    /// <summary>
    /// <code>Offset: 0x00674250
    /// int __thiscall BTree::InsertEntryTrans(BTree*,BTMemNode*,BTEntry*,Cache_Pack_t*)</code>
    /// </summary>
    public int InsertEntryTrans(ACBindings.Internal.BTMemNode* pNode, ACBindings.Internal.BTEntry* entry, ACBindings.Internal.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, int>)0x00674250)(ref this, pNode, entry, pack_buf);

    /// <summary>
    /// <code>Offset: 0x006742C0
    /// int __thiscall BTree::Update_Data_Trans(BTree*,BTMemNode*,BTEntry*,Cache_Pack_t*)</code>
    /// </summary>
    public int Update_Data_Trans(ACBindings.Internal.BTMemNode* pNode, ACBindings.Internal.BTEntry* entry, ACBindings.Internal.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, int>)0x006742C0)(ref this, pNode, entry, pack_buf);

    /// <summary>
    /// <code>Offset: 0x00674350
    /// int __thiscall BTree::DescendToAdd(BTree*,BTEntry*,Cache_Pack_t*)</code>
    /// </summary>
    public int DescendToAdd(ACBindings.Internal.BTEntry* entry, ACBindings.Internal.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, int>)0x00674350)(ref this, entry, pack_buf);

    /// <summary>
    /// <code>Offset: 0x00674500
    /// int __thiscall BTree::MergeNodesTrans(BTree*,BTMemNode*,BTMemNode*,BTMemNode*,int)</code>
    /// </summary>
    public int MergeNodesTrans(ACBindings.Internal.BTMemNode* pNode, ACBindings.Internal.BTMemNode* pLeftKid, ACBindings.Internal.BTMemNode* pRightKid, int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, ACBindings.Internal.BTMemNode*, ACBindings.Internal.BTMemNode*, int, int>)0x00674500)(ref this, pNode, pLeftKid, pRightKid, index);

    /// <summary>
    /// <code>Offset: 0x00674580
    /// int __thiscall BTree::DeleteLeafTrans(BTree*,BTMemNode*,int)</code>
    /// </summary>
    public int DeleteLeafTrans(ACBindings.Internal.BTMemNode* pNode, int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, int, int>)0x00674580)(ref this, pNode, index);

    /// <summary>
    /// <code>Offset: 0x006745E0
    /// int __thiscall BTree::DeleteInternalTrans(BTree*,unsigned int,unsigned int,int,int,int,int)</code>
    /// </summary>
    public int DeleteInternalTrans(uint a2, uint a3, int a4, int a5, int a6, int a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, uint, uint, int, int, int, int, int>)0x006745E0)(ref this, a2, a3, a4, a5, a6, a7);

    /// <summary>
    /// <code>Offset: 0x00674650
    /// int __thiscall BTree::RotateEntryTrans(BTree*,BTMemNode*,int,int,int,bool)</code>
    /// </summary>
    public int RotateEntryTrans(ACBindings.Internal.BTMemNode* pParent, int index, int nodeEntryCount, int siblingEntryCount, byte fLeftSibling) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, int, int, int, byte, int>)0x00674650)(ref this, pParent, index, nodeEntryCount, siblingEntryCount, fLeftSibling);

    /// <summary>
    /// <code>Offset: 0x006747A0
    /// int __thiscall BTree::Lookup(BTree*,unsigned int,BTMemNode**)</code>
    /// </summary>
    public int Lookup(uint a2, ACBindings.Internal.BTMemNode** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, uint, ACBindings.Internal.BTMemNode**, int>)0x006747A0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x006747D0
    /// int __thiscall BTree::DescendToDelete(BTree*,BTMemNode*,unsigned int,BTMemNode**,int*)</code>
    /// </summary>
    public int DescendToDelete(ACBindings.Internal.BTMemNode* pParent, uint a3, ACBindings.Internal.BTMemNode** a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, uint, ACBindings.Internal.BTMemNode**, int*, int>)0x006747D0)(ref this, pParent, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x00674950
    /// int __thiscall BTree::Delete(int,unsigned int,BTMemNode*)</code>
    /// </summary>
    public int Delete(uint a2, ACBindings.Internal.BTMemNode* pLeftKid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, uint, ACBindings.Internal.BTMemNode*, int>)0x00674950)(ref this, a2, pLeftKid);

    /// <summary>
    /// <code>Offset: 0x00674AF0
    /// bool __thiscall BTree::Remove(BTMemNode*,unsigned int)</code>
    /// </summary>
    public byte Remove(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, uint, byte>)0x00674AF0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00674B70
    /// bool __thiscall BTree::Try_Delete_Oldest(BTree*)</code>
    /// </summary>
    public byte Try_Delete_Oldest() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, byte>)0x00674B70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00674BC0
    /// _DWORD* __thiscall BTree::Build_Id_List(BTree*,_DWORD*,int,signed int,_DWORD*)</code>
    /// </summary>
    public int* Build_Id_List(int* a2, int a3, int a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int*, int, int, int*, int*>)0x00674BC0)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x00674CB0
    /// int __thiscall BTree::Build_Id_List(BTree*,_DWORD*,BTMemNode*)</code>
    /// </summary>
    public int Build_Id_List(int* a2, ACBindings.Internal.BTMemNode* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int*, ACBindings.Internal.BTMemNode*, int>)0x00674CB0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00674DC0
    /// char __thiscall BTree::Get_Id_List(BTree*,_DWORD*)</code>
    /// </summary>
    public sbyte Get_Id_List(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int*, sbyte>)0x00674DC0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00674DE0
    /// bool __thiscall BTree::Get_Id_List_Range(BTree*,_DWORD*,signed int,_DWORD*)</code>
    /// </summary>
    public byte Get_Id_List_Range(int* a2, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int*, int, int*, byte>)0x00674DE0)(ref this, a2, a3, a4);
}

