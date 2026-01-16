namespace ACBindings.Internal;


/// <summary>Specifies metadata and callbacks used to create COM components, including the name string, class ID, factory function, initializer routine, and an optional filter pointer.</summary>
public unsafe struct CFactoryTemplate
{
    // Members
    public ushort* m_Name;
    public ACBindings.Internal._GUID* m_ClsID;
    public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, int*, ACBindings.Internal.CUnknown*> m_lpfnNew; // function pointer
    public static delegate* unmanaged[Stdcall]<int, ACBindings.Internal._GUID*, void> m_lpfnInit; // function pointer
    public System.IntPtr m_pAMovieSetup_Filter;

    // Methods
}

