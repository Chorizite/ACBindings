namespace ACBindings;

// GameSky
public unsafe struct GameSky : System.IDisposable
{
    // Statics
    public static byte* s_weatherEnabled = (byte*)0x0081DD3C;
    public static double* s_timeAdjustment = (double*)0x00842970;

    // Members
    public ACBindings.AC1Legacy.SmartArray__CelestialPosition sky_obj_pos;
    public ACBindings.AC1Legacy.SmartArray__CPhysicsObj_ptr sky_obj;
    public ACBindings.AC1Legacy.SmartArray__uint property_array;
    public ACBindings.CEnvCell* before_sky_cell;
    public ACBindings.CEnvCell* after_sky_cell;

    // Generated Constructor
    public GameSky() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall GameSky::UpdatePosition(GameSky*,const Position*)
    public void UpdatePosition(ACBindings.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameSky, ACBindings.Position*, void>)0x00507830)(ref this, p);
    // CPhysicsObj* __thiscall GameSky::MakeObject(CObjCell**,int,float*,int,int)
    public ACBindings.CPhysicsObj* MakeObject(int a2, float* a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameSky, int, float*, int, int, ACBindings.CPhysicsObj*>)0x00507940)(ref this, a2, a3, a4, a5);
    // void __thiscall GameSky::CalcFrame(GameSky*,Frame*,float,float)
    public void CalcFrame(ACBindings.Frame* dummy_frame, float heading, float rotation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameSky, ACBindings.Frame*, float, float, void>)0x005079E0)(ref this, dummy_frame, heading, rotation);
    // void __thiscall GameSky::Draw(GameSky*,int)
    public void Draw(int after) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameSky, int, void>)0x00507A50)(ref this, after);
    // LONG GameSky::OnTimeAdjustment()
    public static int OnTimeAdjustment() => ((delegate* unmanaged[Cdecl]<int>)0x00507B80)();
    // void __thiscall GameSky::GameSky(GameSky*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameSky, void>)0x00507C50)(ref this);
    // void __thiscall GameSky::~GameSky(GameSky*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameSky, void>)0x00507D40)(ref this);
    // void __thiscall GameSky::CreateDeletePhysicsObjects(GameSky*)
    public void CreateDeletePhysicsObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameSky, void>)0x00507E20)(ref this);
    // void __thiscall GameSky::UseTime(GameSky*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameSky, void>)0x00508010)(ref this);
    // void __thiscall GameSky::SetInactive(GameSky*)
    public void SetInactive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameSky, void>)0x005081C0)(ref this);
}

