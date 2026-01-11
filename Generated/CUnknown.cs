namespace ACBindings.Internal;

public unsafe struct CUnknown
{
    // Base Classes
    public ACBindings.Internal.INonDelegatingUnknown BaseClass_INonDelegatingUnknown; // ACBindings.Internal.INonDelegatingUnknown

    // Child Types
    public unsafe struct CUnknown_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.CUnknown*, ACBindings.Internal._GUID*, void**, int> NonDelegatingQueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.CUnknown*, uint> NonDelegatingAddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.CUnknown*, uint> NonDelegatingRelease; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CUnknown*, void> CUnknown_dtor_c; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IUnknown* m_pUnknown;
    public int m_cRef;

    // Generated Constructor
    public CUnknown(sbyte* pName, ACBindings.Internal.IUnknown* pUnk) {
        _ConstructorInternal(pName, pUnk);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x006C1EB0
    /// void __thiscall CUnknown::CUnknown(CUnknown*,const char*,IUnknown*)</code>
    /// </summary>
    public void _ConstructorInternal(sbyte* pName, ACBindings.Internal.IUnknown* pUnk) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CUnknown, sbyte*, ACBindings.Internal.IUnknown*, void>)0x006C1EB0)(ref this, pName, pUnk);

    /// <summary>
    /// <code>Offset: 0x006C1F30
    /// unsigned int __stdcall CUnknown::NonDelegatingAddRef(CUnknown*)</code>
    /// </summary>
    public static uint NonDelegatingAddRef(ACBindings.Internal.CUnknown* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.CUnknown*, uint>)0x006C1F30)(this_);

    /// <summary>
    /// <code>Offset: 0x006C1F50
    /// unsigned int __stdcall CUnknown::NonDelegatingRelease(CUnknown*)</code>
    /// </summary>
    public static uint NonDelegatingRelease(ACBindings.Internal.CUnknown* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.CUnknown*, uint>)0x006C1F50)(this_);
}

