namespace ACBindings.Internal;

public unsafe struct ACCharGenResult
{
    // Base Classes
    public ACBindings.Internal.CharGenResult BaseClass_CharGenResult; // ACBindings.Internal.CharGenResult

    // Child Types
    public unsafe struct ACCharGenResult_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, void> ACCharGenResult_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, void**, uint, int> UnPack; // function pointer
        public System.IntPtr GetName;
        public System.IntPtr SetName;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, int> GetSlot; // function pointer
        public System.IntPtr GetClassID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, uint> GetStartArea; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, int> IsAdmin; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, int> IsEnvoy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, int, int> VerifyCharacterGenerationResult; // function pointer

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
    public ACBindings.Internal.SKILL_ADVANCEMENT_CLASS* skillAdvancementClasses;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte name;
    public int slot;
    public ACBindings.Internal.IDClass____tagDataID classID;
    public uint startArea;
    public int isAdmin;
    public int isEnvoy;

    // Generated Constructor
    public ACCharGenResult() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005C8010
    /// void __thiscall ACCharGenResult::ACCharGenResult(ACCharGenResult*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, void>)0x005C8010)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C80F0
    /// char* __thiscall ACCharGenResult::GetName(char*)</code>
    /// </summary>
    public sbyte* GetName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, sbyte*>)0x005C80F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C8100
    /// int __thiscall ACCharGenResult::GetSlot(ACCharGenResult*)</code>
    /// </summary>
    public int GetSlot() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, int>)0x005C8100)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C8110
    /// int __thiscall ACCharGenResult::IsEnvoy(ACCharGenResult*)</code>
    /// </summary>
    public int IsEnvoy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, int>)0x005C8110)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C8130
    /// _DWORD* __thiscall ACCharGenResult::GetClassID(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int* GetClassID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, int*, int*>)0x005C8130)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005C8140
    /// LONG __thiscall ACCharGenResult::SetName(_DWORD*,LONG*)</code>
    /// </summary>
    public int SetName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, int*, int>)0x005C8140)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005C81E0
    /// void __thiscall ACCharGenResult::CG_Pack(ACCharGenResult*,void**,unsigned __int8*)</code>
    /// </summary>
    public void CG_Pack(void** buffer_vpr, byte* end) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, void**, byte*, void>)0x005C81E0)(ref this, buffer_vpr, end);

    /// <summary>
    /// <code>Offset: 0x005C84C0
    /// unsigned int __thiscall ACCharGenResult::GetPackSize(ACCharGenResult*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, uint>)0x005C84C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C8550
    /// unsigned int __thiscall ACCharGenResult::Pack(ACCharGenResult*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, void**, uint, uint>)0x005C8550)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005C85B0
    /// int __thiscall ACCharGenResult::CG_UnPack(ACCharGenResult*,void**,unsigned __int8*)</code>
    /// </summary>
    public int CG_UnPack(void** buffer_vpr, byte* end) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, void**, byte*, int>)0x005C85B0)(ref this, buffer_vpr, end);

    /// <summary>
    /// <code>Offset: 0x005C89B0
    /// int __thiscall ACCharGenResult::UnPack(ACCharGenResult*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, void**, uint, int>)0x005C89B0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005C89D0
    /// int __cdecl ACCharGenResult::VerifyCharacterGenerationResult(const ACCharGenResult*,const int)</code>
    /// </summary>
    public static int VerifyCharacterGenerationResult(ACBindings.Internal.ACCharGenResult* cgr, int has_throne_of_destiny) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ACCharGenResult*, int, int>)0x005C89D0)(cgr, has_throne_of_destiny);

    /// <summary>
    /// <code>Offset: 0x005C90C0
    /// int __thiscall ACCharGenResult::VerifyCharacterGenerationResult(ACCharGenResult*,const int)</code>
    /// </summary>
    public int VerifyCharacterGenerationResult(int has_throne_of_destiny) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, int, int>)0x005C90C0)(ref this, has_throne_of_destiny);
}

