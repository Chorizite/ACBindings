namespace ACBindings.Internal;

public unsafe struct PageDataList : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct PageDataList_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PageDataList*, void> PageDataList_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PageDataList*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PageDataList*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PageDataList*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PageData* first;
    public ACBindings.Internal.PageData* last;
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

    /// <summary>
    /// <code>Offset: 0x005D2DC0
    /// PageData* __thiscall PageDataList::Get(PageDataList*,int)</code>
    /// </summary>
    public ACBindings.Internal.PageData* Get(int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, int, ACBindings.Internal.PageData*>)0x005D2DC0)(ref this, pos);

    /// <summary>
    /// <code>Offset: 0x005D2DF0
    /// void __thiscall PageDataList::PageDataList(PageDataList*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, void>)0x005D2DF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D2E20
    /// void __thiscall PageDataList::Insert(PageDataList*,PageData*,int)</code>
    /// </summary>
    public void Insert(ACBindings.Internal.PageData* pd, int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, ACBindings.Internal.PageData*, int, void>)0x005D2E20)(ref this, pd, pos);

    /// <summary>
    /// <code>Offset: 0x005D2ED0
    /// PageData* __thiscall PageDataList::Remove(PageDataList*,int)</code>
    /// </summary>
    public ACBindings.Internal.PageData* Remove(int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, int, ACBindings.Internal.PageData*>)0x005D2ED0)(ref this, pos);

    /// <summary>
    /// <code>Offset: 0x005D2F40
    /// void __thiscall PageDataList::Delete(PageDataList*,int)</code>
    /// </summary>
    public void Delete(int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, int, void>)0x005D2F40)(ref this, pos);

    /// <summary>
    /// <code>Offset: 0x005D2F60
    /// void __thiscall PageDataList::Flush(PageDataList*)</code>
    /// </summary>
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, void>)0x005D2F60)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3090
    /// void __thiscall PageDataList::~PageDataList(PageDataList*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, void>)0x005D3090)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D30B0
    /// int __thiscall PageDataList::UnPack(PageDataList*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, void**, uint, int>)0x005D30B0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D3640
    /// unsigned int __thiscall PageDataList::pack_size(PageDataList*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, uint>)0x005D3640)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D36A0
    /// unsigned int __thiscall PageDataList::Pack(PageDataList*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, void**, uint, uint>)0x005D36A0)(ref this, addr, size);
}

