namespace ACBindings.Internal;


/// <summary>Manages housing‑related events on the client side, processing house data, transactions, and updates, while employing a reference‑counted interface to control its lifetime.</summary>
public unsafe struct ClientHousingSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem

    // Statics
    public static ACBindings.Internal.ClientHousingSystem** s_pHousingSystem = (ACBindings.Internal.ClientHousingSystem**)0x008719BC;

    // Child Types
    public unsafe struct ClientHousingSystem_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientHousingSystem*, ACBindings.Internal.ClientHousingSystem.Enum12> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientHousingSystem::Enum11
    public enum Enum11 : uint
    {
    }
    // ClientHousingSystem::Enum12
    public enum Enum12 : uint
    {
    }
    // ClientHousingSystem::Enum13
    public enum Enum13 : uint
    {
    }
    // ClientHousingSystem::Enum14
    public enum Enum14 : uint
    {
    }
    // ClientHousingSystem::Enum4
    public enum Enum4 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;

    // Generated Constructor
    public ClientHousingSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Cleans up a ClientHousingSystem instance by decrementing reference counts and invoking base class destructors.
    /// <code>Offset: 0x00586770
    /// void __thiscall ClientHousingSystem::~ClientHousingSystem(ClientHousingSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, void>)0x00586770)(ref this);

    /// <summary>Cleans up the client housing subsystem by invoking its shutdown routine and clearing global references.
    /// <code>Offset: 0x005867A0
    /// void __thiscall ClientHousingSystem::OnShutdown(ClientHousingSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, void>)0x005867A0)(ref this);

    /// <summary>Handles reception of a HouseProfile update by forwarding it to the client housing system.
    /// <code>Offset: 0x005867C0
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_HouseProfile(ClientHousingSystem*,unsigned int,const HouseProfile*)</code>
    /// </summary>
    /// <param name="lord">Identifier of the house owner or lord associated with the profile.</param>
    /// <param name="prof">Pointer to the HouseProfile containing updated house data.</param>
    /// <returns>Zero indicating successful handling of the profile.</returns>
    public uint Handle_House__Recv_HouseProfile(uint lord, ACBindings.Internal.HouseProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, uint, ACBindings.Internal.HouseProfile*, uint>)0x005867C0)(ref this, lord, prof);

    /// <summary>Handles an incoming house transaction notification by informing the user that the transaction has failed and returning a completion status.
    /// <code>Offset: 0x005867E0
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_HouseTransaction(ClientHousingSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="etype">The identifier for the failed transaction type.</param>
    /// <returns>A status code (currently always 0) indicating that the failure was processed.</returns>
    public uint Handle_House__Recv_HouseTransaction(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, uint, uint>)0x005867E0)(ref this, etype);

    /// <summary>Processes received house information by broadcasting an update notice to relevant components.
    /// <code>Offset: 0x00586800
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_HouseData(ClientHousingSystem*,const HouseData*)</code>
    /// </summary>
    /// <param name="data">The house data packet containing purchase, rent, and positional details.</param>
    /// <returns>A zero value indicating successful handling of the house data receipt.</returns>
    public uint Handle_House__Recv_HouseData(ACBindings.Internal.HouseData* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, ACBindings.Internal.HouseData*, uint>)0x00586800)(ref this, data);

    /// <summary>Handles receipt of a rent time update by broadcasting the new duration to relevant components.
    /// <code>Offset: 0x00586820
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_UpdateRentTime(ClientHousingSystem*,int)</code>
    /// </summary>
    /// <param name="rent_time">The updated rent duration value in seconds.</param>
    /// <returns>Zero, indicating successful handling.</returns>
    public uint Handle_House__Recv_UpdateRentTime(int rent_time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, int, uint>)0x00586820)(ref this, rent_time);

    /// <summary>Processes an incoming rent‑payment update by forwarding the payment list to the housing system.
    /// <code>Offset: 0x00586840
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_UpdateRentPayment(ClientHousingSystem*,const HousePaymentList*)</code>
    /// </summary>
    /// <param name="rent">A list containing updated rent payment information.</param>
    /// <returns>An unsigned integer status code; always zero for successful handling.</returns>
    public uint Handle_House__Recv_UpdateRentPayment(ACBindings.Internal.HousePaymentList* rent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, ACBindings.Internal.HousePaymentList*, uint>)0x00586840)(ref this, rent);

    /// <summary>Updates the house restrictions for an object when a valid update is received from another client.
    /// <code>Offset: 0x00586860
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_UpdateRestrictions(ClientHousingSystem*,unsigned __int8,unsigned int,const RestrictionDB*)</code>
    /// </summary>
    /// <param name="wts">Timestamp or version identifier used to validate the restriction update.</param>
    /// <param name="sender">Identifier of the sender that requested the restriction update.</param>
    /// <param name="db">Pointer to a RestrictionDB structure containing the new restriction data.</param>
    /// <returns>Zero; function always returns 0 as a status code.</returns>
    public uint Handle_House__Recv_UpdateRestrictions(byte wts, uint sender, ACBindings.Internal.RestrictionDB* db) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, byte, uint, ACBindings.Internal.RestrictionDB*, uint>)0x00586860)(ref this, wts, sender, db);

    /// <summary>
    /// Implements a COM-style QueryInterface for ClientHousingSystem, locating the requested interface by GUID and returning a reference to it if available.
    /// 
    /// <code>Offset: 0x005868C0
    /// TResult* __thiscall ClientHousingSystem::QueryInterface(ClientHousingSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="this">Pointer to the current ClientHousingSystem instance.</param>
    /// <param name="result">Pointer to a TResult structure that receives the operation status; on success m_val is set to 0 (S_OK), otherwise an error code such as E_NOINTERFACE.</param>
    /// <param name="i_rcInterface">GUID of the interface requested.</param>
    /// <param name="o_ppvInterface">Output pointer to the requested interface if found; may remain unchanged when the interface is not available or the argument is null.</param>
    /// <returns>The TResult* passed in as result, allowing immediate inspection of m_val.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x005868C0)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Reduces the internal reference counter of the housing system, freeing resources when the count drops to zero.
    /// <code>Offset: 0x00586990
    /// unsigned int __thiscall ClientHousingSystem::Release(ClientHousingSystem*)</code>
    /// </summary>
    /// <returns>The updated reference count after release; a value of zero indicates that the system has been destroyed.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, uint>)0x00586990)(ref this);

    /// <summary>Initializes the client housing system by setting up interface vtables, establishing an initial reference count, storing the instance in a static pointer, and incrementing its reference counter.
    /// <code>Offset: 0x005869C0
    /// void __thiscall ClientHousingSystem::ClientHousingSystem(ClientHousingSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, void>)0x005869C0)(ref this);

    /// <summary>Receives a housing update record, logs its contents to the client scroll view, and performs cleanup of reference-counted resources such as roommate list and string buffer associated with the HAR data.
    /// <code>Offset: 0x00586A00
    /// unsigned int __thiscall ClientHousingSystem::Handle_House__Recv_UpdateHAR(ClientHousingSystem*,const HAR*)</code>
    /// </summary>
    /// <param name="har">The housing update record received from the server.</param>
    /// <returns>Status code indicating success (0).</returns>
    public uint Handle_House__Recv_UpdateHAR(ACBindings.Internal.HAR* har) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, ACBindings.Internal.HAR*, uint>)0x00586A00)(ref this, har);

    /// <summary>Iterates over a linked list of land identifiers supplied via the second argument, converts each identifier to world coordinates, formats the coordinates with compass directions, and appends each formatted entry to the client scroll display.
    /// <code>Offset: 0x00586AA0
    /// unsigned int* __thiscall ClientHousingSystem::DisplayListOfCoords(void*,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientHousingSystem instance.</param>
    /// <param name="a2">Address of a structure whose member at offset 4 points to the head of the land‑ID list.</param>
    /// <returns>NULL after all entries have been processed; the function does not return any meaningful value.</returns>
    public uint* DisplayListOfCoords(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, int, uint*>)0x00586AA0)(ref this, a2);

    /// <summary>Processes the server response with the number of available houses, formats a message for the user, and displays house locations on the map.
    /// <code>Offset: 0x00586BD0
    /// int __thiscall ClientHousingSystem::Handle_House__Recv_AvailableHouses(ClientSystem*,int,int,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the client system handling housing data.</param>
    /// <param name="a2">The house type identifier (1=cottages, 2=villas, 3=mansions, 4=apartments).</param>
    /// <param name="a3">Additional context such as a coordinate or page index used for displaying locations.</param>
    /// <param name="ArgList">The number of available houses reported by the server.</param>
    /// <returns>Zero on success.</returns>
    public int Handle_House__Recv_AvailableHouses(int a2, int a3, int ArgList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientHousingSystem, int, int, int, int>)0x00586BD0)(ref this, a2, a3, ArgList);
}

