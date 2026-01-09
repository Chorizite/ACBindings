namespace ACBindings;

// IDataGraph
public unsafe struct IDataGraph
{
    // Child Types
    // IDataGraph_vtbl
    public unsafe struct IDataGraph_vtbl
    {
        // Members
        public System.IntPtr add_did;
        public System.IntPtr add_did_link;
        public System.IntPtr remove_did;
        public System.IntPtr add_iid; // function pointer
        public System.IntPtr add_iid_iid_link; // function pointer
        public System.IntPtr add_iid_did_link;
        public System.IntPtr remove_iid; // function pointer
        public System.IntPtr add; // function pointer
        public System.IntPtr add_link; // function pointer
        public System.IntPtr remove; // function pointer
        public System.IntPtr remove_link; // function pointer
        public System.IntPtr check_did_link;
        public System.IntPtr check_iid_link; // function pointer
        public System.IntPtr check_iid_did_link;
        public System.IntPtr check_ancestor_did;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

