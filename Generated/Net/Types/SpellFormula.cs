namespace ACBindings.Internal;


/// <summary>Represents a spell formula comprising eight integer components, used for defining the spell’s behavior and targeting characteristics.</summary>
/// <remarks>Inherits packing capabilities from <see cref="PackObj"/> to support binary serialization, alignment, and buffer management.</remarks>
public unsafe struct SpellFormula
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SpellFormula_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellFormula*, void> SpellFormula_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellFormula*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellFormula*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellFormula*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public fixed uint _comps[8];

    // Methods

    /// <summary>Determines whether a spell formula has reached its required component count of five or more.
    /// <code>Offset: 0x005BD950
    /// int __thiscall SpellFormula::Complete(SpellFormula*)</code>
    /// </summary>
    /// <returns>Non‑zero (1) if the formula contains at least five components; otherwise 0.</returns>
    public int Complete() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int>)0x005BD950)(ref this);

    /// <summary>Assigns a component value at the specified index within the spell formula's internal array when the index is valid.
    /// <code>Offset: 0x005BD970
    /// int __thiscall SpellFormula::SetComponent(SpellFormula*,const int,const unsigned int)</code>
    /// </summary>
    /// <param name="num">Index of the component to set (must be less than 8).</param>
    /// <param name="comp">Value to assign to the component slot.</param>
    /// <returns>Non‑zero if the component was stored successfully; zero otherwise.</returns>
    public int SetComponent(int num, uint comp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int, uint, int>)0x005BD970)(ref this, num, comp);

    /// <summary>Counts and returns the number of active spell components stored in the formula’s component array.
    /// <code>Offset: 0x005BD990
    /// int __thiscall SpellFormula::GetNumSpellComponents(SpellFormula*)</code>
    /// </summary>
    /// <returns>An integer between 0 and 8 indicating how many non‑zero component slots are present.</returns>
    public int GetNumSpellComponents() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int>)0x005BD990)(ref this);

    /// <summary>Retrieves the targeting type associated with this spell formula by inspecting its active components.
    /// <code>Offset: 0x005BD9E0
    /// unsigned int __thiscall SpellFormula::GetTargetingType(SpellFormula*)</code>
    /// </summary>
    /// <returns>An unsigned integer representing the targeting type determined from the spell component table.</returns>
    public uint GetTargetingType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, uint>)0x005BD9E0)(ref this);

    /// <summary>Retrieves the power level of the spell’s first component using the magic system.
    /// <code>Offset: 0x005BDA10
    /// unsigned int __thiscall SpellFormula::GetPowerLevelOfPowerComponent(SpellFormula*)</code>
    /// </summary>
    /// <returns>The computed power level as an unsigned integer.</returns>
    public uint GetPowerLevelOfPowerComponent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, uint>)0x005BDA10)(ref this);

    /// <summary>Finds the most powerful component in a spell formula and outputs its power level.
    /// <code>Offset: 0x005BDA20
    /// unsigned int __thiscall SpellFormula::FindMostPowerfulPowerComponent(SpellFormula*,unsigned int*)</code>
    /// </summary>
    /// <param name="power_lvl">Pointer to store the highest power level among components; set to 0 if none exist.</param>
    /// <returns>The component identifier with the greatest power level, or zero when no components are present.</returns>
    public uint FindMostPowerfulPowerComponent(uint* power_lvl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, uint*, uint>)0x005BDA20)(ref this, power_lvl);

    /// <summary>Decrypts the eight component values of a spell formula by subtracting the supplied key from each non‑zero element.
    /// <code>Offset: 0x005BDAC0
    /// int __thiscall SpellFormula::Decrypt(SpellFormula*,const unsigned int)</code>
    /// </summary>
    /// <param name="key">The value used to reverse the encryption applied to the components.</param>
    /// <returns>Always returns true (1) indicating the decryption operation completed successfully.</returns>
    public int Decrypt(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, uint, int>)0x005BDAC0)(ref this, key);

    /// <summary>Serializes the eight unsigned integer components of a SpellFormula into the buffer referenced by addr, advancing the pointer after each write when at least 32 bytes are available.
    /// <code>Offset: 0x005BDB30
    /// unsigned int __thiscall SpellFormula::Pack(SpellFormula*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer that receives the address of the next free byte in the buffer after serialization.</param>
    /// <param name="size">Number of bytes available for writing; if less than 32, no data is written.</param>
    /// <returns>Always 32, representing the number of bytes written (or required).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, void**, uint, uint>)0x005BDB30)(ref this, addr, size);

    /// <summary>Reads eight unsigned integer components from a byte stream into the formula's component array, ensuring at least 32 bytes are available.
    /// <code>Offset: 0x005BDBB0
    /// int __thiscall SpellFormula::UnPack(SpellFormula*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position; advanced past the consumed data upon return.</param>
    /// <param name="size">Number of remaining bytes in the buffer; must be at least 32 for a successful unpack.</param>
    /// <returns>Non‑zero if exactly 32 bytes were read and stored, zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, void**, uint, int>)0x005BDBB0)(ref this, addr, size);

    /// <summary>Randomizes the spell formula's component values using a hash derived from data pointed to by the second argument, distributing pseudo‑random adjustments across existing components.
    /// <code>Offset: 0x005BDC40
    /// int __thiscall SpellFormula::RandomizeVersion1(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to input data whose contents are hashed and used to influence the randomization outcome.</param>
    /// <returns>Always 1, indicating successful randomization.</returns>
    public int RandomizeVersion1(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int*, int>)0x005BDC40)(ref this, a2);

    /// <summary>Computes and updates two internal identifiers for a spell using data supplied through the second argument, caching its hash when necessary.
    /// <code>Offset: 0x005BDE10
    /// int __thiscall SpellFormula::RandomizeVersion2(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an object whose 16‑byte field holds a cached hash; if unset (−1), the function computes the hash from the object and stores it back.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public int RandomizeVersion2(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int*, int>)0x005BDE10)(ref this, a2);

    /// <summary>Randomizes spell components based on a provided key, updating internal component indices with deterministic pseudo‑random values.
    /// <code>Offset: 0x005BDEF0
    /// int __thiscall SpellFormula::RandomizeVersion3(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the identifier string used as the source of hash values for randomization.</param>
    /// <returns>Always returns 1 to indicate successful completion.</returns>
    public int RandomizeVersion3(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int*, int>)0x005BDEF0)(ref this, a2);

    /// <summary>Dispatches spell formula randomization based on the provided version number and returns the result of the selected routine.
    /// <code>Offset: 0x005BE120
    /// int __thiscall SpellFormula::RandomizeForName(_DWORD*,int*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to data affected by randomization; forwarded unchanged to the chosen implementation.</param>
    /// <param name="a3">Version identifier selecting which RandomizeVersionX function to invoke (1, 2, or 3).</param>
    /// <returns>Result code from the invoked RandomizeVersionX function; returns 0 if an unsupported version is supplied.</returns>
    public int RandomizeForName(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int*, int, int>)0x005BE120)(ref this, a2, a3);
}

