namespace ACBindings;

// MediaMachine
public unsafe struct MediaMachine : System.IDisposable
{
    // Base Classes
    public ACBindings.UIListener BaseClass_UIListener; // ACBindings.UIListener

    // Child Types
    // MediaMachine_vtbl
    public unsafe struct MediaMachine_vtbl
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
    public ACBindings.UIElement* m_owner;
    public ACBindings.SmartArray__MediaDesc_ptr m_array;
    public uint m_curIndex;

    // Generated Constructor
    public MediaMachine() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall MediaMachine::Update_Pause(MediaMachine*,MD_Data_Pause*)
    public byte Update_Pause(ACBindings.MD_Data_Pause* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, ACBindings.MD_Data_Pause*, byte>)0x00465650)(ref this, desc);
    // bool __thiscall MediaMachine::Update_Jump(MediaMachine*,MD_Data_Jump*)
    public byte Update_Jump(ACBindings.MD_Data_Jump* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, ACBindings.MD_Data_Jump*, byte>)0x004656E0)(ref this, desc);
    // bool __thiscall MediaMachine::Update_Message(MediaMachine*,MD_Data_Message*)
    public byte Update_Message(ACBindings.MD_Data_Message* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, ACBindings.MD_Data_Message*, byte>)0x00465730)(ref this, desc);
    // bool __thiscall MediaMachine::Update_State(MediaMachine*,MD_Data_State*)
    public byte Update_State(ACBindings.MD_Data_State* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, ACBindings.MD_Data_State*, byte>)0x00465790)(ref this, desc);
    // bool __thiscall MediaMachine::Update_Movie(MediaMachine*,MD_Data_Movie*)
    public byte Update_Movie(ACBindings.MD_Data_Movie* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, ACBindings.MD_Data_Movie*, byte>)0x004657E0)(ref this, desc);
    // bool __thiscall MediaMachine::Update_Anim(MediaMachine*,MD_Data_Anim*)
    public byte Update_Anim(ACBindings.MD_Data_Anim* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, ACBindings.MD_Data_Anim*, byte>)0x00465810)(ref this, desc);
    // bool __thiscall MediaMachine::Update_Alpha(MediaMachine*,MD_Data_Alpha*)
    public byte Update_Alpha(ACBindings.MD_Data_Alpha* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, ACBindings.MD_Data_Alpha*, byte>)0x00465960)(ref this, desc);
    // bool __thiscall MediaMachine::Update_Image(MediaMachine*,MD_Data_Image*)
    public byte Update_Image(ACBindings.MD_Data_Image* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, ACBindings.MD_Data_Image*, byte>)0x004659A0)(ref this, desc);
    // bool __thiscall MediaMachine::Update_Sound(MediaMachine*,MD_Data_Sound*)
    public byte Update_Sound(ACBindings.MD_Data_Sound* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, ACBindings.MD_Data_Sound*, byte>)0x004659E0)(ref this, desc);
    // bool __thiscall MediaMachine::Update_Fade(MediaMachine*,MD_Data_Fade*)
    public byte Update_Fade(ACBindings.MD_Data_Fade* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, ACBindings.MD_Data_Fade*, byte>)0x00465A60)(ref this, desc);
    // bool __thiscall MediaMachine::Update_Cursor(MediaMachine*,MD_Data_Cursor*)
    public byte Update_Cursor(ACBindings.MD_Data_Cursor* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, ACBindings.MD_Data_Cursor*, byte>)0x00465BB0)(ref this, desc);
    // void __thiscall MediaMachine::MediaMachine(MediaMachine*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, void>)0x00465BF0)(ref this);
    // void __thiscall MediaMachine::Cleanup(MediaMachine*)
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, void>)0x00465C20)(ref this);
    // void __thiscall MediaMachine::Update(MediaMachine*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, void>)0x00465CD0)(ref this);
    // void __thiscall MediaMachine::ListenToGlobalMessage(MediaMachine*,unsigned int,int)
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, uint, int, void>)0x00465E20)(ref this, messageID, data_int);
    // void __thiscall MediaMachine::~MediaMachine(MediaMachine*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, void>)0x00465E30)(ref this);
    // void __thiscall MediaMachine::Reset(MediaMachine*,_DWORD*)
    public void Reset(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaMachine, int*, void>)0x00465EC0)(ref this, a2);
}

