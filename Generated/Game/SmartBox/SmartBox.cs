namespace ACBindings;

// SmartBox
public unsafe struct SmartBox : System.IDisposable
{
    // Statics
    public static float* s_fViewerLightFalloff = (float*)0x00819610;
    public static int* click_object_index = (int*)0x00819618;
    public static uint* click_object_id = (uint*)0x0083DA44;
    public static byte* lookingForObject = (byte*)0x0083DA48;
    public static uint* m_cxWindowFindPos = (uint*)0x0083DA4C;
    public static uint* m_cyWindowFindPos = (uint*)0x0083DA50;
    public static ACBindings.SmartBox* smartbox = (ACBindings.SmartBox*)0x0083DA58;
    public static float* s_fViewerLightIntensity = (float*)0x0083DC10;

    // Child Types
    // SmartBox_vtbl
    public unsafe struct SmartBox_vtbl
    {
        // Members
        public System.IntPtr SmartBox_dtor_0; // function pointer
        public System.IntPtr IsReadyToDispatchEvent; // function pointer
        public System.IntPtr DispatchSmartBoxEvent; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public int testMode;
    public ACBindings.Position viewer;
    public ACBindings.CObjCell* viewer_cell;
    public uint head_index;
    public ACBindings.Position viewer_sought_position;
    public ACBindings.CameraManager* camera_manager;
    public ACBindings.CellManager* cell_manager;
    public ACBindings.CPhysics* physics;
    public ACBindings.CObjectMaint* m_pObjMaint;
    public ACBindings.LScape* lscape;
    public System.IntPtr ambient_sounds;
    public ACBindings.CommandInterpreter* cmdinterp;
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
    public ACBindings.CPhysicsObj* player;
    public uint target_object_id;
    public System.IntPtr target_callback; // function pointer
    public uint num_cells;
    public ACBindings.CEnvCell** cells;
    public uint num_objects;
    public ACBindings.CPhysicsObj** objects;
    public System.IntPtr m_renderingCallback; // function pointer

    // Generated Constructor
    public SmartBox(int a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // NetBlobProcessedStatus __thiscall SmartBox::DispatchSmartBoxEvent(SmartBox*,NetBlob*)
    public ACBindings.NetBlobProcessedStatus DispatchSmartBoxEvent(ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, ACBindings.NetBlobProcessedStatus>)0x00451BB0)(ref this, blob);
    // VisualDesc* __thiscall SmartBox::get_player_visualdesc(SmartBox*)
    public ACBindings.VisualDesc* get_player_visualdesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.VisualDesc*>)0x00451BC0)(ref this);
    // void __thiscall SmartBox::QueueBlobForObject(SmartBox*,unsigned int,NetBlob*)
    public void QueueBlobForObject(uint object_id, ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, uint, ACBindings.NetBlob*, void>)0x00451BD0)(ref this, object_id, blob);
    // void __cdecl SmartBox::set_selected_object_id(unsigned int)
    public static void set_selected_object_id(uint id) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00451BE0)(id);
    // bool __cdecl SmartBox::is_selected_object_in_view()
    public static byte is_selected_object_in_view() => ((delegate* unmanaged[Cdecl]<byte>)0x00451BF0)();
    // void __thiscall SmartBox::SetOverrideFovDistance(SmartBox*,bool,float)
    public void SetOverrideFovDistance(byte fEnable, float i_vdst) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, byte, float, void>)0x00451C00)(ref this, fEnable, i_vdst);
    // float __thiscall SmartBox::GetOverrideFovDistance(SmartBox*)
    public float GetOverrideFovDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, float>)0x00451C20)(ref this);
    // bool __thiscall SmartBox::teleport_in_progress(SmartBox*)
    public byte teleport_in_progress() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, byte>)0x00451C60)(ref this);
    // int __thiscall SmartBox::teleport_occured(SmartBox*)
    public int teleport_occured() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, int>)0x00451C80)(ref this);
    // bool __cdecl SmartBox::find_object(unsigned int,unsigned int)
    public static byte find_object(uint mouseX, uint mouseY) => ((delegate* unmanaged[Cdecl]<uint, uint, byte>)0x00451CA0)(mouseX, mouseY);
    // unsigned int __cdecl SmartBox::get_found_object_id()
    public static uint get_found_object_id() => ((delegate* unmanaged[Cdecl]<uint>)0x00451D20)();
    // void __cdecl SmartBox::set_found_object(unsigned int,unsigned int)
    public static void set_found_object(uint iid, uint index) => ((delegate* unmanaged[Cdecl]<uint, uint, void>)0x00451D30)(iid, index);
    // void __thiscall SmartBox::SetTargettingCallback(SmartBox*,void (__cdecl*targetting_callback_func)(unsigned int, ObjectSelectStatus, const tagRECT*, const float))
    public void SetTargettingCallback(delegate* unmanaged[Cdecl]<uint, ACBindings.ObjectSelectStatus, ACBindings.tagRECT*, float, void> targetting_callback_func) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, delegate* unmanaged[Cdecl]<uint, ACBindings.ObjectSelectStatus, ACBindings.tagRECT*, float, void>, void>)0x00451D50)(ref this, targetting_callback_func);
    // void __thiscall SmartBox::SetTargetObjectID(SmartBox*,unsigned int)
    public void SetTargetObjectID(uint new_target_object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, uint, void>)0x00451D60)(ref this, new_target_object_id);
    // void __thiscall SmartBox::Show(SmartBox*)
    public void Show() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, void>)0x00451D70)(ref this);
    // void __thiscall SmartBox::Hide(SmartBox*)
    public void Hide() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, void>)0x00451D80)(ref this);
    // int __thiscall SmartBox::SetMode(SmartBox*,int,int,int,int)
    public int SetMode(int x, int y, int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, int, int, int, int, int>)0x00451D90)(ref this, x, y, width, height);
    // void __cdecl SmartBox::DisableDegrades(int)
    public static void DisableDegrades(int disable) => ((delegate* unmanaged[Cdecl]<int, void>)0x00451DE0)(disable);
    // void __cdecl SmartBox::DisableFogging(int)
    public static void DisableFogging(int disable) => ((delegate* unmanaged[Cdecl]<int, void>)0x00451DF0)(disable);
    // void __thiscall SmartBox::EnableWeather(SmartBox*,int)
    public void EnableWeather(int enable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, int, void>)0x00451E10)(ref this, enable);
    // bool __thiscall SmartBox::SetDetailTexturing(SmartBox*,bool,bool)
    public byte SetDetailTexturing(byte landscape, byte environment) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, byte, byte, byte>)0x00451E30)(ref this, landscape, environment);
    // int __thiscall SmartBox::HandleRenderOption(SmartBox*,int,char**,const char**,const char**)
    public int HandleRenderOption(int argc, sbyte** argv, sbyte** status_string, sbyte** textbox_string) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, int, sbyte**, sbyte**, sbyte**, int>)0x00451E60)(ref this, argc, argv, status_string, textbox_string);
    // void __thiscall SmartBox::SetDefaultFov(SmartBox*,float)
    public void SetDefaultFov(float degrees) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, float, void>)0x00451EA0)(ref this, degrees);
    // int __thiscall SmartBox::is_player_outside(SmartBox*)
    public int is_player_outside() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, int>)0x00451EC0)(ref this);
    // NetBlobProcessedStatus __thiscall SmartBox::HandleDeleteObject(SmartBox*,NetBlob*,unsigned int,unsigned __int16)
    public ACBindings.NetBlobProcessedStatus HandleDeleteObject(ACBindings.NetBlob* blob, uint object_id, ushort instance_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, uint, ushort, ACBindings.NetBlobProcessedStatus>)0x00451EE0)(ref this, blob, object_id, instance_timestamp);
    // int __thiscall SmartBox::UpdateVisualDesc(SmartBox*,CPhysicsObj*,const VisualDesc*,unsigned __int16)
    public int UpdateVisualDesc(ACBindings.CPhysicsObj* object_, ACBindings.VisualDesc* vdesc, ushort vdesc_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.CPhysicsObj*, ACBindings.VisualDesc*, ushort, int>)0x00451F80)(ref this, object_, vdesc, vdesc_ts);
    // NetBlobProcessedStatus __thiscall SmartBox::HandleSoundEvent(SmartBox*,NetBlob*,unsigned int,int,float)
    public ACBindings.NetBlobProcessedStatus HandleSoundEvent(ACBindings.NetBlob* blob, uint object_id, int sound, float volume) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, uint, int, float, ACBindings.NetBlobProcessedStatus>)0x00452000)(ref this, blob, object_id, sound, volume);
    // int __thiscall SmartBox::HandlePlayScriptID(CObjectMaint**,NetBlob*,unsigned int,int)
    public int HandlePlayScriptID(ACBindings.NetBlob* blob, uint object_id, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, uint, int, int>)0x00452060)(ref this, blob, object_id, a4);
    // NetBlobProcessedStatus __thiscall SmartBox::HandlePlayScriptType(SmartBox*,NetBlob*,unsigned int,int,float)
    public ACBindings.NetBlobProcessedStatus HandlePlayScriptType(ACBindings.NetBlob* blob, uint object_id, int script_type, float mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, uint, int, float, ACBindings.NetBlobProcessedStatus>)0x004520B0)(ref this, blob, object_id, script_type, mod);
    // void __thiscall SmartBox::DoSetState(SmartBox*,CPhysicsObj*,unsigned int,unsigned __int16)
    public void DoSetState(ACBindings.CPhysicsObj* object_, uint state, ushort state_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.CPhysicsObj*, uint, ushort, void>)0x00452110)(ref this, object_, state, state_timestamp);
    // NetBlobProcessedStatus __thiscall SmartBox::HandlePlayerTeleport(SmartBox*,NetBlob*,unsigned __int16)
    public ACBindings.NetBlobProcessedStatus HandlePlayerTeleport(ACBindings.NetBlob* blob, ushort physics_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, ushort, ACBindings.NetBlobProcessedStatus>)0x00452190)(ref this, blob, physics_timestamp);
    // void __thiscall SmartBox::DoVectorUpdate(SmartBox*,CPhysicsObj*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,unsigned __int16)
    public void DoVectorUpdate(ACBindings.CPhysicsObj* object_, ACBindings.AC1Legacy.Vector3* velocity, ACBindings.AC1Legacy.Vector3* omega, ushort vector_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.CPhysicsObj*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, ushort, void>)0x00452200)(ref this, object_, velocity, omega, vector_timestamp);
    // void __thiscall SmartBox::DoPickupEvent(SmartBox*,CPhysicsObj*,unsigned __int16)
    public void DoPickupEvent(ACBindings.CPhysicsObj* object_, ushort position_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.CPhysicsObj*, ushort, void>)0x00452280)(ref this, object_, position_timestamp);
    // void __thiscall SmartBox::DoParentEvent(SmartBox*,CPhysicsObj*,CPhysicsObj*,unsigned int,unsigned int,unsigned __int16)
    public void DoParentEvent(ACBindings.CPhysicsObj* child, ACBindings.CPhysicsObj* parent, uint child_location, uint placement_id, ushort position_stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.CPhysicsObj*, ACBindings.CPhysicsObj*, uint, uint, ushort, void>)0x004522D0)(ref this, child, parent, child_location, placement_id, position_stamp);
    // void __thiscall SmartBox::set_viewer(SmartBox*,const Position*,int)
    public void set_viewer(ACBindings.Position* new_viewer, int set_sought_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.Position*, int, void>)0x00452C80)(ref this, new_viewer, set_sought_position);
    // void __thiscall SmartBox::PlayerPhysicsUpdatedCallback(SmartBox*)
    public void PlayerPhysicsUpdatedCallback() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, void>)0x00452DA0)(ref this);
    // int __thiscall SmartBox::convert_to_player_space(SmartBox*,CPhysicsObj*,AC1Legacy::Vector3*)
    public int convert_to_player_space(ACBindings.CPhysicsObj* object_, ACBindings.AC1Legacy.Vector3* return_vector) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.CPhysicsObj*, ACBindings.AC1Legacy.Vector3*, int>)0x00452DE0)(ref this, object_, return_vector);
    // ObjectSelectStatus __thiscall SmartBox::GetObjectBoundingBox(SmartBox*,unsigned int,tagRECT*,float*)
    public ACBindings.ObjectSelectStatus GetObjectBoundingBox(uint object_iid, ACBindings.tagRECT* bbox, float* heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, uint, ACBindings.tagRECT*, float*, ACBindings.ObjectSelectStatus>)0x00452E60)(ref this, object_iid, bbox, heading);
    // void __thiscall SmartBox::SetWorldAmbientLight(SmartBox*,float,unsigned int)
    public void SetWorldAmbientLight(float intensity, uint color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, float, uint, void>)0x004530E0)(ref this, intensity, color);
    // int __thiscall SmartBox::SetNormalMode(SmartBox*)
    public int SetNormalMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, int>)0x00453160)(ref this);
    // int __thiscall SmartBox::set_mid_radius(SmartBox*,int)
    public int set_mid_radius(int mid_radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, int, int>)0x004531C0)(ref this, mid_radius);
    // int __thiscall SmartBox::SetRegion(SmartBox*,unsigned int)
    public int SetRegion(uint region_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, uint, int>)0x00453230)(ref this, region_num);
    // void __thiscall SmartBox::set_viewer_home(SmartBox*)
    public void set_viewer_home() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, void>)0x00453280)(ref this);
    // NetBlobProcessedStatus __thiscall SmartBox::HandleObjDescEvent(SmartBox*,NetBlob*,unsigned int,const VisualDesc*,const PhysicsTimestampPack*)
    public ACBindings.NetBlobProcessedStatus HandleObjDescEvent(ACBindings.NetBlob* blob, uint object_id, ACBindings.VisualDesc* vdesc, ACBindings.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, uint, ACBindings.VisualDesc*, ACBindings.PhysicsTimestampPack*, ACBindings.NetBlobProcessedStatus>)0x00453380)(ref this, blob, object_id, vdesc, timestamps);
    // NetBlobProcessedStatus __thiscall SmartBox::HandleSetState(SmartBox*,NetBlob*,unsigned int,unsigned int,const PhysicsTimestampPack*)
    public ACBindings.NetBlobProcessedStatus HandleSetState(ACBindings.NetBlob* blob, uint object_id, uint new_state, ACBindings.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, uint, uint, ACBindings.PhysicsTimestampPack*, ACBindings.NetBlobProcessedStatus>)0x00453420)(ref this, blob, object_id, new_state, timestamps);
    // NetBlobProcessedStatus __thiscall SmartBox::HandleVectorUpdate(SmartBox*,NetBlob*,unsigned int,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,const PhysicsTimestampPack*)
    public ACBindings.NetBlobProcessedStatus HandleVectorUpdate(ACBindings.NetBlob* blob, uint object_id, ACBindings.AC1Legacy.Vector3* velocity, ACBindings.AC1Legacy.Vector3* omega, ACBindings.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, uint, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, ACBindings.PhysicsTimestampPack*, ACBindings.NetBlobProcessedStatus>)0x004534C0)(ref this, blob, object_id, velocity, omega, timestamps);
    // NetBlobProcessedStatus __thiscall SmartBox::HandlePickupEvent(SmartBox*,NetBlob*,unsigned int,const PhysicsTimestampPack*)
    public ACBindings.NetBlobProcessedStatus HandlePickupEvent(ACBindings.NetBlob* blob, uint object_id, ACBindings.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, uint, ACBindings.PhysicsTimestampPack*, ACBindings.NetBlobProcessedStatus>)0x00453570)(ref this, blob, object_id, timestamps);
    // NetBlobProcessedStatus __thiscall SmartBox::HandleParentEvent(SmartBox*,NetBlob*,unsigned int,unsigned int,unsigned int,unsigned int,const PhysicsTimestampPack*)
    public ACBindings.NetBlobProcessedStatus HandleParentEvent(ACBindings.NetBlob* blob, uint object_id, uint child_id, uint child_location, uint placement_id, ACBindings.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, uint, uint, uint, uint, ACBindings.PhysicsTimestampPack*, ACBindings.NetBlobProcessedStatus>)0x00453610)(ref this, blob, object_id, child_id, child_location, placement_id, timestamps);
    // void __cdecl SmartBox::Cleanup(SmartBox*)
    public static void Cleanup(ACBindings.SmartBox* smartbox) => ((delegate* unmanaged[Cdecl]<ACBindings.SmartBox*, void>)0x004538E0)(smartbox);
    // void __thiscall SmartBox::PlayerPositionUpdated(SmartBox*,int,float)
    public void PlayerPositionUpdated(int teleporting, float distance_moved) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, int, float, void>)0x00453910)(ref this, teleporting, distance_moved);
    // void __thiscall SmartBox::TeleportPlayer(SmartBox*,const Position*)
    public void TeleportPlayer(ACBindings.Position* new_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.Position*, void>)0x004539B0)(ref this, new_pos);
    // void __thiscall SmartBox::BlipPlayer(SmartBox*,const Position*)
    public void BlipPlayer(ACBindings.Position* new_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.Position*, void>)0x004539E0)(ref this, new_pos);
    // void __thiscall SmartBox::QueueNetBlob(SmartBox*,NetBlob*)
    public void QueueNetBlob(ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, void>)0x00453A20)(ref this, blob);
    // void __thiscall SmartBox::DestroyQueuedNetBlobs(SmartBox*)
    public void DestroyQueuedNetBlobs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, void>)0x00453AB0)(ref this);
    // void __thiscall SmartBox::RenderNormalMode(SmartBox*)
    public void RenderNormalMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, void>)0x00453B40)(ref this);
    // void __thiscall SmartBox::Reset(SmartBox*,int)
    public void Reset(int clear_objects) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, int, void>)0x00453C90)(ref this, clear_objects);
    // void __thiscall SmartBox::init_player(SmartBox*,CPhysicsObj*,int)
    public void init_player(ACBindings.CPhysicsObj* player_object, int autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.CPhysicsObj*, int, void>)0x00453D20)(ref this, player_object, autonomous);
    // void __thiscall SmartBox::update_viewer(SmartBox*)
    public void update_viewer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, void>)0x00453D80)(ref this);
    // void __thiscall SmartBox::HandleReceivedPosition(SmartBox*,CPhysicsObj*,const Position*,unsigned int,int,const AC1Legacy::Vector3*,unsigned __int16,unsigned __int16,unsigned __int16)
    public void HandleReceivedPosition(ACBindings.CPhysicsObj* object_, ACBindings.Position* position, uint placement_id, int has_contact, ACBindings.AC1Legacy.Vector3* velocity, ushort position_timestamp, ushort teleport_timestamp, ushort force_position_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.CPhysicsObj*, ACBindings.Position*, uint, int, ACBindings.AC1Legacy.Vector3*, ushort, ushort, ushort, void>)0x00454070)(ref this, object_, position, placement_id, has_contact, velocity, position_timestamp, teleport_timestamp, force_position_timestamp);
    // NetBlobProcessedStatus __thiscall SmartBox::UnpackPositionEvent(SmartBox*,unsigned int,void**,unsigned int)
    public ACBindings.NetBlobProcessedStatus UnpackPositionEvent(uint object_id, void** buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, uint, void**, uint, ACBindings.NetBlobProcessedStatus>)0x00454360)(ref this, object_id, buff, size);
    // char* __thiscall SmartBox::SmartBox(char*,int)
    public sbyte* _ConstructorInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, int, sbyte*>)0x00454640)(ref this, a2);
    // void __thiscall SmartBox::~SmartBox(SmartBox*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, void>)0x00454920)(ref this);
    // void __thiscall SmartBox::ProcessNetBlobs(SmartBox*)
    public void ProcessNetBlobs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, void>)0x00454B10)(ref this);
    // void __thiscall SmartBox::ProcessObjectNetBlobs(SmartBox*,CPhysicsObj*)
    public void ProcessObjectNetBlobs(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.CPhysicsObj*, void>)0x00454BC0)(ref this, object_);
    // NetBlobProcessedStatus __thiscall SmartBox::HandleCreateObject(SmartBox*,NetBlob*,unsigned int,const VisualDesc*,const PhysicsDesc*,const WeenieDesc*,int)
    public ACBindings.NetBlobProcessedStatus HandleCreateObject(ACBindings.NetBlob* blob, uint object_id, ACBindings.VisualDesc* vdesc, ACBindings.PhysicsDesc* physicsdesc, ACBindings.WeenieDesc* wdesc, int force_recreate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, uint, ACBindings.VisualDesc*, ACBindings.PhysicsDesc*, ACBindings.WeenieDesc*, int, ACBindings.NetBlobProcessedStatus>)0x00454D20)(ref this, blob, object_id, vdesc, physicsdesc, wdesc, force_recreate);
    // NetBlobProcessedStatus __thiscall SmartBox::HandleCreatePlayer(SmartBox*,NetBlob*,unsigned int)
    public ACBindings.NetBlobProcessedStatus HandleCreatePlayer(ACBindings.NetBlob* blob, uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, uint, ACBindings.NetBlobProcessedStatus>)0x004551B0)(ref this, blob, object_id);
    // char __thiscall SmartBox::InitInternal(SmartBox*,int)
    public sbyte InitInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, int, sbyte>)0x00455290)(ref this, a2);
    // void __thiscall SmartBox::UseTime(SmartBox*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, void>)0x004554B0)(ref this);
    // void __thiscall SmartBox::Draw(SmartBox*)
    public void Draw() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, void>)0x00455610)(ref this);
    // NetBlobProcessedStatus __thiscall SmartBox::HandleUpdateObject(SmartBox*,NetBlob*,unsigned int,const VisualDesc*,const PhysicsDesc*,const WeenieDesc*)
    public ACBindings.NetBlobProcessedStatus HandleUpdateObject(ACBindings.NetBlob* blob, uint object_id, ACBindings.VisualDesc* objdesc, ACBindings.PhysicsDesc* physicsdesc, ACBindings.WeenieDesc* wdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBox, ACBindings.NetBlob*, uint, ACBindings.VisualDesc*, ACBindings.PhysicsDesc*, ACBindings.WeenieDesc*, ACBindings.NetBlobProcessedStatus>)0x00455620)(ref this, blob, object_id, objdesc, physicsdesc, wdesc);
    // int __cdecl SmartBox::Init(int,int)
    public static int Init(int a1, int a2) => ((delegate* unmanaged[Cdecl]<int, int, int>)0x00455710)(a1, a2);
}

