namespace ACBindings.Internal;

public unsafe struct CPluginManager
{
    // Members
    public ACBindings.Internal.SmartArray___CPluginPrototype_ptr m_Plugins;

    // Methods

    /// <summary>Removes the specified plugin prototype from this manager’s internal collection.
    /// <code>Offset: 0x0040E340
    /// bool __thiscall CPluginManager::RemovePluginPrototype(CPluginManager*,CPluginPrototype*)</code>
    /// </summary>
    /// <param name="pPlugin">The plugin prototype to remove.</param>
    /// <returns>True if the plugin was present and removed; otherwise, false.</returns>
    public byte RemovePluginPrototype(ACBindings.Internal.CPluginPrototype* pPlugin) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPluginManager, ACBindings.Internal.CPluginPrototype*, byte>)0x0040E340)(ref this, pPlugin);

    /// <summary>Adds the specified plugin prototype to this manager unless it is already associated with another manager. Calls the plugin's OnPluggedIn callback after attempting to add.
    /// <code>Offset: 0x0040E4E0
    /// bool __thiscall CPluginManager::AddPluginPrototype(CPluginManager*,CPluginPrototype*)</code>
    /// </summary>
    /// <param name="pPlugin">The plugin prototype to register with this manager.</param>
    /// <returns>True if the plugin was added or an attempt was made; false if the plugin already has a manager assigned.</returns>
    public byte AddPluginPrototype(ACBindings.Internal.CPluginPrototype* pPlugin) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPluginManager, ACBindings.Internal.CPluginPrototype*, byte>)0x0040E4E0)(ref this, pPlugin);
}

