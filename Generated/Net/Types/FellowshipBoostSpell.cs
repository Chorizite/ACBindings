namespace ACBindings.Internal;


/// <summary>Represents a boost spell tailored for use within fellowship systems, encapsulating the standard BoostSpell data structure.</summary>
public unsafe struct FellowshipBoostSpell
{
    // Base Classes
    public ACBindings.Internal.BoostSpell BaseClass_BoostSpell; // ACBindings.Internal.BoostSpell

    // Child Types
    public unsafe struct FellowshipBoostSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, void> FellowshipBoostSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipBoostSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Generated Constructor
    public FellowshipBoostSpell() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new FellowshipBoostSpell instance, setting up its base BoostSpell and Spell properties.
    /// <code>Offset: 0x00599D10
    /// void __thiscall FellowshipBoostSpell::FellowshipBoostSpell(FellowshipBoostSpell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FellowshipBoostSpell, void>)0x00599D10)(ref this);
}

