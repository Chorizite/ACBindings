namespace ACBindings.Internal;


/// <summary>Holds a bitmask describing how an item may be used, providing methods to test general and target‑specific usability.</summary>
public unsafe struct ItemUses
{
    // Members
    public int _useable_bitfield;

    // Generated Constructor
    public ItemUses(uint useable_bitfield) {
        _ConstructorInternal(useable_bitfield);
    }

    // Methods

    /// <summary>Initializes the item use data with a specified usability bitfield.
    /// <code>Offset: 0x004FD850
    /// void __thiscall ItemUses::ItemUses(ItemUses*,const unsigned int)</code>
    /// </summary>
    /// <param name="useable_bitfield">Bitmask indicating which actions are allowed for the item.</param>
    public void _ConstructorInternal(uint useable_bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemUses, uint, void>)0x004FD850)(ref this, useable_bitfield);

    /// <summary>Determines whether the item is currently usable by inspecting its internal bitfield.
    /// <code>Offset: 0x004FD860
    /// int __thiscall ItemUses::IsUseable(ItemUses*)</code>
    /// </summary>
    /// <returns>Non‑zero if the item can be used, zero otherwise.</returns>
    public int IsUseable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemUses, int>)0x004FD860)(ref this);

    /// <summary>Returns the highest-priority usable flag from the item's bitfield, checking bits 0x20, 0x10, 8, 4 and 2 in order.
    /// <code>Offset: 0x004FD870
    /// ITEM_USEABLE __thiscall ItemUses::GetLeastLimitedSourceUse(ItemUses*)</code>
    /// </summary>
    /// <returns>The value of the first set flag among 32, 16, 8, 4, or 2; zero if none are set.</returns>
    public ACBindings.Internal.ITEM_USEABLE GetLeastLimitedSourceUse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemUses, ACBindings.Internal.ITEM_USEABLE>)0x004FD870)(ref this);

    /// <summary>Retrieves the upper‑order usage flag field from an item’s internal bitmask, indicating whether it can be used when targeted.
    /// <code>Offset: 0x004FD8B0
    /// int __thiscall ItemUses::IsUseable_Targeted(ItemUses*)</code>
    /// </summary>
    /// <returns>An integer containing the high‑16 bits of the item's useability bitfield; zero indicates that the item is not usable in a targeted context.</returns>
    public int IsUseable_Targeted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemUses, int>)0x004FD8B0)(ref this);

    /// <summary>Checks whether the item can be used for self‑targeting by inspecting a specific flag in its use‑ability bit field.
    /// <code>Offset: 0x004FD8D0
    /// int __thiscall ItemUses::IsUseable_SelfTarget(ItemUses*)</code>
    /// </summary>
    /// <returns>Non‑zero if self‑target usage is allowed, otherwise zero.</returns>
    public int IsUseable_SelfTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemUses, int>)0x004FD8D0)(ref this);

    /// <summary>Determines the lowest priority target-use flag encoded in an item's bitfield.
    /// <code>Offset: 0x004FD8F0
    /// ITEM_USEABLE __thiscall ItemUses::GetLeastLimitedTargetUse(ItemUses*)</code>
    /// </summary>
    /// <returns>The numeric value of the least limited target use (32, 16, 8, 4, 2, 128) or 0 if none are set.</returns>
    public ACBindings.Internal.ITEM_USEABLE GetLeastLimitedTargetUse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemUses, ACBindings.Internal.ITEM_USEABLE>)0x004FD8F0)(ref this);
}

