namespace ACBindings.Internal;

public unsafe struct ItemUses
{
    // Members
    public int _useable_bitfield;

    // Generated Constructor
    public ItemUses(uint useable_bitfield) {
        _ConstructorInternal(useable_bitfield);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004FD850
    /// void __thiscall ItemUses::ItemUses(ItemUses*,const unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(uint useable_bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemUses, uint, void>)0x004FD850)(ref this, useable_bitfield);

    /// <summary>
    /// <code>Offset: 0x004FD860
    /// int __thiscall ItemUses::IsUseable(ItemUses*)</code>
    /// </summary>
    public int IsUseable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemUses, int>)0x004FD860)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FD870
    /// ITEM_USEABLE __thiscall ItemUses::GetLeastLimitedSourceUse(ItemUses*)</code>
    /// </summary>
    public ACBindings.Internal.ITEM_USEABLE GetLeastLimitedSourceUse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemUses, ACBindings.Internal.ITEM_USEABLE>)0x004FD870)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FD8B0
    /// int __thiscall ItemUses::IsUseable_Targeted(ItemUses*)</code>
    /// </summary>
    public int IsUseable_Targeted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemUses, int>)0x004FD8B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FD8D0
    /// int __thiscall ItemUses::IsUseable_SelfTarget(ItemUses*)</code>
    /// </summary>
    public int IsUseable_SelfTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemUses, int>)0x004FD8D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FD8F0
    /// ITEM_USEABLE __thiscall ItemUses::GetLeastLimitedTargetUse(ItemUses*)</code>
    /// </summary>
    public ACBindings.Internal.ITEM_USEABLE GetLeastLimitedTargetUse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemUses, ACBindings.Internal.ITEM_USEABLE>)0x004FD8F0)(ref this);
}

