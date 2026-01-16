namespace ACBindings.Internal;


/// <summary>
/// Defines the visual appearance of rendered objects, storing shader constants, texture layers, and lighting capabilities.
/// Tracks optimization state and blending requirements to inform the graphics pipeline during rendering.
/// </summary>
public unsafe struct RenderMaterial : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct RenderMaterial_vtbl
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
    public byte m_IsInstance;
    public ACBindings.Internal.MaterialModifier properties;
    public ACBindings.Internal.SmartArray___MaterialLayer_ptr layers;
    public ACBindings.Internal.SmartArray___PStringBase__sbyte m_MaterialShaderConstantNames;
    public ACBindings.Internal.SmartArray___MaterialShaderConstant m_MaterialShaderConstants;
    public byte m_IsOptimized;
    public byte m_SupportsLighting;
    public byte m_SupportsMultiPassLighting;
    public byte m_SupportsCombinedAmbientPass;
    public byte m_SupportsGlowing;
    public byte m_NeedsAlphaBlendPass;
    public byte m_UsesVideoPost;
    public float m_Opacity;
    public fixed byte m_LayerIndices[45];

    // Generated Constructor
    public RenderMaterial() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Inserts the given material layer into this RenderMaterial's layer collection at the specified index, preserving order.
    /// <code>Offset: 0x0043FFC0
    /// void __thiscall RenderMaterial::InsertLayer(RenderMaterial*,const unsigned int,MaterialLayer*)</code>
    /// </summary>
    /// <param name="index">The zero‑based position where the new layer should be inserted; existing layers are shifted accordingly.</param>
    /// <param name="pLayer">Pointer to the MaterialLayer instance to add to the collection.</param>
    public void InsertLayer(uint index, ACBindings.Internal.MaterialLayer* pLayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, uint, ACBindings.Internal.MaterialLayer*, void>)0x0043FFC0)(ref this, index, pLayer);

    /// <summary>Searches the material’s layers for an output field matching the supplied identifiers and updates the provided reference if found.
    /// <code>Offset: 0x00449420
    /// char __thiscall RenderMaterial::CheckOutputField(_DWORD*,int*,int,int,int,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a variable that receives the matched layer reference; updated only when a different layer is located.</param>
    /// <param name="a3">Primary identifier used in the match comparison.</param>
    /// <param name="a4">Reserved/unused parameter retained for signature compatibility.</param>
    /// <param name="a5">Secondary identifier used in the match comparison.</param>
    /// <param name="a6">Tertiary identifier used in the match comparison.</param>
    /// <returns>Non‑zero if a matching output field is found; zero otherwise.</returns>
    public sbyte CheckOutputField(int* a2, int a3, int a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, int*, int, int, int, int, sbyte>)0x00449420)(ref this, a2, a3, a4, a5, a6);

    /// <summary>Analyzes all attached material layers, determines rendering capabilities (lighting, multi‑pass lighting, ambient pass, glow, alpha blend, video post), computes the minimum opacity, sets a layer index lookup table, and marks the material as optimized.
    /// <code>Offset: 0x004494E0
    /// void __thiscall RenderMaterial::Optimize(RenderMaterial*)</code>
    /// </summary>
    public void Optimize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, void>)0x004494E0)(ref this);

    /// <summary>Collects all valid texture data identifiers from a render material’s properties and layers, adding them to the provided array.
    /// <code>Offset: 0x00449710
    /// void __thiscall RenderMaterial::GetSubDataIDs(RenderMaterial*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that will receive qualified IDs for each referenced texture; entries are appended by this method.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00449710)(ref this, id_array);

    /// <summary>Constructs a RenderMaterial object, initializing its base DBObj, properties, layers, shader constants, capability flags, opacity, and layer index data with default values.
    /// <code>Offset: 0x004497E0
    /// void __thiscall RenderMaterial::RenderMaterial(RenderMaterial*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, void>)0x004497E0)(ref this);

    /// <summary>Retrieves the database object type identifier for this render material.
    /// <code>Offset: 0x00449880
    /// unsigned int __thiscall RenderMaterial::GetDBOType(RenderMaterial*)</code>
    /// </summary>
    /// <returns>The unique type identifier (currently always 31).</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, uint>)0x00449880)(ref this);

    /// <summary>Releases the material's sub‑objects, cleaning up layers and shader constants. Operation occurs only during runtime; on failure returns false.
    /// <code>Offset: 0x00449890
    /// bool __thiscall RenderMaterial::ReleaseSubObjects(RenderMaterial*)</code>
    /// </summary>
    /// <returns>True if all releases succeeded; otherwise false.</returns>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, byte>)0x00449890)(ref this);

    /// <summary>Allocates and constructs a new RenderMaterial object, returning a pointer to the resulting DBObj.
    /// <code>Offset: 0x00449950
    /// DBObj* __cdecl RenderMaterial::Allocator()</code>
    /// </summary>
    /// <returns>Pointer to the newly created RenderMaterial instance; null on failure.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x00449950)();

    /// <summary>Releases all subobjects of a RenderMaterial, clears its layers array and deallocates any associated memory, resets shader constant names and constants with proper reference handling, and finalizes the material for reuse or destruction.
    /// <code>Offset: 0x00449970
    /// void __thiscall RenderMaterial::End(RenderMaterial*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, void>)0x00449970)(ref this);

    /// <summary>Copies the contents of this RenderMaterial into the supplied DBObj destination, duplicating properties, shader constants, and layers.
    /// <code>Offset: 0x00449A60
    /// bool __thiscall RenderMaterial::CopyInto(RenderMaterial*,DBObj*)</code>
    /// </summary>
    /// <param name="this">Source RenderMaterial instance from which data is copied.</param>
    /// <param name="retval">Destination DBObj that receives the copied material data.</param>
    /// <returns>True if all components were successfully duplicated; otherwise false.</returns>
    public byte CopyInto(ACBindings.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, ACBindings.Internal.DBObj*, byte>)0x00449A60)(ref this, retval);

    /// <summary>Finalizes rendering for the material and resets all state flags, opacity, and layer indices to their default values.
    /// <code>Offset: 0x00449CF0
    /// void __thiscall RenderMaterial::Destroy(RenderMaterial*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, void>)0x00449CF0)(ref this);

    /// <summary>Serializes a RenderMaterial, writing or reading its base data, modifier properties, and every contained MaterialLayer via the supplied Archive.
    /// <code>Offset: 0x00449D50
    /// void __thiscall RenderMaterial::Serialize(RenderMaterial*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for serialization; when in write mode it stores current state, and when in read mode it reconstructs the material from stored data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, ACBindings.Internal.Archive*, void>)0x00449D50)(ref this, io_archive);

    /// <summary>Destroys a RenderMaterial instance, releasing shader constants, constant names, material layers, and other resources before invoking its base DBObj destructor.
    /// <code>Offset: 0x00449E50
    /// void __thiscall RenderMaterial::~RenderMaterial(RenderMaterial*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, void>)0x00449E50)(ref this);

    /// <summary>Prepares the material’s sub‑objects for rendering by removing inactive layers, collecting shader constants from its properties, and applying those properties or delegating to each layer. Returns true when every required sub‑object was successfully processed; otherwise returns false.
    /// <code>Offset: 0x00449ED0
    /// bool __thiscall RenderMaterial::GetSubObjects(RenderMaterial*)</code>
    /// </summary>
    /// <returns>True if all sub‑objects were prepared successfully, else false.</returns>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, byte>)0x00449ED0)(ref this);

    /// <summary>Checks whether the supplied field name matches one of the material's known properties; on match creates a new stage with the provided parameters and inserts it into that property's layer.
    /// <code>Offset: 0x0044A200
    /// char __thiscall RenderMaterial::CheckParseField(_DWORD*,volatile LONG*,int,_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="String1">Reference‑counted string buffer containing the field name to parse; may be modified during processing.</param>
    /// <param name="a3">Integer value passed as the first argument to the newly created stage.</param>
    /// <param name="a4">Pointer that must match an entry in the material's property table and is stored in the new stage.</param>
    /// <param name="a5">Second integer parameter for the new stage.</param>
    /// <param name="a6">Third integer parameter for the new stage.</param>
    /// <returns>Non‑zero (1) if parsing succeeded and a stage was inserted; zero otherwise.</returns>
    public sbyte CheckParseField(int* String1, int a3, int* a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMaterial, int*, int, int*, int, int, sbyte>)0x0044A200)(ref this, String1, a3, a4, a5, a6);
}

