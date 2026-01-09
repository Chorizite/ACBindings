namespace ACBindings;

// VitaeSystem
public unsafe struct VitaeSystem
{
    // Methods
    // unsigned int __cdecl VitaeSystem::VitaeCPPoolThreshold(float,unsigned int)
    public static uint VitaeCPPoolThreshold(float cur_vitae, uint level) => ((delegate* unmanaged[Cdecl]<float, uint, uint>)0x005C9FB0)(cur_vitae, level);
}

