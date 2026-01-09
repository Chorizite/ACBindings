namespace ACBindings;

// ClientCharGenState
public unsafe struct ClientCharGenState : System.IDisposable
{
    // Base Classes
    public ACBindings.CharGenState BaseClass_CharGenState; // ACBindings.CharGenState

    // Child Types
    // ClientCharGenState_vtbl
    public unsafe struct ClientCharGenState_vtbl
    {
        // Members
        public System.IntPtr UpdateTrueFacePal; // function pointer
        public System.IntPtr GetRandomInt; // function pointer
        public System.IntPtr GetRandomReal; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Palette* grayFacePal;
    public ACBindings.Palette* trueFacePal;
    public int trueFacePalChangeNum;

    // Generated Constructor
    public ClientCharGenState() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ClientCharGenState::ClientCharGenState(ClientCharGenState*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCharGenState, void>)0x00564660)(ref this);
    // void __thiscall ClientCharGenState::~ClientCharGenState(ClientCharGenState*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCharGenState, void>)0x00564700)(ref this);
    // unsigned int __stdcall ClientCharGenState::GetColorFromPal(int,unsigned int)
    public static uint GetColorFromPal(int ArgList, uint color_index) => ((delegate* unmanaged[Stdcall]<int, uint, uint>)0x00564730)(ArgList, color_index);
    // void __thiscall ClientCharGenState::UpdateTrueFacePal(ClientCharGenState*)
    public void UpdateTrueFacePal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCharGenState, void>)0x005647C0)(ref this);
}

