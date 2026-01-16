namespace ACBindings.Internal;


/// <summary>Manages a persistent B‑tree used to store and retrieve BTEntry objects on disk with an in‑memory cache. The structure handles node allocation, searching, insertion, deletion and transaction recovery while coordinating with a block allocator and optional LRU list for efficient access.</summary>
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

    /// <summary>Removes the entry at the specified index from a BTree memory node, shifting subsequent entries left and updating child pointers.
    /// <code>Offset: 0x00672BF0
    /// int __thiscall BTree::ExtractEntryShift(BTree*,BTMemNode*,int,BTEntry*)</code>
    /// </summary>
    /// <param name="pNode">The memory node to modify.</param>
    /// <param name="index">Zero‑based position of the entry to extract within the node.</param>
    /// <param name="pOutEntry">Destination for a copy of the extracted entry; may be null if not needed.</param>
    /// <returns>Always 0, indicating successful extraction.</returns>
    public int ExtractEntryShift(ACBindings.Internal.BTMemNode* pNode, int index, ACBindings.Internal.BTEntry* pOutEntry) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, int, ACBindings.Internal.BTEntry*, int>)0x00672BF0)(ref this, pNode, index, pOutEntry);

    /// <summary>Inserts a new entry at the beginning of a B‑tree memory node, shifting existing entries and updating child links accordingly.
    /// <code>Offset: 0x00672C80
    /// void __thiscall BTree::AddLeast(BTree*,BTMemNode*,BTEntry*,int)</code>
    /// </summary>
    /// <param name="pNode">The node into which the new entry is inserted.</param>
    /// <param name="newEntry">Pointer to the entry data to insert.</param>
    /// <param name="newLink">Identifier for the leftmost child link associated with the new entry.</param>
    public void AddLeast(ACBindings.Internal.BTMemNode* pNode, ACBindings.Internal.BTEntry* newEntry, int newLink) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, ACBindings.Internal.BTEntry*, int, void>)0x00672C80)(ref this, pNode, newEntry, newLink);

    /// <summary>
    /// Searches a B‑tree node for the specified key, returning true if found; otherwise returns false and supplies the index at which the key would be inserted to preserve sorted order.
    /// 
    /// <code>Offset: 0x00672D20
    /// char __stdcall BTree::HasEntry(unsigned int,int,int*)</code>
    /// </summary>
    /// <param name="a1">Key value to locate.</param>
    /// <param name="a2">Pointer to the BTree node structure containing an array of keys.</param>
    /// <param name="a3">Out parameter that receives the position index for insertion if the key is not found, or the existing entry index when the key exists.</param>
    /// <returns>Nonzero (true) if the key is present in the node; zero (false) otherwise.</returns>
    public static sbyte HasEntry(uint a1, int a2, int* a3) => ((delegate* unmanaged[Stdcall]<uint, int, int*, sbyte>)0x00672D20)(a1, a2, a3);

    /// <summary>Extracts and removes the first entry from a BTree memory node, shifting subsequent entries forward and updating node metadata.
    /// <code>Offset: 0x00672DA0
    /// BTEntry* __thiscall BTree::RemoveLeast(BTree*,BTEntry*,BTMemNode*,int*)</code>
    /// </summary>
    /// <param name="result">Buffer that receives the removed entry; returned unchanged.</param>
    /// <param name="pNode">Memory node from which to remove the least entry.</param>
    /// <param name="pOutLink">Receives the original next-node link of the removed entry’s node.</param>
    /// <returns>Pointer to <paramref name="result"/> containing the extracted entry.</returns>
    public ACBindings.Internal.BTEntry* RemoveLeast(ACBindings.Internal.BTEntry* result, ACBindings.Internal.BTMemNode* pNode, int* pOutLink) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTEntry*, ACBindings.Internal.BTMemNode*, int*, ACBindings.Internal.BTEntry*>)0x00672DA0)(ref this, result, pNode, pOutLink);

    /// <summary>Persists the contents of a memory node to disk, clearing its dirty flag.
    /// <code>Offset: 0x00672E30
    /// int __thiscall BTree::UpdateNode(BTree*,BTMemNode*,BTMemNode*)</code>
    /// </summary>
    /// <param name="pTarget">The in‑memory node whose data should be written back to storage.</param>
    /// <param name="pParent">Ignored; retained for interface compatibility.</param>
    /// <returns>Zero (success).</returns>
    public int UpdateNode(ACBindings.Internal.BTMemNode* pTarget, ACBindings.Internal.BTMemNode* pParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, ACBindings.Internal.BTMemNode*, int>)0x00672E30)(ref this, pTarget, pParent);

    /// <summary>Updates the LRU usage status of a BTree node when its internal flag is active and returns the resulting status byte.
    /// <code>Offset: 0x00672EA0
    /// char __thiscall BTree::Restamp_Entry(int,int)</code>
    /// </summary>
    /// <param name="a2">The identifier or index of the node to restamp.</param>
    /// <returns>The low‑order byte from the node’s internal state, possibly updated by the LRU list.</returns>
    public sbyte Restamp_Entry(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int, sbyte>)0x00672EA0)(ref this, a2);

    /// <summary>Initializes a BTree instance with the supplied block allocator, setting up its root node and internal tracking fields.
    /// <code>Offset: 0x00672F10
    /// void __thiscall BTree::BTree(BTree*,CLBlockAllocator*)</code>
    /// </summary>
    /// <param name="allocator">The CLBlockAllocator used for managing memory blocks of the tree.</param>
    public void _ConstructorInternal(ACBindings.Internal.CLBlockAllocator* allocator) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.CLBlockAllocator*, void>)0x00672F10)(ref this, allocator);

    /// <summary>Releases allocated memory for the tree’s in‑memory node array and its LRU manager, performing necessary cleanup before object destruction.
    /// <code>Offset: 0x00672F60
    /// void __thiscall BTree::~BTree(BTree*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, void>)0x00672F60)(ref this);

    /// <summary>Initializes the BTree instance using data from a DiskFileInfo_t header, allocating an array of tree nodes, establishing the root node offset, and setting up optional LRU management.
    /// <code>Offset: 0x00672FB0
    /// int __thiscall BTree::CreateTree(BTree*,DiskFileInfo_t*)</code>
    /// </summary>
    /// <param name="pHeaderInfo">Disk file header containing metadata required to create the B‑tree structure.</param>
    /// <returns>Integer status code; zero or positive on success, negative values indicate allocation or initialization failure.</returns>
    public int CreateTree(ACBindings.Internal.DiskFileInfo_t* pHeaderInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.DiskFileInfo_t*, int>)0x00672FB0)(ref this, pHeaderInfo);

    /// <summary>Loads a B‑tree from the supplied disk file header, allocating memory for nodes and initializing them with data read from disk. If an LRU manager is requested, it also loads the corresponding list.
    /// <code>Offset: 0x006730F0
    /// int __thiscall BTree::LoadTree(BTree*,DiskFileInfo_t*)</code>
    /// </summary>
    /// <param name="pHeaderInfo">Pointer to the disk file information structure that contains metadata such as the root node offset and flags controlling LRU loading.</param>
    /// <returns>Zero on success; a negative value (e.g., –1) indicates failure during allocation or data load.</returns>
    public int LoadTree(ACBindings.Internal.DiskFileInfo_t* pHeaderInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.DiskFileInfo_t*, int>)0x006730F0)(ref this, pHeaderInfo);

    /// <summary>
    /// Flushes in-memory BTree nodes to disk, updates the root offset if changed, writes file metadata via block allocator, and clears transaction state.
    /// 
    /// <code>Offset: 0x00673220
    /// int __thiscall BTree::SaveDataToFile(BTree*)</code>
    /// </summary>
    /// <returns>
    /// An integer status code from CLBlockAllocator::SaveFileInfo; zero indicates success, non‑zero signals an error during saving.
    /// </returns>
    public int SaveDataToFile() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int>)0x00673220)(ref this);

    /// <summary>Retrieves a BTree node by its on‑disk offset, returning the in‑memory representation and updating its LRU status; loads data from disk into an available cache slot if necessary.
    /// <code>Offset: 0x006732C0
    /// BTMemNode* __thiscall BTree::FindNode(BTree*,int,int*)</code>
    /// </summary>
    /// <param name="offset">The on‑disk offset of the desired node. If it matches the root’s offset, the root node is returned.</param>
    /// <param name="pOutIndex">Receives the index of the returned node within the in‑memory array; set to -1 when the root node is returned. May be null if the caller does not need the index.</param>
    /// <returns>A pointer to the BTMemNode that corresponds to the requested offset, after ensuring it is resident and up-to-date.</returns>
    public ACBindings.Internal.BTMemNode* FindNode(int offset, int* pOutIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int, int*, ACBindings.Internal.BTMemNode*>)0x006732C0)(ref this, offset, pOutIndex);

    /// <summary>Allocates and initializes an empty node within the BTree, resetting its entry count and persisting the node data to storage.
    /// <code>Offset: 0x00673450
    /// BTMemNode* __thiscall BTree::AllocateEmptyNode(BTree*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated BTMemNode.</returns>
    public ACBindings.Internal.BTMemNode* AllocateEmptyNode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*>)0x00673450)(ref this);

    /// <summary>Splits a B‑tree node according to the supplied transaction information, redistributing entries between existing nodes and updating parent references.
    /// <code>Offset: 0x006734E0
    /// int __thiscall BTree::SplitNodeExec(BTree*,const SplitNodeTransactInfo*)</code>
    /// </summary>
    /// <param name="pTrIn">Transaction data containing the parent offset, split index, first free block, and entry counts needed for the split operation.</param>
    /// <returns>Zero on completion.</returns>
    public int SplitNodeExec(ACBindings.Internal.SplitNodeTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.SplitNodeTransactInfo*, int>)0x006734E0)(ref this, pTrIn);

    /// <summary>Inserts a new entry into the B‑tree node identified by the transaction info, shifting existing entries and updating node metadata before persisting changes.
    /// <code>Offset: 0x00673660
    /// int __thiscall BTree::InsertEntryExec(BTree*,const AddObjectTransactInfo*,Cache_Pack_t*)</code>
    /// </summary>
    /// <param name="pTrIn">Transaction information containing the entry to insert, its offset within the tree, free block index, and current number of node entries.</param>
    /// <param name="pack_buf">Buffer holding data for the new entry; used during storage allocation and rollback.</param>
    /// <returns>Zero on success. Negative values indicate errors such as invalid size (-101), missing node (-1), or buffer allocation failures. Positive values may be returned from underlying block‑allocation operations if they report a status code.</returns>
    public int InsertEntryExec(ACBindings.Internal.AddObjectTransactInfo* pTrIn, ACBindings.Internal.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.AddObjectTransactInfo*, ACBindings.Internal.Cache_Pack_t*, int>)0x00673660)(ref this, pTrIn, pack_buf);

    /// <summary>Updates an existing B‑tree node entry using the supplied transaction information, reallocating cached data and adjusting disk blocks accordingly.
    /// <code>Offset: 0x006737D0
    /// int __thiscall BTree::UpdateObjectExec(BTree*,const UpdateObjectTransactInfo*,Cache_Pack_t*)</code>
    /// </summary>
    /// <param name="pTrIn">Transaction details identifying the target entry, its index within the node, new entry data and previous block offset.</param>
    /// <param name="pack_buf">Cache buffer that holds the updated entry data; used when the entry size is not a special marker.</param>
    /// <returns>Zero on success. Returns -1 if the target node cannot be located, or the error code returned by the block allocator during data storage or block deletion.</returns>
    public int UpdateObjectExec(ACBindings.Internal.UpdateObjectTransactInfo* pTrIn, ACBindings.Internal.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.UpdateObjectTransactInfo*, ACBindings.Internal.Cache_Pack_t*, int>)0x006737D0)(ref this, pTrIn, pack_buf);

    /// <summary>Merges a B‑tree node with its right sibling into the left sibling during delete rebalancing, moving the separator key down and consolidating all entries.
    /// <code>Offset: 0x00673960
    /// int __thiscall BTree::MergeNodesExec(BTree*,const MergeNodesTransactInfo*)</code>
    /// </summary>
    /// <param name="pTrIn">Specifies the target node offset, left and right sibling offsets, index of the separating entry, and expected number of entries in the node to merge.</param>
    /// <returns>Zero on success (currently always returned).</returns>
    public int MergeNodesExec(ACBindings.Internal.MergeNodesTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.MergeNodesTransactInfo*, int>)0x00673960)(ref this, pTrIn);

    /// <summary>Locates the smallest GID identifier in the sub‑tree rooted at a3 and writes it into the integer pointed to by a2.
    /// <code>Offset: 0x00673BC0
    /// unsigned int* __thiscall BTree::FindMin(BTree*,unsigned int*,BTMemNode*)</code>
    /// </summary>
    /// <param name="a2">Reference where the minimum GID id will be stored.</param>
    /// <param name="a3">Root node of the sub‑tree to search for the minimal entry.</param>
    /// <returns>Pointer to the unsigned int that now contains the found minimum GID id.</returns>
    public uint* FindMin(uint* a2, ACBindings.Internal.BTMemNode* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, uint*, ACBindings.Internal.BTMemNode*, uint*>)0x00673BC0)(ref this, a2, a3);

    /// <summary>Finds the maximum key within the subtree rooted at the specified node and stores it in the provided integer pointer.
    /// <code>Offset: 0x00673C00
    /// int* __thiscall BTree::FindMax(BTree*,int*,BTMemNode*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer where the maximum value will be written.</param>
    /// <param name="a3">Root of the subtree to search for the maximum key.</param>
    /// <returns>Returns the same pointer passed as a2, pointing to the stored maximum value.</returns>
    public int* FindMax(int* a2, ACBindings.Internal.BTMemNode* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int*, ACBindings.Internal.BTMemNode*, int*>)0x00673C00)(ref this, a2, a3);

    /// <summary>Removes a leaf entry from the B‑tree identified by the supplied transaction information, updates node structure and frees related disk blocks.
    /// <code>Offset: 0x00673C50
    /// int __thiscall BTree::DeleteLeafExec(BTree*,const DeleteLeafTransactInfo*)</code>
    /// </summary>
    /// <param name="pTrIn">Transaction data specifying the target node offset, index within that node, and object ID of the entry to delete.</param>
    /// <returns>-1 if the specified node cannot be found; 0 if the entry’s ID does not match; otherwise returns the result of BTree::UpdateNode indicating success or failure.</returns>
    public int DeleteLeafExec(ACBindings.Internal.DeleteLeafTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.DeleteLeafTransactInfo*, int>)0x00673C50)(ref this, pTrIn);

    /// <summary>Deletes an internal B‑tree entry by replacing it with data from a donor node and updating any affected nodes.
    /// <code>Offset: 0x00673D00
    /// int __thiscall BTree::DeleteInternalExec(BTree*,const DeleteInternalTransactInfo*)</code>
    /// </summary>
    /// <param name="pTrIn">Transaction information describing the target and donor offsets, indices, and identifiers used to locate the entries within the tree.</param>
    /// <returns>-1 if either the target or donor node cannot be found; otherwise returns the result of BTree::UpdateNode after modifying the involved nodes (typically 0 on success).</returns>
    public int DeleteInternalExec(ACBindings.Internal.DeleteInternalTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.DeleteInternalTransactInfo*, int>)0x00673D00)(ref this, pTrIn);

    /// <summary>Perform a rotation of a B‑tree entry based on the supplied transaction information, adjusting parent and sibling nodes to maintain tree balance.
    /// <code>Offset: 0x00673E20
    /// int __thiscall BTree::RotateEntryExec(BTree*,const RotateEntryTransactInfo*)</code>
    /// </summary>
    /// <param name="pTrIn">Transaction details for the rotation, including node offsets, index, sibling counts, and direction (left or right).</param>
    /// <returns>Status code; negative values indicate failure (currently always returns -1).</returns>
    public int RotateEntryExec(ACBindings.Internal.RotateEntryTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.RotateEntryTransactInfo*, int>)0x00673E20)(ref this, pTrIn);

    /// <summary>Restores the B‑tree state by applying a disk transaction described by pTrIn. The function interprets the transaction type and executes the corresponding in‑memory operation (insert, delete leaf/internal, merge nodes, update object, split node or rotate entry).
    /// <code>Offset: 0x00673FC0
    /// int __thiscall BTree::RecoverTransaction(BTree*,const DiskTransactInfo*)</code>
    /// </summary>
    /// <param name="pTrIn">Transaction information to recover, including its type and associated data.</param>
    /// <returns>Zero on success; a negative error code if the transaction type is unsupported or an execution fails.</returns>
    public int RecoverTransaction(ACBindings.Internal.DiskTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.DiskTransactInfo*, int>)0x00673FC0)(ref this, pTrIn);

    /// <summary>Searches for an entry with the specified key in the B-tree starting from a given node. If the key is located, returns the address of its data within the node and stores the node pointer in the output parameter; otherwise returns zero.
    /// <code>Offset: 0x00674160
    /// int __thiscall BTree::Search(BTree*,BTMemNode*,unsigned int,BTMemNode**)</code>
    /// </summary>
    /// <param name="a2">The node to begin searching from; typically the root or a known ancestor.</param>
    /// <param name="a3">The key value identifying the entry to locate.</param>
    /// <param name="a4">Pointer that receives the node containing the found entry, if any.</param>
    /// <returns>Zero on failure; otherwise the address of the entry data within the located node.</returns>
    public int Search(ACBindings.Internal.BTMemNode* a2, uint a3, ACBindings.Internal.BTMemNode** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, uint, ACBindings.Internal.BTMemNode**, int>)0x00674160)(ref this, a2, a3, a4);

    /// <summary>Executes a node split transaction in the B-tree, preparing and committing metadata changes atomically.
    /// <code>Offset: 0x006741E0
    /// int __thiscall BTree::SplitNodeTrans(BTree*,BTMemNode*,int,BTMemNode*)</code>
    /// </summary>
    /// <param name="pParent">The parent node that contains the entry being split.</param>
    /// <param name="splitIndex">Position within the parent where the split occurs.</param>
    /// <param name="pNode">The node to be split (currently unused but retained for interface consistency).</param>
    /// <returns>Zero on success, non‑zero error code if transaction commit fails.</returns>
    public int SplitNodeTrans(ACBindings.Internal.BTMemNode* pParent, int splitIndex, ACBindings.Internal.BTMemNode* pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, int, ACBindings.Internal.BTMemNode*, int>)0x006741E0)(ref this, pParent, splitIndex, pNode);

    /// <summary>Inserts a new entry into the specified B-tree node within a transactional context, preserving state to enable commit or rollback.
    /// <code>Offset: 0x00674250
    /// int __thiscall BTree::InsertEntryTrans(BTree*,BTMemNode*,BTEntry*,Cache_Pack_t*)</code>
    /// </summary>
    /// <param name="pNode">The in-memory node where the entry will be added.</param>
    /// <param name="entry">Pointer to the entry data to insert.</param>
    /// <param name="pack_buf">Cache buffer used for packing disk I/O during the transaction.</param>
    /// <returns>Zero on success; non‑zero error code if the transaction fails.</returns>
    public int InsertEntryTrans(ACBindings.Internal.BTMemNode* pNode, ACBindings.Internal.BTEntry* entry, ACBindings.Internal.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, int>)0x00674250)(ref this, pNode, entry, pack_buf);

    /// <summary>Records a transaction for updating a B‑tree node entry, executes the update, and commits the change using the block allocator.
    /// <code>Offset: 0x006742C0
    /// int __thiscall BTree::Update_Data_Trans(BTree*,BTMemNode*,BTEntry*,Cache_Pack_t*)</code>
    /// </summary>
    /// <param name="pNode">The memory node containing the entry that will be updated.</param>
    /// <param name="entry">The new entry data to write into the node.</param>
    /// <param name="pack_buf">Cache buffer used during the update operation.</param>
    /// <returns>Integer status returned by CLBlockAllocator::ClearTransaction, indicating whether the transaction commit succeeded.</returns>
    public int Update_Data_Trans(ACBindings.Internal.BTMemNode* pNode, ACBindings.Internal.BTEntry* entry, ACBindings.Internal.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, int>)0x006742C0)(ref this, pNode, entry, pack_buf);

    /// <summary>Descends from the root node to the appropriate leaf, splitting full nodes along the way, updates the entry’s offset and size from the provided cache buffer, and inserts the entry transactionally into the B‑tree.
    /// <code>Offset: 0x00674350
    /// int __thiscall BTree::DescendToAdd(BTree*,BTEntry*,Cache_Pack_t*)</code>
    /// </summary>
    /// <param name="entry">The BTEntry to be inserted; its fields are updated before insertion.</param>
    /// <param name="pack_buf">Cache buffer containing data for the entry; used to compute the entry’s size.</param>
    /// <returns>Result code from InsertEntryTrans indicating success or failure of the insertion.</returns>
    public int DescendToAdd(ACBindings.Internal.BTEntry* entry, ACBindings.Internal.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, int>)0x00674350)(ref this, entry, pack_buf);

    /// <summary>Merges the contents of two child nodes into a parent node while recording the operation in a transaction for durability.
    /// <code>Offset: 0x00674500
    /// int __thiscall BTree::MergeNodesTrans(BTree*,BTMemNode*,BTMemNode*,BTMemNode*,int)</code>
    /// </summary>
    /// <param name="pNode">Parent node that will receive merged entries.</param>
    /// <param name="pLeftKid">Left child node to merge from.</param>
    /// <param name="pRightKid">Right child node to merge from.</param>
    /// <param name="index">Index within the parent node where the left and right children are located.</param>
    /// <returns>Zero on success; non‑zero error code otherwise.</returns>
    public int MergeNodesTrans(ACBindings.Internal.BTMemNode* pNode, ACBindings.Internal.BTMemNode* pLeftKid, ACBindings.Internal.BTMemNode* pRightKid, int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, ACBindings.Internal.BTMemNode*, ACBindings.Internal.BTMemNode*, int, int>)0x00674500)(ref this, pNode, pLeftKid, pRightKid, index);

    /// <summary>Starts a transactional deletion of the leaf entry at the specified index within a memory node, records the operation, executes the removal, and finalizes the transaction.
    /// <code>Offset: 0x00674580
    /// int __thiscall BTree::DeleteLeafTrans(BTree*,BTMemNode*,int)</code>
    /// </summary>
    /// <param name="pNode">Memory node that contains the target leaf entry.</param>
    /// <param name="index">Position of the leaf entry in the node's entry array to delete.</param>
    /// <returns>Zero on success; otherwise a non‑zero error code from CLBlockAllocator::ClearTransaction.</returns>
    public int DeleteLeafTrans(ACBindings.Internal.BTMemNode* pNode, int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, int, int>)0x00674580)(ref this, pNode, index);

    /// <summary>Deletes an internal B‑tree node by recording a transaction that transfers data from a donor node to a target node, then executes and clears the transaction.
    /// <code>Offset: 0x006745E0
    /// int __thiscall BTree::DeleteInternalTrans(BTree*,unsigned int,unsigned int,int,int,int,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the target node to delete.</param>
    /// <param name="a3">Identifier of the donor node providing replacement data.</param>
    /// <param name="a4">Offset within the target node where the deletion occurs.</param>
    /// <param name="a5">Offset within the donor node for the transfer operation.</param>
    /// <param name="a6">Index of the target node in the B‑tree’s internal structure.</param>
    /// <param name="a7">Index of the donor node in the B‑tree.</param>
    /// <returns>Zero on success; otherwise a non‑zero error code from ClearTransaction.</returns>
    public int DeleteInternalTrans(uint a2, uint a3, int a4, int a5, int a6, int a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, uint, uint, int, int, int, int, int>)0x006745E0)(ref this, a2, a3, a4, a5, a6, a7);

    /// <summary>Rotates an entry between a parent B‑tree node and one of its siblings while recording the change as a transaction that can be committed or rolled back.
    /// <code>Offset: 0x00674650
    /// int __thiscall BTree::RotateEntryTrans(BTree*,BTMemNode*,int,int,int,bool)</code>
    /// </summary>
    /// <param name="pParent">The parent memory node containing the entry to rotate.</param>
    /// <param name="index">Zero‑based index of the entry within the parent node that will be rotated.</param>
    /// <param name="nodeEntryCount">Number of entries currently stored in the parent node before rotation.</param>
    /// <param name="siblingEntryCount">Number of entries present in the sibling node involved in the rotation.</param>
    /// <param name="fLeftSibling">True if the sibling is the left child; false if it is the right child.</param>
    /// <returns>An integer status code returned by the block allocator after clearing the transaction, indicating whether the operation succeeded or failed.</returns>
    public int RotateEntryTrans(ACBindings.Internal.BTMemNode* pParent, int index, int nodeEntryCount, int siblingEntryCount, byte fLeftSibling) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, int, int, int, byte, int>)0x00674650)(ref this, pParent, index, nodeEntryCount, siblingEntryCount, fLeftSibling);

    /// <summary>Searches a BTree for a node with the specified identifier, returning zero when not found or the tree is empty.
    /// <code>Offset: 0x006747A0
    /// int __thiscall BTree::Lookup(BTree*,unsigned int,BTMemNode**)</code>
    /// </summary>
    /// <param name="a2">Identifier of the node to locate.</param>
    /// <param name="a3">Receives pointer to the found BTMemNode; left unchanged if not found.</param>
    /// <returns>Non‑zero value returned by Search on success, zero otherwise.</returns>
    public int Lookup(uint a2, ACBindings.Internal.BTMemNode** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, uint, ACBindings.Internal.BTMemNode**, int>)0x006747A0)(ref this, a2, a3);

    /// <summary>Searches the B‑tree from a given parent node for the specified key value, performing any necessary rotations or merges to preserve tree invariants during descent. On success, returns 0 and writes the node containing the key and its entry index through the output parameters; otherwise returns –1 with outputs cleared.
    /// <code>Offset: 0x006747D0
    /// int __thiscall BTree::DescendToDelete(BTree*,BTMemNode*,unsigned int,BTMemNode**,int*)</code>
    /// </summary>
    /// <param name="pParent">The node from which the search begins.</param>
    /// <param name="a3">The key value to locate within the tree.</param>
    /// <param name="a4">Output parameter that receives a pointer to the node containing the found key, or null if not found.</param>
    /// <param name="a5">Output parameter that receives the index of the key within its node, or –1 if not found.</param>
    /// <returns>Zero if the key is located; –1 otherwise.</returns>
    public int DescendToDelete(ACBindings.Internal.BTMemNode* pParent, uint a3, ACBindings.Internal.BTMemNode** a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, ACBindings.Internal.BTMemNode*, uint, ACBindings.Internal.BTMemNode**, int*, int>)0x006747D0)(ref this, pParent, a3, a4, a5);

    /// <summary>Deletes the entry with key <paramref name="a2"/> from the B‑tree, adjusting nodes to preserve tree balance through splits, merges, or rotations.
    /// <code>Offset: 0x00674950
    /// int __thiscall BTree::Delete(int,unsigned int,BTMemNode*)</code>
    /// </summary>
    /// <param name="a2">The key value identifying the item to remove.</param>
    /// <param name="pLeftKid">Pointer to the left child node involved in the deletion path; may be null when starting at the root.</param>
    /// <returns>Zero on success; non‑zero error code if the key cannot be found or a tree operation fails.</returns>
    public int Delete(uint a2, ACBindings.Internal.BTMemNode* pLeftKid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, uint, ACBindings.Internal.BTMemNode*, int>)0x00674950)(ref this, a2, pLeftKid);

    /// <summary>Removes a node identified by the given key from the BTree, indicating success or failure.
    /// <code>Offset: 0x00674AF0
    /// bool __thiscall BTree::Remove(BTMemNode*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The unsigned integer key of the entry to remove.</param>
    /// <returns>True if removal succeeded; otherwise false.</returns>
    public byte Remove(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, uint, byte>)0x00674AF0)(ref this, a2);

    /// <summary>Attempts to remove the oldest entry from the B‑tree by consulting the LRU manager; succeeds only when a valid record exists and is deleted without error.
    /// <code>Offset: 0x00674B70
    /// bool __thiscall BTree::Try_Delete_Oldest(BTree*)</code>
    /// </summary>
    /// <returns>true if an old record was removed successfully; otherwise false.</returns>
    public byte Try_Delete_Oldest() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, byte>)0x00674B70)(ref this);

    /// <summary>Collects BTEntry identifiers within the inclusive interval [a4, a5] from the subtree rooted at node a3 and appends them to the SmartArray pointed to by a2.
    /// <code>Offset: 0x00674BC0
    /// _DWORD* __thiscall BTree::Build_Id_List(BTree*,_DWORD*,int,signed int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">SmartArray where qualifying entries are appended.</param>
    /// <param name="a3">Pointer to the current tree node being inspected.</param>
    /// <param name="a4">Lower bound of identifier range (inclusive).</param>
    /// <param name="a5">Upper bound of identifier range (inclusive).</param>
    /// <returns>Internal pointer that may represent the updated SmartArray or a continuation state; not intended for direct external use.</returns>
    public int* Build_Id_List(int* a2, int a3, int a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int*, int, int, int*, int*>)0x00674BC0)(ref this, a2, a3, a4, a5);

    /// <summary>Collects BTEntry records from a BTree subtree into a dynamic array, expanding the buffer as necessary.
    /// <code>Offset: 0x00674CB0
    /// int __thiscall BTree::Build_Id_List(BTree*,_DWORD*,BTMemNode*)</code>
    /// </summary>
    /// <param name="a2">Array descriptor containing: element 0 – pointer to the data buffer; element 1 – current capacity masked with 0x7FFFFFFF; element 2 – number of entries already stored.</param>
    /// <param name="a3">The BTree node that serves as the starting point for traversal.</param>
    /// <returns>Zero when the supplied node has no child nodes; otherwise a positive integer derived from the node’s NumEntries value, typically equal to NumEntries + 1 after processing its children.</returns>
    public int Build_Id_List(int* a2, ACBindings.Internal.BTMemNode* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int*, ACBindings.Internal.BTMemNode*, int>)0x00674CB0)(ref this, a2, a3);

    /// <summary>Obtains a list of identifiers from the BTree's in‑memory nodes, filling the supplied buffer when the root contains entries.
    /// <code>Offset: 0x00674DC0
    /// char __thiscall BTree::Get_Id_List(BTree*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an array that will receive the node identifiers; must be large enough for all entries.</param>
    /// <returns>1 if identifiers were written successfully; 0 if the tree has no entries.</returns>
    public sbyte Get_Id_List(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int*, sbyte>)0x00674DC0)(ref this, a2);

    /// <summary>Builds an identifier list from the tree within the specified range and stores it in the supplied buffer.
    /// <code>Offset: 0x00674DE0
    /// bool __thiscall BTree::Get_Id_List_Range(BTree*,_DWORD*,signed int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Output array that receives the count of identifiers at index 2 and the identifiers starting at earlier indices.</param>
    /// <param name="a3">Maximum number of identifiers to retrieve or the size of the requested range.</param>
    /// <param name="a4">Additional context used by the build routine (e.g., bounds or auxiliary data).</param>
    /// <returns>True if the list contains one or more identifiers; otherwise, false.</returns>
    public byte Get_Id_List_Range(int* a2, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BTree, int*, int, int*, byte>)0x00674DE0)(ref this, a2, a3, a4);
}

