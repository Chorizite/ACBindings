namespace ACBindings.Internal;

public unsafe struct CharacterIdentity : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CharacterIdentity_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterIdentity*, void> CharacterIdentity_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterIdentity*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterIdentity*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterIdentity*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint gid_;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte name_;
    public uint secondsGreyedOut_;

    // Generated Constructor
    public CharacterIdentity() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004FEB40
    /// void __thiscall CharacterIdentity::~CharacterIdentity(CharacterIdentity*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterIdentity, void>)0x004FEB40)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FF180
    /// void __thiscall CharacterIdentity::CharacterIdentity(CharacterIdentity*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterIdentity, void>)0x004FF180)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FF1B0
    /// unsigned int __thiscall CharacterIdentity::pack_size(CharacterIdentity*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterIdentity, uint>)0x004FF1B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FF200
    /// unsigned int __thiscall CharacterIdentity::Pack(CharacterIdentity*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterIdentity, void**, uint, uint>)0x004FF200)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x004FF300
    /// int __thiscall CharacterIdentity::UnPack(CharacterIdentity*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterIdentity, void**, uint, int>)0x004FF300)(ref this, addr, size);
}

