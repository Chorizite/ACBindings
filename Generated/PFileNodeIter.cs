namespace ACBindings.Internal;

public unsafe struct PFileNodeIter : System.IDisposable
{
    // Members
    public ACBindings.Internal.PFileNode* file_node;
    public uint curr_index;
    public ACBindings.Internal.PStringBase__sbyte search_string;

    // Generated Constructor
    public PFileNodeIter(ACBindings.Internal.PFileNode* file_node) {
        _ConstructorInternal(file_node);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0065C810
    /// const PFileNode* __thiscall PFileNodeIter::Curr(PFileNodeIter*)</code>
    /// </summary>
    public ACBindings.Internal.PFileNode* Curr() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNodeIter, ACBindings.Internal.PFileNode*>)0x0065C810)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065CAE0
    /// void __thiscall PFileNodeIter::~PFileNodeIter(PFileNodeIter*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNodeIter, void>)0x0065CAE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065CB10
    /// const PFileNode* __thiscall PFileNodeIter::Next(PFileNodeIter*)</code>
    /// </summary>
    public ACBindings.Internal.PFileNode* Next() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNodeIter, ACBindings.Internal.PFileNode*>)0x0065CB10)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065CF90
    /// void __thiscall PFileNodeIter::PFileNodeIter(PFileNodeIter*,const PFileNode*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNodeIter, ACBindings.Internal.PFileNode*, void>)0x0065CF90)(ref this, file_node);
}

