namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0051C470
    /// void __thiscall ObjCollisionProfile::SetCreature(ObjCollisionProfile*,const int)</code>
    /// </summary>
    public void SetCreature(int isCreature) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C470)(ref this, isCreature);

    /// <summary>
    /// <code>Offset: 0x0051C490
    /// void __thiscall ObjCollisionProfile::SetPlayer(ObjCollisionProfile*,const int)</code>
    /// </summary>
    public void SetPlayer(int isPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C490)(ref this, isPlayer);

    /// <summary>
    /// <code>Offset: 0x0051C4B0
    /// void __thiscall ObjCollisionProfile::SetDoor(ObjCollisionProfile*,const int)</code>
    /// </summary>
    public void SetDoor(int isDoor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C4B0)(ref this, isDoor);

    /// <summary>
    /// <code>Offset: 0x0051C4D0
    /// void __thiscall ObjCollisionProfile::SetAttackable(ObjCollisionProfile*,const int)</code>
    /// </summary>
    public void SetAttackable(int attackable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C4D0)(ref this, attackable);

    /// <summary>
    /// <code>Offset: 0x0051C4F0
    /// void __thiscall ObjCollisionProfile::SetMissile(ObjCollisionProfile*,const int)</code>
    /// </summary>
    public void SetMissile(int isMissile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C4F0)(ref this, isMissile);

    /// <summary>
    /// <code>Offset: 0x0051C510
    /// void __thiscall ObjCollisionProfile::SetInContact(ObjCollisionProfile*,const int)</code>
    /// </summary>
    public void SetInContact(int hasContact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C510)(ref this, hasContact);

    /// <summary>
    /// <code>Offset: 0x0051C530
    /// void __thiscall ObjCollisionProfile::SetMeInContact(ObjCollisionProfile*,const int)</code>
    /// </summary>
    public void SetMeInContact(int hasContact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, int, void>)0x0051C530)(ref this, hasContact);

    /// <summary>
    /// <code>Offset: 0x0051C560
    /// void __thiscall ObjCollisionProfile::ObjCollisionProfile(ObjCollisionProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjCollisionProfile, void>)0x0051C560)(ref this);
}

