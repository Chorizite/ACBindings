namespace ACBindings;

// UIMainFramework
public unsafe struct UIMainFramework : System.IDisposable
{
    // Base Classes
    public ACBindings.UIFramework BaseClass_UIFramework; // ACBindings.UIFramework

    // Child Types
    // UIMainFramework_vtbl
    public unsafe struct UIMainFramework_vtbl
    {
        // Members
        public System.IntPtr UIMainFramework_dtor_0; // function pointer
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
        public System.IntPtr SetErrorMsg; // function pointer
        public System.IntPtr Update; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SmartArray__UIElement_ptr m_rootElements;

    // Generated Constructor
    public UIMainFramework() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // UIElement* __thiscall UIMainFramework::CreateAndAddRootElement(UIMainFramework*,const unsigned int,const unsigned int)
    public ACBindings.UIElement* CreateAndAddRootElement(uint layoutEnum, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIMainFramework, uint, uint, ACBindings.UIElement*>)0x006A1A20)(ref this, layoutEnum, elementID);
    // void __thiscall UIMainFramework::RemoveRootElement(UIMainFramework*,UIElement**)
    public void RemoveRootElement(ACBindings.UIElement** element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIMainFramework, ACBindings.UIElement**, void>)0x006A1A60)(ref this, element);
    // void __thiscall UIMainFramework::UIMainFramework(UIMainFramework*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIMainFramework, void>)0x006A1AB0)(ref this);
    // void __thiscall UIMainFramework::~UIMainFramework(UIMainFramework*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIMainFramework, void>)0x006A1AE0)(ref this);
    // UIElement* __thiscall UIMainFramework::CreateAndAddRootElementByDataID(UIListener*,int,unsigned int)
    public ACBindings.UIElement* CreateAndAddRootElementByDataID(int a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIMainFramework, int, uint, ACBindings.UIElement*>)0x006A1B70)(ref this, a2, a3);
}

