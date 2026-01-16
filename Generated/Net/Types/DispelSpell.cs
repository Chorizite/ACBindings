namespace ACBindings.Internal;


/// <summary>Represents a dispel spell, encapsulating a Spell instance that supplies serialization and runtime functionality.</summary>
/// <remarks>Struct is aligned on a 4‑byte boundary to match the application’s memory layout expectations.</remarks>
public unsafe struct DispelSpell
{
    // Base Classes
    public ACBindings.Internal.Spell BaseClass_Spell; // ACBindings.Internal.Spell

    // Child Types
    public unsafe struct DispelSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, void> DispelSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Packs the DispelSpell data into a memory buffer, delegating to its Spell base class when sufficient space is provided.
    /// <code>Offset: 0x00599960
    /// unsigned int __thiscall DispelSpell::Pack(DispelSpell*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer where serialized data will be written.</param>
    /// <param name="size">Maximum number of bytes available in the destination buffer.</param>
    /// <returns>Number of bytes required to serialize the object. If size is less than this value, no data is written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DispelSpell, void**, uint, uint>)0x00599960)(ref this, addr, size);

    /// <summary>Unpacks a DispelSpell object from serialized data, verifying that the supplied buffer is large enough and delegating to base class unpacking routines.
    /// <code>Offset: 0x00599990
    /// int __thiscall DispelSpell::UnPack(DispelSpell*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the memory block containing packed data to be read during unpacking.</param>
    /// <param name="size">Size of the provided data buffer in bytes; must be at least as large as required by the object's unpack logic.</param>
    /// <returns>Non‑zero if the unpack operation succeeded and the buffer contained valid data; zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DispelSpell, void**, uint, int>)0x00599990)(ref this, addr, size);

    /// <summary>Copies the data from a source spell into a destination spell within the dispel spell context.
    /// <code>Offset: 0x005999E0
    /// void __thiscall DispelSpell::SetEqual(DispelSpell*,const Spell*,const Spell*)</code>
    /// </summary>
    /// <param name="dst">The spell object to receive the copied values.</param>
    /// <param name="src">The spell object providing the values to copy.</param>
    public void SetEqual(ACBindings.Internal.Spell* dst, ACBindings.Internal.Spell* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DispelSpell, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void>)0x005999E0)(ref this, dst, src);
}

