namespace ACBindings.Internal;

// ObjCollisionProfile_Bitfield
public enum ObjCollisionProfile_Bitfield : uint
{
    Undef_OCPB = 0x0,
    Creature_OCPB = 0x1,
    Player_OCPB = 0x2,
    Attackable_OCPB = 0x4,
    Missile_OCPB = 0x8,
    Contact_OCPB = 0x10,
    MyContact_OCPB = 0x20,
    Door_OCPB = 0x40,
    Cloaked_OCPB = 0x80,
    FORCE_ObjCollisionProfile_Bitfield_32_BIT = 0x7FFFFFFF
}

