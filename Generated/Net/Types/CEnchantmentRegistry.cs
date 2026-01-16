namespace ACBindings.Internal;


/// <summary>Manages active enchantments applied to a character or object, maintaining separate lists for multiplicative, additive, and cooldown effects plus the special vitae enchantment; tracks helpful and harmful counts for quick queries.</summary>
public unsafe struct CEnchantmentRegistry
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CEnchantmentRegistry_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CEnchantmentRegistry*, void> CEnchantmentRegistry_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CEnchantmentRegistry*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CEnchantmentRegistry*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CEnchantmentRegistry*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr _mult_list;
    public System.IntPtr _add_list;
    public System.IntPtr _cooldown_list;
    public ACBindings.Internal.Enchantment* _vitae;
    public uint m_cHelpfulEnchantments;
    public uint m_cHarmfulEnchantments;

    // Generated Constructor
    public CEnchantmentRegistry() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Copies the registry's Vitae enchantment into the supplied Enchantment object if available.
    /// <code>Offset: 0x00594770
    /// int __thiscall CEnchantmentRegistry::InqVitae(CEnchantmentRegistry*,Enchantment*)</code>
    /// </summary>
    /// <param name="vitae">Destination for the copied Vitae enchantment.</param>
    /// <returns>1 when a Vitae exists and is copied; 0 otherwise.</returns>
    public int InqVitae(ACBindings.Internal.Enchantment* vitae) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, ACBindings.Internal.Enchantment*, int>)0x00594770)(ref this, vitae);

    /// <summary>Computes total byte count required to serialize a GenericQualitiesData instance, including all statistic tables and a 4‑byte header.
    /// <code>Offset: 0x005947B0
    /// unsigned int __thiscall CEnchantmentRegistry::pack_size(GenericQualitiesData*)</code>
    /// </summary>
    /// <param name="this">The GenericQualitiesData object to be packed.</param>
    /// <returns>The number of bytes needed for packing.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint>)0x005947B0)(ref this);

    /// <summary>Initializes a new enchantment registry instance, setting up internal lists and counters to empty values.
    /// <code>Offset: 0x00594820
    /// void __thiscall CEnchantmentRegistry::CEnchantmentRegistry(CEnchantmentRegistry*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, void>)0x00594820)(ref this);

    /// <summary>Clears all stored enchantments and their related lists from the registry, deallocating resources and resetting both helpful and harmful enchantment counters to zero.
    /// <code>Offset: 0x00594840
    /// void __thiscall CEnchantmentRegistry::Clear(CEnchantmentRegistry*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, void>)0x00594840)(ref this);

    /// <summary>Updates the registry's primary enchantment (vitae) when the provided enchantment’s type matches the current activation mask, creating or replacing the stored copy as needed.
    /// <code>Offset: 0x00594890
    /// int __thiscall CEnchantmentRegistry::UpdateVitae(CEnchantmentRegistry*,const Enchantment*)</code>
    /// </summary>
    /// <param name="vitae">The enchantment to install as the registry’s vita. Must have a type compatible with the active activation mask.</param>
    /// <returns>1 if the vitae was successfully updated; 0 otherwise (type mismatch or allocation failure).</returns>
    public int UpdateVitae(ACBindings.Internal.Enchantment* vitae) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, ACBindings.Internal.Enchantment*, int>)0x00594890)(ref this, vitae);

    /// <summary>Serializes the enchantment registry’s data into the supplied memory location when sufficient space is available.
    /// <code>Offset: 0x005948F0
    /// unsigned int __thiscall CEnchantmentRegistry::Pack(CEnchantmentRegistry*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; advanced past written data upon completion.</param>
    /// <param name="size">Maximum number of bytes that may be written; if smaller than the required size, serialization is skipped.</param>
    /// <returns>Size, in bytes, needed to serialize the entire registry regardless of whether packing succeeded.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, void**, uint, uint>)0x005948F0)(ref this, addr, size);

    /// <summary>Applies all registered enchantments to the supplied value, aggregating results with a bitwise OR.
    /// <code>Offset: 0x005949C0
    /// int __stdcall CEnchantmentRegistry::Enchant(int,float*)</code>
    /// </summary>
    /// <param name="value">Pointer to a float that will be modified by each enchantment.</param>
    /// <returns>Bitwise OR of individual enchantment return values; indicates overall success or combined flags.</returns>
    public static int Enchant(int a1, float* value) => ((delegate* unmanaged[Stdcall]<int, float*, int>)0x005949C0)(a1, value);

    /// <summary>Applies all enchantments stored in the registry to the supplied quality details and returns a combined status code.
    /// <code>Offset: 0x005949F0
    /// int __stdcall CEnchantmentRegistry::Enchant(int,EnchantedQualityDetails*)</code>
    /// </summary>
    /// <param name="a1">The <c>CEnchantmentRegistry</c> instance on which to apply enchantments.</param>
    /// <param name="value">An <c>EnchantedQualityDetails</c> object to receive the enchantments.</param>
    /// <returns>The bitwise OR of each individual enchantment's return value; zero indicates no enchantments were applied, non‑zero indicates at least one succeeded.</returns>
    public static int Enchant(int a1, ACBindings.Internal.EnchantedQualityDetails* value) => ((delegate* unmanaged[Stdcall]<int, ACBindings.Internal.EnchantedQualityDetails*, int>)0x005949F0)(a1, value);

    /// <summary>Replaces all entries in a specified enchantment list that match a given enchantment with the supplied replacement, copying its data into each matching entry.
    /// <code>Offset: 0x00594A20
    /// int __stdcall CEnchantmentRegistry::ReplaceEnchantmentInList(Enchantment*,int)</code>
    /// </summary>
    /// <param name="rhs">The enchantment to copy into matching list items.</param>
    /// <param name="a2">A pointer to the enchantment list structure; may be null.</param>
    /// <returns>Non‑zero if at least one replacement was performed; otherwise zero. If the list pointer is null, returns the original value of a2.</returns>
    public static int ReplaceEnchantmentInList(ACBindings.Internal.Enchantment* rhs, int a2) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.Enchantment*, int, int>)0x00594A20)(rhs, a2);

    /// <summary>Checks whether an enchantment with a given ID exists within the specified list.
    /// <code>Offset: 0x00594A70
    /// int __stdcall CEnchantmentRegistry::IsEnchantmentInList(int,int)</code>
    /// </summary>
    /// <param name="a1">Identifier of the enchantment to locate.</param>
    /// <param name="a2">Pointer to the list structure containing potential matches.</param>
    /// <returns>Non‑zero if the enchantment is present; zero otherwise.</returns>
    public static int IsEnchantmentInList(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, int>)0x00594A70)(a1, a2);

    /// <summary>Adjusts the registry’s helpful or harmful enchantment totals for the specified spell, returning whether the update succeeded.
    /// <code>Offset: 0x00594AB0
    /// int __thiscall CEnchantmentRegistry::UpdateSpellTotals(CEnchantmentRegistry*,unsigned int,int)</code>
    /// </summary>
    /// <param name="spell">The identifier of the spell to modify totals for.</param>
    /// <param name="iDelta">The amount to add (or subtract) from the appropriate total.</param>
    /// <returns>1 on success; 0 if the spell data could not be retrieved or is invalid.</returns>
    public int UpdateSpellTotals(uint spell, int iDelta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, int, int>)0x00594AB0)(ref this, spell, iDelta);

    /// <summary>Iterates over a linked list of spell entries and calls UpdateSpellTotals on each to update enchantment totals.
    /// <code>Offset: 0x00594B40
    /// int __thiscall CEnchantmentRegistry::CountSpellsInList(CEnchantmentRegistry*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the head of a spell list; may be null if no entries exist.</param>
    /// <returns>The value returned by UpdateSpellTotals for the last processed entry, or the original argument if the list is empty.</returns>
    public int CountSpellsInList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, int, int>)0x00594B40)(ref this, a2);

    /// <summary>Attempts to replace an existing enchantment in the registry list with the supplied one if a matching entry exists and both have positive duration.
    /// <code>Offset: 0x00594B70
    /// int __stdcall CEnchantmentRegistry::AttemptToReplaceSpellInList(int,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the source enchantment whose data will overwrite a matching entry.</param>
    /// <param name="a2">Pointer to the linked list containing current enchantments.</param>
    /// <returns>Non‑zero (1) when replacement succeeded; zero otherwise.</returns>
    public static int AttemptToReplaceSpellInList(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, int>)0x00594B70)(a1, a2);

    /// <summary>Adds an enchantment to the registry, creating or updating its internal list as needed.
    /// <code>Offset: 0x00594C60
    /// int __thiscall CEnchantmentRegistry::AddEnchantmentToList(CEnchantmentRegistry*,Enchantment*,_DWORD**)</code>
    /// </summary>
    /// <param name="a2">The enchantment object to add or replace in the list.</param>
    /// <param name="a3">Reference to the list of enchantments; initialized if null and updated with the new enchantment if it is not replaced.</param>
    /// <returns>1 on success, 0 if memory allocation for the list fails.</returns>
    public int AddEnchantmentToList(ACBindings.Internal.Enchantment* a2, int** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, ACBindings.Internal.Enchantment*, int**, int>)0x00594C60)(ref this, a2, a3);

    /// <summary>Updates the registry by replacing an existing enchantment of a matching type or adding a new one. Handles special cases such as vitae updates and cooldowns based on flags within the enchantment’s stat modification type.
    /// <code>Offset: 0x00594CE0
    /// int __thiscall CEnchantmentRegistry::UpdateEnchantment(CEnchantmentRegistry*,const Enchantment*)</code>
    /// </summary>
    /// <param name="to_update">The enchantment to apply, including its effect type and related data.</param>
    /// <returns>Non‑zero when the enchantment was successfully processed; zero if the enchantment type does not match any handled category or fails initial checks.</returns>
    public int UpdateEnchantment(ACBindings.Internal.Enchantment* to_update) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, ACBindings.Internal.Enchantment*, int>)0x00594CE0)(ref this, to_update);

    /// <summary>
    /// Iterates over a list of enchantments referenced by the supplied pointer, invoking UpdateEnchantment on each and accumulating success flags. Returns non‑zero if any update succeeded.
    /// 
    /// <code>Offset: 0x00594DC0
    /// int __thiscall CEnchantmentRegistry::UpdateEnchantmentList(CEnchantmentRegistry*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to an object whose fourth field points to the first Enchantment in a sequence; the function walks this sequence updating each enchantment.</param>
    /// <returns>Non‑zero if at least one UpdateEnchantment call returned non‑zero, otherwise zero.</returns>
    public int UpdateEnchantmentList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, int, int>)0x00594DC0)(ref this, a2);

    /// <summary>Determines whether the specified enchantment is currently active in the registry.
    /// <code>Offset: 0x00594DF0
    /// int __thiscall CEnchantmentRegistry::IsEnchanted(CEnchantmentRegistry*,const unsigned int)</code>
    /// </summary>
    /// <param name="spell">The unique identifier of an enchantment or spell to check.</param>
    /// <returns>Non‑zero if the enchantment is enabled; zero otherwise.</returns>
    public int IsEnchanted(uint spell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, int>)0x00594DF0)(ref this, spell);

    /// <summary>Unpacks a serialized enchantment registry from the supplied byte buffer, initializing or clearing the mult/add/cooldown lists and vitae object according to embedded flag bits, then updates internal counts of helpful and harmful enchantments.
    /// <code>Offset: 0x00594E60
    /// int __thiscall CEnchantmentRegistry::UnPack(CEnchantmentRegistry*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">The CEnchantmentRegistry instance receiving the unpacked data.</param>
    /// <param name="addr">Pointer to the current position in the source buffer; on return it points to the first byte following the processed segment.</param>
    /// <param name="size">Total number of bytes remaining in the buffer that may be read during this call.</param>
    /// <returns>Zero if unpacking fails or data is malformed; non‑zero otherwise, indicating successful completion and that *addr has advanced past the consumed data.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, void**, uint, int>)0x00594E60)(ref this, addr, size);

    /// <summary>Attempts to create or update a duel between the provided enchantment and those already registered in the internal list, removing any existing duels of the same spell category. Returns 1 on successful registration; returns 0 if a conflicting duel prevents the operation.
    /// <code>Offset: 0x00595120
    /// int __stdcall CEnchantmentRegistry::Duel(Enchantment*,_DWORD*)</code>
    /// </summary>
    /// <param name="challenger">The enchantment that initiates or participates in the duel.</param>
    /// <param name="a2">Pointer to the internal registry structure holding active duels and related counters.</param>
    /// <returns>1 if the duel was successfully added or updated; 0 otherwise.</returns>
    public static int Duel(ACBindings.Internal.Enchantment* challenger, int* a2) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.Enchantment*, int*, int>)0x00595120)(challenger, a2);

    /// <summary>Removes the enchantment with identifier spid from the specified list and decrements its count in the registry when removal succeeds.
    /// <code>Offset: 0x005951D0
    /// int __thiscall CEnchantmentRegistry::RemoveEnchantmentFromList(CEnchantmentRegistry*,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="spid">The unique identifier of the enchantment to remove.</param>
    /// <param name="a3">Pointer to the list from which the enchantment should be removed; must not be null.</param>
    /// <returns>Non‑zero if the enchantment was successfully removed; zero otherwise.</returns>
    public int RemoveEnchantmentFromList(uint spid, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, int*, int>)0x005951D0)(ref this, spid, a3);

    /// <summary>Determines whether an enchantment identified by <paramref name="cooldown_id"/> remains on cooldown, updates <paramref name="time_left"/> with the remaining duration, and removes the entry if the cooldown has expired.
    /// <code>Offset: 0x00595230
    /// int __thiscall CEnchantmentRegistry::OnCooldown(CEnchantmentRegistry*,const unsigned int,long double*)</code>
    /// </summary>
    /// <param name="cooldown_id">Identifier of the enchantment to query.</param>
    /// <param name="time_left">Pointer to a long double that receives the seconds left on the cooldown; set only when an active cooldown is found.</param>
    /// <returns>Nonzero (1) if the enchantment is still cooling down; zero (0) if it is not present or its cooldown has elapsed and was removed.</returns>
    public int OnCooldown(uint cooldown_id, double* time_left) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, double*, int>)0x00595230)(ref this, cooldown_id, time_left);

    /// <summary>Determines which enchantments in the supplied list are active on the specified target.
    /// <code>Offset: 0x005952A0
    /// int __stdcall CEnchantmentRegistry::GetEnchantmentsInEffectFromList(int,_DWORD*)</code>
    /// </summary>
    /// <param name="a1">Pointer to a structure containing a linked list of enchantment objects.</param>
    /// <param name="a2">Context data passed to each enchantment’s Duel method for evaluation against the target.</param>
    /// <returns>Bitmask indicating which enchantments from the list are in effect; zero if none or if the list is empty.</returns>
    public static int GetEnchantmentsInEffectFromList(int a1, int* a2) => ((delegate* unmanaged[Stdcall]<int, int*, int>)0x005952A0)(a1, a2);

    /// <summary>Processes enchantments in the supplied list, selecting those whose type matches the provided mask and that satisfy one of several key-based criteria. For each qualifying enchantment, executes duel logic with the specified context and aggregates the results.
    /// <code>Offset: 0x005952E0
    /// int __stdcall CEnchantmentRegistry::CullEnchantmentsFromList(int,int,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="a1">Pointer to the first element of an enchantment list structure; if null, the function returns immediately.</param>
    /// <param name="a2">Bitmask specifying which enchantment types should be considered during processing.</param>
    /// <param name="key">Identifier used to match specific enchantments or determine skill relevance for attack and defense categories.</param>
    /// <param name="a4">Pointer passed to the duel logic, typically containing contextual data required for resolving enchantment interactions.</param>
    /// <returns>Bitwise OR of all results returned by individual duel operations; zero if the list is empty or no enchantments match the criteria.</returns>
    public static int CullEnchantmentsFromList(int a1, int a2, uint key, int* a4) => ((delegate* unmanaged[Stdcall]<int, int, uint, int*, int>)0x005952E0)(a1, a2, key, a4);

    /// <summary>Removes an enchantment identified by its ID from the registry.
    /// <code>Offset: 0x00595350
    /// int __thiscall CEnchantmentRegistry::RemoveEnchantment(CEnchantmentRegistry*,const unsigned int)</code>
    /// </summary>
    /// <param name="eid">The unique identifier of the enchantment to remove.</param>
    /// <returns>Non‑zero if the enchantment was found and removed; zero otherwise.</returns>
    public int RemoveEnchantment(uint eid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, int>)0x00595350)(ref this, eid);

    /// <summary>Combines active enchantments from multiplicative and additive lists into a single set.
    /// <code>Offset: 0x005953B0
    /// int __thiscall CEnchantmentRegistry::GetEnchantmentsInEffect(int*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Buffer or context used to collect enchantment data during retrieval.</param>
    /// <returns>Bitmask of all enchantments currently affecting the entity.</returns>
    public int GetEnchantmentsInEffect(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, int*, int>)0x005953B0)(ref this, a2);

    /// <summary>Applies all applicable multiplicative and additive enchantments for the given attribute type to a value, clamping the result within defined bounds based on the original value.
    /// <code>Offset: 0x005953E0
    /// int __thiscall CEnchantmentRegistry::EnchantAttribute(CEnchantmentRegistry*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the attribute type whose value will be enchanted.</param>
    /// <param name="val">Pointer to the attribute’s integer value; treated as a floating‑point during enchantment calculations and updated with the rounded final result.</param>
    /// <returns>Bitwise OR of all individual enchantment application results, zero when no enchantments are applied.</returns>
    public int EnchantAttribute(uint stype, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, uint*, int>)0x005953E0)(ref this, stype, val);

    /// <summary>Applies secondary attribute enchantments to the supplied value, updating it and returning a bitmask indicating which enchantments were applied.
    /// <code>Offset: 0x005954E0
    /// int __thiscall CEnchantmentRegistry::EnchantAttribute2nd(CEnchantmentRegistry*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="stype">Identifier for the attribute type whose second attribute should be enchanted.</param>
    /// <param name="val">Pointer to the value to modify; updated with the enchanted result.</param>
    /// <returns>Non‑zero bitmask of applied enchantments, or zero if no enchantments were applied or an error occurred.</returns>
    public int EnchantAttribute2nd(uint stype, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, uint*, int>)0x005954E0)(ref this, stype, val);

    /// <summary>Applies all active enchantments for the given skill type to the value pointed to by val and returns a bitmask indicating which enchantments modified the result.
    /// <code>Offset: 0x00595620
    /// int __thiscall CEnchantmentRegistry::EnchantSkill(CEnchantmentRegistry*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="stype">Skill type identifier used to filter applicable enchantments.</param>
    /// <param name="val">Pointer to an integer containing the base value; after execution contains the adjusted value rounded to the nearest whole number.</param>
    /// <returns>Bitwise OR of individual enchantment return codes; non‑zero if at least one enchantment was applied.</returns>
    public int EnchantSkill(uint stype, int* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, int*, int>)0x00595620)(ref this, stype, val);

    /// <summary>Applies active enchantments of the specified type to an integer value, adjusting it according to multiplier and additive lists; writes the modified value back through the pointer argument.
    /// <code>Offset: 0x00595710
    /// int __thiscall CEnchantmentRegistry::EnchantInt(CEnchantmentRegistry*,unsigned int,int*,int)</code>
    /// </summary>
    /// <param name="stype">Identifier for the enchantment type to apply.</param>
    /// <param name="val">Pointer to the integer value that will be modified by the applied enchantments.</param>
    /// <param name="allow_negative">If zero, negative results are clamped to zero; otherwise negative values are allowed.</param>
    /// <returns>The number of enchantments processed or zero if none were applicable.</returns>
    public int EnchantInt(uint stype, int* val, int allow_negative) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, int*, int, int>)0x00595710)(ref this, stype, val, allow_negative);

    /// <summary>Applies all active enchantments matching the specified type to the supplied floating-point value, updating it in place.
    /// <code>Offset: 0x00595820
    /// int __thiscall CEnchantmentRegistry::EnchantFloat(CEnchantmentRegistry*,unsigned int,long double*)</code>
    /// </summary>
    /// <param name="stype">Enchantment type identifier used to filter applicable enchantments.</param>
    /// <param name="val">Pointer to the value that will be modified by the enchantments.</param>
    /// <returns>Zero if no enchantments were applied or an error occurred; otherwise returns a non‑zero status indicating successful application.</returns>
    public int EnchantFloat(uint stype, double* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, double*, int>)0x00595820)(ref this, stype, val);

    /// <summary>Retrieves active enchantments of the specified type and applies their modifiers to the provided quality details object.
    /// <code>Offset: 0x00595900
    /// int __thiscall CEnchantmentRegistry::GetFloatEnchantmentDetails(CEnchantmentRegistry*,unsigned int,EnchantedQualityDetails*)</code>
    /// </summary>
    /// <param name="stype">Identifier for the float-based enchantment set to query.</param>
    /// <param name="val">Structure that will receive the calculated quality adjustments.</param>
    /// <returns>1 if the operation succeeded; otherwise an error code returned from DBObj::GetByEnum.</returns>
    public int GetFloatEnchantmentDetails(uint stype, ACBindings.Internal.EnchantedQualityDetails* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, ACBindings.Internal.EnchantedQualityDetails*, int>)0x00595900)(ref this, stype, val);

    /// <summary>Removes the specified enchantments from the registry's active lists, handling vitae, cooldown, multiplicative and additive categories.
    /// <code>Offset: 0x005959B0
    /// int __thiscall CEnchantmentRegistry::RemoveEnchantments(CEnchantmentRegistry*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to an array of unsigned integer enchantment identifiers to remove.</param>
    /// <returns>Non‑zero if at least one enchantment was removed; zero otherwise.</returns>
    public int RemoveEnchantments(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, int, int>)0x005959B0)(ref this, a2);

    /// <summary>Removes all active enchantments referenced in the supplied list from this registry, ignoring entries that carry a sentinel value.
    /// <code>Offset: 0x00595AC0
    /// int __thiscall CEnchantmentRegistry::PurgeEnchantmentList(CEnchantmentRegistry*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a data structure containing a linked list of enchantment descriptors; if null, no removal occurs.</param>
    /// <returns>The number of enchantments successfully removed, or 0 if the input was invalid or no removals were performed.</returns>
    public int PurgeEnchantmentList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, int, int>)0x00595AC0)(ref this, a2);

    /// <summary>Removes enchantments from the registry that lack a specific flag and possess an explicit expiration time.
    /// <code>Offset: 0x00595B80
    /// int __thiscall CEnchantmentRegistry::PurgeBadEnchantmentList(CEnchantmentRegistry*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a list of enchantment entries to inspect; if null, the function exits immediately with zero.</param>
    /// <returns>The number of enchantments removed, as returned by CEnchantmentRegistry::RemoveEnchantments.</returns>
    public int PurgeBadEnchantmentList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, int, int>)0x00595B80)(ref this, a2);
}

