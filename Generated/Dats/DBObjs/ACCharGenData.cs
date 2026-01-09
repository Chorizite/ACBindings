namespace ACBindings;

// ACCharGenData
public unsafe struct ACCharGenData : System.IDisposable
{
    // Base Classes
    public ACBindings.CharGenData BaseClass_CharGenData; // ACBindings.CharGenData

    // Child Types
    // ACCharGenData_vtbl
    public unsafe struct ACCharGenData_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer
        public System.IntPtr GetStartingPosition; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SmartArray__ACCharGenStartArea mStartAreaList;
    public ACBindings.HashTable__uint__HeritageGroup_CG mHeritageGroupList;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // DBObj* __cdecl ACCharGenData::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x0058B690)();
    // void __cdecl ACCharGenData::FormatName(char*)
    public static void FormatName(sbyte* name) => ((delegate* unmanaged[Cdecl]<sbyte*, void>)0x005BE6A0)(name);
    // void __thiscall ACCharGenData::GetSubDataIDs(ACCharGenData*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, ACBindings.QualifiedDataIDArray*, void>)0x005C1E80)(ref this, id_array);
    // int __thiscall ACCharGenData::GetStartingPosition(ACCharGenData*,const CharGenResult*,Position*)
    public int GetStartingPosition(ACBindings.CharGenResult* cgr, ACBindings.Position* pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, ACBindings.CharGenResult*, ACBindings.Position*, int>)0x005C2360)(ref this, cgr, pos);
    // const HeritageGroup_CG* __thiscall ACCharGenData::GetHG(ACCharGenData*,const HeritageGroup_CG*,unsigned int)
    public ACBindings.HeritageGroup_CG* GetHG(ACBindings.HeritageGroup_CG* result, uint heritage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, ACBindings.HeritageGroup_CG*, uint, ACBindings.HeritageGroup_CG*>)0x005C3380)(ref this, result, heritage);
    // int __thiscall ACCharGenData::GetSkillTrainedCost(ACCharGenData*,int,unsigned int,unsigned int)
    public int GetSkillTrainedCost(int skillID, uint heritage, uint gender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, int, uint, uint, int>)0x005C36B0)(ref this, skillID, heritage, gender);
    // int __thiscall ACCharGenData::GetSkillSpecializedCost(ACCharGenData*,int,unsigned int,unsigned int)
    public int GetSkillSpecializedCost(int skillID, uint heritage, uint gender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, int, uint, uint, int>)0x005C37B0)(ref this, skillID, heritage, gender);
    // int __thiscall ACCharGenData::GenerateBaseAppearanceData(ACCharGenData*,const ACCharGenResult*,CharAppearanceData*,ObjDesc*)
    public int GenerateBaseAppearanceData(ACBindings.ACCharGenResult* cgr, ACBindings.CharAppearanceData* cad, ACBindings.ObjDesc* objDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, ACBindings.ACCharGenResult*, ACBindings.CharAppearanceData*, ACBindings.ObjDesc*, int>)0x005C38B0)(ref this, cgr, cad, objDesc);
    // unsigned int __thiscall ACCharGenData::GetHairIndexFromID(ACCharGenData*,unsigned int,unsigned int,int,char)
    public uint GetHairIndexFromID(uint heritage, uint gender, int a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, uint, uint, int, sbyte, uint>)0x005C3DB0)(ref this, heritage, gender, a4, a5);
    // unsigned int __thiscall ACCharGenData::GetEyeStripIndexFromID(ACCharGenData*,unsigned int,unsigned int,int,char,char)
    public uint GetEyeStripIndexFromID(uint heritage, uint gender, int a4, sbyte a5, sbyte a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, uint, uint, int, sbyte, sbyte, uint>)0x005C3EE0)(ref this, heritage, gender, a4, a5, a6);
    // unsigned int __thiscall ACCharGenData::GetNoseStripIndexFromID(ACCharGenData*,unsigned int,unsigned int,int,char)
    public uint GetNoseStripIndexFromID(uint heritage, uint gender, int a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, uint, uint, int, sbyte, uint>)0x005C4050)(ref this, heritage, gender, a4, a5);
    // unsigned int __thiscall ACCharGenData::GetMouthStripIndexFromID(ACCharGenData*,unsigned int,unsigned int,int,char)
    public uint GetMouthStripIndexFromID(uint heritage, uint gender, int a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, uint, uint, int, sbyte, uint>)0x005C4170)(ref this, heritage, gender, a4, a5);
    // void __thiscall ACCharGenData::GetSkinShadeFromID(ACCharGenData*,unsigned int,unsigned int,int,double*)
    public void GetSkinShadeFromID(uint heritage, uint gender, int a4, double* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, uint, uint, int, double*, void>)0x005C4290)(ref this, heritage, gender, a4, a5);
    // void __thiscall ACCharGenData::GetHairColorFromID(ACCharGenData*,unsigned int,unsigned int,int,unsigned int*,_DWORD*)
    public void GetHairColorFromID(uint heritage, uint gender, int a4, uint* a5, int* a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, uint, uint, int, uint*, int*, void>)0x005C4380)(ref this, heritage, gender, a4, a5, a6);
    // void __thiscall ACCharGenData::GetEyeColorFromID(ACCharGenData*,unsigned int,unsigned int,int,unsigned int*)
    public void GetEyeColorFromID(uint heritage, uint gender, int a4, uint* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, uint, uint, int, uint*, void>)0x005C44E0)(ref this, heritage, gender, a4, a5);
    // void __thiscall ACCharGenData::~ACCharGenData(ACCharGenData*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, void>)0x005C4620)(ref this);
    // void __thiscall ACCharGenData::Serialize(ACCharGenData*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenData, ACBindings.Archive*, void>)0x005C46B0)(ref this, io_archive);
}

