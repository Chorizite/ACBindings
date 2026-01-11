namespace ACBindings.Internal;

public unsafe struct MovementSystem
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x006B1820
    /// float __cdecl MovementSystem::GetRunRate(const float,const int,const float)</code>
    /// </summary>
    public static float GetRunRate(float load, int runskill, float scaling) => ((delegate* unmanaged[Cdecl]<float, int, float, float>)0x006B1820)(load, runskill, scaling);

    /// <summary>
    /// <code>Offset: 0x006B1880
    /// float __cdecl MovementSystem::GetJumpHeight(const float,const int,const float,const float)</code>
    /// </summary>
    public static float GetJumpHeight(float load, int jumpskill, float power, float scaling) => ((delegate* unmanaged[Cdecl]<float, int, float, float, float>)0x006B1880)(load, jumpskill, power, scaling);

    /// <summary>
    /// <code>Offset: 0x006B1910
    /// int __cdecl MovementSystem::JumpStaminaCost(float,float,int)</code>
    /// </summary>
    public static int JumpStaminaCost(float power, float load, int bPK) => ((delegate* unmanaged[Cdecl]<float, float, int, int>)0x006B1910)(power, load, bPK);
}

