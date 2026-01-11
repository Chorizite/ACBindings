namespace ACBindings.Internal;

public unsafe struct PageData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct PageData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PageData*, void> PageData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PageData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PageData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PageData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint authorID;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte authorName;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte authorAccount;
    public int textIncluded;
    public int ignoreAuthor;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte pageText;
    public ACBindings.Internal.PageData* prev;
    public ACBindings.Internal.PageData* next;

    // Generated Constructor
    public PageData() {
        _ConstructorInternal();
    }
    public PageData(void** a2, void*** a3, void*** a4, void*** a5, void** a6) {
        _ConstructorInternal(a2, a3, a4, a5, a6);
    }
    public PageData(ACBindings.Internal.PageData* pd, int includeText) {
        _ConstructorInternal(pd, includeText);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004BB980
    /// LONG __thiscall PageData::SetPageText(_DWORD*,LONG*)</code>
    /// </summary>
    public int SetPageText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, int*, int>)0x004BB980)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0055B180
    /// void __thiscall PageData::~PageData(PageData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, void>)0x0055B180)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D2FC0
    /// void __thiscall PageData::PageData(PageData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, void>)0x005D2FC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3020
    /// void*** __thiscall PageData::PageData(void***,void**,void***,void***,void***,void**)</code>
    /// </summary>
    public void*** _ConstructorInternal(void** a2, void*** a3, void*** a4, void*** a5, void** a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, void**, void***, void***, void***, void**, void***>)0x005D3020)(ref this, a2, a3, a4, a5, a6);

    /// <summary>
    /// <code>Offset: 0x005D32B0
    /// void __thiscall PageData::PageData(PageData*,PageData*,int)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.PageData* pd, int includeText) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, ACBindings.Internal.PageData*, int, void>)0x005D32B0)(ref this, pd, includeText);

    /// <summary>
    /// <code>Offset: 0x005D3380
    /// unsigned int __thiscall PageData::Pack(PageData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, void**, uint, uint>)0x005D3380)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D3460
    /// int __thiscall PageData::UnPack(PageData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, void**, uint, int>)0x005D3460)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D3510
    /// unsigned int __thiscall PageData::PackNoText(PageData*,void**,unsigned int)</code>
    /// </summary>
    public uint PackNoText(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, void**, uint, uint>)0x005D3510)(ref this, addr, size);
}

