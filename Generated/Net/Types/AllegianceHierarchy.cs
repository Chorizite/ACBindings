namespace ACBindings;

// AllegianceHierarchy
public unsafe struct AllegianceHierarchy : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // AllegianceHierarchy_vtbl
    public unsafe struct AllegianceHierarchy_vtbl
    {
        // Members
        public System.IntPtr AllegianceHierarchy_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr GetMinPackSize; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AllegianceVersion m_oldVersion;
    public ACBindings.AllegianceNode* m_pMonarch;
    public uint m_total;
    public int m_monarchBroadcastTime;
    public int m_spokesBroadcastTime;
    public uint m_monarchBroadcastsToday;
    public uint m_spokesBroadcastsToday;
    public ACBindings.AC1Legacy.PStringBase__sbyte m_motd;
    public ACBindings.AC1Legacy.PStringBase__sbyte m_motdSetBy;
    public ACBindings.AC1Legacy.PStringBase__sbyte m_AllegianceName;
    public int m_NameLastSetTime;
    public uint m_chatRoomID;
    public ACBindings.PHashTable__uint__uint m_AllegianceOfficers;
    public ACBindings.PSmartArray__AC1Legacy_PStringBase__sbyte m_OfficerTitles;
    public ACBindings.Position m_BindPoint;
    public int m_isLocked;
    public uint m_ApprovedVassal;

    // Generated Constructor
    public AllegianceHierarchy() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall AllegianceHierarchy::Clear(AllegianceHierarchy*,AllegianceNode**)
    public void Clear(ACBindings.AllegianceNode** node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, ACBindings.AllegianceNode**, void>)0x005B7D10)(ref this, node);
    // unsigned int __thiscall AllegianceHierarchy::GetNodePackSize(AllegianceHierarchy*,AllegianceNode*)
    public uint GetNodePackSize(ACBindings.AllegianceNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, ACBindings.AllegianceNode*, uint>)0x005B7D70)(ref this, node);
    // AllegianceNode* __thiscall AllegianceHierarchy::Search(AllegianceHierarchy*,const unsigned int,AllegianceNode*)
    public ACBindings.AllegianceNode* Search(uint id, ACBindings.AllegianceNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, uint, ACBindings.AllegianceNode*, ACBindings.AllegianceNode*>)0x005B7DD0)(ref this, id, node);
    // unsigned int __thiscall AllegianceHierarchy::GetMonarchID(AllegianceHierarchy*)
    public uint GetMonarchID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, uint>)0x005B7E10)(ref this);
    // unsigned int __thiscall AllegianceHierarchy::PackNode(AllegianceHierarchy*,AllegianceNode*,void**,unsigned int)
    public uint PackNode(ACBindings.AllegianceNode* node, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, ACBindings.AllegianceNode*, void**, uint, uint>)0x005B7E20)(ref this, node, addr, size);
    // int __thiscall AllegianceHierarchy::LookUp(AllegianceHierarchy*,const unsigned int,AllegianceData*)
    public int LookUp(uint id, ACBindings.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, uint, ACBindings.AllegianceData*, int>)0x005B7E90)(ref this, id, retval);
    // int __thiscall AllegianceHierarchy::Add(AllegianceHierarchy*,const unsigned int,const AllegianceData*)
    public int Add(uint patron, ACBindings.AllegianceData* new_data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, uint, ACBindings.AllegianceData*, int>)0x005B7FD0)(ref this, patron, new_data);
    // int __thiscall AllegianceHierarchy::Copy(AllegianceHierarchy*,AllegianceNode*,int)
    public int Copy(ACBindings.AllegianceNode* node, int copy_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, ACBindings.AllegianceNode*, int, int>)0x005B8090)(ref this, node, copy_node);
    // unsigned int __thiscall AllegianceHierarchy::GetPackSize(AllegianceHierarchy*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, uint>)0x005B8100)(ref this);
    // unsigned int __thiscall AllegianceHierarchy::Pack(AllegianceHierarchy*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, void**, uint, uint>)0x005B81A0)(ref this, addr, size);
    // void __thiscall AllegianceHierarchy::Clear(AllegianceHierarchy*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, void>)0x005B8550)(ref this);
    // int __thiscall AllegianceHierarchy::UnPack(AllegianceHierarchy*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, void**, uint, int>)0x005B8660)(ref this, addr, size);
    // void __thiscall AllegianceHierarchy::AllegianceHierarchy(AllegianceHierarchy*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, void>)0x005B8930)(ref this);
    // void __thiscall AllegianceHierarchy::~AllegianceHierarchy(AllegianceHierarchy*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceHierarchy, void>)0x005B8C00)(ref this);
}

