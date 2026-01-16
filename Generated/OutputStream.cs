namespace ACBindings.Internal;


/// <summary>Encapsulates an output destination that can write data either to a file handle or an internal string buffer, using a virtual function table to support different stream implementations.</summary>
public unsafe struct OutputStream
{
    // Child Types

    /// <summary>Defines the vtable layout for OutputStream, exposing its destructor and enabling polymorphic cleanup of derived streams.</summary>
    public unsafe struct OutputStream_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OutputStream*, void> OutputStream_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public byte saving_to_string;
    public byte* file_ptr;
    public System.IntPtr m_pstring_stream;

    // Methods
}

