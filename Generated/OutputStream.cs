namespace ACBindings.Internal;

public unsafe struct OutputStream
{
    // Child Types
    public unsafe struct OutputStream_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OutputStream*, void> OutputStream_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public byte saving_to_string;
    public byte* file_ptr;
    public System.IntPtr m_pstring_stream;

    // Methods
}

