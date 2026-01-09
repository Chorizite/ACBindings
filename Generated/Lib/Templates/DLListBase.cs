namespace ACBindings;

// DLListBase
public unsafe struct DLListBase
{
    // Members
    public ACBindings.DLListData* head_;
    public ACBindings.DLListData* tail_;

    // Methods
    // void __thiscall DLListBase::InsertAfter(DLListBase*,DLListData*,DLListData*)
    public void InsertAfter(ACBindings.DLListData* to_add, ACBindings.DLListData* where) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DLListBase, ACBindings.DLListData*, ACBindings.DLListData*, void>)0x00410820)(ref this, to_add, where);
    // void __thiscall DLListBase::Remove(DLListBase*,DLListData*)
    public void Remove(ACBindings.DLListData* to_remove) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DLListBase, ACBindings.DLListData*, void>)0x00410880)(ref this, to_remove);
}

