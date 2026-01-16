namespace ACBindings.Internal;


/// <summary>Captures alias information including identifier, associated value(s), numeric representation, header index, symbol form, and descriptive comments.</summary>
/// <remarks>Used within the system to map symbolic names to concrete values, facilitating code generation or debugging tasks that require detailed alias metadata.</remarks>
public unsafe struct PAlias
{
    // Members
    public ACBindings.Internal.PStringBase__sbyte m_str;
    public ACBindings.Internal.SmartArray___PStringBase__sbyte m_val;
    public ulong m_realVal;
    public ushort m_headerIndex;
    public ACBindings.Internal.PStringBase__sbyte m_symbol;
    public ACBindings.Internal.PStringBase__sbyte m_comment_string;
    public ACBindings.Internal.PStringBase__sbyte m_gen_comment;

    // Methods
}

