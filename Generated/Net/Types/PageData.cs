namespace ACBindings;

// PageData
public unsafe struct PageData : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // PageData_vtbl
    public unsafe struct PageData_vtbl
    {
        // Members
        public System.IntPtr PageData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint authorID;
    public ACBindings.AC1Legacy.PStringBase__sbyte authorName;
    public ACBindings.AC1Legacy.PStringBase__sbyte authorAccount;
    public int textIncluded;
    public int ignoreAuthor;
    public ACBindings.AC1Legacy.PStringBase__sbyte pageText;
    public ACBindings.PageData* prev;
    public ACBindings.PageData* next;

    // Generated Constructor
    public PageData() {
        _ConstructorInternal();
    }
    public PageData(void** a2, void*** a3, void*** a4, void*** a5, void** a6) {
        _ConstructorInternal(a2, a3, a4, a5, a6);
    }
    public PageData(ACBindings.PageData* pd, int includeText) {
        _ConstructorInternal(pd, includeText);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // LONG __thiscall PageData::SetPageText(_DWORD*,LONG*)
    public int SetPageText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageData, int*, int>)0x004BB980)(ref this, a2);
    // void __thiscall PageData::~PageData(PageData*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageData, void>)0x0055B180)(ref this);
    // void __thiscall PageData::PageData(PageData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageData, void>)0x005D2FC0)(ref this);
    // void*** __thiscall PageData::PageData(void***,void**,void***,void***,void***,void**)
    public void*** _ConstructorInternal(void** a2, void*** a3, void*** a4, void*** a5, void** a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageData, void**, void***, void***, void***, void**, void***>)0x005D3020)(ref this, a2, a3, a4, a5, a6);
    // void __thiscall PageData::PageData(PageData*,PageData*,int)
    public void _ConstructorInternal(ACBindings.PageData* pd, int includeText) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageData, ACBindings.PageData*, int, void>)0x005D32B0)(ref this, pd, includeText);
    // unsigned int __thiscall PageData::Pack(PageData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageData, void**, uint, uint>)0x005D3380)(ref this, addr, size);
    // int __thiscall PageData::UnPack(PageData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageData, void**, uint, int>)0x005D3460)(ref this, addr, size);
    // unsigned int __thiscall PageData::PackNoText(PageData*,void**,unsigned int)
    public uint PackNoText(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageData, void**, uint, uint>)0x005D3510)(ref this, addr, size);
}

