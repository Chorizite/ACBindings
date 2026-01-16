namespace ACBindings.Internal;


/// <summary>
/// Describes a state entity within the system, including identification, spatial bounds, rendering flags, associated properties, and media assets.
/// </summary>
public unsafe struct StateDesc : System.IDisposable
{
    // Child Types

    /// <summary>Defines the virtual function table for StateDesc objects, enabling lifecycle management, serialization, node handling, and spatial updates in the system.</summary>
    public unsafe struct StateDesc_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, void> StateDesc_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.PFileNode*, byte> ToFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.PFileNode*, byte> FromFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.PFileNode*, byte> PositionToFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.PFileNode*, byte*, byte> HandleNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.PFileNode*, byte> CheckFFN; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, uint, uint, uint, uint, void> UpdateSizeAndPosition; // function pointer

        // Methods
    }
    // StateDesc::INCORPORATIONFLAGS
    public enum INCORPORATIONFLAGS : byte
    {
        IF_PASSTOCHILDREN = 0x1,
        IF_X = 0x2,
        IF_Y = 0x4,
        IF_WIDTH = 0x8,
        IF_HEIGHT = 0x10,
        IF_ZLEVEL = 0x20
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_uiIncorporationFlags;
    public uint m_stateID;
    public byte m_bIsCode;
    public byte m_bPassToChildren;
    public int m_x;
    public int m_y;
    public int m_width;
    public int m_height;
    public int m_zLevel;
    public ACBindings.Internal.PropertyCollection m_properties;
    public ACBindings.Internal.SmartArray___MediaDesc_ptr m_media;

    // Generated Constructor
    public StateDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Collects all sub-data identifiers from this state's property collection and associated media descriptors into the supplied array.
    /// <code>Offset: 0x0069CD60
    /// void __thiscall StateDesc::GetSubDataIDs(StateDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">Array to receive qualified data identifiers of nested components.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0069CD60)(ref this, id_array);

    /// <summary>Updates the state's position and size relative to a new parent rectangle, applying specified alignment rules for each side.
    /// <code>Offset: 0x0069CDB0
    /// void __thiscall StateDesc::UpdateSizeAndPosition(StateDesc*,const Box2D*,const Box2D*,unsigned int,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="oldParent">The previous bounding box that defined the state’s coordinate system.</param>
    /// <param name="newParent">The target bounding box to which the state will be positioned.</param>
    /// <param name="leftEdge">Alignment setting for the left edge (e.g., align, center, stretch).</param>
    /// <param name="topEdge">Alignment setting for the top edge.</param>
    /// <param name="rightEdge">Alignment setting for the right edge.</param>
    /// <param name="bottomEdge">Alignment setting for the bottom edge.</param>
    public void UpdateSizeAndPosition(ACBindings.Internal.Box2D* oldParent, ACBindings.Internal.Box2D* newParent, uint leftEdge, uint topEdge, uint rightEdge, uint bottomEdge) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, uint, uint, uint, uint, void>)0x0069CDB0)(ref this, oldParent, newParent, leftEdge, topEdge, rightEdge, bottomEdge);

    /// <summary>Initializes a StateDesc instance with default values, zeroing numeric flags, identifiers, dimensions, positions, z‑level, and clearing associated property collection and media array.
    /// <code>Offset: 0x0069D010
    /// void __thiscall StateDesc::StateDesc(StateDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, void>)0x0069D010)(ref this);

    /// <summary>Always returns true without modifying the supplied file node.
    /// <code>Offset: 0x0069D060
    /// bool __thiscall StateDesc::PositionToFileNode(StateDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">File node intended to receive position data (currently unused).</param>
    /// <returns>True.</returns>
    public byte PositionToFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.PFileNode*, byte>)0x0069D060)(ref this, file_node);

    /// <summary>Cleans up all media objects stored in the state description by invoking their destructors and resetting the collection. If the internal data buffer was allocated dynamically, it is freed; otherwise remaining slots are cleared.
    /// <code>Offset: 0x0069D070
    /// void __thiscall StateDesc::CleanupMedia(StateDesc*)</code>
    /// </summary>
    public void CleanupMedia() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, void>)0x0069D070)(ref this);

    /// <summary>Destroys a StateDesc instance by cleaning up its media resources, deallocating owned arrays when necessary, and destroying the property collection.
    /// <code>Offset: 0x0069D120
    /// void __thiscall StateDesc::~StateDesc(StateDesc*)</code>
    /// </summary>
    /// <param name="this">Pointer to the StateDesc object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, void>)0x0069D120)(ref this);

    /// <summary>Converts a StateDesc into a hierarchical PFileNode representation, adding subnodes for state ID, code flag, passtochildren flag, position data, properties, and media items.
    /// <code>Offset: 0x0069D160
    /// bool __thiscall StateDesc::ToFileNode(StateDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The root node to which the state's information will be appended; must not be null.</param>
    /// <returns>True if all relevant subnodes were successfully created and populated; otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.PFileNode*, byte>)0x0069D160)(ref this, file_node);

    /// <summary>Checks that this StateDesc defines a valid state ID before further processing.
    /// <code>Offset: 0x0069D2D0
    /// bool __thiscall StateDesc::CheckFFN(StateDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The file node from which to report an error if the check fails.</param>
    /// <returns>True when the StateDesc has a non‑zero stateID; otherwise reports an error and returns false.</returns>
    public byte CheckFFN(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.PFileNode*, byte>)0x0069D2D0)(ref this, file_node);

    /// <summary>Serializes the StateDesc object to or from an Archive, writing or reading fields such as state ID, incorporation flags, geometry coordinates, and child pass flag according to archive mode and version token.
    /// <code>Offset: 0x0069D480
    /// void __thiscall StateDesc::Serialize(StateDesc*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for serialization; determines whether data is written or read and may contain a version token that controls which fields are processed.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.Archive*, void>)0x0069D480)(ref this, io_archive);

    /// <summary>Parses a PFileNode to populate this StateDesc object by handling each sub‑node and reporting any unknown keywords. Returns true when parsing succeeds and the resulting description passes validation.
    /// <code>Offset: 0x0069D640
    /// bool __thiscall StateDesc::FromFileNode(StateDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The file node containing state information to be parsed.</param>
    /// <returns>True if the node was processed successfully; otherwise, false.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.PFileNode*, byte>)0x0069D640)(ref this, file_node);

    /// <summary>Loads a media descriptor from the specified file node and appends it to the state's media collection.
    /// <code>Offset: 0x0069D7E0
    /// bool __thiscall StateDesc::LoadMedia(StateDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="node">The file node containing media information; may be null, causing failure.</param>
    /// <returns>True if the media was successfully created and added; otherwise false.</returns>
    public byte LoadMedia(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.PFileNode*, byte>)0x0069D7E0)(ref this, node);

    /// <summary>Appends all media descriptors from another StateDesc into this instance, creating copies of each descriptor.
    /// <code>Offset: 0x0069D840
    /// void __thiscall StateDesc::ConcatenateMedia(StateDesc*,const StateDesc*)</code>
    /// </summary>
    /// <param name="rhs">The source StateDesc whose media items are to be concatenated.</param>
    public void ConcatenateMedia(ACBindings.Internal.StateDesc* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.StateDesc*, void>)0x0069D840)(ref this, rhs);

    /// <summary>Determines if the state description includes the specified property.
    /// <code>Offset: 0x0069D8D0
    /// bool __thiscall StateDesc::ContainsProperty(StateDesc*,const unsigned int)</code>
    /// </summary>
    /// <param name="property">Identifier of the property to check for inclusion.</param>
    /// <returns>True when the property exists in the state's property collection; otherwise, false.</returns>
    public byte ContainsProperty(uint property) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, uint, byte>)0x0069D8D0)(ref this, property);

    /// <summary>Creates or updates a media image associated with this state descriptor, initializing its properties and adding it to the state's media collection.
    /// <code>Offset: 0x0069D8E0
    /// void __thiscall StateDesc::SetMediaImage(_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="a2">The first dimension/parameter of the media image (e.g., width).</param>
    /// <param name="a3">The second dimension/parameter of the media image (e.g., height).</param>
    public void SetMediaImage(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, int, int, void>)0x0069D8E0)(ref this, a2, a3);

    /// <summary>
    /// Handles a file node representing a state description by parsing recognized keywords such as STATEID, PASSTOCHILDREN, PROPERTIES, and MEDIA, updating the StateDesc instance accordingly.
    /// Returns true if parsing succeeded; otherwise false on error or unsupported keyword.
    /// 
    /// <code>Offset: 0x0069D990
    /// bool __thiscall StateDesc::HandleNode(StateDesc*,const PFileNode*,bool*)</code>
    /// </summary>
    /// <param name="node">The file node to process. Must not be null.</param>
    /// <param name="handled">Set to true when the node matches a known keyword; set to false if the node is unrecognized and will be processed elsewhere.</param>
    /// <returns>True if the node was successfully handled and parsed; otherwise false indicating failure or unsupported content.</returns>
    public byte HandleNode(ACBindings.Internal.PFileNode* node, byte* handled) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.PFileNode*, byte*, byte>)0x0069D990)(ref this, node, handled);

    /// <summary>Merges the properties of <paramref name="desc"/> into the current state, updating only those fields indicated by flag bits in <paramref name="desc"/>'s <c>m_uiIncorporationFlags</c>.
    /// <code>Offset: 0x0069DB30
    /// bool __thiscall StateDesc::Incorporate(StateDesc*,const StateDesc*)</code>
    /// </summary>
    /// <param name="desc">The source state whose attributes are incorporated.</param>
    /// <returns>True after successfully merging the data.</returns>
    public byte Incorporate(ACBindings.Internal.StateDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.StateDesc*, byte>)0x0069DB30)(ref this, desc);
}

