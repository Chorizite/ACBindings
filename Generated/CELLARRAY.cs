namespace ACBindings;

// CELLARRAY
public unsafe struct CELLARRAY
{
    // Members
    public int added_outside;
    public int do_not_load_cells;
    public uint num_cells;
    public ACBindings.DArray__CELLINFO cells;

    // Generated Constructor
    public CELLARRAY() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CELLARRAY::CELLARRAY(CELLARRAY*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CELLARRAY, void>)0x0050B3F0)(ref this);
    // void __thiscall CELLARRAY::remove_cell(CELLARRAY*,const unsigned int)
    public void remove_cell(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CELLARRAY, uint, void>)0x006B5DC0)(ref this, index);
    // void __thiscall CELLARRAY::add_cell(CELLARRAY*,const unsigned int,const CObjCell*)
    public void add_cell(uint cell_id, ACBindings.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CELLARRAY, uint, ACBindings.CObjCell*, void>)0x006B5F30)(ref this, cell_id, cell);
}

