namespace ACBindings.Internal;


/// <summary>
/// HashBaseData&lt;unsigned long&gt; models an element in a hash table, holding a unique identifier and a link to the next entry for collision resolution. The vtable pointer allows derived types to implement virtual functions.
/// </summary>
public unsafe struct HashBaseData__uint
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr hash_next;
    public uint id;

    // Methods
}

public unsafe struct HashBaseData__ulong
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr hash_next;
    public ulong id;

    // Methods
}

