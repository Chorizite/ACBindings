namespace ACBindings;

// CharacterSet
public unsafe struct CharacterSet : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj
    public ACBindings.StrHashData BaseClass_StrHashData; // ACBindings.StrHashData

    // Child Types
    // CharacterSet_vtbl
    public unsafe struct CharacterSet_vtbl
    {
        // Members
        public System.IntPtr CharacterSet_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.SmartArray__CharacterIdentity set_;
    public ACBindings.AC1Legacy.SmartArray__CharacterIdentity delSet_;
    public uint status_;
    public int numAllowedCharacters_;
    public ACBindings.accountID account_;
    public int m_fUseTurbineChat;
    public int m_fHasThroneofDestiny;

    // Generated Constructor
    public CharacterSet() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CharacterSet::CharacterSet(CharacterSet*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterSet, void>)0x00479D30)(ref this);
    // void __thiscall CharacterSet::~CharacterSet(CharacterSet*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterSet, void>)0x00479D80)(ref this);
    // CharacterIdentity* __thiscall CharacterSet::GetIdentity(CharacterSet*,int)
    public ACBindings.CharacterIdentity* GetIdentity(int indexSigned) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterSet, int, ACBindings.CharacterIdentity*>)0x004E8B20)(ref this, indexSigned);
    // void __thiscall CharacterSet::ClearIdentity(CharacterSet*,int)
    public void ClearIdentity(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterSet, int, void>)0x004FE960)(ref this, slot);
    // const char* __thiscall CharacterSet::GetName(CharacterSet*,int)
    public sbyte* GetName(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterSet, int, sbyte*>)0x004FE980)(ref this, index);
    // unsigned int __thiscall CharacterSet::GetGID(CharacterSet*,int)
    public uint GetGID(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterSet, int, uint>)0x004FE9B0)(ref this, slot);
    // int __thiscall CharacterSet::GetSlot(CharacterSet*,unsigned int)
    public int GetSlot(uint i_iidAvatar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterSet, uint, int>)0x004FE9E0)(ref this, i_iidAvatar);
    // unsigned int __thiscall CharacterSet::GetGreyedOutFor(CharacterSet*,int)
    public uint GetGreyedOutFor(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterSet, int, uint>)0x004FEA20)(ref this, slot);
    // unsigned int __thiscall CharacterSet::pack_size(CharacterSet*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterSet, uint>)0x004FEC30)(ref this);
    // unsigned int __thiscall CharacterSet::Pack(CharacterSet*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterSet, void**, uint, uint>)0x004FECE0)(ref this, addr, size);
    // int __thiscall CharacterSet::UnPack(CharacterSet*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterSet, void**, uint, int>)0x004FEDC0)(ref this, addr, size);
    // int __thiscall CharacterSet::AddIdentity(CharacterSet*,CharacterIdentity*)
    public int AddIdentity(ACBindings.CharacterIdentity* toAdd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterSet, ACBindings.CharacterIdentity*, int>)0x004FEF70)(ref this, toAdd);
}

