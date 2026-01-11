namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0047AF90
    /// int* __thiscall InterfacePtr&lt;Interface&gt;::_QueryInterface_1(int*,int*,_DWORD*)</code>
    /// </summary>
    // int* __thiscall InterfacePtr<Interface>::_QueryInterface_1(int*,int*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x00508650
    /// int* __thiscall InterfacePtr&lt;Interface&gt;::_QueryInterface_2(int*,int*,_DWORD*)</code>
    /// </summary>
    // int* __thiscall InterfacePtr<Interface>::_QueryInterface_2(int*,int*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x00558190
    /// int* __thiscall InterfacePtr&lt;Interface&gt;::_QueryInterface_3(int*,int*,_DWORD*)</code>
    /// </summary>
    // int* __thiscall InterfacePtr<Interface>::_QueryInterface_3(int*,int*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x0055F4F0
    /// int* __thiscall InterfacePtr&lt;Interface&gt;::_QueryInterface_4(int*,int*,_DWORD*)</code>
    /// </summary>
    // int* __thiscall InterfacePtr<Interface>::_QueryInterface_4(int*,int*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x00594130
    /// int* __thiscall InterfacePtr&lt;Interface&gt;::_QueryInterface_5(int*,int*,_DWORD*)</code>
    /// </summary>
    // int* __thiscall InterfacePtr<Interface>::_QueryInterface_5(int*,int*,_DWORD*) (template type method)
}

public unsafe struct InterfacePtr___CObjectMaint
{
    // Members
    public ACBindings.Internal.CObjectMaint* m_pInterface;
    public ACBindings.Internal.TResult m_trStatus;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00454590
    /// int* __thiscall InterfacePtr&lt;CObjectMaint&gt;::_QueryInterface(int*,int*,_DWORD*,int)</code>
    /// </summary>
    // int* __thiscall InterfacePtr<CObjectMaint>::_QueryInterface(int*,int*,_DWORD*,int) (template type method)

    /// <summary>
    /// <code>Offset: 0x00455250
    /// int* __thiscall InterfacePtr&lt;CObjectMaint&gt;::InterfacePtr&lt;CObjectMaint&gt;(int*,_DWORD*)</code>
    /// </summary>
    // int* __thiscall InterfacePtr<CObjectMaint>::InterfacePtr<CObjectMaint>(int*,_DWORD*) (template type method)
}

public unsafe struct InterfacePtr___PlayerDesc
{
    // Members
    public ACBindings.Internal.PlayerDesc* m_pInterface;
    public ACBindings.Internal.TResult m_trStatus;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0048BB00
    /// int* __thiscall InterfacePtr&lt;PlayerDesc&gt;::_QueryInterface(int*,int*,_DWORD*,int)</code>
    /// </summary>
    // int* __thiscall InterfacePtr<PlayerDesc>::_QueryInterface(int*,int*,_DWORD*,int) (template type method)

    /// <summary>
    /// <code>Offset: 0x0048BC80
    /// int* __thiscall InterfacePtr&lt;PlayerDesc&gt;::InterfacePtr&lt;PlayerDesc&gt;(int*,_DWORD*)</code>
    /// </summary>
    // int* __thiscall InterfacePtr<PlayerDesc>::InterfacePtr<PlayerDesc>(int*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x004CA390
    /// BOOL __thiscall InterfacePtr&lt;PlayerDesc&gt;::IsValid(_DWORD*)</code>
    /// </summary>
    // BOOL __thiscall InterfacePtr<PlayerDesc>::IsValid(_DWORD*) (template type method)
}

public unsafe struct InterfacePtr___ClientObjMaintSystem
{
    // Members
    public ACBindings.Internal.ClientObjMaintSystem* m_pInterface;
    public ACBindings.Internal.TResult m_trStatus;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004C1DA0
    /// int* __thiscall InterfacePtr&lt;ClientObjMaintSystem&gt;::_QueryInterface(int*,int*,_DWORD*,int)</code>
    /// </summary>
    // int* __thiscall InterfacePtr<ClientObjMaintSystem>::_QueryInterface(int*,int*,_DWORD*,int) (template type method)

    /// <summary>
    /// <code>Offset: 0x004C2FD0
    /// int* __thiscall InterfacePtr&lt;ClientObjMaintSystem&gt;::InterfacePtr&lt;ClientObjMaintSystem&gt;(int*,_DWORD*)</code>
    /// </summary>
    // int* __thiscall InterfacePtr<ClientObjMaintSystem>::InterfacePtr<ClientObjMaintSystem>(int*,_DWORD*) (template type method)
}

public unsafe struct InterfacePtr___CPlayerModule
{
    // Members
    public ACBindings.Internal.CPlayerModule* m_pInterface;
    public ACBindings.Internal.TResult m_trStatus;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00485260
    /// int* __thiscall InterfacePtr&lt;CPlayerModule&gt;::_QueryInterface(int*,int*,_DWORD*,int)</code>
    /// </summary>
    // int* __thiscall InterfacePtr<CPlayerModule>::_QueryInterface(int*,int*,_DWORD*,int) (template type method)

    /// <summary>
    /// <code>Offset: 0x004855A0
    /// int* __thiscall InterfacePtr&lt;CPlayerModule&gt;::InterfacePtr&lt;CPlayerModule&gt;(int*,_DWORD*)</code>
    /// </summary>
    // int* __thiscall InterfacePtr<CPlayerModule>::InterfacePtr<CPlayerModule>(int*,_DWORD*) (template type method)
}

