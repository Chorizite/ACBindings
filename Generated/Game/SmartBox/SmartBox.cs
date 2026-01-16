namespace ACBindings.Internal;


/// <summary>
/// Central component coordinating rendering, physics simulation, object lifecycle, and network event processing within the game engine.
/// </summary>
public unsafe struct SmartBox : System.IDisposable
{
    // Statics
    public static float* s_fViewerLightFalloff = (float*)0x00819610;
    public static int* click_object_index = (int*)0x00819618;
    public static uint* click_object_id = (uint*)0x0083DA44;
    public static byte* lookingForObject = (byte*)0x0083DA48;
    public static uint* m_cxWindowFindPos = (uint*)0x0083DA4C;
    public static uint* m_cyWindowFindPos = (uint*)0x0083DA50;
    public static ACBindings.Internal.SmartBox** smartbox = (ACBindings.Internal.SmartBox**)0x0083DA58;
    public static float* s_fViewerLightIntensity = (float*)0x0083DC10;

    // Child Types
    public unsafe struct SmartBox_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SmartBox*, void> SmartBox_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SmartBox*, ACBindings.Internal.NetBlob*, int> IsReadyToDispatchEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SmartBox*, ACBindings.Internal.NetBlob*, ACBindings.Internal.NetBlobProcessedStatus> DispatchSmartBoxEvent; // function pointer

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
    public static delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.ObjectSelectStatus, ACBindings.Internal.tagRECT*, float, void> target_callback; // function pointer
    public uint num_cells;
    public ACBindings.Internal.CEnvCell** cells;
    public uint num_objects;
    public ACBindings.Internal.CPhysicsObj** objects;
    public static delegate* unmanaged[Cdecl]<void> m_renderingCallback; // function pointer

    // Generated Constructor
    public SmartBox(int a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Attempts to dispatch a SmartBox event using the supplied NetBlob and reports the processing outcome.
    /// <code>Offset: 0x00451BB0
    /// NetBlobProcessedStatus __thiscall SmartBox::DispatchSmartBoxEvent(SmartBox*,NetBlob*)</code>
    /// </summary>
    /// <param name="this">The SmartBox instance handling the event dispatch.</param>
    /// <param name="blob">The NetBlob containing event data; this implementation does not use its contents.</param>
    /// <returns>A NetBlobProcessedStatus value. The current implementation always returns 3, indicating a fixed processing status regardless of the blob content.</returns>
    public ACBindings.Internal.NetBlobProcessedStatus DispatchSmartBoxEvent(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, ACBindings.Internal.NetBlobProcessedStatus>)0x00451BB0)(ref this, blob);

    /// <summary>Retrieves a VisualDesc pointer by invoking IUnknown_AddRef on m_pObjMaint and casting the returned reference count to a VisualDesc*.
    /// <code>Offset: 0x00451BC0
    /// VisualDesc* __thiscall SmartBox::get_player_visualdesc(SmartBox*)</code>
    /// </summary>
    /// <returns>A VisualDesc* that is actually the integer reference count cast to a pointer; this may not point to valid visual description data.</returns>
    public ACBindings.Internal.VisualDesc* get_player_visualdesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.VisualDesc*>)0x00451BC0)(ref this);

    /// <summary>Queues a NetBlob to be transmitted for the specified object ID.
    /// <code>Offset: 0x00451BD0
    /// void __thiscall SmartBox::QueueBlobForObject(SmartBox*,unsigned int,NetBlob*)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the target game object.</param>
    /// <param name="blob">Network packet containing data to send.</param>
    public void QueueBlobForObject(uint object_id, ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, uint, ACBindings.Internal.NetBlob*, void>)0x00451BD0)(ref this, object_id, blob);

    /// <summary>Sets the identifier of the object currently selected for view‑cone checks.
    /// <code>Offset: 0x00451BE0
    /// void __cdecl SmartBox::set_selected_object_id(unsigned int)</code>
    /// </summary>
    /// <param name="id">The unique ID of the object to be selected.</param>
    public static void set_selected_object_id(uint id) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00451BE0)(id);

    /// <summary>Determines whether the currently selected physics object is visible in the current view.
    /// <code>Offset: 0x00451BF0
    /// bool __cdecl SmartBox::is_selected_object_in_view()</code>
    /// </summary>
    /// <returns>True if a selected object exists and lies within the camera’s view; otherwise false.</returns>
    public static byte is_selected_object_in_view() => ((delegate* unmanaged[Cdecl]<byte>)0x00451BF0)();

    /// <summary>Enables or disables overriding the camera's field‑of‑view distance and sets the override value when enabled.
    /// <code>Offset: 0x00451C00
    /// void __thiscall SmartBox::SetOverrideFovDistance(SmartBox*,bool,float)</code>
    /// </summary>
    /// <param name="fEnable">True to activate the override, false to use default calculation.</param>
    /// <param name="i_vdst">The desired view‑distance in units for the overridden field of view.</param>
    public void SetOverrideFovDistance(byte fEnable, float i_vdst) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, byte, float, void>)0x00451C00)(ref this, fEnable, i_vdst);

    /// <summary>Calculates the effective field‑of‑view distance used by the camera. If the box’s view‑distance flag is set, returns the preconfigured distance; otherwise derives a distance from the current game FOV and the renderer’s scale.
    /// <code>Offset: 0x00451C20
    /// float __thiscall SmartBox::GetOverrideFovDistance(SmartBox*)</code>
    /// </summary>
    /// <returns>The override field‑of‑view distance as a floating‑point value.</returns>
    public float GetOverrideFovDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, float>)0x00451C20)(ref this);

    /// <summary>Determines whether a teleport operation is currently in progress by checking the presence of a player and completion status of position updates.
    /// <code>Offset: 0x00451C60
    /// bool __thiscall SmartBox::teleport_in_progress(SmartBox*)</code>
    /// </summary>
    /// <returns>True when a teleport has started but not yet finished; otherwise false.</returns>
    public byte teleport_in_progress() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, byte>)0x00451C60)(ref this);

    /// <summary>Reports whether the object has been teleported since the previous query and clears the flag.
    /// <code>Offset: 0x00451C80
    /// int __thiscall SmartBox::teleport_occured(SmartBox*)</code>
    /// </summary>
    /// <returns>The value of has_been_teleported before it was reset (non‑zero if a teleport occurred).</returns>
    public int teleport_occured() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int>)0x00451C80)(ref this);

    /// <summary>Prepares a click at the specified screen coordinates and updates the rendering cursor if the point lies within the visible viewport. If outside the viewport, clears the selection cursor.
    /// <code>Offset: 0x00451CA0
    /// bool __cdecl SmartBox::find_object(unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="mouseX">Horizontal coordinate of the mouse click relative to the window's origin.</param>
    /// <param name="mouseY">Vertical coordinate of the mouse click relative to the window's origin.</param>
    /// <returns>True when the coordinates are within the render area and a selection cursor is set; otherwise false, indicating no object was selected.</returns>
    public static byte find_object(uint mouseX, uint mouseY) => ((delegate* unmanaged[Cdecl]<uint, uint, byte>)0x00451CA0)(mouseX, mouseY);

    /// <summary>Retrieves the identifier of the most recently clicked or selected object.
    /// <code>Offset: 0x00451D20
    /// unsigned int __cdecl SmartBox::get_found_object_id()</code>
    /// </summary>
    /// <returns>The unsigned integer ID representing the found object.</returns>
    public static uint get_found_object_id() => ((delegate* unmanaged[Cdecl]<uint>)0x00451D20)();

    /// <summary>Records the specified object's ID and its index as found and sends a UI notification.
    /// <code>Offset: 0x00451D30
    /// void __cdecl SmartBox::set_found_object(unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="iid">Unique identifier of the object that was found.</param>
    /// <param name="index">Position or index of the object within the current context.</param>
    public static void set_found_object(uint iid, uint index) => ((delegate* unmanaged[Cdecl]<uint, uint, void>)0x00451D30)(iid, index);

    /// <summary>Assigns a callback invoked during target selection events.
    /// <code>Offset: 0x00451D50
    /// void __thiscall SmartBox::SetTargettingCallback(SmartBox*,void (__cdecl*targetting_callback_func)(unsigned int, ObjectSelectStatus, const tagRECT*, const float))</code>
    /// </summary>
    /// <param name="targetting_callback_func">Function pointer to receive the target ID, status, bounding rectangle and a float value related to targeting.</param>
    public void SetTargettingCallback(delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.ObjectSelectStatus, ACBindings.Internal.tagRECT*, float, void> targetting_callback_func) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.ObjectSelectStatus, ACBindings.Internal.tagRECT*, float, void>, void>)0x00451D50)(ref this, targetting_callback_func);

    /// <summary>Assigns a new target object identifier to the SmartBox instance.
    /// <code>Offset: 0x00451D60
    /// void __thiscall SmartBox::SetTargetObjectID(SmartBox*,unsigned int)</code>
    /// </summary>
    /// <param name="new_target_object_id">The unique identifier of the target object.</param>
    public void SetTargetObjectID(uint new_target_object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, uint, void>)0x00451D60)(ref this, new_target_object_id);

    /// <summary>Makes the SmartBox visible by clearing its hidden flag.
    /// <code>Offset: 0x00451D70
    /// void __thiscall SmartBox::Show(SmartBox*)</code>
    /// </summary>
    public void Show() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00451D70)(ref this);

    /// <summary>Sets the smart box's hidden flag to true, marking it as invisible or inactive in the game world.
    /// <code>Offset: 0x00451D80
    /// void __thiscall SmartBox::Hide(SmartBox*)</code>
    /// </summary>
    public void Hide() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00451D80)(ref this);

    /// <summary>Sets the 3D view rectangle and, if an object search is active, restarts it at the current window position.
    /// <code>Offset: 0x00451D90
    /// int __thiscall SmartBox::SetMode(SmartBox*,int,int,int,int)</code>
    /// </summary>
    /// <param name="x">The left coordinate of the viewport in pixels.</param>
    /// <param name="y">The top coordinate of the viewport in pixels.</param>
    /// <param name="width">The width of the viewport in pixels.</param>
    /// <param name="height">The height of the viewport in pixels.</param>
    /// <returns>1 if the view was set successfully; 0 otherwise.</returns>
    public int SetMode(int x, int y, int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, int, int, int, int>)0x00451D90)(ref this, x, y, width, height);

    /// <summary>Disables or re‑enables in-game degradations according to the supplied flag.
    /// <code>Offset: 0x00451DE0
    /// void __cdecl SmartBox::DisableDegrades(int)</code>
    /// </summary>
    /// <param name="disable">Non‑zero value disables degradations; zero enables them.</param>
    public static void DisableDegrades(int disable) => ((delegate* unmanaged[Cdecl]<int, void>)0x00451DE0)(disable);

    /// <summary>Disables or enables the rendering fog system based on the supplied flag.
    /// <code>Offset: 0x00451DF0
    /// void __cdecl SmartBox::DisableFogging(int)</code>
    /// </summary>
    /// <param name="disable">Non‑zero values turn fog off; zero turns it back on.</param>
    public static void DisableFogging(int disable) => ((delegate* unmanaged[Cdecl]<int, void>)0x00451DF0)(disable);

    /// <summary>Activates or deactivates the game's weather system based on the supplied flag.
    /// <code>Offset: 0x00451E10
    /// void __thiscall SmartBox::EnableWeather(SmartBox*,int)</code>
    /// </summary>
    /// <param name="enable">Non‑zero to turn weather on, zero to turn it off.</param>
    public void EnableWeather(int enable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, void>)0x00451E10)(ref this, enable);

    /// <summary>Enables or disables detailed texturing for landscape and environment, delegating to the underlying LScape if present.
    /// <code>Offset: 0x00451E30
    /// bool __thiscall SmartBox::SetDetailTexturing(SmartBox*,bool,bool)</code>
    /// </summary>
    /// <param name="landscape">True to enable detail texturing on the landscape; false to disable it.</param>
    /// <param name="environment">True to enable detail texturing on the environment; false to disable it.</param>
    /// <returns>True if the operation succeeded; otherwise false (e.g., when no LScape is available).</returns>
    public byte SetDetailTexturing(byte landscape, byte environment) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, byte, byte, byte>)0x00451E30)(ref this, landscape, environment);

    /// <summary>
    /// Processes rendering options for the SmartBox by delegating to the global graphics settings handler, returning its result.
    /// 
    /// <code>Offset: 0x00451E60
    /// int __thiscall SmartBox::HandleRenderOption(SmartBox*,int,char**,const char**,const char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied.</param>
    /// <param name="argv">An array of argument strings.</param>
    /// <param name="status_string">Pointer to a string that will receive a status message; initialized to null before delegation.</param>
    /// <param name="textbox_string">Pointer to a string for additional text output; initialized to null before delegation.</param>
    /// <returns>An integer result from GraphicsOptions::HandleRenderOption, indicating success or failure of the operation.</returns>
    public int HandleRenderOption(int argc, sbyte** argv, sbyte** status_string, sbyte** textbox_string) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, sbyte**, sbyte**, sbyte**, int>)0x00451E60)(ref this, argc, argv, status_string, textbox_string);

    /// <summary>Sets the default game field‑of‑view in radians from a degree value.
    /// <code>Offset: 0x00451EA0
    /// void __thiscall SmartBox::SetDefaultFov(SmartBox*,float)</code>
    /// </summary>
    /// <param name="degrees">The desired FOV to set, expressed in degrees.</param>
    public void SetDefaultFov(float degrees) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, float, void>)0x00451EA0)(ref this, degrees);

    /// <summary>Checks whether the SmartBox contains a valid player object and its cell ID is less than 256.
    /// <code>Offset: 0x00451EC0
    /// int __thiscall SmartBox::is_player_outside(SmartBox*)</code>
    /// </summary>
    /// <returns>Non‑zero if both conditions hold; otherwise zero.</returns>
    public int is_player_outside() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int>)0x00451EC0)(ref this);

    /// <summary>
    /// Handles a delete‑object network message by verifying the target object exists, ensuring its update time matches the provided instance timestamp, and then either acknowledges, rejects, or queues the request for later processing.
    /// 
    /// <code>Offset: 0x00451EE0
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleDeleteObject(SmartBox*,NetBlob*,unsigned int,unsigned __int16)</code>
    /// </summary>
    /// <param name="blob">The NetBlob containing the delete‑request data.</param>
    /// <param name="object_id">Identifier of the object to be deleted.</param>
    /// <param name="instance_timestamp">Timestamp expected for the object's current state.</param>
    /// <returns>NetBlobProcessedStatus indicating whether the delete request was accepted, rejected, queued, or invalid (e.g., attempt to delete the local player).</returns>
    public ACBindings.Internal.NetBlobProcessedStatus HandleDeleteObject(ACBindings.Internal.NetBlob* blob, uint object_id, ushort instance_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ushort, ACBindings.Internal.NetBlobProcessedStatus>)0x00451EE0)(ref this, blob, object_id, instance_timestamp);

    /// <summary>Updates a physics object's visual appearance using the supplied descriptor only when its timestamp is newer than the object's last update; returns 1 on success and 0 if no change occurs.
    /// <code>Offset: 0x00451F80
    /// int __thiscall SmartBox::UpdateVisualDesc(SmartBox*,CPhysicsObj*,const VisualDesc*,unsigned __int16)</code>
    /// </summary>
    /// <param name="object">The physics object whose visual representation should be refreshed.</param>
    /// <param name="vdesc">The new visual description to apply to the object.</param>
    /// <param name="vdesc_ts">Timestamp of the supplied visual descriptor, used to determine whether an update is necessary.</param>
    /// <returns>1 when the object's visual data was updated; 0 if the descriptor was older or identical to the last applied one.</returns>
    public int UpdateVisualDesc(ACBindings.Internal.CPhysicsObj* object_, ACBindings.Internal.VisualDesc* vdesc, ushort vdesc_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.VisualDesc*, ushort, int>)0x00451F80)(ref this, object_, vdesc, vdesc_ts);

    /// <summary>Handles a sound event for an object, playing the sound if the object is present or queuing the blob otherwise.
    /// <code>Offset: 0x00452000
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleSoundEvent(SmartBox*,NetBlob*,unsigned int,int,float)</code>
    /// </summary>
    /// <param name="blob">Network packet containing data related to the sound event.</param>
    /// <param name="object_id">Identifier of the target object that should emit the sound.</param>
    /// <param name="sound">Integer code representing the type of sound to play.</param>
    /// <param name="volume">Desired volume level for the sound playback.</param>
    /// <returns>NetBlobProcessedStatus indicating whether the sound was played, failed, or the blob was queued for later processing.</returns>
    public ACBindings.Internal.NetBlobProcessedStatus HandleSoundEvent(ACBindings.Internal.NetBlob* blob, uint object_id, int sound, float volume) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, int, float, ACBindings.Internal.NetBlobProcessedStatus>)0x00452000)(ref this, blob, object_id, sound, volume);

    /// <summary>Handles a request to play a script on an object identified by ID. If the object exists, attempts to start the script and reports success or failure; otherwise queues the incoming data for later processing.
    /// <code>Offset: 0x00452060
    /// int __thiscall SmartBox::HandlePlayScriptID(CObjectMaint**,NetBlob*,unsigned int,int)</code>
    /// </summary>
    /// <param name="blob">NetBlob containing information about the playback request.</param>
    /// <param name="object_id">Identifier of the target object.</param>
    /// <param name="a4">Parameter forwarded to the object's play_script method, typically a script ID or related argument.</param>
    /// <returns>1 if the script started successfully; 3 if the script failed to start; 4 if the target object was not found and the blob was queued for later handling.</returns>
    public int HandlePlayScriptID(ACBindings.Internal.NetBlob* blob, uint object_id, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, int, int>)0x00452060)(ref this, blob, object_id, a4);

    /// <summary>Attempts to execute a gameplay script on the specified object; if the object is unavailable, defers execution by queuing the network blob.
    /// <code>Offset: 0x004520B0
    /// NetBlobProcessedStatus __thiscall SmartBox::HandlePlayScriptType(SmartBox*,NetBlob*,unsigned int,int,float)</code>
    /// </summary>
    /// <param name="this">The SmartBox instance handling the request.</param>
    /// <param name="blob">Network payload containing script data for later processing if needed.</param>
    /// <param name="object_id">Identifier of the target physics object.</param>
    /// <param name="script_type">Enumeration value indicating which script to play.</param>
    /// <param name="mod">Modifier applied when executing the script.</param>
    /// <returns>NetBlobProcessedStatus representing the outcome: 1 if the script was played successfully, 3 if playing failed, or 4 if the object is not yet available and the blob has been queued.</returns>
    public ACBindings.Internal.NetBlobProcessedStatus HandlePlayScriptType(ACBindings.Internal.NetBlob* blob, uint object_id, int script_type, float mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, int, float, ACBindings.Internal.NetBlobProcessedStatus>)0x004520B0)(ref this, blob, object_id, script_type, mod);

    /// <summary>Updates the object's internal timestamp and sets its state when a newer state update arrives, optionally clearing a teleport wait flag for the player object.
    /// <code>Offset: 0x00452110
    /// void __thiscall SmartBox::DoSetState(SmartBox*,CPhysicsObj*,unsigned int,unsigned __int16)</code>
    /// </summary>
    /// <param name="object">The physics object whose state is being updated.</param>
    /// <param name="state">The new state value to apply.</param>
    /// <param name="state_timestamp">Timestamp indicating the recency of the state change.</param>
    public void DoSetState(ACBindings.Internal.CPhysicsObj* object_, uint state, ushort state_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, uint, ushort, void>)0x00452110)(ref this, object_, state, state_timestamp);

    /// <summary>Compares the supplied physics timestamp with the player’s last update time, accounting for wrap‑around. If the packet’s timestamp is not newer than the current value, clears position‑update status, resets teleport flags and marks a pending teleport request.
    /// <code>Offset: 0x00452190
    /// NetBlobProcessedStatus __thiscall SmartBox::HandlePlayerTeleport(SmartBox*,NetBlob*,unsigned __int16)</code>
    /// </summary>
    /// <param name="blob">Network data packet containing teleport information.</param>
    /// <param name="physics_timestamp">Physics state timestamp from the packet.</param>
    /// <returns>NETBLOB_PROCESSED_OK when processed; otherwise returns 1 if no player object is available, indicating an error or unprocessed status.</returns>
    public ACBindings.Internal.NetBlobProcessedStatus HandlePlayerTeleport(ACBindings.Internal.NetBlob* blob, ushort physics_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, ushort, ACBindings.Internal.NetBlobProcessedStatus>)0x00452190)(ref this, blob, physics_timestamp);

    /// <summary>Updates a physics object's linear and angular velocity when the supplied timestamp is newer than its stored value, skipping updates for the player under certain interpreter conditions.
    /// <code>Offset: 0x00452200
    /// void __thiscall SmartBox::DoVectorUpdate(SmartBox*,CPhysicsObj*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,unsigned __int16)</code>
    /// </summary>
    /// <param name="this">The SmartBox instance performing the update.</param>
    /// <param name="object">Physics object whose motion vectors are updated.</param>
    /// <param name="velocity">New linear velocity vector.</param>
    /// <param name="omega">New angular (rotational) velocity vector.</param>
    /// <param name="vector_timestamp">Timestamp indicating when the vector data was generated; used to determine if an update is required.</param>
    public void DoVectorUpdate(ACBindings.Internal.CPhysicsObj* object_, ACBindings.Internal.AC1Legacy.Vector3* velocity, ACBindings.Internal.AC1Legacy.Vector3* omega, ushort vector_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ushort, void>)0x00452200)(ref this, object_, velocity, omega, vector_timestamp);

    /// <summary>
    /// Handles a pickup event by updating the object's timestamp and detaching it from the world when the new time is more recent than its current record.
    /// 
    /// <code>Offset: 0x00452280
    /// void __thiscall SmartBox::DoPickupEvent(SmartBox*,CPhysicsObj*,unsigned __int16)</code>
    /// </summary>
    /// <param name="object">The physics object being picked up.</param>
    /// <param name="position_timestamp">Timestamp indicating the new update time for the object.</param>
    public void DoPickupEvent(ACBindings.Internal.CPhysicsObj* object_, ushort position_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, ushort, void>)0x00452280)(ref this, object_, position_timestamp);

    /// <summary>When a newer timestamp is supplied, updates the child’s parent relationship and placement; if the child was previously unparented and the new parent is not the current player, triggers the parent’s WeenieObject parent‑event callback.
    /// <code>Offset: 0x004522D0
    /// void __thiscall SmartBox::DoParentEvent(SmartBox*,CPhysicsObj*,CPhysicsObj*,unsigned int,unsigned int,unsigned __int16)</code>
    /// </summary>
    /// <param name="this">SmartBox instance holding context such as the current player ID.</param>
    /// <param name="child">Physics object whose parent may be updated.</param>
    /// <param name="parent">Candidate new parent physics object.</param>
    /// <param name="child_location">Attachment index within the parent where the child should connect.</param>
    /// <param name="placement_id">Frame identifier specifying how the child aligns to the parent.</param>
    /// <param name="position_stamp">Timestamp indicating the recency of the child's state; only newer timestamps cause an update.</param>
    public void DoParentEvent(ACBindings.Internal.CPhysicsObj* child, ACBindings.Internal.CPhysicsObj* parent, uint child_location, uint placement_id, ushort position_stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.CPhysicsObj*, uint, uint, ushort, void>)0x004522D0)(ref this, child, parent, child_location, placement_id, position_stamp);

    /// <summary>Sets the current viewer position and optionally updates the sought position, then refreshes lighting, sound, sky, and camera settings accordingly.
    /// <code>Offset: 0x00452C80
    /// void __thiscall SmartBox::set_viewer(SmartBox*,const Position*,int)</code>
    /// </summary>
    /// <param name="new_viewer">The new viewer position to apply.</param>
    /// <param name="set_sought_position">If non-zero, also set the viewer's sought position to match the new position.</param>
    public void set_viewer(ACBindings.Internal.Position* new_viewer, int set_sought_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.Position*, int, void>)0x00452C80)(ref this, new_viewer, set_sought_position);

    /// <summary>Synchronizes the player's sought position with the camera's updated location and orientation after a physics update.
    /// <code>Offset: 0x00452DA0
    /// void __thiscall SmartBox::PlayerPhysicsUpdatedCallback(SmartBox*)</code>
    /// </summary>
    public void PlayerPhysicsUpdatedCallback() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00452DA0)(ref this);

    /// <summary>Translates an object's world position into coordinates relative to the current player.
    /// <code>Offset: 0x00452DE0
    /// int __thiscall SmartBox::convert_to_player_space(SmartBox*,CPhysicsObj*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="object">The physics object whose position is converted.</param>
    /// <param name="return_vector">Receives the resulting local‑space position.</param>
    /// <returns>Non‑zero if conversion succeeded; zero if no valid player, the object is null, or the object has no cell.</returns>
    public int convert_to_player_space(ACBindings.Internal.CPhysicsObj* object_, ACBindings.Internal.AC1Legacy.Vector3* return_vector) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00452DE0)(ref this, object_, return_vector);

    /// <summary>Obtains the screen‑space bounding rectangle of an object identified by its ID and reports whether it is visible, off‑screen, or invalid.
    /// <code>Offset: 0x00452E60
    /// ObjectSelectStatus __thiscall SmartBox::GetObjectBoundingBox(SmartBox*,unsigned int,tagRECT*,float*)</code>
    /// </summary>
    /// <param name="object_iid">The unique identifier of the object to query.</param>
    /// <param name="bbox">On success with an onscreen object, receives a <c>tagRECT</c> containing left, right, top, and bottom screen coordinates; otherwise remains unchanged.</param>
    /// <param name="heading">If the object is off‑screen, receives the heading angle (in degrees) from the viewer to the object; set to zero for an onscreen or invalid object.</param>
    /// <returns>An <c>ObjectSelectStatus</c> value indicating the object's status: <c>Onscreen_OSS</c>, <c>Offscreen_OSS</c>, or <c>Invalid_OSS</c>.</returns>
    public ACBindings.Internal.ObjectSelectStatus GetObjectBoundingBox(uint object_iid, ACBindings.Internal.tagRECT* bbox, float* heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, uint, ACBindings.Internal.tagRECT*, float*, ACBindings.Internal.ObjectSelectStatus>)0x00452E60)(ref this, object_iid, bbox, heading);

    /// <summary>Sets the world’s ambient light intensity and color, updating the rendering engine when creature mode is disabled.
    /// <code>Offset: 0x004530E0
    /// void __thiscall SmartBox::SetWorldAmbientLight(SmartBox*,float,unsigned int)</code>
    /// </summary>
    /// <param name="intensity">The multiplier applied to the RGB components of the supplied color.</param>
    /// <param name="color">A 32‑bit ARGB value specifying the desired ambient light color.</param>
    public void SetWorldAmbientLight(float intensity, uint color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, float, uint, void>)0x004530E0)(ref this, intensity, color);

    /// <summary>Switches SmartBox from creature mode to normal mode, restoring ambient lighting and clearing world lights.
    /// <code>Offset: 0x00453160
    /// int __thiscall SmartBox::SetNormalMode(SmartBox*)</code>
    /// </summary>
    /// <returns>Always returns 1 indicating successful switch.</returns>
    public int SetNormalMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int>)0x00453160)(ref this);

    /// <summary>Sets the mid‑radius value for the landscape and, when cell blocking is enabled, updates the player’s cell position to reflect the change.
    /// <code>Offset: 0x004531C0
    /// int __thiscall SmartBox::set_mid_radius(SmartBox*,int)</code>
    /// </summary>
    /// <param name="mid_radius">The new mid‑radius value to apply.</param>
    /// <returns>Non‑zero on success; zero if setting the radius failed.</returns>
    public int set_mid_radius(int mid_radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, int>)0x004531C0)(ref this, mid_radius);

    /// <summary>Changes SmartBox's region, resetting its cell manager and updating the landscape when successful.
    /// <code>Offset: 0x00453230
    /// int __thiscall SmartBox::SetRegion(SmartBox*,unsigned int)</code>
    /// </summary>
    /// <param name="region_num">The target region identifier to switch to.</param>
    /// <returns>Non-zero on success; zero if setting the region fails.</returns>
    public int SetRegion(uint region_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, uint, int>)0x00453230)(ref this, region_num);

    /// <summary>Configures the camera manager to focus on and follow the player character by setting pivot, offset, target direction, and scaling parameters while clearing any previous targets.
    /// <code>Offset: 0x00453280
    /// void __thiscall SmartBox::set_viewer_home(SmartBox*)</code>
    /// </summary>
    public void set_viewer_home() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00453280)(ref this);

    /// <summary>Handles an object description event by validating timestamps and updating visual data or deferring the packet when necessary.
    /// <code>Offset: 0x00453380
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleObjDescEvent(SmartBox*,NetBlob*,unsigned int,const VisualDesc*,const PhysicsTimestampPack*)</code>
    /// </summary>
    /// <param name="blob">Network packet containing the object description payload.</param>
    /// <param name="object_id">Identifier of the target object to update.</param>
    /// <param name="vdesc">Visual description information to apply when timestamps match.</param>
    /// <param name="timestamps">Timestamp pair used for freshness comparison with the object's last update time.</param>
    /// <returns>NetBlobProcessedStatus value indicating whether the packet was applied immediately (1), considered stale and ignored (2), or queued for later processing (4).</returns>
    public ACBindings.Internal.NetBlobProcessedStatus HandleObjDescEvent(ACBindings.Internal.NetBlob* blob, uint object_id, ACBindings.Internal.VisualDesc* vdesc, ACBindings.Internal.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ACBindings.Internal.VisualDesc*, ACBindings.Internal.PhysicsTimestampPack*, ACBindings.Internal.NetBlobProcessedStatus>)0x00453380)(ref this, blob, object_id, vdesc, timestamps);

    /// <summary>Handles a set‑state packet for an object by checking its timestamp against the object's last update time; applies the state immediately when timestamps match, ignores it when they differ slightly, or queues it for later when it is missing or too old.
    /// <code>Offset: 0x00453420
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleSetState(SmartBox*,NetBlob*,unsigned int,unsigned int,const PhysicsTimestampPack*)</code>
    /// </summary>
    /// <param name="blob">Network packet containing the requested state change.</param>
    /// <param name="object_id">Identifier of the target object.</param>
    /// <param name="new_state">State value to apply to the object.</param>
    /// <param name="timestamps">Timestamp information used to determine packet freshness relative to the object's last update time.</param>
    /// <returns>1 if state applied, 2 if timestamp differs but is still recent enough (packet ignored), or 4 if the object is missing or timestamp is too old and the packet has been queued for later processing.</returns>
    public ACBindings.Internal.NetBlobProcessedStatus HandleSetState(ACBindings.Internal.NetBlob* blob, uint object_id, uint new_state, ACBindings.Internal.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, uint, ACBindings.Internal.PhysicsTimestampPack*, ACBindings.Internal.NetBlobProcessedStatus>)0x00453420)(ref this, blob, object_id, new_state, timestamps);

    /// <summary>Handles a vector update packet for a specified object, applying the new velocity and rotation when the timestamp matches, discarding it when the packet is newer but not matching, or queuing it for later processing if the object is missing or timestamps differ by more than 32767 ticks.
    /// <code>Offset: 0x004534C0
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleVectorUpdate(SmartBox*,NetBlob*,unsigned int,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,const PhysicsTimestampPack*)</code>
    /// </summary>
    /// <param name="blob">Network data containing the vector update to be processed.</param>
    /// <param name="object_id">Identifier of the target object whose motion will be updated.</param>
    /// <param name="velocity">New linear velocity vector for the object.</param>
    /// <param name="omega">New angular (rotational) velocity vector for the object.</param>
    /// <param name="timestamps">Timestamps used to determine whether the update should be applied, discarded or queued.</param>
    /// <returns>NetBlobProcessedStatus: 1 if the update is applied immediately; 2 if the packet is discarded because it is newer than the stored timestamp but not equal; 4 if the blob is queued for later processing due to missing object or a timestamp difference exceeding 32767 ticks.</returns>
    public ACBindings.Internal.NetBlobProcessedStatus HandleVectorUpdate(ACBindings.Internal.NetBlob* blob, uint object_id, ACBindings.Internal.AC1Legacy.Vector3* velocity, ACBindings.Internal.AC1Legacy.Vector3* omega, ACBindings.Internal.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.PhysicsTimestampPack*, ACBindings.Internal.NetBlobProcessedStatus>)0x004534C0)(ref this, blob, object_id, velocity, omega, timestamps);

    /// <summary>Processes a network pickup event by validating timestamps and either executing the event or queuing it for later handling.
    /// <code>Offset: 0x00453570
    /// NetBlobProcessedStatus __thiscall SmartBox::HandlePickupEvent(SmartBox*,NetBlob*,unsigned int,const PhysicsTimestampPack*)</code>
    /// </summary>
    /// <param name="blob">The NetBlob containing the pickup data.</param>
    /// <param name="object_id">Identifier of the object involved in the pickup.</param>
    /// <param name="timestamps">Timestamp pack used to determine event timing consistency.</param>
    /// <returns>NetBlobProcessedStatus code: 1 if processed immediately, 2 if timestamp mismatch requires resynchronization, 4 if queued for later processing.</returns>
    public ACBindings.Internal.NetBlobProcessedStatus HandlePickupEvent(ACBindings.Internal.NetBlob* blob, uint object_id, ACBindings.Internal.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ACBindings.Internal.PhysicsTimestampPack*, ACBindings.Internal.NetBlobProcessedStatus>)0x00453570)(ref this, blob, object_id, timestamps);

    /// <summary>Handles a parent event received via a network blob, validating the primary and child objects along with their timestamps before delegating to DoParentEvent or queuing the blob for later processing.
    /// <code>Offset: 0x00453610
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleParentEvent(SmartBox*,NetBlob*,unsigned int,unsigned int,unsigned int,unsigned int,const PhysicsTimestampPack*)</code>
    /// </summary>
    /// <param name="blob">The network packet containing event data.</param>
    /// <param name="object_id">Identifier of the main object associated with the event.</param>
    /// <param name="child_id">Identifier of the child object involved in the event.</param>
    /// <param name="child_location">Index or positional descriptor for the child within its parent context.</param>
    /// <param name="placement_id">Placement identifier used during event handling.</param>
    /// <param name="timestamps">Timestamp information used to verify the freshness and ordering of the event.</param>
    /// <returns>NetBlobProcessedStatus: 1 if the event was processed, 2 if rejected due to a timestamp mismatch, or 4 if the blob was queued for later processing.</returns>
    public ACBindings.Internal.NetBlobProcessedStatus HandleParentEvent(ACBindings.Internal.NetBlob* blob, uint object_id, uint child_id, uint child_location, uint placement_id, ACBindings.Internal.PhysicsTimestampPack* timestamps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, uint, uint, uint, ACBindings.Internal.PhysicsTimestampPack*, ACBindings.Internal.NetBlobProcessedStatus>)0x00453610)(ref this, blob, object_id, child_id, child_location, placement_id, timestamps);

    /// <summary>Unlinks rendering callbacks and clears internal state for a SmartBox instance.
    /// <code>Offset: 0x004538E0
    /// void __cdecl SmartBox::Cleanup(SmartBox*)</code>
    /// </summary>
    /// <param name="smartbox">The SmartBox instance to clean up (currently unused in the implementation).</param>
    public static void Cleanup(ACBindings.Internal.SmartBox* smartbox) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SmartBox*, void>)0x004538E0)(smartbox);

    /// <summary>Updates the player’s state, handling teleportation and refreshing camera view when movement exceeds a threshold.
    /// <code>Offset: 0x00453910
    /// void __thiscall SmartBox::PlayerPositionUpdated(SmartBox*,int,float)</code>
    /// </summary>
    /// <param name="teleporting">Non‑zero if this update represents a teleport; resets internal flags, triggers the player’s teleport hook, and clears input focus.</param>
    /// <param name="distance_moved">Distance moved since the last update; used to determine whether the viewer should be updated based on the autonomy blip distance.</param>
    public void PlayerPositionUpdated(int teleporting, float distance_moved) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, float, void>)0x00453910)(ref this, teleporting, distance_moved);

    /// <summary>Teleports the current player to a specified position by setting its physics location and notifying the system of the change.
    /// <code>Offset: 0x004539B0
    /// void __thiscall SmartBox::TeleportPlayer(SmartBox*,const Position*)</code>
    /// </summary>
    /// <param name="new_pos">Target position, containing cell ID and frame information, for the player to be moved to.</param>
    public void TeleportPlayer(ACBindings.Internal.Position* new_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.Position*, void>)0x004539B0)(ref this, new_pos);

    /// <summary>Instantly relocates the current player object to a specified position, calculating the distance between the previous and new locations.
    /// <code>Offset: 0x004539E0
    /// void __thiscall SmartBox::BlipPlayer(SmartBox*,const Position*)</code>
    /// </summary>
    /// <param name="new_pos">Target position for the player.</param>
    public void BlipPlayer(ACBindings.Internal.Position* new_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.Position*, void>)0x004539E0)(ref this, new_pos);

    /// <summary>Adds a network blob to the SmartBox's internal queue, ensuring proper reference counting and initializing the queue if necessary.
    /// <code>Offset: 0x00453A20
    /// void __thiscall SmartBox::QueueNetBlob(SmartBox*,NetBlob*)</code>
    /// </summary>
    /// <param name="blob">The NetBlob instance to enqueue.</param>
    public void QueueNetBlob(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, void>)0x00453A20)(ref this, blob);

    /// <summary>Removes all queued network blobs from this SmartBox, deallocating each object and decreasing its reference count. If a blob’s reference count reaches zero, its release handler is invoked. After processing, the internal list is cleared.
    /// <code>Offset: 0x00453AB0
    /// void __thiscall SmartBox::DestroyQueuedNetBlobs(SmartBox*)</code>
    /// </summary>
    public void DestroyQueuedNetBlobs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00453AB0)(ref this);

    /// <summary>Renders the scene in normal mode by setting camera parameters based on viewer position and view distance settings, updating viewpoint for the current or outside cell, drawing the landscape, flushing alpha blending, and invoking target selection and optional rendering callbacks.
    /// <code>Offset: 0x00453B40
    /// void __thiscall SmartBox::RenderNormalMode(SmartBox*)</code>
    /// </summary>
    public void RenderNormalMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00453B40)(ref this);

    /// <summary>Restores the SmartBox to a default state by clearing the current player reference, resetting viewer cell and position flags, and optionally destroying all tracked objects and queued network blobs.
    /// <code>Offset: 0x00453C90
    /// void __thiscall SmartBox::Reset(SmartBox*,int)</code>
    /// </summary>
    /// <param name="clear_objects">When non-zero, removes all managed objects, resets the player ID, and clears queued net blobs; otherwise only core references are reset.</param>
    public void Reset(int clear_objects) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, void>)0x00453C90)(ref this, clear_objects);

    /// <summary>Initializes the player character within the SmartBox by assigning it to the internal player field, updating viewer home position, linking window ID to its physics object, registering the player with the physics system, storing its unique identifier, and invoking the command interpreter’s input action callback based on the autonomous flag.
    /// <code>Offset: 0x00453D20
    /// void __thiscall SmartBox::init_player(SmartBox*,CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="player_object">The CPhysicsObj representing the player's character to be initialized within SmartBox.</param>
    /// <param name="autonomous">Flag indicating whether the player is controlled autonomously, affecting how the command interpreter handles input actions.</param>
    public void init_player(ACBindings.Internal.CPhysicsObj* player_object, int autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, int, void>)0x00453D20)(ref this, player_object, autonomous);

    /// <summary>
    /// Synchronizes the viewer’s position and cell with the player’s current location, applying camera pivot offsets when a dynamic camera is used and attempting a smooth transition through object cells. If a valid path cannot be found or the player is not visible, the viewer falls back to an immediate update of the player’s position.
    /// 
    /// <code>Offset: 0x00453D80
    /// void __thiscall SmartBox::update_viewer(SmartBox*)</code>
    /// </summary>
    public void update_viewer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00453D80)(ref this);

    /// <summary>Applies an incoming network position update to a physics object, handling normal movement, teleportation, and constraint logic while updating timestamps and state based on the provided identifiers.
    /// <code>Offset: 0x00454070
    /// void __thiscall SmartBox::HandleReceivedPosition(SmartBox*,CPhysicsObj*,const Position*,unsigned int,int,const AC1Legacy::Vector3*,unsigned __int16,unsigned __int16,unsigned __int16)</code>
    /// </summary>
    /// <param name="object">The physics object whose position is being updated.</param>
    /// <param name="position">A Position structure containing the new location and orientation for the object.</param>
    /// <param name="placement_id">Frame identifier used when repositioning non‑player objects during a teleport or forced placement.</param>
    /// <param name="has_contact">Flag indicating whether the object was in contact with another entity during movement, affecting interpolation behavior.</param>
    /// <param name="velocity">Optional velocity vector for smooth interpolation between positions.</param>
    /// <param name="position_timestamp">Timestamp of the position event to determine recency of the update.</param>
    /// <param name="teleport_timestamp">Timestamp associated with a teleport action; used to decide whether to apply a teleported state.</param>
    /// <param name="force_position_timestamp">Timestamp used when forcibly overriding the player's position, ensuring it supersedes other updates.</param>
    public void HandleReceivedPosition(ACBindings.Internal.CPhysicsObj* object_, ACBindings.Internal.Position* position, uint placement_id, int has_contact, ACBindings.Internal.AC1Legacy.Vector3* velocity, ushort position_timestamp, ushort teleport_timestamp, ushort force_position_timestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.Position*, uint, int, ACBindings.Internal.AC1Legacy.Vector3*, ushort, ushort, ushort, void>)0x00454070)(ref this, object_, position, placement_id, has_contact, velocity, position_timestamp, teleport_timestamp, force_position_timestamp);

    /// <summary>Unpacks a position update packet for the specified object and applies the new state when timestamps are within an acceptable range.
    /// <code>Offset: 0x00454360
    /// NetBlobProcessedStatus __thiscall SmartBox::UnpackPositionEvent(SmartBox*,unsigned int,void**,unsigned int)</code>
    /// </summary>
    /// <param name="object_id">The unique identifier of the target physics object to be updated.</param>
    /// <param name="buff">A pointer to the buffer containing the serialized PositionPack data.</param>
    /// <param name="size">The size, in bytes, of the incoming buffer.</param>
    /// <returns>Returns a NetBlobProcessedStatus value: 1 on successful update, 2 if the packet’s timestamp differs from the object’s current update time, or 4 if the object is missing or the timestamps are out‑of‑range.</returns>
    public ACBindings.Internal.NetBlobProcessedStatus UnpackPositionEvent(uint object_id, void** buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, uint, void**, uint, ACBindings.Internal.NetBlobProcessedStatus>)0x00454360)(ref this, object_id, buff, size);

    /// <summary>Create a SmartBox instance, initializing its internal state, viewer sphere, default light properties, and registering global configuration variables for player light intensity and falloff.
    /// <code>Offset: 0x00454640
    /// char* __thiscall SmartBox::SmartBox(char*,int)</code>
    /// </summary>
    /// <param name="a2">The identifier of the player associated with this SmartBox.</param>
    /// <returns>Pointer to the newly constructed SmartBox object.</returns>
    public sbyte* _ConstructorInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, sbyte*>)0x00454640)(ref this, a2);

    /// <summary>Destroys a SmartBox instance, releasing all associated resources such as camera manager, cell manager, command interpreter, physics objects, ambient sounds, and landscape data. Unregisters viewer-related variables from the global registry, clears static references to maintain integrity, and resets internal state before object destruction.
    /// <code>Offset: 0x00454920
    /// void __thiscall SmartBox::~SmartBox(SmartBox*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00454920)(ref this);

    /// <summary>Processes queued network blobs, dispatching ready events or queuing others for later handling and then releases the blob list.
    /// <code>Offset: 0x00454B10
    /// void __thiscall SmartBox::ProcessNetBlobs(SmartBox*)</code>
    /// </summary>
    public void ProcessNetBlobs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00454B10)(ref this);

    /// <summary>Processes a physics object's network blobs by invoking its weenie object's update routine (if present), clearing and rebuilding the netblob list, and dispatching or queuing each blob according to readiness while managing reference counts.
    /// <code>Offset: 0x00454BC0
    /// void __thiscall SmartBox::ProcessObjectNetBlobs(SmartBox*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="this">The SmartBox instance performing the processing.</param>
    /// <param name="object">The physics object whose network blobs are processed.</param>
    public void ProcessObjectNetBlobs(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.CPhysicsObj*, void>)0x00454BC0)(ref this, object_);

    /// <summary>Creates or updates a game object from the supplied network blob and descriptors. If the parent object is missing, the blob is queued for later; otherwise the function either creates a new physics object or refreshes an existing one with visual, position, movement, state, and other attributes.
    /// <code>Offset: 0x00454D20
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleCreateObject(SmartBox*,NetBlob*,unsigned int,const VisualDesc*,const PhysicsDesc*,const WeenieDesc*,int)</code>
    /// </summary>
    /// <param name="blob">Network packet containing creation or update information for the object.</param>
    /// <param name="object_id">Unique identifier of the object to create or update.</param>
    /// <param name="vdesc">Visual description defining appearance data.</param>
    /// <param name="physicsdesc">Physics description providing position, movement, and state timestamps.</param>
    /// <param name="wdesc">Weenie description containing additional object metadata.</param>
    /// <param name="force_recreate">When non‑zero forces recreation of the object even if an existing instance is present.</param>
    /// <returns>NetBlobProcessedStatus indicating whether the blob was processed immediately (1), ignored due to newer data (2), failed to create a physics object (3), or queued for later processing because its parent is missing (4).</returns>
    public ACBindings.Internal.NetBlobProcessedStatus HandleCreateObject(ACBindings.Internal.NetBlob* blob, uint object_id, ACBindings.Internal.VisualDesc* vdesc, ACBindings.Internal.PhysicsDesc* physicsdesc, ACBindings.Internal.WeenieDesc* wdesc, int force_recreate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ACBindings.Internal.VisualDesc*, ACBindings.Internal.PhysicsDesc*, ACBindings.Internal.WeenieDesc*, int, ACBindings.Internal.NetBlobProcessedStatus>)0x00454D20)(ref this, blob, object_id, vdesc, physicsdesc, wdesc, force_recreate);

    /// <summary>Handles creation of a new player from a network packet. If the current instance has no assigned player ID, it registers the supplied object identifier, processes queued blobs, triggers the command interpreter action, and reports success; otherwise it returns a status indicating that a player already exists.
    /// <code>Offset: 0x004551B0
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleCreatePlayer(SmartBox*,NetBlob*,unsigned int)</code>
    /// </summary>
    /// <param name="blob">The network packet containing creation data (not directly used in this routine).</param>
    /// <param name="object_id">The unique identifier for the new player entity.</param>
    /// <returns>NetBlobProcessedStatus: 1 if the player was created successfully, 3 if a player already exists and the request is ignored.</returns>
    public ACBindings.Internal.NetBlobProcessedStatus HandleCreatePlayer(ACBindings.Internal.NetBlob* blob, uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ACBindings.Internal.NetBlobProcessedStatus>)0x004551B0)(ref this, blob, object_id);

    /// <summary>Initializes the SmartBox internal systems, establishing object maintenance, physics, landscape, ambient sounds, command interpretation, cell management, and camera handling. Configures inter‑component relationships and marks the box hidden after successful setup.
    /// <code>Offset: 0x00455290
    /// char __thiscall SmartBox::InitInternal(SmartBox*,int)</code>
    /// </summary>
    /// <param name="a2">Unused initialization parameter; ignored by the method.</param>
    /// <returns>Non‑zero value (1) on success, zero if any component fails to initialize.</returns>
    public sbyte InitInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, int, sbyte>)0x00455290)(ref this, a2);

    /// <summary>Updates core subsystems for a single frame, including cell management, player positioning, object maintenance, physics simulation, game time advancement, ambient effects, and rendering level calculation. Processes queued network blobs, dispatching or re‑queuing events as appropriate, and handles test‑mode cleanup of input callbacks.
    /// <code>Offset: 0x004554B0
    /// void __thiscall SmartBox::UseTime(SmartBox*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x004554B0)(ref this);

    /// <summary>Draws the SmartBox interface when visible, updating viewer information and rendering normal mode for the player, while processing any pending object selection and clearing the selection cursor.
    /// <code>Offset: 0x00455610
    /// void __thiscall SmartBox::Draw(SmartBox*)</code>
    /// </summary>
    public void Draw() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, void>)0x00455610)(ref this);

    /// <summary>Processes a network blob containing updated object data and creates or updates the corresponding in‑world entity.
    /// <code>Offset: 0x00455620
    /// NetBlobProcessedStatus __thiscall SmartBox::HandleUpdateObject(SmartBox*,NetBlob*,unsigned int,const VisualDesc*,const PhysicsDesc*,const WeenieDesc*)</code>
    /// </summary>
    /// <param name="blob">Network packet with serialized object information.</param>
    /// <param name="object_id">Identifier for the target object.</param>
    /// <param name="objdesc">Visual description of the object.</param>
    /// <param name="physicsdesc">Physical properties and state to apply.</param>
    /// <param name="wdesc">Additional Weenie metadata.</param>
    /// <returns>Resulting status from processing the blob, indicating success or failure.</returns>
    public ACBindings.Internal.NetBlobProcessedStatus HandleUpdateObject(ACBindings.Internal.NetBlob* blob, uint object_id, ACBindings.Internal.VisualDesc* objdesc, ACBindings.Internal.PhysicsDesc* physicsdesc, ACBindings.Internal.WeenieDesc* wdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBox, ACBindings.Internal.NetBlob*, uint, ACBindings.Internal.VisualDesc*, ACBindings.Internal.PhysicsDesc*, ACBindings.Internal.WeenieDesc*, ACBindings.Internal.NetBlobProcessedStatus>)0x00455620)(ref this, blob, object_id, objdesc, physicsdesc, wdesc);

    /// <summary>Initializes a SmartBox instance using the specified type identifier and auxiliary value, setting up internal state and registering a rendering callback upon successful construction.
    /// <code>Offset: 0x00455710
    /// int __cdecl SmartBox::Init(int,int)</code>
    /// </summary>
    /// <param name="a1">Identifier or configuration key used by the factory to create the SmartBox.</param>
    /// <param name="a2">Auxiliary value assigned to the newly created SmartBox (e.g., priority or size).</param>
    /// <returns>Pointer to the initialized SmartBox instance on success; otherwise zero if creation or internal initialization fails.</returns>
    public static int Init(int a1, int a2) => ((delegate* unmanaged[Cdecl]<int, int, int>)0x00455710)(a1, a2);
}

