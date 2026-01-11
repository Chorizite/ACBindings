namespace ACBindings.Internal;

public unsafe struct CharGenState : System.IDisposable
{
    // Child Types
    public unsafe struct CharGenState_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharGenState*, void> UpdateTrueFacePal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharGenState*, int, int> GetRandomInt; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharGenState*, double> GetRandomReal; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x005646B0
    /// int __thiscall CharGenState::GetRandomInt(CharGenState*,int)</code>
    /// </summary>
    public int GetRandomInt(int range) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005646B0)(ref this, range);

    /// <summary>
    /// <code>Offset: 0x005646C0
    /// int __thiscall CharGenState::GetRandomInt(CharGenState*,int,int)</code>
    /// </summary>
    public int GetRandomInt(int range, int exclude) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005646C0)(ref this, range, exclude);

    /// <summary>
    /// <code>Offset: 0x005646E0
    /// long double __thiscall CharGenState::GetRandomReal(CharGenState*)</code>
    /// </summary>
    public double GetRandomReal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, double>)0x005646E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C4780
    /// void __thiscall CharGenState::SetVerificationState(CharGenState*,CG_VERIFICATION_RESPONSE)</code>
    /// </summary>
    public void SetVerificationState(ACBindings.Internal.CG_VERIFICATION_RESPONSE verificationState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void>)0x005C4780)(ref this, verificationState);

    /// <summary>
    /// <code>Offset: 0x005C4790
    /// CG_VERIFICATION_RESPONSE __thiscall CharGenState::GetVerificationState(CharGenState*)</code>
    /// </summary>
    public ACBindings.Internal.CG_VERIFICATION_RESPONSE GetVerificationState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, ACBindings.Internal.CG_VERIFICATION_RESPONSE>)0x005C4790)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C47A0
    /// void __thiscall CharGenState::UpdateRemainingSkillCredits(CharGenState*)</code>
    /// </summary>
    public void UpdateRemainingSkillCredits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C47A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C4830
    /// long double __thiscall CharGenState::SetSkinShade(CharGenState*,long double)</code>
    /// </summary>
    public double SetSkinShade(double skinShade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, double, double>)0x005C4830)(ref this, skinShade);

    /// <summary>
    /// <code>Offset: 0x005C4860
    /// long double __thiscall CharGenState::SetHairShade(CharGenState*,long double)</code>
    /// </summary>
    public double SetHairShade(double hairShade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, double, double>)0x005C4860)(ref this, hairShade);

    /// <summary>
    /// <code>Offset: 0x005C4890
    /// int __thiscall CharGenState::SetHairColor(CharGenState*,int)</code>
    /// </summary>
    public int SetHairColor(int hairColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005C4890)(ref this, hairColor);

    /// <summary>
    /// <code>Offset: 0x005C48B0
    /// int __thiscall CharGenState::SetEyeColor(CharGenState*,int)</code>
    /// </summary>
    public int SetEyeColor(int eyeColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005C48B0)(ref this, eyeColor);

    /// <summary>
    /// <code>Offset: 0x005C48D0
    /// unsigned int __thiscall CharGenState::GetHeadgearPaletteTemplateID(CharGenState*,int)</code>
    /// </summary>
    public uint GetHeadgearPaletteTemplateID(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, uint>)0x005C48D0)(ref this, num);

    /// <summary>
    /// <code>Offset: 0x005C4900
    /// unsigned int __thiscall CharGenState::GetShirtPaletteTemplateID(CharGenState*,int)</code>
    /// </summary>
    public uint GetShirtPaletteTemplateID(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, uint>)0x005C4900)(ref this, num);

    /// <summary>
    /// <code>Offset: 0x005C4930
    /// unsigned int __thiscall CharGenState::GetTrousersPaletteTemplateID(CharGenState*,int)</code>
    /// </summary>
    public uint GetTrousersPaletteTemplateID(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, uint>)0x005C4930)(ref this, num);

    /// <summary>
    /// <code>Offset: 0x005C4960
    /// unsigned int __thiscall CharGenState::GetFootwearPaletteTemplateID(CharGenState*,int)</code>
    /// </summary>
    public uint GetFootwearPaletteTemplateID(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, uint>)0x005C4960)(ref this, num);

    /// <summary>
    /// <code>Offset: 0x005C4990
    /// int __thiscall CharGenState::GetAttribute(CharGenState*,unsigned int)</code>
    /// </summary>
    public int GetAttribute(uint attr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, int>)0x005C4990)(ref this, attr);

    /// <summary>
    /// <code>Offset: 0x005C4A00
    /// void __thiscall CharGenState::GetAttributeName(CharGenState*,unsigned int,char*)</code>
    /// </summary>
    public void GetAttributeName(uint attr, sbyte* o_string) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, sbyte*, void>)0x005C4A00)(ref this, attr, o_string);

    /// <summary>
    /// <code>Offset: 0x005C4B00
    /// int __thiscall CharGenState::GetAbsRemainingCredits(CharGenState*,unsigned int)</code>
    /// </summary>
    public int GetAbsRemainingCredits(uint curAtrb) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, int>)0x005C4B00)(ref this, curAtrb);

    /// <summary>
    /// <code>Offset: 0x005C4BA0
    /// void __thiscall CharGenState::ResetAttributeLock(CharGenState*)</code>
    /// </summary>
    public void ResetAttributeLock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C4BA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C4BC0
    /// void __thiscall CharGenState::LockAttribute(CharGenState*,unsigned int,int)</code>
    /// </summary>
    public void LockAttribute(uint attr, int lock_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, int, void>)0x005C4BC0)(ref this, attr, lock_);

    /// <summary>
    /// <code>Offset: 0x005C4BE0
    /// SKILL_ADVANCEMENT_CLASS __thiscall CharGenState::GetSkillLevel(CharGenState*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.SKILL_ADVANCEMENT_CLASS GetSkillLevel(uint skill) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS>)0x005C4BE0)(ref this, skill);

    /// <summary>
    /// <code>Offset: 0x005C4C00
    /// int __thiscall CharGenState::SetSkillLevel(CharGenState*,unsigned int,SKILL_ADVANCEMENT_CLASS)</code>
    /// </summary>
    public int SetSkillLevel(uint skillNum, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS skillLevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, int>)0x005C4C00)(ref this, skillNum, skillLevel);

    /// <summary>
    /// <code>Offset: 0x005C4CF0
    /// void __thiscall CharGenState::SetName(CharGenState*,const char*)</code>
    /// </summary>
    public void SetName(sbyte* name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, sbyte*, void>)0x005C4CF0)(ref this, name);

    /// <summary>
    /// <code>Offset: 0x005C4D40
    /// void __thiscall CharGenState::SetSlot(CharGenState*,int)</code>
    /// </summary>
    public void SetSlot(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, void>)0x005C4D40)(ref this, slot);

    /// <summary>
    /// <code>Offset: 0x005C4D50
    /// _DWORD* __thiscall CharGenState::GetHeadgearPalSetID(_DWORD*,_DWORD*,int)</code>
    /// </summary>
    public int* GetHeadgearPalSetID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int*, int, int*>)0x005C4D50)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005C4D70
    /// _DWORD* __thiscall CharGenState::GetShirtPalSetID(_DWORD*,_DWORD*,int)</code>
    /// </summary>
    public int* GetShirtPalSetID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int*, int, int*>)0x005C4D70)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005C4D90
    /// _DWORD* __thiscall CharGenState::GetTrousersPalSetID(_DWORD*,_DWORD*,int)</code>
    /// </summary>
    public int* GetTrousersPalSetID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int*, int, int*>)0x005C4D90)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005C4DB0
    /// _DWORD* __thiscall CharGenState::GetFootwearPalSetID(_DWORD*,_DWORD*,int)</code>
    /// </summary>
    public int* GetFootwearPalSetID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int*, int, int*>)0x005C4DB0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005C4DD0
    /// void __thiscall CharGenState::BalanceAttributes(CharGenState*,unsigned int)</code>
    /// </summary>
    public void BalanceAttributes(uint fixedAtrb) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, void>)0x005C4DD0)(ref this, fixedAtrb);

    /// <summary>
    /// <code>Offset: 0x005C4FE0
    /// void __thiscall CharGenState::SetStartArea(CharGenState*,int)</code>
    /// </summary>
    public void SetStartArea(int startArea) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, void>)0x005C4FE0)(ref this, startArea);

    /// <summary>
    /// <code>Offset: 0x005C5010
    /// ACCharGenResult* __thiscall CharGenState::GetCharGenResult(CharGenState*)</code>
    /// </summary>
    public ACBindings.Internal.ACCharGenResult* GetCharGenResult() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, ACBindings.Internal.ACCharGenResult*>)0x005C5010)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C5390
    /// void __thiscall CharGenState::ResetSkillLevels(CharGenState*)</code>
    /// </summary>
    public void ResetSkillLevels() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C5390)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C54B0
    /// void __stdcall CharGenState::StoreColorInformation(int,_DWORD*,void**,_DWORD*,int)</code>
    /// </summary>
    public static void StoreColorInformation(int a1, int* a2, void** a3, int* a4, int a5) => ((delegate* unmanaged[Stdcall]<int, int*, void**, int*, int, void>)0x005C54B0)(a1, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x005C5640
    /// int __thiscall CharGenState::SetStrength(CharGenState*,int,int)</code>
    /// </summary>
    public int SetStrength(int strength, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C5640)(ref this, strength, balance);

    /// <summary>
    /// <code>Offset: 0x005C56C0
    /// int __thiscall CharGenState::SetEndurance(CharGenState*,int,int)</code>
    /// </summary>
    public int SetEndurance(int endurance, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C56C0)(ref this, endurance, balance);

    /// <summary>
    /// <code>Offset: 0x005C5740
    /// int __thiscall CharGenState::SetCoordination(CharGenState*,int,int)</code>
    /// </summary>
    public int SetCoordination(int coordination, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C5740)(ref this, coordination, balance);

    /// <summary>
    /// <code>Offset: 0x005C57C0
    /// int __thiscall CharGenState::SetQuickness(CharGenState*,int,int)</code>
    /// </summary>
    public int SetQuickness(int quickness, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C57C0)(ref this, quickness, balance);

    /// <summary>
    /// <code>Offset: 0x005C5840
    /// int __thiscall CharGenState::SetFocus(CharGenState*,int,int)</code>
    /// </summary>
    public int SetFocus(int focus, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C5840)(ref this, focus, balance);

    /// <summary>
    /// <code>Offset: 0x005C58C0
    /// int __thiscall CharGenState::SetSelf(CharGenState*,int,int)</code>
    /// </summary>
    public int SetSelf(int self, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C58C0)(ref this, self, balance);

    /// <summary>
    /// <code>Offset: 0x005C5970
    /// void __thiscall CharGenState::ApplyDefaultTemplate(CharGenState*)</code>
    /// </summary>
    public void ApplyDefaultTemplate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C5970)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C5B30
    /// int __thiscall CharGenState::GetSkillScore(CharGenState*,unsigned int)</code>
    /// </summary>
    public int GetSkillScore(uint skill) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, int>)0x005C5B30)(ref this, skill);

    /// <summary>
    /// <code>Offset: 0x005C5DB0
    /// void __thiscall CharGenState::~CharGenState(CharGenState*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C5DB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C5EF0
    /// void __thiscall CharGenState::RandomizeAppearance(CharGenState*,int)</code>
    /// </summary>
    public void RandomizeAppearance(int restrict_hair) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, void>)0x005C5EF0)(ref this, restrict_hair);

    /// <summary>
    /// <code>Offset: 0x005C6060
    /// void __thiscall CharGenState::ApplyTemplate(CharGenState*)</code>
    /// </summary>
    public void ApplyTemplate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C6060)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C6280
    /// int __thiscall CharGenState::GetBaldState(CharGenState*)</code>
    /// </summary>
    public int GetBaldState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int>)0x005C6280)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C6330
    /// int __thiscall CharGenState::SetHeadgearStyle(CharGenState*,int)</code>
    /// </summary>
    public int SetHeadgearStyle(int headgearStyle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005C6330)(ref this, headgearStyle);

    /// <summary>
    /// <code>Offset: 0x005C6460
    /// int __thiscall CharGenState::SetShirtStyle(CharGenState*,int)</code>
    /// </summary>
    public int SetShirtStyle(int shirtStyle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005C6460)(ref this, shirtStyle);

    /// <summary>
    /// <code>Offset: 0x005C6580
    /// int __thiscall CharGenState::SetTrousersStyle(CharGenState*,int)</code>
    /// </summary>
    public int SetTrousersStyle(int trousersStyle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005C6580)(ref this, trousersStyle);

    /// <summary>
    /// <code>Offset: 0x005C66A0
    /// int __thiscall CharGenState::SetFootwearStyle(CharGenState*,int)</code>
    /// </summary>
    public int SetFootwearStyle(int footwearStyle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int>)0x005C66A0)(ref this, footwearStyle);

    /// <summary>
    /// <code>Offset: 0x005C67C0
    /// void __thiscall CharGenState::RandomizeSkills(CharGenState*)</code>
    /// </summary>
    public void RandomizeSkills() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C67C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C69C0
    /// void __thiscall CharGenState::RandomizeStartArea(CharGenState*)</code>
    /// </summary>
    public void RandomizeStartArea() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C69C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C6A40
    /// int __thiscall CharGenState::SetTemplate(CharGenState*,int,int)</code>
    /// </summary>
    public int SetTemplate(int templatea, int apply) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, int, int>)0x005C6A40)(ref this, templatea, apply);

    /// <summary>
    /// <code>Offset: 0x005C6A70
    /// unsigned int* __thiscall CharGenState::GetSetupID(int,unsigned int*)</code>
    /// </summary>
    public uint* GetSetupID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint*, uint*>)0x005C6A70)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005C6B60
    /// void __thiscall CharGenState::ConstrainAllByGender(CharGenState*)</code>
    /// </summary>
    public void ConstrainAllByGender() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C6B60)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C6DF0
    /// void __thiscall CharGenState::RandomizeHeadgear(CharGenState*,int)</code>
    /// </summary>
    public void RandomizeHeadgear(int excludeCurrent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, void>)0x005C6DF0)(ref this, excludeCurrent);

    /// <summary>
    /// <code>Offset: 0x005C6ED0
    /// void __thiscall CharGenState::RandomizeShirt(CharGenState*)</code>
    /// </summary>
    public void RandomizeShirt() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C6ED0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C6F90
    /// void __thiscall CharGenState::RandomizeTrousers(CharGenState*)</code>
    /// </summary>
    public void RandomizeTrousers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C6F90)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C7050
    /// void __thiscall CharGenState::RandomizeFootwear(CharGenState*)</code>
    /// </summary>
    public void RandomizeFootwear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C7050)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C7110
    /// void __thiscall CharGenState::FitTemplateToCharacter(CharGenState*)</code>
    /// </summary>
    public void FitTemplateToCharacter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C7110)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C7480
    /// void __thiscall CharGenState::SetGender(CharGenState*,unsigned int)</code>
    /// </summary>
    public void SetGender(uint gender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, void>)0x005C7480)(ref this, gender);

    /// <summary>
    /// <code>Offset: 0x005C74E0
    /// void __thiscall CharGenState::RandomizeTemplate(CharGenState*)</code>
    /// </summary>
    public void RandomizeTemplate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C74E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C7570
    /// void __thiscall CharGenState::ConstrainAllByHeritage(CharGenState*)</code>
    /// </summary>
    public void ConstrainAllByHeritage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C7570)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C7750
    /// void __thiscall CharGenState::RandomizeClothing(CharGenState*,int)</code>
    /// </summary>
    public void RandomizeClothing(int excludeCurrent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, int, void>)0x005C7750)(ref this, excludeCurrent);

    /// <summary>
    /// <code>Offset: 0x005C7780
    /// void __thiscall CharGenState::SetHeritageGroup(CharGenState*,unsigned int)</code>
    /// </summary>
    public void SetHeritageGroup(uint heritageGroup) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, uint, void>)0x005C7780)(ref this, heritageGroup);

    /// <summary>
    /// <code>Offset: 0x005C7880
    /// void __thiscall CharGenState::Reset(CharGenState*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C7880)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C7A00
    /// void __thiscall CharGenState::RandomizeHeritageGroup(CharGenState*,bool)</code>
    /// </summary>
    public void RandomizeHeritageGroup(byte hasThroneOfDestiny) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, byte, void>)0x005C7A00)(ref this, hasThroneOfDestiny);

    /// <summary>
    /// <code>Offset: 0x005C7A30
    /// void __thiscall CharGenState::CharGenState(CharGenState*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, void>)0x005C7A30)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C7D60
    /// void __thiscall CharGenState::RandomizeCharacter(CharGenState*,bool)</code>
    /// </summary>
    public void RandomizeCharacter(byte hasThroneOfDestiny) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharGenState, byte, void>)0x005C7D60)(ref this, hasThroneOfDestiny);
}

