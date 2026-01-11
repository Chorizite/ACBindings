namespace ACBindings.Internal;

public unsafe struct WeaponProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct WeaponProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WeaponProfile*, void> WeaponProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WeaponProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WeaponProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WeaponProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.DAMAGE_TYPE damage_type;
    public uint weapon_skill;
    public int weapon_time;
    public int weapon_damage;
    public double damage_variance;
    public double damage_mod;
    public double weapon_length;
    public double max_velocity;
    public double weapon_offense;
    public int max_velocity_estimated;

    // Generated Constructor
    public WeaponProfile() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005B7370
    /// void __thiscall WeaponProfile::WeaponProfile(WeaponProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WeaponProfile, void>)0x005B7370)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B73C0
    /// unsigned int __thiscall WeaponProfile::Pack(WeaponProfile*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WeaponProfile, void**, uint, uint>)0x005B73C0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005B7470
    /// int __thiscall WeaponProfile::UnPack(WeaponProfile*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WeaponProfile, void**, uint, int>)0x005B7470)(ref this, addr, size);
}

