namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0050B3F0
    /// void __thiscall CELLARRAY::CELLARRAY(CELLARRAY*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CELLARRAY, void>)0x0050B3F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B5DC0
    /// void __thiscall CELLARRAY::remove_cell(CELLARRAY*,const unsigned int)</code>
    /// </summary>
    public void remove_cell(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CELLARRAY, uint, void>)0x006B5DC0)(ref this, index);

    /// <summary>
    /// <code>Offset: 0x006B5F30
    /// void __thiscall CELLARRAY::add_cell(CELLARRAY*,const unsigned int,const CObjCell*)</code>
    /// </summary>
    public void add_cell(uint cell_id, ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CELLARRAY, uint, ACBindings.Internal.CObjCell*, void>)0x006B5F30)(ref this, cell_id, cell);
}

