namespace ACBindings.Internal;

public unsafe struct UIFlow : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface
    public ACBindings.Internal.NoticeHandler BaseClass_NoticeHandler; // ACBindings.Internal.NoticeHandler
    public ACBindings.Internal.UIListener BaseClass_UIListener; // ACBindings.Internal.UIListener

    // Statics
    public static ACBindings.Internal.UIFlow* m_instance = (ACBindings.Internal.UIFlow*)0x0083E72C;

    // Child Types
    public unsafe struct UIFlow_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, ACBindings.Internal.UIFlow.Enum19> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, uint, void> QueueUIMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, uint, ACBindings.Internal.StringInfo*, void> QueueUIModeWithError; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, ACBindings.Internal.UIPersistantData*> GetPersistantData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, void> Update; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004797C0
    /// void __thiscall UIFlow::QueueUIMode(UIFlow*,const unsigned int)</code>
    /// </summary>
    public void QueueUIMode(uint newMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, uint, void>)0x004797C0)(ref this, newMode);

    /// <summary>
    /// <code>Offset: 0x004797F0
    /// void __thiscall UIFlow::QueueUIModeWithError(UIFlow*,const unsigned int,const StringInfo*)</code>
    /// </summary>
    public void QueueUIModeWithError(uint newMode, ACBindings.Internal.StringInfo* newText) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, uint, ACBindings.Internal.StringInfo*, void>)0x004797F0)(ref this, newMode, newText);

    /// <summary>
    /// <code>Offset: 0x00479830
    /// void __thiscall UIFlow::Update(UIFlow*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, void>)0x00479830)(ref this);

    /// <summary>
    /// <code>Offset: 0x00479840
    /// void __thiscall UIFlow::~UIFlow(UIFlow*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, void>)0x00479840)(ref this);

    /// <summary>
    /// <code>Offset: 0x004798E0
    /// TResult* __thiscall UIFlow::QueryInterface(UIFlow*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x004798E0)(ref this, result, i_rcInterface, o_ppObject);

    /// <summary>
    /// <code>Offset: 0x00479940
    /// unsigned int __thiscall UIFlow::AddRef(UIFlow*)</code>
    /// </summary>
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, uint>)0x00479940)(ref this);

    /// <summary>
    /// <code>Offset: 0x00479950
    /// unsigned int __thiscall UIFlow::Release(UIFlow*)</code>
    /// </summary>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, uint>)0x00479950)(ref this);

    /// <summary>
    /// <code>Offset: 0x004799C0
    /// void __thiscall UIFlow::UIFlow(UIFlow*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, void>)0x004799C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00479AA0
    /// void __thiscall UIFlow::UseNewMode(UIFlow*)</code>
    /// </summary>
    public void UseNewMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, void>)0x00479AA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00479BA0
    /// void __thiscall UIFlow::ListenToGlobalMessage(UIFlow*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, uint, int, void>)0x00479BA0)(ref this, messageID, data_int);

    /// <summary>
    /// <code>Offset: 0x00479C50
    /// void __cdecl UIFlow::RegisterFrameworkClass(unsigned int,UIMainFramework*(__cdecl*createMethod)())</code>
    /// </summary>
    public static void RegisterFrameworkClass(uint mode, delegate* unmanaged[Cdecl]<ACBindings.Internal.UIMainFramework*> createMethod) => ((delegate* unmanaged[Cdecl]<uint, delegate* unmanaged[Cdecl]<ACBindings.Internal.UIMainFramework*>, void>)0x00479C50)(mode, createMethod);

    /// <summary>
    /// <code>Offset: 0x0051DFB0
    /// unsigned int __thiscall UIFlow::GetPersistantData(PhysicsDesc*)</code>
    /// </summary>
    public uint GetPersistantData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFlow, uint>)0x0051DFB0)(ref this);
}

