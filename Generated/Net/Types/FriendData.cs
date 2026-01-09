namespace ACBindings;

// FriendData
public unsafe struct FriendData : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // FriendData_vtbl
    public unsafe struct FriendData_vtbl
    {
        // Members
        public System.IntPtr FriendData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_id;
    public ACBindings.AC1Legacy.PStringBase__sbyte m_name;
    public int m_online;
    public int m_appearOffline;
    public ACBindings.PList__uint m_friendsList;
    public ACBindings.PList__uint m_friendOfList;

    // Generated Constructor
    public FriendData() {
        _ConstructorInternal();
    }
    public FriendData(ACBindings.FriendData* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall FriendData::~FriendData(FriendData*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FriendData, void>)0x0048C960)(ref this);
    // unsigned int __thiscall FriendData::GetPackSize(FriendData*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FriendData, uint>)0x005BADA0)(ref this);
    // unsigned int __thiscall FriendData::Pack(FriendData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FriendData, void**, uint, uint>)0x005BADF0)(ref this, addr, size);
    // int __thiscall FriendData::UnPack(FriendData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FriendData, void**, uint, int>)0x005BAE60)(ref this, addr, size);
    // void __thiscall FriendData::FriendData(FriendData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FriendData, void>)0x005BAED0)(ref this);
    // void __thiscall FriendData::FriendData(FriendData*,const FriendData*)
    public void _ConstructorInternal(ACBindings.FriendData* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FriendData, ACBindings.FriendData*, void>)0x005BAFC0)(ref this, rhs);
}

