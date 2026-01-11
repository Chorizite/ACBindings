namespace ACBindings.Internal;

public unsafe struct VitaeSystem
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x005C9FB0
    /// unsigned int __cdecl VitaeSystem::VitaeCPPoolThreshold(float,unsigned int)</code>
    /// </summary>
    public static uint VitaeCPPoolThreshold(float cur_vitae, uint level) => ((delegate* unmanaged[Cdecl]<float, uint, uint>)0x005C9FB0)(cur_vitae, level);
}

