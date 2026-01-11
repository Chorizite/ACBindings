namespace ACBindings.Internal;

// DiskTransactType
public enum DiskTransactType : byte
{
    NO_TRANS = 0x0,
    ADD_OBJ_TRANS = 0x1,
    DELETE_LEAF_TRANS = 0x2,
    DELETE_INTERNAL_TRANS = 0x3,
    MERGE_NODES_TRANS = 0x4,
    UPDATE_OBJ_TRANS = 0x5,
    SPLIT_NODE_TRANS = 0x6,
    ROTATE_TRANS = 0x7,
    LRU_EXPAND_TRANS = 0x8,
    LRU_DELETE_TRANS = 0x9,
    NUM_TRANS_TYPES = 0xA
}

