namespace ACBindings.Internal;


/// <summary>Facilitates graph operations by exposing a virtual method table, enabling polymorphic implementations of data manipulation and traversal functions.</summary>
public unsafe struct IDataGraph
{
    // Child Types

    /// <summary>
    /// Defines the virtual function table for IDataGraph, exposing operations for adding and removing data identifiers (DID/IID) and managing links between them within a graph structure.
    /// </summary>
    public unsafe struct IDataGraph_vtbl
    {
        // Members
        public System.IntPtr add_did;
        public System.IntPtr add_did_link;
        public System.IntPtr remove_did;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, uint, byte> add_iid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, uint, uint, byte> add_iid_iid_link; // function pointer
        public System.IntPtr add_iid_did_link;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, uint, byte> remove_iid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, System.IntPtr, byte> add; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, System.IntPtr, System.IntPtr, byte> add_link; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, System.IntPtr, byte> remove; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, System.IntPtr, System.IntPtr, byte> remove_link; // function pointer
        public System.IntPtr check_did_link;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IDataGraph*, uint, uint, byte> check_iid_link; // function pointer
        public System.IntPtr check_iid_did_link;
        public System.IntPtr check_ancestor_did;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

