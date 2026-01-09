namespace ACBindings;

// WeaponProfile
public unsafe struct WeaponProfile
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // WeaponProfile_vtbl
    public unsafe struct WeaponProfile_vtbl
    {
        // Members
        public System.IntPtr WeaponProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.DAMAGE_TYPE damage_type;
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
    // void __thiscall WeaponProfile::WeaponProfile(WeaponProfile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.WeaponProfile, void>)0x005B7370)(ref this);
    // unsigned int __thiscall WeaponProfile::Pack(WeaponProfile*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WeaponProfile, void**, uint, uint>)0x005B73C0)(ref this, addr, size);
    // int __thiscall WeaponProfile::UnPack(WeaponProfile*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WeaponProfile, void**, uint, int>)0x005B7470)(ref this, addr, size);
}

