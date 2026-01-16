namespace ACBindings.Internal;


/// <summary>Iterates through child nodes of a file node, maintaining the current position and optional search criteria.</summary>
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

    /// <summary>Returns the file node currently referenced by the iterator, resolving any sub‑node index via the underlying node’s virtual method.
    /// <code>Offset: 0x0065C810
    /// const PFileNode* __thiscall PFileNodeIter::Curr(PFileNodeIter*)</code>
    /// </summary>
    /// <returns>A pointer to the current PFileNode, or nullptr when the iterator has no node.</returns>
    public ACBindings.Internal.PFileNode* Curr() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNodeIter, ACBindings.Internal.PFileNode*>)0x0065C810)(ref this);

    /// <summary>Releases the resources held by the iterator's search string, decrementing its reference count and freeing memory when no longer used.
    /// <code>Offset: 0x0065CAE0
    /// void __thiscall PFileNodeIter::~PFileNodeIter(PFileNodeIter*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNodeIter, void>)0x0065CAE0)(ref this);

    /// <summary>Advances the iteration over a file node's children and returns the next child node.
    /// <code>Offset: 0x0065CB10
    /// const PFileNode* __thiscall PFileNodeIter::Next(PFileNodeIter*)</code>
    /// </summary>
    /// <returns>A pointer to the subsequent <c>PFileNode</c> in the current iteration, or <c>nullptr</c> when no further nodes remain.</returns>
    public ACBindings.Internal.PFileNode* Next() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNodeIter, ACBindings.Internal.PFileNode*>)0x0065CB10)(ref this);

    /// <summary>Initializes the iterator for a specified file node, resetting its index and search state.
    /// <code>Offset: 0x0065CF90
    /// void __thiscall PFileNodeIter::PFileNodeIter(PFileNodeIter*,const PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The file node to iterate over.</param>
    public void _ConstructorInternal(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNodeIter, ACBindings.Internal.PFileNode*, void>)0x0065CF90)(ref this, file_node);
}

