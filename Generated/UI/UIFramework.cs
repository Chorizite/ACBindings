namespace ACBindings.Internal;

public unsafe struct UIFramework : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIListener BaseClass_UIListener; // ACBindings.Internal.UIListener

    // Child Types
    public unsafe struct UIFramework_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, void> UIFramework_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, byte, void> Show; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, byte> Shown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, byte, void> ForceHidden; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFramework*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer

        // Methods
    }

    // Members
    public byte m_bCanForceHide;
    public byte m_bIsForcedHidden;
    public byte m_shown;
    public ACBindings.Internal.SmartArray___UIChildFramework_ptr m_children;

    // Generated Constructor
    public UIFramework() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004E7AE0
    /// bool __thiscall UIFramework::Shown(UIFramework*)</code>
    /// </summary>
    public byte Shown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, byte>)0x004E7AE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006A1730
    /// UIPersistantData* __thiscall UIFramework::GetPersistantData(UIFramework*)</code>
    /// </summary>
    public ACBindings.Internal.UIPersistantData* GetPersistantData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, ACBindings.Internal.UIPersistantData*>)0x006A1730)(ref this);

    /// <summary>
    /// <code>Offset: 0x006A1740
    /// void __thiscall UIFramework::QueueUIMode(UIFramework*,const unsigned int)</code>
    /// </summary>
    public void QueueUIMode(uint newMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, uint, void>)0x006A1740)(ref this, newMode);

    /// <summary>
    /// <code>Offset: 0x006A1750
    /// void __thiscall UIFramework::Show(UIFramework*,bool)</code>
    /// </summary>
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, byte, void>)0x006A1750)(ref this, shown);

    /// <summary>
    /// <code>Offset: 0x006A17C0
    /// void __thiscall UIFramework::ForceHidden(UIFramework*,bool)</code>
    /// </summary>
    public void ForceHidden(byte hide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, byte, void>)0x006A17C0)(ref this, hide);

    /// <summary>
    /// <code>Offset: 0x006A1830
    /// int __thiscall UIFramework::FindChild(UIFramework*,UIChildFramework*)</code>
    /// </summary>
    public int FindChild(ACBindings.Internal.UIChildFramework* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, ACBindings.Internal.UIChildFramework*, int>)0x006A1830)(ref this, child);

    /// <summary>
    /// <code>Offset: 0x006A1860
    /// UIElementMessageListenResult __thiscall UIFramework::ListenToElementMessage(UIFramework*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x006A1860)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x006A18B0
    /// void __thiscall UIFramework::RemoveChild(UIFramework*,UIChildFramework*)</code>
    /// </summary>
    public void RemoveChild(ACBindings.Internal.UIChildFramework* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, ACBindings.Internal.UIChildFramework*, void>)0x006A18B0)(ref this, child);

    /// <summary>
    /// <code>Offset: 0x006A1900
    /// void __thiscall UIFramework::UIFramework(UIFramework*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, void>)0x006A1900)(ref this);

    /// <summary>
    /// <code>Offset: 0x006A1930
    /// void __thiscall UIFramework::~UIFramework(UIFramework*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, void>)0x006A1930)(ref this);

    /// <summary>
    /// <code>Offset: 0x006A19C0
    /// void __thiscall UIFramework::AddChild(UIFramework*,UIChildFramework*)</code>
    /// </summary>
    public void AddChild(ACBindings.Internal.UIChildFramework* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIFramework, ACBindings.Internal.UIChildFramework*, void>)0x006A19C0)(ref this, child);
}

