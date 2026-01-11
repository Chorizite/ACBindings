namespace ACBindings.Internal;

public unsafe struct HousePaymentList : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackableList___HousePayment BaseClass_PackableList; // ACBindings.Internal.PackableList___HousePayment

    // Child Types
    public unsafe struct HousePaymentList_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePaymentList*, void> HousePaymentList_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePaymentList*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePaymentList*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePaymentList*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005BB7C0
    /// int __thiscall HousePaymentList::ClearPayment(HousePaymentList*)</code>
    /// </summary>
    public int ClearPayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, int>)0x005BB7C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BB7E0
    /// int __thiscall HousePaymentList::IsPaidInFull(HousePaymentList*)</code>
    /// </summary>
    public int IsPaidInFull() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, int>)0x005BB7E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BB800
    /// int __thiscall HousePaymentList::RemovePayment(HousePaymentList*,const HousePayment*)</code>
    /// </summary>
    public int RemovePayment(ACBindings.Internal.HousePayment* remove) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, ACBindings.Internal.HousePayment*, int>)0x005BB800)(ref this, remove);

    /// <summary>
    /// <code>Offset: 0x005BB8D0
    /// BOOL __thiscall HousePaymentList::NeedsMore(_DWORD*,int)</code>
    /// </summary>
    public byte NeedsMore(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, int, byte>)0x005BB8D0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005BB990
    /// int __thiscall HousePaymentList::AttemptToPay(_DWORD*,int,int)</code>
    /// </summary>
    public int AttemptToPay(int a2, int amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, int, int, int>)0x005BB990)(ref this, a2, amount);

    /// <summary>
    /// <code>Offset: 0x005BBB90
    /// int __thiscall HousePaymentList::Pay(HousePaymentList*,const HousePayment*)</code>
    /// </summary>
    public int Pay(ACBindings.Internal.HousePayment* pay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, ACBindings.Internal.HousePayment*, int>)0x005BBB90)(ref this, pay);

    /// <summary>
    /// <code>Offset: 0x005BBFE0
    /// void __thiscall HousePaymentList::~HousePaymentList(HousePaymentList*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, void>)0x005BBFE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BC210
    /// int __thiscall HousePaymentList::ComposeText(_DWORD*,int)</code>
    /// </summary>
    public int ComposeText(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, int, int>)0x005BC210)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005BC2A0
    /// int __thiscall HousePaymentList::ComposeText2(_DWORD*,int)</code>
    /// </summary>
    public int ComposeText2(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePaymentList, int, int>)0x005BC2A0)(ref this, a2);
}

