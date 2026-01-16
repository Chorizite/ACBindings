namespace ACBindings.Internal;


/// <summary>Maintains a set of integers optimized for mostly consecutive ranges, storing values in a compact array and tracking sorted state for fast operations.</summary>
/// <remarks>Used internally to handle integer collections where runs of consecutive numbers are frequent, enabling efficient storage and quick membership checks.</remarks>
public unsafe struct CMostlyConsecutiveIntSet : System.IDisposable
{
    // Child Types

    /// <summary>Defines the virtual function table layout for CMostlyConsecutiveIntSet, exposing a pointer to its Serialize routine used during data persistence.</summary>
    public unsafe struct CMostlyConsecutiveIntSet_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CMostlyConsecutiveIntSet*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.SmartArray__int m_Ints;
    public byte m_bSorted;

    // Generated Constructor
    public CMostlyConsecutiveIntSet() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases resources owned by the set, deallocating its integer array when necessary.
    /// <code>Offset: 0x004F8C10
    /// void __thiscall CMostlyConsecutiveIntSet::~CMostlyConsecutiveIntSet(CMostlyConsecutiveIntSet*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMostlyConsecutiveIntSet, void>)0x004F8C10)(ref this);

    /// <summary>Sorts the internal integer set in ascending order and removes any duplicate entries. If duplicates are found, the set is re-sorted after removal to maintain order.
    /// <code>Offset: 0x00670F20
    /// void __thiscall CMostlyConsecutiveIntSet::Sort(CMostlyConsecutiveIntSet*)</code>
    /// </summary>
    public void Sort() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMostlyConsecutiveIntSet, void>)0x00670F20)(ref this);

    /// <summary>Creates a new instance of CMostlyConsecutiveIntSet, initializing the internal array to empty and marking the set as sorted.
    /// <code>Offset: 0x00670FC0
    /// void __thiscall CMostlyConsecutiveIntSet::CMostlyConsecutiveIntSet(CMostlyConsecutiveIntSet*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMostlyConsecutiveIntSet, void>)0x00670FC0)(ref this);

    /// <summary>Serializes or deserializes a mostly consecutive integer set to or from an Archive, encoding runs of consecutive integers efficiently.
    /// <code>Offset: 0x00671040
    /// void __thiscall CMostlyConsecutiveIntSet::Serialize(CMostlyConsecutiveIntSet*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance used for reading or writing the set data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMostlyConsecutiveIntSet, ACBindings.Internal.Archive*, void>)0x00671040)(ref this, io_archive);

    /// <summary>Adds an integer to the collection and marks the set as unsorted.
    /// <code>Offset: 0x00671280
    /// bool __thiscall CMostlyConsecutiveIntSet::Add(CMostlyConsecutiveIntSet*,int)</code>
    /// </summary>
    /// <param name="NewInt">The integer to add to the set.</param>
    /// <returns>True if the integer was added successfully; otherwise, false (this implementation always succeeds).</returns>
    public byte Add(int NewInt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMostlyConsecutiveIntSet, int, byte>)0x00671280)(ref this, NewInt);
}

