namespace ACBindings;

// CFactoryTemplate
public unsafe struct CFactoryTemplate
{
    // Members
    public ushort* m_Name;
    public ACBindings._GUID* m_ClsID;
    public System.IntPtr m_lpfnNew; // function pointer
    public System.IntPtr m_lpfnInit; // function pointer
    public System.IntPtr m_pAMovieSetup_Filter;

    // Methods
}

