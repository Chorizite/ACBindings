namespace ACBindings;

// CreatureMode
public unsafe struct CreatureMode : System.IDisposable
{
    // Members
    public ACBindings.SmartArray__CPhysicsObj_ptr creature_mode_objects;
    public ACBindings.SmartArray__LIGHTINFO_ptr creature_mode_lights;
    public ACBindings.CEnvCell* creature_cell;
    public ACBindings.Frame creature_view_frame;
    public ACBindings.RGBColor m_clrAmbientLight;
    public float m_fFOVRadians;
    public byte m_bUseSmartboxFOV;
    public byte m_bUseSharpMode;

    // Generated Constructor
    public CreatureMode() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CreatureMode::SetCameraPosition(CreatureMode*,const AC1Legacy::Vector3*)
    public void SetCameraPosition(ACBindings.AC1Legacy.Vector3* i_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, ACBindings.AC1Legacy.Vector3*, void>)0x004523A0)(ref this, i_position);
    // void __thiscall CreatureMode::UseSmartboxFOV(CreatureMode*)
    public void UseSmartboxFOV() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, void>)0x004523C0)(ref this);
    // void __thiscall CreatureMode::UseSharpMode(CreatureMode*)
    public void UseSharpMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, void>)0x004523D0)(ref this);
    // void __thiscall CreatureMode::Render(CreatureMode*)
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, void>)0x00452A10)(ref this);
    // bool __thiscall CreatureMode::RemoveObject(CreatureMode*,const CPhysicsObj*)
    public byte RemoveObject(ACBindings.CPhysicsObj* i_pObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, ACBindings.CPhysicsObj*, byte>)0x004536E0)(ref this, i_pObject);
    // CPhysicsObj* __thiscall CreatureMode::GetObjectByIndex(CreatureMode*,unsigned int)
    public ACBindings.CPhysicsObj* GetObjectByIndex(uint i_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, uint, ACBindings.CPhysicsObj*>)0x00453750)(ref this, i_index);
    // void __thiscall CreatureMode::SetCameraDirection(CreatureMode*,const AC1Legacy::Vector3*)
    public void SetCameraDirection(ACBindings.AC1Legacy.Vector3* i_direction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, ACBindings.AC1Legacy.Vector3*, void>)0x00453770)(ref this, i_direction);
    // void __thiscall CreatureMode::SetCameraDirection_Degrees(CreatureMode*,const AC1Legacy::Vector3*)
    public void SetCameraDirection_Degrees(ACBindings.AC1Legacy.Vector3* i_direction_degrees) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, ACBindings.AC1Legacy.Vector3*, void>)0x004537A0)(ref this, i_direction_degrees);
    // void __thiscall CreatureMode::CreatureMode(CreatureMode*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, void>)0x00454430)(ref this);
    // void __thiscall CreatureMode::RemoveAllObjects(CreatureMode*)
    public void RemoveAllObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, void>)0x00454490)(ref this);
    // void __thiscall CreatureMode::RemoveAllLights(CreatureMode*)
    public void RemoveAllLights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, void>)0x004544D0)(ref this);
    // bool __thiscall CreatureMode::SetLightDirection(CreatureMode*,unsigned int,const AC1Legacy::Vector3*)
    public byte SetLightDirection(uint i_index, ACBindings.AC1Legacy.Vector3* i_direction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, uint, ACBindings.AC1Legacy.Vector3*, byte>)0x00454560)(ref this, i_index, i_direction);
    // void __thiscall CreatureMode::~CreatureMode(CreatureMode*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, void>)0x004551F0)(ref this);
    // void __thiscall CreatureMode::AddLight(CreatureMode*,LIGHTINFO::LightType,float)
    public void AddLight(ACBindings.LIGHTINFO.LightType lightType, float intensity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, ACBindings.LIGHTINFO.LightType, float, void>)0x00455650)(ref this, lightType, intensity);
    // bool __thiscall CreatureMode::AddObject(CreatureMode*,CPhysicsObj*)
    public byte AddObject(ACBindings.CPhysicsObj* i_pObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureMode, ACBindings.CPhysicsObj*, byte>)0x004557F0)(ref this, i_pObject);
}

