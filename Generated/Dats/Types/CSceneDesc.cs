namespace ACBindings.Internal;


/// <summary>Stores a dynamic list of scene types, managing allocation and cleanup for scene descriptors in the application.</summary>
/// <remarks>Encapsulates an AC1Legacy::SmartArray of CSceneType pointers, offering methods to add scenes, compute serialization size, retrieve sub‑data IDs, and destroy contained objects.</remarks>
public unsafe struct CSceneDesc : System.IDisposable
{
    // Members
    public ACBindings.Internal.AC1Legacy.SmartArray___CSceneType_ptr scene_types;

    // Generated Constructor
    public CSceneDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys all scene types held by the descriptor, freeing each object’s resources and clearing the internal collection.
    /// <code>Offset: 0x00502DC0
    /// void __thiscall CSceneDesc::Destroy(CSceneDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneDesc, void>)0x00502DC0)(ref this);

    /// <summary>Calculates the total byte count required to serialize the scene description, including a fixed 4‑byte header and the packed sizes of all contained scene types.
    /// <code>Offset: 0x00502E20
    /// unsigned int __thiscall CSceneDesc::pack_size(CSceneDesc*)</code>
    /// </summary>
    /// <returns>The cumulative size in bytes needed for packing.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneDesc, uint>)0x00502E20)(ref this);

    /// <summary>Destroys a CSceneDesc instance, releasing its scene type array and cleaning up internal state.
    /// <code>Offset: 0x00502E50
    /// void __thiscall CSceneDesc::~CSceneDesc(CSceneDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneDesc, void>)0x00502E50)(ref this);

    /// <summary>Collects data identifiers from all scenes within this scene descriptor and appends them to the supplied array.
    /// <code>Offset: 0x00502E70
    /// void __thiscall CSceneDesc::GetSubDataIDs(CSceneDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The QualifiedDataIDArray that will receive the collected IDs.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00502E70)(ref this, id_array);

    /// <summary>Adds a new scene type to the collection, expanding storage if necessary.
    /// <code>Offset: 0x00502EF0
    /// int __thiscall CSceneDesc::Add(CSceneDesc*,CSceneType*)</code>
    /// </summary>
    /// <param name="scene">The scene type to add.</param>
    /// <returns>Non‑zero on success (typically 1); zero or an error code if allocation fails.</returns>
    public int Add(ACBindings.Internal.CSceneType* scene) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneDesc, ACBindings.Internal.CSceneType*, int>)0x00502EF0)(ref this, scene);

    /// <summary>Initializes the TurbineChatBlob instance by resetting target ID, result code, and chat type to zero.
    /// <code>Offset: 0x005031E0
    /// void __thiscall CSceneDesc::CSceneDesc(TurbineChatBlob*)</code>
    /// </summary>
    /// <param name="this">The TurbineChatBlob object to initialize.</param>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneDesc, void>)0x005031E0)(ref this);
}

