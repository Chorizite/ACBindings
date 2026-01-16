namespace ACBindings.Internal;


/// <summary>Encapsulates the parameters for evaluating a skill’s power, storing four integer coefficients used in a weighted sum and two identifiers for the attributes applied during calculation. Provides methods for computing the value and serializing/deserializing the formula.</summary>
public unsafe struct SkillFormula
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SkillFormula_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillFormula*, void> SkillFormula_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillFormula*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillFormula*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillFormula*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _w;
    public uint _x;
    public uint _y;
    public uint _z;
    public uint _attr1;
    public uint _attr2;

    // Generated Constructor
    public SkillFormula(ACBindings.Internal.SkillFormula* that) {
        _ConstructorInternal(that);
    }

    // Methods

    /// <summary>Creates a SkillFormula by copying the values from an existing instance.
    /// <code>Offset: 0x00480710
    /// void __thiscall SkillFormula::SkillFormula(SkillFormula*,const SkillFormula*)</code>
    /// </summary>
    /// <param name="that">The source SkillFormula to copy data from.</param>
    public void _ConstructorInternal(ACBindings.Internal.SkillFormula* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillFormula, ACBindings.Internal.SkillFormula*, void>)0x00480710)(ref this, that);

    /// <summary>Computes a skill formula based on internal coefficients and two attribute values, storing the result in an output parameter.
    /// <code>Offset: 0x00592660
    /// int __thiscall SkillFormula::Calculate(SkillFormula*,unsigned int,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="attr1">First attribute used in the calculation.</param>
    /// <param name="attr2">Second attribute used in the calculation.</param>
    /// <param name="retval">Pointer to receive the computed unsigned integer value when successful.</param>
    /// <returns>Non‑zero if the formula was evaluated (denominator non‑zero); zero otherwise. The calculated value is written into *retval on success.</returns>
    public int Calculate(uint attr1, uint attr2, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillFormula, uint, uint, uint*, int>)0x00592660)(ref this, attr1, attr2, retval);

    /// <summary>Serializes the six unsigned integer fields of a SkillFormula into a contiguous block starting at *addr if the supplied buffer has at least 24 bytes, otherwise leaves the buffer untouched.
    /// <code>Offset: 0x005CB7E0
    /// unsigned int __thiscall SkillFormula::Pack(SkillFormula*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer location; updated to point past the written data only when packing occurs.</param>
    /// <param name="size">Number of bytes available in the destination buffer; packing proceeds only when this is at least 24.</param>
    /// <returns>Always 24, representing the number of bytes required for a fully packed SkillFormula regardless of whether any data was actually written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillFormula, void**, uint, uint>)0x005CB7E0)(ref this, addr, size);

    /// <summary>Extracts six unsigned integer values from a serialized buffer and advances the buffer pointer accordingly.
    /// <code>Offset: 0x005CB840
    /// int __thiscall SkillFormula::UnPack(SkillFormula*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the buffer; updated to point after the read data.</param>
    /// <param name="size">The total number of bytes available for unpacking; must be at least 24.</param>
    /// <returns>Non‑zero if exactly 24 bytes were consumed and the size check passed; zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillFormula, void**, uint, int>)0x005CB840)(ref this, addr, size);
}

