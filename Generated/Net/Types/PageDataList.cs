namespace ACBindings;

// PageDataList
public unsafe struct PageDataList : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // PageDataList_vtbl
    public unsafe struct PageDataList_vtbl
    {
        // Members
        public System.IntPtr PageDataList_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PageData* first;
    public ACBindings.PageData* last;
    public int numPages;
    public int maxNumPages;
    public int maxNumCharsPerPage;
    public int packWithText;

    // Generated Constructor
    public PageDataList() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // PageData* __thiscall PageDataList::Get(PageDataList*,int)
    public ACBindings.PageData* Get(int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageDataList, int, ACBindings.PageData*>)0x005D2DC0)(ref this, pos);
    // void __thiscall PageDataList::PageDataList(PageDataList*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageDataList, void>)0x005D2DF0)(ref this);
    // void __thiscall PageDataList::Insert(PageDataList*,PageData*,int)
    public void Insert(ACBindings.PageData* pd, int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageDataList, ACBindings.PageData*, int, void>)0x005D2E20)(ref this, pd, pos);
    // PageData* __thiscall PageDataList::Remove(PageDataList*,int)
    public ACBindings.PageData* Remove(int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageDataList, int, ACBindings.PageData*>)0x005D2ED0)(ref this, pos);
    // void __thiscall PageDataList::Delete(PageDataList*,int)
    public void Delete(int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageDataList, int, void>)0x005D2F40)(ref this, pos);
    // void __thiscall PageDataList::Flush(PageDataList*)
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageDataList, void>)0x005D2F60)(ref this);
    // void __thiscall PageDataList::~PageDataList(PageDataList*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageDataList, void>)0x005D3090)(ref this);
    // int __thiscall PageDataList::UnPack(PageDataList*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageDataList, void**, uint, int>)0x005D30B0)(ref this, addr, size);
    // unsigned int __thiscall PageDataList::pack_size(PageDataList*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageDataList, uint>)0x005D3640)(ref this);
    // unsigned int __thiscall PageDataList::Pack(PageDataList*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageDataList, void**, uint, uint>)0x005D36A0)(ref this, addr, size);
}

