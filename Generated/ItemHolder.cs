namespace ACBindings;

// ItemHolder
public unsafe struct ItemHolder
{
    // Statics
    public static double* m_timeLastUsed = (double*)0x0086E790;

    // Methods
    // int __cdecl ItemHolder::CheckHookStatus(ACCWeenieObject*,ACCWeenieObject*,int*)
    public static int CheckHookStatus(ACBindings.ACCWeenieObject* ween_obj, ACBindings.ACCWeenieObject* container, int* not_owner) => ((delegate* unmanaged[Cdecl]<ACBindings.ACCWeenieObject*, ACBindings.ACCWeenieObject*, int*, int>)0x00587CC0)(ween_obj, container, not_owner);
    // unsigned int __cdecl ItemHolder::GetObjectSplitSize(ACCWeenieObject*)
    public static uint GetObjectSplitSize(ACBindings.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Cdecl]<ACBindings.ACCWeenieObject*, uint>)0x00587D30)(weenObj);
    // int __cdecl ItemHolder::IsMergeAttemptLegal(unsigned int,unsigned int,int)
    public static int IsMergeAttemptLegal(uint objectID, uint mergeToID, int quiet) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int>)0x00587D60)(objectID, mergeToID, quiet);
    // int __cdecl ItemHolder::AttemptToPlaceInContainer_IsItemLegal(unsigned int,int)
    public static int AttemptToPlaceInContainer_IsItemLegal(uint i_itemID, int i_bQuiet) => ((delegate* unmanaged[Cdecl]<uint, int, int>)0x00587EF0)(i_itemID, i_bQuiet);
    // int __cdecl ItemHolder::AttemptSetGroundObject(unsigned int)
    public static int AttemptSetGroundObject(uint objectID) => ((delegate* unmanaged[Cdecl]<uint, int>)0x00588200)(objectID);
    // bool __cdecl ItemHolder::TargetCompatibleWithObject(unsigned int,unsigned int,bool,bool)
    public static byte TargetCompatibleWithObject(uint targetID, uint targetingObjectID, byte quiet, byte displayUseMessage) => ((delegate* unmanaged[Cdecl]<uint, uint, byte, byte, byte>)0x00588350)(targetID, targetingObjectID, quiet, displayUseMessage);
    // int __cdecl ItemHolder::AttemptMerge(unsigned int,unsigned int,int)
    public static int AttemptMerge(uint objectID, uint mergeToID, int quiet) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int>)0x00588720)(objectID, mergeToID, quiet);
    // int __cdecl ItemHolder::AttemptToPlaceInContainer_IsContainerLegal(unsigned int,unsigned int,int)
    public static int AttemptToPlaceInContainer_IsContainerLegal(uint i_itemID, uint i_containerID, int i_bQuiet) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int>)0x005887E0)(i_itemID, i_containerID, i_bQuiet);
    // int __cdecl ItemHolder::AttemptAutoMerge(unsigned int,unsigned int,unsigned int)
    public static int AttemptAutoMerge(uint i_itemID, uint i_topContainerID, uint i_preferredContainerID) => ((delegate* unmanaged[Cdecl]<uint, uint, uint, int>)0x00588A70)(i_itemID, i_topContainerID, i_preferredContainerID);
    // int __cdecl ItemHolder::WillItemFitInContainer(unsigned int,unsigned int)
    public static int WillItemFitInContainer(uint i_itemID, uint i_containerID) => ((delegate* unmanaged[Cdecl]<uint, uint, int>)0x00588B90)(i_itemID, i_containerID);
    // int __cdecl ItemHolder::IsDragIntoContainerAttemptLegal(unsigned int,unsigned int)
    public static int IsDragIntoContainerAttemptLegal(uint i_itemID, uint i_containerID) => ((delegate* unmanaged[Cdecl]<uint, uint, int>)0x00588CC0)(i_itemID, i_containerID);
    // bool __cdecl ItemHolder::IsTargetCompatibleWithTargetingObject(unsigned int)
    public static byte IsTargetCompatibleWithTargetingObject(uint i_idTargetObject) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x00588EA0)(i_idTargetObject);
    // int __cdecl ItemHolder::AttemptToPlaceInContainer(unsigned int,unsigned int,unsigned int,int,int)
    public static int AttemptToPlaceInContainer(uint i_itemID, uint i_topContainerID, uint i_preferredContainerID, int i_bAttemptAutoMerge, int i_place) => ((delegate* unmanaged[Cdecl]<uint, uint, uint, int, int, int>)0x00588F70)(i_itemID, i_topContainerID, i_preferredContainerID, i_bAttemptAutoMerge, i_place);
    // unsigned __int16 __cdecl ItemHolder::DetermineUseResult(ACCWeenieObject*)
    public static ushort DetermineUseResult(ACBindings.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Cdecl]<ACBindings.ACCWeenieObject*, ushort>)0x00589290)(weenObj);
    // int __cdecl ItemHolder::AttemptPlaceIn3D(unsigned int,unsigned int,int)
    public static int AttemptPlaceIn3D(uint objectID, uint draggedOnID, int dropIfGiveFails) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int>)0x00589430)(objectID, draggedOnID, dropIfGiveFails);
    // void __cdecl ItemHolder::UseObject(unsigned int,int,int)
    public static void UseObject(uint itemID, int targetIsSelected, int forceUse) => ((delegate* unmanaged[Cdecl]<uint, int, int, void>)0x005898B0)(itemID, targetIsSelected, forceUse);
    // void __cdecl ItemHolder::TargetAcquired(unsigned int)
    public static void TargetAcquired(uint targetID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00589D20)(targetID);
}

