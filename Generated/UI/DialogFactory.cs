namespace ACBindings.Internal;

public unsafe struct DialogFactory
{
    // Statics
    public static uint* s_globalContext = (uint*)0x0083E718;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00477460
    /// bool __cdecl DialogFactory::IsDialogOpen(unsigned int)</code>
    /// </summary>
    public static byte IsDialogOpen(uint i_queueID) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x00477460)(i_queueID);

    /// <summary>
    /// <code>Offset: 0x004777C0
    /// void __cdecl DialogFactory::DialogDone(DialogInfo*)</code>
    /// </summary>
    public static void DialogDone(ACBindings.Internal.DialogInfo* i_info) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DialogInfo*, void>)0x004777C0)(i_info);

    /// <summary>
    /// <code>Offset: 0x00477990
    /// void __cdecl DialogFactory::UpdatePendingDialogDisplay_()</code>
    /// </summary>
    public static void UpdatePendingDialogDisplay_() => ((delegate* unmanaged[Cdecl]<void>)0x00477990)();

    /// <summary>
    /// <code>Offset: 0x00477D50
    /// void __cdecl DialogFactory::Reset()</code>
    /// </summary>
    public static void Reset() => ((delegate* unmanaged[Cdecl]<void>)0x00477D50)();

    /// <summary>
    /// <code>Offset: 0x00477ED0
    /// void __cdecl DialogFactory::CreateDialog_(const DialogInfo*,unsigned int)</code>
    /// </summary>
    public static void CreateDialog_(ACBindings.Internal.DialogInfo* info, uint queueID) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DialogInfo*, uint, void>)0x00477ED0)(info, queueID);

    /// <summary>
    /// <code>Offset: 0x00478130
    /// void __cdecl DialogFactory::OpenNextDialog(unsigned int)</code>
    /// </summary>
    public static void OpenNextDialog(uint i_queueID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00478130)(i_queueID);

    /// <summary>
    /// <code>Offset: 0x00478290
    /// unsigned int __cdecl DialogFactory::MakeDialog(UIFramework*,const PropertyCollection*)</code>
    /// </summary>
    public static uint MakeDialog(ACBindings.Internal.UIFramework* i_pcParent, ACBindings.Internal.PropertyCollection* i_rcData) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIFramework*, ACBindings.Internal.PropertyCollection*, uint>)0x00478290)(i_pcParent, i_rcData);

    /// <summary>
    /// <code>Offset: 0x00478560
    /// void __cdecl DialogFactory::CloseDialog(const unsigned int)</code>
    /// </summary>
    public static void CloseDialog(uint context) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00478560)(context);

    /// <summary>
    /// <code>Offset: 0x00478810
    /// unsigned int __cdecl DialogFactory::MakeDialogInCurrentUI(const PropertyCollection*)</code>
    /// </summary>
    public static uint MakeDialogInCurrentUI(ACBindings.Internal.PropertyCollection* i_rcData) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, uint>)0x00478810)(i_rcData);

    /// <summary>
    /// <code>Offset: 0x00478830
    /// unsigned int __cdecl DialogFactory::MakeCallbackDialogInCurrentUI(const PropertyCollection*,void (__cdecl*pFunc)(const PropertyCollection*))</code>
    /// </summary>
    public static uint MakeCallbackDialogInCurrentUI(ACBindings.Internal.PropertyCollection* i_rcData, delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void> pFunc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>, uint>)0x00478830)(i_rcData, pFunc);
}

