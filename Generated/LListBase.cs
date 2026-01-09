namespace ACBindings;

// LListBase
public unsafe struct LListBase
{
    // Members
    public ACBindings.LListData* head_;
    public ACBindings.LListData* tail_;

    // Methods
    // LListData* __thiscall LListBase::RemoveTail(LListBase*)
    public ACBindings.LListData* RemoveTail() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LListBase, ACBindings.LListData*>)0x00556490)(ref this);
}

