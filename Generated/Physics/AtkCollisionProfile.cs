namespace ACBindings;

// AtkCollisionProfile
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
    // void __thiscall AtkCollisionProfile::AtkCollisionProfile(AtkCollisionProfile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AtkCollisionProfile, void>)0x0051C430)(ref this);
}

