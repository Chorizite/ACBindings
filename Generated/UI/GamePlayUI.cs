namespace ACBindings;

// GamePlayUI
public unsafe struct GamePlayUI
{
    // Base Classes
    public ACBindings.UIMainFramework BaseClass_UIMainFramework; // ACBindings.UIMainFramework

    // Child Types
    // GamePlayUI_vtbl
    public unsafe struct GamePlayUI_vtbl
    {
        // Members
        public System.IntPtr GamePlayUI_dtor_0; // function pointer
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

    // Generated Constructor
    public GamePlayUI() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall GamePlayUI::GamePlayUI(GamePlayUI*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GamePlayUI, void>)0x006A1BC0)(ref this);
}

