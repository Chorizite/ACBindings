namespace ACBindings;

// APIManager
public unsafe struct APIManager
{
    // Statics
    public static int* m_UIReady = (int*)0x0086F1BC;

    // Child Types
    // APIManager::IAsheronsCallImpl_vtbl
    public unsafe struct IAsheronsCallImpl_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr WriteToChat; // function pointer
        public System.IntPtr IssueChatBarCommand; // function pointer
        public System.IntPtr SelectItem; // function pointer
        public System.IntPtr SetSelectedObjectID; // function pointer
        public System.IntPtr SetPreviousSelectedItemID; // function pointer
        public System.IntPtr GetSelectedItemID; // function pointer
        public System.IntPtr GetPreviousSelectedItemID; // function pointer
        public System.IntPtr ExamineObject; // function pointer
        public System.IntPtr UseObject; // function pointer
        public System.IntPtr UseObjectOn; // function pointer
        public System.IntPtr UseEquippedItem; // function pointer
        public System.IntPtr ChangeCombatMode; // function pointer
        public System.IntPtr GetCombatMode; // function pointer
        public System.IntPtr MoveItemExternal; // function pointer
        public System.IntPtr MoveItemInternal; // function pointer
        public System.IntPtr CastSpell; // function pointer
        public System.IntPtr GetBusyCount; // function pointer
        public System.IntPtr IncrementBusyCount; // function pointer
        public System.IntPtr DecrementBusyCount; // function pointer
        public System.IntPtr IsStandingStill; // function pointer
        public System.IntPtr StopCompletely; // function pointer
        public System.IntPtr TurnToHeading; // function pointer
        public System.IntPtr SetAutoRun; // function pointer
        public System.IntPtr GetIsOutdoors; // function pointer
        public System.IntPtr GetCurCoords; // function pointer
        public System.IntPtr GetCurLoc; // function pointer
        public System.IntPtr GetPlayerID; // function pointer
        public System.IntPtr GetVendorID; // function pointer
        public System.IntPtr GetGroundContainerID; // function pointer
        public System.IntPtr GetSelectedStackCount; // function pointer
        public System.IntPtr SetSelectedStackCount; // function pointer
        public System.IntPtr TradeWindow_IsOpen; // function pointer
        public System.IntPtr TradeWindow_GetPartnerID; // function pointer
        public System.IntPtr TradeWindow_AddItem; // function pointer
        public System.IntPtr TradeWindow_Clear; // function pointer
        public System.IntPtr TradeWindow_Accept; // function pointer
        public System.IntPtr TradeWindow_Close; // function pointer
        public System.IntPtr SalvagePanel_Open; // function pointer
        public System.IntPtr SalvagePanel_Add; // function pointer
        public System.IntPtr SalvagePanel_Remove; // function pointer
        public System.IntPtr SalvagePanel_Close; // function pointer
        public System.IntPtr SalvagePanel_Clear; // function pointer
        public System.IntPtr SalvagePanel_Salvage; // function pointer
        public System.IntPtr EndCharacterSession; // function pointer
        public System.IntPtr BeginCharacterSession; // function pointer
        public System.IntPtr GetChatState; // function pointer
        public System.IntPtr GetScreenDimensions; // function pointer
        public System.IntPtr ItemIsKnown; // function pointer
        public System.IntPtr GetItemName; // function pointer

        // Methods
    }
    // APIManager::IAsheronsCallImpl
    public unsafe struct IAsheronsCallImpl
    {
        // Base Classes
        public ACBindings.IAsheronsCall BaseClass_IAsheronsCall; // ACBindings.IAsheronsCall

        // Members
        public int m_cRef;

        // Methods
        // unsigned int __stdcall APIManager::IAsheronsCallImpl::AddRef(APIManager::IAsheronsCallImpl*)
        public static uint AddRef(ACBindings.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint>)0x0055A7B0)(this_);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::IssueChatBarCommand(APIManager::IAsheronsCallImpl*,unsigned __int16*,const int)
        public static int IssueChatBarCommand(ACBindings.APIManager.IAsheronsCallImpl* this_, ushort* txt, int isBotOriginated) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, ushort*, int, int>)0x0055A7D0)(this_, txt, isBotOriginated);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::SelectItem(APIManager::IAsheronsCallImpl*,const unsigned int)
        public static int SelectItem(ACBindings.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A7E0)(this_, objectID);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::SetSelectedObjectID(APIManager::IAsheronsCallImpl*,const unsigned int)
        public static int SetSelectedObjectID(ACBindings.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A800)(this_, objectID);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::SetPreviousSelectedItemID(APIManager::IAsheronsCallImpl*,const unsigned int)
        public static int SetPreviousSelectedItemID(ACBindings.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A820)(this_, objectID);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::GetSelectedItemID(APIManager::IAsheronsCallImpl*,unsigned int*)
        public static int GetSelectedItemID(ACBindings.APIManager.IAsheronsCallImpl* this_, uint* selectedID) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055A840)(this_, selectedID);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::GetPreviousSelectedItemID(APIManager::IAsheronsCallImpl*,unsigned int*)
        public static int GetPreviousSelectedItemID(ACBindings.APIManager.IAsheronsCallImpl* this_, uint* selectedID) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055A860)(this_, selectedID);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::ExamineObject(APIManager::IAsheronsCallImpl*,const unsigned int)
        public static int ExamineObject(ACBindings.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A880)(this_, objectID);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::UseObject(APIManager::IAsheronsCallImpl*,const unsigned int)
        public static int UseObject(ACBindings.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A8A0)(this_, objectID);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::UseObjectOn(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int)
        public static int UseObjectOn(ACBindings.APIManager.IAsheronsCallImpl* this_, uint useThisID, uint onThisID) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint, uint, int>)0x0055A8C0)(this_, useThisID, onThisID);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::UseEquippedItem(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int)
        public static int UseEquippedItem(ACBindings.APIManager.IAsheronsCallImpl* this_, uint useThisID, uint onThisID) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint, uint, int>)0x0055A910)(this_, useThisID, onThisID);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::ChangeCombatMode(APIManager::IAsheronsCallImpl*,const eCombatMode)
        public static int ChangeCombatMode(ACBindings.APIManager.IAsheronsCallImpl* this_, ACBindings.eCombatMode newCombatMode) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, ACBindings.eCombatMode, int>)0x0055A960)(this_, newCombatMode);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::GetVendorID(APIManager::IAsheronsCallImpl*,unsigned int*)
        public static int GetVendorID(ACBindings.APIManager.IAsheronsCallImpl* this_, uint* id) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055A9B0)(this_, id);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::MoveItemExternal(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int,const int)
        public static int MoveItemExternal(ACBindings.APIManager.IAsheronsCallImpl* this_, uint objectID, uint draggedOnID, int dropIfGiveFails) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint, uint, int, int>)0x0055A9E0)(this_, objectID, draggedOnID, dropIfGiveFails);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::MoveItemInternal(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int,const int,const int)
        public static int MoveItemInternal(ACBindings.APIManager.IAsheronsCallImpl* this_, uint objectID, uint containerID, int place, int attemptAutoMerge) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint, uint, int, int, int>)0x0055AA00)(this_, objectID, containerID, place, attemptAutoMerge);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::CastSpell(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int)
        public static int CastSpell(ACBindings.APIManager.IAsheronsCallImpl* this_, uint spellID, uint targetID) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint, uint, int>)0x0055AA30)(this_, spellID, targetID);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::SetSelectedStackCount(APIManager::IAsheronsCallImpl*,int*)
        public static int SetSelectedStackCount(ACBindings.APIManager.IAsheronsCallImpl* this_, int* isOpen) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, int*, int>)0x0055AAB0)(this_, isOpen);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::DecrementBusyCount(APIManager::IAsheronsCallImpl*)
        public static int DecrementBusyCount(ACBindings.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, int>)0x0055AAC0)(this_);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::IsStandingStill(APIManager::IAsheronsCallImpl*,int*)
        public static int IsStandingStill(ACBindings.APIManager.IAsheronsCallImpl* this_, int* isStandingStill) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, int*, int>)0x0055AAD0)(this_, isStandingStill);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::StopCompletely(APIManager::IAsheronsCallImpl*)
        public static int StopCompletely(ACBindings.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, int>)0x0055AB00)(this_);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::TurnToHeading(APIManager::IAsheronsCallImpl*,const float)
        public static int TurnToHeading(ACBindings.APIManager.IAsheronsCallImpl* this_, float heading) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, float, int>)0x0055AB30)(this_, heading);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::SetAutoRun(APIManager::IAsheronsCallImpl*,const int)
        public static int SetAutoRun(ACBindings.APIManager.IAsheronsCallImpl* this_, int val) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, int, int>)0x0055ABA0)(this_, val);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::GetCurCoords(APIManager::IAsheronsCallImpl*,long double*,long double*)
        public static int GetCurCoords(ACBindings.APIManager.IAsheronsCallImpl* this_, double* coordX, double* coordY) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, double*, double*, int>)0x0055ABF0)(this_, coordX, coordY);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::GetCurLoc(APIManager::IAsheronsCallImpl*,unsigned int*,float*,float*,float*,float*)
        public static int GetCurLoc(ACBindings.APIManager.IAsheronsCallImpl* this_, uint* landblock, float* x, float* y, float* z, float* heading) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint*, float*, float*, float*, float*, int>)0x0055AC40)(this_, landblock, x, y, z, heading);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::GetPlayerID(APIManager::IAsheronsCallImpl*,unsigned int*)
        public static int GetPlayerID(ACBindings.APIManager.IAsheronsCallImpl* this_, uint* id) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055AC70)(this_, id);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::GetGroundContainerID(APIManager::IAsheronsCallImpl*,unsigned int*)
        public static int GetGroundContainerID(ACBindings.APIManager.IAsheronsCallImpl* this_, uint* id) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055ACC0)(this_, id);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::TradeWindow_Clear(APIManager::IAsheronsCallImpl*)
        public static int TradeWindow_Clear(ACBindings.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, int>)0x0055AD00)(this_);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::EndCharacterSession(APIManager::IAsheronsCallImpl*)
        public static int EndCharacterSession(ACBindings.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, int>)0x0055AD10)(this_);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::BeginCharacterSession(APIManager::IAsheronsCallImpl*,unsigned int)
        public static int BeginCharacterSession(ACBindings.APIManager.IAsheronsCallImpl* this_, uint iidCharacter) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint, int>)0x0055AD50)(this_, iidCharacter);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::GetScreenDimensions(APIManager::IAsheronsCallImpl*,int*,int*)
        public static int GetScreenDimensions(ACBindings.APIManager.IAsheronsCallImpl* this_, int* area3DWidth, int* area3DHeight) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, int*, int*, int>)0x0055AD90)(this_, area3DWidth, area3DHeight);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::ItemIsKnown(APIManager::IAsheronsCallImpl*,const unsigned int,int*)
        public static int ItemIsKnown(ACBindings.APIManager.IAsheronsCallImpl* this_, uint itemID, int* isKnown) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint, int*, int>)0x0055ADC0)(this_, itemID, isKnown);
        // unsigned int __stdcall APIManager::IAsheronsCallImpl::Release(APIManager::IAsheronsCallImpl*)
        public static uint Release(ACBindings.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint>)0x0055AE10)(this_);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::GetItemName(APIManager::IAsheronsCallImpl*,const unsigned int,unsigned __int16**)
        public static int GetItemName(ACBindings.APIManager.IAsheronsCallImpl* this_, uint itemID, ushort** itemName) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, uint, ushort**, int>)0x0055AE40)(this_, itemID, itemName);
        // HRESULT __stdcall APIManager::IAsheronsCallImpl::WriteToChat(APIManager::IAsheronsCallImpl*,unsigned __int16*,const eChatTypes)
        public static int WriteToChat(ACBindings.APIManager.IAsheronsCallImpl* this_, ushort* txt, ACBindings.eChatTypes type) => ((delegate* unmanaged[Stdcall]<ACBindings.APIManager.IAsheronsCallImpl*, ushort*, ACBindings.eChatTypes, int>)0x0055B0E0)(this_, txt, type);
    }

    // Members
    public ACBindings.IACPlugin* m_pPlugin;
    public ACBindings.IAsheronsCall* m_pAsheronsCallImpl;

    // Methods
    // IACPlugin* __cdecl APIManager::GetACPlugin()
    public static ACBindings.IACPlugin* GetACPlugin() => ((delegate* unmanaged[Cdecl]<ACBindings.IACPlugin*>)0x0055A740)();
    // IAsheronsCall* __thiscall APIManager::GetAsheronsCallImpl(APIManager*)
    public ACBindings.IAsheronsCall* GetAsheronsCallImpl() => ((delegate* unmanaged[Thiscall]<ref ACBindings.APIManager, ACBindings.IAsheronsCall*>)0x0055AED0)(ref this);
    // int __cdecl APIManager::Init()
    public static int Init() => ((delegate* unmanaged[Cdecl]<int>)0x0055AF00)();
    // void __cdecl APIManager::SetUIReady(int)
    public static void SetUIReady(int isReady) => ((delegate* unmanaged[Cdecl]<int, void>)0x0055B070)(isReady);
    // int __cdecl APIManager::APIIsReady()
    public static int APIIsReady() => ((delegate* unmanaged[Cdecl]<int>)0x0055B0A0)();
}

