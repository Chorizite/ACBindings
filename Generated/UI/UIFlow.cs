namespace ACBindings.Internal;


/// <summary>Manages user‑interface flow, keeping track of the current and queued modes, handling reference counts, and registering for global messages.</summary>
public unsafe struct UIFlow : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface
    public ACBindings.Internal.NoticeHandler BaseClass_NoticeHandler; // ACBindings.Internal.NoticeHandler
    public ACBindings.Internal.UIListener BaseClass_UIListener; // ACBindings.Internal.UIListener

    // Statics
    public static ACBindings.Internal.HashTable__uint__void_ptr* _frameworkCreateMethodTable = (ACBindings.Internal.HashTable__uint__void_ptr*)0x00819F88;
    public static ACBindings.Internal.UIFlow** m_instance = (ACBindings.Internal.UIFlow**)0x0083E72C;

    // Child Types
    public unsafe struct UIFlow_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, ACBindings.Internal.UIFlow.Enum19> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, uint, void> QueueUIMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, uint, ACBindings.Internal.StringInfo*, void> QueueUIModeWithError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, ACBindings.Internal.UIPersistantData*> GetPersistantData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, void> Update; // function pointer

        // Methods
    }
    // UIFlow::Enum18
    public enum Enum18 : uint
    {
    }
    // UIFlow::Enum19
    public enum Enum19 : uint
    {
    }
    // UIFlow::Enum20
    public enum Enum20 : uint
    {
    }
    // UIFlow::Enum3
    public enum Enum3 : uint
    {
    }
    // UIFlow::Enum4
    public enum Enum4 : uint
    {
    }
    // UIFlow::Enum5
    public enum Enum5 : uint
    {
    }
    // UIFlow::Enum6
    public enum Enum6 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public uint _curMode;
    public uint _nextMode;
    public ACBindings.Internal.UIMainFramework* _curUI;
    public ACBindings.Internal.UIPersistantData* _data;
    public ACBindings.Internal.StringInfo _nextText;

    // Generated Constructor
    public UIFlow() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Queues a new UI mode to be applied during the next framework update, resetting any pending text.
    /// <code>Offset: 0x004797C0
    /// void __thiscall UIFlow::QueueUIMode(UIFlow*,const unsigned int)</code>
    /// </summary>
    /// <param name="newMode">The identifier of the mode to transition to.</param>
    public void QueueUIMode(uint newMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, uint, void>)0x004797C0)(ref this, newMode);

    /// <summary>Queues a UI mode transition and stores the supplied text for later use.
    /// <code>Offset: 0x004797F0
    /// void __thiscall UIFlow::QueueUIModeWithError(UIFlow*,const unsigned int,const StringInfo*)</code>
    /// </summary>
    /// <param name="newMode">Identifier of the UI mode to queue.</param>
    /// <param name="newText">Pointer to a StringInfo containing the text associated with the queued mode; must not be null.</param>
    public void QueueUIModeWithError(uint newMode, ACBindings.Internal.StringInfo* newText) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, uint, ACBindings.Internal.StringInfo*, void>)0x004797F0)(ref this, newMode, newText);

    /// <summary>Invokes the current UI’s action handler to advance or respond to user interactions.
    /// <code>Offset: 0x00479830
    /// void __thiscall UIFlow::Update(UIFlow*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, void>)0x00479830)(ref this);

    /// <summary>Releases all resources held by a UIFlow instance, including unregistering from global message bus, deleting persistent data and text strings, and destroying base class components.
    /// <code>Offset: 0x00479840
    /// void __thiscall UIFlow::~UIFlow(UIFlow*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, void>)0x00479840)(ref this);

    /// <summary>Retrieves a requested interface from the UIFlow object based on the provided GUID.
    /// <code>Offset: 0x004798E0
    /// TResult* __thiscall UIFlow::QueryInterface(UIFlow*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Receives the status of the request; zero (S_OK) on success or an HRESULT failure code otherwise.</param>
    /// <param name="i_rcInterface">GUID identifying the desired interface.</param>
    /// <param name="o_ppObject">Output pointer that receives the requested interface if the GUID matches the UIFlow implementation.</param>
    /// <returns>Pointer to the TResult supplied, containing the operation's outcome.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x004798E0)(ref this, result, i_rcInterface, o_ppObject);

    /// <summary>Increments the Turbine reference counter for this UIFlow instance and returns the new count.
    /// <code>Offset: 0x00479940
    /// unsigned int __thiscall UIFlow::AddRef(UIFlow*)</code>
    /// </summary>
    /// <returns>The updated reference count after incrementing.</returns>
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, uint>)0x00479940)(ref this);

    /// <summary>Decrements UIFlow’s internal reference counter, destroying its input‑action callback when the count reaches zero.
    /// <code>Offset: 0x00479950
    /// unsigned int __thiscall UIFlow::Release(UIFlow*)</code>
    /// </summary>
    /// <returns>The updated reference count after decrement; zero indicates the object has been fully released and cleaned up.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, uint>)0x00479950)(ref this);

    /// <summary>Initializes a UIFlow object by establishing its base interfaces, setting default mode values, registering for global messages, and allocating persistent data. It also assigns the newly created instance to the global singleton reference.
    /// <code>Offset: 0x004799C0
    /// void __thiscall UIFlow::UIFlow(UIFlow*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, void>)0x004799C0)(ref this);

    /// <summary>Switches the UI flow to a new mode by destroying the current interface, updating internal state, and creating a new UI element based on the pending mode and associated text.
    /// <code>Offset: 0x00479AA0
    /// void __thiscall UIFlow::UseNewMode(UIFlow*)</code>
    /// </summary>
    public void UseNewMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, void>)0x00479AA0)(ref this);

    /// <summary>Listens for a global message and initiates a UI mode transition when the specified message ID occurs while the object maintains active references.
    /// <code>Offset: 0x00479BA0
    /// void __thiscall UIFlow::ListenToGlobalMessage(UIFlow*,unsigned int,int)</code>
    /// </summary>
    /// <param name="messageID">Identifier of the global message to react to; currently only ID 3 triggers a mode change.</param>
    /// <param name="data_int">Integer payload accompanying the message, presently unused but available for future extensions.</param>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, uint, int, void>)0x00479BA0)(ref this, messageID, data_int);

    /// <summary>Registers a UI framework factory method for a given mode in the internal framework table.
    /// <code>Offset: 0x00479C50
    /// void __cdecl UIFlow::RegisterFrameworkClass(unsigned int,UIMainFramework*(__cdecl*createMethod)())</code>
    /// </summary>
    /// <param name="mode">Identifier specifying the framework mode to register.</param>
    /// <param name="createMethod">Pointer to a function that constructs an instance of UIMainFramework.</param>
    public static void RegisterFrameworkClass(uint mode, delegate* unmanaged[Cdecl]<ACBindings.Internal.UIMainFramework*> createMethod) => ((delegate* unmanaged[Cdecl]<uint, delegate* unmanaged[Cdecl]<ACBindings.Internal.UIMainFramework*>, void>)0x00479C50)(mode, createMethod);

    /// <summary>Retrieves the number of child objects defined in a physics description.
    /// <code>Offset: 0x0051DFB0
    /// unsigned int __thiscall UIFlow::GetPersistantData(PhysicsDesc*)</code>
    /// </summary>
    /// <param name="this">Pointer to the PhysicsDesc instance from which to obtain the child count.</param>
    /// <returns>The total number of child objects associated with the given physics descriptor.</returns>
    public uint GetPersistantData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, uint>)0x0051DFB0)(ref this);
}

