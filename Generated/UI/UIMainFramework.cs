namespace ACBindings.Internal;

public unsafe struct UIMainFramework : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIFramework BaseClass_UIFramework; // ACBindings.Internal.UIFramework

    // Child Types
    public unsafe struct UIMainFramework_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, void> UIMainFramework_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, byte, void> Show; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, byte> Shown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, byte, void> ForceHidden; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIMainFramework*, void> Update; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___UIElement_ptr m_rootElements;

    // Generated Constructor
    public UIMainFramework() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x006A1A20
    /// UIElement* __thiscall UIMainFramework::CreateAndAddRootElement(UIMainFramework*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* CreateAndAddRootElement(uint layoutEnum, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIMainFramework, uint, uint, ACBindings.Internal.UIElement*>)0x006A1A20)(ref this, layoutEnum, elementID);

    /// <summary>
    /// <code>Offset: 0x006A1A60
    /// void __thiscall UIMainFramework::RemoveRootElement(UIMainFramework*,UIElement**)</code>
    /// </summary>
    public void RemoveRootElement(ACBindings.Internal.UIElement** element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIMainFramework, ACBindings.Internal.UIElement**, void>)0x006A1A60)(ref this, element);

    /// <summary>
    /// <code>Offset: 0x006A1AB0
    /// void __thiscall UIMainFramework::UIMainFramework(UIMainFramework*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIMainFramework, void>)0x006A1AB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006A1AE0
    /// void __thiscall UIMainFramework::~UIMainFramework(UIMainFramework*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIMainFramework, void>)0x006A1AE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006A1B70
    /// UIElement* __thiscall UIMainFramework::CreateAndAddRootElementByDataID(UIListener*,int,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* CreateAndAddRootElementByDataID(int a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIMainFramework, int, uint, ACBindings.Internal.UIElement*>)0x006A1B70)(ref this, a2, a3);
}

