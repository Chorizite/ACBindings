namespace ACBindings;

// Spell
public unsafe struct Spell
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // Spell_vtbl
    public unsafe struct Spell_vtbl
    {
        // Members
        public System.IntPtr Spell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr SetEqual; // function pointer
        public System.IntPtr InqDuration; // function pointer
        public System.IntPtr SetDuration; // function pointer
        public System.IntPtr IsEnchantmentSpell; // function pointer
        public System.IntPtr IsBoostSpell; // function pointer
        public System.IntPtr IsProjectileSpell; // function pointer
        public System.IntPtr IsTransferSpell; // function pointer
        public System.IntPtr IsDispelSpell; // function pointer
        public System.IntPtr IsFellowshipSpell; // function pointer
        public System.IntPtr BuildEnchantment; // function pointer
        public System.IntPtr AffectsHealth; // function pointer
        public System.IntPtr AffectsStamina; // function pointer
        public System.IntPtr AffectsMana; // function pointer
        public System.IntPtr pack_size; // function pointer

        // Methods
    }

    // Members
    public uint _spell_id;

    // Generated Constructor
    public Spell() {
        _ConstructorInternal();
    }

    // Methods
    // Spell* __cdecl Spell::BuildSpell(const SpellType)
    public static ACBindings.Spell* BuildSpell(ACBindings.SpellType sp_type) => ((delegate* unmanaged[Cdecl]<ACBindings.SpellType, ACBindings.Spell*>)0x00599540)(sp_type);
    // void __thiscall Spell::Spell(Spell*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Spell, void>)0x00599820)(ref this);
    // long double __thiscall Spell::InqDuration(Spell*)
    public double InqDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Spell, double>)0x00599830)(ref this);
    // unsigned int __thiscall Spell::Pack(Spell*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Spell, void**, uint, uint>)0x00599840)(ref this, addr, size);
    // int __thiscall Spell::UnPack(Spell*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Spell, void**, uint, int>)0x00599860)(ref this, addr, size);
}

