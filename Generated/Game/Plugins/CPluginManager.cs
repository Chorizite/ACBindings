namespace ACBindings;

// CPluginManager
public unsafe struct CPluginManager
{
    // Members
    public ACBindings.SmartArray__CPluginPrototype_ptr m_Plugins;

    // Methods
    // bool __thiscall CPluginManager::RemovePluginPrototype(CPluginManager*,CPluginPrototype*)
    public byte RemovePluginPrototype(ACBindings.CPluginPrototype* pPlugin) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPluginManager, ACBindings.CPluginPrototype*, byte>)0x0040E340)(ref this, pPlugin);
    // bool __thiscall CPluginManager::AddPluginPrototype(CPluginManager*,CPluginPrototype*)
    public byte AddPluginPrototype(ACBindings.CPluginPrototype* pPlugin) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPluginManager, ACBindings.CPluginPrototype*, byte>)0x0040E4E0)(ref this, pPlugin);
}

