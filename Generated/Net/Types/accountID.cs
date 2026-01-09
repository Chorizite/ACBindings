namespace ACBindings;

// accountID
public unsafe struct accountID
{
    // Base Classes
    public ACBindings.AC1Legacy.PStringBase__sbyte BaseClass_AC1Legacy_PStringBase; // ACBindings.AC1Legacy.PStringBase__sbyte

    // Members
    public int fIsDarkMajestyExpansion_;
    public int m_fIsThroneOfDestinyExpansion;
    public int m_fPreOrderedThroneOfDestinyExpansion;

    // Generated Constructor
    public accountID(ACBindings.accountID* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // void __thiscall accountID::accountID(accountID*,const accountID*)
    public void _ConstructorInternal(ACBindings.accountID* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.accountID, ACBindings.accountID*, void>)0x004E9280)(ref this, rhs);
}

