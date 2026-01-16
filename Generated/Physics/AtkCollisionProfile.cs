namespace ACBindings.Internal;


/// <summary>Defines a collision profile for an attack, identifying the target part, unique id, and spatial location within the game world.</summary>
public unsafe struct AtkCollisionProfile
{
    // Members
    public int part;
    public uint id;
    public uint location;

    // Generated Constructor
    public AtkCollisionProfile() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new AtkCollisionProfile with default values: part set to –1, id and location set to 0.
    /// <code>Offset: 0x0051C430
    /// void __thiscall AtkCollisionProfile::AtkCollisionProfile(AtkCollisionProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AtkCollisionProfile, void>)0x0051C430)(ref this);
}

