namespace ACBindings.Internal;


/// <summary>Stores a dynamic array of unsigned int values with size tracking and deallocation control, aligned on 4‑byte boundaries.</summary>
/// <remarks>Uses an internal pointer to the data, a counter for elements, and a flag indicating whether memory should be freed automatically.</remarks>
public unsafe struct SmartArray__uint
{
    // Members
    public uint* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds an owned array of character pointers, maintaining the data buffer, its allocation status, and element count.</summary>
public unsafe struct SmartArray__sbyte_ptr
{
    // Members
    public sbyte** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages a one-dimensional array of 32‑bit integers, tracking allocated storage and element count.</summary>
/// <remarks>m_data points to the contiguous integer buffer; m_sizeAndDeallocate encodes allocation size with a deallocation flag; m_num indicates how many elements are currently stored.</remarks>
public unsafe struct SmartArray__int
{
    // Members
    public int* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages a contiguous collection of ArchiveVersionRow::VersionEntry objects, tracking element count and ownership semantics for automatic memory release.</summary>
public unsafe struct SmartArray___ArchiveVersionRow_VersionEntry
{
    // Members
    public ACBindings.Internal.ArchiveVersionRow.VersionEntry* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Maintains a compact array of Logger::ILoggingOutputHandler pointers, tracking size and deallocation status for efficient logging handler management.</summary>
public unsafe struct SmartArray___Logger_ILoggingOutputHandler_ptr
{
    // Members
    public ACBindings.Internal.Logger.ILoggingOutputHandler** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Lightweight container for a fixed-size array of immutable command line arguments, managing pointer storage and optional deallocation responsibility.</summary>
public unsafe struct SmartArray___CommandLineArg_ptr
{
    // Members
    public ACBindings.Internal.CommandLineArg** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Handles dynamic storage of an array of wide-character strings, tracks allocation size and element count, and ensures proper deallocation when no longer needed.</summary>
public unsafe struct SmartArray__ushort_ptr
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores a single <c>PStringBase&lt;unsigned short&gt;</c> instance with automatic memory management, tracking the data pointer, allocation flags, and element count within a 4‑byte aligned structure.</summary>
public unsafe struct SmartArray___PStringBase__ushort
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds a dynamically sized collection of CommandLineArg objects, tracking the number of elements and whether it owns the underlying storage for deallocation.</summary>
public unsafe struct SmartArray___CommandLineArg
{
    // Members
    public ACBindings.Internal.CommandLineArg* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores a dynamic collection of BTEntry objects, tracking the number of elements and deallocation state for efficient memory management.</summary>
public unsafe struct SmartArray___BTEntry
{
    // Members
    public ACBindings.Internal.BTEntry* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages an array of PFileNode pointers, tracks element count, and controls deallocation behavior for its owned resources.</summary>
public unsafe struct SmartArray___PFileNode_ptr
{
    // Members
    public ACBindings.Internal.PFileNode** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds a reference to dynamically allocated storage for a PStringBase&lt;char&gt; instance, along with metadata indicating allocation state and element count. Supports efficient management of a single string object within aligned memory.</summary>
public unsafe struct SmartArray___PStringBase__sbyte
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds a dynamically allocated array of CAsyncGetRequest pointers, tracks the number of stored requests and whether the memory should be freed automatically. Used internally by asynchronous request handling mechanisms.</summary>
public unsafe struct SmartArray___CAsyncGetRequest_ptr
{
    // Members
    public ACBindings.Internal.CAsyncGetRequest** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Provides dynamic storage for CCallbackWrapper objects used in async cache requests, maintaining a data pointer, element count, and deallocation status.</summary>
public unsafe struct SmartArray___AsyncCache_CAsyncRequest_CCallbackWrapper
{
    // Members
    public ACBindings.Internal.AsyncCache.CAsyncRequest.CCallbackWrapper* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds an array of AsyncCache::CAsyncRequest pointers with capacity defined by the template parameter, tracking current usage and deallocation responsibility. Provides lightweight storage for asynchronous cache request objects within a fixed-size container.</summary>
public unsafe struct SmartArray___AsyncCache_CAsyncRequest_ptr
{
    // Members
    public ACBindings.Internal.AsyncCache.CAsyncRequest** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Provides storage for a single BaseProperty instance, tracking allocation status and the number of elements stored.</summary>
public unsafe struct SmartArray___BaseProperty
{
    // Members
    public ACBindings.Internal.BaseProperty* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Handles a resizable collection of 64‑bit integer values, maintaining element count and ownership semantics for memory management.</summary>
public unsafe struct SmartArray__long
{
    // Members
    public long* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds a contiguous array of DeviceKeyMapEntry objects, tracking the buffer pointer, element count, and allocation state.</summary>
public unsafe struct SmartArray___DeviceKeyMapEntry
{
    // Members
    public ACBindings.Internal.DeviceKeyMapEntry* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Container that holds a single ActionState::SingleKeyInfo instance, managing its allocation, deallocation, and size metadata.</summary>
public unsafe struct SmartArray___ActionState_SingleKeyInfo
{
    // Members
    public ACBindings.Internal.ActionState.SingleKeyInfo* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores a single‑element array of QualifiedControl and unsigned long pairs, tracking allocation status and element count.</summary>
public unsafe struct SmartArray____STL_pair___QualifiedControl__uint
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds a pointer to a contiguous sequence of Glyph objects along with compact metadata indicating the array’s length and automatic deallocation policy.</summary>
public unsafe struct SmartArray___Glyph
{
    // Members
    public ACBindings.Internal.Glyph* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages a single-element array of const GRPVariableObject pointers, handling storage and ownership semantics for variable objects within the system.</summary>
public unsafe struct SmartArray___GRPVariableObject_ptr
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Encapsulates an array of string pairs, providing automatic memory management and size tracking within a compact structure.</summary>
public unsafe struct SmartArray____STL_pair___PStringBase__sbyte___PStringBase__sbyte
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages an array of PrefDisplayModeType instances, handling allocation and deallocation based on internal flags. Provides storage, size tracking, and element count for use in preference display logic.</summary>
public unsafe struct SmartArray___PrefDisplayModeType
{
    // Members
    public ACBindings.Internal.PrefDisplayModeType* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Dynamic byte array that stores raw data and tracks its size, incorporating smart memory management through a deallocation flag.</summary>
public unsafe struct SmartArray__byte
{
    // Members
    public byte* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds a dynamically allocated array of DBLevelInfo objects, tracking the number of elements and memory ownership.</summary>
public unsafe struct SmartArray___DBLevelInfo
{
    // Members
    public ACBindings.Internal.DBLevelInfo* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Lightweight container for MaterialProperty pointers, maintaining allocation state and element count.</summary>
public unsafe struct SmartArray___MaterialProperty_ptr
{
    // Members
    public ACBindings.Internal.MaterialProperty** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>A lightweight container for a single-dimensional array of MaterialField pointers, handling allocation state and element count.</summary>
/// <remarks>Encapsulates dynamic array storage with metadata for size and deallocation control. The m_data member points to the underlying buffer, while m_num records current element count, and m_sizeAndDeallocate flags allocation status.</remarks>
public unsafe struct SmartArray___MaterialField_ptr
{
    // Members
    public ACBindings.Internal.MaterialField** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Represents a lightweight container that holds up to one ModifierRef pointer, storing size and deallocation flags for efficient memory handling of single‑modifier scenarios.</summary>
public unsafe struct SmartArray___ModifierRef_ptr
{
    // Members
    public ACBindings.Internal.ModifierRef** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores an array of MaterialModifier pointers, managing their ownership and automatic memory deallocation while tracking the number of elements.</summary>
public unsafe struct SmartArray___MaterialModifier_ptr
{
    // Members
    public ACBindings.Internal.MaterialModifier** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages an array of MaterialLayer pointers with automatic memory handling and size tracking, facilitating efficient layer storage within the material system.</summary>
public unsafe struct SmartArray___MaterialLayer_ptr
{
    // Members
    public ACBindings.Internal.MaterialLayer** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>
/// Stores a collection of MaterialShaderConstant elements and tracks allocation state, enabling efficient memory handling for shader constant data.
/// </summary>
public unsafe struct SmartArray___MaterialShaderConstant
{
    // Members
    public ACBindings.Internal.MaterialShaderConstant* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores a single ShaderResourceType element with size and deallocation flags for efficient GPU resource management.</summary>
public unsafe struct SmartArray___ShaderResourceType
{
    // Members
    public ACBindings.Internal.ShaderResourceType* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages a collection of LayerStage pointers, storing the underlying data array, size and deallocation flag, and element count.</summary>
public unsafe struct SmartArray___LayerStage_ptr
{
    // Members
    public ACBindings.Internal.LayerStage** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Fixed-size array storing LayerModifier pointers, tracking element count and deallocation behavior.</summary>
public unsafe struct SmartArray___LayerModifier_ptr
{
    // Members
    public ACBindings.Internal.LayerModifier** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Maintains a fixed-size array of RenderMeshBatch pointers, tracking count and deallocation status for efficient rendering batch management.</summary>
public unsafe struct SmartArray___RenderMeshBatch_ptr
{
    // Members
    public ACBindings.Internal.RenderMeshBatch** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores a dynamic array of RenderMeshFragmentTopology::TopBatchType objects used by mesh topology processing. Tracks the underlying data pointer, total allocated size encoded in m_sizeAndDeallocate together with a deallocation flag, and the current number of elements.</summary>
public unsafe struct SmartArray___RenderMeshFragmentTopology_TopBatchType
{
    // Members
    public ACBindings.Internal.RenderMeshFragmentTopology.TopBatchType* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds a dynamic array of 16‑bit unsigned integers, storing element data, size information, and an allocation flag for memory management.</summary>
public unsafe struct SmartArray__ushort
{
    // Members
    public ushort* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>
/// Holds a contiguous array of Vector3 objects, managing size and deallocation flags.
/// </summary>
public unsafe struct SmartArray___Vector3
{
    // Members
    public ACBindings.Internal.Vector3* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages a contiguous collection of Box2D elements, tracking allocation state and element count for efficient resource handling.</summary>
public unsafe struct SmartArray___Box2D
{
    // Members
    public ACBindings.Internal.Box2D* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Encapsulates a single element of type IDClass&lt;_tagDataID,32,0&gt;, providing automatic memory management and size tracking for efficient array operations.</summary>
public unsafe struct SmartArray___IDClass____tagDataID
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores a dynamically sized collection of UIElement pointers, tracking the element count and whether the underlying array should be automatically freed upon destruction.</summary>
public unsafe struct SmartArray___UIElement_ptr
{
    // Members
    public ACBindings.Internal.UIElement** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages a dynamically allocated array of MediaDesc pointers, tracking element count and deallocation status.</summary>
public unsafe struct SmartArray___MediaDesc_ptr
{
    // Members
    public ACBindings.Internal.MediaDesc** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores a dynamic array of BaseInfo objects, managing the data pointer, element count, and deallocation flag in a compact layout.</summary>
public unsafe struct SmartArray___BaseInfo
{
    // Members
    public ACBindings.Internal.BaseInfo* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores a dynamic collection of SurfaceUsageSummary entries, managing memory allocation and tracking the number of elements.</summary>
public unsafe struct SmartArray___SurfaceUsageSummary
{
    // Members
    public ACBindings.Internal.SurfaceUsageSummary* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages a dynamically allocated array of GlyphLine objects, tracking element count and ownership for efficient glyph rendering.</summary>
public unsafe struct SmartArray___GlyphLine
{
    // Members
    public ACBindings.Internal.GlyphLine* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds an aligned single-element array of UIChildFramework pointers, tracking allocation state and current element count.</summary>
public unsafe struct SmartArray___UIChildFramework_ptr
{
    // Members
    public ACBindings.Internal.UIChildFramework** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds a dynamically sized collection of StringDownload pointers, tracking element count and deallocation behavior.</summary>
public unsafe struct SmartArray___StringDownload_ptr
{
    // Members
    public ACBindings.Internal.StringDownload** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Array container for Skill_CG objects, automatically managing memory allocation and deallocation while tracking element count.</summary>
public unsafe struct SmartArray___Skill_CG
{
    // Members
    public ACBindings.Internal.Skill_CG* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Dynamic container for Template_CG instances, holding a data pointer, element count, and allocation metadata.</summary>
public unsafe struct SmartArray___Template_CG
{
    // Members
    public ACBindings.Internal.Template_CG* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds a dynamic collection of HairStyle_CG objects, tracking memory ownership and current element count. The array data is referenced by a pointer, while the size and deallocate status are encoded within a single unsigned integer field.</summary>
public unsafe struct SmartArray___HairStyle_CG
{
    // Members
    public ACBindings.Internal.HairStyle_CG* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages a dynamic collection of EyesStrip_CG instances, storing the array pointer, element count, and deallocation status.</summary>
public unsafe struct SmartArray___EyesStrip_CG
{
    // Members
    public ACBindings.Internal.EyesStrip_CG* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>
/// Holds a dynamic collection of FaceStrip_CG objects, providing size and deallocation metadata to manage memory safely.
/// Tracks element count via m_num while exposing the raw array pointer m_data for direct access in rendering processes.
/// </summary>
public unsafe struct SmartArray___FaceStrip_CG
{
    // Members
    public ACBindings.Internal.FaceStrip_CG* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores a dynamically sized array of Style_CG objects and manages its memory allocation and deallocation automatically using the size and flag stored in m_sizeAndDeallocate.</summary>
public unsafe struct SmartArray___Style_CG
{
    // Members
    public ACBindings.Internal.Style_CG* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Represents a lightweight container holding up to one pair consisting of an unsigned long key and a nested pair of QualifiedControl and size, used for quick access and storage within the application. Manages raw data pointer, allocation flags, and element count.</summary>
public unsafe struct SmartArray____STL_pair__uint____STL_pair___QualifiedControl__uint
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores and manages a dynamic array of PTaggedIterationList elements, tracking allocation size and element count.</summary>
public unsafe struct SmartArray___CAllIterationList_PTaggedIterationList
{
    // Members
    public ACBindings.Internal.CAllIterationList.PTaggedIterationList* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores a dynamically allocated array of MissingIteration objects, tracks the number of elements, and indicates whether the memory should be freed upon destruction.</summary>
public unsafe struct SmartArray___MissingIteration
{
    // Members
    public ACBindings.Internal.MissingIteration* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds an array of QualifiedDataID objects, tracking element count and allocation status for efficient memory management.</summary>
/// <remarks>m_data points to the allocated array; m_num records the number of stored elements; m_sizeAndDeallocate encodes size or deallocation information used by the application’s internal memory handling routines.</remarks>
public unsafe struct SmartArray___QualifiedDataID
{
    // Members
    public ACBindings.Internal.QualifiedDataID* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Encapsulates dynamic array handling for BSP node pointers, storing the element count and a flag indicating whether to free memory upon destruction.</summary>
public unsafe struct SmartArray___BSPNODE_ptr
{
    // Members
    public ACBindings.Internal.BSPNODE** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages a dynamic array of MeshBatchType objects, tracking allocation state and element count.</summary>
public unsafe struct SmartArray___MeshBatchType
{
    // Members
    public ACBindings.Internal.MeshBatchType* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Represents a lightweight container for an array of D3DXATTRIBUTERANGE elements, managing storage and element count.</summary>
public unsafe struct SmartArray____D3DXATTRIBUTERANGE
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Container for an array of Position objects, storing the current element count and related metadata.</summary>
/// <remarks>
/// m_data points to a dynamically allocated array of Position instances.<br/>
/// m_num records how many elements are currently stored.<br/>
/// m_sizeAndDeallocate holds additional information about the array, such as size or allocation state; its exact meaning is implementation-defined.
/// </remarks>
public unsafe struct SmartArray___Position
{
    // Members
    public ACBindings.Internal.Position* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Represents a dynamically allocated array of ACCharGenStartArea elements, tracking the element count and deallocation status.</summary>
public unsafe struct SmartArray___ACCharGenStartArea
{
    // Members
    public ACBindings.Internal.ACCharGenStartArea* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Dynamic container that stores and manages a collection of LOAD_WEIGHTS instances, automatically handling memory allocation and deallocation.</summary>
public unsafe struct SmartArray___LOAD_WEIGHTS
{
    // Members
    public ACBindings.Internal.LOAD_WEIGHTS* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages a dynamic collection of LOAD_UVPAIR objects, storing the data pointer, allocated size with deallocation flag, and current element count.</summary>
public unsafe struct SmartArray___LOAD_UVPAIR
{
    // Members
    public ACBindings.Internal.LOAD_UVPAIR* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Manages a collection of graphic resources, automatically handling allocation and deallocation while tracking the number of elements in the array.</summary>
public unsafe struct SmartArray___GraphicsResource_ptr
{
    // Members
    public ACBindings.Internal.GraphicsResource** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds at most one FontReference, managing its lifetime and providing simple size tracking.</summary>
/// <remarks>Designed for 32‑bit Windows builds with 4‑byte alignment, this lightweight container stores a pointer to the font reference, a flag/value in m_sizeAndDeallocate, and a count of elements in m_num. It offers deterministic ownership semantics while remaining compact for single‑element use cases.</remarks>
public unsafe struct SmartArray___FontReference
{
    // Members
    public ACBindings.Internal.FontReference* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores an array of CPluginPrototype pointers, tracks how many are used, and indicates whether the stored objects should be automatically freed when the container is destroyed. Designed for efficient management of plugin prototypes in the application.</summary>
public unsafe struct SmartArray___CPluginPrototype_ptr
{
    // Members
    public ACBindings.Internal.CPluginPrototype** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Holds an array of InfoRegion pointers, providing automatic memory management and size tracking for the collection.</summary>
public unsafe struct SmartArray___InfoRegion_ptr
{
    // Members
    public ACBindings.Internal.InfoRegion** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Stores up to one function pointer returning bool and tracks its allocation state through an encoded size field.</summary>
public unsafe struct SmartArray__void_ptr
{
    // Members
    public static delegate* unmanaged[Cdecl]<byte> m_data; // function pointer
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Handles dynamic storage of TextureBasedFontVertexType elements, tracking element count and deallocation state within a contiguous array.</summary>
public unsafe struct SmartArray___TextureBasedFontVertexType
{
    // Members
    public ACBindings.Internal.TextureBasedFontVertexType* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}


/// <summary>Maintains a dynamic array of RenderLight objects, storing the data pointer, allocated capacity plus deallocation flag, and current element count.</summary>
public unsafe struct SmartArray___RenderLight
{
    // Members
    public ACBindings.Internal.RenderLight* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___DiskController_ptr
{
    // Members
    public ACBindings.Internal.DiskController** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___CPhysicsObj_ptr
{
    // Members
    public ACBindings.Internal.CPhysicsObj** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___LIGHTINFO_ptr
{
    // Members
    public ACBindings.Internal.LIGHTINFO** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___IConsoleCallbackObject_ptr
{
    // Members
    public ACBindings.Internal.IConsoleCallbackObject** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray____STL_pair__uint___QualifiedDataIDArray
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___DataHistory_DataIDHistoryData
{
    // Members
    public ACBindings.Internal.DataHistory.DataIDHistoryData* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___HashSorterNode__int___DataHistory_IterationData
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray____STL_pair___IDClass____tagDataID___MaterialInstance_ptr
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___RenderVertexBuffer_ptr
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___RenderIndexBuffer_ptr
{
    // Members
    public ACBindings.Internal.RenderIndexBuffer** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___RenderMeshFragmentTopology_TopVertexType
{
    // Members
    public ACBindings.Internal.RenderMeshFragmentTopology.TopVertexType* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___RenderMeshFragmentTopology_TopTriangleType
{
    // Members
    public ACBindings.Internal.RenderMeshFragmentTopology.TopTriangleType* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___RenderMeshFragmentTopology_TopEdgeType
{
    // Members
    public ACBindings.Internal.RenderMeshFragmentTopology.TopEdgeType* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___RenderMeshFragment_ptr
{
    // Members
    public ACBindings.Internal.RenderMeshFragment** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___QualityChangeHandler_ptr
{
    // Members
    public ACBindings.Internal.QualityChangeHandler** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___ClientNet_CReferralQueueEntry
{
    // Members
    public ACBindings.Internal.ClientNet.CReferralQueueEntry* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___HashSorterNode__uint___ElementDesc
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___ClientSystem_ptr
{
    // Members
    public ACBindings.Internal.ClientSystem** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___DbgReportGenPage_ptr
{
    // Members
    public ACBindings.Internal.DbgReportGenPage** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___UIMessageData
{
    // Members
    public ACBindings.Internal.UIMessageData* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___UIMessageRemovalData
{
    // Members
    public ACBindings.Internal.UIMessageRemovalData* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___ContextMenuData
{
    // Members
    public ACBindings.Internal.ContextMenuData* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___ProfilerUIWindow_ptr
{
    // Members
    public ACBindings.Internal.ProfilerUIWindow** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___QuickButton_ptr
{
    // Members
    public ACBindings.Internal.QuickButton** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___BudgetStatItem
{
    // Members
    public ACBindings.Internal.BudgetStatItem* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___ProfilerDBObjStat
{
    // Members
    public ACBindings.Internal.ProfilerDBObjStat* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___RenderDisplayModeType
{
    // Members
    public ACBindings.Internal.RenderDisplayModeType* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___PEnum
{
    // Members
    public ACBindings.Internal.PEnum* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___PAlias
{
    // Members
    public ACBindings.Internal.PAlias* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___QualifiedIteration
{
    // Members
    public ACBindings.Internal.QualifiedIteration* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___DDD_DataMessage_ptr
{
    // Members
    public ACBindings.Internal.DDD_DataMessage** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___HashSorterNode__uint___StringTableString_ptr
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___CInputManager_WIN32_InputDevice
{
    // Members
    public ACBindings.Internal.CInputManager_WIN32.InputDevice* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___PriorityHash___ControlSpecification___CInputManager_WIN32_ButtonHistoryEntry_PriorityHashData_ptr
{
    // Members
    public System.IntPtr m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___VertexRange
{
    // Members
    public ACBindings.Internal.VertexRange* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___RenderVertexStreamD3D_ptr
{
    // Members
    public ACBindings.Internal.RenderVertexStreamD3D** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___D3DLevelResourceType
{
    // Members
    public ACBindings.Internal.D3DLevelResourceType* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___Font_ptr
{
    // Members
    public ACBindings.Internal.Font** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___RenderMeshQueryVertexType
{
    // Members
    public ACBindings.Internal.RenderMeshQueryVertexType* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___View
{
    // Members
    public ACBindings.Internal.View* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___UIElement_Button_ptr
{
    // Members
    public ACBindings.Internal.UIElement_Button** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___UIOption_ptr
{
    // Members
    public ACBindings.Internal.UIOption** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___RadarInfo
{
    // Members
    public ACBindings.Internal.RadarInfo* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___RenderSurface_ptr
{
    // Members
    public ACBindings.Internal.RenderSurface** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___StringInfo
{
    // Members
    public ACBindings.Internal.StringInfo* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___gmCombatPanelUI_PanelChildInfo
{
    // Members
    public ACBindings.Internal.gmCombatPanelUI.PanelChildInfo* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___gmEnvPanelUI_PanelChildInfo
{
    // Members
    public ACBindings.Internal.gmEnvPanelUI.PanelChildInfo* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___UIElement_Text_ptr
{
    // Members
    public ACBindings.Internal.UIElement_Text** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___gmPanelUI_PanelChildInfo
{
    // Members
    public ACBindings.Internal.gmPanelUI.PanelChildInfo* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___PanelButtonInfo
{
    // Members
    public ACBindings.Internal.PanelButtonInfo* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___UIElement_ItemList_ptr
{
    // Members
    public ACBindings.Internal.UIElement_ItemList** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___EffectInfoRegion_ptr
{
    // Members
    public ACBindings.Internal.EffectInfoRegion** m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

public unsafe struct SmartArray___UIOption_CheckboxBitfield64_ChildInfo
{
    // Members
    public ACBindings.Internal.UIOption_CheckboxBitfield64.ChildInfo* m_data;
    public uint m_sizeAndDeallocate;
    public uint m_num;

    // Methods
}

