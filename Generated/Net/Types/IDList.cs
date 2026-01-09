namespace ACBindings;

// IDList
public unsafe struct IDList : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // IDList_vtbl
    public unsafe struct IDList_vtbl
    {
        // Members
        public System.IntPtr IDList_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDListNode* first;
    public ACBindings.IDListNode* last;
    public ACBindings.IDListNode* curNode;
    public int numIDs;
    public int curNum;

    // Generated Constructor
    public IDList() {
        _ConstructorInternal();
    }
    public IDList(ACBindings.IDList* list) {
        _ConstructorInternal(list);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall IDList::Add(IDList*,unsigned int)
    public void Add(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, uint, void>)0x005AEC00)(ref this, id);
    // int __thiscall IDList::IsInList(IDList*,unsigned int)
    public int IsInList(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, uint, int>)0x005AEC80)(ref this, id);
    // int __thiscall IDList::SetCurToNext(IDList*)
    public int SetCurToNext() => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, int>)0x005AECB0)(ref this);
    // unsigned int __thiscall IDList::GetCurID(IDList*)
    public uint GetCurID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, uint>)0x005AECE0)(ref this);
    // IDListNode* __thiscall IDList::GetNodeByNum(IDList*,int)
    public ACBindings.IDListNode* GetNodeByNum(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, int, ACBindings.IDListNode*>)0x005AECF0)(ref this, num);
    // void __thiscall IDList::IDList(IDList*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, void>)0x005AEDB0)(ref this);
    // int __thiscall IDList::AddAtNum(IDList*,unsigned int,int,int)
    public int AddAtNum(uint id, int num, int addAtEndOnFail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, uint, int, int, int>)0x005AEDD0)(ref this, id, num, addAtEndOnFail);
    // int __thiscall IDList::RemoveByID(IDList*,unsigned int)
    public int RemoveByID(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, uint, int>)0x005AEEA0)(ref this, id);
    // unsigned int __thiscall IDList::GetByNum(IDList*,int)
    public uint GetByNum(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, int, uint>)0x005AEEF0)(ref this, num);
    // void __thiscall IDList::Clear(IDList*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, void>)0x005AEF10)(ref this);
    // int __thiscall IDList::SetCurToNum(IDList*,int)
    public int SetCurToNum(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, int, int>)0x005AEFC0)(ref this, num);
    // unsigned int __thiscall IDList::Pack(IDList*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, void**, uint, uint>)0x005AEFF0)(ref this, addr, size);
    // int __thiscall IDList::UnPack(IDList*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, void**, uint, int>)0x005AF0A0)(ref this, addr, size);
    // void __thiscall IDList::~IDList(IDList*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, void>)0x005AF120)(ref this);
    // void __thiscall IDList::AddList(IDList*,IDList*)
    public void AddList(ACBindings.IDList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, ACBindings.IDList*, void>)0x005AF140)(ref this, list);
    // void __thiscall IDList::IDList(IDList*,IDList*)
    public void _ConstructorInternal(ACBindings.IDList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IDList, ACBindings.IDList*, void>)0x005AF210)(ref this, list);
}

