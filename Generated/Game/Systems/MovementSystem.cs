namespace ACBindings;

// MovementSystem
public unsafe struct MovementSystem
{
    // Methods
    // float __cdecl MovementSystem::GetRunRate(const float,const int,const float)
    public static float GetRunRate(float load, int runskill, float scaling) => ((delegate* unmanaged[Cdecl]<float, int, float, float>)0x006B1820)(load, runskill, scaling);
    // float __cdecl MovementSystem::GetJumpHeight(const float,const int,const float,const float)
    public static float GetJumpHeight(float load, int jumpskill, float power, float scaling) => ((delegate* unmanaged[Cdecl]<float, int, float, float, float>)0x006B1880)(load, jumpskill, power, scaling);
    // int __cdecl MovementSystem::JumpStaminaCost(float,float,int)
    public static int JumpStaminaCost(float power, float load, int bPK) => ((delegate* unmanaged[Cdecl]<float, float, int, int>)0x006B1910)(power, load, bPK);
}

