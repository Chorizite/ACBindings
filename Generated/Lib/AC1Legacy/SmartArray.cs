namespace ACBindings.Internal.AC1Legacy;


/// <summary>Provides a resizable array of CharacterIdentity entries, handling allocation, deallocation, and size tracking to support efficient storage and retrieval in AC1Legacy systems.</summary>
public unsafe struct SmartArray___CharacterIdentity
{
    // Members
    public ACBindings.Internal.CharacterIdentity* m_data;
    public uint m_size;
    public uint m_num;

    // Methods

    /// <summary>Clears the smart array, resetting its size and element count to zero and freeing any allocated memory for CharacterIdentity elements.
    /// <code>Offset: 0x004FE8D0
    /// void __thiscall AC1Legacy::SmartArray&lt;CharacterIdentity&gt;::Reset(_DWORD*)</code>
    /// </summary>
    // void __thiscall AC1Legacy::SmartArray<CharacterIdentity>::Reset(_DWORD*) (template type method)

    /// <summary>Expands the smart array to hold at least <paramref name="n"/> CharacterIdentity objects, reallocating memory and copying existing elements if necessary.
    /// <code>Offset: 0x004FEA60
    /// int __thiscall AC1Legacy::SmartArray&lt;CharacterIdentity&gt;::grow(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="n">The desired capacity of the array in number of CharacterIdentity entries.</param>
    /// <returns>1 when the array is successfully resized (or reset when n == 0); 0 if allocation fails or an invalid request is made.</returns>
    // int __thiscall AC1Legacy::SmartArray<CharacterIdentity>::grow(_DWORD*,unsigned int) (template type method)
}


/// <summary>Container that stores an array of animation hook pointers, tracking current usage and capacity.</summary>
public unsafe struct SmartArray___CAnimHook_ptr
{
    // Members
    public ACBindings.Internal.CAnimHook** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Encapsulates a dynamically resizable collection of unsigned long values, handling allocation, size tracking, and element count.</summary>
public unsafe struct SmartArray__uint
{
    // Members
    public uint* m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Holds a dynamically resizable array of PStringBase&lt;char&gt; objects, managing memory and providing size tracking for string collections.</summary>
public unsafe struct SmartArray___AC1Legacy_PStringBase__sbyte
{
    // Members
    public System.IntPtr m_data;
    public uint m_size;
    public uint m_num;

    // Methods

    /// <summary>Resizes the array to accommodate at least `n` elements. If `n` is less than the current element count, the operation fails; otherwise, it reallocates and copies existing items or frees the buffer when zero.
    /// <code>Offset: 0x005B82E0
    /// int __thiscall AC1Legacy::SmartArray&lt;AC1Legacy::PStringBase&lt;char&gt;&gt;::grow(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="n">The desired number of elements that the array should be able to hold.</param>
    /// <returns>1 if resizing succeeds (or the requested capacity already exists); 0 on failure such as a too‑small request or memory allocation error.</returns>
    // int __thiscall AC1Legacy::SmartArray<AC1Legacy::PStringBase<char>>::grow(_DWORD*,unsigned int) (template type method)
}


/// <summary>Dynamic collection of GfxVelocityDesc pointers, tracking allocated capacity (m_size) and used entries (m_num).</summary>
/// <remarks>Employed within AC1Legacy to store and manipulate velocity descriptors for graphical computations.</remarks>
public unsafe struct SmartArray___GfxVelocityDesc_ptr
{
    // Members
    public ACBindings.Internal.GfxVelocityDesc** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Stores an expandable list of pointers to CPhysicsObj objects, maintaining both the total allocated space (m_size) and the number of elements currently in use (m_num).</summary>
public unsafe struct SmartArray___CPhysicsObj_ptr
{
    // Members
    public ACBindings.Internal.CPhysicsObj** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Stores a dynamically resizable collection of ScriptAndModData objects, managing allocation and deallocation of the underlying array.</summary>
public unsafe struct SmartArray___ScriptAndModData
{
    // Members
    public ACBindings.Internal.ScriptAndModData* m_data;
    public uint m_size;
    public uint m_num;

    // Methods

    /// <summary>Resets the SmartArray by freeing any allocated ScriptAndModData objects and setting its size and element count to zero.
    /// <code>Offset: 0x005225D0
    /// void __thiscall AC1Legacy::SmartArray&lt;ScriptAndModData&gt;::Reset(int*)</code>
    /// </summary>
    // void __thiscall AC1Legacy::SmartArray<ScriptAndModData>::Reset(int*) (template type method)

    /// <summary>Expands the SmartArray to hold at least *n* ScriptAndModData objects, reallocating internal storage when necessary. If called with zero it resets the array.
    /// <code>Offset: 0x005226D0
    /// int __thiscall AC1Legacy::SmartArray&lt;ScriptAndModData&gt;::grow(int*,unsigned int)</code>
    /// </summary>
    /// <param name="n">The desired number of elements for the array after growth.</param>
    /// <returns>Non‑zero (1) if the array was successfully resized or already large enough; zero if memory allocation failed or the requested size is invalid.</returns>
    // int __thiscall AC1Legacy::SmartArray<ScriptAndModData>::grow(int*,unsigned int) (template type method)
}


/// <summary>Holds a dynamically allocated collection of CelestialPosition objects, tracking capacity and element count to support growth operations during runtime.</summary>
public unsafe struct SmartArray___CelestialPosition
{
    // Members
    public ACBindings.Internal.CelestialPosition* m_data;
    public uint m_size;
    public uint m_num;

    // Methods

    /// <summary>Ensures the SmartArray holds at least n CelestialPosition entries by reallocating if necessary; resets the array when n is zero.
    /// <code>Offset: 0x00502040
    /// int __thiscall AC1Legacy::SmartArray&lt;CelestialPosition&gt;::grow(int*,unsigned int)</code>
    /// </summary>
    /// <param name="n">The minimum capacity required for the array.</param>
    /// <returns>1 when no reallocation is needed, the allocation succeeds, or the array is reset; 0 on failure (allocation failure or requested size smaller than the current element count).</returns>
    // int __thiscall AC1Legacy::SmartArray<CelestialPosition>::grow(int*,unsigned int) (template type method)
}


/// <summary>Tracks a collection of AmbientSoundDesc pointers, maintaining storage capacity and current element count for efficient sound descriptor handling.</summary>
/// <remarks>Used within the AC1Legacy system to manage ambient sounds in a contiguous array structure.</remarks>
public unsafe struct SmartArray___AmbientSoundDesc_ptr
{
    // Members
    public ACBindings.Internal.AmbientSoundDesc** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Holds an expandable array of TimeOfDay pointers, tracking capacity and current element count.</summary>
public unsafe struct SmartArray___TimeOfDay_ptr
{
    // Members
    public ACBindings.Internal.TimeOfDay** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Represents a dynamic array that stores pointers to WeekDay objects, tracking both allocated capacity and current element count. Used within AC1Legacy to manage weekday collections efficiently.</summary>
public unsafe struct SmartArray___WeekDay_ptr
{
    // Members
    public ACBindings.Internal.WeekDay** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Stores a dynamic array of pointers to Season objects, tracking capacity and current count for efficient management.</summary>
public unsafe struct SmartArray___Season_ptr
{
    // Members
    public ACBindings.Internal.Season** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Provides a dynamic array of PalShiftSubPal pointers, tracking allocated capacity and current element count.</summary>
public unsafe struct SmartArray___PalShiftSubPal_ptr
{
    // Members
    public ACBindings.Internal.PalShiftSubPal** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Stores an array of PalShiftRoadCode pointers, tracking capacity and element count information for managing road shift data efficiently.</summary>
/// <remarks>Encapsulates dynamic storage used by AC1Legacy components that require quick access and manipulation of PalShiftRoadCode objects.</remarks>
public unsafe struct SmartArray___PalShiftRoadCode_ptr
{
    // Members
    public ACBindings.Internal.PalShiftRoadCode** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Holds a dynamically allocated array of PalShiftTerrainPal pointers, along with metadata tracking capacity and current element count.</summary>
public unsafe struct SmartArray___PalShiftTerrainPal_ptr
{
    // Members
    public ACBindings.Internal.PalShiftTerrainPal** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Stores an expandable collection of PalShiftTex objects, maintaining the underlying pointer array along with its allocated size and used count.</summary>
public unsafe struct SmartArray___PalShiftTex_ptr
{
    // Members
    public ACBindings.Internal.PalShiftTex** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Stores a resizable array of TerrainAlphaMap pointers, tracking both capacity and current element count for legacy AC1 terrain management.</summary>
public unsafe struct SmartArray___TerrainAlphaMap_ptr
{
    // Members
    public ACBindings.Internal.TerrainAlphaMap** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Dynamic array that holds pointers to RoadAlphaMap instances, maintaining the allocated capacity and current element count.</summary>
public unsafe struct SmartArray___RoadAlphaMap_ptr
{
    // Members
    public ACBindings.Internal.RoadAlphaMap** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Manages a dynamic array of TerrainTex pointer objects, tracking the allocated storage size and current number of elements stored.</summary>
public unsafe struct SmartArray___TerrainTex_ptr
{
    // Members
    public ACBindings.Internal.TerrainTex** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Holds a dynamic array of TMTerrainDesc pointers, managing allocated capacity and current element count for terrain data.</summary>
public unsafe struct SmartArray___TMTerrainDesc_ptr
{
    // Members
    public ACBindings.Internal.TMTerrainDesc** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>
/// Holds a dynamic array of CSurface pointers, tracking the raw storage pointer, allocated capacity, and number of active elements for efficient surface management.
/// </summary>
public unsafe struct SmartArray___CSurface_ptr
{
    // Members
    public ACBindings.Internal.CSurface** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>
/// Represents a dynamically allocated array of CSceneType pointers, storing scene objects and tracking both the total allocation size and current element count.
/// </summary>
public unsafe struct SmartArray___CSceneType_ptr
{
    // Members
    public ACBindings.Internal.CSceneType** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Manages a dynamic list of CTerrainType pointers, storing the underlying array, allocated capacity, and current element count.</summary>
public unsafe struct SmartArray___CTerrainType_ptr
{
    // Members
    public ACBindings.Internal.CTerrainType** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Maintains a resizable array of pointers to SkyObjectReplace objects, handling dynamic allocation and size tracking within the AC1Legacy system.</summary>
public unsafe struct SmartArray___SkyObjectReplace_ptr
{
    // Members
    public ACBindings.Internal.SkyObjectReplace** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Stores pointers to SkyTimeOfDay objects in a dynamic array, tracking the allocated size and number of elements currently stored.</summary>
public unsafe struct SmartArray___SkyTimeOfDay_ptr
{
    // Members
    public ACBindings.Internal.SkyTimeOfDay** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Stores a contiguous array of SkyObject pointers, maintaining allocated capacity (m_size) and current element count (m_num). Supports basic collection operations within the legacy engine.</summary>
public unsafe struct SmartArray___SkyObject_ptr
{
    // Members
    public ACBindings.Internal.SkyObject** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Maintains a dynamically resizable array of DayGroup pointers, tracking the number of elements stored and the allocated capacity.</summary>
public unsafe struct SmartArray___DayGroup_ptr
{
    // Members
    public ACBindings.Internal.DayGroup** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Handles a resizable collection of AmbientSTBDesc pointers, maintaining the total capacity and current element count.</summary>
public unsafe struct SmartArray___AmbientSTBDesc_ptr
{
    // Members
    public ACBindings.Internal.AmbientSTBDesc** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Dynamic array holding pointers to TChessPiece&lt;CBasePiece&gt; instances, tracking the underlying buffer, capacity and active count.</summary>
public unsafe struct SmartArray___TChessPiece___CBasePiece_ptr
{
    // Members
    public System.IntPtr m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}


/// <summary>Represents a dynamic array of cWObjHierNode pointers, tracking allocated size and element count.</summary>
public unsafe struct SmartArray___cWObjHierNode_ptr
{
    // Members
    public ACBindings.Internal.cWObjHierNode** m_data;
    public uint m_size;
    public uint m_num;

    // Methods
}

