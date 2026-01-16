namespace ACBindings.Internal;


/// <summary>Encapsulates a pointer to an Interface implementation together with the status of the most recent operation, enabling safe access and error reporting.</summary>
public unsafe struct InterfacePtr___Interface
{
    // Members
    public ACBindings.Internal.Interface* m_pInterface;
    public ACBindings.Internal.TResult m_trStatus;

    // Methods

    /// <summary>Attempts to obtain a new interface instance matching the identifier provided in a3, updating this InterfacePtr object with the resulting interface pointer and status while releasing any previously held interface.
    /// <code>Offset: 0x004036D0
    /// int* __thiscall InterfacePtr&lt;Interface&gt;::_QueryInterface(int*,int*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Receives the result code (HRESULT) of the query operation.</param>
    /// <param name="a3">Pointer to an identifier specifying the desired interface; must not be null. If null, the InterfacePtr is reset and a failure code is returned.</param>
    /// <returns>Returns a pointer to the HRESULT output parameter, mirroring the value written into a2.</returns>
    // int* __thiscall InterfacePtr<Interface>::_QueryInterface(int*,int*,_DWORD*) (template type method)

    /// <summary>Attempts to obtain an implementation of the specified interface from the current object and updates this InterfacePtr with it. On success the instance holds the new interface; on failure it is cleared.
    /// <code>Offset: 0x0047AF90
    /// int* __thiscall InterfacePtr&lt;Interface&gt;::_QueryInterface_1(int*,int*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer where the query result code is written (non‑negative for success).</param>
    /// <param name="a3">Pointer to a GUID that identifies the desired interface type; if null, the InterfacePtr is reset and an error code is returned.</param>
    /// <returns>Returns the same pointer passed in as <c>a2</c>, containing the query status after execution.</returns>
    // int* __thiscall InterfacePtr<Interface>::_QueryInterface_1(int*,int*,_DWORD*) (template type method)

    /// <summary>Retrieves an Interface_InterfaceType_139 interface from the underlying object and stores it in this smart pointer, clearing the pointer on failure.
    /// <code>Offset: 0x00508650
    /// int* __thiscall InterfacePtr&lt;Interface&gt;::_QueryInterface_2(int*,int*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Receives the status code (e.g., HRESULT) returned by the query operation.</param>
    /// <param name="a3">Identifier for the requested interface type; if null the operation fails immediately.</param>
    /// <returns>Pointer to a2, allowing the caller to inspect the result status directly.</returns>
    // int* __thiscall InterfacePtr<Interface>::_QueryInterface_2(int*,int*,_DWORD*) (template type method)

    /// <summary>Attempts to obtain an Interface instance based on a request descriptor and stores the result in this InterfacePtr, releasing any previously held interface reference.
    /// <code>Offset: 0x00558190
    /// int* __thiscall InterfacePtr&lt;Interface&gt;::_QueryInterface_3(int*,int*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a status code variable that receives the outcome of the query operation.</param>
    /// <param name="a3">Pointer to a descriptor identifying the desired interface; if null, the InterfacePtr is reset and an error status is set.</param>
    /// <returns>Returns the status code pointer supplied by the caller after the query completes.</returns>
    // int* __thiscall InterfacePtr<Interface>::_QueryInterface_3(int*,int*,_DWORD*) (template type method)

    /// <summary>Attempts to acquire a requested interface from the wrapped object, updating the internal pointer and status. On success the new interface replaces the existing one; on failure the current interface is released and cleared.
    /// <code>Offset: 0x0055F4F0
    /// int* __thiscall InterfacePtr&lt;Interface&gt;::_QueryInterface_4(int*,int*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer that receives the operation result code (0 for success).</param>
    /// <param name="a3">Optional identifier or parameters specifying the desired interface type.</param>
    /// <returns>Same as the a2 pointer, returning the status code of the operation.</returns>
    // int* __thiscall InterfacePtr<Interface>::_QueryInterface_4(int*,int*,_DWORD*) (template type method)

    /// <summary>Queries the underlying object for the interface identified by the GUID supplied in <c>a3</c>, replacing any existing interface and recording the result status in <c>*a2</c>.
    /// <code>Offset: 0x00594130
    /// int* __thiscall InterfacePtr&lt;Interface&gt;::_QueryInterface_5(int*,int*,_DWORD*)</code>
    /// </summary>
    /// <param name="this">Reference to the <see cref="InterfacePtr{Interface}"/> instance whose internal pointer will be updated.</param>
    /// <param name="a2">Pointer to an integer that receives the query outcome code; this same pointer is returned by the function.</param>
    /// <param name="a3">GUID specifying the desired interface. If null, the call fails with <c>E_NOINTERFACE</c> and releases any current interface.</param>
    /// <returns>Returns the address of the status code stored in <c>a2</c>.</returns>
    // int* __thiscall InterfacePtr<Interface>::_QueryInterface_5(int*,int*,_DWORD*) (template type method)
}


/// <summary>Provides a pointer to a CObjectMaint instance and records the status of interactions with that interface.</summary>
public unsafe struct InterfacePtr___CObjectMaint
{
    // Members
    public ACBindings.Internal.CObjectMaint* m_pInterface;
    public ACBindings.Internal.TResult m_trStatus;

    // Methods

    /// <summary>Attempts to obtain the requested interface from the underlying object and updates the InterfacePtr instance accordingly.
    /// <code>Offset: 0x00454590
    /// int* __thiscall InterfacePtr&lt;CObjectMaint&gt;::_QueryInterface(int*,int*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer that receives the result code (HRESULT) of the query operation; zero indicates success, negative values indicate failure.</param>
    /// <param name="a3">Pointer to an interface type descriptor specifying which interface to request from the target object.</param>
    /// <param name="a4">Reserved parameter, unused in this implementation.</param>
    /// <returns>Returns a pointer to the status code passed in a2.</returns>
    // int* __thiscall InterfacePtr<CObjectMaint>::_QueryInterface(int*,int*,_DWORD*,int) (template type method)

    /// <summary>Initializes an InterfacePtr&lt;CObjectMaint&gt; from a raw interface pointer, performing a QueryInterface call when appropriate.
    /// <code>Offset: 0x00455250
    /// int* __thiscall InterfacePtr&lt;CObjectMaint&gt;::InterfacePtr&lt;CObjectMaint&gt;(int*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the raw interface pointer used for initialization.</param>
    /// <returns>Pointer to the initialized InterfacePtr instance.</returns>
    // int* __thiscall InterfacePtr<CObjectMaint>::InterfacePtr<CObjectMaint>(int*,_DWORD*) (template type method)
}


/// <summary>Encapsulates a reference to a PlayerDesc interface and tracks the status of its retrieval operations.</summary>
public unsafe struct InterfacePtr___PlayerDesc
{
    // Members
    public ACBindings.Internal.PlayerDesc* m_pInterface;
    public ACBindings.Internal.TResult m_trStatus;

    // Methods

    /// <summary>Queries a source object for its PlayerDesc interface and assigns it to this InterfacePtr instance, storing the operation result in the supplied output parameter.
    /// <code>Offset: 0x0048BB00
    /// int* __thiscall InterfacePtr&lt;PlayerDesc&gt;::_QueryInterface(int*,int*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Output parameter that receives the status code of the query operation; negative values indicate failure.</param>
    /// <param name="a3">Source object whose PlayerDesc interface is requested. If NULL, releases the current interface and returns a failure code.</param>
    /// <param name="a4">Reserved for future use; ignored by this method.</param>
    /// <returns>Pointer to the output status parameter (same as a2).</returns>
    // int* __thiscall InterfacePtr<PlayerDesc>::_QueryInterface(int*,int*,_DWORD*,int) (template type method)

    /// <summary>Initializes an InterfacePtr for PlayerDesc by querying a supplied object pointer and recording the query status.
    /// <code>Offset: 0x0048BC80
    /// int* __thiscall InterfacePtr&lt;PlayerDesc&gt;::InterfacePtr&lt;PlayerDesc&gt;(int*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an object that may provide a PlayerDesc interface; if null or unsupported, the resulting interface pointer remains null.</param>
    /// <returns>Reference to this InterfacePtr instance.</returns>
    // int* __thiscall InterfacePtr<PlayerDesc>::InterfacePtr<PlayerDesc>(int*,_DWORD*) (template type method)

    /// <summary>Determines whether the underlying PlayerDesc interface is present and its status indicates success.
    /// <code>Offset: 0x004CA390
    /// BOOL __thiscall InterfacePtr&lt;PlayerDesc&gt;::IsValid(_DWORD*)</code>
    /// </summary>
    /// <returns>True if m_pInterface is non‑null and m_trStatus is greater than or equal to zero; otherwise false.</returns>
    // BOOL __thiscall InterfacePtr<PlayerDesc>::IsValid(_DWORD*) (template type method)
}


/// <summary>Wraps a ClientObjMaintSystem interface pointer and tracks operation status via TResult. Enables safe interface handling and query operations within the client object maintenance system.</summary>
public unsafe struct InterfacePtr___ClientObjMaintSystem
{
    // Members
    public ACBindings.Internal.ClientObjMaintSystem* m_pInterface;
    public ACBindings.Internal.TResult m_trStatus;

    // Methods

    /// <summary>Attempts to query for a ClientObjMaintSystem interface from the supplied source interface, storing it in this InterfacePtr instance and reporting the result via the status output parameter.
    /// <code>Offset: 0x004C1DA0
    /// int* __thiscall InterfacePtr&lt;ClientObjMaintSystem&gt;::_QueryInterface(int*,int*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Output HRESULT indicating success (0) or failure (negative).</param>
    /// <param name="a3">Source interface pointer used to perform the query; if null, clears the stored interface.</param>
    /// <param name="a4">Reserved flag, currently unused.</param>
    /// <returns>The address of the status output parameter (a2). </returns>
    // int* __thiscall InterfacePtr<ClientObjMaintSystem>::_QueryInterface(int*,int*,_DWORD*,int) (template type method)

    /// <summary>Initializes an InterfacePtr with a ClientObjMaintSystem interface obtained from the supplied object.
    /// <code>Offset: 0x004C2FD0
    /// int* __thiscall InterfacePtr&lt;ClientObjMaintSystem&gt;::InterfacePtr&lt;ClientObjMaintSystem&gt;(int*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the object used for querying the desired interface.</param>
    /// <returns>Reference to the initialized InterfacePtr instance (this).</returns>
    // int* __thiscall InterfacePtr<ClientObjMaintSystem>::InterfacePtr<ClientObjMaintSystem>(int*,_DWORD*) (template type method)
}


/// <summary>Represents a smart pointer that owns a CPlayerModule instance and records the success status of interface acquisition operations.</summary>
/// <remarks>Manages COM‑like reference counting, releasing the held interface when reset or destroyed.</remarks>
public unsafe struct InterfacePtr___CPlayerModule
{
    // Members
    public ACBindings.Internal.CPlayerModule* m_pInterface;
    public ACBindings.Internal.TResult m_trStatus;

    // Methods

    /// <summary>
    /// Retrieves a CPlayerModule interface from the supplied source object, updates this InterfacePtr with the obtained interface (or clears it on failure), and writes the operation's HRESULT into an output parameter.
    /// 
    /// <code>Offset: 0x00485260
    /// int* __thiscall InterfacePtr&lt;CPlayerModule&gt;::_QueryInterface(int*,int*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Receives the HRESULT of the query; negative values indicate failure.</param>
    /// <param name="a3">Input reference used to obtain the CPlayerModule. It is released after the call. If null, the function fails immediately.</param>
    /// <param name="a4">Ignored – present only for compatibility with the original signature.</param>
    /// <returns>Pointer to the status code written into a2.</returns>
    // int* __thiscall InterfacePtr<CPlayerModule>::_QueryInterface(int*,int*,_DWORD*,int) (template type method)

    /// <summary>Initializes an InterfacePtr&lt;CPlayerModule&gt; by querying the supplied raw interface pointer for a CPlayerModule implementation and storing the query result.
    /// <code>Offset: 0x004855A0
    /// int* __thiscall InterfacePtr&lt;CPlayerModule&gt;::InterfacePtr&lt;CPlayerModule&gt;(int*,_DWORD*)</code>
    /// </summary>
    /// <param name="this">Pointer to the InterfacePtr&lt;CPlayerModule&gt; instance being constructed.</param>
    /// <param name="a2">Raw COM-like interface pointer from which to obtain a CPlayerModule object.</param>
    /// <returns>Pointer to the initialized InterfacePtr&lt;CPlayerModule&gt;.</returns>
    // int* __thiscall InterfacePtr<CPlayerModule>::InterfacePtr<CPlayerModule>(int*,_DWORD*) (template type method)
}

