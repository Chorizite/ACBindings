namespace ACBindings.Internal;


/// <summary>Represents an instance of a material used in rendering, encapsulating its name, identifier, type information, modifier references, and flags controlling shadow behavior and geometry handling. It maintains pointers to both the original and modified render materials for runtime updates.</summary>
public unsafe struct MaterialInstance : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct MaterialInstance_vtbl
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
    public ACBindings.Internal.PStringBase__sbyte m_materialName;
    public ACBindings.Internal.IDClass____tagDataID m_materialID;
    public ACBindings.Internal.PStringBase__sbyte m_materialTypeName;
    public uint m_materialType;
    public ACBindings.Internal.SmartArray___ModifierRef_ptr m_aModifierRefs;
    public byte m_AllowStencilShadows;
    public byte m_WantDiscardGeometry;
    public ACBindings.Internal.RenderMaterial* m_pMaterial;
    public ACBindings.Internal.SmartArray___MaterialModifier_ptr m_aModifiers;
    public ACBindings.Internal.RenderMaterial* m_pModifiedMaterial;
    public byte m_bNeedRefresh;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Marks the material instance as needing a refresh and indicates success.
    /// <code>Offset: 0x0044D170
    /// char __thiscall MaterialInstance::Refresh(_BYTE*,int)</code>
    /// </summary>
    /// <param name="a2">Unused parameter kept for compatibility with legacy calls.</param>
    /// <returns>Always returns 1 (true).</returns>
    public sbyte Refresh(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, int, sbyte>)0x0044D170)(ref this, a2);

    /// <summary>Initializes a material instance by clearing its name and type buffers, resetting identifiers, and setting default rendering flags such as stencil shadows and geometry discard behavior.
    /// <code>Offset: 0x0044D180
    /// void __thiscall MaterialInstance::Begin(MaterialInstance*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, void>)0x0044D180)(ref this);

    /// <summary>Adds the instance's material ID and each non‑invalid modifier reference ID to the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x0044D250
    /// void __thiscall MaterialInstance::GetSubDataIDs(MaterialInstance*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="this">Pointer to the MaterialInstance calling the method.</param>
    /// <param name="id_array">Collection into which qualifying data IDs are appended.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0044D250)(ref this, id_array);

    /// <summary>Releases all subordinate objects associated with this material instance, such as modified and base materials and attached modifiers.
    /// <code>Offset: 0x0044D2D0
    /// bool __thiscall MaterialInstance::ReleaseSubObjects(MaterialInstance*)</code>
    /// </summary>
    /// <returns>True after successful cleanup; the method always succeeds and therefore returns true.</returns>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, byte>)0x0044D2D0)(ref this);

    /// <summary>Retrieves the database object type ID for this material instance.
    /// <code>Offset: 0x0044D3D0
    /// unsigned int __thiscall MaterialInstance::GetDBOType(MaterialInstance*)</code>
    /// </summary>
    /// <returns>The constant value 33 that identifies the MaterialInstance DBO type.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, uint>)0x0044D3D0)(ref this);

    /// <summary>Finalizes the material instance by releasing subobjects, clearing modifier references, deallocating associated resources, and resetting internal state.
    /// <code>Offset: 0x0044D410
    /// void __thiscall MaterialInstance::End(MaterialInstance*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, void>)0x0044D410)(ref this);

    /// <summary>Copies the material instance into a DBObj representation for persistence.
    /// <code>Offset: 0x0044D4C0
    /// bool __thiscall MaterialInstance::CopyInto(MaterialInstance*,DBObj*)</code>
    /// </summary>
    /// <param name="retval">The database object that receives the copied data.</param>
    /// <returns>True if all components were successfully copied; otherwise false.</returns>
    public byte CopyInto(ACBindings.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, ACBindings.Internal.DBObj*, byte>)0x0044D4C0)(ref this, retval);

    /// <summary>Resets the material instance by ending and reinitializing its state.
    /// <code>Offset: 0x0044D790
    /// void __thiscall MaterialInstance::Destroy(MaterialInstance*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, void>)0x0044D790)(ref this);

    /// <summary>Populates the material instance with its base render material and associated modifiers, marking it for refresh. Returns true when all referenced objects are successfully retrieved; otherwise false if any reference is missing or invalid.
    /// <code>Offset: 0x0044D7A0
    /// bool __thiscall MaterialInstance::GetSubObjects(MaterialInstance*)</code>
    /// </summary>
    /// <returns>True if the material and all its modifiers were found and stored; false if an identifier was invalid or a required object could not be obtained.</returns>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, byte>)0x0044D7A0)(ref this);

    /// <summary>Serializes or deserializes the material instance's identifiers, type, modifier references and flag settings to or from an archive, handling alignment and data consistency based on the archive mode.
    /// <code>Offset: 0x0044D840
    /// void __thiscall MaterialInstance::Serialize(MaterialInstance*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for reading or writing the material instance data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, ACBindings.Internal.Archive*, void>)0x0044D840)(ref this, io_archive);

    /// <summary>Destroys a MaterialInstance by releasing its modifier arrays, decrementing reference‑counted material name strings, invoking End to perform instance cleanup, and then destroying the base DBObj component.
    /// <code>Offset: 0x0044DA30
    /// void __thiscall MaterialInstance::~MaterialInstance(MaterialInstance*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialInstance, void>)0x0044DA30)(ref this);
}

