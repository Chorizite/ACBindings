namespace ACBindings.Internal;

public unsafe struct SmartBox : System.IDisposable
{
    // Statics
    public static float* s_fViewerLightFalloff = (float*)0x00819610;
    public static uint* m_cxWindowFindPos = (uint*)0x0083DA4C;
    public static uint* m_cyWindowFindPos = (uint*)0x0083DA50;

    // Child Types
    public unsafe struct SmartBox_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SmartBox*, void> SmartBox_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SmartBox*, ACBindings.Internal.NetBlob*, int> IsReadyToDispatchEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SmartBox*, ACBindings.Internal.NetBlob*, ACBindings.Internal.NetBlobProcessedStatus> DispatchSmartBoxEvent; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public int testMode;
    public ACBindings.Internal.Position viewer;
    public ACBindings.Internal.CObjCell* viewer_cell;
    public uint head_index;
    public ACBindings.Internal.Position viewer_sought_position;
    public ACBindings.Internal.CameraManager* camera_manager;
    public ACBindings.Internal.CellManager* cell_manager;
    public ACBindings.Internal.CPhysics* physics;
    public ACBindings.Internal.CObjectMaint* m_pObjMaint;
    public ACBindings.Internal.LScape* lscape;
    public System.IntPtr ambient_sounds;
    public ACBindings.Internal.CommandInterpreter* cmdinterp;
    public int creature_mode;
    public float m_fGameFOV;
    public float m_fViewDistFOV;
    public byte m_bUseViewDistance;
    public float game_ambient_level;
    public uint game_ambient_color;
    public int game_degrades_disabled;
    public int hidden;
    public int position_update_complete;
    public int waiting_for_teleport;
    public int has_been_teleported;
    public System.IntPtr in_queue;
    public System.IntPtr netblob_list;
    public byte* position_and_movement_file;
    public uint player_id;
    public ACBindings.Internal.CPhysicsObj* player;
    public uint target_object_id;
    public delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.ObjectSelectStatus, ACBindings.Internal.tagRECT*, float, void> target_callback; // function pointer
    public uint num_cells;
    public ACBindings.Internal.CEnvCell** cells;
    public uint num_objects;
    public ACBindings.Internal.CPhysicsObj** objects;
    public delegate* unmanaged[Cdecl]<void> m_renderingCallback; // function pointer

    // Generated Constructor
    public SmartBox(int a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00451BB0
    /// NetBlobProcessedStatus __thiscall SmartBox::DispatchSmartBoxEvent(SmartBox*,NetBlob*)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus DispatchSmartBoxEvent(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, ACBindings.Internal.NetBlobProcessedStatus>)0x00451BB0)(ref this, blob);

    /// <summary>
    /// <code>Offset: 0x00451BC0
    /// VisualDesc* __thiscall SmartBox::get_player_visualdesc(SmartBox*)</code>
    /// </summary>
    public ACBindings.Internal.VisualDesc* get_player_visualdesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.VisualDesc*>)0x00451BC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00451BD0
    /// void __thiscall SmartBox::QueueBlobForObject(SmartBox*,unsigned int,NetBlob*)</code>
    /// </summary>
    public void QueueBlobForObject(uint object_id, ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, uint, ACBindings.Internal.NetBlob*, void>)0x00451BD0)(ref this, object_id, blob);

    /// <summary>
    /// <code>Offset: 0x00451BE0
    /// void __cdecl SmartBox::set_selected_object_id(unsigned int)</code>
    /// </summary>
    public static void set_selected_object_id(uint id) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00451BE0)(id);

    /// <summary>
    /// <code>Offset: 0x00451BF0
    /// bool __cdecl SmartBox::is_selected_object_in_view()</code>
    /// </summary>
    public static byte is_selected_object_in_view() => ((delegate* unmanaged[Cdecl]<byte>)0x00451BF0)();

    /// <summary>
    /// <code>Offset: 0x00451C00
    /// void __thiscall SmartBox::SetOverrideFovDistance(SmartBox*,bool,float)</code>
    /// </summary>
    public void SetOverrideFovDistance(byte fEnable, float i_vdst) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, byte, float, void>)0x00451C00)(ref this, fEnable, i_vdst);

    /// <summary>
    /// <code>Offset: 0x00451C20
    /// float __thiscall SmartBox::GetOverrideFovDistance(SmartBox*)</code>
    /// </summary>
    public float GetOverrideFovDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, float>)0x00451C20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00451C60
    /// bool __thiscall SmartBox::teleport_in_progress(SmartBox*)</code>
    /// </summary>
    public byte teleport_in_progress() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, byte>)0x00451C60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00451C80
    /// int __thiscall SmartBox::teleport_occured(SmartBox*)</code>
    /// </summary>
    public int teleport_occured() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int>)0x00451C80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00451CA0
    /// bool __cdecl SmartBox::find_object(unsigned int,unsigned int)</code>
    /// </summary>
    public static byte find_object(uint mouseX, uint mouseY) => ((delegate* unmanaged[Cdecl]<uint, uint, byte>)0x00451CA0)(mouseX, mouseY);

    /// <summary>
    /// <code>Offset: 0x00451D20
    /// unsigned int __cdecl SmartBox::get_found_object_id()</code>
    /// </summary>
    public static uint get_found_object_id() => ((delegate* unmanaged[Cdecl]<uint>)0x00451D20)();

    /// <summary>
    /// <code>Offset: 0x00451D30
    /// void __cdecl SmartBox::set_found_object(unsigned int,unsigned int)</code>
    /// </summary>
    public static void set_found_object(uint iid, uint index) => ((delegate* unmanaged[Cdecl]<uint, uint, void>)0x00451D30)(iid, index);

    /// <summary>
    /// <code>Offset: 0x00451D50
    /// void __thiscall SmartBox::SetTargettingCallback(SmartBox*,void (__cdecl*targetting_callback_func)(unsigned int, ObjectSelectStatus, const tagRECT*, const float))</code>
    /// </summary>
    public void SetTargettingCallback(delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.ObjectSelectStatus, ACBindings.Internal.tagRECT*, float, void> targetting_callback_func) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.ObjectSelectStatus, ACBindings.Internal.tagRECT*, float, void>, void>)0x00451D50)(ref this, targetting_callback_func);

    /// <summary>
    /// <code>Offset: 0x00451D60
    /// void __thiscall SmartBox::SetTargetObjectID(SmartBox*,unsigned int)</code>
    /// </summary>
    public void SetTargetObjectID(uint new_target_object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, uint, void>)0x00451D60)(ref this, new_target_object_id);

    /// <summary>
    /// <code>Offset: 0x00451D70
    /// void __thiscall SmartBox::Show(SmartBox*)</code>
    /// </summary>
    public void Show() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00451D70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00451D80
    /// void __thiscall SmartBox::Hide(SmartBox*)</code>
    /// </summary>
    public void Hide() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00451D80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00451D90
    /// int __thiscall SmartBox::SetMode(SmartBox*,int,int,int,int)</code>
    /// </summary>
    public int SetMode(int x, int y, int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, int, int, int, int>)0x00451D90)(ref this, x, y, width, height);

    /// <summary>
    /// <code>Offset: 0x00451DE0
    /// void __cdecl SmartBox::DisableDegrades(int)</code>
    /// </summary>
    public static void DisableDegrades(int disable) => ((delegate* unmanaged[Cdecl]<int, void>)0x00451DE0)(disable);

    /// <summary>
    /// <code>Offset: 0x00451DF0
    /// void __cdecl SmartBox::DisableFogging(int)</code>
    /// </summary>
    public static void DisableFogging(int disable) => ((delegate* unmanaged[Cdecl]<int, void>)0x00451DF0)(disable);

    /// <summary>
    /// <code>Offset: 0x00451E10
    /// void __thiscall SmartBox::EnableWeather(SmartBox*,int)</code>
    /// </summary>
    public void EnableWeather(int enable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, void>)0x00451E10)(ref this, enable);

    /// <summary>
    /// <code>Offset: 0x00451E30
    /// bool __thiscall SmartBox::SetDetailTexturing(SmartBox*,bool,bool)</code>
    /// </summary>
    public byte SetDetailTexturing(byte landscape, byte environment) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, byte, byte, byte>)0x00451E30)(ref this, landscape, environment);

    /// <summary>
    /// <code>Offset: 0x00451E60
    /// int __thiscall SmartBox::HandleRenderOption(SmartBox*,int,char**,const char**,const char**)</code>
    /// </summary>
    public int HandleRenderOption(int argc, sbyte** argv, sbyte** status_string, sbyte** textbox_string) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, sbyte**, sbyte**, sbyte**, int>)0x00451E60)(ref this, argc, argv, status_string, textbox_string);

    /// <summary>
    /// <code>Offset: 0x00451EA0
    /// void __thiscall SmartBox::SetDefaultFov(SmartBox*,float)</code>
    /// </summary>
    public void SetDefaultFov(float degrees) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, float, void>)0x00451EA0)(ref this, degrees);

    /// <summary>
    /// <code>Offset: 0x00451EC0
    /// int __thiscall SmartBox::is_player_outside(SmartBox*)</code>
    /// </summary>
    public int is_player_outside() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int>)0x00451EC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00451EE0
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleDeleteObject(SmartBox*,NetBlob*,unsigned int,unsigned __int16)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus HandleDeleteObject(ACBindings.Internal.NetBlob* blob, uint object_id, ushort instance_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ushort, ACBindings.Internal.NetBlobProcessedStatus>)0x00451EE0)(ref this, blob, object_id, instance_timestamp);

    /// <summary>
    /// <code>Offset: 0x00451F80
    /// int __thiscall SmartBox::UpdateVisualDesc(SmartBox*,CPhysicsObj*,const VisualDesc*,unsigned __int16)</code>
    /// </summary>
    public int UpdateVisualDesc(ACBindings.Internal.CPhysicsObj* object_, ACBindings.Internal.VisualDesc* vdesc, ushort vdesc_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.VisualDesc*, ushort, int>)0x00451F80)(ref this, object_, vdesc, vdesc_ts);

    /// <summary>
    /// <code>Offset: 0x00452000
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleSoundEvent(SmartBox*,NetBlob*,unsigned int,int,float)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus HandleSoundEvent(ACBindings.Internal.NetBlob* blob, uint object_id, int sound, float volume) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, int, float, ACBindings.Internal.NetBlobProcessedStatus>)0x00452000)(ref this, blob, object_id, sound, volume);

    /// <summary>
    /// <code>Offset: 0x00452060
    /// int __thiscall SmartBox::HandlePlayScriptID(CObjectMaint**,NetBlob*,unsigned int,int)</code>
    /// </summary>
    public int HandlePlayScriptID(ACBindings.Internal.NetBlob* blob, uint object_id, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, int, int>)0x00452060)(ref this, blob, object_id, a4);

    /// <summary>
    /// <code>Offset: 0x004520B0
    /// NetBlobProcessedStatus __thiscall SmartBox::HandlePlayScriptType(SmartBox*,NetBlob*,unsigned int,int,float)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus HandlePlayScriptType(ACBindings.Internal.NetBlob* blob, uint object_id, int script_type, float mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, int, float, ACBindings.Internal.NetBlobProcessedStatus>)0x004520B0)(ref this, blob, object_id, script_type, mod);

    /// <summary>
    /// <code>Offset: 0x00452110
    /// void __thiscall SmartBox::DoSetState(SmartBox*,CPhysicsObj*,unsigned int,unsigned __int16)</code>
    /// </summary>
    public void DoSetState(ACBindings.Internal.CPhysicsObj* object_, uint state, ushort state_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, uint, ushort, void>)0x00452110)(ref this, object_, state, state_timestamp);

    /// <summary>
    /// <code>Offset: 0x00452190
    /// NetBlobProcessedStatus __thiscall SmartBox::HandlePlayerTeleport(SmartBox*,NetBlob*,unsigned __int16)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus HandlePlayerTeleport(ACBindings.Internal.NetBlob* blob, ushort physics_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, ushort, ACBindings.Internal.NetBlobProcessedStatus>)0x00452190)(ref this, blob, physics_timestamp);

    /// <summary>
    /// <code>Offset: 0x00452200
    /// void __thiscall SmartBox::DoVectorUpdate(SmartBox*,CPhysicsObj*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,unsigned __int16)</code>
    /// </summary>
    public void DoVectorUpdate(ACBindings.Internal.CPhysicsObj* object_, ACBindings.Internal.AC1Legacy.Vector3* velocity, ACBindings.Internal.AC1Legacy.Vector3* omega, ushort vector_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ushort, void>)0x00452200)(ref this, object_, velocity, omega, vector_timestamp);

    /// <summary>
    /// <code>Offset: 0x00452280
    /// void __thiscall SmartBox::DoPickupEvent(SmartBox*,CPhysicsObj*,unsigned __int16)</code>
    /// </summary>
    public void DoPickupEvent(ACBindings.Internal.CPhysicsObj* object_, ushort position_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, ushort, void>)0x00452280)(ref this, object_, position_timestamp);

    /// <summary>
    /// <code>Offset: 0x004522D0
    /// void __thiscall SmartBox::DoParentEvent(SmartBox*,CPhysicsObj*,CPhysicsObj*,unsigned int,unsigned int,unsigned __int16)</code>
    /// </summary>
    public void DoParentEvent(ACBindings.Internal.CPhysicsObj* child, ACBindings.Internal.CPhysicsObj* parent, uint child_location, uint placement_id, ushort position_stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.CPhysicsObj*, uint, uint, ushort, void>)0x004522D0)(ref this, child, parent, child_location, placement_id, position_stamp);

    /// <summary>
    /// <code>Offset: 0x00452C80
    /// void __thiscall SmartBox::set_viewer(SmartBox*,const Position*,int)</code>
    /// </summary>
    public void set_viewer(ACBindings.Internal.Position* new_viewer, int set_sought_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.Position*, int, void>)0x00452C80)(ref this, new_viewer, set_sought_position);

    /// <summary>
    /// <code>Offset: 0x00452DA0
    /// void __thiscall SmartBox::PlayerPhysicsUpdatedCallback(SmartBox*)</code>
    /// </summary>
    public void PlayerPhysicsUpdatedCallback() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00452DA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00452DE0
    /// int __thiscall SmartBox::convert_to_player_space(SmartBox*,CPhysicsObj*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public int convert_to_player_space(ACBindings.Internal.CPhysicsObj* object_, ACBindings.Internal.AC1Legacy.Vector3* return_vector) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00452DE0)(ref this, object_, return_vector);

    /// <summary>
    /// <code>Offset: 0x00452E60
    /// ObjectSelectStatus __thiscall SmartBox::GetObjectBoundingBox(SmartBox*,unsigned int,tagRECT*,float*)</code>
    /// </summary>
    public ACBindings.Internal.ObjectSelectStatus GetObjectBoundingBox(uint object_iid, ACBindings.Internal.tagRECT* bbox, float* heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, uint, ACBindings.Internal.tagRECT*, float*, ACBindings.Internal.ObjectSelectStatus>)0x00452E60)(ref this, object_iid, bbox, heading);

    /// <summary>
    /// <code>Offset: 0x004530E0
    /// void __thiscall SmartBox::SetWorldAmbientLight(SmartBox*,float,unsigned int)</code>
    /// </summary>
    public void SetWorldAmbientLight(float intensity, uint color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, float, uint, void>)0x004530E0)(ref this, intensity, color);

    /// <summary>
    /// <code>Offset: 0x00453160
    /// int __thiscall SmartBox::SetNormalMode(SmartBox*)</code>
    /// </summary>
    public int SetNormalMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int>)0x00453160)(ref this);

    /// <summary>
    /// <code>Offset: 0x004531C0
    /// int __thiscall SmartBox::set_mid_radius(SmartBox*,int)</code>
    /// </summary>
    public int set_mid_radius(int mid_radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, int>)0x004531C0)(ref this, mid_radius);

    /// <summary>
    /// <code>Offset: 0x00453230
    /// int __thiscall SmartBox::SetRegion(SmartBox*,unsigned int)</code>
    /// </summary>
    public int SetRegion(uint region_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, uint, int>)0x00453230)(ref this, region_num);

    /// <summary>
    /// <code>Offset: 0x00453280
    /// void __thiscall SmartBox::set_viewer_home(SmartBox*)</code>
    /// </summary>
    public void set_viewer_home() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00453280)(ref this);

    /// <summary>
    /// <code>Offset: 0x00453380
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleObjDescEvent(SmartBox*,NetBlob*,unsigned int,const VisualDesc*,const PhysicsTimestampPack*)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus HandleObjDescEvent(ACBindings.Internal.NetBlob* blob, uint object_id, ACBindings.Internal.VisualDesc* vdesc, ACBindings.Internal.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ACBindings.Internal.VisualDesc*, ACBindings.Internal.PhysicsTimestampPack*, ACBindings.Internal.NetBlobProcessedStatus>)0x00453380)(ref this, blob, object_id, vdesc, timestamps);

    /// <summary>
    /// <code>Offset: 0x00453420
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleSetState(SmartBox*,NetBlob*,unsigned int,unsigned int,const PhysicsTimestampPack*)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus HandleSetState(ACBindings.Internal.NetBlob* blob, uint object_id, uint new_state, ACBindings.Internal.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, uint, ACBindings.Internal.PhysicsTimestampPack*, ACBindings.Internal.NetBlobProcessedStatus>)0x00453420)(ref this, blob, object_id, new_state, timestamps);

    /// <summary>
    /// <code>Offset: 0x004534C0
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleVectorUpdate(SmartBox*,NetBlob*,unsigned int,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,const PhysicsTimestampPack*)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus HandleVectorUpdate(ACBindings.Internal.NetBlob* blob, uint object_id, ACBindings.Internal.AC1Legacy.Vector3* velocity, ACBindings.Internal.AC1Legacy.Vector3* omega, ACBindings.Internal.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.PhysicsTimestampPack*, ACBindings.Internal.NetBlobProcessedStatus>)0x004534C0)(ref this, blob, object_id, velocity, omega, timestamps);

    /// <summary>
    /// <code>Offset: 0x00453570
    /// NetBlobProcessedStatus __thiscall SmartBox::HandlePickupEvent(SmartBox*,NetBlob*,unsigned int,const PhysicsTimestampPack*)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus HandlePickupEvent(ACBindings.Internal.NetBlob* blob, uint object_id, ACBindings.Internal.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ACBindings.Internal.PhysicsTimestampPack*, ACBindings.Internal.NetBlobProcessedStatus>)0x00453570)(ref this, blob, object_id, timestamps);

    /// <summary>
    /// <code>Offset: 0x00453610
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleParentEvent(SmartBox*,NetBlob*,unsigned int,unsigned int,unsigned int,unsigned int,const PhysicsTimestampPack*)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus HandleParentEvent(ACBindings.Internal.NetBlob* blob, uint object_id, uint child_id, uint child_location, uint placement_id, ACBindings.Internal.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, uint, uint, uint, ACBindings.Internal.PhysicsTimestampPack*, ACBindings.Internal.NetBlobProcessedStatus>)0x00453610)(ref this, blob, object_id, child_id, child_location, placement_id, timestamps);

    /// <summary>
    /// <code>Offset: 0x004538E0
    /// void __cdecl SmartBox::Cleanup(SmartBox*)</code>
    /// </summary>
    public static void Cleanup(ACBindings.Internal.SmartBox* smartbox) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SmartBox*, void>)0x004538E0)(smartbox);

    /// <summary>
    /// <code>Offset: 0x00453910
    /// void __thiscall SmartBox::PlayerPositionUpdated(SmartBox*,int,float)</code>
    /// </summary>
    public void PlayerPositionUpdated(int teleporting, float distance_moved) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, float, void>)0x00453910)(ref this, teleporting, distance_moved);

    /// <summary>
    /// <code>Offset: 0x004539B0
    /// void __thiscall SmartBox::TeleportPlayer(SmartBox*,const Position*)</code>
    /// </summary>
    public void TeleportPlayer(ACBindings.Internal.Position* new_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.Position*, void>)0x004539B0)(ref this, new_pos);

    /// <summary>
    /// <code>Offset: 0x004539E0
    /// void __thiscall SmartBox::BlipPlayer(SmartBox*,const Position*)</code>
    /// </summary>
    public void BlipPlayer(ACBindings.Internal.Position* new_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.Position*, void>)0x004539E0)(ref this, new_pos);

    /// <summary>
    /// <code>Offset: 0x00453A20
    /// void __thiscall SmartBox::QueueNetBlob(SmartBox*,NetBlob*)</code>
    /// </summary>
    public void QueueNetBlob(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, void>)0x00453A20)(ref this, blob);

    /// <summary>
    /// <code>Offset: 0x00453AB0
    /// void __thiscall SmartBox::DestroyQueuedNetBlobs(SmartBox*)</code>
    /// </summary>
    public void DestroyQueuedNetBlobs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00453AB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00453B40
    /// void __thiscall SmartBox::RenderNormalMode(SmartBox*)</code>
    /// </summary>
    public void RenderNormalMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00453B40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00453C90
    /// void __thiscall SmartBox::Reset(SmartBox*,int)</code>
    /// </summary>
    public void Reset(int clear_objects) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, void>)0x00453C90)(ref this, clear_objects);

    /// <summary>
    /// <code>Offset: 0x00453D20
    /// void __thiscall SmartBox::init_player(SmartBox*,CPhysicsObj*,int)</code>
    /// </summary>
    public void init_player(ACBindings.Internal.CPhysicsObj* player_object, int autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, int, void>)0x00453D20)(ref this, player_object, autonomous);

    /// <summary>
    /// <code>Offset: 0x00453D80
    /// void __thiscall SmartBox::update_viewer(SmartBox*)</code>
    /// </summary>
    public void update_viewer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00453D80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00454070
    /// void __thiscall SmartBox::HandleReceivedPosition(SmartBox*,CPhysicsObj*,const Position*,unsigned int,int,const AC1Legacy::Vector3*,unsigned __int16,unsigned __int16,unsigned __int16)</code>
    /// </summary>
    public void HandleReceivedPosition(ACBindings.Internal.CPhysicsObj* object_, ACBindings.Internal.Position* position, uint placement_id, int has_contact, ACBindings.Internal.AC1Legacy.Vector3* velocity, ushort position_timestamp, ushort teleport_timestamp, ushort force_position_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.Position*, uint, int, ACBindings.Internal.AC1Legacy.Vector3*, ushort, ushort, ushort, void>)0x00454070)(ref this, object_, position, placement_id, has_contact, velocity, position_timestamp, teleport_timestamp, force_position_timestamp);

    /// <summary>
    /// <code>Offset: 0x00454360
    /// NetBlobProcessedStatus __thiscall SmartBox::UnpackPositionEvent(SmartBox*,unsigned int,void**,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus UnpackPositionEvent(uint object_id, void** buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, uint, void**, uint, ACBindings.Internal.NetBlobProcessedStatus>)0x00454360)(ref this, object_id, buff, size);

    /// <summary>
    /// <code>Offset: 0x00454640
    /// char* __thiscall SmartBox::SmartBox(char*,int)</code>
    /// </summary>
    public sbyte* _ConstructorInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, sbyte*>)0x00454640)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00454920
    /// void __thiscall SmartBox::~SmartBox(SmartBox*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00454920)(ref this);

    /// <summary>
    /// <code>Offset: 0x00454B10
    /// void __thiscall SmartBox::ProcessNetBlobs(SmartBox*)</code>
    /// </summary>
    public void ProcessNetBlobs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00454B10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00454BC0
    /// void __thiscall SmartBox::ProcessObjectNetBlobs(SmartBox*,CPhysicsObj*)</code>
    /// </summary>
    public void ProcessObjectNetBlobs(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, void>)0x00454BC0)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x00454D20
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleCreateObject(SmartBox*,NetBlob*,unsigned int,const VisualDesc*,const PhysicsDesc*,const WeenieDesc*,int)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus HandleCreateObject(ACBindings.Internal.NetBlob* blob, uint object_id, ACBindings.Internal.VisualDesc* vdesc, ACBindings.Internal.PhysicsDesc* physicsdesc, ACBindings.Internal.WeenieDesc* wdesc, int force_recreate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ACBindings.Internal.VisualDesc*, ACBindings.Internal.PhysicsDesc*, ACBindings.Internal.WeenieDesc*, int, ACBindings.Internal.NetBlobProcessedStatus>)0x00454D20)(ref this, blob, object_id, vdesc, physicsdesc, wdesc, force_recreate);

    /// <summary>
    /// <code>Offset: 0x004551B0
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleCreatePlayer(SmartBox*,NetBlob*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus HandleCreatePlayer(ACBindings.Internal.NetBlob* blob, uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ACBindings.Internal.NetBlobProcessedStatus>)0x004551B0)(ref this, blob, object_id);

    /// <summary>
    /// <code>Offset: 0x00455290
    /// char __thiscall SmartBox::InitInternal(SmartBox*,int)</code>
    /// </summary>
    public sbyte InitInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, sbyte>)0x00455290)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004554B0
    /// void __thiscall SmartBox::UseTime(SmartBox*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x004554B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00455610
    /// void __thiscall SmartBox::Draw(SmartBox*)</code>
    /// </summary>
    public void Draw() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00455610)(ref this);

    /// <summary>
    /// <code>Offset: 0x00455620
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleUpdateObject(SmartBox*,NetBlob*,unsigned int,const VisualDesc*,const PhysicsDesc*,const WeenieDesc*)</code>
    /// </summary>
    public ACBindings.Internal.NetBlobProcessedStatus HandleUpdateObject(ACBindings.Internal.NetBlob* blob, uint object_id, ACBindings.Internal.VisualDesc* objdesc, ACBindings.Internal.PhysicsDesc* physicsdesc, ACBindings.Internal.WeenieDesc* wdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ACBindings.Internal.VisualDesc*, ACBindings.Internal.PhysicsDesc*, ACBindings.Internal.WeenieDesc*, ACBindings.Internal.NetBlobProcessedStatus>)0x00455620)(ref this, blob, object_id, objdesc, physicsdesc, wdesc);

    /// <summary>
    /// <code>Offset: 0x00455710
    /// int __cdecl SmartBox::Init(int,int)</code>
    /// </summary>
    public static int Init(int a1, int a2) => ((delegate* unmanaged[Cdecl]<int, int, int>)0x00455710)(a1, a2);
}

