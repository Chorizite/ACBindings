namespace ACBindings.Internal;

public unsafe struct PortalSendingSpell
{
    // Base Classes
    public ACBindings.Internal.Spell BaseClass_Spell; // ACBindings.Internal.Spell

    // Child Types
    public unsafe struct PortalSendingSpell_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, void> PortalSendingSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, double> InqDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, double, int> SetDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, int> IsEnchantmentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, int> IsBoostSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, int> IsProjectileSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, int> IsTransferSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, int> IsDispelSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, int> IsFellowshipSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, int> AffectsHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, int> AffectsStamina; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, int> AffectsMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSendingSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods
}

