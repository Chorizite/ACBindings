namespace ACBindings.Internal.StringTableMetaLanguage;


/// <summary>
/// Represents a node in the string table meta‑language, storing a Unicode text value, type, identifier, capitalization flag, and attribute flags. It maintains a linked list of child nodes to form hierarchical structures for complex localized strings. Reference‑counted strings and positional data support efficient parsing and memory management.
/// </summary>
public unsafe struct Node : System.IDisposable
{
    // Members
    public ACBindings.Internal.PStringBase__ushort text;
    public ACBindings.Internal.StringTableMetaLanguage.NodeType type;
    public ACBindings.Internal.List___StringTableMetaLanguage_Node_ptr children;
    public int ID;
    public byte bForceCapital;
    public ACBindings.Internal.PStringBase__ushort flags;
    public int pos;

    // Generated Constructor
    public Node(ACBindings.Internal.StringTableMetaLanguage.NodeType Type) {
        _ConstructorInternal(Type);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Adds a child node to the current node’s children list, updating internal linked‑list pointers and element count.
    /// <code>Offset: 0x0067E6C0
    /// void __thiscall StringTableMetaLanguage::Node::AddChild(StringTableMetaLanguage::Node*,const StringTableMetaLanguage::Node*)</code>
    /// </summary>
    /// <param name="child">The node to append as a child of this node.</param>
    public void AddChild(ACBindings.Internal.StringTableMetaLanguage.Node* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTableMetaLanguage.Node, ACBindings.Internal.StringTableMetaLanguage.Node*, void>)0x0067E6C0)(ref this, child);

    /// <summary>Resets a node by clearing its type and deleting all child nodes.
    /// <code>Offset: 0x0067E870
    /// void __thiscall StringTableMetaLanguage::Node::Reset(StringTableMetaLanguage::Node*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTableMetaLanguage.Node, void>)0x0067E870)(ref this);

    /// <summary>Initializes a new StringTableMetaLanguage::Node instance with the specified type, setting text and flags to empty strings, creating an empty children list, and zeroing all numeric fields.
    /// <code>Offset: 0x0067E8F0
    /// void __thiscall StringTableMetaLanguage::Node::Node(StringTableMetaLanguage::Node*,StringTableMetaLanguage::NodeType)</code>
    /// </summary>
    /// <param name="Type">The NodeType value that determines the node's role in the table.</param>
    public void _ConstructorInternal(ACBindings.Internal.StringTableMetaLanguage.NodeType Type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTableMetaLanguage.Node, ACBindings.Internal.StringTableMetaLanguage.NodeType, void>)0x0067E8F0)(ref this, Type);

    /// <summary>Destroys a node by resetting its data, decrementing reference counts of associated strings, and clearing its child list.
    /// <code>Offset: 0x0067E950
    /// void __thiscall StringTableMetaLanguage::Node::~Node(StringTableMetaLanguage::Node*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTableMetaLanguage.Node, void>)0x0067E950)(ref this);
}

