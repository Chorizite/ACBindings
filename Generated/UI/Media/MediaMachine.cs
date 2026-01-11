namespace ACBindings.Internal;

public unsafe struct MediaMachine : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIListener BaseClass_UIListener; // ACBindings.Internal.UIListener

    // Child Types
    public unsafe struct MediaMachine_vtbl
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
    public ACBindings.Internal.UIElement* m_owner;
    public ACBindings.Internal.SmartArray___MediaDesc_ptr m_array;
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

    /// <summary>
    /// <code>Offset: 0x00465650
    /// bool __thiscall MediaMachine::Update_Pause(MediaMachine*,MD_Data_Pause*)</code>
    /// </summary>
    public byte Update_Pause(ACBindings.Internal.MD_Data_Pause* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Pause*, byte>)0x00465650)(ref this, desc);

    /// <summary>
    /// <code>Offset: 0x004656E0
    /// bool __thiscall MediaMachine::Update_Jump(MediaMachine*,MD_Data_Jump*)</code>
    /// </summary>
    public byte Update_Jump(ACBindings.Internal.MD_Data_Jump* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Jump*, byte>)0x004656E0)(ref this, desc);

    /// <summary>
    /// <code>Offset: 0x00465730
    /// bool __thiscall MediaMachine::Update_Message(MediaMachine*,MD_Data_Message*)</code>
    /// </summary>
    public byte Update_Message(ACBindings.Internal.MD_Data_Message* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Message*, byte>)0x00465730)(ref this, desc);

    /// <summary>
    /// <code>Offset: 0x00465790
    /// bool __thiscall MediaMachine::Update_State(MediaMachine*,MD_Data_State*)</code>
    /// </summary>
    public byte Update_State(ACBindings.Internal.MD_Data_State* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_State*, byte>)0x00465790)(ref this, desc);

    /// <summary>
    /// <code>Offset: 0x004657E0
    /// bool __thiscall MediaMachine::Update_Movie(MediaMachine*,MD_Data_Movie*)</code>
    /// </summary>
    public byte Update_Movie(ACBindings.Internal.MD_Data_Movie* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Movie*, byte>)0x004657E0)(ref this, desc);

    /// <summary>
    /// <code>Offset: 0x00465810
    /// bool __thiscall MediaMachine::Update_Anim(MediaMachine*,MD_Data_Anim*)</code>
    /// </summary>
    public byte Update_Anim(ACBindings.Internal.MD_Data_Anim* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Anim*, byte>)0x00465810)(ref this, desc);

    /// <summary>
    /// <code>Offset: 0x00465960
    /// bool __thiscall MediaMachine::Update_Alpha(MediaMachine*,MD_Data_Alpha*)</code>
    /// </summary>
    public byte Update_Alpha(ACBindings.Internal.MD_Data_Alpha* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Alpha*, byte>)0x00465960)(ref this, desc);

    /// <summary>
    /// <code>Offset: 0x004659A0
    /// bool __thiscall MediaMachine::Update_Image(MediaMachine*,MD_Data_Image*)</code>
    /// </summary>
    public byte Update_Image(ACBindings.Internal.MD_Data_Image* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Image*, byte>)0x004659A0)(ref this, desc);

    /// <summary>
    /// <code>Offset: 0x004659E0
    /// bool __thiscall MediaMachine::Update_Sound(MediaMachine*,MD_Data_Sound*)</code>
    /// </summary>
    public byte Update_Sound(ACBindings.Internal.MD_Data_Sound* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Sound*, byte>)0x004659E0)(ref this, desc);

    /// <summary>
    /// <code>Offset: 0x00465A60
    /// bool __thiscall MediaMachine::Update_Fade(MediaMachine*,MD_Data_Fade*)</code>
    /// </summary>
    public byte Update_Fade(ACBindings.Internal.MD_Data_Fade* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Fade*, byte>)0x00465A60)(ref this, desc);

    /// <summary>
    /// <code>Offset: 0x00465BB0
    /// bool __thiscall MediaMachine::Update_Cursor(MediaMachine*,MD_Data_Cursor*)</code>
    /// </summary>
    public byte Update_Cursor(ACBindings.Internal.MD_Data_Cursor* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Cursor*, byte>)0x00465BB0)(ref this, desc);

    /// <summary>
    /// <code>Offset: 0x00465BF0
    /// void __thiscall MediaMachine::MediaMachine(MediaMachine*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, void>)0x00465BF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00465C20
    /// void __thiscall MediaMachine::Cleanup(MediaMachine*)</code>
    /// </summary>
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, void>)0x00465C20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00465CD0
    /// void __thiscall MediaMachine::Update(MediaMachine*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, void>)0x00465CD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00465E20
    /// void __thiscall MediaMachine::ListenToGlobalMessage(MediaMachine*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, uint, int, void>)0x00465E20)(ref this, messageID, data_int);

    /// <summary>
    /// <code>Offset: 0x00465E30
    /// void __thiscall MediaMachine::~MediaMachine(MediaMachine*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, void>)0x00465E30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00465EC0
    /// void __thiscall MediaMachine::Reset(MediaMachine*,_DWORD*)</code>
    /// </summary>
    public void Reset(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, int*, void>)0x00465EC0)(ref this, a2);
}

