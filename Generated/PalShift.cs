namespace ACBindings;

// PalShift
public unsafe struct PalShift : System.IDisposable
{
    // Members
    public uint cur_tex;
    public ACBindings.AC1Legacy.SmartArray__PalShiftTex_ptr land_tex;
    public ACBindings.Subpalette* sub_pals;
    public uint maxsubs;

    // Generated Constructor
    public PalShift() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall PalShift::CleanupSurface(PalShift*,CSurface*)
    public void CleanupSurface(ACBindings.CSurface* surf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, ACBindings.CSurface*, void>)0x005004C0)(ref this, surf);
    // unsigned int __thiscall PalShift::GetBeginRotIx(PalShift*,int,int,unsigned int*,int)
    public uint GetBeginRotIx(int x, int y, uint* pcode, int minimize_pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, int, int, uint*, int, uint>)0x005004E0)(ref this, x, y, pcode, minimize_pal);
    // void __thiscall PalShift::PalShift(PalShift*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, void>)0x00500680)(ref this);
    // unsigned int __thiscall PalShift::MakeSubPal(_DWORD*,int*,_DWORD*,char,int,int)
    public uint MakeSubPal(int* a2, int* a3, sbyte a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, int*, int*, sbyte, int, int, uint>)0x005006A0)(ref this, a2, a3, a4, a5, a6);
    // int __thiscall PalShift::CheckTerrain(_DWORD*,unsigned int,_DWORD*)
    public int CheckTerrain(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, uint, int*, int>)0x00500880)(ref this, a2, a3);
    // int __thiscall PalShift::CheckRot(PalShift*,unsigned int,unsigned int*)
    public int CheckRot(uint pcode, uint* rindex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, uint, uint*, int>)0x00500980)(ref this, pcode, rindex);
    // unsigned int __thiscall PalShift::pack_size(PalShift*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, uint>)0x005009F0)(ref this);
    // void __thiscall PalShift::GetSubDataIDs(PalShift*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, ACBindings.QualifiedDataIDArray*, void>)0x00500CE0)(ref this, id_array);
    // unsigned int __thiscall PalShift::SelectRot(PalShift*,int,int,int*,unsigned int*,int,_DWORD*,unsigned int*,int)
    public uint SelectRot(int x, int y, int* a4, uint* pcode, int a6, int* a7, uint* rindex, int minimize_pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, int, int, int*, uint*, int, int*, uint*, int, uint>)0x00500D90)(ref this, x, y, a4, pcode, a6, a7, rindex, minimize_pal);
    // CSurface* __thiscall PalShift::MakeNewSurface(_DWORD*,int,char,int,int)
    public ACBindings.CSurface* MakeNewSurface(int a2, sbyte a3, int a4, int numSubs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, int, sbyte, int, int, ACBindings.CSurface*>)0x00500EA0)(ref this, a2, a3, a4, numSubs);
    // unsigned int __thiscall PalShift::Pack(PalShift*,void**,unsigned int*)
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, void**, uint*, uint>)0x00500F20)(ref this, addr, size);
    // void __thiscall PalShift::Destroy(PalShift*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, void>)0x00501280)(ref this);
    // int __thiscall PalShift::UnPack(PalShift*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, void**, uint*, int>)0x00501320)(ref this, addr, size);
    // void __thiscall PalShift::~PalShift(PalShift*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShift, void>)0x00501430)(ref this);
}

