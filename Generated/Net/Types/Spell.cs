namespace ACBindings.Internal;

public unsafe struct Spell
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Spell_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, void> Spell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, double> InqDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, double, int> SetDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> IsEnchantmentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> IsBoostSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> IsProjectileSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> IsTransferSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> IsDispelSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> IsFellowshipSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> AffectsHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> AffectsStamina; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> AffectsMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, uint> pack_size; // function pointer

        // Methods
    }

    // Members
    public uint _spell_id;

    // Generated Constructor
    public Spell() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00599540
    /// Spell* __cdecl Spell::BuildSpell(const SpellType)</code>
    /// </summary>
    public static ACBindings.Internal.Spell* BuildSpell(ACBindings.Internal.SpellType sp_type) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SpellType, ACBindings.Internal.Spell*>)0x00599540)(sp_type);

    /// <summary>
    /// <code>Offset: 0x00599820
    /// void __thiscall Spell::Spell(Spell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Spell, void>)0x00599820)(ref this);

    /// <summary>
    /// <code>Offset: 0x00599830
    /// long double __thiscall Spell::InqDuration(Spell*)</code>
    /// </summary>
    public double InqDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Spell, double>)0x00599830)(ref this);

    /// <summary>
    /// <code>Offset: 0x00599840
    /// unsigned int __thiscall Spell::Pack(Spell*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Spell, void**, uint, uint>)0x00599840)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00599860
    /// int __thiscall Spell::UnPack(Spell*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Spell, void**, uint, int>)0x00599860)(ref this, addr, size);
}

