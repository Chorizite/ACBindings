namespace ACBindings.Internal.Turbine;


/// <summary>Optimized string container that stores up to 4096 characters directly in its own buffer, eliminating heap allocations for small strings.</summary>
public unsafe struct InplaceString__sbyte
{
    // Members
    public sbyte* m_pBuffer;
    public fixed sbyte m_buffer[4096];

    // Methods
}

