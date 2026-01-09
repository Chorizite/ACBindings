namespace ACBindings.StringTableMetaLanguage;

// StringTableMetaLanguage::Node
public unsafe struct Node : System.IDisposable
{
    // Members
    public ACBindings.PStringBase__ushort text;
    public ACBindings.StringTableMetaLanguage.NodeType type;
    public ACBindings.List__StringTableMetaLanguage_Node_ptr children;
    public int ID;
    public byte bForceCapital;
    public ACBindings.PStringBase__ushort flags;
    public int pos;

    // Generated Constructor
    public Node(ACBindings.StringTableMetaLanguage.NodeType Type) {
        _ConstructorInternal(Type);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall StringTableMetaLanguage::Node::AddChild(StringTableMetaLanguage::Node*,const StringTableMetaLanguage::Node*)
    public void AddChild(ACBindings.StringTableMetaLanguage.Node* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTableMetaLanguage.Node, ACBindings.StringTableMetaLanguage.Node*, void>)0x0067E6C0)(ref this, child);
    // void __thiscall StringTableMetaLanguage::Node::Reset(StringTableMetaLanguage::Node*)
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTableMetaLanguage.Node, void>)0x0067E870)(ref this);
    // void __thiscall StringTableMetaLanguage::Node::Node(StringTableMetaLanguage::Node*,StringTableMetaLanguage::NodeType)
    public void _ConstructorInternal(ACBindings.StringTableMetaLanguage.NodeType Type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTableMetaLanguage.Node, ACBindings.StringTableMetaLanguage.NodeType, void>)0x0067E8F0)(ref this, Type);
    // void __thiscall StringTableMetaLanguage::Node::~Node(StringTableMetaLanguage::Node*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTableMetaLanguage.Node, void>)0x0067E950)(ref this);
}

