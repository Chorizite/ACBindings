namespace ACBindings.Internal;

public unsafe struct ACCharGenData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CharGenData BaseClass_CharGenData; // ACBindings.Internal.CharGenData

    // Child Types
    public unsafe struct ACCharGenData_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharGenData*, ACBindings.Internal.CharGenResult*, ACBindings.Internal.Position*, int> GetStartingPosition; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___ACCharGenStartArea mStartAreaList;
    public ACBindings.Internal.HashTable__uint___HeritageGroup_CG mHeritageGroupList;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0058B690
    /// DBObj* __cdecl ACCharGenData::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B690)();

    /// <summary>
    /// <code>Offset: 0x005BE6A0
    /// void __cdecl ACCharGenData::FormatName(char*)</code>
    /// </summary>
    public static void FormatName(sbyte* name) => ((delegate* unmanaged[Cdecl]<sbyte*, void>)0x005BE6A0)(name);

    /// <summary>
    /// <code>Offset: 0x005C1E80
    /// void __thiscall ACCharGenData::GetSubDataIDs(ACCharGenData*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005C1E80)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x005C2360
    /// int __thiscall ACCharGenData::GetStartingPosition(ACCharGenData*,const CharGenResult*,Position*)</code>
    /// </summary>
    public int GetStartingPosition(ACBindings.Internal.CharGenResult* cgr, ACBindings.Internal.Position* pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, ACBindings.Internal.CharGenResult*, ACBindings.Internal.Position*, int>)0x005C2360)(ref this, cgr, pos);

    /// <summary>
    /// <code>Offset: 0x005C3380
    /// const HeritageGroup_CG* __thiscall ACCharGenData::GetHG(ACCharGenData*,const HeritageGroup_CG*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.HeritageGroup_CG* GetHG(ACBindings.Internal.HeritageGroup_CG* result, uint heritage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, ACBindings.Internal.HeritageGroup_CG*, uint, ACBindings.Internal.HeritageGroup_CG*>)0x005C3380)(ref this, result, heritage);

    /// <summary>
    /// <code>Offset: 0x005C36B0
    /// int __thiscall ACCharGenData::GetSkillTrainedCost(ACCharGenData*,int,unsigned int,unsigned int)</code>
    /// </summary>
    public int GetSkillTrainedCost(int skillID, uint heritage, uint gender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, int, uint, uint, int>)0x005C36B0)(ref this, skillID, heritage, gender);

    /// <summary>
    /// <code>Offset: 0x005C37B0
    /// int __thiscall ACCharGenData::GetSkillSpecializedCost(ACCharGenData*,int,unsigned int,unsigned int)</code>
    /// </summary>
    public int GetSkillSpecializedCost(int skillID, uint heritage, uint gender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, int, uint, uint, int>)0x005C37B0)(ref this, skillID, heritage, gender);

    /// <summary>
    /// <code>Offset: 0x005C38B0
    /// int __thiscall ACCharGenData::GenerateBaseAppearanceData(ACCharGenData*,const ACCharGenResult*,CharAppearanceData*,ObjDesc*)</code>
    /// </summary>
    public int GenerateBaseAppearanceData(ACBindings.Internal.ACCharGenResult* cgr, ACBindings.Internal.CharAppearanceData* cad, ACBindings.Internal.ObjDesc* objDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, ACBindings.Internal.ACCharGenResult*, ACBindings.Internal.CharAppearanceData*, ACBindings.Internal.ObjDesc*, int>)0x005C38B0)(ref this, cgr, cad, objDesc);

    /// <summary>
    /// <code>Offset: 0x005C3DB0
    /// unsigned int __thiscall ACCharGenData::GetHairIndexFromID(ACCharGenData*,unsigned int,unsigned int,int,char)</code>
    /// </summary>
    public uint GetHairIndexFromID(uint heritage, uint gender, int a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, sbyte, uint>)0x005C3DB0)(ref this, heritage, gender, a4, a5);

    /// <summary>
    /// <code>Offset: 0x005C3EE0
    /// unsigned int __thiscall ACCharGenData::GetEyeStripIndexFromID(ACCharGenData*,unsigned int,unsigned int,int,char,char)</code>
    /// </summary>
    public uint GetEyeStripIndexFromID(uint heritage, uint gender, int a4, sbyte a5, sbyte a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, sbyte, sbyte, uint>)0x005C3EE0)(ref this, heritage, gender, a4, a5, a6);

    /// <summary>
    /// <code>Offset: 0x005C4050
    /// unsigned int __thiscall ACCharGenData::GetNoseStripIndexFromID(ACCharGenData*,unsigned int,unsigned int,int,char)</code>
    /// </summary>
    public uint GetNoseStripIndexFromID(uint heritage, uint gender, int a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, sbyte, uint>)0x005C4050)(ref this, heritage, gender, a4, a5);

    /// <summary>
    /// <code>Offset: 0x005C4170
    /// unsigned int __thiscall ACCharGenData::GetMouthStripIndexFromID(ACCharGenData*,unsigned int,unsigned int,int,char)</code>
    /// </summary>
    public uint GetMouthStripIndexFromID(uint heritage, uint gender, int a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, sbyte, uint>)0x005C4170)(ref this, heritage, gender, a4, a5);

    /// <summary>
    /// <code>Offset: 0x005C4290
    /// void __thiscall ACCharGenData::GetSkinShadeFromID(ACCharGenData*,unsigned int,unsigned int,int,double*)</code>
    /// </summary>
    public void GetSkinShadeFromID(uint heritage, uint gender, int a4, double* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, double*, void>)0x005C4290)(ref this, heritage, gender, a4, a5);

    /// <summary>
    /// <code>Offset: 0x005C4380
    /// void __thiscall ACCharGenData::GetHairColorFromID(ACCharGenData*,unsigned int,unsigned int,int,unsigned int*,_DWORD*)</code>
    /// </summary>
    public void GetHairColorFromID(uint heritage, uint gender, int a4, uint* a5, int* a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, uint*, int*, void>)0x005C4380)(ref this, heritage, gender, a4, a5, a6);

    /// <summary>
    /// <code>Offset: 0x005C44E0
    /// void __thiscall ACCharGenData::GetEyeColorFromID(ACCharGenData*,unsigned int,unsigned int,int,unsigned int*)</code>
    /// </summary>
    public void GetEyeColorFromID(uint heritage, uint gender, int a4, uint* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, uint, uint, int, uint*, void>)0x005C44E0)(ref this, heritage, gender, a4, a5);

    /// <summary>
    /// <code>Offset: 0x005C4620
    /// void __thiscall ACCharGenData::~ACCharGenData(ACCharGenData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, void>)0x005C4620)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C46B0
    /// void __thiscall ACCharGenData::Serialize(ACCharGenData*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenData, ACBindings.Internal.Archive*, void>)0x005C46B0)(ref this, io_archive);
}

