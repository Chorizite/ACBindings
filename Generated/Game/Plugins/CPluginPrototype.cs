namespace ACBindings.Internal;

public unsafe struct CPluginPrototype
{
    // Child Types
    public unsafe struct CPluginPrototype_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CPluginPrototype*, void> CPluginPrototype_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CPluginPrototype*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.CPluginManager* m_pManager;

    // Methods

    /// <summary>Stores the supplied plugin manager instance within the prototype to enable future interactions.
    /// <code>Offset: 0x00401D80
    /// void __thiscall CPluginPrototype::OnPluggedIn(CPluginPrototype*,CPluginManager*)</code>
    /// </summary>
    /// <param name="pManager">The plugin manager that has registered this prototype.</param>
    public void OnPluggedIn(ACBindings.Internal.CPluginManager* pManager) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPluginPrototype, ACBindings.Internal.CPluginManager*, void>)0x00401D80)(ref this, pManager);
}

