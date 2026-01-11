namespace ACBindings.Internal.StringTableMetaLanguage;

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

    /// <summary>
    /// <code>Offset: 0x0067E6C0
    /// void __thiscall StringTableMetaLanguage::Node::AddChild(StringTableMetaLanguage::Node*,const StringTableMetaLanguage::Node*)</code>
    /// </summary>
    public void AddChild(ACBindings.Internal.StringTableMetaLanguage.Node* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTableMetaLanguage.Node, ACBindings.Internal.StringTableMetaLanguage.Node*, void>)0x0067E6C0)(ref this, child);

    /// <summary>
    /// <code>Offset: 0x0067E870
    /// void __thiscall StringTableMetaLanguage::Node::Reset(StringTableMetaLanguage::Node*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTableMetaLanguage.Node, void>)0x0067E870)(ref this);

    /// <summary>
    /// <code>Offset: 0x0067E8F0
    /// void __thiscall StringTableMetaLanguage::Node::Node(StringTableMetaLanguage::Node*,StringTableMetaLanguage::NodeType)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.StringTableMetaLanguage.NodeType Type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTableMetaLanguage.Node, ACBindings.Internal.StringTableMetaLanguage.NodeType, void>)0x0067E8F0)(ref this, Type);

    /// <summary>
    /// <code>Offset: 0x0067E950
    /// void __thiscall StringTableMetaLanguage::Node::~Node(StringTableMetaLanguage::Node*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTableMetaLanguage.Node, void>)0x0067E950)(ref this);
}

