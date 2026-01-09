namespace ACBindings;

// OldList
public unsafe struct OldList
{
    // Child Types
    // OldList_vtbl
    public unsafe struct OldList_vtbl
    {
        // Members
        public System.IntPtr OldList_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr current;
    public int numItems;
    public void** pointBuff;
    public int pointBuffSize;
    public int curNum;
    public int multiInsertStartNum;

    // Methods
}

