namespace ACBindings.Internal;

public unsafe struct StringTableGen
{
    // Child Types
    public unsafe struct StringTableGen_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StringTableGen*, void> StringTableGen_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StringTableGen*, void> Reset; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StringTableGen*, byte> Save; // function pointer
        public System.IntPtr AddString;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StringTableGen*, void> Report; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

