namespace ACBindings.Internal;


/// <summary>Describes a UI element, containing identifiers, layout boundaries, state information, and hierarchical relationships for rendering and interaction.</summary>
public unsafe struct ElementDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.StateDesc BaseClass_StateDesc; // ACBindings.Internal.StateDesc

    // Child Types
    public unsafe struct ElementDesc_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, void> ElementDesc_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.PFileNode*, byte> ToFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.PFileNode*, byte> FromFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.PFileNode*, byte> PositionToFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.PFileNode*, byte*, byte> HandleNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.PFileNode*, byte> CheckFFN; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, uint, uint, uint, uint, void> UpdateSizeAndPosition; // function pointer

        // Methods
    }

    // Members
    public uint m_elementID;
    public uint m_type;
    public uint m_engineType;
    public uint m_baseElement;
    public ACBindings.Internal.IDClass____tagDataID m_baseLayout;
    public uint m_defaultState;
    public uint m_leftEdge;
    public uint m_topEdge;
    public uint m_rightEdge;
    public uint m_bottomEdge;
    public ACBindings.Internal.HashTable__uint___StateDesc m_states;
    public ACBindings.Internal.HashTable__uint___ElementDesc m_children;
    public uint m_uiReadOrder;
    public ACBindings.Internal.PStringBase__sbyte m_strComments;
    public ACBindings.Internal.PStringBase__sbyte m_strName;

    // Generated Constructor
    public ElementDesc() {
        _ConstructorInternal();
    }
    public ElementDesc(ACBindings.Internal.ElementDesc* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Updates the element’s size and position based on a new parent layout, then propagates the changes to all child elements.
    /// <code>Offset: 0x0069B6A0
    /// void __thiscall ElementDesc::UpdateSizeAndPosition(ElementDesc*,const Box2D*,const Box2D*,unsigned int,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="oldParent">The previous parent bounds before relocation.</param>
    /// <param name="newParent">The updated parent bounds after relocation.</param>
    /// <param name="leftEdge">Left edge of the element relative to its parent.</param>
    /// <param name="topEdge">Top edge of the element relative to its parent.</param>
    /// <param name="rightEdge">Right edge of the element relative to its parent.</param>
    /// <param name="bottomEdge">Bottom edge of the element relative to its parent.</param>
    public void UpdateSizeAndPosition(ACBindings.Internal.Box2D* oldParent, ACBindings.Internal.Box2D* newParent, uint leftEdge, uint topEdge, uint rightEdge, uint bottomEdge) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, uint, uint, uint, uint, void>)0x0069B6A0)(ref this, oldParent, newParent, leftEdge, topEdge, rightEdge, bottomEdge);

    /// <summary>Aggregates all qualified data identifiers associated with this element, including those from the base layout, child elements, and state definitions, into the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x0069B790
    /// void __thiscall ElementDesc::GetSubDataIDs(ElementDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="this">The ElementDesc instance whose sub‑data identifiers are to be collected.</param>
    /// <param name="id_array">The array that receives the aggregated qualified data identifiers.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0069B790)(ref this, id_array);

    /// <summary>Serializes this element’s position and size attributes into a file node, creating subnodes for x, y, width, height, and z‑level when their corresponding incorporation flags are set.
    /// <code>Offset: 0x0069B8B0
    /// bool __thiscall ElementDesc::PositionToFileNode(ElementDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The target file node to receive the serialized positional data.</param>
    /// <returns>True if all required subnodes were created successfully; otherwise false.</returns>
    public byte PositionToFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.PFileNode*, byte>)0x0069B8B0)(ref this, file_node);

    /// <summary>Validates an ElementDesc against syntax rules, ensuring proper use of Type/Base keywords, disallowing StateID, and requiring an ElementID.
    /// <code>Offset: 0x0069BA20
    /// bool __thiscall ElementDesc::CheckFFN(ElementDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The file node containing the element definition, used for reporting any validation errors.</param>
    /// <returns>True if the element satisfies all constraints; otherwise false after logging errors.</returns>
    public byte CheckFFN(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.PFileNode*, byte>)0x0069BA20)(ref this, file_node);

    /// <summary>Retrieve the state description associated with a given identifier from an element's state table.
    /// <code>Offset: 0x0069BAD0
    /// StateDesc* __thiscall ElementDesc::AccessStateDesc(ElementDesc*,unsigned int)</code>
    /// </summary>
    /// <param name="stateID">The unique identifier of the desired state.</param>
    /// <returns>Pointer to the matching StateDesc object, or nullptr if no such state exists.</returns>
    public ACBindings.Internal.StateDesc* AccessStateDesc(uint stateID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, uint, ACBindings.Internal.StateDesc*>)0x0069BAD0)(ref this, stateID);

    /// <summary>Destroys an ElementDesc instance, freeing its name and comment buffers, deleting all child elements and states from the internal hash tables, and invoking the base StateDesc destructor to release inherited resources.
    /// <code>Offset: 0x0069C0C0
    /// void __thiscall ElementDesc::~ElementDesc(ElementDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, void>)0x0069C0C0)(ref this);

    /// <summary>Initializes a new ElementDesc object, zeroing out identifiers, setting up the base StateDesc component, creating empty state and child hash tables, and preparing name/comment strings.
    /// <code>Offset: 0x0069C1A0
    /// void __thiscall ElementDesc::ElementDesc(ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, void>)0x0069C1A0)(ref this);

    /// <summary>Initializes a new ElementDesc instance by setting up its state table, child table, and string members, then copies the contents of another ElementDesc into it.
    /// <code>Offset: 0x0069C3B0
    /// void __thiscall ElementDesc::ElementDesc(ElementDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="rhs">The source ElementDesc whose properties are copied to the newly constructed object.</param>
    public void _ConstructorInternal(ACBindings.Internal.ElementDesc* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.ElementDesc*, void>)0x0069C3B0)(ref this, rhs);

    /// <summary>Incorporates properties, states, and child elements from another ElementDesc into this instance, updating dimensions and read order accordingly.
    /// <code>Offset: 0x0069C430
    /// bool __thiscall ElementDesc::Incorporate(ElementDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="desc">The source ElementDesc whose data will be merged into this element.</param>
    /// <returns>True if all incorporation steps succeeded; otherwise false.</returns>
    public byte Incorporate(ACBindings.Internal.ElementDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.ElementDesc*, byte>)0x0069C430)(ref this, desc);

    /// <summary>Serializes or deserializes an ElementDesc object using the provided Archive, writing or reading its identifier, type, layout information, bounds, state table, and child elements while respecting versioning and alignment constraints.
    /// <code>Offset: 0x0069CA30
    /// void __thiscall ElementDesc::Serialize(ElementDesc*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used to write or read element data. The archive’s flags determine whether the operation is a write (serialization) or a read (deserialization).</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.Archive*, void>)0x0069CA30)(ref this, io_archive);
}

