namespace ACBindings.Internal;

public unsafe struct CreatureMode : System.IDisposable
{
    // Members
    public ACBindings.Internal.SmartArray___CPhysicsObj_ptr creature_mode_objects;
    public ACBindings.Internal.SmartArray___LIGHTINFO_ptr creature_mode_lights;
    public ACBindings.Internal.CEnvCell* creature_cell;
    public ACBindings.Internal.Frame creature_view_frame;
    public ACBindings.Internal.RGBColor m_clrAmbientLight;
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

    /// <summary>
    /// <code>Offset: 0x004523A0
    /// void __thiscall CreatureMode::SetCameraPosition(CreatureMode*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void SetCameraPosition(ACBindings.Internal.AC1Legacy.Vector3* i_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x004523A0)(ref this, i_position);

    /// <summary>
    /// <code>Offset: 0x004523C0
    /// void __thiscall CreatureMode::UseSmartboxFOV(CreatureMode*)</code>
    /// </summary>
    public void UseSmartboxFOV() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x004523C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004523D0
    /// void __thiscall CreatureMode::UseSharpMode(CreatureMode*)</code>
    /// </summary>
    public void UseSharpMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x004523D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00452A10
    /// void __thiscall CreatureMode::Render(CreatureMode*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x00452A10)(ref this);

    /// <summary>
    /// <code>Offset: 0x004536E0
    /// bool __thiscall CreatureMode::RemoveObject(CreatureMode*,const CPhysicsObj*)</code>
    /// </summary>
    public byte RemoveObject(ACBindings.Internal.CPhysicsObj* i_pObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, ACBindings.Internal.CPhysicsObj*, byte>)0x004536E0)(ref this, i_pObject);

    /// <summary>
    /// <code>Offset: 0x00453750
    /// CPhysicsObj* __thiscall CreatureMode::GetObjectByIndex(CreatureMode*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CPhysicsObj* GetObjectByIndex(uint i_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, uint, ACBindings.Internal.CPhysicsObj*>)0x00453750)(ref this, i_index);

    /// <summary>
    /// <code>Offset: 0x00453770
    /// void __thiscall CreatureMode::SetCameraDirection(CreatureMode*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void SetCameraDirection(ACBindings.Internal.AC1Legacy.Vector3* i_direction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00453770)(ref this, i_direction);

    /// <summary>
    /// <code>Offset: 0x004537A0
    /// void __thiscall CreatureMode::SetCameraDirection_Degrees(CreatureMode*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void SetCameraDirection_Degrees(ACBindings.Internal.AC1Legacy.Vector3* i_direction_degrees) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x004537A0)(ref this, i_direction_degrees);

    /// <summary>
    /// <code>Offset: 0x00454430
    /// void __thiscall CreatureMode::CreatureMode(CreatureMode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x00454430)(ref this);

    /// <summary>
    /// <code>Offset: 0x00454490
    /// void __thiscall CreatureMode::RemoveAllObjects(CreatureMode*)</code>
    /// </summary>
    public void RemoveAllObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x00454490)(ref this);

    /// <summary>
    /// <code>Offset: 0x004544D0
    /// void __thiscall CreatureMode::RemoveAllLights(CreatureMode*)</code>
    /// </summary>
    public void RemoveAllLights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x004544D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00454560
    /// bool __thiscall CreatureMode::SetLightDirection(CreatureMode*,unsigned int,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public byte SetLightDirection(uint i_index, ACBindings.Internal.AC1Legacy.Vector3* i_direction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, uint, ACBindings.Internal.AC1Legacy.Vector3*, byte>)0x00454560)(ref this, i_index, i_direction);

    /// <summary>
    /// <code>Offset: 0x004551F0
    /// void __thiscall CreatureMode::~CreatureMode(CreatureMode*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, void>)0x004551F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00455650
    /// void __thiscall CreatureMode::AddLight(CreatureMode*,LIGHTINFO::LightType,float)</code>
    /// </summary>
    public void AddLight(ACBindings.Internal.LIGHTINFO.LightType lightType, float intensity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, ACBindings.Internal.LIGHTINFO.LightType, float, void>)0x00455650)(ref this, lightType, intensity);

    /// <summary>
    /// <code>Offset: 0x004557F0
    /// bool __thiscall CreatureMode::AddObject(CreatureMode*,CPhysicsObj*)</code>
    /// </summary>
    public byte AddObject(ACBindings.Internal.CPhysicsObj* i_pObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureMode, ACBindings.Internal.CPhysicsObj*, byte>)0x004557F0)(ref this, i_pObject);
}

