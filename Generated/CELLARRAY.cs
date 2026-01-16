namespace ACBindings.Internal;


/// <summary>Contains information about a set of cells, including flags for external addition and loading behavior, as well as the total count and detailed cell data.</summary>
public unsafe struct CELLARRAY
{
    // Members
    public int added_outside;
    public int do_not_load_cells;
    public uint num_cells;
    public ACBindings.Internal.DArray___CELLINFO cells;

    // Generated Constructor
    public CELLARRAY() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new CELLARRAY instance, setting all counters to zero and allocating an empty dynamic array of CELLINFO objects with an initial capacity of eight.
    /// <code>Offset: 0x0050B3F0
    /// void __thiscall CELLARRAY::CELLARRAY(CELLARRAY*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CELLARRAY, void>)0x0050B3F0)(ref this);

    /// <summary>Removes a cell from the array by replacing it with the last element and decrementing the count.
    /// <code>Offset: 0x006B5DC0
    /// void __thiscall CELLARRAY::remove_cell(CELLARRAY*,const unsigned int)</code>
    /// </summary>
    /// <param name="index">Zero‑based index of the cell to delete.</param>
    public void remove_cell(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CELLARRAY, uint, void>)0x006B5DC0)(ref this, index);

    /// <summary>Adds a new cell to the internal collection, expanding the underlying array if required. If a cell with the same identifier already exists, the addition is skipped.
    /// <code>Offset: 0x006B5F30
    /// void __thiscall CELLARRAY::add_cell(CELLARRAY*,const unsigned int,const CObjCell*)</code>
    /// </summary>
    /// <param name="cell_id">The unique identifier for the cell being added.</param>
    /// <param name="cell">Pointer to the CObjCell instance containing cell data and metadata.</param>
    public void add_cell(uint cell_id, ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CELLARRAY, uint, ACBindings.Internal.CObjCell*, void>)0x006B5F30)(ref this, cell_id, cell);
}

