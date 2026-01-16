namespace ACBindings.Internal;


/// <summary>Represents a scene type within the application, storing a name, a list of related scene identifiers, and an optional sound table descriptor for audio resources.</summary>
public unsafe struct CSceneType : System.IDisposable
{
    // Members
    public ACBindings.Internal.PStringBase__sbyte scene_name;
    public ACBindings.Internal.SmartArray___IDClass____tagDataID scenes;
    public ACBindings.Internal.AmbientSTBDesc* sound_table_desc;

    // Generated Constructor
    public CSceneType() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Computes the size in bytes required to pack this scene type's data, accounting for its scene list.
    /// <code>Offset: 0x00503C20
    /// unsigned int __thiscall CSceneType::pack_size(CSceneType*)</code>
    /// </summary>
    /// <returns>Total number of bytes needed for serialization.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneType, uint>)0x00503C20)(ref this);

    /// <summary>Serializes the scene type’s data into a binary buffer, writing the scene count followed by each scene ID as 32‑bit values while respecting the supplied buffer size.
    /// <code>Offset: 0x00503C30
    /// unsigned int __thiscall CSceneType::pack(CSceneType*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">A pointer to the current write position in the destination buffer; updated to point after the serialized data.</param>
    /// <param name="size">The remaining size of the buffer before serialization; remains unchanged after the call and is also returned by the function.</param>
    /// <returns>The original size of the buffer passed in via <paramref name="size"/>.</returns>
    public uint pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneType, void**, uint*, uint>)0x00503C30)(ref this, addr, size);

    /// <summary>Initializes a new CSceneType object with default values: sets the scene name to an empty string, clears the list of scenes, and resets the sound table descriptor.
    /// <code>Offset: 0x00503C90
    /// void __thiscall CSceneType::CSceneType(CSceneType*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneType, void>)0x00503C90)(ref this);

    /// <summary>Destroys a CSceneType instance, freeing its scenes array and decrementing the reference count of the associated scene name string.
    /// <code>Offset: 0x00503CC0
    /// void __thiscall CSceneType::~CSceneType(CSceneType*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneType, void>)0x00503CC0)(ref this);

    /// <summary>Unpacks a list of scene identifiers from a binary buffer into the current object's scenes array, advancing the buffer pointer and reducing the remaining byte count accordingly.
    /// <code>Offset: 0x00503D20
    /// int __thiscall CSceneType::unpack(CSceneType*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position within the input buffer; updated to point after the read data.</param>
    /// <param name="size">Reference to the number of bytes left in the buffer; decreased by the amount consumed during unpacking.</param>
    /// <returns>1, indicating that the operation completed successfully and the scenes array has been populated with the extracted IDs.</returns>
    public int unpack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneType, void**, uint*, int>)0x00503D20)(ref this, addr, size);
}

