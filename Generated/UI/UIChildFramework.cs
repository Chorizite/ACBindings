namespace ACBindings.Internal;

public unsafe struct UIChildFramework
{
    // Base Classes
    public ACBindings.Internal.UIFramework BaseClass_UIFramework; // ACBindings.Internal.UIFramework

    // Child Types
    public unsafe struct UIChildFramework_vtbl
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
    public ACBindings.Internal.UIFramework* m_parent;

    // Methods
}

