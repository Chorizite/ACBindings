namespace ACBindings.Internal;

public unsafe struct CharacterSet : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj
    public ACBindings.Internal.StrHashData BaseClass_StrHashData; // ACBindings.Internal.StrHashData

    // Child Types
    public unsafe struct CharacterSet_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterSet*, void> CharacterSet_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterSet*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterSet*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterSet*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.SmartArray___CharacterIdentity set_;
    public ACBindings.Internal.AC1Legacy.SmartArray___CharacterIdentity delSet_;
    public uint status_;
    public int numAllowedCharacters_;
    public ACBindings.Internal.accountID account_;
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

    /// <summary>
    /// <code>Offset: 0x00479D30
    /// void __thiscall CharacterSet::CharacterSet(CharacterSet*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, void>)0x00479D30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00479D80
    /// void __thiscall CharacterSet::~CharacterSet(CharacterSet*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, void>)0x00479D80)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E8B20
    /// CharacterIdentity* __thiscall CharacterSet::GetIdentity(CharacterSet*,int)</code>
    /// </summary>
    public ACBindings.Internal.CharacterIdentity* GetIdentity(int indexSigned) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, int, ACBindings.Internal.CharacterIdentity*>)0x004E8B20)(ref this, indexSigned);

    /// <summary>
    /// <code>Offset: 0x004FE960
    /// void __thiscall CharacterSet::ClearIdentity(CharacterSet*,int)</code>
    /// </summary>
    public void ClearIdentity(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, int, void>)0x004FE960)(ref this, slot);

    /// <summary>
    /// <code>Offset: 0x004FE980
    /// const char* __thiscall CharacterSet::GetName(CharacterSet*,int)</code>
    /// </summary>
    public sbyte* GetName(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, int, sbyte*>)0x004FE980)(ref this, index);

    /// <summary>
    /// <code>Offset: 0x004FE9B0
    /// unsigned int __thiscall CharacterSet::GetGID(CharacterSet*,int)</code>
    /// </summary>
    public uint GetGID(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, int, uint>)0x004FE9B0)(ref this, slot);

    /// <summary>
    /// <code>Offset: 0x004FE9E0
    /// int __thiscall CharacterSet::GetSlot(CharacterSet*,unsigned int)</code>
    /// </summary>
    public int GetSlot(uint i_iidAvatar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, uint, int>)0x004FE9E0)(ref this, i_iidAvatar);

    /// <summary>
    /// <code>Offset: 0x004FEA20
    /// unsigned int __thiscall CharacterSet::GetGreyedOutFor(CharacterSet*,int)</code>
    /// </summary>
    public uint GetGreyedOutFor(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, int, uint>)0x004FEA20)(ref this, slot);

    /// <summary>
    /// <code>Offset: 0x004FEC30
    /// unsigned int __thiscall CharacterSet::pack_size(CharacterSet*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, uint>)0x004FEC30)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FECE0
    /// unsigned int __thiscall CharacterSet::Pack(CharacterSet*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, void**, uint, uint>)0x004FECE0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x004FEDC0
    /// int __thiscall CharacterSet::UnPack(CharacterSet*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, void**, uint, int>)0x004FEDC0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x004FEF70
    /// int __thiscall CharacterSet::AddIdentity(CharacterSet*,CharacterIdentity*)</code>
    /// </summary>
    public int AddIdentity(ACBindings.Internal.CharacterIdentity* toAdd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, ACBindings.Internal.CharacterIdentity*, int>)0x004FEF70)(ref this, toAdd);
}

