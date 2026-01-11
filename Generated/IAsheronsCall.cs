namespace ACBindings.Internal;

public unsafe struct IAsheronsCall
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IAsheronsCall_vtbl
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

    // Methods
}

