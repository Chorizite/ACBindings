namespace ACBindings;

// ObjCollisionProfile
public unsafe struct ObjCollisionProfile
{
    // Members
    public uint id;
    public ACBindings.AC1Legacy.Vector3 velocity;
    public ACBindings.IDClass___tagDataID wcid;
    public ACBindings.ITEM_TYPE itemType;
    public uint _bitfield;

    // Generated Constructor
    public ObjCollisionProfile() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall ObjCollisionProfile::SetCreature(ObjCollisionProfile*,const int)
    public void SetCreature(int isCreature) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjCollisionProfile, int, void>)0x0051C470)(ref this, isCreature);
    // void __thiscall ObjCollisionProfile::SetPlayer(ObjCollisionProfile*,const int)
    public void SetPlayer(int isPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjCollisionProfile, int, void>)0x0051C490)(ref this, isPlayer);
    // void __thiscall ObjCollisionProfile::SetDoor(ObjCollisionProfile*,const int)
    public void SetDoor(int isDoor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjCollisionProfile, int, void>)0x0051C4B0)(ref this, isDoor);
    // void __thiscall ObjCollisionProfile::SetAttackable(ObjCollisionProfile*,const int)
    public void SetAttackable(int attackable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjCollisionProfile, int, void>)0x0051C4D0)(ref this, attackable);
    // void __thiscall ObjCollisionProfile::SetMissile(ObjCollisionProfile*,const int)
    public void SetMissile(int isMissile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjCollisionProfile, int, void>)0x0051C4F0)(ref this, isMissile);
    // void __thiscall ObjCollisionProfile::SetInContact(ObjCollisionProfile*,const int)
    public void SetInContact(int hasContact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjCollisionProfile, int, void>)0x0051C510)(ref this, hasContact);
    // void __thiscall ObjCollisionProfile::SetMeInContact(ObjCollisionProfile*,const int)
    public void SetMeInContact(int hasContact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjCollisionProfile, int, void>)0x0051C530)(ref this, hasContact);
    // void __thiscall ObjCollisionProfile::ObjCollisionProfile(ObjCollisionProfile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjCollisionProfile, void>)0x0051C560)(ref this);
}

