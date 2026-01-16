namespace ACBindings.Internal;


/// <summary>Represents the collision profile of an object in the game world, storing its identifier, velocity, world‑collision ID, item type and a bitfield that encodes flags such as attackability, creature status, door, missile, player and contact states.</summary>
public unsafe struct ObjCollisionProfile
{
    // Members
    public uint id;
    public ACBindings.Internal.AC1Legacy.Vector3 velocity;
    public ACBindings.Internal.IDClass____tagDataID wcid;
    public ACBindings.Internal.ITEM_TYPE itemType;
    public uint _bitfield;

    // Generated Constructor
    public ObjCollisionProfile() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Sets or clears the creature flag in the collision profile’s bitfield.
    /// <code>Offset: 0x0051C470
    /// void __thiscall ObjCollisionProfile::SetCreature(ObjCollisionProfile*,const int)</code>
    /// </summary>
    /// <param name="isCreature">Non‑zero to mark the object as a creature; zero clears the flag.</param>
    public void SetCreature(int isCreature) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C470)(ref this, isCreature);

    /// <summary>Sets or clears the player flag in this object's bitfield based on the supplied value.
    /// <code>Offset: 0x0051C490
    /// void __thiscall ObjCollisionProfile::SetPlayer(ObjCollisionProfile*,const int)</code>
    /// </summary>
    /// <param name="isPlayer">Non‑zero to mark as a player, zero to clear the flag.</param>
    public void SetPlayer(int isPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C490)(ref this, isPlayer);

    /// <summary>Marks the collision profile as a door when isDoor is nonzero, otherwise clears the door flag.
    /// <code>Offset: 0x0051C4B0
    /// void __thiscall ObjCollisionProfile::SetDoor(ObjCollisionProfile*,const int)</code>
    /// </summary>
    /// <param name="isDoor">Non-zero to set door status; zero to clear it.</param>
    public void SetDoor(int isDoor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C4B0)(ref this, isDoor);

    /// <summary>Sets the object's attackability state within its collision profile.
    /// <code>Offset: 0x0051C4D0
    /// void __thiscall ObjCollisionProfile::SetAttackable(ObjCollisionProfile*,const int)</code>
    /// </summary>
    /// <param name="attackable">True to mark as attackable; false to clear the flag.</param>
    public void SetAttackable(int attackable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C4D0)(ref this, attackable);

    /// <summary>Marks the collision profile as a missile if isMissile is non‑zero, otherwise clears that flag.
    /// <code>Offset: 0x0051C4F0
    /// void __thiscall ObjCollisionProfile::SetMissile(ObjCollisionProfile*,const int)</code>
    /// </summary>
    /// <param name="isMissile">Non-zero to set the missile bit; zero to clear it.</param>
    public void SetMissile(int isMissile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C4F0)(ref this, isMissile);

    /// <summary>Marks the collision profile as being in contact or not based on the provided flag.
    /// <code>Offset: 0x0051C510
    /// void __thiscall ObjCollisionProfile::SetInContact(ObjCollisionProfile*,const int)</code>
    /// </summary>
    /// <param name="hasContact">True to set the in‑contact bit; false clears it.</param>
    public void SetInContact(int hasContact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C510)(ref this, hasContact);

    /// <summary>Updates the collision profile's contact status by setting or clearing the contact flag.
    /// <code>Offset: 0x0051C530
    /// void __thiscall ObjCollisionProfile::SetMeInContact(ObjCollisionProfile*,const int)</code>
    /// </summary>
    /// <param name="hasContact">Non‑zero to mark the object as in contact; zero clears the flag.</param>
    public void SetMeInContact(int hasContact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C530)(ref this, hasContact);

    /// <summary>Initializes an ObjCollisionProfile instance with default values for identifier, world collision ID, item type, and bitfield.
    /// <code>Offset: 0x0051C560
    /// void __thiscall ObjCollisionProfile::ObjCollisionProfile(ObjCollisionProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, void>)0x0051C560)(ref this);
}

