namespace ACBindings.Internal;


/// <summary>Provides client‑side object maintenance by combining a base client system with an object maintainer, handling creation, deletion, and quality updates for in‑world objects.</summary>
/// <remarks>Inherits core client functionality from ClientSystem and object management capabilities from ACCObjectMaint, enabling the client to track, update, and synchronize physics and weenie data within the game world.</remarks>
public unsafe struct ClientObjMaintSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem
    public ACBindings.Internal.ACCObjectMaint BaseClass_ACCObjectMaint; // ACBindings.Internal.ACCObjectMaint

    // Child Types
    public unsafe struct ClientObjMaintSystem_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnStartup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnBeginCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnEndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnShutdown; // function pointer

        // Methods
    }

    // Generated Constructor
    public ClientObjMaintSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a ClientObjMaintSystem instance, freeing its resources, resetting internal pointers, and invoking destructors of all base components.
    /// <code>Offset: 0x00558370
    /// void __thiscall ClientObjMaintSystem::~ClientObjMaintSystem(ClientObjMaintSystem*)</code>
    /// </summary>
    /// <param name="this">The ClientObjMaintSystem object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, void>)0x00558370)(ref this);

    /// <summary>Retrieves the weenie object identified by the specified ID from the global client object maintainer, returning a pointer to its ACCWeenieObject structure.
    /// <code>Offset: 0x005583F0
    /// ACCWeenieObject* __cdecl ClientObjMaintSystem::GetWeenieObject(unsigned int)</code>
    /// </summary>
    /// <param name="i_iid">The unique identifier of the desired weenie object.</param>
    /// <returns>A pointer to the corresponding ACCWeenieObject if found; otherwise null.</returns>
    public static ACBindings.Internal.ACCWeenieObject* GetWeenieObject(uint i_iid) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.ACCWeenieObject*>)0x005583F0)(i_iid);

    /// <summary>Retrieves a physics object by its identifier from the global object maintainer, returning nullptr when no instance exists.
    /// <code>Offset: 0x00558410
    /// CPhysicsObj* __cdecl ClientObjMaintSystem::GetPhysicsObject(unsigned int)</code>
    /// </summary>
    /// <param name="i_iid">Identifier of the desired physics object.</param>
    /// <returns>The requested CPhysicsObj pointer or nullptr if unavailable.</returns>
    public static ACBindings.Internal.CPhysicsObj* GetPhysicsObject(uint i_iid) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CPhysicsObj*>)0x00558410)(i_iid);

    /// <summary>Releases a reference to this ClientObjMaintSystem instance, decrementing its internal reference counter and freeing resources when the count reaches zero.
    /// <code>Offset: 0x00558490
    /// unsigned int __thiscall ClientObjMaintSystem::Release(ClientObjMaintSystem*)</code>
    /// </summary>
    /// <returns>The updated reference count after decrement; zero indicates that the object has been fully released.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, uint>)0x00558490)(ref this);

    /// <summary>Retrieves an interface implementation identified by the supplied GUID from this system, storing the resulting interface pointer in o_ppvInterface and reporting success or failure via result.
    /// <code>Offset: 0x00558540
    /// TResult* __thiscall ClientObjMaintSystem::QueryInterface(ClientObjMaintSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="this">The ClientObjMaintSystem instance performing the query.</param>
    /// <param name="result">Out parameter used to receive the status code (0 for success, -2147467262 if not found).</param>
    /// <param name="i_rcInterface">GUID of the requested interface.</param>
    /// <param name="o_ppvInterface">Output pointer set to the located interface implementation; remains unchanged if no match is found.</param>
    /// <returns>Returns the TResult object passed in, containing the operation status code.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00558540)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Retrieves an interface instance identified by a GUID from the client object maintenance system.
    /// <code>Offset: 0x00558630
    /// TResult* __thiscall ClientObjMaintSystem::QueryInterface(TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Pointer used to receive the queried interface, if provided.</param>
    /// <param name="a2">GUID specifying the desired interface type.</param>
    /// <param name="a3">Output parameter that receives the queried interface pointer if found.</param>
    /// <returns>Interface pointer matching the requested GUID, or nullptr if not available.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.Turbine_GUID* a2, void** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00558630)(ref this, a2, a3);

    /// <summary>Updates a weenie object's stack size after validating its stamper and confirming the current maximum stack size meets a required threshold.
    /// <code>Offset: 0x005587E0
    /// bool __thiscall ClientObjMaintSystem::UpdateStackSize(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="ts">The timestamp used to validate or update the object's stamper.</param>
    /// <param name="item">Identifier of the object whose stack size may be updated.</param>
    /// <param name="amount">Minimum maxStackSize that must be satisfied before the stack size is changed.</param>
    /// <param name="newValue">Desired new stack size to assign if conditions are met.</param>
    /// <returns>True if stamp validation and timestamp update succeeded; otherwise, false.</returns>
    public byte UpdateStackSize(byte ts, uint item, uint amount, uint newValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint, byte>)0x005587E0)(ref this, ts, item, amount, newValue);

    /// <summary>Removes an integer quality stat identified by stype from the object with ID object_id, updating its stamper timestamp to new_ts and notifying the QualityRegistrar.
    /// <code>Offset: 0x005590B0
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;Int_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="stype">The identifier of the stat to remove.</param>
    /// <param name="new_ts">The new timestamp value applied to the object's stamper during removal.</param>
    /// <param name="object_id">The unique ID of the object whose quality is being modified.</param>
    /// <returns>Zero (unused as a success indicator).</returns>
    public static int RemoveStat__Int_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x005590B0)(stype, new_ts, object_id);

    /// <summary>Removes an Int64 quality stat of the specified type from the target object, updating its stamper and notifying registered handlers.
    /// <code>Offset: 0x00559130
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;Int64_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="stype">Identifier of the stat to remove.</param>
    /// <param name="new_ts">New timestamp applied to the object's stamper if update succeeds.</param>
    /// <param name="object_id">Unique identifier of the object whose stat is being removed.</param>
    /// <returns>Zero on completion (no error reported).</returns>
    public static int RemoveStat__Int64_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x00559130)(stype, new_ts, object_id);

    /// <summary>Removes a Boolean quality stat from the specified object, updates its timestamp, and invokes any associated quality‑removal handlers.
    /// <code>Offset: 0x005591B0
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;Bool_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="stype">Identifier of the stat type to be removed.</param>
    /// <param name="new_ts">Timestamp value used when updating the object's stamper for this removal.</param>
    /// <param name="object_id">Unique ID of the object from which the stat is removed.</param>
    /// <returns>Always returns zero; callers should not rely on a non‑zero value for error handling.</returns>
    public static int RemoveStat__Bool_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x005591B0)(stype, new_ts, object_id);

    /// <summary>Removes a floating-point quality stat from the specified object, updates its timestamp and triggers any registered removal handlers.
    /// <code>Offset: 0x00559230
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;Float_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="stype">The identifier of the quality stat to remove.</param>
    /// <param name="new_ts">New timestamp value applied to the stat's stamper during removal.</param>
    /// <param name="object_id">Unique ID of the object from which the stat is removed.</param>
    /// <returns>Zero, indicating that the operation was performed (no error code).</returns>
    public static int RemoveStat__Float_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x00559230)(stype, new_ts, object_id);

    /// <summary>Removes a string-based quality stat identified by <paramref name="stype"/> from the weenie object with <paramref name="object_id"/>, updates its timestamp to <paramref name="new_ts"/>, and triggers any registered remove handlers.
    /// <code>Offset: 0x005592B0
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;String_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="stype">The identifier of the quality stat to be removed.</param>
    /// <param name="new_ts">The new timestamp value applied during removal.</param>
    /// <param name="object_id">The unique ID of the object whose quality is being modified.</param>
    /// <returns>Always returns 0, indicating completion of the operation.</returns>
    public static int RemoveStat__String_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x005592B0)(stype, new_ts, object_id);

    /// <summary>Removes a quality stat identified by <paramref name="stype"/> from the specified object, updates its stamp timestamp, and triggers any registered removal callbacks.
    /// <code>Offset: 0x00559330
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;DataID_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="stype">Identifier of the stat to remove.</param>
    /// <param name="new_ts">New timestamp value for updating the object's stamper.</param>
    /// <param name="object_id">ID of the target object whose stat is being removed.</param>
    /// <returns>Zero on completion. The function currently always returns 0.</returns>
    public static int RemoveStat__DataID_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x00559330)(stype, new_ts, object_id);

    /// <summary>Removes a stat of type <paramref name="stype"/> from the specified object, updates its timestamp to <paramref name="new_ts"/>, and notifies the quality registrar.
    /// <code>Offset: 0x005593B0
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;InstanceID_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="stype">Identifier of the statistic to remove.</param>
    /// <param name="new_ts">New timestamp value applied during removal.</param>
    /// <param name="object_id">ID of the object whose stat is being removed.</param>
    /// <returns>Zero (function currently returns 0 regardless of outcome).</returns>
    public static int RemoveStat__InstanceID_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x005593B0)(stype, new_ts, object_id);

    /// <summary>Removes a Position quality stat from the specified object, updating its stamper and notifying registered handlers.
    /// <code>Offset: 0x00559430
    /// int __stdcall ClientObjMaintSystem::RemoveStat&lt;Position_QualityType&gt;(unsigned int,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="stype">The type ID of the stat to remove.</param>
    /// <param name="new_ts">Timestamp used when updating the object's stamper.</param>
    /// <param name="object_id">Unique identifier of the weenie whose stat is being removed.</param>
    /// <returns>Zero on completion (the function always returns 0).</returns>
    public static int RemoveStat__Position_QualityType(uint stype, byte new_ts, uint object_id) => ((delegate* unmanaged[Stdcall]<uint, byte, uint, int>)0x00559430)(stype, new_ts, object_id);

    /// <summary>Initializes a ClientObjMaintSystem instance by setting up its vtables and registering the class with InterfaceSystem for later use.
    /// <code>Offset: 0x005597B0
    /// void __thiscall ClientObjMaintSystem::ClientObjMaintSystem(ClientObjMaintSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, void>)0x005597B0)(ref this);

    /// <summary>Cleans up the client object maintenance system during shutdown by unregistering it from the interface system and invoking base class cleanup routines.
    /// <code>Offset: 0x00559860
    /// void __thiscall ClientObjMaintSystem::OnShutdown(ClientObjMaintSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, void>)0x00559860)(ref this);

    /// <summary>Updates a quality attribute for an object, delegating to the generic UpdateStat routine.
    /// <code>Offset: 0x005598C0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateAttribute(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,Attribute*)</code>
    /// </summary>
    /// <param name="wts">Weight or flag parameter influencing the update behavior.</param>
    /// <param name="sender">Identifier of the entity requesting the quality change.</param>
    /// <param name="stype">Stat type specifying which quality attribute to modify.</param>
    /// <param name="val">Pointer to an Attribute structure containing the new quality values.</param>
    /// <returns>Result code from UpdateStat, indicating success or failure of the operation.</returns>
    public uint Handle_Qualities__UpdateAttribute(byte wts, uint sender, uint stype, ACBindings.Internal.Attribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, ACBindings.Internal.Attribute*, uint>)0x005598C0)(ref this, wts, sender, stype, val);

    /// <summary>Updates an attribute quality stat for the client object maintenance system using the specified type and value.
    /// <code>Offset: 0x005598E0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateAttributeLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)</code>
    /// </summary>
    /// <param name="wts">Identifier specifying which quality attribute to update.</param>
    /// <param name="sender">Unique ID of the sender requesting the update.</param>
    /// <param name="stype">Stat type code that determines the specific quality attribute to modify.</param>
    /// <param name="val">New value for the specified quality stat.</param>
    /// <returns>Resulting updated attribute level or status code indicating success or failure.</returns>
    public uint Handle_Qualities__UpdateAttributeLevel(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x005598E0)(ref this, wts, sender, stype, val);

    /// <summary>Updates a secondary attribute quality using provided parameters and returns a status code.
    /// <code>Offset: 0x00559900
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateAttribute2nd(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,SecondaryAttribute*)</code>
    /// </summary>
    /// <param name="wts">Flag or qualifier used to determine how the quality update should be processed.</param>
    /// <param name="sender">Identifier of the entity that initiated the update request.</param>
    /// <param name="stype">Subtype identifier specifying which secondary attribute quality is being updated.</param>
    /// <param name="val">Pointer to the new value for the secondary attribute, including current level and base data.</param>
    /// <returns>Status code indicating the result of the update operation (e.g., success or failure).</returns>
    public uint Handle_Qualities__UpdateAttribute2nd(byte wts, uint sender, uint stype, ACBindings.Internal.SecondaryAttribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, ACBindings.Internal.SecondaryAttribute*, uint>)0x00559900)(ref this, wts, sender, stype, val);

    /// <summary>Updates a second‑level quality attribute for an object by forwarding the call to the generic UpdateStat routine.
    /// <code>Offset: 0x00559920
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateAttribute2ndLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)</code>
    /// </summary>
    /// <param name="wts">Flag identifying the quality type to be updated.</param>
    /// <param name="sender">Identifier of the entity initiating the update.</param>
    /// <param name="stype">Sub‑type or index of the specific quality attribute within the second level.</param>
    /// <param name="val">New value for the quality attribute.</param>
    /// <returns>Unsigned integer status code returned by UpdateStat, indicating success or failure.</returns>
    public uint Handle_Qualities__UpdateAttribute2ndLevel(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x00559920)(ref this, wts, sender, stype, val);

    /// <summary>Updates a skill quality for an object using provided parameters.
    /// <code>Offset: 0x00559940
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateSkill(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,Skill*)</code>
    /// </summary>
    /// <param name="wts">Specifies the quality type to update.</param>
    /// <param name="sender">Identifier of the entity initiating the update.</param>
    /// <param name="stype">Stat type identifier associated with the update.</param>
    /// <param name="val">Skill structure containing updated values.</param>
    /// <returns>Result code indicating success or failure of the update operation.</returns>
    public uint Handle_Qualities__UpdateSkill(byte wts, uint sender, uint stype, ACBindings.Internal.Skill* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, ACBindings.Internal.Skill*, uint>)0x00559940)(ref this, wts, sender, stype, val);

    /// <summary>Processes a skill level quality update by delegating to UpdateStat and returning the operation's result.
    /// <code>Offset: 0x00559960
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateSkillLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)</code>
    /// </summary>
    /// <param name="wts">Quality type identifier specifying which skill quality to update.</param>
    /// <param name="sender">Identifier of the object initiating the update.</param>
    /// <param name="stype">Stat type identifier used by the internal stat system.</param>
    /// <param name="val">New value for the specified skill quality.</param>
    /// <returns>Result code indicating success (0) or failure (>0).</returns>
    public uint Handle_Qualities__UpdateSkillLevel(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x00559960)(ref this, wts, sender, stype, val);

    /// <summary>Updates the quality of a specified skill for a client object and returns the result of the underlying update operation.
    /// <code>Offset: 0x00559980
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateSkillAC(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,SKILL_ADVANCEMENT_CLASS)</code>
    /// </summary>
    /// <param name="wts">Weight or type specifier influencing how the quality is applied.</param>
    /// <param name="sender">Identifier of the entity requesting the update.</param>
    /// <param name="stype">Skill identifier whose quality is being updated.</param>
    /// <param name="val">New skill advancement class value to set for the specified skill.</param>
    /// <returns>Unsigned integer result code from UpdateStat indicating success or failure.</returns>
    public uint Handle_Qualities__UpdateSkillAC(byte wts, uint sender, uint stype, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, uint>)0x00559980)(ref this, wts, sender, stype, val);

    /// <summary>Updates an integer quality statistic for an object in the client maintenance system.
    /// <code>Offset: 0x005599A0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateInt(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)</code>
    /// </summary>
    /// <param name="wts">Identifier specifying the particular quality to update.</param>
    /// <param name="sender">ID of the entity initiating the update.</param>
    /// <param name="stype">Subtype or category of the stat being modified.</param>
    /// <param name="val">New integer value for the specified quality.</param>
    /// <returns>Unsigned int status code indicating success (e.g., 0) or failure of the update operation.</returns>
    public uint Handle_Qualities__UpdateInt(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x005599A0)(ref this, wts, sender, stype, val);

    /// <summary>Updates a 64‑bit quality value for an object, delegating the work to the generic stat updater.
    /// <code>Offset: 0x005599C0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateInt64(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,__int64)</code>
    /// </summary>
    /// <param name="wts">Specifies the target or scope of the quality change (e.g., which client(s) should receive the update).</param>
    /// <param name="sender">Identifier of the entity that initiated the update.</param>
    /// <param name="stype">Quality type identifier indicating which quality is being updated.</param>
    /// <param name="val">New 64‑bit value to assign to the specified quality.</param>
    /// <returns>Result code returned by the stat updater, indicating success or failure.</returns>
    public uint Handle_Qualities__UpdateInt64(byte wts, uint sender, uint stype, long val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, long, uint>)0x005599C0)(ref this, wts, sender, stype, val);

    /// <summary>Handles an update to a Boolean quality for an object by delegating to UpdateStat.
    /// <code>Offset: 0x005599F0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateBool(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,int)</code>
    /// </summary>
    /// <param name="wts">Write type or context indicator for the update operation.</param>
    /// <param name="sender">Identifier of the entity initiating the update.</param>
    /// <param name="stype">Stat identifier specifying which Boolean quality is being updated.</param>
    /// <param name="val">New value for the Boolean quality.</param>
    /// <returns>Result status code from UpdateStat indicating success or failure.</returns>
    public uint Handle_Qualities__UpdateBool(byte wts, uint sender, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int, uint>)0x005599F0)(ref this, wts, sender, stype, val);

    /// <summary>Updates a floating‑point quality stat identified by stype for an object, delegating to UpdateStat with the provided context and value.
    /// <code>Offset: 0x00559A10
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateFloat(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,long double)</code>
    /// </summary>
    /// <param name="wts">Contextual information or target identifier for the stat update.</param>
    /// <param name="sender">Identifier of the entity requesting the update.</param>
    /// <param name="stype">Quality type ID specifying which statistic to modify.</param>
    /// <param name="val">New floating‑point value to apply to the quality.</param>
    /// <returns>Unsigned integer status code from UpdateStat, typically zero for success and non‑zero for failure.</returns>
    public uint Handle_Qualities__UpdateFloat(byte wts, uint sender, uint stype, double val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, double, uint>)0x00559A10)(ref this, wts, sender, stype, val);

    /// <summary>Updates a string-quality attribute on a client-maintained object using the supplied identifiers and value.
    /// <code>Offset: 0x00559A40
    /// int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateString(void*,unsigned __int8,unsigned int,unsigned int,int*)</code>
    /// </summary>
    /// <param name="this">The ClientObjMaintSystem instance that owns the object to be updated.</param>
    /// <param name="a2">Indicator or modifier for the quality update (e.g., a flag or enum value).</param>
    /// <param name="a3">Quality key identifying which string attribute to modify.</param>
    /// <param name="a4">Identifier of the target object whose quality is being updated.</param>
    /// <param name="a5">Optional pointer to an integer where the function writes a status code or result.</param>
    /// <returns>Integer status code indicating success (non‑zero) or failure (zero).</returns>
    public int Handle_Qualities__UpdateString(byte a2, uint a3, uint a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int*, int>)0x00559A40)(ref this, a2, a3, a4, a5);

    /// <summary>Updates an object’s quality stat identified by a DataID, delegating to UpdateStat with the supplied parameters.
    /// <code>Offset: 0x00559A60
    /// int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateDataID(void*,unsigned __int8,unsigned int,unsigned int,int)</code>
    /// </summary>
    /// <param name="qualityFlag">The type or flag indicating which quality category to modify.</param>
    /// <param name="newValue">The new value to apply to the quality stat.</param>
    /// <param name="dataId">Identifier specifying which quality data entry to update.</param>
    /// <param name="flags">Additional flags influencing the update operation.</param>
    /// <returns>The result of UpdateStat, typically zero on success.</returns>
    public int Handle_Qualities__UpdateDataID(byte a2, uint a3, uint a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, int, int>)0x00559A60)(ref this, a2, a3, a4, a5);

    /// <summary>Updates an instance ID quality for a specified object and returns a status code.
    /// <code>Offset: 0x00559A80
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdateInstanceID(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Quality type identifier or update flags used when setting the quality.</param>
    /// <param name="sender">Object identifier whose quality is being updated.</param>
    /// <param name="stype">Subtype or specific quality field to modify.</param>
    /// <param name="val">New instance ID value for the quality.</param>
    /// <returns>Zero on success, non‑zero status code otherwise.</returns>
    public uint Handle_Qualities__UpdateInstanceID(byte wts, uint sender, uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint, uint>)0x00559A80)(ref this, wts, sender, stype, val);

    /// <summary>Processes a position quality update by delegating to the underlying stat updater.
    /// <code>Offset: 0x00559AA0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__UpdatePosition(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int,const Position*)</code>
    /// </summary>
    /// <param name="wts">Identifier for the specific quality subtype associated with the position update.</param>
    /// <param name="sender">ID of the object that originated the update request.</param>
    /// <param name="stype">Stat identifier indicating which quality is being updated.</param>
    /// <param name="val">Pointer to the Position structure containing new coordinates and frame data.</param>
    /// <returns>Result code from the UpdateStat operation, typically zero on success or a non‑zero error value.</returns>
    public uint Handle_Qualities__UpdatePosition(byte wts, uint sender, uint stype, ACBindings.Internal.Position* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, ACBindings.Internal.Position*, uint>)0x00559AA0)(ref this, wts, sender, stype, val);

    /// <summary>Handles updating a quality attribute for an object, forwarding the request to the system’s update routine with context from the current smartbox.
    /// <code>Offset: 0x00559AC0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateAttribute(ClientObjMaintSystem*,unsigned __int8,unsigned int,Attribute*)</code>
    /// </summary>
    /// <param name="wts">Index or flag indicating which quality slot or modifier is targeted.</param>
    /// <param name="stype">Identifier specifying the specific quality type being updated.</param>
    /// <param name="val">Pointer to an Attribute structure containing new attribute data and level information.</param>
    /// <returns>Result code from UpdateStat indicating success or failure of the update operation.</returns>
    public uint Handle_Qualities__PrivateUpdateAttribute(byte wts, uint stype, ACBindings.Internal.Attribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, ACBindings.Internal.Attribute*, uint>)0x00559AC0)(ref this, wts, stype, val);

    /// <summary>Updates an object's quality attribute level by calling UpdateStat with the supplied type, value, and a context value from SmartBox if present.
    /// <code>Offset: 0x00559AF0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateAttributeLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)</code>
    /// </summary>
    /// <param name="wts">Identifier for the quality slot or sub‑type involved in the update.</param>
    /// <param name="stype">The stat identifier indicating which quality attribute to modify.</param>
    /// <param name="val">The new level or value to assign to the specified quality attribute.</param>
    /// <returns>An unsigned integer status code returned by UpdateStat, typically indicating success or failure of the operation.</returns>
    public uint Handle_Qualities__PrivateUpdateAttributeLevel(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int, uint>)0x00559AF0)(ref this, wts, stype, val);

    /// <summary>Updates the secondary quality attribute of an object by invoking UpdateStat with the supplied SecondaryAttribute data.
    /// <code>Offset: 0x00559B20
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateAttribute2nd(ClientObjMaintSystem*,unsigned __int8,unsigned int,SecondaryAttribute*)</code>
    /// </summary>
    /// <param name="wts">Flag or modifier influencing how the update is applied.</param>
    /// <param name="stype">Identifier for the specific stat type to modify.</param>
    /// <param name="val">Pointer to a SecondaryAttribute instance containing the new level information.</param>
    /// <returns>Result code produced by UpdateStat, indicating success or failure of the operation.</returns>
    public uint Handle_Qualities__PrivateUpdateAttribute2nd(byte wts, uint stype, ACBindings.Internal.SecondaryAttribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, ACBindings.Internal.SecondaryAttribute*, uint>)0x00559B20)(ref this, wts, stype, val);

    /// <summary>Updates a second‑level quality attribute by retrieving an auxiliary value from SmartBox when available and delegating to the generic stat update routine.
    /// <code>Offset: 0x00559B50
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateAttribute2ndLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)</code>
    /// </summary>
    /// <param name="wts">Quality subtype identifier used in the update.</param>
    /// <param name="stype">Stat type code representing the specific quality to modify.</param>
    /// <param name="val">New integer value for the quality attribute.</param>
    /// <returns>Status code from UpdateStat indicating success or failure of the operation.</returns>
    public uint Handle_Qualities__PrivateUpdateAttribute2ndLevel(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int, uint>)0x00559B50)(ref this, wts, stype, val);

    /// <summary>Updates a skill's quality stat for the client object maintenance system using data from the provided Skill instance and an optional SmartBox context.
    /// <code>Offset: 0x00559B80
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateSkill(ClientObjMaintSystem*,unsigned __int8,unsigned int,Skill*)</code>
    /// </summary>
    /// <param name="wts">Identifier indicating what aspect of the skill to update.</param>
    /// <param name="stype">Skill type identifier used in the update operation.</param>
    /// <param name="val">Pointer to a Skill structure containing the values for the update.</param>
    /// <returns>Result code returned by UpdateStat, typically indicating success or failure of the stat update.</returns>
    public uint Handle_Qualities__PrivateUpdateSkill(byte wts, uint stype, ACBindings.Internal.Skill* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, ACBindings.Internal.Skill*, uint>)0x00559B80)(ref this, wts, stype, val);

    /// <summary>Updates a skill quality statistic for the client object, applying an optional SmartBox weight adjustment.
    /// <code>Offset: 0x00559BB0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateSkillLevel(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)</code>
    /// </summary>
    /// <param name="wts">Weight parameter used when updating the statistic.</param>
    /// <param name="stype">Identifier of the skill quality type to update.</param>
    /// <param name="val">New value or delta for the statistic.</param>
    /// <returns>Result from the UpdateStat operation, typically indicating success or providing the updated value.</returns>
    public uint Handle_Qualities__PrivateUpdateSkillLevel(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int, uint>)0x00559BB0)(ref this, wts, stype, val);

    /// <summary>Updates a skill quality stat for the client object using an advancement class and optional smart‑box data.
    /// <code>Offset: 0x00559BE0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateSkillAC(ClientObjMaintSystem*,unsigned __int8,unsigned int,SKILL_ADVANCEMENT_CLASS)</code>
    /// </summary>
    /// <param name="wts">Weight or subtype modifier applied to the skill update.</param>
    /// <param name="stype">Identifier of the skill quality being updated.</param>
    /// <param name="val">Skill advancement class determining how the stat changes.</param>
    /// <returns>Result code from UpdateStat, indicating success or the updated value.</returns>
    public uint Handle_Qualities__PrivateUpdateSkillAC(byte wts, uint stype, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, uint>)0x00559BE0)(ref this, wts, stype, val);

    /// <summary>Updates an integer quality statistic for the client object maintenance system, optionally incorporating a context value from SmartBox.
    /// <code>Offset: 0x00559C10
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateInt(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)</code>
    /// </summary>
    /// <param name="wts">Qualifier specifying the target or mode of the update operation.</param>
    /// <param name="stype">Identifier of the quality type to modify.</param>
    /// <param name="val">New integer value assigned to the specified quality.</param>
    /// <returns>Result code returned by UpdateStat, indicating success or failure of the update.</returns>
    public uint Handle_Qualities__PrivateUpdateInt(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int, uint>)0x00559C10)(ref this, wts, stype, val);

    /// <summary>Updates an Int64 quality stat for the client object system with the supplied write type and value, using a global smartbox context if available.
    /// <code>Offset: 0x00559C40
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateInt64(ClientObjMaintSystem*,unsigned __int8,unsigned int,__int64)</code>
    /// </summary>
    /// <param name="wts">The write type indicating how the update should be applied.</param>
    /// <param name="stype">Identifier of the quality stat to modify.</param>
    /// <param name="val">New 64‑bit integer value for the stat.</param>
    /// <returns>Result code from UpdateStat, typically a status flag or error indicator.</returns>
    public uint Handle_Qualities__PrivateUpdateInt64(byte wts, uint stype, long val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, long, uint>)0x00559C40)(ref this, wts, stype, val);

    /// <summary>Updates a boolean quality attribute on an object using the specified type and identifier with the provided value.
    /// <code>Offset: 0x00559C70
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateBool(ClientObjMaintSystem*,unsigned __int8,unsigned int,int)</code>
    /// </summary>
    /// <param name="wts">Identifier specifying which quality attribute to modify.</param>
    /// <param name="stype">Stat type code used by the update operation.</param>
    /// <param name="val">The new boolean value for the quality attribute (typically 0 or 1).</param>
    /// <returns>Status of the update operation, indicating success or failure.</returns>
    public uint Handle_Qualities__PrivateUpdateBool(byte wts, uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int, uint>)0x00559C70)(ref this, wts, stype, val);

    /// <summary>Updates a float-quality stat for a client object, applying the specified type, weight and new value. If a SmartBox is active, its context ID influences the update.
    /// <code>Offset: 0x00559CA0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateFloat(ClientObjMaintSystem*,unsigned __int8,unsigned int,long double)</code>
    /// </summary>
    /// <param name="wts">Weight or source index used during the quality statistic update.</param>
    /// <param name="stype">Identifier of the quality statistic to modify.</param>
    /// <param name="val">New floating-point value for the specified quality.</param>
    /// <returns>Unsigned integer status code indicating success (non-zero) or failure (zero).</returns>
    public uint Handle_Qualities__PrivateUpdateFloat(byte wts, uint stype, double val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, double, uint>)0x00559CA0)(ref this, wts, stype, val);

    /// <summary>Updates an object's quality string using the supplied type and value while accounting for the current SmartBox context.
    /// <code>Offset: 0x00559CD0
    /// int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateString(void*,unsigned __int8,unsigned int,int*)</code>
    /// </summary>
    /// <param name="a2">The quality subtype (typically a small integer) to apply.</param>
    /// <param name="a3">Identifier of the quality attribute being updated.</param>
    /// <param name="a4">Pointer to an integer that receives status or additional data from the update operation.</param>
    /// <returns>Result code returned by UpdateStat indicating success or failure of the update.</returns>
    public int Handle_Qualities__PrivateUpdateString(byte a2, uint a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int*, int>)0x00559CD0)(ref this, a2, a3, a4);

    /// <summary>Updates a client's object quality stat identified by the provided DataID and quality type, optionally using global smartbox state as a fallback.
    /// <code>Offset: 0x00559D00
    /// int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateDataID(void*,unsigned __int8,unsigned int,int)</code>
    /// </summary>
    /// <param name="a2">Quality type identifier (0‑255).</param>
    /// <param name="a3">Data ID used to locate the specific stat entry.</param>
    /// <param name="a4">Additional modifier or flag passed to UpdateStat.</param>
    /// <returns>Integer status code from UpdateStat indicating success or failure.</returns>
    public int Handle_Qualities__PrivateUpdateDataID(byte a2, uint a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, int, int>)0x00559D00)(ref this, a2, a3, a4);

    /// <summary>Updates a quality statistic for the client object using the specified type, weight flag, and the current SmartBox instance context.
    /// <code>Offset: 0x00559D30
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdateInstanceID(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Weighting or flag value influencing how the stat is applied.</param>
    /// <param name="stype">Identifier of the quality statistic to update.</param>
    /// <param name="val">New value for the specified statistic.</param>
    /// <returns>Result code from the underlying UpdateStat call, indicating success or failure of the update.</returns>
    public uint Handle_Qualities__PrivateUpdateInstanceID(byte wts, uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559D30)(ref this, wts, stype, val);

    /// <summary>Updates position-based qualities for a client object by delegating to the generic UpdateStat routine.
    /// <code>Offset: 0x00559D60
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateUpdatePosition(ClientObjMaintSystem*,unsigned __int8,unsigned int,const Position*)</code>
    /// </summary>
    /// <param name="wts">Specifies the weight or type flag used in quality calculation.</param>
    /// <param name="stype">Identifies the stat type being updated.</param>
    /// <param name="val">Pointer to a Position structure containing new coordinates and related data.</param>
    /// <returns>Result code from UpdateStat indicating success or failure.</returns>
    public uint Handle_Qualities__PrivateUpdatePosition(byte wts, uint stype, ACBindings.Internal.Position* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, ACBindings.Internal.Position*, uint>)0x00559D60)(ref this, wts, stype, val);

    /// <summary>Removes an integer quality from a client object by delegating to RemoveStat for Int_QualityType.
    /// <code>Offset: 0x00559D90
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveIntEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Specifies the quality type to remove.</param>
    /// <param name="sender">Identifier of the entity initiating the removal.</param>
    /// <param name="stype">The stat type identifier used in the removal operation.</param>
    /// <returns>Result code indicating success or failure of the removal operation.</returns>
    public uint Handle_Qualities__RemoveIntEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559D90)(ref this, wts, sender, stype);

    /// <summary>Handles removal of an Int64 quality event by delegating to RemoveStat and returning its result.
    /// <code>Offset: 0x00559DB0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveInt64Event(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Identifier for the quality category involved in the event.</param>
    /// <param name="sender">ID of the entity that initiated the event.</param>
    /// <param name="stype">Specific quality type to be removed.</param>
    /// <returns>Result code from RemoveStat indicating success or failure.</returns>
    public uint Handle_Qualities__RemoveInt64Event(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559DB0)(ref this, wts, sender, stype);

    /// <summary>Removes a boolean-quality event from the client object maintenance system for a specified sender and quality type.
    /// <code>Offset: 0x00559DD0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveBoolEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Specifies the quality subtype to remove.</param>
    /// <param name="sender">Identifier of the object that generated the event.</param>
    /// <param name="stype">Quality type identifier used in the removal operation.</param>
    /// <returns>Unsigned integer status code returned by RemoveStat indicating success or failure.</returns>
    public uint Handle_Qualities__RemoveBoolEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559DD0)(ref this, wts, sender, stype);

    /// <summary>Removes a floating‑point quality stat of the specified type from the client object maintenance system.
    /// <code>Offset: 0x00559DF0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveFloatEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Weight or modifier value associated with the quality event to remove.</param>
    /// <param name="sender">Identifier of the entity that requested the removal operation.</param>
    /// <param name="stype">Numeric identifier of the quality stat to be removed.</param>
    /// <returns>Unsigned integer status code returned by the removal operation, indicating success or failure.</returns>
    public uint Handle_Qualities__RemoveFloatEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559DF0)(ref this, wts, sender, stype);

    /// <summary>Handles removal of a string quality event by delegating to RemoveStat&lt;String_QualityType&gt;. 
    /// <code>Offset: 0x00559E10
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveStringEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Specifies the world or context for the operation.</param>
    /// <param name="sender">Identifier of the object initiating the removal.</param>
    /// <param name="stype">Stat type identifier representing the specific quality to remove.</param>
    /// <returns>Result status code from RemoveStat&lt;String_QualityType&gt;. </returns>
    public uint Handle_Qualities__RemoveStringEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559E10)(ref this, wts, sender, stype);

    /// <summary>Processes a request to remove a quality data ID stat by delegating to the generic stat removal routine.
    /// <code>Offset: 0x00559E30
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveDataIDEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Identifier specifying the event type or context.</param>
    /// <param name="sender">Object identifier that initiated the removal.</param>
    /// <param name="stype">Stat type identifier for the quality to be removed.</param>
    /// <returns>Result code from RemoveStat indicating success or failure.</returns>
    public uint Handle_Qualities__RemoveDataIDEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559E30)(ref this, wts, sender, stype);

    /// <summary>Removes an InstanceID quality stat from an object when a remove event is received.
    /// <code>Offset: 0x00559E50
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemoveInstanceIDEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="wts">The transaction stamp associated with the event.</param>
    /// <param name="sender">Identifier of the sender initiating the removal.</param>
    /// <param name="stype">Type identifier of the stat to be removed.</param>
    /// <returns>Zero on success, or a non‑zero error code if removal failed.</returns>
    public uint Handle_Qualities__RemoveInstanceIDEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559E50)(ref this, wts, sender, stype);

    /// <summary>Delegates removal of a position quality stat to the generic RemoveStat routine specialized for Position_QualityType.
    /// <code>Offset: 0x00559E70
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__RemovePositionEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Indicator of which quality type should be removed.</param>
    /// <param name="sender">Identifier of the object that triggered the removal event.</param>
    /// <param name="stype">Specific stat identifier corresponding to the position quality to remove.</param>
    /// <returns>Result code returned by RemoveStat; zero signals success, non‑zero indicates failure.</returns>
    public uint Handle_Qualities__RemovePositionEvent(byte wts, uint sender, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint, uint>)0x00559E70)(ref this, wts, sender, stype);

    /// <summary>Allocates memory for a new ClientObjMaintSystem instance, invokes its constructor, and returns a pointer to the constructed object.
    /// <code>Offset: 0x00559EA0
    /// ClientObjMaintSystem* __cdecl ClientObjMaintSystem::Allocate()</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated ClientObjMaintSystem, or null if allocation fails.</returns>
    public static ACBindings.Internal.ClientObjMaintSystem* Allocate() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientObjMaintSystem*>)0x00559EA0)();

    /// <summary>Removes an integer quality event for the specified stat type, using SmartBox data when available.
    /// <code>Offset: 0x00559EC0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveIntEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="wts">The weight or identifier used in the removal operation.</param>
    /// <param name="stype">The identifier of the stat type to remove.</param>
    /// <returns>The result code from the underlying RemoveStat call.</returns>
    public uint Handle_Qualities__PrivateRemoveIntEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x00559EC0)(ref this, wts, stype);

    /// <summary>Removes an Int64 quality event for the specified stat type and weight using SmartBox data when available.
    /// <code>Offset: 0x00559F00
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveInt64Event(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Weight or flag used to identify which statistic instance to remove.</param>
    /// <param name="stype">Identifier of the Int64 quality stat to be removed.</param>
    /// <returns>Return code from RemoveStat indicating success (non-zero) or failure (zero).</returns>
    public uint Handle_Qualities__PrivateRemoveInt64Event(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x00559F00)(ref this, wts, stype);

    /// <summary>Removes a Boolean quality event identified by <paramref name="stype"/> and <paramref name="wts"/> from the client object maintenance system, optionally using a SmartBox reference if available.
    /// <code>Offset: 0x00559F40
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveBoolEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Identifier or context value specifying which Boolean quality to target for removal.</param>
    /// <param name="stype">The stat type code that determines the specific quality event to remove.</param>
    /// <returns>Unsigned integer status indicating success (typically zero) or an error code returned by the underlying RemoveStat operation.</returns>
    public uint Handle_Qualities__PrivateRemoveBoolEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x00559F40)(ref this, wts, stype);

    /// <summary>Removes a floating-point quality stat from an object based on the supplied quality and stat type identifiers.
    /// <code>Offset: 0x00559F80
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveFloatEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Identifier of the quality to remove.</param>
    /// <param name="stype">Stat type identifier specifying the category of the float quality.</param>
    /// <returns>An unsigned integer status code indicating success (typically 0) or failure from RemoveStat&lt;Float_QualityType&gt;.</returns>
    public uint Handle_Qualities__PrivateRemoveFloatEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x00559F80)(ref this, wts, stype);

    /// <summary>Removes a quality string stat from the client object maintenance system based on the provided type and flag, delegating to RemoveStat with an optional SmartBox reference.
    /// <code>Offset: 0x00559FC0
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveStringEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Flag influencing how the stat is removed or which subset of objects it targets.</param>
    /// <param name="stype">Identifier of the stat type to remove.</param>
    /// <returns>Result code from ClientObjMaintSystem::RemoveStat indicating the outcome of the removal operation.</returns>
    public uint Handle_Qualities__PrivateRemoveStringEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x00559FC0)(ref this, wts, stype);

    /// <summary>Removes a quality data ID entry from the client object maintenance system based on the provided identifiers.
    /// <code>Offset: 0x0055A000
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveDataIDEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Quality data identifier to remove.</param>
    /// <param name="stype">Statistical type associated with the quality entry.</param>
    /// <returns>The status code returned by the underlying RemoveStat operation.</returns>
    public uint Handle_Qualities__PrivateRemoveDataIDEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x0055A000)(ref this, wts, stype);

    /// <summary>Removes an InstanceID quality statistic from the client object maintenance system based on the specified type and weight, utilizing the current smartbox state if available.
    /// <code>Offset: 0x0055A040
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemoveInstanceIDEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="wts">The weight value used when removing the stat.</param>
    /// <param name="stype">The identifier of the stat type to remove.</param>
    /// <returns>Number of stats removed or status code indicating success.</returns>
    public uint Handle_Qualities__PrivateRemoveInstanceIDEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x0055A040)(ref this, wts, stype);

    /// <summary>Removes a private position quality event from the client object maintenance system, optionally using data from SmartBox if available.
    /// <code>Offset: 0x0055A080
    /// unsigned int __thiscall ClientObjMaintSystem::Handle_Qualities__PrivateRemovePositionEvent(ClientObjMaintSystem*,unsigned __int8,unsigned int)</code>
    /// </summary>
    /// <param name="wts">Specifies the quality subtype to remove.</param>
    /// <param name="stype">Identifies the stat type for the removal operation.</param>
    /// <returns>The number of statistics removed, or a status code indicating success or failure.</returns>
    public uint Handle_Qualities__PrivateRemovePositionEvent(byte wts, uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, byte, uint, uint>)0x0055A080)(ref this, wts, stype);

    /// <summary>Increments the reference counter for a combat system object in a thread‑safe manner and returns the updated count.
    /// <code>Offset: 0x0056B950
    /// unsigned int __thiscall ClientObjMaintSystem::AddRef(ClientCombatSystem*)</code>
    /// </summary>
    /// <returns>The new reference count after the increment operation.</returns>
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientObjMaintSystem, uint>)0x0056B950)(ref this);
}

