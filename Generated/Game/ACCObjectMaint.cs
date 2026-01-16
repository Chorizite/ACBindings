namespace ACBindings.Internal;


/// <summary>Extends the core object maintenance system with support for a per-player visual descriptor, enabling dynamic updates of the player character’s appearance.</summary>
public unsafe struct ACCObjectMaint
{
    // Base Classes
    public ACBindings.Internal.CObjectMaint BaseClass_CObjectMaint; // ACBindings.Internal.CObjectMaint

    // Child Types

    /// <summary>
    /// Defines the virtual function table for maintaining game objects, offering COM query methods, object creation utilities, and visual/weenie descriptor management within the engine.
    /// </summary>
    public unsafe struct ACCObjectMaint_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.CObjectMaint.Enum5> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public fixed byte gap1C[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, void> CObjectMaint_dtor_20; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.VisualDesc*, void> SetVisualDesc; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.WeenieDesc*, int, void> SetWeenieDesc; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, uint, ACBindings.Internal.VisualDesc*, ACBindings.Internal.PhysicsDesc*, ACBindings.Internal.WeenieDesc*, ACBindings.Internal.CPhysicsObj*> CreateObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.VisualDesc*, void> SetPlayerVisualDesc; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, ACBindings.Internal.VisualDesc*> GetPlayerVisualDesc; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectMaint*, void> OnShutdown; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.ObjDesc* player_objdesc;

    // Methods

    /// <summary>Updates a physics object's visual properties by applying the provided VisualDesc using default descriptor changes.
    /// <code>Offset: 0x005582A0
    /// void __thiscall ACCObjectMaint::SetVisualDesc(ACCObjectMaint*,CPhysicsObj*,VisualDesc*)</code>
    /// </summary>
    /// <param name="object">The CPhysicsObj to modify.</param>
    /// <param name="vdesc">The VisualDesc containing new visual attributes.</param>
    public void SetVisualDesc(ACBindings.Internal.CPhysicsObj* object_, ACBindings.Internal.VisualDesc* vdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.VisualDesc*, void>)0x005582A0)(ref this, object_, vdesc);

    /// <summary>Replaces the current visual description for the player with the supplied descriptor, destroying any existing one and notifying listeners of the change.
    /// <code>Offset: 0x005582C0
    /// void __thiscall ACCObjectMaint::SetPlayerVisualDesc(ACCObjectMaint*,VisualDesc*)</code>
    /// </summary>
    /// <param name="new_player_vdesc">The new visual descriptor to assign; if null the player's descriptor is cleared.</param>
    public void SetPlayerVisualDesc(ACBindings.Internal.VisualDesc* new_player_vdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, ACBindings.Internal.VisualDesc*, void>)0x005582C0)(ref this, new_player_vdesc);

    /// <summary>Retrieves the visual descriptor associated with the current player object.
    /// <code>Offset: 0x00558320
    /// VisualDesc* __thiscall ACCObjectMaint::GetPlayerVisualDesc(ACCObjectMaint*)</code>
    /// </summary>
    /// <returns>A pointer to the base visual description of the player's object, suitable for rendering and other visual operations.</returns>
    public ACBindings.Internal.VisualDesc* GetPlayerVisualDesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, ACBindings.Internal.VisualDesc*>)0x00558320)(ref this);

    /// <summary>Deletes an object identified by its ID, notifying the AC plugin and marking any associated corpse as deleted before delegating to base maintenance deletion logic.
    /// <code>Offset: 0x00558330
    /// int __thiscall ACCObjectMaint::DeleteObject(ACCObjectMaint*,unsigned int)</code>
    /// </summary>
    /// <param name="object_id">The identifier of the object to delete.</param>
    /// <returns>The result code from CObjectMaint::DeleteObject; zero indicates success.</returns>
    public int DeleteObject(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, uint, int>)0x00558330)(ref this, object_id);

    /// <summary>Assigns or updates the description for a weenie object, adjusting its position state and notifying the client as needed.
    /// <code>Offset: 0x00558660
    /// void __thiscall ACCObjectMaint::SetWeenieDesc(ACCObjectMaint*,CWeenieObject*,WeenieDesc*,int)</code>
    /// </summary>
    /// <param name="wobj">The weenie object whose description is being set.</param>
    /// <param name="wdesc">New weenie description to apply.</param>
    /// <param name="recreated">Flag indicating whether the object has been recreated; influences notification behavior.</param>
    public void SetWeenieDesc(ACBindings.Internal.CWeenieObject* wobj, ACBindings.Internal.WeenieDesc* wdesc, int recreated) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.WeenieDesc*, int, void>)0x00558660)(ref this, wobj, wdesc, recreated);

    /// <summary>Creates a new physics object identified by the supplied id using visual, physics and weenie descriptors, registers it in the maintenance system, and returns the created instance.
    /// <code>Offset: 0x005594B0
    /// CPhysicsObj* __thiscall ACCObjectMaint::CreateObject(ACCObjectMaint*,unsigned int,VisualDesc*,PhysicsDesc*,WeenieDesc*)</code>
    /// </summary>
    /// <param name="objectID">Unique identifier for the object to be created.</param>
    /// <param name="vdesc">Visual description providing appearance data for the object.</param>
    /// <param name="physicsdesc">Physics description containing physical properties and parent-child relationships.</param>
    /// <param name="wdesc">Weenie descriptor supplying game logic information for the object.</param>
    /// <returns>Pointer to the newly created <c>CPhysicsObj</c>, or <c>null</c> if an object with that id already exists or creation fails.</returns>
    public ACBindings.Internal.CPhysicsObj* CreateObject(uint objectID, ACBindings.Internal.VisualDesc* vdesc, ACBindings.Internal.PhysicsDesc* physicsdesc, ACBindings.Internal.WeenieDesc* wdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, uint, ACBindings.Internal.VisualDesc*, ACBindings.Internal.PhysicsDesc*, ACBindings.Internal.WeenieDesc*, ACBindings.Internal.CPhysicsObj*>)0x005594B0)(ref this, objectID, vdesc, physicsdesc, wdesc);

    /// <summary>Updates the inventory lists for the specified object by clearing any existing items or containers and repopulating them from the supplied content data.
    /// <code>Offset: 0x005596B0
    /// void __thiscall ACCObjectMaint::ViewObjectContents(CObjectMaint*,unsigned int,int)</code>
    /// </summary>
    /// <param name="object_id">The identifier of the target object whose contents are being refreshed.</param>
    /// <param name="a3">A pointer to a structure containing a linked list of entries; each entry holds an ID and a flag indicating whether it is a container or a regular item, which will be added to the corresponding inventory list.</param>
    public void ViewObjectContents(uint object_id, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, uint, int, void>)0x005596B0)(ref this, object_id, a3);

    /// <summary>Stops monitoring an object's contents by clearing its interface reference and removing its inventory entry from the maintenance table.
    /// <code>Offset: 0x00559770
    /// void __thiscall ACCObjectMaint::StopViewingObjectContents(ACCObjectMaint*,unsigned int)</code>
    /// </summary>
    /// <param name="object_id">The identifier of the object whose contents should no longer be viewed.</param>
    public void StopViewingObjectContents(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, uint, void>)0x00559770)(ref this, object_id);

    /// <summary>Updates the inventory placement list of a specific object within the maintenance system.
    /// <code>Offset: 0x0055A190
    /// _DWORD* __thiscall ACCObjectMaint::UpdateObjectInventory(CObjectMaint*,unsigned int,int)</code>
    /// </summary>
    /// <param name="object_id">The unique identifier of the object whose inventory is being updated.</param>
    /// <param name="a3">Data used to modify the object's inventory placement, typically an update flag or new placement information.</param>
    /// <returns>Pointer to the resulting inventory placement structure after applying the update.</returns>
    public int* UpdateObjectInventory(uint object_id, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCObjectMaint, uint, int, int*>)0x0055A190)(ref this, object_id, a3);
}

