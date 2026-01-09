namespace ACBindings;

// ACCharGenResult
public unsafe struct ACCharGenResult
{
    // Base Classes
    public ACBindings.CharGenResult BaseClass_CharGenResult; // ACBindings.CharGenResult

    // Child Types
    // ACCharGenResult_vtbl
    public unsafe struct ACCharGenResult_vtbl
    {
        // Members
        public System.IntPtr ACCharGenResult_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr GetName;
        public System.IntPtr SetName;
        public System.IntPtr GetSlot; // function pointer
        public System.IntPtr GetClassID;
        public System.IntPtr GetStartArea; // function pointer
        public System.IntPtr IsAdmin; // function pointer
        public System.IntPtr IsEnvoy; // function pointer
        public System.IntPtr VerifyCharacterGenerationResult; // function pointer

        // Methods
    }

    // Members
    public uint heritageGroup;
    public uint gender;
    public int eyesStrip;
    public int noseStrip;
    public int mouthStrip;
    public int hairColor;
    public int eyeColor;
    public int hairStyle;
    public int headgearStyle;
    public int shirtStyle;
    public int trousersStyle;
    public int footwearStyle;
    public uint headgearColor;
    public uint shirtColor;
    public uint trousersColor;
    public uint footwearColor;
    public double skinShade;
    public double hairShade;
    public double headgearShade;
    public double shirtShade;
    public double trousersShade;
    public double footwearShade;
    public int templateNum;
    public int strength;
    public int endurance;
    public int coordination;
    public int quickness;
    public int focus;
    public int self;
    public int numSkills;
    public ACBindings.SKILL_ADVANCEMENT_CLASS* skillAdvancementClasses;
    public ACBindings.AC1Legacy.PStringBase__sbyte name;
    public int slot;
    public ACBindings.IDClass___tagDataID classID;
    public uint startArea;
    public int isAdmin;
    public int isEnvoy;

    // Generated Constructor
    public ACCharGenResult() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall ACCharGenResult::ACCharGenResult(ACCharGenResult*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenResult, void>)0x005C8010)(ref this);
    // char* __thiscall ACCharGenResult::GetName(char*)
    public sbyte* GetName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenResult, sbyte*>)0x005C80F0)(ref this);
    // int __thiscall ACCharGenResult::GetSlot(ACCharGenResult*)
    public int GetSlot() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenResult, int>)0x005C8100)(ref this);
    // int __thiscall ACCharGenResult::IsEnvoy(ACCharGenResult*)
    public int IsEnvoy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenResult, int>)0x005C8110)(ref this);
    // _DWORD* __thiscall ACCharGenResult::GetClassID(_DWORD*,_DWORD*)
    public int* GetClassID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenResult, int*, int*>)0x005C8130)(ref this, a2);
    // LONG __thiscall ACCharGenResult::SetName(_DWORD*,LONG*)
    public int SetName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenResult, int*, int>)0x005C8140)(ref this, a2);
    // void __thiscall ACCharGenResult::CG_Pack(ACCharGenResult*,void**,unsigned __int8*)
    public void CG_Pack(void** buffer_vpr, byte* end) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenResult, void**, byte*, void>)0x005C81E0)(ref this, buffer_vpr, end);
    // unsigned int __thiscall ACCharGenResult::GetPackSize(ACCharGenResult*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenResult, uint>)0x005C84C0)(ref this);
    // unsigned int __thiscall ACCharGenResult::Pack(ACCharGenResult*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenResult, void**, uint, uint>)0x005C8550)(ref this, addr, size);
    // int __thiscall ACCharGenResult::CG_UnPack(ACCharGenResult*,void**,unsigned __int8*)
    public int CG_UnPack(void** buffer_vpr, byte* end) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenResult, void**, byte*, int>)0x005C85B0)(ref this, buffer_vpr, end);
    // int __thiscall ACCharGenResult::UnPack(ACCharGenResult*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenResult, void**, uint, int>)0x005C89B0)(ref this, addr, size);
    // int __cdecl ACCharGenResult::VerifyCharacterGenerationResult(const ACCharGenResult*,const int)
    public static int VerifyCharacterGenerationResult(ACBindings.ACCharGenResult* cgr, int has_throne_of_destiny) => ((delegate* unmanaged[Cdecl]<ACBindings.ACCharGenResult*, int, int>)0x005C89D0)(cgr, has_throne_of_destiny);
    // int __thiscall ACCharGenResult::VerifyCharacterGenerationResult(ACCharGenResult*,const int)
    public int VerifyCharacterGenerationResult(int has_throne_of_destiny) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenResult, int, int>)0x005C90C0)(ref this, has_throne_of_destiny);
}

