namespace ACBindings.Internal;

public unsafe struct IDataGraph
{
    // Child Types
    public unsafe struct IDataGraph_vtbl
    {
        // Members
        public System.IntPtr add_did;
        public System.IntPtr add_did_link;
        public System.IntPtr remove_did;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, uint, byte> add_iid; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, uint, uint, byte> add_iid_iid_link; // function pointer
        public System.IntPtr add_iid_did_link;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, uint, byte> remove_iid; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, System.IntPtr, byte> add; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, System.IntPtr, System.IntPtr, byte> add_link; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, System.IntPtr, byte> remove; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, System.IntPtr, System.IntPtr, byte> remove_link; // function pointer
        public System.IntPtr check_did_link;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, uint, uint, byte> check_iid_link; // function pointer
        public System.IntPtr check_iid_did_link;
        public System.IntPtr check_ancestor_did;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

