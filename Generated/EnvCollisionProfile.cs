namespace ACBindings;

// EnvCollisionProfile
public unsafe struct EnvCollisionProfile
{
    // Members
    public ACBindings.AC1Legacy.Vector3 velocity;
    public uint _bitfield;

    // Generated Constructor
    public EnvCollisionProfile() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall EnvCollisionProfile::SetMeInContact(EnvCollisionProfile*,const int)
    public void SetMeInContact(int hasContact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnvCollisionProfile, int, void>)0x0051C450)(ref this, hasContact);
    // void __thiscall EnvCollisionProfile::EnvCollisionProfile(EnvCollisionProfile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnvCollisionProfile, void>)0x0051C550)(ref this);
}

