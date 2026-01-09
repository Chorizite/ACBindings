namespace ACBindings;

// ItemUses
public unsafe struct ItemUses
{
    // Members
    public int _useable_bitfield;

    // Generated Constructor
    public ItemUses(uint useable_bitfield) {
        _ConstructorInternal(useable_bitfield);
    }

    // Methods
    // void __thiscall ItemUses::ItemUses(ItemUses*,const unsigned int)
    public void _ConstructorInternal(uint useable_bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemUses, uint, void>)0x004FD850)(ref this, useable_bitfield);
    // int __thiscall ItemUses::IsUseable(ItemUses*)
    public int IsUseable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemUses, int>)0x004FD860)(ref this);
    // ITEM_USEABLE __thiscall ItemUses::GetLeastLimitedSourceUse(ItemUses*)
    public ACBindings.ITEM_USEABLE GetLeastLimitedSourceUse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemUses, ACBindings.ITEM_USEABLE>)0x004FD870)(ref this);
    // int __thiscall ItemUses::IsUseable_Targeted(ItemUses*)
    public int IsUseable_Targeted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemUses, int>)0x004FD8B0)(ref this);
    // int __thiscall ItemUses::IsUseable_SelfTarget(ItemUses*)
    public int IsUseable_SelfTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemUses, int>)0x004FD8D0)(ref this);
    // ITEM_USEABLE __thiscall ItemUses::GetLeastLimitedTargetUse(ItemUses*)
    public ACBindings.ITEM_USEABLE GetLeastLimitedTargetUse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemUses, ACBindings.ITEM_USEABLE>)0x004FD8F0)(ref this);
}

