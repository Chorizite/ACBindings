namespace ACBindings.Internal;

public unsafe struct IDList : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct IDList_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDList*, void> IDList_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDList*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDList*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDList*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDListNode* first;
    public ACBindings.Internal.IDListNode* last;
    public ACBindings.Internal.IDListNode* curNode;
    public int numIDs;
    public int curNum;

    // Generated Constructor
    public IDList() {
        _ConstructorInternal();
    }
    public IDList(ACBindings.Internal.IDList* list) {
        _ConstructorInternal(list);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005AEC00
    /// void __thiscall IDList::Add(IDList*,unsigned int)</code>
    /// </summary>
    public void Add(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, uint, void>)0x005AEC00)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x005AEC80
    /// int __thiscall IDList::IsInList(IDList*,unsigned int)</code>
    /// </summary>
    public int IsInList(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, uint, int>)0x005AEC80)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x005AECB0
    /// int __thiscall IDList::SetCurToNext(IDList*)</code>
    /// </summary>
    public int SetCurToNext() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, int>)0x005AECB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AECE0
    /// unsigned int __thiscall IDList::GetCurID(IDList*)</code>
    /// </summary>
    public uint GetCurID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, uint>)0x005AECE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AECF0
    /// IDListNode* __thiscall IDList::GetNodeByNum(IDList*,int)</code>
    /// </summary>
    public ACBindings.Internal.IDListNode* GetNodeByNum(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, int, ACBindings.Internal.IDListNode*>)0x005AECF0)(ref this, num);

    /// <summary>
    /// <code>Offset: 0x005AEDB0
    /// void __thiscall IDList::IDList(IDList*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, void>)0x005AEDB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AEDD0
    /// int __thiscall IDList::AddAtNum(IDList*,unsigned int,int,int)</code>
    /// </summary>
    public int AddAtNum(uint id, int num, int addAtEndOnFail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, uint, int, int, int>)0x005AEDD0)(ref this, id, num, addAtEndOnFail);

    /// <summary>
    /// <code>Offset: 0x005AEEA0
    /// int __thiscall IDList::RemoveByID(IDList*,unsigned int)</code>
    /// </summary>
    public int RemoveByID(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, uint, int>)0x005AEEA0)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x005AEEF0
    /// unsigned int __thiscall IDList::GetByNum(IDList*,int)</code>
    /// </summary>
    public uint GetByNum(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, int, uint>)0x005AEEF0)(ref this, num);

    /// <summary>
    /// <code>Offset: 0x005AEF10
    /// void __thiscall IDList::Clear(IDList*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, void>)0x005AEF10)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AEFC0
    /// int __thiscall IDList::SetCurToNum(IDList*,int)</code>
    /// </summary>
    public int SetCurToNum(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, int, int>)0x005AEFC0)(ref this, num);

    /// <summary>
    /// <code>Offset: 0x005AEFF0
    /// unsigned int __thiscall IDList::Pack(IDList*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, void**, uint, uint>)0x005AEFF0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AF0A0
    /// int __thiscall IDList::UnPack(IDList*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, void**, uint, int>)0x005AF0A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AF120
    /// void __thiscall IDList::~IDList(IDList*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, void>)0x005AF120)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AF140
    /// void __thiscall IDList::AddList(IDList*,IDList*)</code>
    /// </summary>
    public void AddList(ACBindings.Internal.IDList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, ACBindings.Internal.IDList*, void>)0x005AF140)(ref this, list);

    /// <summary>
    /// <code>Offset: 0x005AF210
    /// void __thiscall IDList::IDList(IDList*,IDList*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.IDList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, ACBindings.Internal.IDList*, void>)0x005AF210)(ref this, list);
}

