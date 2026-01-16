namespace ACBindings.Internal;


/// <summary>Coordinates cell loading, caching, and ambient sound management for the player's current position within the game's environment system, handling prefetched data and load‑point updates as needed.</summary>
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

    /// <summary>Adjusts the LScape load point to match the current cell ID stored in the manager’s load position, performing a validity check on the ID before delegating to LScape::update_loadpoint.
    /// <code>Offset: 0x00455830
    /// void __thiscall CellManager::UpdateLoadPoint(CellManager*)</code>
    /// </summary>
    public void UpdateLoadPoint() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, void>)0x00455830)(ref this);

    /// <summary>Initializes a CellManager instance with default settings, resetting all cell tracking fields and establishing an identity load position frame.
    /// <code>Offset: 0x004558D0
    /// void __thiscall CellManager::CellManager(CellManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, void>)0x004558D0)(ref this);

    /// <summary>Restores the virtual function table of the manager's load position object to its base PackObj representation during CellManager destruction.
    /// <code>Offset: 0x00455930
    /// void __thiscall CellManager::~CellManager(CellManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, void>)0x00455930)(ref this);

    /// <summary>Initiates pre‑fetching of environment cells for a specified cell ID, optionally asynchronously, and updates internal status flags. Returns whether the requested cells are ready.
    /// <code>Offset: 0x00455940
    /// int __thiscall CellManager::PreFetchCells(int,int,int)</code>
    /// </summary>
    /// <param name="a2">The identifier (index) of the cell to pre‑fetch.</param>
    /// <param name="a3">Non‑zero indicates asynchronous fetching; zero triggers an immediate readiness check.</param>
    /// <returns>1 if the cells are available and ready, otherwise 0.</returns>
    public int PreFetchCells(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, int, int, int>)0x00455940)(ref this, a2, a3);

    /// <summary>Resets the CellManager by clearing its current cell references, releasing loaded cells and ambient sound tables, and resetting availability flags to default values.
    /// <code>Offset: 0x00455A50
    /// void __thiscall CellManager::Reset(CellManager*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, void>)0x00455A50)(ref this);

    /// <summary>Updates the cell manager’s current cell to match a new position, prefetching or blocking cell loading as requested and refreshing rendering lighting and ambient sounds accordingly.
    /// <code>Offset: 0x00455AD0
    /// void __thiscall CellManager::ChangePosition(CellManager*,const Position*,int)</code>
    /// </summary>
    /// <param name="p">The target position containing the desired object cell ID.</param>
    /// <param name="blocking">If non‑zero, block while fetching cells; otherwise allow asynchronous loading.</param>
    public void ChangePosition(ACBindings.Internal.Position* p, int blocking) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, ACBindings.Internal.Position*, int, void>)0x00455AD0)(ref this, p, blocking);

    /// <summary>Determines whether cell pre‑fetching should occur based on elapsed time and initiates the process if needed. Returns non‑zero when cells have been prefetched, or zero otherwise.
    /// <code>Offset: 0x00455D00
    /// int __thiscall CellManager::CheckPrefetchStatus(CellManager*)</code>
    /// </summary>
    /// <returns>Non‑zero if prefetching succeeded; zero if no action was taken or no cells were prefetched.</returns>
    public int CheckPrefetchStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CellManager, int>)0x00455D00)(ref this);
}

