namespace ACBindings;

// gmCreditsUI
public unsafe struct gmCreditsUI : System.IDisposable
{
    // Base Classes
    public ACBindings.gmUIMainFramework BaseClass_gmUIMainFramework; // ACBindings.gmUIMainFramework

    // Child Types
    // gmCreditsUI_vtbl
    public unsafe struct gmCreditsUI_vtbl
    {
        // Members
        public System.IntPtr gmCreditsUI_dtor_0; // function pointer
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

    // Members
    public uint m_waitContext;
    public int m_lastPicture;
    public int m_lastX;
    public int m_lastY;
    public ACBindings.BaseProperty m_pictureProp;
    public uint m_numPictures;
    public float m_duration;
    public double m_endTime;
    public ACBindings.SmartArray__UIElement_ptr m_aPictureElements;
    public ACBindings.UIElement* m_pictureField;
    public ACBindings.UIElement* m_textField;
    public ACBindings.UIElement_Text* m_textArea;
    public byte m_alternate;

    // Generated Constructor
    public gmCreditsUI() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmCreditsUI::ListenToGlobalMessage(gmCreditsUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCreditsUI, uint, int, void>)0x004E7AD0)(ref this, messageID, data_int);
    // IDClass<_tagDataID,32,0>* __thiscall gmCreditsUI::GetNextPictureID(_DWORD*,IDClass<_tagDataID,32,0>*)
    public ACBindings.IDClass___tagDataID* GetNextPictureID(ACBindings.IDClass___tagDataID* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCreditsUI, ACBindings.IDClass___tagDataID*, ACBindings.IDClass___tagDataID*>)0x004E7B00)(ref this, a2);
    // void __thiscall gmCreditsUI::~gmCreditsUI(gmCreditsUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCreditsUI, void>)0x004E7C50)(ref this);
    // void __thiscall gmCreditsUI::Initialize(gmCreditsUI*)
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCreditsUI, void>)0x004E7D30)(ref this);
    // void __thiscall gmCreditsUI::gmCreditsUI(gmCreditsUI*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCreditsUI, void>)0x004E7FA0)(ref this);
    // UIMainFramework* __cdecl gmCreditsUI::Create()
    public static ACBindings.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.UIMainFramework*>)0x004E8170)();
    // void __cdecl gmCreditsUI::Register(unsigned int)
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004E8190)(mode);
    // void __thiscall gmCreditsUI::CreateAndAddPicture(gmCreditsUI*)
    public void CreateAndAddPicture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCreditsUI, void>)0x004E81B0)(ref this);
    // void __thiscall gmCreditsUI::ScrollPictures(gmCreditsUI*,int)
    public void ScrollPictures(int pixels) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCreditsUI, int, void>)0x004E82A0)(ref this, pixels);
    // void __thiscall gmCreditsUI::MakePleaseWaitDialog(gmCreditsUI*)
    public void MakePleaseWaitDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCreditsUI, void>)0x004E8380)(ref this);
    // int __thiscall gmCreditsUI::ScrollText(gmCreditsUI*)
    public int ScrollText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCreditsUI, int>)0x004E84E0)(ref this);
    // bool __thiscall gmCreditsUI::OnAction(gmCreditsUI*,const InputEvent*)
    public byte OnAction(ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCreditsUI, ACBindings.InputEvent*, byte>)0x004E8630)(ref this, i_evt);
    // void __thiscall gmCreditsUI::Update(gmCreditsUI*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCreditsUI, void>)0x004E8660)(ref this);
}

