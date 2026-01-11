namespace ACBindings.Internal;

public unsafe struct gmCreditsUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.gmUIMainFramework BaseClass_gmUIMainFramework; // ACBindings.Internal.gmUIMainFramework

    // Child Types
    public unsafe struct gmCreditsUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, void> gmCreditsUI_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, byte, void> Show; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, byte> Shown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, byte, void> ForceHidden; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCreditsUI*, void> Update; // function pointer

        // Methods
    }

    // Members
    public uint m_waitContext;
    public int m_lastPicture;
    public int m_lastX;
    public int m_lastY;
    public ACBindings.Internal.BaseProperty m_pictureProp;
    public uint m_numPictures;
    public float m_duration;
    public double m_endTime;
    public ACBindings.Internal.SmartArray___UIElement_ptr m_aPictureElements;
    public ACBindings.Internal.UIElement* m_pictureField;
    public ACBindings.Internal.UIElement* m_textField;
    public ACBindings.Internal.UIElement_Text* m_textArea;
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

    /// <summary>
    /// <code>Offset: 0x004E7AD0
    /// void __thiscall gmCreditsUI::ListenToGlobalMessage(gmCreditsUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, uint, int, void>)0x004E7AD0)(ref this, messageID, data_int);

    /// <summary>
    /// <code>Offset: 0x004E7B00
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall gmCreditsUI::GetNextPictureID(_DWORD*,IDClass&lt;_tagDataID,32,0&gt;*)</code>
    /// </summary>
    public ACBindings.Internal.IDClass____tagDataID* GetNextPictureID(ACBindings.Internal.IDClass____tagDataID* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, ACBindings.Internal.IDClass____tagDataID*, ACBindings.Internal.IDClass____tagDataID*>)0x004E7B00)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004E7C50
    /// void __thiscall gmCreditsUI::~gmCreditsUI(gmCreditsUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, void>)0x004E7C50)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E7D30
    /// void __thiscall gmCreditsUI::Initialize(gmCreditsUI*)</code>
    /// </summary>
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, void>)0x004E7D30)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E7FA0
    /// void __thiscall gmCreditsUI::gmCreditsUI(gmCreditsUI*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, void>)0x004E7FA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E8170
    /// UIMainFramework* __cdecl gmCreditsUI::Create()</code>
    /// </summary>
    public static ACBindings.Internal.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIMainFramework*>)0x004E8170)();

    /// <summary>
    /// <code>Offset: 0x004E8190
    /// void __cdecl gmCreditsUI::Register(unsigned int)</code>
    /// </summary>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004E8190)(mode);

    /// <summary>
    /// <code>Offset: 0x004E81B0
    /// void __thiscall gmCreditsUI::CreateAndAddPicture(gmCreditsUI*)</code>
    /// </summary>
    public void CreateAndAddPicture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, void>)0x004E81B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E82A0
    /// void __thiscall gmCreditsUI::ScrollPictures(gmCreditsUI*,int)</code>
    /// </summary>
    public void ScrollPictures(int pixels) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, int, void>)0x004E82A0)(ref this, pixels);

    /// <summary>
    /// <code>Offset: 0x004E8380
    /// void __thiscall gmCreditsUI::MakePleaseWaitDialog(gmCreditsUI*)</code>
    /// </summary>
    public void MakePleaseWaitDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, void>)0x004E8380)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E84E0
    /// int __thiscall gmCreditsUI::ScrollText(gmCreditsUI*)</code>
    /// </summary>
    public int ScrollText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, int>)0x004E84E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E8630
    /// bool __thiscall gmCreditsUI::OnAction(gmCreditsUI*,const InputEvent*)</code>
    /// </summary>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, ACBindings.Internal.InputEvent*, byte>)0x004E8630)(ref this, i_evt);

    /// <summary>
    /// <code>Offset: 0x004E8660
    /// void __thiscall gmCreditsUI::Update(gmCreditsUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCreditsUI, void>)0x004E8660)(ref this);
}

