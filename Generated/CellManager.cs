namespace ACBindings.Internal;

public unsafe struct CellManager : System.IDisposable
{
    // Members
    public ACBindings.Internal.LScape* lscape;
    public System.IntPtr ambient_sounds;
    public uint last_prefetch_cell_id;
    public double last_prefetch_check;
    public byte blocking_for_cells;
    public byte all_cells_available;
    public uint num_cells_waiting;
    public uint total_num_cells_waiting;
    public ACBindings.Internal.CObjCell* curr_cell;
    public ACBindings.Internal.Position load_pos;
    public int keep_lscape_loaded;

    // Generated Constructor
    public CellManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00455830
    /// void __thiscall CellManager::UpdateLoadPoint(CellManager*)</code>
    /// </summary>
    public void UpdateLoadPoint() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, void>)0x00455830)(ref this);

    /// <summary>
    /// <code>Offset: 0x004558D0
    /// void __thiscall CellManager::CellManager(CellManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, void>)0x004558D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00455930
    /// void __thiscall CellManager::~CellManager(CellManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, void>)0x00455930)(ref this);

    /// <summary>
    /// <code>Offset: 0x00455940
    /// int __thiscall CellManager::PreFetchCells(int,int,int)</code>
    /// </summary>
    public int PreFetchCells(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, int, int, int>)0x00455940)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00455A50
    /// void __thiscall CellManager::Reset(CellManager*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, void>)0x00455A50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00455AD0
    /// void __thiscall CellManager::ChangePosition(CellManager*,const Position*,int)</code>
    /// </summary>
    public void ChangePosition(ACBindings.Internal.Position* p, int blocking) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, ACBindings.Internal.Position*, int, void>)0x00455AD0)(ref this, p, blocking);

    /// <summary>
    /// <code>Offset: 0x00455D00
    /// int __thiscall CellManager::CheckPrefetchStatus(CellManager*)</code>
    /// </summary>
    public int CheckPrefetchStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, int>)0x00455D00)(ref this);
}

