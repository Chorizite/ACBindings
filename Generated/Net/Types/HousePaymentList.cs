namespace ACBindings.Internal;


/// <summary>Holds a PackableList of HousePayment objects representing payments toward a house transaction. Provides operations to check completion status, apply or remove payments, clear entries, and serialize or deserialize the list.</summary>
public unsafe struct HousePaymentList : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackableList___HousePayment BaseClass_PackableList; // ACBindings.Internal.PackableList___HousePayment

    // Child Types
    public unsafe struct HousePaymentList_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePaymentList*, void> HousePaymentList_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePaymentList*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePaymentList*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePaymentList*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Resets a field of every house payment in the list to zero.
    /// <code>Offset: 0x005BB7C0
    /// int __thiscall HousePaymentList::ClearPayment(HousePaymentList*)</code>
    /// </summary>
    /// <returns>An integer status code; always returns 1 to indicate success.</returns>
    public int ClearPayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, int>)0x005BB7C0)(ref this);

    /// <summary>Verifies that every payment in the list has been satisfied; returns true if the list is empty or all entries are complete.
    /// <code>Offset: 0x005BB7E0
    /// int __thiscall HousePaymentList::IsPaidInFull(HousePaymentList*)</code>
    /// </summary>
    /// <returns>Non‑zero when all payments are fully paid, otherwise zero.</returns>
    public int IsPaidInFull() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, int>)0x005BB7E0)(ref this);

    /// <summary>Removes a specified payment from the house payment list by decreasing its stored amount or eliminating it when depleted.
    /// <code>Offset: 0x005BB800
    /// int __thiscall HousePaymentList::RemovePayment(HousePaymentList*,const HousePayment*)</code>
    /// </summary>
    /// <param name="remove">The HousePayment to remove. The function searches for an entry with matching ID and adjusts the quantity accordingly.</param>
    /// <returns>1 if the payment was successfully removed; 0 if no matching payment exists or removal could not be performed.</returns>
    public int RemovePayment(ACBindings.Internal.HousePayment* remove) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, ACBindings.Internal.HousePayment*, int>)0x005BB800)(ref this, remove);

    /// <summary>Determines whether the house payment list still needs more entries of a given item type, respecting per‑type maximums and special handling for trade note coin stacks.
    /// <code>Offset: 0x005BB8D0
    /// BOOL __thiscall HousePaymentList::NeedsMore(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">The identifier (class ID) of the item to check within the list.</param>
    /// <returns>True if additional items of that type are required; otherwise, false.</returns>
    public byte NeedsMore(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, int, byte>)0x005BB8D0)(ref this, a2);

    /// <summary>Applies a specified amount of payment using the wallet class ID a2 toward an existing house payment entry, handling trade‑note logic and preventing overpayment.
    /// <code>Offset: 0x005BB990
    /// int __thiscall HousePaymentList::AttemptToPay(_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="a2">The wallet class identifier to use for the payment.</param>
    /// <param name="amount">The amount of units intended for payment.</param>
    /// <returns>Number of units actually paid; zero if no matching entry is found, payment exceeds remaining balance, or the payment cannot be processed.</returns>
    public int AttemptToPay(int a2, int amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, int, int, int>)0x005BB990)(ref this, a2, amount);

    /// <summary>Attempts to process a house payment using the specified HousePayment details.
    /// <code>Offset: 0x005BBB90
    /// int __thiscall HousePaymentList::Pay(HousePaymentList*,const HousePayment*)</code>
    /// </summary>
    /// <param name="pay">The HousePayment containing the item ID and amount to be paid.</param>
    /// <returns>Non-zero if the payment was applied successfully; otherwise zero.</returns>
    public int Pay(ACBindings.Internal.HousePayment* pay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, ACBindings.Internal.HousePayment*, int>)0x005BBB90)(ref this, pay);

    /// <summary>Destroys a HousePaymentList instance, freeing any stored HousePayment objects and resetting virtual tables appropriately.
    /// <code>Offset: 0x005BBFE0
    /// void __thiscall HousePaymentList::~HousePaymentList(HousePaymentList*)</code>
    /// </summary>
    /// <param name="this">Pointer to the HousePaymentList object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, void>)0x005BBFE0)(ref this);

    /// <summary>Builds a comma‑separated representation of all payments in the list, writing the result into the supplied string buffer.
    /// <code>Offset: 0x005BC210
    /// int __thiscall HousePaymentList::ComposeText(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a mutable string buffer that receives the composed text.</param>
    /// <returns>Zero on success (the function always returns 0).</returns>
    public int ComposeText(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, int, int>)0x005BC210)(ref this, a2);

    /// <summary>Appends each house payment’s representation to the supplied text buffer, separating entries with commas; removes a leading separator after processing.
    /// <code>Offset: 0x005BC2A0
    /// int __thiscall HousePaymentList::ComposeText2(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">The string buffer that receives the composed list of payments.</param>
    /// <returns>Zero on success.</returns>
    public int ComposeText2(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, int, int>)0x005BC2A0)(ref this, a2);
}

