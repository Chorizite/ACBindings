namespace ACBindings.Internal;

public unsafe struct GameSky : System.IDisposable
{
    // Statics
    public static double* s_timeAdjustment = (double*)0x00842970;

    // Members
    public ACBindings.Internal.AC1Legacy.SmartArray___CelestialPosition sky_obj_pos;
    public ACBindings.Internal.AC1Legacy.SmartArray___CPhysicsObj_ptr sky_obj;
    public ACBindings.Internal.AC1Legacy.SmartArray__uint property_array;
    public ACBindings.Internal.CEnvCell* before_sky_cell;
    public ACBindings.Internal.CEnvCell* after_sky_cell;

    // Generated Constructor
    public GameSky() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00507830
    /// void __thiscall GameSky::UpdatePosition(GameSky*,const Position*)</code>
    /// </summary>
    public void UpdatePosition(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, ACBindings.Internal.Position*, void>)0x00507830)(ref this, p);

    /// <summary>
    /// <code>Offset: 0x00507940
    /// CPhysicsObj* __thiscall GameSky::MakeObject(CObjCell**,int,float*,int,int)</code>
    /// </summary>
    public ACBindings.Internal.CPhysicsObj* MakeObject(int a2, float* a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, int, float*, int, int, ACBindings.Internal.CPhysicsObj*>)0x00507940)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x005079E0
    /// void __thiscall GameSky::CalcFrame(GameSky*,Frame*,float,float)</code>
    /// </summary>
    public void CalcFrame(ACBindings.Internal.Frame* dummy_frame, float heading, float rotation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, ACBindings.Internal.Frame*, float, float, void>)0x005079E0)(ref this, dummy_frame, heading, rotation);

    /// <summary>
    /// <code>Offset: 0x00507A50
    /// void __thiscall GameSky::Draw(GameSky*,int)</code>
    /// </summary>
    public void Draw(int after) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, int, void>)0x00507A50)(ref this, after);

    /// <summary>
    /// <code>Offset: 0x00507B80
    /// LONG GameSky::OnTimeAdjustment()</code>
    /// </summary>
    public static int OnTimeAdjustment() => ((delegate* unmanaged[Cdecl]<int>)0x00507B80)();

    /// <summary>
    /// <code>Offset: 0x00507C50
    /// void __thiscall GameSky::GameSky(GameSky*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, void>)0x00507C50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00507D40
    /// void __thiscall GameSky::~GameSky(GameSky*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, void>)0x00507D40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00507E20
    /// void __thiscall GameSky::CreateDeletePhysicsObjects(GameSky*)</code>
    /// </summary>
    public void CreateDeletePhysicsObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, void>)0x00507E20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00508010
    /// void __thiscall GameSky::UseTime(GameSky*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, void>)0x00508010)(ref this);

    /// <summary>
    /// <code>Offset: 0x005081C0
    /// void __thiscall GameSky::SetInactive(GameSky*)</code>
    /// </summary>
    public void SetInactive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameSky, void>)0x005081C0)(ref this);
}

