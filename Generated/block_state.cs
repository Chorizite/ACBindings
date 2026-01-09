namespace ACBindings;

// block_state
public enum block_state : byte
{
    need_more = 0x0,
    block_done = 0x1,
    finish_started = 0x2,
    finish_done = 0x3
}

