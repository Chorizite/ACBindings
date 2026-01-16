namespace ACBindings.Internal;


/// <summary>Encapsulates a portal‑linking spell, holding a Spell instance to provide specialized behavior for creating or activating portals.</summary>
public unsafe struct PortalLinkSpell
{
    // Base Classes
    public ACBindings.Internal.Spell BaseClass_Spell; // ACBindings.Internal.Spell

    // Child Types
    public unsafe struct PortalLinkSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, void> PortalLinkSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalLinkSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods
}

