namespace ACBindings.Internal;


/// <summary>Encapsulates animation data for multiple styles, offering default values, motion cycles, modifiers, and cross‑table links while supporting serialization via PackDBObj.</summary>
public unsafe struct CMotionTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct CMotionTable_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.LongNIValHash__uint style_defaults;
    public ACBindings.Internal.LongHash___MotionData cycles;
    public ACBindings.Internal.LongHash___MotionData modifiers;
    public ACBindings.Internal.LongNIValHash___LongHash___MotionData_ptr links;
    public uint default_style;

    // Generated Constructor
    public CMotionTable() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a CMotionTable instance by constructing its base classes and setting up hash tables for style defaults, cycles, modifiers, and links.
    /// <code>Offset: 0x004FA080
    /// void __thiscall CMotionTable::CMotionTable(CMotionTable*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, void>)0x004FA080)(ref this);

    /// <summary>Allocates and constructs a new CMotionTable instance, returning it as a DBObj pointer.
    /// <code>Offset: 0x004FA280
    /// DBObj* __thiscall CMotionTable::Allocator(CMotionTable*)</code>
    /// </summary>
    /// <returns>A pointer to the newly created DBObj representing the CMotionTable, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, ACBindings.Internal.DBObj*>)0x004FA280)(ref this);

    /// <summary>Recalculates the modifier chain of a MotionState by removing existing modifiers and retrieving updated sequences from the CMotionTable using the supplied CSequence. The method clones the original state, iteratively clears modifiers from both the clone and the original, then calls GetObjectSequence to apply new motion data before cleaning up the temporary copy.
    /// <code>Offset: 0x00522E30
    /// void __thiscall CMotionTable::re_modify(CMotionTable*,CSequence*,MotionState*)</code>
    /// </summary>
    /// <param name="this">The CMotionTable instance that supplies modifier information.</param>
    /// <param name="sequence">The CSequence used as a reference for obtaining updated motion sequences.</param>
    /// <param name="state">The MotionState whose modifiers are refreshed based on table data.</param>
    public void re_modify(ACBindings.Internal.CSequence* sequence, ACBindings.Internal.MotionState* state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, ACBindings.Internal.CSequence*, ACBindings.Internal.MotionState*, void>)0x00522E30)(ref this, sequence, state);

    /// <summary>Checks whether the given motion data is permitted for the current motion state based on its bitfield flag and substate relationships.
    /// <code>Offset: 0x00523260
    /// int __thiscall CMotionTable::is_allowed(CMotionTable*,unsigned int,const MotionData*,const MotionState*)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion’s substate to compare with the state's substate.</param>
    /// <param name="mdata">MotionData describing the candidate motion.</param>
    /// <param name="state">Current MotionState against which allowance is evaluated.</param>
    /// <returns>Non‑zero if allowed, zero otherwise (or null mdata yields 0).</returns>
    public int is_allowed(uint motion, ACBindings.Internal.MotionData* mdata, ACBindings.Internal.MotionState* state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, uint, ACBindings.Internal.MotionData*, ACBindings.Internal.MotionState*, int>)0x00523260)(ref this, motion, mdata, state);

    /// <summary>Retrieves a MotionData entry for the specified style, substate, motion, and speed values from the motion table, using linked data or default styles when available.
    /// <code>Offset: 0x005232B0
    /// MotionData* __thiscall CMotionTable::get_link(CMotionTable*,unsigned int,unsigned int,float,unsigned int,float)</code>
    /// </summary>
    /// <param name="style">The style identifier used as part of the lookup key.</param>
    /// <param name="substate">The sub-state identifier within the style.</param>
    /// <param name="substate_speed">Speed associated with the substate; negative values trigger a special lookup path.</param>
    /// <param name="motion">The motion identifier to retrieve.</param>
    /// <param name="speed">Speed associated with the motion; negative values cause fallback to default links.</param>
    /// <returns>Pointer to the matching MotionData, or null if no suitable entry is found.</returns>
    public ACBindings.Internal.MotionData* get_link(uint style, uint substate, float substate_speed, uint motion, float speed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, uint, uint, float, uint, float, ACBindings.Internal.MotionData*>)0x005232B0)(ref this, style, substate, substate_speed, motion, speed);

    /// <summary>Builds and updates an animation sequence for an object based on the requested motion type, handling transitions, modifiers, and cycle changes while updating the object's MotionState.
    /// <code>Offset: 0x00523400
    /// int __thiscall CMotionTable::GetObjectSequence(CMotionTable*,unsigned int,MotionState*,CSequence*,float,unsigned int*,int)</code>
    /// </summary>
    /// <param name="motion">Identifier or flag specifying the desired motion state and transition behavior.</param>
    /// <param name="curr_state">Pointer to the object's current MotionState; will be modified to reflect the new state after execution.</param>
    /// <param name="sequence">CSequence object that receives added or altered animation nodes.</param>
    /// <param name="speed_mod">Speed multiplier applied to animation nodes during sequence construction.</param>
    /// <param name="num_anims">Output parameter receiving the number of animations added to the sequence.</param>
    /// <param name="stop_modifiers">Value used for stopping or modifying motion transitions (also interpreted as a float in some cases).</param>
    /// <returns>1 if the transition and sequence update succeeded; 0 otherwise.</returns>
    public int GetObjectSequence(uint motion, ACBindings.Internal.MotionState* curr_state, ACBindings.Internal.CSequence* sequence, float speed_mod, uint* num_anims, int stop_modifiers) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, uint, ACBindings.Internal.MotionState*, ACBindings.Internal.CSequence*, float, uint*, int, int>)0x00523400)(ref this, motion, curr_state, sequence, speed_mod, num_anims, stop_modifiers);

    /// <summary>Stops a motion substate or modifier from the current state and updates the animation sequence accordingly.
    /// <code>Offset: 0x00523B60
    /// int __thiscall CMotionTable::StopSequenceMotion(CMotionTable*,unsigned int,float,MotionState*,CSequence*,unsigned int*)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to stop; if bit 0x40000000 is set and equals the state's substate, that substate is terminated. If bit 0x20000000 is set, treats it as a modifier ID to be removed from the state.</param>
    /// <param name="speed">Ignored – retained for API compatibility.</param>
    /// <param name="curr_state">Current motion state from which the substate or modifier is removed.</param>
    /// <param name="sequence">Animation sequence that may be modified when a motion stops.</param>
    /// <param name="num_anims">Scratch storage used internally; may be overwritten by lookup functions and is not intended for external use.</param>
    /// <returns>Non‑zero if the specified substate or modifier was found and removed, zero otherwise.</returns>
    public int StopSequenceMotion(uint motion, float speed, ACBindings.Internal.MotionState* curr_state, ACBindings.Internal.CSequence* sequence, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, uint, float, ACBindings.Internal.MotionState*, ACBindings.Internal.CSequence*, uint*, int>)0x00523B60)(ref this, motion, speed, curr_state, sequence, num_anims);

    /// <summary>Sets a MotionState to the table’s default style and applies its motion cycle to a CSequence, returning whether the operation succeeded.
    /// <code>Offset: 0x00523C40
    /// int __thiscall CMotionTable::SetDefaultState(CMotionTable*,MotionState*,CSequence*,unsigned int*)</code>
    /// </summary>
    /// <param name="state">The MotionState object to be initialized with the default style, substate, and modifier values.</param>
    /// <param name="sequence">The CSequence into which the default motion will be added after clearing existing physics and animations.</param>
    /// <param name="num_anims">Output parameter that receives the number of animation frames minus one used for the applied motion cycle.</param>
    /// <returns>1 if the default state was successfully set and the sequence updated; 0 otherwise (e.g., style not found or no matching cycle).</returns>
    public int SetDefaultState(ACBindings.Internal.MotionState* state, ACBindings.Internal.CSequence* sequence, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, ACBindings.Internal.MotionState*, ACBindings.Internal.CSequence*, uint*, int>)0x00523C40)(ref this, state, sequence, num_anims);

    /// <summary>Serializes a CMotionTable into a contiguous block of memory. If the supplied buffer is large enough, data are written to *addr; otherwise only the required size is calculated.
    /// <code>Offset: 0x00523D20
    /// unsigned int __thiscall CMotionTable::Pack(CMotionTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a location where the serialized data will be stored.</param>
    /// <param name="size">Size in bytes of the destination buffer.</param>
    /// <returns>The total number of bytes needed for serialization, which equals the number written when the buffer is sufficient.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, void**, uint, uint>)0x00523D20)(ref this, addr, size);

    /// <summary>Unpacks motion table data from a packed buffer into the CMotionTable's internal hash tables, reconstructing modifiers, styles, cycles, and links.
    /// <code>Offset: 0x00524460
    /// int __thiscall CMotionTable::UnPack(CMotionTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the source buffer; updated as data is consumed.</param>
    /// <param name="size">Number of bytes available in the buffer for unpacking.</param>
    /// <returns>Non‑zero if unpacking succeeded; zero indicates insufficient data or a failure during reconstruction.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, void**, uint, int>)0x00524460)(ref this, addr, size);

    /// <summary>Destroys all motion data associated with this table, clearing cycles, modifiers, style defaults and freeing linked resources.
    /// <code>Offset: 0x00524970
    /// void __thiscall CMotionTable::Destroy(CMotionTable*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, void>)0x00524970)(ref this);

    /// <summary>Retrieves the animation sequence for the specified motion and applies it to the provided <c>CSequence</c> structure.
    /// <code>Offset: 0x00524A90
    /// int __thiscall CMotionTable::DoObjectMotion(CMotionTable*,unsigned int,MotionState*,CSequence*,float,unsigned int*)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to execute.</param>
    /// <param name="curr_state">Current state information used to determine the appropriate sequence.</param>
    /// <param name="sequence">The sequence object that will receive the computed animation data.</param>
    /// <param name="speed_mod">Multiplier applied to the motion speed before calculation.</param>
    /// <param name="num_anims">Receives the number of animations generated for this motion.</param>
    /// <returns>Integer status code returned by <c>GetObjectSequence</c>, indicating success or failure of the operation.</returns>
    public int DoObjectMotion(uint motion, ACBindings.Internal.MotionState* curr_state, ACBindings.Internal.CSequence* sequence, float speed_mod, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, uint, ACBindings.Internal.MotionState*, ACBindings.Internal.CSequence*, float, uint*, int>)0x00524A90)(ref this, motion, curr_state, sequence, speed_mod, num_anims);

    /// <summary>Stops all modifier motions associated with the given state, then attempts to halt its substate motion within the supplied sequence.
    /// <code>Offset: 0x00524AD0
    /// int __thiscall CMotionTable::StopObjectCompletely(CMotionTable*,MotionState*,CSequence*,unsigned int*)</code>
    /// </summary>
    /// <param name="curr_state">The motion state whose motions are to be terminated.</param>
    /// <param name="sequence">Sequence context used while stopping motions.</param>
    /// <param name="num_anims">Pointer to a counter that receives the number of animations stopped during this operation.</param>
    /// <returns>Non‑zero if at least one motion (modifier or substate) was successfully halted; zero otherwise.</returns>
    public int StopObjectCompletely(ACBindings.Internal.MotionState* curr_state, ACBindings.Internal.CSequence* sequence, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, ACBindings.Internal.MotionState*, ACBindings.Internal.CSequence*, uint*, int>)0x00524AD0)(ref this, curr_state, sequence, num_anims);

    /// <summary>Destroys a CMotionTable instance by releasing all internal data structures—style defaults, cycles, modifiers, and links—and then calling the base DBObj destructor to clean up inherited resources.
    /// <code>Offset: 0x00524B50
    /// void __thiscall CMotionTable::~CMotionTable(CMotionTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionTable, void>)0x00524B50)(ref this);
}

