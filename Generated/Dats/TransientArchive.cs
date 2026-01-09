namespace ACBindings;

// TransientArchive
public unsafe struct TransientArchive
{
    // Base Classes
    public ACBindings.Archive BaseClass_Archive; // ACBindings.Archive

    // Child Types
    // TransientArchive_vtbl
    public unsafe struct TransientArchive_vtbl
    {
        // Members
        public System.IntPtr InitForPacking; // function pointer
        public System.IntPtr InitForUnpacking; // function pointer
        public System.IntPtr SetCheckpointing; // function pointer
        public System.IntPtr InitVersionStack; // function pointer
        public System.IntPtr CreateVersionStack; // function pointer
        public System.IntPtr InitForPacking_14; // function pointer
        public System.IntPtr InitForUnpacking_18; // function pointer

        // Methods
    }

    // Generated Constructor
    public TransientArchive(ACBindings.Archive.tagPacking formal) {
        _ConstructorInternal(formal);
    }
    public TransientArchive(ACBindings.Archive.tagUnpacking formal, System.IntPtr addr, uint size) {
        _ConstructorInternal(formal, addr, size);
    }

    // Methods
    // void __thiscall TransientArchive::TransientArchive(TransientArchive*,Archive::tagPacking)
    public void _ConstructorInternal(ACBindings.Archive.tagPacking formal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TransientArchive, ACBindings.Archive.tagPacking, void>)0x00401600)(ref this, formal);
    // void __thiscall TransientArchive::InitForPacking(TransientArchive*,const SmartBuffer*)
    public void InitForPacking(ACBindings.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TransientArchive, ACBindings.SmartBuffer*, void>)0x00401670)(ref this, i_buffer);
    // void __thiscall TransientArchive::InitForUnpacking(TransientArchive*,const SmartBuffer*)
    public void InitForUnpacking(ACBindings.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TransientArchive, ACBindings.SmartBuffer*, void>)0x00401690)(ref this, i_buffer);
    // void __thiscall TransientArchive::TransientArchive(TransientArchive*,Archive::tagUnpacking,void*,unsigned int)
    public void _ConstructorInternal(ACBindings.Archive.tagUnpacking formal, System.IntPtr addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TransientArchive, ACBindings.Archive.tagUnpacking, System.IntPtr, uint, void>)0x004F7A90)(ref this, formal, addr, size);
}

