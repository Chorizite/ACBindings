namespace ACBindings;

// UIListener
public unsafe struct UIListener : System.IDisposable
{
    // Base Classes
    public ACBindings.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.IInputActionCallback

    // Child Types
    // UIListener_vtbl
    public unsafe struct UIListener_vtbl
    {
        // Members
        public System.IntPtr UIListener_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer

        // Methods
    }

    // Members
    public ACBindings.HashSet__UIElement_ptr m_hashElementsRegisteredWith;
    public ACBindings.CTimestamp__uint m_tsSerialNumberLastListenedTo;

    // Generated Constructor
    public UIListener() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall UIListener::RegisterForElementMessage(UIListener*,unsigned int,unsigned int)
    public void RegisterForElementMessage(uint elementID, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIListener, uint, uint, void>)0x00465F50)(ref this, elementID, messageID);
    // void __thiscall UIListener::UnRegisterForElementMessage(UIListener*,unsigned int,unsigned int)
    public void UnRegisterForElementMessage(uint elementID, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIListener, uint, uint, void>)0x00465F70)(ref this, elementID, messageID);
    // void __thiscall UIListener::RegisterForGlobalMessage(UIListener*,unsigned int)
    public void RegisterForGlobalMessage(uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIListener, uint, void>)0x00465F90)(ref this, messageID);
    // void __thiscall UIListener::UnRegisterForGlobalMessage(UIListener*,unsigned int)
    public void UnRegisterForGlobalMessage(uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIListener, uint, void>)0x00465FB0)(ref this, messageID);
    // void __thiscall UIListener::UIListener(UIListener*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIListener, void>)0x00466380)(ref this);
    // void __thiscall UIListener::~UIListener(UIListener*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIListener, void>)0x004663B0)(ref this);
    // void __thiscall UIListener::OnRegisteredWithElement(UIListener*,UIElement*)
    public void OnRegisteredWithElement(ACBindings.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIListener, ACBindings.UIElement*, void>)0x00466470)(ref this, i_pElement);
    // void __thiscall UIListener::OnUnregisteredWithElement(UIListener*,UIElement*)
    public void OnUnregisteredWithElement(ACBindings.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIListener, ACBindings.UIElement*, void>)0x00466480)(ref this, i_pElement);
}

