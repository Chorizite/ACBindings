namespace ACBindings;

// CharGenState
public unsafe struct CharGenState : System.IDisposable
{
    // Child Types
    // CharGenState_vtbl
    public unsafe struct CharGenState_vtbl
    {
        // Members
        public System.IntPtr UpdateTrueFacePal; // function pointer
        public System.IntPtr GetRandomInt; // function pointer
        public System.IntPtr GetRandomReal; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.ACCharGenResult charGenResult;
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
    public ACBindings.Method_CG method;
    public ACBindings.AdvancedMethod_CG advancedMethod;
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
    public ACBindings.SKILL_ADVANCEMENT_CLASS* skillLevels;
    public int totalSkillCredits;
    public int remainingSkillCredits;
    public int* spellKnown;
    public ACBindings.List__SkillRecord_ptr skillRecordList;
    public fixed sbyte name[33];
    public int linkingWord;
    public int startArea;
    public ACBindings.IDClass___tagDataID setupID;
    public ACBindings.IDClass___tagDataID animID;
    public int setupChanged;
    public int slot;
    public fixed sbyte password[20];
    public ACBindings.CG_VERIFICATION_RESPONSE verificationState;
    public int createAsAdmin;
    public int createAsEnvoy;
    public fixed int bAttribLocked[7];
    public ACBindings.SkillTable* skillTable;
    public ACBindings.Attribute2ndTable* attribute2ndTable;
    public ACBindings.EnterChargen enterChargen;
    public ACBindings.ACCharGenData* charGenData;

    // Generated Constructor
    public CharGenState() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall CharGenState::GetRandomInt(CharGenState*,int)
    public int GetRandomInt(int range) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int>)0x005646B0)(ref this, range);
    // int __thiscall CharGenState::GetRandomInt(CharGenState*,int,int)
    public int GetRandomInt(int range, int exclude) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int, int>)0x005646C0)(ref this, range, exclude);
    // long double __thiscall CharGenState::GetRandomReal(CharGenState*)
    public double GetRandomReal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, double>)0x005646E0)(ref this);
    // void __thiscall CharGenState::SetVerificationState(CharGenState*,CG_VERIFICATION_RESPONSE)
    public void SetVerificationState(ACBindings.CG_VERIFICATION_RESPONSE verificationState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, ACBindings.CG_VERIFICATION_RESPONSE, void>)0x005C4780)(ref this, verificationState);
    // CG_VERIFICATION_RESPONSE __thiscall CharGenState::GetVerificationState(CharGenState*)
    public ACBindings.CG_VERIFICATION_RESPONSE GetVerificationState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, ACBindings.CG_VERIFICATION_RESPONSE>)0x005C4790)(ref this);
    // void __thiscall CharGenState::UpdateRemainingSkillCredits(CharGenState*)
    public void UpdateRemainingSkillCredits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C47A0)(ref this);
    // long double __thiscall CharGenState::SetSkinShade(CharGenState*,long double)
    public double SetSkinShade(double skinShade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, double, double>)0x005C4830)(ref this, skinShade);
    // long double __thiscall CharGenState::SetHairShade(CharGenState*,long double)
    public double SetHairShade(double hairShade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, double, double>)0x005C4860)(ref this, hairShade);
    // int __thiscall CharGenState::SetHairColor(CharGenState*,int)
    public int SetHairColor(int hairColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int>)0x005C4890)(ref this, hairColor);
    // int __thiscall CharGenState::SetEyeColor(CharGenState*,int)
    public int SetEyeColor(int eyeColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int>)0x005C48B0)(ref this, eyeColor);
    // unsigned int __thiscall CharGenState::GetHeadgearPaletteTemplateID(CharGenState*,int)
    public uint GetHeadgearPaletteTemplateID(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, uint>)0x005C48D0)(ref this, num);
    // unsigned int __thiscall CharGenState::GetShirtPaletteTemplateID(CharGenState*,int)
    public uint GetShirtPaletteTemplateID(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, uint>)0x005C4900)(ref this, num);
    // unsigned int __thiscall CharGenState::GetTrousersPaletteTemplateID(CharGenState*,int)
    public uint GetTrousersPaletteTemplateID(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, uint>)0x005C4930)(ref this, num);
    // unsigned int __thiscall CharGenState::GetFootwearPaletteTemplateID(CharGenState*,int)
    public uint GetFootwearPaletteTemplateID(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, uint>)0x005C4960)(ref this, num);
    // int __thiscall CharGenState::GetAttribute(CharGenState*,unsigned int)
    public int GetAttribute(uint attr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, uint, int>)0x005C4990)(ref this, attr);
    // void __thiscall CharGenState::GetAttributeName(CharGenState*,unsigned int,char*)
    public void GetAttributeName(uint attr, sbyte* o_string) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, uint, sbyte*, void>)0x005C4A00)(ref this, attr, o_string);
    // int __thiscall CharGenState::GetAbsRemainingCredits(CharGenState*,unsigned int)
    public int GetAbsRemainingCredits(uint curAtrb) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, uint, int>)0x005C4B00)(ref this, curAtrb);
    // void __thiscall CharGenState::ResetAttributeLock(CharGenState*)
    public void ResetAttributeLock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C4BA0)(ref this);
    // void __thiscall CharGenState::LockAttribute(CharGenState*,unsigned int,int)
    public void LockAttribute(uint attr, int lock_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, uint, int, void>)0x005C4BC0)(ref this, attr, lock_);
    // SKILL_ADVANCEMENT_CLASS __thiscall CharGenState::GetSkillLevel(CharGenState*,unsigned int)
    public ACBindings.SKILL_ADVANCEMENT_CLASS GetSkillLevel(uint skill) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, uint, ACBindings.SKILL_ADVANCEMENT_CLASS>)0x005C4BE0)(ref this, skill);
    // int __thiscall CharGenState::SetSkillLevel(CharGenState*,unsigned int,SKILL_ADVANCEMENT_CLASS)
    public int SetSkillLevel(uint skillNum, ACBindings.SKILL_ADVANCEMENT_CLASS skillLevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, uint, ACBindings.SKILL_ADVANCEMENT_CLASS, int>)0x005C4C00)(ref this, skillNum, skillLevel);
    // void __thiscall CharGenState::SetName(CharGenState*,const char*)
    public void SetName(sbyte* name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, sbyte*, void>)0x005C4CF0)(ref this, name);
    // void __thiscall CharGenState::SetSlot(CharGenState*,int)
    public void SetSlot(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, void>)0x005C4D40)(ref this, slot);
    // _DWORD* __thiscall CharGenState::GetHeadgearPalSetID(_DWORD*,_DWORD*,int)
    public int* GetHeadgearPalSetID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int*, int, int*>)0x005C4D50)(ref this, a2, a3);
    // _DWORD* __thiscall CharGenState::GetShirtPalSetID(_DWORD*,_DWORD*,int)
    public int* GetShirtPalSetID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int*, int, int*>)0x005C4D70)(ref this, a2, a3);
    // _DWORD* __thiscall CharGenState::GetTrousersPalSetID(_DWORD*,_DWORD*,int)
    public int* GetTrousersPalSetID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int*, int, int*>)0x005C4D90)(ref this, a2, a3);
    // _DWORD* __thiscall CharGenState::GetFootwearPalSetID(_DWORD*,_DWORD*,int)
    public int* GetFootwearPalSetID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int*, int, int*>)0x005C4DB0)(ref this, a2, a3);
    // void __thiscall CharGenState::BalanceAttributes(CharGenState*,unsigned int)
    public void BalanceAttributes(uint fixedAtrb) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, uint, void>)0x005C4DD0)(ref this, fixedAtrb);
    // void __thiscall CharGenState::SetStartArea(CharGenState*,int)
    public void SetStartArea(int startArea) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, void>)0x005C4FE0)(ref this, startArea);
    // ACCharGenResult* __thiscall CharGenState::GetCharGenResult(CharGenState*)
    public ACBindings.ACCharGenResult* GetCharGenResult() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, ACBindings.ACCharGenResult*>)0x005C5010)(ref this);
    // void __thiscall CharGenState::ResetSkillLevels(CharGenState*)
    public void ResetSkillLevels() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C5390)(ref this);
    // void __stdcall CharGenState::StoreColorInformation(int,_DWORD*,void**,_DWORD*,int)
    public static void StoreColorInformation(int a1, int* a2, void** a3, int* a4, int a5) => ((delegate* unmanaged[Stdcall]<int, int*, void**, int*, int, void>)0x005C54B0)(a1, a2, a3, a4, a5);
    // int __thiscall CharGenState::SetStrength(CharGenState*,int,int)
    public int SetStrength(int strength, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int, int>)0x005C5640)(ref this, strength, balance);
    // int __thiscall CharGenState::SetEndurance(CharGenState*,int,int)
    public int SetEndurance(int endurance, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int, int>)0x005C56C0)(ref this, endurance, balance);
    // int __thiscall CharGenState::SetCoordination(CharGenState*,int,int)
    public int SetCoordination(int coordination, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int, int>)0x005C5740)(ref this, coordination, balance);
    // int __thiscall CharGenState::SetQuickness(CharGenState*,int,int)
    public int SetQuickness(int quickness, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int, int>)0x005C57C0)(ref this, quickness, balance);
    // int __thiscall CharGenState::SetFocus(CharGenState*,int,int)
    public int SetFocus(int focus, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int, int>)0x005C5840)(ref this, focus, balance);
    // int __thiscall CharGenState::SetSelf(CharGenState*,int,int)
    public int SetSelf(int self, int balance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int, int>)0x005C58C0)(ref this, self, balance);
    // void __thiscall CharGenState::ApplyDefaultTemplate(CharGenState*)
    public void ApplyDefaultTemplate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C5970)(ref this);
    // int __thiscall CharGenState::GetSkillScore(CharGenState*,unsigned int)
    public int GetSkillScore(uint skill) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, uint, int>)0x005C5B30)(ref this, skill);
    // void __thiscall CharGenState::~CharGenState(CharGenState*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C5DB0)(ref this);
    // void __thiscall CharGenState::RandomizeAppearance(CharGenState*,int)
    public void RandomizeAppearance(int restrict_hair) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, void>)0x005C5EF0)(ref this, restrict_hair);
    // void __thiscall CharGenState::ApplyTemplate(CharGenState*)
    public void ApplyTemplate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C6060)(ref this);
    // int __thiscall CharGenState::GetBaldState(CharGenState*)
    public int GetBaldState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int>)0x005C6280)(ref this);
    // int __thiscall CharGenState::SetHeadgearStyle(CharGenState*,int)
    public int SetHeadgearStyle(int headgearStyle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int>)0x005C6330)(ref this, headgearStyle);
    // int __thiscall CharGenState::SetShirtStyle(CharGenState*,int)
    public int SetShirtStyle(int shirtStyle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int>)0x005C6460)(ref this, shirtStyle);
    // int __thiscall CharGenState::SetTrousersStyle(CharGenState*,int)
    public int SetTrousersStyle(int trousersStyle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int>)0x005C6580)(ref this, trousersStyle);
    // int __thiscall CharGenState::SetFootwearStyle(CharGenState*,int)
    public int SetFootwearStyle(int footwearStyle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int>)0x005C66A0)(ref this, footwearStyle);
    // void __thiscall CharGenState::RandomizeSkills(CharGenState*)
    public void RandomizeSkills() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C67C0)(ref this);
    // void __thiscall CharGenState::RandomizeStartArea(CharGenState*)
    public void RandomizeStartArea() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C69C0)(ref this);
    // int __thiscall CharGenState::SetTemplate(CharGenState*,int,int)
    public int SetTemplate(int templatea, int apply) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, int, int>)0x005C6A40)(ref this, templatea, apply);
    // unsigned int* __thiscall CharGenState::GetSetupID(int,unsigned int*)
    public uint* GetSetupID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, uint*, uint*>)0x005C6A70)(ref this, a2);
    // void __thiscall CharGenState::ConstrainAllByGender(CharGenState*)
    public void ConstrainAllByGender() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C6B60)(ref this);
    // void __thiscall CharGenState::RandomizeHeadgear(CharGenState*,int)
    public void RandomizeHeadgear(int excludeCurrent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, void>)0x005C6DF0)(ref this, excludeCurrent);
    // void __thiscall CharGenState::RandomizeShirt(CharGenState*)
    public void RandomizeShirt() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C6ED0)(ref this);
    // void __thiscall CharGenState::RandomizeTrousers(CharGenState*)
    public void RandomizeTrousers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C6F90)(ref this);
    // void __thiscall CharGenState::RandomizeFootwear(CharGenState*)
    public void RandomizeFootwear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C7050)(ref this);
    // void __thiscall CharGenState::FitTemplateToCharacter(CharGenState*)
    public void FitTemplateToCharacter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C7110)(ref this);
    // void __thiscall CharGenState::SetGender(CharGenState*,unsigned int)
    public void SetGender(uint gender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, uint, void>)0x005C7480)(ref this, gender);
    // void __thiscall CharGenState::RandomizeTemplate(CharGenState*)
    public void RandomizeTemplate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C74E0)(ref this);
    // void __thiscall CharGenState::ConstrainAllByHeritage(CharGenState*)
    public void ConstrainAllByHeritage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C7570)(ref this);
    // void __thiscall CharGenState::RandomizeClothing(CharGenState*,int)
    public void RandomizeClothing(int excludeCurrent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, int, void>)0x005C7750)(ref this, excludeCurrent);
    // void __thiscall CharGenState::SetHeritageGroup(CharGenState*,unsigned int)
    public void SetHeritageGroup(uint heritageGroup) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, uint, void>)0x005C7780)(ref this, heritageGroup);
    // void __thiscall CharGenState::Reset(CharGenState*)
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C7880)(ref this);
    // void __thiscall CharGenState::RandomizeHeritageGroup(CharGenState*,bool)
    public void RandomizeHeritageGroup(byte hasThroneOfDestiny) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, byte, void>)0x005C7A00)(ref this, hasThroneOfDestiny);
    // void __thiscall CharGenState::CharGenState(CharGenState*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, void>)0x005C7A30)(ref this);
    // void __thiscall CharGenState::RandomizeCharacter(CharGenState*,bool)
    public void RandomizeCharacter(byte hasThroneOfDestiny) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharGenState, byte, void>)0x005C7D60)(ref this, hasThroneOfDestiny);
}

