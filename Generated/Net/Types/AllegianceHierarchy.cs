namespace ACBindings.Internal;

public unsafe struct AllegianceHierarchy : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AllegianceHierarchy_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceHierarchy*, void> AllegianceHierarchy_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceHierarchy*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceHierarchy*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceHierarchy*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceHierarchy*, uint> GetMinPackSize; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AllegianceVersion m_oldVersion;
    public ACBindings.Internal.AllegianceNode* m_pMonarch;
    public uint m_total;
    public int m_monarchBroadcastTime;
    public int m_spokesBroadcastTime;
    public uint m_monarchBroadcastsToday;
    public uint m_spokesBroadcastsToday;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_motd;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_motdSetBy;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_AllegianceName;
    public int m_NameLastSetTime;
    public uint m_chatRoomID;
    public ACBindings.Internal.PHashTable__uint__uint m_AllegianceOfficers;
    public ACBindings.Internal.PSmartArray___AC1Legacy_PStringBase__sbyte m_OfficerTitles;
    public ACBindings.Internal.Position m_BindPoint;
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

    /// <summary>
    /// <code>Offset: 0x005B7D10
    /// void __thiscall AllegianceHierarchy::Clear(AllegianceHierarchy*,AllegianceNode**)</code>
    /// </summary>
    public void Clear(ACBindings.Internal.AllegianceNode** node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, ACBindings.Internal.AllegianceNode**, void>)0x005B7D10)(ref this, node);

    /// <summary>
    /// <code>Offset: 0x005B7D70
    /// unsigned int __thiscall AllegianceHierarchy::GetNodePackSize(AllegianceHierarchy*,AllegianceNode*)</code>
    /// </summary>
    public uint GetNodePackSize(ACBindings.Internal.AllegianceNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, ACBindings.Internal.AllegianceNode*, uint>)0x005B7D70)(ref this, node);

    /// <summary>
    /// <code>Offset: 0x005B7DD0
    /// AllegianceNode* __thiscall AllegianceHierarchy::Search(AllegianceHierarchy*,const unsigned int,AllegianceNode*)</code>
    /// </summary>
    public ACBindings.Internal.AllegianceNode* Search(uint id, ACBindings.Internal.AllegianceNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, uint, ACBindings.Internal.AllegianceNode*, ACBindings.Internal.AllegianceNode*>)0x005B7DD0)(ref this, id, node);

    /// <summary>
    /// <code>Offset: 0x005B7E10
    /// unsigned int __thiscall AllegianceHierarchy::GetMonarchID(AllegianceHierarchy*)</code>
    /// </summary>
    public uint GetMonarchID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, uint>)0x005B7E10)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B7E20
    /// unsigned int __thiscall AllegianceHierarchy::PackNode(AllegianceHierarchy*,AllegianceNode*,void**,unsigned int)</code>
    /// </summary>
    public uint PackNode(ACBindings.Internal.AllegianceNode* node, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, ACBindings.Internal.AllegianceNode*, void**, uint, uint>)0x005B7E20)(ref this, node, addr, size);

    /// <summary>
    /// <code>Offset: 0x005B7E90
    /// int __thiscall AllegianceHierarchy::LookUp(AllegianceHierarchy*,const unsigned int,AllegianceData*)</code>
    /// </summary>
    public int LookUp(uint id, ACBindings.Internal.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, uint, ACBindings.Internal.AllegianceData*, int>)0x005B7E90)(ref this, id, retval);

    /// <summary>
    /// <code>Offset: 0x005B7FD0
    /// int __thiscall AllegianceHierarchy::Add(AllegianceHierarchy*,const unsigned int,const AllegianceData*)</code>
    /// </summary>
    public int Add(uint patron, ACBindings.Internal.AllegianceData* new_data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, uint, ACBindings.Internal.AllegianceData*, int>)0x005B7FD0)(ref this, patron, new_data);

    /// <summary>
    /// <code>Offset: 0x005B8090
    /// int __thiscall AllegianceHierarchy::Copy(AllegianceHierarchy*,AllegianceNode*,int)</code>
    /// </summary>
    public int Copy(ACBindings.Internal.AllegianceNode* node, int copy_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, ACBindings.Internal.AllegianceNode*, int, int>)0x005B8090)(ref this, node, copy_node);

    /// <summary>
    /// <code>Offset: 0x005B8100
    /// unsigned int __thiscall AllegianceHierarchy::GetPackSize(AllegianceHierarchy*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, uint>)0x005B8100)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B81A0
    /// unsigned int __thiscall AllegianceHierarchy::Pack(AllegianceHierarchy*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, void**, uint, uint>)0x005B81A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005B8550
    /// void __thiscall AllegianceHierarchy::Clear(AllegianceHierarchy*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, void>)0x005B8550)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B8660
    /// int __thiscall AllegianceHierarchy::UnPack(AllegianceHierarchy*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, void**, uint, int>)0x005B8660)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005B8930
    /// void __thiscall AllegianceHierarchy::AllegianceHierarchy(AllegianceHierarchy*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, void>)0x005B8930)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B8C00
    /// void __thiscall AllegianceHierarchy::~AllegianceHierarchy(AllegianceHierarchy*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, void>)0x005B8C00)(ref this);
}

