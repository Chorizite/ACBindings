namespace ACBindings.Internal;


/// <summary>Provides the primary user interface framework for the application, encapsulating a UIMainFramework instance that manages root UI elements and global UI state.</summary>
public unsafe struct gmUIMainFramework
{
    // Base Classes
    public ACBindings.Internal.UIMainFramework BaseClass_UIMainFramework; // ACBindings.Internal.UIMainFramework

    // Child Types
    public unsafe struct gmUIMainFramework_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, void> gmUIMainFramework_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmUIMainFramework*, void> Update; // function pointer

        // Methods
    }

    // Methods
}

