namespace ACBindings.Internal;


/// <summary>Defines a weapon’s statistical profile for gameplay calculations, encapsulating damage characteristics, performance parameters, and movement constraints.</summary>
public unsafe struct WeaponProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct WeaponProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WeaponProfile*, void> WeaponProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WeaponProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WeaponProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WeaponProfile*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>Initializes a weapon profile with default values and assigns the appropriate vtable.
    /// <code>Offset: 0x005B7370
    /// void __thiscall WeaponProfile::WeaponProfile(WeaponProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WeaponProfile, void>)0x005B7370)(ref this);

    /// <summary>Serializes a weapon profile into a contiguous memory block, advancing the destination pointer and aligning it afterward.
    /// <code>Offset: 0x005B73C0
    /// unsigned int __thiscall WeaponProfile::Pack(WeaponProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of the buffer where serialized data will be written; the pointer is moved past the written block.</param>
    /// <param name="size">Number of bytes available in the buffer; serialization occurs only when at least 60 bytes are present.</param>
    /// <returns>The number of bytes written (always 60).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WeaponProfile, void**, uint, uint>)0x005B73C0)(ref this, addr, size);

    /// <summary>Unpacks a WeaponProfile from the provided buffer, advancing the read pointer and aligning it after reading all fields.
    /// <code>Offset: 0x005B7470
    /// int __thiscall WeaponProfile::UnPack(WeaponProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position in the buffer; updated to point past the serialized data.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be at least 0x3C for a successful unpack.</param>
    /// <returns>1 if unpacking succeeds, otherwise 0 when the buffer is too small.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WeaponProfile, void**, uint, int>)0x005B7470)(ref this, addr, size);
}

