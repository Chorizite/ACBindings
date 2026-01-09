namespace ACBindings;

// HousePaymentList
public unsafe struct HousePaymentList : System.IDisposable
{
    // Base Classes
    public ACBindings.PackableList__HousePayment BaseClass_PackableList; // ACBindings.PackableList__HousePayment

    // Child Types
    // HousePaymentList_vtbl
    public unsafe struct HousePaymentList_vtbl
    {
        // Members
        public System.IntPtr HousePaymentList_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall HousePaymentList::ClearPayment(HousePaymentList*)
    public int ClearPayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePaymentList, int>)0x005BB7C0)(ref this);
    // int __thiscall HousePaymentList::IsPaidInFull(HousePaymentList*)
    public int IsPaidInFull() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePaymentList, int>)0x005BB7E0)(ref this);
    // int __thiscall HousePaymentList::RemovePayment(HousePaymentList*,const HousePayment*)
    public int RemovePayment(ACBindings.HousePayment* remove) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePaymentList, ACBindings.HousePayment*, int>)0x005BB800)(ref this, remove);
    // BOOL __thiscall HousePaymentList::NeedsMore(_DWORD*,int)
    public byte NeedsMore(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePaymentList, int, byte>)0x005BB8D0)(ref this, a2);
    // int __thiscall HousePaymentList::AttemptToPay(_DWORD*,int,int)
    public int AttemptToPay(int a2, int amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePaymentList, int, int, int>)0x005BB990)(ref this, a2, amount);
    // int __thiscall HousePaymentList::Pay(HousePaymentList*,const HousePayment*)
    public int Pay(ACBindings.HousePayment* pay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePaymentList, ACBindings.HousePayment*, int>)0x005BBB90)(ref this, pay);
    // void __thiscall HousePaymentList::~HousePaymentList(HousePaymentList*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePaymentList, void>)0x005BBFE0)(ref this);
    // int __thiscall HousePaymentList::ComposeText(_DWORD*,int)
    public int ComposeText(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePaymentList, int, int>)0x005BC210)(ref this, a2);
    // int __thiscall HousePaymentList::ComposeText2(_DWORD*,int)
    public int ComposeText2(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePaymentList, int, int>)0x005BC2A0)(ref this, a2);
}

