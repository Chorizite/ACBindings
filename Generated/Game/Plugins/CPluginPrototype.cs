namespace ACBindings.Internal;


/// <summary>Provides a prototype for plugins, maintaining a reference to the managing system and enabling interaction with plugin lifecycle events.</summary>
/// <remarks>The manager pointer is assigned via OnPluggedIn when the plugin registers.</remarks>
public unsafe struct CPluginPrototype
{
    // Child Types

    /// <summary>Defines the virtual function table used by CPluginPrototype objects, containing function pointers for destruction and plug‑in initialization. Enables dynamic dispatch of plugin lifecycle callbacks within the application framework.</summary>
    public unsafe struct CPluginPrototype_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CPluginPrototype*, void> CPluginPrototype_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CPluginPrototype*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer

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

