namespace ACBindings;

// CharacterIdentity
public unsafe struct CharacterIdentity : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CharacterIdentity_vtbl
    public unsafe struct CharacterIdentity_vtbl
    {
        // Members
        public System.IntPtr CharacterIdentity_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint gid_;
    public ACBindings.AC1Legacy.PStringBase__sbyte name_;
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
    // void __thiscall CharacterIdentity::~CharacterIdentity(CharacterIdentity*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterIdentity, void>)0x004FEB40)(ref this);
    // void __thiscall CharacterIdentity::CharacterIdentity(CharacterIdentity*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterIdentity, void>)0x004FF180)(ref this);
    // unsigned int __thiscall CharacterIdentity::pack_size(CharacterIdentity*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterIdentity, uint>)0x004FF1B0)(ref this);
    // unsigned int __thiscall CharacterIdentity::Pack(CharacterIdentity*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterIdentity, void**, uint, uint>)0x004FF200)(ref this, addr, size);
    // int __thiscall CharacterIdentity::UnPack(CharacterIdentity*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharacterIdentity, void**, uint, int>)0x004FF300)(ref this, addr, size);
}

