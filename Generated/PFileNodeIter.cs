namespace ACBindings;

// PFileNodeIter
public unsafe struct PFileNodeIter : System.IDisposable
{
    // Members
    public ACBindings.PFileNode* file_node;
    public uint curr_index;
    public ACBindings.PStringBase__sbyte search_string;

    // Generated Constructor
    public PFileNodeIter(ACBindings.PFileNode* file_node) {
        _ConstructorInternal(file_node);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // const PFileNode* __thiscall PFileNodeIter::Curr(PFileNodeIter*)
    public ACBindings.PFileNode* Curr() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNodeIter, ACBindings.PFileNode*>)0x0065C810)(ref this);
    // void __thiscall PFileNodeIter::~PFileNodeIter(PFileNodeIter*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNodeIter, void>)0x0065CAE0)(ref this);
    // const PFileNode* __thiscall PFileNodeIter::Next(PFileNodeIter*)
    public ACBindings.PFileNode* Next() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNodeIter, ACBindings.PFileNode*>)0x0065CB10)(ref this);
    // void __thiscall PFileNodeIter::PFileNodeIter(PFileNodeIter*,const PFileNode*)
    public void _ConstructorInternal(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNodeIter, ACBindings.PFileNode*, void>)0x0065CF90)(ref this, file_node);
}

