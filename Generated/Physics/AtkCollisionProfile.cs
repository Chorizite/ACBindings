namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0051C430
    /// void __thiscall AtkCollisionProfile::AtkCollisionProfile(AtkCollisionProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AtkCollisionProfile, void>)0x0051C430)(ref this);
}

