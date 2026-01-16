namespace ACBindings.Internal;


/// <summary>Represents a dynamic collection of generic pointers, maintaining an internal buffer for efficient memory management and supporting bulk insertion operations.</summary>
/// <remarks>Legacy implementation predating modern container classes, used by older components within the system.</remarks>
public unsafe struct OldList
{
    // Child Types
    public unsafe struct OldList_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OldList*, void> OldList_dtor_0; // function pointer

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

