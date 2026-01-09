namespace ACBindings;

// UIFlow
public unsafe struct UIFlow : System.IDisposable
{
    // Base Classes
    public ACBindings.Interface BaseClass_Interface; // ACBindings.Interface
    public ACBindings.NoticeHandler BaseClass_NoticeHandler; // ACBindings.NoticeHandler
    public ACBindings.UIListener BaseClass_UIListener; // ACBindings.UIListener

    // Statics
    public static ACBindings.HashTable__uint__void_ptr* _frameworkCreateMethodTable = (ACBindings.HashTable__uint__void_ptr*)0x00819FF4;
    public static ACBindings.UIFlow* m_instance = (ACBindings.UIFlow*)0x0083E72C;

    // Child Types
    // UIFlow_vtbl
    public unsafe struct UIFlow_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public System.IntPtr QueueUIMode; // function pointer
        public System.IntPtr QueueUIModeWithError; // function pointer
        public System.IntPtr GetPersistantData; // function pointer
        public System.IntPtr Update; // function pointer

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
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public uint _curMode;
    public uint _nextMode;
    public ACBindings.UIMainFramework* _curUI;
    public ACBindings.UIPersistantData* _data;
    public ACBindings.StringInfo _nextText;

    // Generated Constructor
    public UIFlow() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall UIFlow::QueueUIMode(UIFlow*,const unsigned int)
    public void QueueUIMode(uint newMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFlow, uint, void>)0x004797C0)(ref this, newMode);
    // void __thiscall UIFlow::QueueUIModeWithError(UIFlow*,const unsigned int,const StringInfo*)
    public void QueueUIModeWithError(uint newMode, ACBindings.StringInfo* newText) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFlow, uint, ACBindings.StringInfo*, void>)0x004797F0)(ref this, newMode, newText);
    // void __thiscall UIFlow::Update(UIFlow*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFlow, void>)0x00479830)(ref this);
    // void __thiscall UIFlow::~UIFlow(UIFlow*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFlow, void>)0x00479840)(ref this);
    // TResult* __thiscall UIFlow::QueryInterface(UIFlow*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFlow, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x004798E0)(ref this, result, i_rcInterface, o_ppObject);
    // unsigned int __thiscall UIFlow::AddRef(UIFlow*)
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFlow, uint>)0x00479940)(ref this);
    // unsigned int __thiscall UIFlow::Release(UIFlow*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFlow, uint>)0x00479950)(ref this);
    // void __thiscall UIFlow::UIFlow(UIFlow*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFlow, void>)0x004799C0)(ref this);
    // void __thiscall UIFlow::UseNewMode(UIFlow*)
    public void UseNewMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFlow, void>)0x00479AA0)(ref this);
    // void __thiscall UIFlow::ListenToGlobalMessage(UIFlow*,unsigned int,int)
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFlow, uint, int, void>)0x00479BA0)(ref this, messageID, data_int);
    // void __cdecl UIFlow::RegisterFrameworkClass(unsigned int,UIMainFramework*(__cdecl*createMethod)())
    public static void RegisterFrameworkClass(uint mode, delegate* unmanaged[Cdecl]<ACBindings.UIMainFramework*> createMethod) => ((delegate* unmanaged[Cdecl]<uint, delegate* unmanaged[Cdecl]<ACBindings.UIMainFramework*>, void>)0x00479C50)(mode, createMethod);
    // unsigned int __thiscall UIFlow::GetPersistantData(PhysicsDesc*)
    public uint GetPersistantData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFlow, uint>)0x0051DFB0)(ref this);
}

