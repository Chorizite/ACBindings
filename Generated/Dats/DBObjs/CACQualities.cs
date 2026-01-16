namespace ACBindings.Internal;


/// <summary>Represents the core quality data of a character or object in the game system, aggregating attributes, skills, enchantments, and spellbooks while providing methods for manipulation and serialization.</summary>
public unsafe struct CACQualities
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj
    public ACBindings.Internal.CBaseQualities BaseClass_CBaseQualities; // ACBindings.Internal.CBaseQualities

    // Child Types
    public unsafe struct CACQualities_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer
        public System.IntPtr InqPluralNameString;

        // Methods
    }

    // Members
    public ACBindings.Internal.AttributeCache* _attribCache;
    public System.IntPtr _skillStatsTable;
    public ACBindings.Internal.Body* _body;
    public ACBindings.Internal.CSpellBook* _spell_book;
    public ACBindings.Internal.CEnchantmentRegistry* _enchantment_reg;
    public ACBindings.Internal.EventFilter* _event_filter;
    public ACBindings.Internal.CEmoteTable* _emote_table;
    public System.IntPtr _create_list;
    public ACBindings.Internal.PageDataList* _pageDataList;
    public ACBindings.Internal.GeneratorTable* _generator_table;
    public ACBindings.Internal.GeneratorRegistry* _generator_registry;
    public ACBindings.Internal.GeneratorQueue* _generator_queue;

    // Generated Constructor
    public CACQualities(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Determines whether the current qualities instance contains an associated spell book.
    /// <code>Offset: 0x0058FCE0
    /// int __thiscall CACQualities::HasSpellBook(CACQualities*)</code>
    /// </summary>
    /// <returns>Non‑zero if a spell book is present, zero otherwise.</returns>
    public int HasSpellBook() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int>)0x0058FCE0)(ref this);

    /// <summary>Checks whether the given spell identifier exists in the object's spell book.
    /// <code>Offset: 0x0058FCF0
    /// int __thiscall CACQualities::IsSpellKnown(CACQualities*,const unsigned int)</code>
    /// </summary>
    /// <param name="spell">The spell ID to query.</param>
    /// <returns>Non‑zero if the spell is known; zero otherwise.</returns>
    public int IsSpellKnown(uint spell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int>)0x0058FCF0)(ref this, spell);

    /// <summary>Copies the spells stored in this object's spell book to the specified destination.
    /// <code>Offset: 0x0058FD10
    /// int __thiscall CACQualities::TranscribeSpells(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Buffer or structure that receives the transcribed spell data.</param>
    /// <returns>Zero if the object lacks a spell book; otherwise, the result of CSpellBook::TranscribeSpells, typically indicating success or the number of spells copied.</returns>
    public int TranscribeSpells(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int*, int>)0x0058FD10)(ref this, a2);

    /// <summary>Indicates whether the quality instance contains an enchantment registry.
    /// <code>Offset: 0x0058FD30
    /// int __thiscall CACQualities::HasEnchantmentRegistry(CACQualities*)</code>
    /// </summary>
    /// <returns>Non‑zero when an enchantment registry exists; zero otherwise.</returns>
    public int HasEnchantmentRegistry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int>)0x0058FD30)(ref this);

    /// <summary>Determines whether this object has been enchanted by a specified spell.
    /// <code>Offset: 0x0058FD40
    /// int __thiscall CACQualities::IsEnchanted(CACQualities*,const unsigned int)</code>
    /// </summary>
    /// <param name="spell">Identifier of the spell to check for enchantment.</param>
    /// <returns>Nonzero if the object has been enchanted with the given spell; zero otherwise.</returns>
    public int IsEnchanted(uint spell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int>)0x0058FD40)(ref this, spell);

    /// <summary>Purges all enchantments associated with this quality object, clearing its multiplicative and additive enchantment lists.
    /// <code>Offset: 0x0058FD60
    /// int __thiscall CACQualities::PurgeEnchantments(CACQualities*)</code>
    /// </summary>
    /// <returns>An integer status code combining the results of purging each list; non‑zero indicates an error occurred during the purge process.</returns>
    public int PurgeEnchantments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int>)0x0058FD60)(ref this);

    /// <summary>Purges bad enchantments from the object's registry by cleaning both multiplicative and additive lists.
    /// <code>Offset: 0x0058FD70
    /// int __thiscall CACQualities::PurgeBadEnchantments(CACQualities*)</code>
    /// </summary>
    /// <returns>Zero if the object has no enchantment registry; otherwise a status code that is the bitwise OR of the results returned from purging the multiplicative and additive enchantment lists.</returns>
    public int PurgeBadEnchantments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int>)0x0058FD70)(ref this);

    /// <summary>Retrieves the enchantments currently active on this object and stores them in a supplied container.
    /// <code>Offset: 0x0058FD80
    /// int __thiscall CACQualities::GetEnchantmentsInEffect(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a structure that will receive the list of active enchantments.</param>
    /// <returns>The number of enchantments returned, or zero if no registry is available.</returns>
    public int GetEnchantmentsInEffect(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int*, int>)0x0058FD80)(ref this, a2);

    /// <summary>Removes an enchantment identified by <c>eid</c> from the object's registry, returning non‑zero on success and zero if the registry is absent or removal fails.
    /// <code>Offset: 0x0058FDA0
    /// int __thiscall CACQualities::RemoveEnchantment(CACQualities*,const unsigned int)</code>
    /// </summary>
    /// <param name="eid">Identifier of the enchantment to remove.</param>
    /// <returns>Non‑zero value when removal succeeded; otherwise zero.</returns>
    public int RemoveEnchantment(uint eid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int>)0x0058FDA0)(ref this, eid);

    /// <summary>Removes specified enchantments from the object's enchantment registry and returns how many were removed.
    /// <code>Offset: 0x0058FDC0
    /// int __thiscall CACQualities::RemoveEnchantments(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">The identifier (e.g., index or ID) of the enchantments to remove.</param>
    /// <returns>The number of enchantments that were successfully removed; returns 0 if no registry is present.</returns>
    public int RemoveEnchantments(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int, int>)0x0058FDC0)(ref this, a2);

    /// <summary>Updates an enchantment in the object's registry, creating the registry if it does not exist.
    /// <code>Offset: 0x0058FDE0
    /// int __thiscall CACQualities::UpdateEnchantment(CACQualities*,const Enchantment*)</code>
    /// </summary>
    /// <param name="to_update">The enchantment to add or update.</param>
    /// <returns>An integer status code from the registry's UpdateEnchantment call; zero indicates failure to create the registry.</returns>
    public int UpdateEnchantment(ACBindings.Internal.Enchantment* to_update) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, ACBindings.Internal.Enchantment*, int>)0x0058FDE0)(ref this, to_update);

    /// <summary>Ensures the object's enchantment registry exists and updates its enchantment list using the supplied identifier.
    /// <code>Offset: 0x0058FE20
    /// void __thiscall CACQualities::UpdateEnchantments(CEnchantmentRegistry**,int)</code>
    /// </summary>
    /// <param name="a2">The identifier used to update the enchantments in the registry.</param>
    public void UpdateEnchantments(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int, void>)0x0058FE20)(ref this, a2);

    /// <summary>Retrieves vitae information for the specified enchantment by delegating to the object's enchantment registry, returning zero when the registry is unavailable.
    /// <code>Offset: 0x0058FE60
    /// int __thiscall CACQualities::InqVitae(CACQualities*,Enchantment*)</code>
    /// </summary>
    /// <param name="vitae">The enchantment whose vitae data is being queried.</param>
    /// <returns>Zero if no enchantment registry exists; otherwise the result of the registry's InqVitae call.</returns>
    public int InqVitae(ACBindings.Internal.Enchantment* vitae) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, ACBindings.Internal.Enchantment*, int>)0x0058FE60)(ref this, vitae);

    /// <summary>Obtains the Vitae enchantment's scaling factor for a character; if the Vitae enchantment is absent, returns the neutral value of 1.0.
    /// <code>Offset: 0x0058FE80
    /// float __thiscall CACQualities::GetVitaeValue(CACQualities*)</code>
    /// </summary>
    /// <returns>The multiplier applied by the Vitae enchantment, or 1.0 when no Vitae is equipped.</returns>
    public float GetVitaeValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float>)0x0058FE80)(ref this);

    /// <summary>Applies an enchantment to a specified attribute by delegating the operation to the object's enchantment registry.
    /// <code>Offset: 0x0058FEA0
    /// int __thiscall CACQualities::EnchantAttribute(CACQualities*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="stype">Identifier for the attribute type to be enchanted.</param>
    /// <param name="val">Pointer to the value that may be modified by the enchantment process.</param>
    /// <returns>Zero if no registry is present or the enchantment fails; otherwise returns the result code from CEnchantmentRegistry::EnchantAttribute.</returns>
    public int EnchantAttribute(uint stype, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint*, int>)0x0058FEA0)(ref this, stype, val);

    /// <summary>Applies a second‑level enchantment to an attribute type via the object's enchantment registry.
    /// <code>Offset: 0x0058FEC0
    /// int __thiscall CACQualities::EnchantAttribute2nd(CACQualities*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the attribute to be enchanted.</param>
    /// <param name="val">Pointer to unsigned integer that receives the resulting value after enchantment.</param>
    /// <returns>Non‑zero if the enchantment succeeded; zero otherwise.</returns>
    public int EnchantAttribute2nd(uint stype, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint*, int>)0x0058FEC0)(ref this, stype, val);

    /// <summary>Applies an enchantment to a skill via the object's enchantment registry and returns the resulting value.
    /// <code>Offset: 0x0058FEE0
    /// int __thiscall CACQualities::EnchantSkill(CACQualities*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the skill type to be enchanted.</param>
    /// <param name="val">Pointer to an integer that receives the enchanted skill value.</param>
    /// <returns>The result returned by CEnchantmentRegistry::EnchantSkill, or 0 if no enchantment registry is available.</returns>
    public int EnchantSkill(uint stype, int* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int*, int>)0x0058FEE0)(ref this, stype, val);

    /// <summary>Applies an enchantment to the specified integer stat by delegating to the object's enchantment registry.
    /// <code>Offset: 0x0058FF00
    /// int __thiscall CACQualities::EnchantInt(CACQualities*,unsigned int,int*,int)</code>
    /// </summary>
    /// <param name="stype">Identifier of the stat type to enchant.</param>
    /// <param name="val">Pointer to the integer value that will be modified by the enchantment.</param>
    /// <param name="allow_negative">When true, permits negative results; otherwise clamps to non‑negative values.</param>
    /// <returns>Non-zero on success, zero if the object lacks an enchantment registry or the operation fails.</returns>
    public int EnchantInt(uint stype, int* val, int allow_negative) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int*, int, int>)0x0058FF00)(ref this, stype, val, allow_negative);

    /// <summary>Applies a float-based enchantment identified by the given type to the supplied value, delegating through the object's base class registry.
    /// <code>Offset: 0x0058FF20
    /// int __thiscall CACQualities::EnchantFloat(CACQualities*,unsigned int,long double*)</code>
    /// </summary>
    /// <param name="stype">Identifier for the enchantment or attribute type to apply.</param>
    /// <param name="val">Pointer to the floating-point value that will be modified by the enchantment.</param>
    /// <returns>Non-zero if the enchantment succeeded; zero otherwise.</returns>
    public int EnchantFloat(uint stype, double* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, double*, int>)0x0058FF20)(ref this, stype, val);

    /// <summary>Retrieves float enchantment details for a specified stat type from the object’s enchantment registry when available.
    /// <code>Offset: 0x0058FF40
    /// int __thiscall CACQualities::GetFloatEnchantmentDetails(CACQualities*,unsigned int,EnchantedQualityDetails*)</code>
    /// </summary>
    /// <param name="stype">Stat type identifier used to query the registry.</param>
    /// <param name="val">Output structure that receives the retrieved enchantment details on success.</param>
    /// <returns>Non‑zero value if the details are successfully fetched; zero otherwise.</returns>
    public int GetFloatEnchantmentDetails(uint stype, ACBindings.Internal.EnchantedQualityDetails* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.EnchantedQualityDetails*, int>)0x0058FF40)(ref this, stype, val);

    /// <summary>Computes the current encumbrance load of a CACQualities instance using its capacity and carried weight, writing the result to the supplied float pointer.
    /// <code>Offset: 0x0058FF60
    /// int __thiscall CACQualities::InqLoad(CACQualities*,float*)</code>
    /// </summary>
    /// <param name="load">Reference that receives the calculated load value.</param>
    /// <returns>Integer status code; non‑zero indicates successful calculation.</returns>
    public int InqLoad(float* load) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float*, int>)0x0058FF60)(ref this, load);

    /// <summary>Adds a spell to the object's spell book, creating the book if it does not exist.
    /// <code>Offset: 0x00590050
    /// int __thiscall CACQualities::AddSpell(CACQualities*,const unsigned int)</code>
    /// </summary>
    /// <param name="newSpell">Identifier of the spell to add.</param>
    /// <returns>Non‑zero value on success; zero if creation fails or adding the spell fails.</returns>
    public int AddSpell(uint newSpell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int>)0x00590050)(ref this, newSpell);

    /// <summary>Removes a spell identified by its ID from the object's spellbook if present.
    /// <code>Offset: 0x005900B0
    /// int __thiscall CACQualities::RemoveSpell(CACQualities*,const unsigned int)</code>
    /// </summary>
    /// <param name="spell">The unique identifier of the spell to be removed.</param>
    /// <returns>Non‑zero on successful removal; zero if the object has no spellbook or the removal fails.</returns>
    public int RemoveSpell(uint spell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int>)0x005900B0)(ref this, spell);

    /// <summary>Retrieves the plural form of an object’s name from its qualities and stores it in the supplied string reference.
    /// <code>Offset: 0x00590680
    /// int __thiscall CACQualities::InqPluralNameString(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Reference to a string that will receive the resulting plural name.</param>
    /// <returns>Nonzero if a plural name was obtained or constructed; zero when the default “items” string is used.</returns>
    public int InqPluralNameString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int*, int>)0x00590680)(ref this, a2);

    /// <summary>Retrieves an attribute of the specified type from the object's attribute cache.
    /// <code>Offset: 0x005926D0
    /// int __thiscall CACQualities::InqAttribute(CACQualities*,unsigned int,Attribute*)</code>
    /// </summary>
    /// <param name="stype">The identifier of the requested attribute type.</param>
    /// <param name="retval">Pointer to an Attribute structure that receives the retrieved data.</param>
    /// <returns>Non‑zero if the attribute was found and copied; zero otherwise.</returns>
    public int InqAttribute(uint stype, ACBindings.Internal.Attribute* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.Attribute*, int>)0x005926D0)(ref this, stype, retval);

    /// <summary>Retrieves the value of an attribute identified by its type ID, applying enchantments unless requested raw.
    /// <code>Offset: 0x00592700
    /// int __thiscall CACQualities::InqAttribute(CACQualities*,unsigned int,unsigned int*,int)</code>
    /// </summary>
    /// <param name="stype">Attribute type identifier to query.</param>
    /// <param name="retval">Pointer that receives the resulting attribute value on success.</param>
    /// <param name="raw">If non‑zero, return the unmodified value; otherwise apply enchantment effects before returning.</param>
    /// <returns>1 if the attribute was found and returned (possibly enchanted); 0 if no cache or lookup failed.</returns>
    public int InqAttribute(uint stype, uint* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint*, int, int>)0x00592700)(ref this, stype, retval, raw);

    /// <summary>Sets an attribute of the specified type for this object, creating an internal attribute cache if necessary.
    /// <code>Offset: 0x00592750
    /// int __thiscall CACQualities::SetAttribute(CACQualities*,unsigned int,const Attribute*)</code>
    /// </summary>
    /// <param name="stype">Identifier indicating which attribute to set.</param>
    /// <param name="val">Pointer to the Attribute structure containing the new value.</param>
    /// <returns>An integer status code: non‑zero on success, zero if allocation fails or the operation cannot be completed.</returns>
    public int SetAttribute(uint stype, ACBindings.Internal.Attribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.Attribute*, int>)0x00592750)(ref this, stype, val);

    /// <summary>Sets the specified attribute within the object's attribute cache, creating a new cache if none exists.
    /// <code>Offset: 0x005927A0
    /// int __thiscall CACQualities::SetAttribute(CACQualities*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="stype">Identifier for the attribute to set.</param>
    /// <param name="init_val">Initial value assigned to the attribute.</param>
    /// <returns>Non‑zero on success; zero if allocation fails or setting fails.</returns>
    public int SetAttribute(uint stype, uint init_val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint, int>)0x005927A0)(ref this, stype, init_val);

    /// <summary>
    /// Retrieves a secondary attribute of the specified type from the object's attribute cache, storing it in retval.
    /// 
    /// <code>Offset: 0x005927F0
    /// int __thiscall CACQualities::InqAttribute2nd(CACQualities*,unsigned int,SecondaryAttribute*)</code>
    /// </summary>
    /// <param name="stype">Identifier for the desired secondary attribute type.</param>
    /// <param name="retval">Pointer to a SecondaryAttribute structure that receives the retrieved data; must not be null.</param>
    /// <returns>Nonzero if the attribute was found and stored successfully; zero otherwise.</returns>
    public int InqAttribute2nd(uint stype, ACBindings.Internal.SecondaryAttribute* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.SecondaryAttribute*, int>)0x005927F0)(ref this, stype, retval);

    /// <summary>Retrieves the maximum run rate for the character represented by this CACQualities instance.
    /// <code>Offset: 0x00592820
    /// int __thiscall CACQualities::InqMaxRunRate(CACQualities*,float*)</code>
    /// </summary>
    /// <param name="rate">Receives the maximum run speed as a float.</param>
    /// <returns>A status code; returns nonzero on success.</returns>
    public int InqMaxRunRate(float* rate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float*, int>)0x00592820)(ref this, rate);

    /// <summary>Determines whether a character may jump by verifying that its current load is below the maximum threshold.
    /// <code>Offset: 0x00592850
    /// int __thiscall CACQualities::CanJump(CACQualities*,float)</code>
    /// </summary>
    /// <param name="extent">The desired jump distance or extent (not used in this check).</param>
    /// <returns>Non‑zero if the character can jump; zero otherwise.</returns>
    public int CanJump(float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float, int>)0x00592850)(ref this, extent);

    /// <summary>Calculates the stamina required for a jump based on distance and character load, storing the result in the provided integer pointer.
    /// <code>Offset: 0x00592890
    /// int __thiscall CACQualities::JumpStaminaCost(CACQualities*,float,int*)</code>
    /// </summary>
    /// <param name="extent">The desired jump distance or intensity.</param>
    /// <param name="cost">Pointer where the calculated stamina cost is stored.</param>
    /// <returns>1 if the calculation succeeded; 0 otherwise.</returns>
    public int JumpStaminaCost(float extent, int* cost) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float, int*, int>)0x00592890)(ref this, extent, cost);

    /// <summary>Computes a derived attribute value based on two base attributes defined by the supplied type.
    /// <code>Offset: 0x00592A20
    /// int __thiscall CACQualities::InqAttribute2ndBaseLevel(CACQualities*,unsigned int,unsigned int*,int)</code>
    /// </summary>
    /// <param name="stype">Identifier indicating which pair of base attributes to query.</param>
    /// <param name="retval">Pointer to receive the calculated result.</param>
    /// <param name="raw">Flag controlling whether raw or processed values are used when retrieving the base attributes.</param>
    /// <returns>Zero if the calculation fails or the type is unsupported; otherwise returns the result code from SkillFormula::Calculate, with the computed value stored in *retval.</returns>
    public int InqAttribute2ndBaseLevel(uint stype, uint* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint*, int, int>)0x00592A20)(ref this, stype, retval, raw);

    /// <summary>Retrieves the statistics for a specified skill type and stores them in the provided Skill structure.
    /// <code>Offset: 0x00592AF0
    /// int __thiscall CACQualities::InqSkill(CACQualities*,unsigned int,Skill*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the skill to query.</param>
    /// <param name="retval">Output parameter that receives the skill information if found.</param>
    /// <returns>1 on success; 0 if no skill table or skill not present.</returns>
    public int InqSkill(uint stype, ACBindings.Internal.Skill* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.Skill*, int>)0x00592AF0)(ref this, stype, retval);

    /// <summary>Retrieves the level of a specified skill from the object's internal statistics table and places it in the supplied output parameter.
    /// <code>Offset: 0x00592B40
    /// int __thiscall CACQualities::InqSkillLevel(CACQualities*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="stype">Identifier for the desired skill.</param>
    /// <param name="retval">Pointer to an integer that receives the combined skill level when the function succeeds.</param>
    /// <returns>1 if the skill was found and its level written to retval; 0 if the statistics table is missing or the skill does not exist.</returns>
    public int InqSkillLevel(uint stype, int* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int*, int>)0x00592B40)(ref this, stype, retval);

    /// <summary>Queries the object's internal skill statistics table for the advancement class associated with a given skill type identifier and writes it to an output variable.
    /// <code>Offset: 0x00592B70
    /// int __thiscall CACQualities::InqSkillAdvancementClass(CACQualities*,unsigned int,SKILL_ADVANCEMENT_CLASS*)</code>
    /// </summary>
    /// <param name="stype">The numeric identifier of the skill whose advancement class is requested.</param>
    /// <param name="retval">Pointer to a SKILL_ADVANCEMENT_CLASS structure that receives the retrieved value when the lookup succeeds.</param>
    /// <returns>Non‑zero (typically 1) if the skill type exists and its advancement class was written; zero otherwise.</returns>
    public int InqSkillAdvancementClass(uint stype, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS*, int>)0x00592B70)(ref this, stype, retval);

    /// <summary>Retrieves the second attribute value for a specified type from a CACQualities instance, combining base level data and optional enchantment effects.
    /// <code>Offset: 0x00592D20
    /// int __thiscall CACQualities::InqAttribute2nd(CACQualities*,unsigned int,unsigned int*,int)</code>
    /// </summary>
    /// <param name="stype">The identifier of the attribute type to query.</param>
    /// <param name="retval">Pointer to receive the computed attribute value.</param>
    /// <param name="raw">If non‑zero, bypasses enchantment adjustments; otherwise applies them.</param>
    /// <returns>Non‑zero if the attribute was successfully retrieved and stored in *retval; zero otherwise.</returns>
    public int InqAttribute2nd(uint stype, uint* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint*, int, int>)0x00592D20)(ref this, stype, retval, raw);

    /// <summary>Validates and clamps the value pointed to by <paramref name="val"/> within its allowed range for attribute types 2, 4, or 6. If the value exceeds the maximum retrieved via <paramref name="max"/>, it is truncated; if negative, it is set to zero.
    /// <code>Offset: 0x00592E00
    /// int __thiscall CACQualities::BoundsCheck(CACQualities*,unsigned int,int*,unsigned int*)</code>
    /// </summary>
    /// <param name="stype">Specifies the attribute type to check; only values 2, 4, or 6 trigger bounds validation.</param>
    /// <param name="val">Pointer to the integer value that will be validated and potentially adjusted.</param>
    /// <param name="max">Pointer to receive the maximum allowed value for the specified attribute type.</param>
    /// <returns>1 on successful validation (or when <paramref name="stype"/> is not 2, 4, or 6); otherwise returns an error code from InqAttribute2nd.</returns>
    public int BoundsCheck(uint stype, int* val, uint* max) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int*, uint*, int>)0x00592E00)(ref this, stype, val, max);

    /// <summary>Computes the base level for a specified skill type using its formula and current attributes, storing the result in the supplied integer pointer.
    /// <code>Offset: 0x00592E60
    /// int __thiscall CACQualities::InqSkillBaseLevel(CACQualities*,unsigned int,int*,int)</code>
    /// </summary>
    /// <param name="stype">The identifier of the skill whose base level will be queried.</param>
    /// <param name="retval">Pointer to an integer that receives the calculated base level; set to 0 when the skill's current level is below its minimum requirement.</param>
    /// <param name="raw">Flag indicating whether attribute lookups should use raw values during formula evaluation.</param>
    /// <returns>Zero if the requested skill or supporting data cannot be found; otherwise returns the status code from the skill formula calculation (non‑zero).</returns>
    public int InqSkillBaseLevel(uint stype, int* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int*, int, int>)0x00592E60)(ref this, stype, retval, raw);

    /// <summary>Assigns or updates the skill data for the specified skill type within this object, creating an internal hash table if one does not yet exist.
    /// <code>Offset: 0x00592F60
    /// int __thiscall CACQualities::SetSkill(CACQualities*,unsigned int,const Skill*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the skill type to set.</param>
    /// <param name="val">Pointer to a Skill structure containing the new values to store.</param>
    /// <returns>Non‑zero on success; zero if memory allocation fails or the operation cannot be completed.</returns>
    public int SetSkill(uint stype, ACBindings.Internal.Skill* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.Skill*, int>)0x00592F60)(ref this, stype, val);

    /// <summary>
    /// Assigns or updates the level of a skill identified by stype within this object's skill table, creating the internal table if necessary.
    /// 
    /// <code>Offset: 0x00593060
    /// int __thiscall CACQualities::SetSkillLevel(CACQualities*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="stype">Identifier for the target skill.</param>
    /// <param name="val">Desired level to set for that skill.</param>
    /// <returns>1 on success; 0 if memory allocation fails or the operation cannot be performed.</returns>
    public int SetSkillLevel(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint, int>)0x00593060)(ref this, stype, val);

    /// <summary>Assigns a new advancement class to a skill identified by its type, creating and inserting the skill entry if necessary.
    /// <code>Offset: 0x00593150
    /// int __thiscall CACQualities::SetSkillAdvancementClass(CACQualities*,unsigned int,SKILL_ADVANCEMENT_CLASS)</code>
    /// </summary>
    /// <param name="stype">Numeric identifier for the target skill.</param>
    /// <param name="val">New advancement class value to apply.</param>
    /// <returns>Non‑zero on success; zero when the operation fails (e.g., memory allocation error).</returns>
    public int SetSkillAdvancementClass(uint stype, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, int>)0x00593150)(ref this, stype, val);

    /// <summary>Sets a secondary attribute of the specified type after ensuring the internal cache exists and optionally enforcing level limits for certain types.
    /// <code>Offset: 0x00593250
    /// int __thiscall CACQualities::SetAttribute2nd(CACQualities*,unsigned int,const SecondaryAttribute*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the attribute to modify; special handling applies when it equals 2, 4, or 6.</param>
    /// <param name="val">SecondaryAttribute containing the new base attribute data and desired current level.</param>
    /// <returns>Non‑zero on success, zero if allocation fails or an invalid type is specified.</returns>
    public int SetAttribute2nd(uint stype, ACBindings.Internal.SecondaryAttribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.SecondaryAttribute*, int>)0x00593250)(ref this, stype, val);

    /// <summary>Sets an attribute value after validating it against defined limits, creating an internal cache if required.
    /// <code>Offset: 0x00593310
    /// int __thiscall CACQualities::SetAttribute2nd(CACQualities*,unsigned int,unsigned int,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="stype">Identifier for the attribute type to modify.</param>
    /// <param name="val">Requested new value before bounds enforcement.</param>
    /// <param name="bounded_val">Receives the clamped value that will actually be stored.</param>
    /// <param name="max">Maximum permissible value for this attribute; used during bounds checking.</param>
    /// <returns>Non‑zero on success, zero if bounds check fails or cache allocation fails.</returns>
    public int SetAttribute2nd(uint stype, uint val, uint* bounded_val, uint* max) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint, uint*, uint*, int>)0x00593310)(ref this, stype, val, bounded_val, max);

    /// <summary>Computes the effective level of a given skill for an entity by combining its base level with modifiers from internal tables, attribute bonuses and optional enchantment effects. The final value is written to the integer pointed to by retval. Returns 1 if the skill exists; otherwise returns 0.
    /// <code>Offset: 0x00593380
    /// int __thiscall CACQualities::InqSkill(CACQualities*,unsigned int,int*,int)</code>
    /// </summary>
    /// <param name="stype">Identifier of the skill whose effective level is being queried.</param>
    /// <param name="retval">Pointer to an int that receives the computed skill value.</param>
    /// <param name="raw">Flag controlling whether enchantment bonuses are applied. A non‑zero value skips the extra calculations performed when this flag is zero.</param>
    /// <returns>1 if the skill was successfully queried and retval updated; 0 if the base lookup fails or the skill does not exist.</returns>
    public int InqSkill(uint stype, int* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int*, int, int>)0x00593380)(ref this, stype, retval, raw);

    /// <summary>Calculates the character’s run rate based on current load, attributes, and skills, storing the result in the supplied float pointer.
    /// <code>Offset: 0x00593570
    /// int __thiscall CACQualities::InqRunRate(CACQualities*,float*)</code>
    /// </summary>
    /// <param name="rate">Reference to receive the calculated run rate; must not be null.</param>
    /// <returns>Non-zero if the calculation succeeded; zero otherwise.</returns>
    public int InqRunRate(float* rate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float*, int>)0x00593570)(ref this, rate);

    /// <summary>Calculates the vertical jump velocity required to reach a specified extent based on the object's attributes and skill levels. Stores the result in the provided output pointer.
    /// <code>Offset: 0x00593740
    /// int __thiscall CACQualities::InqJumpVelocity(CACQualities*,float,float*)</code>
    /// </summary>
    /// <param name="extent">Desired jump extent (e.g., horizontal distance or target height) used for the calculation.</param>
    /// <param name="v_z">Pointer to a float where the calculated upward velocity will be written.</param>
    /// <returns>Returns 1 on success, or 0 if the calculation could not be performed due to missing data or errors.</returns>
    public int InqJumpVelocity(float extent, float* v_z) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float, float*, int>)0x00593740)(ref this, extent, v_z);

    /// <summary>Assigns the specified value to an attribute identified by its stat type.
    /// <code>Offset: 0x00593AF0
    /// int __thiscall CACQualities::SetAttribute2nd(CACQualities*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="stype">The identifier for the attribute to modify.</param>
    /// <param name="val">The new value to assign to the attribute.</param>
    /// <returns>An integer status code indicating success or failure of the operation.</returns>
    public int SetAttribute2nd(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint, int>)0x00593AF0)(ref this, stype, val);

    /// <summary>Destroys all owned subcomponents of a CACQualities instance, freeing associated resources and resetting related pointers to null.
    /// <code>Offset: 0x00593B10
    /// void __thiscall CACQualities::Clear(CACQualities*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, void>)0x00593B10)(ref this);

    /// <summary>Obtains a human‑readable string describing the object's data category and writes it into the supplied buffer.
    /// <code>Offset: 0x00593C00
    /// int __thiscall CACQualities::InqWeenieTypeString(CACQualities*,char*,const unsigned int)</code>
    /// </summary>
    /// <param name="buff">Buffer that receives the type string; must be large enough to hold the result.</param>
    /// <param name="size">Maximum number of characters (including terminating null) that may be written to buff.</param>
    /// <returns>Zero on success; a negative value indicates an error or insufficient buffer size.</returns>
    public int InqWeenieTypeString(sbyte* buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, sbyte*, uint, int>)0x00593C00)(ref this, buff, size);

    /// <summary>Sets bits in the supplied bitfield to indicate which optional subcomponents are present within the CACQualities instance.
    /// <code>Offset: 0x00593C20
    /// void __thiscall CACQualities::SetPackHeader(CACQualities*,unsigned int*)</code>
    /// </summary>
    /// <param name="bitfield">Pointer to an unsigned integer that will receive flag bits representing available subcomponents.</param>
    public void SetPackHeader(uint* bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint*, void>)0x00593C20)(ref this, bitfield);

    /// <summary>Calculates the combined memory size of a CACQualities object and its associated data structures.
    /// <code>Offset: 0x00593CC0
    /// unsigned int __thiscall CACQualities::GetPackSize(CACQualities*)</code>
    /// </summary>
    /// <returns>The total size in bytes required to serialize the object's packed representation.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint>)0x00593CC0)(ref this);

    /// <summary>Creates a CACQualities instance, initializing its DBObj and CBaseQualities bases with supplied data and clearing optional component pointers.
    /// <code>Offset: 0x00593E70
    /// int __thiscall CACQualities::CACQualities(int,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to initialization data passed to the base classes.</param>
    /// <returns>Pointer to the constructed CACQualities object.</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, void**, int>)0x00593E70)(ref this, a2);

    /// <summary>Returns the database object type identifier for CACQualities objects.
    /// <code>Offset: 0x00593EF0
    /// unsigned int __thiscall CACQualities::GetDBOType(CACQualities*)</code>
    /// </summary>
    /// <returns>The constant DBO type value (268435457).</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint>)0x00593EF0)(ref this);

    /// <summary>Allocates a new CACQualities instance and returns its underlying DBObj base class pointer. If memory allocation fails, returns null.
    /// <code>Offset: 0x00593FF0
    /// DBObj* __cdecl CACQualities::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed DBObj base class of a CACQualities object or null on failure.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x00593FF0)();

    /// <summary>Serializes a CACQualities instance into the supplied buffer, writing its base qualities, all stat tables, and a pointer to its GeneratorRegistry. Packing occurs only when the provided buffer size is sufficient; otherwise no data is written.
    /// <code>Offset: 0x00594020
    /// unsigned int __thiscall CACQualities::Pack(CACQualities*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer. On return, *addr points just past the end of the serialized block.</param>
    /// <param name="size">Maximum number of bytes available in the destination buffer; must be at least the required pack size for the object.</param>
    /// <returns>The reference count returned by IUnknown_Release on this CACQualities instance after packing. This value is unrelated to the amount of data written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, void**, uint, uint>)0x00594020)(ref this, addr, size);

    /// <summary>Packs the CACQualities object's data into an array of void pointers by delegating to the underlying Pack method.
    /// <code>Offset: 0x005941C0
    /// unsigned int __thiscall CACQualities::Pack2(char*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The output buffer that will receive the packed objects.</param>
    /// <param name="a3">The maximum number of items to pack into the output buffer.</param>
    /// <returns>Number of items successfully packed.</returns>
    public uint Pack2(void** a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, void**, uint, uint>)0x005941C0)(ref this, a2, a3);

    /// <summary>Deserializes a CACQualities instance from a binary buffer, restoring its attributes and related tables according to flags embedded in the stream.
    /// <code>Offset: 0x005941D0
    /// int __thiscall CACQualities::UnPack(CACQualities*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the source buffer; updated to point after the data that was unpacked.</param>
    /// <param name="size">Number of bytes remaining in the buffer available for unpacking.</param>
    /// <returns>Non‑zero if all required data was successfully unpacked; zero on failure or insufficient data.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, void**, uint, int>)0x005941D0)(ref this, addr, size);

    /// <summary>Unpacks the packed quality data of this CACQualities instance into the supplied buffers.
    /// <code>Offset: 0x00594760
    /// int __thiscall CACQualities::UnPack2(char*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Output array receiving pointers to unpacked data objects.</param>
    /// <param name="a3">The number of elements or size limit for the unpacking operation.</param>
    /// <returns>A status code: non‑zero on success, zero indicates failure or no data was extracted.</returns>
    public int UnPack2(void** a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, void**, uint, int>)0x00594760)(ref this, a2, a3);
}

