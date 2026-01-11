namespace ACBindings.Internal;

public unsafe struct EnvCollisionProfile
{
    // Members
    public ACBindings.Internal.AC1Legacy.Vector3 velocity;
    public uint _bitfield;

    // Generated Constructor
    public EnvCollisionProfile() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0051C450
    /// void __thiscall EnvCollisionProfile::SetMeInContact(EnvCollisionProfile*,const int)</code>
    /// </summary>
    public void SetMeInContact(int hasContact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnvCollisionProfile, int, void>)0x0051C450)(ref this, hasContact);

    /// <summary>
    /// <code>Offset: 0x0051C550
    /// void __thiscall EnvCollisionProfile::EnvCollisionProfile(EnvCollisionProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnvCollisionProfile, void>)0x0051C550)(ref this);
}

