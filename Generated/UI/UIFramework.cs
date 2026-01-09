namespace ACBindings;

// UIFramework
public unsafe struct UIFramework : System.IDisposable
{
    // Base Classes
    public ACBindings.UIListener BaseClass_UIListener; // ACBindings.UIListener

    // Child Types
    // UIFramework_vtbl
    public unsafe struct UIFramework_vtbl
    {
        // Members
        public System.IntPtr UIFramework_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer
        public System.IntPtr CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public System.IntPtr RemoveRootElement; // function pointer
        public System.IntPtr Show; // function pointer
        public System.IntPtr Shown; // function pointer
        public System.IntPtr ForceHidden; // function pointer
        public System.IntPtr AddChild; // function pointer
        public System.IntPtr RemoveChild; // function pointer
        public System.IntPtr FindChild; // function pointer

        // Methods
    }

    // Members
    public byte m_bCanForceHide;
    public byte m_bIsForcedHidden;
    public byte m_shown;
    public ACBindings.SmartArray__UIChildFramework_ptr m_children;

    // Generated Constructor
    public UIFramework() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall UIFramework::Shown(UIFramework*)
    public byte Shown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFramework, byte>)0x004E7AE0)(ref this);
    // UIPersistantData* __thiscall UIFramework::GetPersistantData(UIFramework*)
    public ACBindings.UIPersistantData* GetPersistantData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFramework, ACBindings.UIPersistantData*>)0x006A1730)(ref this);
    // void __thiscall UIFramework::QueueUIMode(UIFramework*,const unsigned int)
    public void QueueUIMode(uint newMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFramework, uint, void>)0x006A1740)(ref this, newMode);
    // void __thiscall UIFramework::Show(UIFramework*,bool)
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFramework, byte, void>)0x006A1750)(ref this, shown);
    // void __thiscall UIFramework::ForceHidden(UIFramework*,bool)
    public void ForceHidden(byte hide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFramework, byte, void>)0x006A17C0)(ref this, hide);
    // int __thiscall UIFramework::FindChild(UIFramework*,UIChildFramework*)
    public int FindChild(ACBindings.UIChildFramework* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFramework, ACBindings.UIChildFramework*, int>)0x006A1830)(ref this, child);
    // UIElementMessageListenResult __thiscall UIFramework::ListenToElementMessage(UIFramework*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFramework, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x006A1860)(ref this, i_rMsg);
    // void __thiscall UIFramework::RemoveChild(UIFramework*,UIChildFramework*)
    public void RemoveChild(ACBindings.UIChildFramework* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFramework, ACBindings.UIChildFramework*, void>)0x006A18B0)(ref this, child);
    // void __thiscall UIFramework::UIFramework(UIFramework*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFramework, void>)0x006A1900)(ref this);
    // void __thiscall UIFramework::~UIFramework(UIFramework*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFramework, void>)0x006A1930)(ref this);
    // void __thiscall UIFramework::AddChild(UIFramework*,UIChildFramework*)
    public void AddChild(ACBindings.UIChildFramework* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIFramework, ACBindings.UIChildFramework*, void>)0x006A19C0)(ref this, child);
}

