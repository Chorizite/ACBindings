namespace ACBindings.Internal;


/// <summary>
/// Represents the final state of a character after creation, including appearance, attributes, skill levels, and identity information. Stores all traits required to instantiate a playable avatar in the game world. Provides serialization and validation support for persistence and server communication.
/// </summary>
public unsafe struct ACCharGenResult
{
    // Base Classes
    public ACBindings.Internal.CharGenResult BaseClass_CharGenResult; // ACBindings.Internal.CharGenResult

    // Child Types

    /// <summary>Provides a virtual function table for character generation result objects, exposing operations such as destruction, serialization, name manipulation, slot and class identification, area assignment, role verification, and result validation.</summary>
    /// <remarks>Matches the ACCharGenResult interface used during character creation workflows within the application.</remarks>
    public unsafe struct ACCharGenResult_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, void> ACCharGenResult_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, void**, uint, int> UnPack; // function pointer
        public System.IntPtr GetName;
        public System.IntPtr SetName;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, int> GetSlot; // function pointer
        public System.IntPtr GetClassID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, uint> GetStartArea; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, int> IsAdmin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, int> IsEnvoy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenResult*, int, int> VerifyCharacterGenerationResult; // function pointer

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

    /// <summary>Initializes a new ACCharGenResult instance with all character traits and identity fields reset to their default values, ready for further configuration during character creation.
    /// <code>Offset: 0x005C8010
    /// void __thiscall ACCharGenResult::ACCharGenResult(ACCharGenResult*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, void>)0x005C8010)(ref this);

    /// <summary>Retrieves the character's name as a C-style string.
    /// <code>Offset: 0x005C80F0
    /// char* __thiscall ACCharGenResult::GetName(char*)</code>
    /// </summary>
    /// <returns>A null‑terminated string containing the character's name.</returns>
    public sbyte* GetName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, sbyte*>)0x005C80F0)(ref this);

    /// <summary>Retrieves the slot number assigned to this character generation result.
    /// <code>Offset: 0x005C8100
    /// int __thiscall ACCharGenResult::GetSlot(ACCharGenResult*)</code>
    /// </summary>
    /// <returns>The integer slot identifier.</returns>
    public int GetSlot() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, int>)0x005C8100)(ref this);

    /// <summary>Determines whether the character generation result represents an envoy.
    /// <code>Offset: 0x005C8110
    /// int __thiscall ACCharGenResult::IsEnvoy(ACCharGenResult*)</code>
    /// </summary>
    /// <returns>An integer indicating envoy status: non‑zero if true, zero otherwise.</returns>
    public int IsEnvoy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, int>)0x005C8110)(ref this);

    /// <summary>Retrieves the character’s class identifier from an ACCharGenResult instance and stores it at the supplied address.
    /// <code>Offset: 0x005C8130
    /// _DWORD* __thiscall ACCharGenResult::GetClassID(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="this">Pointer to the ACCharGenResult object.</param>
    /// <param name="a2">Address where the retrieved class ID will be stored.</param>
    /// <returns>The same pointer passed in as a2, now pointing to the stored class ID value.</returns>
    public int* GetClassID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, int*, int*>)0x005C8130)(ref this, a2);

    /// <summary>Assigns a new name to the character result while updating reference counts of string objects.
    /// <code>Offset: 0x005C8140
    /// LONG __thiscall ACCharGenResult::SetName(_DWORD*,LONG*)</code>
    /// </summary>
    /// <param name="this">Pointer to the ACCharGenResult instance.</param>
    /// <param name="a2">Address of the PStringBase&lt;char&gt; object representing the desired name.</param>
    /// <returns>If the supplied name differs from the current one, returns the incremented reference count of that name after assignment; otherwise returns the original address value stored in *a2 unchanged.</returns>
    public int SetName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, int*, int>)0x005C8140)(ref this, a2);

    /// <summary>Serializes an ACCharGenResult into a binary buffer by writing its properties in order and updating the output pointer.
    /// <code>Offset: 0x005C81E0
    /// void __thiscall ACCharGenResult::CG_Pack(ACCharGenResult*,void**,unsigned __int8*)</code>
    /// </summary>
    /// <param name="buffer_vpr">Pointer to the current position within the destination buffer; advanced as data is written.</param>
    /// <param name="end">Maximum buffer address used for string packing to prevent overflow during serialization of variable‑length fields.</param>
    public void CG_Pack(void** buffer_vpr, byte* end) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, void**, byte*, void>)0x005C81E0)(ref this, buffer_vpr, end);

    /// <summary>Computes the total byte count required to serialize this character generation result, accounting for its name string and skill list.
    /// <code>Offset: 0x005C84C0
    /// unsigned int __thiscall ACCharGenResult::GetPackSize(ACCharGenResult*)</code>
    /// </summary>
    /// <returns>The size in bytes needed to pack the object.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, uint>)0x005C84C0)(ref this);

    /// <summary>Packs the current ACCharGenResult instance into a binary buffer when sufficient space is available, or reports the required byte count if not.
    /// <code>Offset: 0x005C8550
    /// unsigned int __thiscall ACCharGenResult::Pack(ACCharGenResult*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer to the destination buffer where packed data will be written.</param>
    /// <param name="size">Number of bytes currently free in the destination buffer; packing occurs only if this value meets or exceeds the size needed.</param>
    /// <returns>The total number of bytes required to pack the ACCharGenResult object, which is also returned when packing succeeds.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, void**, uint, uint>)0x005C8550)(ref this, addr, size);

    /// <summary>Deserializes a character generation result from a binary buffer, populating the ACCharGenResult fields and validating integrity.
    /// <code>Offset: 0x005C85B0
    /// int __thiscall ACCharGenResult::CG_UnPack(ACCharGenResult*,void**,unsigned __int8*)</code>
    /// </summary>
    /// <param name="buffer_vpr">Pointer to the current read position within the buffer; updated as data is consumed.</param>
    /// <param name="end">Pointer marking the end of the valid data region in the buffer.</param>
    /// <returns>Non‑zero if unpacking succeeds without errors and all expected data has been processed; zero otherwise.</returns>
    public int CG_UnPack(void** buffer_vpr, byte* end) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, void**, byte*, int>)0x005C85B0)(ref this, buffer_vpr, end);

    /// <summary>Unpacks an ACCharGenResult object from a serialized byte array.
    /// <code>Offset: 0x005C89B0
    /// int __thiscall ACCharGenResult::UnPack(ACCharGenResult*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the start of the packed data buffer.</param>
    /// <param name="size">Number of bytes to read from the buffer.</param>
    /// <returns>Non-zero if unpacking succeeded; otherwise zero.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, void**, uint, int>)0x005C89B0)(ref this, addr, size);

    /// <summary>Verifies that a character generation result satisfies all game rules for appearance, attributes, skills, and metadata.
    /// <code>Offset: 0x005C89D0
    /// int __cdecl ACCharGenResult::VerifyCharacterGenerationResult(const ACCharGenResult*,const int)</code>
    /// </summary>
    /// <param name="cgr">The character generation result to validate.</param>
    /// <param name="has_throne_of_destiny">Flag indicating whether the player possesses the special throne of destiny item.</param>
    /// <returns>Non‑zero if validation succeeds; zero otherwise.</returns>
    public static int VerifyCharacterGenerationResult(ACBindings.Internal.ACCharGenResult* cgr, int has_throne_of_destiny) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ACCharGenResult*, int, int>)0x005C89D0)(cgr, has_throne_of_destiny);

    /// <summary>Checks the validity of a character generation result, optionally considering throne‑of‑destiny constraints.
    /// <code>Offset: 0x005C90C0
    /// int __thiscall ACCharGenResult::VerifyCharacterGenerationResult(ACCharGenResult*,const int)</code>
    /// </summary>
    /// <param name="has_throne_of_destiny">Flag indicating whether throne‑of‑destiny rules should be applied during the check.</param>
    /// <returns>An integer status code produced by the verification process.</returns>
    public int VerifyCharacterGenerationResult(int has_throne_of_destiny) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenResult, int, int>)0x005C90C0)(ref this, has_throne_of_destiny);
}

