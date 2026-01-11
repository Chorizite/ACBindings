namespace ACBindings.Internal;

public unsafe struct FriendData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct FriendData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FriendData*, void> FriendData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FriendData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FriendData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FriendData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_id;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_name;
    public int m_online;
    public int m_appearOffline;
    public ACBindings.Internal.PList__uint m_friendsList;
    public ACBindings.Internal.PList__uint m_friendOfList;

    // Generated Constructor
    public FriendData() {
        _ConstructorInternal();
    }
    public FriendData(ACBindings.Internal.FriendData* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0048C960
    /// void __thiscall FriendData::~FriendData(FriendData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FriendData, void>)0x0048C960)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BADA0
    /// unsigned int __thiscall FriendData::GetPackSize(FriendData*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FriendData, uint>)0x005BADA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BADF0
    /// unsigned int __thiscall FriendData::Pack(FriendData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FriendData, void**, uint, uint>)0x005BADF0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BAE60
    /// int __thiscall FriendData::UnPack(FriendData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FriendData, void**, uint, int>)0x005BAE60)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BAED0
    /// void __thiscall FriendData::FriendData(FriendData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FriendData, void>)0x005BAED0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BAFC0
    /// void __thiscall FriendData::FriendData(FriendData*,const FriendData*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.FriendData* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FriendData, ACBindings.Internal.FriendData*, void>)0x005BAFC0)(ref this, rhs);
}

