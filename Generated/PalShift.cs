namespace ACBindings.Internal;

public unsafe struct PalShift : System.IDisposable
{
    // Members
    public uint cur_tex;
    public ACBindings.Internal.AC1Legacy.SmartArray___PalShiftTex_ptr land_tex;
    public ACBindings.Internal.Subpalette* sub_pals;
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

    /// <summary>
    /// <code>Offset: 0x005004C0
    /// void __thiscall PalShift::CleanupSurface(PalShift*,CSurface*)</code>
    /// </summary>
    public void CleanupSurface(ACBindings.Internal.CSurface* surf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, ACBindings.Internal.CSurface*, void>)0x005004C0)(ref this, surf);

    /// <summary>
    /// <code>Offset: 0x005004E0
    /// unsigned int __thiscall PalShift::GetBeginRotIx(PalShift*,int,int,unsigned int*,int)</code>
    /// </summary>
    public uint GetBeginRotIx(int x, int y, uint* pcode, int minimize_pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, int, int, uint*, int, uint>)0x005004E0)(ref this, x, y, pcode, minimize_pal);

    /// <summary>
    /// <code>Offset: 0x00500680
    /// void __thiscall PalShift::PalShift(PalShift*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, void>)0x00500680)(ref this);

    /// <summary>
    /// <code>Offset: 0x005006A0
    /// unsigned int __thiscall PalShift::MakeSubPal(_DWORD*,int*,_DWORD*,char,int,int)</code>
    /// </summary>
    public uint MakeSubPal(int* a2, int* a3, sbyte a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, int*, int*, sbyte, int, int, uint>)0x005006A0)(ref this, a2, a3, a4, a5, a6);

    /// <summary>
    /// <code>Offset: 0x00500880
    /// int __thiscall PalShift::CheckTerrain(_DWORD*,unsigned int,_DWORD*)</code>
    /// </summary>
    public int CheckTerrain(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, uint, int*, int>)0x00500880)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00500980
    /// int __thiscall PalShift::CheckRot(PalShift*,unsigned int,unsigned int*)</code>
    /// </summary>
    public int CheckRot(uint pcode, uint* rindex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, uint, uint*, int>)0x00500980)(ref this, pcode, rindex);

    /// <summary>
    /// <code>Offset: 0x005009F0
    /// unsigned int __thiscall PalShift::pack_size(PalShift*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, uint>)0x005009F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00500CE0
    /// void __thiscall PalShift::GetSubDataIDs(PalShift*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00500CE0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x00500D90
    /// unsigned int __thiscall PalShift::SelectRot(PalShift*,int,int,int*,unsigned int*,int,_DWORD*,unsigned int*,int)</code>
    /// </summary>
    public uint SelectRot(int x, int y, int* a4, uint* pcode, int a6, int* a7, uint* rindex, int minimize_pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, int, int, int*, uint*, int, int*, uint*, int, uint>)0x00500D90)(ref this, x, y, a4, pcode, a6, a7, rindex, minimize_pal);

    /// <summary>
    /// <code>Offset: 0x00500EA0
    /// CSurface* __thiscall PalShift::MakeNewSurface(_DWORD*,int,char,int,int)</code>
    /// </summary>
    public ACBindings.Internal.CSurface* MakeNewSurface(int a2, sbyte a3, int a4, int numSubs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, int, sbyte, int, int, ACBindings.Internal.CSurface*>)0x00500EA0)(ref this, a2, a3, a4, numSubs);

    /// <summary>
    /// <code>Offset: 0x00500F20
    /// unsigned int __thiscall PalShift::Pack(PalShift*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, void**, uint*, uint>)0x00500F20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00501280
    /// void __thiscall PalShift::Destroy(PalShift*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, void>)0x00501280)(ref this);

    /// <summary>
    /// <code>Offset: 0x00501320
    /// int __thiscall PalShift::UnPack(PalShift*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, void**, uint*, int>)0x00501320)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00501430
    /// void __thiscall PalShift::~PalShift(PalShift*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShift, void>)0x00501430)(ref this);
}

