namespace ACBindings;

// DialogFactory
public unsafe struct DialogFactory
{
    // Statics
    public static ACBindings.HashTable__uint__List__DialogInfo* s_hashDialogQueues = (ACBindings.HashTable__uint__List__DialogInfo*)0x00819E1C;
    public static ACBindings.HashTable__uint__DialogInfo* s_hashCurInfos = (ACBindings.HashTable__uint__DialogInfo*)0x00819E98;
    public static ACBindings.HashTable__uint__void_ptr* s_hashCallbacks = (ACBindings.HashTable__uint__void_ptr*)0x00819F0C;
    public static uint* s_globalContext = (uint*)0x0083E718;

    // Methods
    // bool __cdecl DialogFactory::IsDialogOpen(unsigned int)
    public static byte IsDialogOpen(uint i_queueID) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x00477460)(i_queueID);
    // void __cdecl DialogFactory::DialogDone(DialogInfo*)
    public static void DialogDone(ACBindings.DialogInfo* i_info) => ((delegate* unmanaged[Cdecl]<ACBindings.DialogInfo*, void>)0x004777C0)(i_info);
    // void __cdecl DialogFactory::UpdatePendingDialogDisplay_()
    public static void UpdatePendingDialogDisplay_() => ((delegate* unmanaged[Cdecl]<void>)0x00477990)();
    // void __cdecl DialogFactory::Reset()
    public static void Reset() => ((delegate* unmanaged[Cdecl]<void>)0x00477D50)();
    // void __cdecl DialogFactory::CreateDialog_(const DialogInfo*,unsigned int)
    public static void CreateDialog_(ACBindings.DialogInfo* info, uint queueID) => ((delegate* unmanaged[Cdecl]<ACBindings.DialogInfo*, uint, void>)0x00477ED0)(info, queueID);
    // void __cdecl DialogFactory::OpenNextDialog(unsigned int)
    public static void OpenNextDialog(uint i_queueID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00478130)(i_queueID);
    // unsigned int __cdecl DialogFactory::MakeDialog(UIFramework*,const PropertyCollection*)
    public static uint MakeDialog(ACBindings.UIFramework* i_pcParent, ACBindings.PropertyCollection* i_rcData) => ((delegate* unmanaged[Cdecl]<ACBindings.UIFramework*, ACBindings.PropertyCollection*, uint>)0x00478290)(i_pcParent, i_rcData);
    // void __cdecl DialogFactory::CloseDialog(const unsigned int)
    public static void CloseDialog(uint context) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00478560)(context);
    // unsigned int __cdecl DialogFactory::MakeDialogInCurrentUI(const PropertyCollection*)
    public static uint MakeDialogInCurrentUI(ACBindings.PropertyCollection* i_rcData) => ((delegate* unmanaged[Cdecl]<ACBindings.PropertyCollection*, uint>)0x00478810)(i_rcData);
    // unsigned int __cdecl DialogFactory::MakeCallbackDialogInCurrentUI(const PropertyCollection*,void (__cdecl*pFunc)(const PropertyCollection*))
    public static uint MakeCallbackDialogInCurrentUI(ACBindings.PropertyCollection* i_rcData, delegate* unmanaged[Cdecl]<ACBindings.PropertyCollection*, void> pFunc) => ((delegate* unmanaged[Cdecl]<ACBindings.PropertyCollection*, delegate* unmanaged[Cdecl]<ACBindings.PropertyCollection*, void>, uint>)0x00478830)(i_rcData, pFunc);
}

