namespace ACBindings.Internal;

public unsafe struct LListBase
{
    // Members
    public ACBindings.Internal.LListData* head_;
    public ACBindings.Internal.LListData* tail_;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00556490
    /// LListData* __thiscall LListBase::RemoveTail(LListBase*)</code>
    /// </summary>
    public ACBindings.Internal.LListData* RemoveTail() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LListBase, ACBindings.Internal.LListData*>)0x00556490)(ref this);
}

