namespace ACBindings.Internal;


/// <summary>Represents an account identifier, storing the base string and flags indicating expansion status such as Dark Majesty and Throne of Destiny.</summary>
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

    /// <summary>Copies an existing accountID into a new instance, duplicating its identifier string and expansion flags while converting the identifier to lowercase.
    /// <code>Offset: 0x004E9280
    /// void __thiscall accountID::accountID(accountID*,const accountID*)</code>
    /// </summary>
    /// <param name="rhs">The accountID object whose data will be copied.</param>
    public void _ConstructorInternal(ACBindings.Internal.accountID* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.accountID, ACBindings.Internal.accountID*, void>)0x004E9280)(ref this, rhs);
}

