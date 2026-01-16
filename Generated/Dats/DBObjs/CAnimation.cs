namespace ACBindings.Internal;


/// <summary>Represents an animation sequence comprising position frames, part-specific frames, hook information, and frame count metadata used by the rendering system.</summary>
public unsafe struct CAnimation : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct CAnimation_vtbl
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
    public ACBindings.Internal.AFrame* pos_frames;
    public ACBindings.Internal.AnimFrame* part_frames;
    public int has_hooks;
    public uint num_parts;
    public uint num_frames;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Allocates a new DBObj instance for CAnimation, initializing base class data and setting appropriate vtable pointers.
    /// <code>Offset: 0x004F7B30
    /// DBObj* __cdecl CAnimation::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed DBObj object, or nullptr if memory allocation failed.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7B30)();

    /// <summary>Collects all sub‑data identifiers referenced by animation hooks across every frame and stores them in the supplied array.
    /// <code>Offset: 0x00520200
    /// void __thiscall CAnimation::GetSubDataIDs(CAnimation*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">A container that receives each unique QualifiedDataID discovered while traversing the animation's frames and part hooks.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAnimation, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00520200)(ref this, id_array);

    /// <summary>Computes the total byte size required to serialize the animation data, including base header, frame information, and all hook structures.
    /// <code>Offset: 0x00520250
    /// unsigned int __thiscall CAnimation::pack_size(CAnimation*)</code>
    /// </summary>
    /// <returns>The packed size in bytes as an unsigned integer.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAnimation, uint>)0x00520250)(ref this);

    /// <summary>Packs the animation data into a binary format at the provided buffer location if enough space remains; serializes base DBObj information followed by all frame and part frames, advancing the address pointer as it writes.
    /// <code>Offset: 0x00520590
    /// unsigned int __thiscall CAnimation::Pack(CAnimation*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the buffer; updated to point after the serialized data.</param>
    /// <param name="size">Remaining size of the buffer; must be at least the required pack size for successful serialization.</param>
    /// <returns>Number of bytes needed to serialize this animation object (in bytes).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAnimation, void**, uint, uint>)0x00520590)(ref this, addr, size);

    /// <summary>Unpacks animation data from a serialized buffer into this CAnimation instance.
    /// <code>Offset: 0x00520660
    /// int __thiscall CAnimation::UnPack(CAnimation*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position; advanced as the buffer is consumed.</param>
    /// <param name="size">Size of the remaining data in the buffer.</param>
    /// <returns>Always 1 indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAnimation, void**, uint, int>)0x00520660)(ref this, addr, size);

    /// <summary>Destroys an animation by releasing its position and part frame resources and resetting internal counters.
    /// <code>Offset: 0x00520780
    /// void __thiscall CAnimation::Destroy(CAnimation*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAnimation, void>)0x00520780)(ref this);

    /// <summary>Destroys a CAnimation instance, freeing allocated position and part frame arrays and resetting member counters to zero.
    /// <code>Offset: 0x005207C0
    /// void __thiscall CAnimation::~CAnimation(CAnimation*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAnimation, void>)0x005207C0)(ref this);
}

