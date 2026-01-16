namespace ACBindings.Internal;


/// <summary>Manages client‑side fellowship state, exposing the current CFellowship instance and handling reference counting for lifecycle control.</summary>
public unsafe struct ClientFellowshipSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem

    // Statics
    public static ACBindings.Internal.ClientFellowshipSystem** s_pFellowshipSystem = (ACBindings.Internal.ClientFellowshipSystem**)0x0087150C;

    // Child Types
    public unsafe struct ClientFellowshipSystem_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientFellowshipSystem*, ACBindings.Internal.ClientFellowshipSystem.Enum11> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientFellowshipSystem::Enum10
    public enum Enum10 : uint
    {
    }
    // ClientFellowshipSystem::Enum11
    public enum Enum11 : uint
    {
    }
    // ClientFellowshipSystem::Enum12
    public enum Enum12 : uint
    {
    }
    // ClientFellowshipSystem::Enum13
    public enum Enum13 : uint
    {
    }
    // ClientFellowshipSystem::Enum4
    public enum Enum4 : uint
    {
    }
    // ClientFellowshipSystem::Enum7
    public enum Enum7 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.Internal.CFellowship* m_pFellowship;

    // Generated Constructor
    public ClientFellowshipSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a ClientFellowshipSystem instance, releasing its internal references and performing cleanup for the embedded notice handler and ref‑counting resources.
    /// <code>Offset: 0x00569E00
    /// void __thiscall ClientFellowshipSystem::~ClientFellowshipSystem(ClientFellowshipSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x00569E00)(ref this);

    /// <summary>Returns the singleton instance of the client fellowship system.
    /// <code>Offset: 0x00569E30
    /// ClientFellowshipSystem* __cdecl ClientFellowshipSystem::GetFellowshipSystem()</code>
    /// </summary>
    /// <returns>A pointer to the ClientFellowshipSystem instance, or nullptr if not initialized.</returns>
    public static ACBindings.Internal.ClientFellowshipSystem* GetFellowshipSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientFellowshipSystem*>)0x00569E30)();

    /// <summary>Destroys the current fellowship object associated with the client, releasing its resources and clearing the reference at the end of a character session.
    /// <code>Offset: 0x00569E40
    /// void __thiscall ClientFellowshipSystem::OnEndCharacterSession(ClientFellowshipSystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x00569E40)(ref this);

    /// <summary>Updates the fellowship information for a member identified by <paramref name="id"/>, sending notifications to the client when a new member is added or when existing member data changes.
    /// <code>Offset: 0x00569E60
    /// unsigned int __thiscall ClientFellowshipSystem::Handle_Fellowship__UpdateFellow(ClientFellowshipSystem*,unsigned int,const Fellow*,unsigned int)</code>
    /// </summary>
    /// <param name="id">The unique identifier of the fellowship member being updated.</param>
    /// <param name="fellow">Pointer to a <c>Fellow</c> structure containing the new attribute values for the member.</param>
    /// <param name="updateType">Bitmask describing which attributes were modified in this update.</param>
    /// <returns>Zero on success; the function always returns 0 but the value can be interpreted as an operation status code.</returns>
    public uint Handle_Fellowship__UpdateFellow(uint id, ACBindings.Internal.Fellow* fellow, uint updateType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, uint, ACBindings.Internal.Fellow*, uint, uint>)0x00569E60)(ref this, id, fellow, updateType);

    /// <summary>Determines whether the specified identifier belongs to a member of the current fellowship.
    /// <code>Offset: 0x00569ED0
    /// bool __thiscall ClientFellowshipSystem::IsFellow(ClientFellowshipSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iid">The identifier to check for fellowship membership.</param>
    /// <returns>True if the identifier corresponds to a fellow; otherwise, false.</returns>
    public byte IsFellow(uint i_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, uint, byte>)0x00569ED0)(ref this, i_iid);

    /// <summary>Determines whether the specified character ID matches the leader of the client's active fellowship.
    /// <code>Offset: 0x00569EF0
    /// bool __thiscall ClientFellowshipSystem::IsFellowshipLeader(ClientFellowshipSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iid">The identifier of the character to verify against the fellowship's leader.</param>
    /// <returns>True when a valid fellowship exists and the supplied ID equals that of its leader; otherwise, false.</returns>
    public byte IsFellowshipLeader(uint i_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, uint, byte>)0x00569EF0)(ref this, i_iid);

    /// <summary>Retrieves an interface implemented by the fellowship system, returning success or error status in the supplied TResult structure.
    /// <code>Offset: 0x00569F10
    /// TResult* __thiscall ClientFellowshipSystem::QueryInterface(ClientFellowshipSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientFellowshipSystem instance.</param>
    /// <param name="result">Structure that receives the query outcome code; zero on success, otherwise an HRESULT.</param>
    /// <param name="i_rcInterface">GUID of the interface requested.</param>
    /// <param name="o_ppvInterface">Address where a pointer to the requested interface is stored upon successful query.</param>
    /// <returns>Pointer to the TResult structure passed in, with its status field set appropriately.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00569F10)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Decrements the object's reference count and deletes the instance when the count reaches zero.
    /// <code>Offset: 0x00569FE0
    /// unsigned int __thiscall ClientFellowshipSystem::Release(ClientFellowshipSystem*)</code>
    /// </summary>
    /// <returns>The reference count remaining after the release operation.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, uint>)0x00569FE0)(ref this);

    /// <summary>Initializes a new ClientFellowshipSystem instance by setting up virtual tables, establishing reference counting, clearing the fellowship pointer, and registering the object as the current system.
    /// <code>Offset: 0x0056A010
    /// void __thiscall ClientFellowshipSystem::ClientFellowshipSystem(ClientFellowshipSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x0056A010)(ref this);

    /// <summary>Handles a full update of the client’s fellowship data, creating or updating an internal CFellowship instance and broadcasting changes such as new leader assignment or member radar updates.
    /// <code>Offset: 0x0056A160
    /// unsigned int __thiscall ClientFellowshipSystem::Handle_Fellowship__FullUpdate(ClientFellowshipSystem*,const CFellowship*)</code>
    /// </summary>
    /// <param name="fellowship">The updated Fellowship information to apply to the client system.</param>
    /// <returns>Zero (always); used as a status code.</returns>
    public uint Handle_Fellowship__FullUpdate(ACBindings.Internal.CFellowship* fellowship) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, ACBindings.Internal.CFellowship*, uint>)0x0056A160)(ref this, fellowship);

    /// <summary>Selects the next fellowship member in the current fellowship list based on the globally selected ID, wrapping to the first member if the end of the list is reached.
    /// <code>Offset: 0x0056A290
    /// void __thiscall ClientFellowshipSystem::SelectNextFellow(ClientFellowshipSystem*)</code>
    /// </summary>
    public void SelectNextFellow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x0056A290)(ref this);

    /// <summary>Selects the preceding member within the current fellowship, updating the global selected object to that member’s ID.
    /// <code>Offset: 0x0056A360
    /// void __thiscall ClientFellowshipSystem::SelectPreviousFellow(ClientFellowshipSystem*)</code>
    /// </summary>
    /// <param name="this">The ClientFellowshipSystem instance on which to perform the selection.</param>
    public void SelectPreviousFellow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x0056A360)(ref this);

    /// <summary>Deletes the client's current fellowship, releasing its resources and notifying all associated members.
    /// <code>Offset: 0x0056AB50
    /// void __thiscall ClientFellowshipSystem::DeleteFellowship(ClientFellowshipSystem*)</code>
    /// </summary>
    public void DeleteFellowship() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x0056AB50)(ref this);

    /// <summary>Shuts down the client fellowship system by deleting its current fellowship and releasing any global instance.
    /// <code>Offset: 0x0056ABF0
    /// void __thiscall ClientFellowshipSystem::OnShutdown(ClientFellowshipSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, void>)0x0056ABF0)(ref this);

    /// <summary>Processes the departure of a member from a fellowship, removing them from the group, updating radar visibility, sending quit notices, and cleaning up the entire fellowship if the departing member is the local player.
    /// <code>Offset: 0x0056AC30
    /// unsigned int __thiscall ClientFellowshipSystem::Handle_Fellowship__Quit(ClientFellowshipSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="quitter">The unique identifier of the character leaving the fellowship.</param>
    /// <returns>Zero on successful handling; may be used as a status code.</returns>
    public uint Handle_Fellowship__Quit(uint quitter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, uint, uint>)0x0056AC30)(ref this, quitter);

    /// <summary>Handles dismissal of a fellowship member, removing them from the group or deleting the entire fellowship if the dismissed ID matches the client’s own ID; updates radar visibility and communication focus accordingly.
    /// <code>Offset: 0x0056ACB0
    /// unsigned int __thiscall ClientFellowshipSystem::Handle_Fellowship__Dismiss(ClientFellowshipSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="dismissed">The identifier of the fellow to dismiss.</param>
    /// <returns>Zero on successful handling.</returns>
    public uint Handle_Fellowship__Dismiss(uint dismissed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientFellowshipSystem, uint, uint>)0x0056ACB0)(ref this, dismissed);
}

