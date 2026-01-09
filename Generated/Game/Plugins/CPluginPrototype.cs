namespace ACBindings;

// CPluginPrototype
public unsafe struct CPluginPrototype
{
    // Child Types
    // CPluginPrototype_vtbl
    public unsafe struct CPluginPrototype_vtbl
    {
        // Members
        public System.IntPtr CPluginPrototype_dtor_0; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.CPluginManager* m_pManager;

    // Methods
    // void __thiscall CPluginPrototype::OnPluggedIn(CPluginPrototype*,CPluginManager*)
    public void OnPluggedIn(ACBindings.CPluginManager* pManager) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPluginPrototype, ACBindings.CPluginManager*, void>)0x00401D80)(ref this, pManager);
}

