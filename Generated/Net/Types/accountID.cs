namespace ACBindings.Internal;

public unsafe struct accountID
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte BaseClass_AC1Legacy_PStringBase; // ACBindings.Internal.AC1Legacy.PStringBase__sbyte

    // Members
    public int fIsDarkMajestyExpansion_;
    public int m_fIsThroneOfDestinyExpansion;
    public int m_fPreOrderedThroneOfDestinyExpansion;

    // Generated Constructor
    public accountID(ACBindings.Internal.accountID* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004E9280
    /// void __thiscall accountID::accountID(accountID*,const accountID*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.accountID* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.accountID, ACBindings.Internal.accountID*, void>)0x004E9280)(ref this, rhs);
}

