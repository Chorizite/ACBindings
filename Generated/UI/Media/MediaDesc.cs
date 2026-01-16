namespace ACBindings.Internal;


/// <summary>Encapsulates a media descriptor with a type identifier and a virtual function table pointer, enabling polymorphic handling of different media types.</summary>
public unsafe struct MediaDesc : System.IDisposable
{
    // Child Types

    /// <summary>VTable structure defining virtual function pointers for MediaDesc objects, enabling polymorphic behavior such as serialization, dynamic casting to specific media types, duration querying, and file node conversion.</summary>
    public unsafe struct MediaDesc_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, void> MediaDesc_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Anim*> DynamicCast_Anim; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Image*> DynamicCast_Image; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Alpha*> DynamicCast_Alpha; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Pause*> DynamicCast_Pause; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Jump*> DynamicCast_Jump; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Message*> DynamicCast_Message; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Sound*> DynamicCast_Sound; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_State*> DynamicCast_State; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Movie*> DynamicCast_Movie; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Cursor*> DynamicCast_Cursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Fade*> DynamicCast_Fade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, float> GetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.PFileNode*, byte> ToFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.PFileNode*, byte> FromFileNode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_type;

    // Generated Constructor
    public MediaDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a MediaDesc instance by assigning its virtual table and setting the media type to zero.
    /// <code>Offset: 0x0069E1D0
    /// void __thiscall MediaDesc::MediaDesc(MediaDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaDesc, void>)0x0069E1D0)(ref this);

    /// <summary>Destructs a MediaDesc instance, resetting its virtual table pointer to the original for proper cleanup.
    /// <code>Offset: 0x0069E200
    /// void __thiscall MediaDesc::~MediaDesc(MediaDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaDesc, void>)0x0069E200)(ref this);

    /// <summary>Creates and initializes a MediaDesc instance corresponding to the specified media type identifier.
    /// <code>Offset: 0x0069E230
    /// MediaDesc* __cdecl MediaDesc::CreateMediaType(unsigned int)</code>
    /// </summary>
    /// <param name="type">A numeric code indicating which kind of media descriptor to construct (e.g., 1 for movie, 2 for alpha, etc.).</param>
    /// <returns>A pointer to a newly allocated MediaDesc object initialized for that type, or null if allocation fails or the type is unrecognized.</returns>
    public static ACBindings.Internal.MediaDesc* CreateMediaType(uint type) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.MediaDesc*>)0x0069E230)(type);

    /// <summary>Creates a new media descriptor by copying the provided descriptor according to its type.
    /// <code>Offset: 0x0069E380
    /// MediaDesc* __cdecl MediaDesc::CreateMediaType(const MediaDesc*)</code>
    /// </summary>
    /// <param name="rhs">The source media descriptor to duplicate.</param>
    /// <returns>A pointer to a newly allocated media descriptor of the same type, or null if allocation fails.</returns>
    public static ACBindings.Internal.MediaDesc* CreateMediaType(ACBindings.Internal.MediaDesc* rhs) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MediaDesc*>)0x0069E380)(rhs);

    /// <summary>Serializes the media type of a MediaDesc instance using an Archive, writing when the archive is in write mode and reading otherwise.
    /// <code>Offset: 0x0069E510
    /// void __thiscall MediaDesc::Serialize(MediaDesc*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Specifies the archive used for serialization; its flags determine whether data is written to or read from it.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaDesc, ACBindings.Internal.Archive*, void>)0x0069E510)(ref this, io_archive);

    /// <summary>Creates a FileNode representation of this MediaDesc by appending a sub‑node containing its type string under the supplied file node.
    /// <code>Offset: 0x0069E550
    /// bool __thiscall MediaDesc::ToFileNode(MediaDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The FileNode to which the media description will be added as a sub‑node.</param>
    /// <returns>True if the conversion succeeds; otherwise, false.</returns>
    public byte ToFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaDesc, ACBindings.Internal.PFileNode*, byte>)0x0069E550)(ref this, file_node);

    /// <summary>Creates a MediaDesc object from the supplied file node by locating the media type sub‑node, converting its leaf value into an enumeration, constructing the appropriate media type, and initializing it with the original node data. If any step fails, reports an error and returns null.
    /// <code>Offset: 0x0069E5F0
    /// MediaDesc* __cdecl MediaDesc::CreateFromFileNode(const PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The file node that describes the media to be created.</param>
    /// <returns>Pointer to a newly constructed MediaDesc instance on success; otherwise nullptr if validation or construction fails.</returns>
    public static ACBindings.Internal.MediaDesc* CreateFromFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PFileNode*, ACBindings.Internal.MediaDesc*>)0x0069E5F0)(file_node);
}

