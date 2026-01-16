namespace ACBindings.Internal;


/// <summary>Manages character generation state during creation, storing appearance, attributes, skills, and related metadata.</summary>
public unsafe struct CharGenState : System.IDisposable
{
    // Child Types
    public unsafe struct CharGenState_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharGenState*, void> UpdateTrueFacePal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharGenState*, int, int> GetRandomInt; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharGenState*, double> GetRandomReal; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.ACCharGenResult charGenResult;
    public int beginRequest;
    public int heritageGroupFrozen;
    public int sexFrozen;
    public int appearanceFrozen;
    public int clothingFrozen;
    public uint mHeritageGroup;
    public uint mGender;
    public int eyesStrip;
    public int noseStrip;
    public int mouthStrip;
    public int hairColor;
    public int eyeColor;
    public int hairStyle;
    public int headgearStyle;
    public int headgearColor;
    public int shirtStyle;
    public int shirtColor;
    public int trousersStyle;
    public int trousersColor;
    public int footwearStyle;
    public int footwearColor;
    public int numHeadgearColors;
    public int numShirtColors;
    public int numTrousersColors;
    public int numFootwearColors;
    public uint* headgearPaletteTemplateIDs;
    public uint* shirtPaletteTemplateIDs;
    public uint* trousersPaletteTemplateIDs;
    public uint* footwearPaletteTemplateIDs;
    public System.IntPtr headgearPalSetIDs;
    public System.IntPtr shirtPalSetIDs;
    public System.IntPtr trousersPalSetIDs;
    public System.IntPtr footwearPalSetIDs;
    public double skinShade;
    public double hairShade;
    public double headgearShade;
    public double shirtShade;
    public double trousersShade;
    public double footwearShade;
    public ACBindings.Internal.Method_CG method;
    public ACBindings.Internal.AdvancedMethod_CG advancedMethod;
    public int template_;
    public int strength;
    public int endurance;
    public int coordination;
    public int quickness;
    public int focus;
    public int self;
    public int totalAtrbCredits;
    public int remainingAtrbCredits;
    public int atrbMin;
    public int atrbMax;
    public int totalNumSkills;
    public ACBindings.Internal.SKILL_ADVANCEMENT_CLASS* skillLevels;
    public int totalSkillCredits;
    public int remainingSkillCredits;
    public int* spellKnown;
    public ACBindings.Internal.List___SkillRecord_ptr skillRecordList;
    public fixed sbyte name[33];
    public int linkingWord;
    public int startArea;
    public ACBindings.Internal.IDClass____tagDataID setupID;
    public ACBindings.Internal.IDClass____tagDataID animID;
    public int setupChanged;
    public int slot;
    public fixed sbyte password[20];
    public ACBindings.Internal.CG_VERIFICATION_RESPONSE verificationState;
    public int createAsAdmin;
    public int createAsEnvoy;
    public fixed int bAttribLocked[7];
    public ACBindings.Internal.SkillTable* skillTable;
    public ACBindings.Internal.Attribute2ndTable* attribute2ndTable;
    public ACBindings.Internal.EnterChargen enterChargen;
    public ACBindings.Internal.ACCharGenData* charGenData;

    // Generated Constructor
    public CharGenState() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Provides a random integer within the specified upper bound using the character generation state’s RNG.
    /// <code>Offset: 0x005646B0
    /// int __thiscall CharGenState::GetRandomInt(CharGenState*,int)</code>
    /// </summary>
    /// <param name="range">The exclusive upper limit for the generated integer.</param>
    /// <returns>A randomly selected integer from 0 up to, but not including, range.</returns>
    public int GetRandomInt(int range) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005646B0)(ref this, range);

    /// <summary>Returns a random integer from 0 to range‑1, avoiding a specified excluded value if it falls within the range.
    /// <code>Offset: 0x005646C0
    /// int __thiscall CharGenState::GetRandomInt(CharGenState*,int,int)</code>
    /// </summary>
    /// <param name="range">Upper bound of the random range (exclusive).</param>
    /// <param name="exclude">Value that should not be returned; if present in the range, another number is selected.</param>
    /// <returns>A random integer between 0 and range‑1 that differs from exclude.</returns>
    public int GetRandomInt(int range, int exclude) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005646C0)(ref this, range, exclude);

    /// <summary>Produces a pseudo‑random real number between 0 and 1 using the standard library’s rand function.
    /// <code>Offset: 0x005646E0
    /// long double __thiscall CharGenState::GetRandomReal(CharGenState*)</code>
    /// </summary>
    /// <returns>A double‑precision value in the interval [0, 1).</returns>
    public double GetRandomReal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, double>)0x005646E0)(ref this);

    /// <summary>Sets the character generation verification state to the specified value.
    /// <code>Offset: 0x005C4780
    /// void __thiscall CharGenState::SetVerificationState(CharGenState*,CG_VERIFICATION_RESPONSE)</code>
    /// </summary>
    /// <param name="verificationState">The verification response to assign to the state.</param>
    public void SetVerificationState(ACBindings.Internal.CG_VERIFICATION_RESPONSE verificationState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void>)0x005C4780)(ref this, verificationState);

    /// <summary>Retrieves the current verification state of the character generation session.
    /// <code>Offset: 0x005C4790
    /// CG_VERIFICATION_RESPONSE __thiscall CharGenState::GetVerificationState(CharGenState*)</code>
    /// </summary>
    /// <returns>The verification response indicating whether the character data passes validation checks.</returns>
    public ACBindings.Internal.CG_VERIFICATION_RESPONSE GetVerificationState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, ACBindings.Internal.CG_VERIFICATION_RESPONSE>)0x005C4790)(ref this);

    /// <summary>Recalculates the number of unused skill credits by subtracting the costs of all trained and specialized skills from the total available credits.
    /// <code>Offset: 0x005C47A0
    /// void __thiscall CharGenState::UpdateRemainingSkillCredits(CharGenState*)</code>
    /// </summary>
    public void UpdateRemainingSkillCredits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C47A0)(ref this);

    /// <summary>Sets the character’s skin shade and updates the face palette with the new value.
    /// <code>Offset: 0x005C4830
    /// long double __thiscall CharGenState::SetSkinShade(CharGenState*,long double)</code>
    /// </summary>
    /// <param name="skinShade">The desired skin shade to apply.</param>
    /// <returns>The updated skin shade stored in the CharGenState instance.</returns>
    public double SetSkinShade(double skinShade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, double, double>)0x005C4830)(ref this, skinShade);

    /// <summary>Sets the hair shade for a character, updates facial palette accordingly, and returns the applied shade.
    /// <code>Offset: 0x005C4860
    /// long double __thiscall CharGenState::SetHairShade(CharGenState*,long double)</code>
    /// </summary>
    /// <param name="hairShade">The desired hair shade value to apply.</param>
    /// <returns>The updated hair shade after setting it.</returns>
    public double SetHairShade(double hairShade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, double, double>)0x005C4860)(ref this, hairShade);

    /// <summary>Assigns a new hair color and refreshes the face palette.
    /// <code>Offset: 0x005C4890
    /// int __thiscall CharGenState::SetHairColor(CharGenState*,int)</code>
    /// </summary>
    /// <param name="hairColor">Identifier of the desired hair color.</param>
    /// <returns>The updated hair color value stored in the character state.</returns>
    public int SetHairColor(int hairColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005C4890)(ref this, hairColor);

    /// <summary>Assigns the character's eye color and refreshes the face palette to reflect the change.
    /// <code>Offset: 0x005C48B0
    /// int __thiscall CharGenState::SetEyeColor(CharGenState*,int)</code>
    /// </summary>
    /// <param name="eyeColor">The new eye color identifier.</param>
    /// <returns>The updated eye color value stored in the state.</returns>
    public int SetEyeColor(int eyeColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005C48B0)(ref this, eyeColor);

    /// <summary>Retrieves the palette template ID for a headgear color at the specified index, returning zero if the index is out of bounds.
    /// <code>Offset: 0x005C48D0
    /// unsigned int __thiscall CharGenState::GetHeadgearPaletteTemplateID(CharGenState*,int)</code>
    /// </summary>
    /// <param name="num">Index of the desired headgear color (0‑based).</param>
    /// <returns>The unsigned integer template ID or 0 when the index exceeds available colors or is negative.</returns>
    public uint GetHeadgearPaletteTemplateID(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, uint>)0x005C48D0)(ref this, num);

    /// <summary>Retrieves the palette template identifier corresponding to a specified shirt color index, returning 0 when the index is out of bounds.
    /// <code>Offset: 0x005C4900
    /// unsigned int __thiscall CharGenState::GetShirtPaletteTemplateID(CharGenState*,int)</code>
    /// </summary>
    /// <param name="num">The zero‑based index of the desired shirt color.</param>
    /// <returns>The palette template ID for the requested shirt color or 0 if the index is invalid.</returns>
    public uint GetShirtPaletteTemplateID(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, uint>)0x005C4900)(ref this, num);

    /// <summary>Returns the palette template identifier used for the specified trousers color slot, or 0 if the index is outside the valid range.
    /// <code>Offset: 0x005C4930
    /// unsigned int __thiscall CharGenState::GetTrousersPaletteTemplateID(CharGenState*,int)</code>
    /// </summary>
    /// <param name="num">The zero‑based index of the trousers color to query.</param>
    /// <returns>The palette template ID associated with that trousers color, or 0 when <paramref name="num"/> exceeds available colors.</returns>
    public uint GetTrousersPaletteTemplateID(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, uint>)0x005C4930)(ref this, num);

    /// <summary>Retrieves the footwear palette template ID for a given index; returns 0 if the index falls outside the valid range.
    /// <code>Offset: 0x005C4960
    /// unsigned int __thiscall CharGenState::GetFootwearPaletteTemplateID(CharGenState*,int)</code>
    /// </summary>
    /// <param name="num">The zero-based index into the footwear color palette array.</param>
    /// <returns>The template ID corresponding to the requested footwear color, or 0 when the index is invalid.</returns>
    public uint GetFootwearPaletteTemplateID(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, uint>)0x005C4960)(ref this, num);

    /// <summary>Retrieves the value of a specified character attribute.
    /// <code>Offset: 0x005C4990
    /// int __thiscall CharGenState::GetAttribute(CharGenState*,unsigned int)</code>
    /// </summary>
    /// <param name="attr">Identifier for the desired attribute (1: Strength, 2: Endurance, 3: Quickness, 4: Coordination, 5: Focus, 6: Self).</param>
    /// <returns>The integer value of the requested attribute or zero when an invalid identifier is supplied.</returns>
    public int GetAttribute(uint attr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, int>)0x005C4990)(ref this, attr);

    /// <summary>Returns the human‑readable name of a character attribute based on the supplied index.
    /// <code>Offset: 0x005C4A00
    /// void __thiscall CharGenState::GetAttributeName(CharGenState*,unsigned int,char*)</code>
    /// </summary>
    /// <param name="attr">Numeric identifier for the attribute to look up.</param>
    /// <param name="o_string">Buffer that receives the attribute name; set to an empty string if the index is unknown.</param>
    public void GetAttributeName(uint attr, sbyte* o_string) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, sbyte*, void>)0x005C4A00)(ref this, attr, o_string);

    /// <summary>Calculates absolute remaining attribute credits by subtracting each attribute’s value from the total credits, using a default value of 10 for unlocked attributes that are not currently selected.
    /// <code>Offset: 0x005C4B00
    /// int __thiscall CharGenState::GetAbsRemainingCredits(CharGenState*,unsigned int)</code>
    /// </summary>
    /// <param name="curAtrb">The index (1‑6) of the attribute currently being edited.</param>
    /// <returns>The number of unused attribute credits after accounting for all attribute values.</returns>
    public int GetAbsRemainingCredits(uint curAtrb) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, int>)0x005C4B00)(ref this, curAtrb);

    /// <summary>Resets all secondary attribute lock flags to unlocked state, preserving the initial lock status of the first attribute.
    /// <code>Offset: 0x005C4BA0
    /// void __thiscall CharGenState::ResetAttributeLock(CharGenState*)</code>
    /// </summary>
    public void ResetAttributeLock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C4BA0)(ref this);

    /// <summary>Sets the lock state for a specific character attribute.
    /// <code>Offset: 0x005C4BC0
    /// void __thiscall CharGenState::LockAttribute(CharGenState*,unsigned int,int)</code>
    /// </summary>
    /// <param name="attr">Index of the attribute to modify (valid values 1–6; zero is ignored).</param>
    /// <param name="lock">Value indicating whether to lock (non‑zero) or unlock (zero).</param>
    public void LockAttribute(uint attr, int lock_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, int, void>)0x005C4BC0)(ref this, attr, lock_);

    /// <summary>Retrieves the advancement class for a specified skill index within the character generation state.
    /// <code>Offset: 0x005C4BE0
    /// SKILL_ADVANCEMENT_CLASS __thiscall CharGenState::GetSkillLevel(CharGenState*,unsigned int)</code>
    /// </summary>
    /// <param name="skill">The zero‑based index of the skill whose level is requested.</param>
    /// <returns>The SKILL_ADVANCEMENT_CLASS value for the given skill, or 0 if the index exceeds totalNumSkills.</returns>
    public ACBindings.Internal.SKILL_ADVANCEMENT_CLASS GetSkillLevel(uint skill) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS>)0x005C4BE0)(ref this, skill);

    /// <summary>Assigns a new advancement level to the specified skill, adjusting remaining credits and updating internal state only if the operation is valid.
    /// <code>Offset: 0x005C4C00
    /// int __thiscall CharGenState::SetSkillLevel(CharGenState*,unsigned int,SKILL_ADVANCEMENT_CLASS)</code>
    /// </summary>
    /// <param name="skillNum">Zero‑based index of the skill whose level is being changed.</param>
    /// <param name="skillLevel">Desired SKILL_ADVANCEMENT_CLASS value (untrained, trained or specialized).</param>
    /// <returns>1 when the skill level was set successfully; 0 if the inputs are invalid or insufficient credits remain.</returns>
    public int SetSkillLevel(uint skillNum, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS skillLevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, int>)0x005C4C00)(ref this, skillNum, skillLevel);

    /// <summary>Sets the character's name to the supplied string when it fits within 32 characters and then formats the result.
    /// <code>Offset: 0x005C4CF0
    /// void __thiscall CharGenState::SetName(CharGenState*,const char*)</code>
    /// </summary>
    /// <param name="name">Null‑terminated string containing the desired name; must not exceed 32 characters.</param>
    public void SetName(sbyte* name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, sbyte*, void>)0x005C4CF0)(ref this, name);

    /// <summary>Assigns the specified slot index to this character generation state.
    /// <code>Offset: 0x005C4D40
    /// void __thiscall CharGenState::SetSlot(CharGenState*,int)</code>
    /// </summary>
    /// <param name="slot">The new slot identifier.</param>
    public void SetSlot(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, void>)0x005C4D40)(ref this, slot);

    /// <summary>Retrieves the headgear palette set identifier at the specified index and stores it in the provided output variable.
    /// <code>Offset: 0x005C4D50
    /// _DWORD* __thiscall CharGenState::GetHeadgearPalSetID(_DWORD*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the retrieved palette set ID.</param>
    /// <param name="a3">Index of the desired headgear palette within the state's collection.</param>
    /// <returns>Pointer to a2 containing the fetched headgear palette set ID.</returns>
    public int* GetHeadgearPalSetID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int*, int, int*>)0x005C4D50)(ref this, a2, a3);

    /// <summary>Retrieves the shirt palette set ID at the specified index and stores it into the supplied DWORD pointer.
    /// <code>Offset: 0x005C4D70
    /// _DWORD* __thiscall CharGenState::GetShirtPalSetID(_DWORD*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer where the retrieved shirt palette set ID will be written.</param>
    /// <param name="a3">Index of the desired shirt palette set within the internal array.</param>
    /// <returns>Returns the same pointer passed in as a2, allowing for chained usage.</returns>
    public int* GetShirtPalSetID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int*, int, int*>)0x005C4D70)(ref this, a2, a3);

    /// <summary>Retrieves a trousers palette set identifier from the character generation state based on the supplied index.
    /// <code>Offset: 0x005C4D90
    /// _DWORD* __thiscall CharGenState::GetTrousersPalSetID(_DWORD*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the retrieved palette set ID.</param>
    /// <param name="a3">Index of the desired trousers palette set within the internal array.</param>
    /// <returns>The same pointer provided in <paramref name="a2"/> after it has been populated with the selected palette set identifier.</returns>
    public int* GetTrousersPalSetID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int*, int, int*>)0x005C4D90)(ref this, a2, a3);

    /// <summary>Retrieves the footwear palette set identifier at the specified index and writes it into the supplied output variable.
    /// <code>Offset: 0x005C4DB0
    /// _DWORD* __thiscall CharGenState::GetFootwearPalSetID(_DWORD*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a DWORD that receives the retrieved palette set ID.</param>
    /// <param name="a3">Zero‑based index of the desired footwear palette template.</param>
    /// <returns>Returns the same pointer passed in as <c>a2</c> after storing the retrieved identifier.</returns>
    public int* GetFootwearPalSetID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int*, int, int*>)0x005C4DB0)(ref this, a2, a3);

    /// <summary>Balances the character’s attribute points so that the total does not exceed the available credits by decrementing excess points from unlocked attributes in a round‑robin fashion, respecting any fixed attribute.
    /// <code>Offset: 0x005C4DD0
    /// void __thiscall CharGenState::BalanceAttributes(CharGenState*,unsigned int)</code>
    /// </summary>
    /// <param name="fixedAtrb">Identifier of an attribute that should remain unchanged during balancing.</param>
    public void BalanceAttributes(uint fixedAtrb) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, void>)0x005C4DD0)(ref this, fixedAtrb);

    /// <summary>Sets the character's starting area to the specified index when it falls within the available list, or flags an invalid selection otherwise.
    /// <code>Offset: 0x005C4FE0
    /// void __thiscall CharGenState::SetStartArea(CharGenState*,int)</code>
    /// </summary>
    /// <param name="startArea">Index of the desired start area; must be non‑negative and less than the number of defined areas.</param>
    public void SetStartArea(int startArea) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, void>)0x005C4FE0)(ref this, startArea);

    /// <summary>
    /// Copies current character generation state into the internal result structure and returns a pointer to it, performing necessary memory cleanup, cloning of skill advancement classes, and setting class ID based on heritage group and admin/envoy flags.
    /// 
    /// <code>Offset: 0x005C5010
    /// ACCharGenResult* __thiscall CharGenState::GetCharGenResult(CharGenState*)</code>
    /// </summary>
    /// <returns>Pointer to the populated ACCharGenResult instance.</returns>
    public ACBindings.Internal.ACCharGenResult* GetCharGenResult() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, ACBindings.Internal.ACCharGenResult*>)0x005C5010)(ref this);

    /// <summary>Resets skill levels for the character by reinitializing each skill to untrained, trained, or specialized based on available credits and heritage/gender data.
    /// <code>Offset: 0x005C5390
    /// void __thiscall CharGenState::ResetSkillLevels(CharGenState*)</code>
    /// </summary>
    public void ResetSkillLevels() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C5390)(ref this);

    /// <summary>Collects palette and sub‑palette effect identifiers from the character generation database for the specified palette table, allocating arrays for the results and recording how many entries were stored.
    /// <code>Offset: 0x005C54B0
    /// void __stdcall CharGenState::StoreColorInformation(int,_DWORD*,void**,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a1">Identifier of the palette table to query.</param>
    /// <param name="a2">Output parameter that receives the number of palette entries written into *a3.</param>
    /// <param name="a3">Pointer to an array where matching color identifiers are written; any existing allocation is freed and new storage is allocated before populating the array.</param>
    /// <param name="a4">Pointer to an array where corresponding sub‑palette effect identifiers are written; behaves like *a3 with memory management.</param>
    /// <param name="a5">Reference to the CharGenState instance whose current color selections determine which palette entries are included.</param>
    public static void StoreColorInformation(int a1, int* a2, void** a3, int* a4, int a5) => ((delegate* unmanaged[Stdcall]<int, int*, void**, int*, int, void>)0x005C54B0)(a1, a2, a3, a4, a5);

    /// <summary>Sets a character's Strength attribute, ensuring sufficient credits remain, updates remaining credit count, and optionally rebalances other attributes.
    /// <code>Offset: 0x005C5640
    /// int __thiscall CharGenState::SetStrength(CharGenState*,int,int)</code>
    /// </summary>
    /// <param name="strength">The desired Strength value to assign.</param>
    /// <param name="balance">If non‑zero, triggers a rebalance of all attributes after setting Strength.</param>
    /// <returns>The final Strength value stored in the character state.</returns>
    public int SetStrength(int strength, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C5640)(ref this, strength, balance);

    /// <summary>Updates the character’s endurance attribute, enforcing credit limits when increasing it. If requested, rebalances associated attributes and updates remaining attribute credits.
    /// <code>Offset: 0x005C56C0
    /// int __thiscall CharGenState::SetEndurance(CharGenState*,int,int)</code>
    /// </summary>
    /// <param name="endurance">The desired new endurance value.</param>
    /// <param name="balance">True to trigger a balance of related attributes after setting endurance.</param>
    /// <returns>The character’s endurance after the update (unchanged if insufficient credits for an increase).</returns>
    public int SetEndurance(int endurance, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C56C0)(ref this, endurance, balance);

    /// <summary>Sets the character's coordination attribute to a new value if sufficient credits remain; optionally balances remaining attributes and updates credit totals.
    /// <code>Offset: 0x005C5740
    /// int __thiscall CharGenState::SetCoordination(CharGenState*,int,int)</code>
    /// </summary>
    /// <param name="coordination">The desired coordination level to assign to the character.</param>
    /// <param name="balance">If non-zero, triggers rebalancing of other attributes after setting coordination.</param>
    /// <returns>The updated coordination value (or the original value if the change was not allowed).</returns>
    public int SetCoordination(int coordination, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C5740)(ref this, coordination, balance);

    /// <summary>Assigns a new Quickness value, consuming attribute credits when possible; optionally rebalances the related attribute group.
    /// <code>Offset: 0x005C57C0
    /// int __thiscall CharGenState::SetQuickness(CharGenState*,int,int)</code>
    /// </summary>
    /// <param name="quickness">Desired Quickness level. If it exceeds the current value and no remaining credits are available, the method leaves the attribute unchanged.</param>
    /// <param name="balance">When true, triggers a rebalance of all attributes in the same group after setting Quickness.</param>
    /// <returns>Current Quickness after the operation (unchanged if the new value could not be applied).</returns>
    public int SetQuickness(int quickness, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C57C0)(ref this, quickness, balance);

    /// <summary>Sets the character's focus attribute while ensuring attribute credit limits are respected and optionally balances other attributes.
    /// <code>Offset: 0x005C5840
    /// int __thiscall CharGenState::SetFocus(CharGenState*,int,int)</code>
    /// </summary>
    /// <param name="focus">The desired focus value to assign.</param>
    /// <param name="balance">When non‑zero, rebalance remaining attributes after setting focus.</param>
    /// <returns>The focus value that was set (unchanged if the increase would exceed available credits).</returns>
    public int SetFocus(int focus, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C5840)(ref this, focus, balance);

    /// <summary>Sets the Self attribute of a character generation state, enforcing credit limits and optionally rebalancing other attributes.
    /// <code>Offset: 0x005C58C0
    /// int __thiscall CharGenState::SetSelf(CharGenState*,int,int)</code>
    /// </summary>
    /// <param name="self">Desired new Self value to assign.</param>
    /// <param name="balance">Non‑zero triggers redistribution of remaining attribute credits after setting Self.</param>
    /// <returns>The resulting Self value after the operation; unchanged if insufficient credits were available.</returns>
    public int SetSelf(int self, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C58C0)(ref this, self, balance);

    /// <summary>Applies default attribute values, setting each primary stat to a minimum of 50 when possible, and then resets all skill levels according to the selected template.
    /// <code>Offset: 0x005C5970
    /// void __thiscall CharGenState::ApplyDefaultTemplate(CharGenState*)</code>
    /// </summary>
    public void ApplyDefaultTemplate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C5970)(ref this);

    /// <summary>Computes a character's effective score for a specified skill using base formula, attribute values, and advancement level; returns zero when the skill is undefined or below the minimum required level.
    /// <code>Offset: 0x005C5B30
    /// int __thiscall CharGenState::GetSkillScore(CharGenState*,unsigned int)</code>
    /// </summary>
    /// <param name="skill">Identifier of the skill whose score is to be calculated.</param>
    /// <returns>An integer representing the computed skill score, or 0 if the skill cannot be scored.</returns>
    public int GetSkillScore(uint skill) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, int>)0x005C5B30)(ref this, skill);

    /// <summary>Destroys a CharGenState instance by releasing allocated memory, cleaning up skill lists, palette data, and associated resources.
    /// <code>Offset: 0x005C5DB0
    /// void __thiscall CharGenState::~CharGenState(CharGenState*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C5DB0)(ref this);

    /// <summary>Randomizes the character's facial features and appearance based on the current heritage group, gender, and optional hairstyle restriction.
    /// <code>Offset: 0x005C5EF0
    /// void __thiscall CharGenState::RandomizeAppearance(CharGenState*,int)</code>
    /// </summary>
    /// <param name="restrict_hair">If non‑zero, limits hairstyle selection to a predefined subset; otherwise selects from the full list.</param>
    public void RandomizeAppearance(int restrict_hair) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, void>)0x005C5EF0)(ref this, restrict_hair);

    /// <summary>Resets attribute locks and applies the current template for the selected heritage group and gender, setting core attributes (strength, endurance, coordination, quickness, focus, self) and training all normal skills. For each primary skill in the template, attempts to upgrade it to a specialized level if sufficient remaining skill credits are available, deducting the appropriate cost from the character’s credit pool.
    /// <code>Offset: 0x005C6060
    /// void __thiscall CharGenState::ApplyTemplate(CharGenState*)</code>
    /// </summary>
    public void ApplyTemplate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C6060)(ref this);

    /// <summary>Determines whether the character’s current hairstyle results in a bald appearance by consulting the character’s heritage group, gender, and selected hair style.
    /// <code>Offset: 0x005C6280
    /// int __thiscall CharGenState::GetBaldState(CharGenState*)</code>
    /// </summary>
    /// <returns>An integer flag; non‑zero indicates that the character is considered bald, otherwise zero.</returns>
    public int GetBaldState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int>)0x005C6280)(ref this);

    /// <summary>Assigns a specified headgear style to the character, updating available colors and clamping the selected color within bounds.
    /// <code>Offset: 0x005C6330
    /// int __thiscall CharGenState::SetHeadgearStyle(CharGenState*,int)</code>
    /// </summary>
    /// <param name="headgearStyle">Index of the desired headgear style; -1 indicates no change to style selection.</param>
    /// <returns>The index of the headgear style that was set on the character.</returns>
    public int SetHeadgearStyle(int headgearStyle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005C6330)(ref this, headgearStyle);

    /// <summary>Sets the character's shirt style to the specified index, updating the shirt color palette when a valid heritage group and gender are present. Passing –1 assigns that value to shirtStyle but skips palette recalculation.
    /// <code>Offset: 0x005C6460
    /// int __thiscall CharGenState::SetShirtStyle(CharGenState*,int)</code>
    /// </summary>
    /// <param name="shirtStyle">Index of the desired shirt style; –1 indicates no palette update while still storing the value.</param>
    /// <returns>The index that was stored in the character’s shirtStyle field (the same value supplied as the argument).</returns>
    public int SetShirtStyle(int shirtStyle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005C6460)(ref this, shirtStyle);

    /// <summary>Assigns a new trousers style and updates colour information in the character generation state. When a valid heritage group and gender are present, the function loads available colours for the selected style; otherwise it leaves colour data unchanged.
    /// <code>Offset: 0x005C6580
    /// int __thiscall CharGenState::SetTrousersStyle(CharGenState*,int)</code>
    /// </summary>
    /// <param name="trousersStyle">Index of the desired trousers style. Passing -1 will still store that value but skip loading colour data.</param>
    /// <returns>The trousers style that was stored in the state (identical to the input argument).</returns>
    public int SetTrousersStyle(int trousersStyle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005C6580)(ref this, trousersStyle);

    /// <summary>Assigns the specified footwear style to the character, updating available color options when heritage and gender data are present.
    /// <code>Offset: 0x005C66A0
    /// int __thiscall CharGenState::SetFootwearStyle(CharGenState*,int)</code>
    /// </summary>
    /// <param name="footwearStyle">Index of the desired footwear style; -1 indicates no change.</param>
    /// <returns>The footwear style that was set.</returns>
    public int SetFootwearStyle(int footwearStyle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005C66A0)(ref this, footwearStyle);

    /// <summary>Randomly assigns skill advancement levels to a character's skill set within the constraints of available skill credits, taking into account the character’s heritage group and gender.
    /// <code>Offset: 0x005C67C0
    /// void __thiscall CharGenState::RandomizeSkills(CharGenState*)</code>
    /// </summary>
    /// <param name="this">The CharGenState instance whose skills will be randomized.</param>
    public void RandomizeSkills() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C67C0)(ref this);

    /// <summary>Randomizes the character’s starting area based on its heritage group, selecting a random entry from that group’s primary start‑area list or marking it as invalid when none are suitable.
    /// <code>Offset: 0x005C69C0
    /// void __thiscall CharGenState::RandomizeStartArea(CharGenState*)</code>
    /// </summary>
    public void RandomizeStartArea() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C69C0)(ref this);

    /// <summary>Sets the current character generation template and optionally applies its settings.
    /// <code>Offset: 0x005C6A40
    /// int __thiscall CharGenState::SetTemplate(CharGenState*,int,int)</code>
    /// </summary>
    /// <param name="templatea">The identifier of the template to apply.</param>
    /// <param name="apply">If non-zero, immediately apply the template's attributes; otherwise only store the ID.</param>
    /// <returns>The index of the currently set template after assignment.</returns>
    public int SetTemplate(int templatea, int apply) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C6A40)(ref this, templatea, apply);

    /// <summary>Determines the character's setup identifier based on current heritage, gender, and hairstyle selections, storing it in the supplied unsigned integer pointer.
    /// <code>Offset: 0x005C6A70
    /// unsigned int* __thiscall CharGenState::GetSetupID(int,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an unsigned integer where the resulting setup ID will be stored.</param>
    /// <returns>The same pointer that was passed in, pointing to the updated setup ID.</returns>
    public uint* GetSetupID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint*, uint*>)0x005C6A70)(ref this, a2);

    /// <summary>Constrains all character generation attributes to valid ranges based on the selected gender and heritage group, resetting or updating values as needed.
    /// <code>Offset: 0x005C6B60
    /// void __thiscall CharGenState::ConstrainAllByGender(CharGenState*)</code>
    /// </summary>
    public void ConstrainAllByGender() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C6B60)(ref this);

    /// <summary>Selects a random headgear style based on the character's heritage group and gender, optionally avoiding the current style, then assigns a random color from the available palette and applies a subtle shade variation. The function updates the CharGenState with new headgear style, color, and shade values if valid options exist.
    /// <code>Offset: 0x005C6DF0
    /// void __thiscall CharGenState::RandomizeHeadgear(CharGenState*,int)</code>
    /// </summary>
    /// <param name="excludeCurrent">If non‑zero, prevents selecting the currently equipped headgear style when choosing randomly.</param>
    public void RandomizeHeadgear(int excludeCurrent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, void>)0x005C6DF0)(ref this, excludeCurrent);

    /// <summary>Randomizes shirt style and color based on the character's heritage group and gender, then applies a random shade factor.
    /// <code>Offset: 0x005C6ED0
    /// void __thiscall CharGenState::RandomizeShirt(CharGenState*)</code>
    /// </summary>
    public void RandomizeShirt() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C6ED0)(ref this);

    /// <summary>Randomizes the character's trousers style, color, and shade based on the current heritage group and gender. Selects a random pant style from the available list if any, assigns a random color when available, and generates a subtle random shade variation.
    /// <code>Offset: 0x005C6F90
    /// void __thiscall CharGenState::RandomizeTrousers(CharGenState*)</code>
    /// </summary>
    public void RandomizeTrousers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C6F90)(ref this);

    /// <summary>Randomly selects a footwear style from the character’s heritage‑group/gender list, chooses a random color if available, and sets a new shade value.
    /// <code>Offset: 0x005C7050
    /// void __thiscall CharGenState::RandomizeFootwear(CharGenState*)</code>
    /// </summary>
    public void RandomizeFootwear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C7050)(ref this);

    /// <summary>Selects the most suitable character template for the current state based on heritage group, gender, attributes and skill levels, assigning the chosen template ID if it meets a minimum fitness threshold.
    /// <code>Offset: 0x005C7110
    /// void __thiscall CharGenState::FitTemplateToCharacter(CharGenState*)</code>
    /// </summary>
    public void FitTemplateToCharacter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C7110)(ref this);

    /// <summary>Assigns a new gender to the character state, updating appearance constraints, face palette, and reapplying headgear, shirt, trousers, and footwear styles accordingly.
    /// <code>Offset: 0x005C7480
    /// void __thiscall CharGenState::SetGender(CharGenState*,unsigned int)</code>
    /// </summary>
    /// <param name="gender">The gender value to set for the character.</param>
    public void SetGender(uint gender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, void>)0x005C7480)(ref this, gender);

    /// <summary>Randomizes the character’s template based on its heritage group and gender, selecting an appropriate template from the available list and applying it to the state.
    /// <code>Offset: 0x005C74E0
    /// void __thiscall CharGenState::RandomizeTemplate(CharGenState*)</code>
    /// </summary>
    public void RandomizeTemplate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C74E0)(ref this);

    /// <summary>Constrains the character's generation state to satisfy restrictions imposed by its heritage group, resetting template indices, attribute and skill credit limits, and applying gender-based constraints as necessary. If no heritage is selected, defaults are applied.
    /// <code>Offset: 0x005C7570
    /// void __thiscall CharGenState::ConstrainAllByHeritage(CharGenState*)</code>
    /// </summary>
    public void ConstrainAllByHeritage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C7570)(ref this);

    /// <summary>Randomly assigns new headgear, shirt, trousers and footwear to the character, optionally retaining the current headgear when requested.
    /// <code>Offset: 0x005C7750
    /// void __thiscall CharGenState::RandomizeClothing(CharGenState*,int)</code>
    /// </summary>
    /// <param name="excludeCurrent">If non-zero, the existing headgear style is preserved during randomization; otherwise a new headgear style is chosen.</param>
    public void RandomizeClothing(int excludeCurrent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, void>)0x005C7750)(ref this, excludeCurrent);

    /// <summary>Assigns the specified heritage group to the character, updates template data, recalculates attribute and skill credit pools, randomizes starting location, enforces heritage constraints, and refreshes appearance settings.
    /// <code>Offset: 0x005C7780
    /// void __thiscall CharGenState::SetHeritageGroup(CharGenState*,unsigned int)</code>
    /// </summary>
    /// <param name="heritageGroup">Identifier of the heritage group to assign.</param>
    public void SetHeritageGroup(uint heritageGroup) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, void>)0x005C7780)(ref this, heritageGroup);

    /// <summary>Resets the character generation state to its initial defaults, clearing verification status, unfreezing attributes, resetting appearance parameters, and applying a standard template.
    /// <code>Offset: 0x005C7880
    /// void __thiscall CharGenState::Reset(CharGenState*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C7880)(ref this);

    /// <summary>Randomizes the character's heritage group, selecting a value between 1 and 4 when a throne of destiny is present or 1 to 3 otherwise.
    /// <code>Offset: 0x005C7A00
    /// void __thiscall CharGenState::RandomizeHeritageGroup(CharGenState*,bool)</code>
    /// </summary>
    /// <param name="hasThroneOfDestiny">If true, an additional heritage option is available; if false only three options are considered.</param>
    public void RandomizeHeritageGroup(byte hasThroneOfDestiny) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, byte, void>)0x005C7A00)(ref this, hasThroneOfDestiny);

    /// <summary>Initializes a CharGenState instance with default character generation settings, loads required tables, and prepares the skill record list and advancement slots.
    /// <code>Offset: 0x005C7A30
    /// void __thiscall CharGenState::CharGenState(CharGenState*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C7A30)(ref this);

    /// <summary>Randomizes a character's attributes, selecting a heritage group (with an optional throne variant), gender, appearance, clothing, template and start area, then freezes the heritage, sex and appearance properties.
    /// <code>Offset: 0x005C7D60
    /// void __thiscall CharGenState::RandomizeCharacter(CharGenState*,bool)</code>
    /// </summary>
    /// <param name="hasThroneOfDestiny">If true, includes an additional heritage group option when randomizing; otherwise uses the standard range.</param>
    public void RandomizeCharacter(byte hasThroneOfDestiny) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, byte, void>)0x005C7D60)(ref this, hasThroneOfDestiny);
}

