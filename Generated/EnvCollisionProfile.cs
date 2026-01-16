namespace ACBindings.Internal;


/// <summary>
/// Represents an environment collision profile, storing an object’s current velocity vector and a compact flag bitfield for tracking collision states such as contact status.
/// </summary>
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

    /// <summary>Sets the contact flag for this collision profile based on the supplied status.
    /// <code>Offset: 0x0051C450
    /// void __thiscall EnvCollisionProfile::SetMeInContact(EnvCollisionProfile*,const int)</code>
    /// </summary>
    /// <param name="hasContact">Non‑zero to mark as in contact; zero clears the flag.</param>
    public void SetMeInContact(int hasContact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnvCollisionProfile, int, void>)0x0051C450)(ref this, hasContact);

    /// <summary>Initializes a new EnvCollisionProfile by clearing the bitfield.
    /// <code>Offset: 0x0051C550
    /// void __thiscall EnvCollisionProfile::EnvCollisionProfile(EnvCollisionProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnvCollisionProfile, void>)0x0051C550)(ref this);
}

