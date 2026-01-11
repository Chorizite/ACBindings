namespace ACBindings.Internal;

public unsafe struct APIManager
{
    // Statics
    public static ACBindings.Internal.APIManager* m_pCliAPI = (ACBindings.Internal.APIManager*)0x00871054;
    public static int* m_UIReady = (int*)0x00871058;

    // Child Types
    public unsafe struct IAsheronsCallImpl
    {
        // Base Classes
        public ACBindings.Internal.IAsheronsCall BaseClass_IAsheronsCall; // ACBindings.Internal.IAsheronsCall

        // Child Types
        public unsafe struct IAsheronsCallImpl_vtbl
        {
            // Members
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, ushort*, ACBindings.Internal.eChatTypes, int> WriteToChat; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, ushort*, int, int> IssueChatBarCommand; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SelectItem; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SetSelectedObjectID; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SetPreviousSelectedItemID; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> GetSelectedItemID; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> GetPreviousSelectedItemID; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> ExamineObject; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> UseObject; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, uint, int> UseObjectOn; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, uint, int> UseEquippedItem; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, ACBindings.Internal.eCombatMode, int> ChangeCombatMode; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, ACBindings.Internal.eCombatMode*, int> GetCombatMode; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, uint, int, int> MoveItemExternal; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, uint, int, int, int> MoveItemInternal; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, uint, int> CastSpell; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int*, int> GetBusyCount; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> IncrementBusyCount; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> DecrementBusyCount; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int*, int> IsStandingStill; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> StopCompletely; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, float, int> TurnToHeading; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int, int> SetAutoRun; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int*, int> GetIsOutdoors; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, double*, double*, int> GetCurCoords; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, float*, float*, float*, float*, int> GetCurLoc; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> GetPlayerID; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> GetVendorID; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> GetGroundContainerID; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> GetSelectedStackCount; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SetSelectedStackCount; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int*, int> TradeWindow_IsOpen; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> TradeWindow_GetPartnerID; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> TradeWindow_AddItem; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> TradeWindow_Clear; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> TradeWindow_Accept; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> TradeWindow_Close; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SalvagePanel_Open; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SalvagePanel_Add; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SalvagePanel_Remove; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> SalvagePanel_Close; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> SalvagePanel_Clear; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> SalvagePanel_Salvage; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> EndCharacterSession; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> BeginCharacterSession; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int*, int> GetChatState; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int*, int*, int> GetScreenDimensions; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int*, int> ItemIsKnown; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, ushort**, int> GetItemName; // function pointer

            // Methods
        }

        // Members
        public int m_cRef;

        // Methods

        /// <summary>
        /// <code>Offset: 0x0055A7B0
        /// unsigned int __stdcall APIManager::IAsheronsCallImpl::AddRef(APIManager::IAsheronsCallImpl*)</code>
        /// </summary>
        public static uint AddRef(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint>)0x0055A7B0)(this_);

        /// <summary>
        /// <code>Offset: 0x0055A7D0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::IssueChatBarCommand(APIManager::IAsheronsCallImpl*,unsigned __int16*,const int)</code>
        /// </summary>
        public static int IssueChatBarCommand(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, ushort* txt, int isBotOriginated) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, ushort*, int, int>)0x0055A7D0)(this_, txt, isBotOriginated);

        /// <summary>
        /// <code>Offset: 0x0055A7E0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::SelectItem(APIManager::IAsheronsCallImpl*,const unsigned int)</code>
        /// </summary>
        public static int SelectItem(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A7E0)(this_, objectID);

        /// <summary>
        /// <code>Offset: 0x0055A800
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::SetSelectedObjectID(APIManager::IAsheronsCallImpl*,const unsigned int)</code>
        /// </summary>
        public static int SetSelectedObjectID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A800)(this_, objectID);

        /// <summary>
        /// <code>Offset: 0x0055A820
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::SetPreviousSelectedItemID(APIManager::IAsheronsCallImpl*,const unsigned int)</code>
        /// </summary>
        public static int SetPreviousSelectedItemID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A820)(this_, objectID);

        /// <summary>
        /// <code>Offset: 0x0055A840
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetSelectedItemID(APIManager::IAsheronsCallImpl*,unsigned int*)</code>
        /// </summary>
        public static int GetSelectedItemID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint* selectedID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055A840)(this_, selectedID);

        /// <summary>
        /// <code>Offset: 0x0055A860
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetPreviousSelectedItemID(APIManager::IAsheronsCallImpl*,unsigned int*)</code>
        /// </summary>
        public static int GetPreviousSelectedItemID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint* selectedID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055A860)(this_, selectedID);

        /// <summary>
        /// <code>Offset: 0x0055A880
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::ExamineObject(APIManager::IAsheronsCallImpl*,const unsigned int)</code>
        /// </summary>
        public static int ExamineObject(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A880)(this_, objectID);

        /// <summary>
        /// <code>Offset: 0x0055A8A0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::UseObject(APIManager::IAsheronsCallImpl*,const unsigned int)</code>
        /// </summary>
        public static int UseObject(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A8A0)(this_, objectID);

        /// <summary>
        /// <code>Offset: 0x0055A8C0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::UseObjectOn(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int)</code>
        /// </summary>
        public static int UseObjectOn(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint useThisID, uint onThisID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, uint, int>)0x0055A8C0)(this_, useThisID, onThisID);

        /// <summary>
        /// <code>Offset: 0x0055A910
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::UseEquippedItem(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int)</code>
        /// </summary>
        public static int UseEquippedItem(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint useThisID, uint onThisID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, uint, int>)0x0055A910)(this_, useThisID, onThisID);

        /// <summary>
        /// <code>Offset: 0x0055A960
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::ChangeCombatMode(APIManager::IAsheronsCallImpl*,const eCombatMode)</code>
        /// </summary>
        public static int ChangeCombatMode(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, ACBindings.Internal.eCombatMode newCombatMode) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, ACBindings.Internal.eCombatMode, int>)0x0055A960)(this_, newCombatMode);

        /// <summary>
        /// <code>Offset: 0x0055A9B0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetVendorID(APIManager::IAsheronsCallImpl*,unsigned int*)</code>
        /// </summary>
        public static int GetVendorID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint* id) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055A9B0)(this_, id);

        /// <summary>
        /// <code>Offset: 0x0055A9E0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::MoveItemExternal(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int,const int)</code>
        /// </summary>
        public static int MoveItemExternal(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID, uint draggedOnID, int dropIfGiveFails) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, uint, int, int>)0x0055A9E0)(this_, objectID, draggedOnID, dropIfGiveFails);

        /// <summary>
        /// <code>Offset: 0x0055AA00
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::MoveItemInternal(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int,const int,const int)</code>
        /// </summary>
        public static int MoveItemInternal(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID, uint containerID, int place, int attemptAutoMerge) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, uint, int, int, int>)0x0055AA00)(this_, objectID, containerID, place, attemptAutoMerge);

        /// <summary>
        /// <code>Offset: 0x0055AA30
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::CastSpell(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int)</code>
        /// </summary>
        public static int CastSpell(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint spellID, uint targetID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, uint, int>)0x0055AA30)(this_, spellID, targetID);

        /// <summary>
        /// <code>Offset: 0x0055AAB0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::SetSelectedStackCount(APIManager::IAsheronsCallImpl*,int*)</code>
        /// </summary>
        public static int SetSelectedStackCount(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, int* isOpen) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int*, int>)0x0055AAB0)(this_, isOpen);

        /// <summary>
        /// <code>Offset: 0x0055AAC0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::DecrementBusyCount(APIManager::IAsheronsCallImpl*)</code>
        /// </summary>
        public static int DecrementBusyCount(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int>)0x0055AAC0)(this_);

        /// <summary>
        /// <code>Offset: 0x0055AAD0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::IsStandingStill(APIManager::IAsheronsCallImpl*,int*)</code>
        /// </summary>
        public static int IsStandingStill(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, int* isStandingStill) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int*, int>)0x0055AAD0)(this_, isStandingStill);

        /// <summary>
        /// <code>Offset: 0x0055AB00
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::StopCompletely(APIManager::IAsheronsCallImpl*)</code>
        /// </summary>
        public static int StopCompletely(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int>)0x0055AB00)(this_);

        /// <summary>
        /// <code>Offset: 0x0055AB30
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::TurnToHeading(APIManager::IAsheronsCallImpl*,const float)</code>
        /// </summary>
        public static int TurnToHeading(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, float heading) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, float, int>)0x0055AB30)(this_, heading);

        /// <summary>
        /// <code>Offset: 0x0055ABA0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::SetAutoRun(APIManager::IAsheronsCallImpl*,const int)</code>
        /// </summary>
        public static int SetAutoRun(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, int val) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int, int>)0x0055ABA0)(this_, val);

        /// <summary>
        /// <code>Offset: 0x0055ABF0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetCurCoords(APIManager::IAsheronsCallImpl*,long double*,long double*)</code>
        /// </summary>
        public static int GetCurCoords(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, double* coordX, double* coordY) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, double*, double*, int>)0x0055ABF0)(this_, coordX, coordY);

        /// <summary>
        /// <code>Offset: 0x0055AC40
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetCurLoc(APIManager::IAsheronsCallImpl*,unsigned int*,float*,float*,float*,float*)</code>
        /// </summary>
        public static int GetCurLoc(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint* landblock, float* x, float* y, float* z, float* heading) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint*, float*, float*, float*, float*, int>)0x0055AC40)(this_, landblock, x, y, z, heading);

        /// <summary>
        /// <code>Offset: 0x0055AC70
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetPlayerID(APIManager::IAsheronsCallImpl*,unsigned int*)</code>
        /// </summary>
        public static int GetPlayerID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint* id) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055AC70)(this_, id);

        /// <summary>
        /// <code>Offset: 0x0055ACC0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetGroundContainerID(APIManager::IAsheronsCallImpl*,unsigned int*)</code>
        /// </summary>
        public static int GetGroundContainerID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint* id) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055ACC0)(this_, id);

        /// <summary>
        /// <code>Offset: 0x0055AD00
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::TradeWindow_Clear(APIManager::IAsheronsCallImpl*)</code>
        /// </summary>
        public static int TradeWindow_Clear(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int>)0x0055AD00)(this_);

        /// <summary>
        /// <code>Offset: 0x0055AD10
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::EndCharacterSession(APIManager::IAsheronsCallImpl*)</code>
        /// </summary>
        public static int EndCharacterSession(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int>)0x0055AD10)(this_);

        /// <summary>
        /// <code>Offset: 0x0055AD50
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::BeginCharacterSession(APIManager::IAsheronsCallImpl*,unsigned int)</code>
        /// </summary>
        public static int BeginCharacterSession(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint iidCharacter) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int>)0x0055AD50)(this_, iidCharacter);

        /// <summary>
        /// <code>Offset: 0x0055AD90
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetScreenDimensions(APIManager::IAsheronsCallImpl*,int*,int*)</code>
        /// </summary>
        public static int GetScreenDimensions(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, int* area3DWidth, int* area3DHeight) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int*, int*, int>)0x0055AD90)(this_, area3DWidth, area3DHeight);

        /// <summary>
        /// <code>Offset: 0x0055ADC0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::ItemIsKnown(APIManager::IAsheronsCallImpl*,const unsigned int,int*)</code>
        /// </summary>
        public static int ItemIsKnown(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint itemID, int* isKnown) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int*, int>)0x0055ADC0)(this_, itemID, isKnown);

        /// <summary>
        /// <code>Offset: 0x0055AE10
        /// unsigned int __stdcall APIManager::IAsheronsCallImpl::Release(APIManager::IAsheronsCallImpl*)</code>
        /// </summary>
        public static uint Release(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint>)0x0055AE10)(this_);

        /// <summary>
        /// <code>Offset: 0x0055AE40
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetItemName(APIManager::IAsheronsCallImpl*,const unsigned int,unsigned __int16**)</code>
        /// </summary>
        public static int GetItemName(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint itemID, ushort** itemName) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, ushort**, int>)0x0055AE40)(this_, itemID, itemName);

        /// <summary>
        /// <code>Offset: 0x0055B0E0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::WriteToChat(APIManager::IAsheronsCallImpl*,unsigned __int16*,const eChatTypes)</code>
        /// </summary>
        public static int WriteToChat(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, ushort* txt, ACBindings.Internal.eChatTypes type) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, ushort*, ACBindings.Internal.eChatTypes, int>)0x0055B0E0)(this_, txt, type);
    }

    // Members
    public ACBindings.Internal.IACPlugin* m_pPlugin;
    public ACBindings.Internal.IAsheronsCall* m_pAsheronsCallImpl;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0055A740
    /// IACPlugin* __cdecl APIManager::GetACPlugin()</code>
    /// </summary>
    public static ACBindings.Internal.IACPlugin* GetACPlugin() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.IACPlugin*>)0x0055A740)();

    /// <summary>
    /// <code>Offset: 0x0055AED0
    /// IAsheronsCall* __thiscall APIManager::GetAsheronsCallImpl(APIManager*)</code>
    /// </summary>
    public ACBindings.Internal.IAsheronsCall* GetAsheronsCallImpl() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.APIManager, ACBindings.Internal.IAsheronsCall*>)0x0055AED0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0055AF00
    /// int __cdecl APIManager::Init()</code>
    /// </summary>
    public static int Init() => ((delegate* unmanaged[Cdecl]<int>)0x0055AF00)();

    /// <summary>
    /// <code>Offset: 0x0055B070
    /// void __cdecl APIManager::SetUIReady(int)</code>
    /// </summary>
    public static void SetUIReady(int isReady) => ((delegate* unmanaged[Cdecl]<int, void>)0x0055B070)(isReady);

    /// <summary>
    /// <code>Offset: 0x0055B0A0
    /// int __cdecl APIManager::APIIsReady()</code>
    /// </summary>
    public static int APIIsReady() => ((delegate* unmanaged[Cdecl]<int>)0x0055B0A0)();
}

