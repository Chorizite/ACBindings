namespace ACBindings;

// CellManager
public unsafe struct CellManager : System.IDisposable
{
    // Members
    public ACBindings.LScape* lscape;
    public System.IntPtr ambient_sounds;
    public uint last_prefetch_cell_id;
    public double last_prefetch_check;
    public byte blocking_for_cells;
    public byte all_cells_available;
    public uint num_cells_waiting;
    public uint total_num_cells_waiting;
    public ACBindings.CObjCell* curr_cell;
    public ACBindings.Position load_pos;
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
    // void __thiscall CellManager::UpdateLoadPoint(CellManager*)
    public void UpdateLoadPoint() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CellManager, void>)0x00455830)(ref this);
    // void __thiscall CellManager::CellManager(CellManager*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CellManager, void>)0x004558D0)(ref this);
    // void __thiscall CellManager::~CellManager(CellManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CellManager, void>)0x00455930)(ref this);
    // int __thiscall CellManager::PreFetchCells(int,int,int)
    public int PreFetchCells(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CellManager, int, int, int>)0x00455940)(ref this, a2, a3);
    // void __thiscall CellManager::Reset(CellManager*)
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CellManager, void>)0x00455A50)(ref this);
    // void __thiscall CellManager::ChangePosition(CellManager*,const Position*,int)
    public void ChangePosition(ACBindings.Position* p, int blocking) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CellManager, ACBindings.Position*, int, void>)0x00455AD0)(ref this, p, blocking);
    // int __thiscall CellManager::CheckPrefetchStatus(CellManager*)
    public int CheckPrefetchStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CellManager, int>)0x00455D00)(ref this);
}

