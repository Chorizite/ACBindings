namespace ACBindings;

// PhysicsTimeStamp
public enum PhysicsTimeStamp : uint
{
    POSITION_TS = 0x0,
    MOVEMENT_TS = 0x1,
    STATE_TS = 0x2,
    VECTOR_TS = 0x3,
    TELEPORT_TS = 0x4,
    SERVER_CONTROLLED_MOVE_TS = 0x5,
    FORCE_POSITION_TS = 0x6,
    OBJDESC_TS = 0x7,
    INSTANCE_TS = 0x8,
    NUM_PHYSICS_TS = 0x9,
    FORCE_PhysicsTimeStamp_32_BIT = 0x7FFFFFFF
}

