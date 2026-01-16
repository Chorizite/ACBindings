namespace ACBindings.Internal;


/// <summary>Encapsulates an enumeration entry, storing its name, header index, assignment status, scope flags (client/server/internal), symbol, source file, comment string, and a reference to related data node.</summary>
public unsafe struct PEnum
{
    // Members
    public ACBindings.Internal.PStringBase__sbyte m_str;
    public ACBindings.Internal._DEC988EAE5BED182094ACFC0893DFC8E ___u1;
    public ushort m_headerIndex;
    public byte m_assigned_value;
    public byte m_forced_value;
    public byte m_client;
    public byte m_server;
    public byte m_internal;
    public ACBindings.Internal.PStringBase__sbyte m_symbol;
    public ACBindings.Internal.PStringBase__sbyte m_filename;
    public ACBindings.Internal.PStringBase__sbyte m_comment_string;
    public ACBindings.Internal.PFileNode* m_data_node;

    // Methods
}

