namespace ACBindings.Internal;


/// <summary>Represents a structured debug report used by the application to convey diagnostic information. It stores an optional pointer for custom user debugging data, a brief summary, an extended report text, and contextual metadata.</summary>
public unsafe struct DbgReportObject
{
    // Members
    public System.IntPtr m_pUserDebuggingData;
    public ACBindings.Internal.PStringBase__sbyte m_sSummary;
    public ACBindings.Internal.PStringBase__sbyte m_sReport;
    public ACBindings.Internal.DbgReportContext m_cContext;

    // Methods
}

