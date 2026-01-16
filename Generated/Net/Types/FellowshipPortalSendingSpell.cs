namespace ACBindings.Internal;


/// <summary>Encapsulates a spell transmitted via the fellowship portal, extending PortalSendingSpell behavior.</summary>
public unsafe struct FellowshipPortalSendingSpell
{
    // Base Classes
    public ACBindings.Internal.PortalSendingSpell BaseClass_PortalSendingSpell; // ACBindings.Internal.PortalSendingSpell

    // Child Types
    public unsafe struct FellowshipPortalSendingSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, void> FellowshipPortalSendingSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipPortalSendingSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods
}

