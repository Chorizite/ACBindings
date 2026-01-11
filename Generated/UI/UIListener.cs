namespace ACBindings.Internal;

public unsafe struct UIListener : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Child Types
    public unsafe struct UIListener_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.HashSet___UIElement_ptr m_hashElementsRegisteredWith;
    public ACBindings.Internal.CTimestamp__uint m_tsSerialNumberLastListenedTo;

    // Generated Constructor
    public UIListener() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00465F50
    /// void __thiscall UIListener::RegisterForElementMessage(UIListener*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RegisterForElementMessage(uint elementID, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, uint, uint, void>)0x00465F50)(ref this, elementID, messageID);

    /// <summary>
    /// <code>Offset: 0x00465F70
    /// void __thiscall UIListener::UnRegisterForElementMessage(UIListener*,unsigned int,unsigned int)</code>
    /// </summary>
    public void UnRegisterForElementMessage(uint elementID, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, uint, uint, void>)0x00465F70)(ref this, elementID, messageID);

    /// <summary>
    /// <code>Offset: 0x00465F90
    /// void __thiscall UIListener::RegisterForGlobalMessage(UIListener*,unsigned int)</code>
    /// </summary>
    public void RegisterForGlobalMessage(uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, uint, void>)0x00465F90)(ref this, messageID);

    /// <summary>
    /// <code>Offset: 0x00465FB0
    /// void __thiscall UIListener::UnRegisterForGlobalMessage(UIListener*,unsigned int)</code>
    /// </summary>
    public void UnRegisterForGlobalMessage(uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, uint, void>)0x00465FB0)(ref this, messageID);

    /// <summary>
    /// <code>Offset: 0x00466380
    /// void __thiscall UIListener::UIListener(UIListener*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, void>)0x00466380)(ref this);

    /// <summary>
    /// <code>Offset: 0x004663B0
    /// void __thiscall UIListener::~UIListener(UIListener*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, void>)0x004663B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00466470
    /// void __thiscall UIListener::OnRegisteredWithElement(UIListener*,UIElement*)</code>
    /// </summary>
    public void OnRegisteredWithElement(ACBindings.Internal.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, ACBindings.Internal.UIElement*, void>)0x00466470)(ref this, i_pElement);

    /// <summary>
    /// <code>Offset: 0x00466480
    /// void __thiscall UIListener::OnUnregisteredWithElement(UIListener*,UIElement*)</code>
    /// </summary>
    public void OnUnregisteredWithElement(ACBindings.Internal.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIListener, ACBindings.Internal.UIElement*, void>)0x00466480)(ref this, i_pElement);
}

