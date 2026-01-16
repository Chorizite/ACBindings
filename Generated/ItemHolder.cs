namespace ACBindings.Internal;


/// <summary>Provides utilities for managing in‑game items, handling stacking, placement, usage, and trade interactions within the client inventory system.</summary>
public unsafe struct ItemHolder
{
    // Statics
    public static uint* targetingObject = (uint*)0x00871AE4;
    public static double* m_timeLastUsed = (double*)0x00871AE8;

    // Methods

    /// <summary>Determines whether a Weenie object may be hooked into a specified container, taking into account the container’s hook type, accepted item types, and any house‑ownership restrictions.
    /// <code>Offset: 0x00587CC0
    /// int __cdecl ItemHolder::CheckHookStatus(ACCWeenieObject*,ACCWeenieObject*,int*)</code>
    /// </summary>
    /// <param name="ween_obj">The object that is attempting to attach a hook.</param>
    /// <param name="container">The target container that might accept the hook.</param>
    /// <param name="not_owner">Set to 1 when hooking fails because the container has an ownership restriction (its house owner ID is zero); otherwise set to 0.</param>
    /// <returns>Non‑zero if the ween object can be hooked into the container; zero if it cannot.</returns>
    public static int CheckHookStatus(ACBindings.Internal.ACCWeenieObject* ween_obj, ACBindings.Internal.ACCWeenieObject* container, int* not_owner) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.ACCWeenieObject*, int*, int>)0x00587CC0)(ween_obj, container, not_owner);

    /// <summary>Determines the quantity an item should be split into when divided in inventory.
    /// <code>Offset: 0x00587D30
    /// unsigned int __cdecl ItemHolder::GetObjectSplitSize(ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="weenObj">The object to query for split size.</param>
    /// <returns>The number of units that will remain after a split operation; uses a predefined split size if the object's ID matches the selected ID, otherwise returns its stack size or 1 if undefined.</returns>
    public static uint GetObjectSplitSize(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ACCWeenieObject*, uint>)0x00587D30)(weenObj);

    /// <summary>Determines whether a merge of two items is permissible under current game rules and states.
    /// <code>Offset: 0x00587D60
    /// int __cdecl ItemHolder::IsMergeAttemptLegal(unsigned int,unsigned int,int)</code>
    /// </summary>
    /// <param name="objectID">The identifier of the item to be merged.</param>
    /// <param name="mergeToID">The identifier of the target stack into which the item would merge.</param>
    /// <param name="quiet">When non‑zero, suppresses user‑facing error messages during validation.</param>
    /// <returns>Non‑zero if the merge can proceed; zero otherwise.</returns>
    public static int IsMergeAttemptLegal(uint objectID, uint mergeToID, int quiet) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int>)0x00587D60)(objectID, mergeToID, quiet);

    /// <summary>Determines whether an item can be placed in a container, performing validity and ownership checks. Optionally displays error notices when the check fails.
    /// <code>Offset: 0x00587EF0
    /// int __cdecl ItemHolder::AttemptToPlaceInContainer_IsItemLegal(unsigned int,int)</code>
    /// </summary>
    /// <param name="i_itemID">Identifier of the item to test for placement legality.</param>
    /// <param name="i_bQuiet">Suppresses user-visible notices if set; otherwise messages are displayed on failure.</param>
    /// <returns>Non-zero (1) if the item is legal for container placement; zero if it fails any check or is invalid.</returns>
    public static int AttemptToPlaceInContainer_IsItemLegal(uint i_itemID, int i_bQuiet) => ((delegate* unmanaged[Cdecl]<uint, int, int>)0x00587EF0)(i_itemID, i_bQuiet);

    /// <summary>Attempts to set an item identified by <paramref name="objectID"/> as a ground object for the current player, performing validation on client UI presence, player readiness, and object status. If successful, updates the UI system and returns 1; otherwise displays an appropriate notice and returns 0.
    /// <code>Offset: 0x00588200
    /// int __cdecl ItemHolder::AttemptSetGroundObject(unsigned int)</code>
    /// </summary>
    /// <param name="objectID">Unique identifier of the target object.</param>
    /// <returns>Integer indicating success (1) or failure (0).</returns>
    public static int AttemptSetGroundObject(uint objectID) => ((delegate* unmanaged[Cdecl]<uint, int>)0x00588200)(objectID);

    /// <summary>Determines whether the item identified by <paramref name="targetingObjectID"/> can be used on the object identified by <paramref name="targetID"/>, checking ownership, trade status, and use rules.
    /// <code>Offset: 0x00588350
    /// bool __cdecl ItemHolder::TargetCompatibleWithObject(unsigned int,unsigned int,bool,bool)</code>
    /// </summary>
    /// <param name="targetID">The unique identifier of the target object or character to receive the use action.</param>
    /// <param name="targetingObjectID">The unique identifier of the source item that is attempting to be used.</param>
    /// <param name="quiet">If true, suppresses any error or status messages when the usage is not allowed; otherwise messages are displayed.</param>
    /// <param name="displayUseMessage">When true, displays a “Using the …” message upon successful compatibility check.</param>
    /// <returns>True if the source item can be used on the target according to game rules; otherwise false.</returns>
    public static byte TargetCompatibleWithObject(uint targetID, uint targetingObjectID, byte quiet, byte displayUseMessage) => ((delegate* unmanaged[Cdecl]<uint, uint, byte, byte, byte>)0x00588350)(targetID, targetingObjectID, quiet, displayUseMessage);

    /// <summary>Attempts to combine two items identified by their object IDs, performing stack size checks and updating the UI on success.
    /// <code>Offset: 0x00588720
    /// int __cdecl ItemHolder::AttemptMerge(unsigned int,unsigned int,int)</code>
    /// </summary>
    /// <param name="objectID">The ID of the item to merge from.</param>
    /// <param name="mergeToID">The target item's ID into which the first item will be merged.</param>
    /// <param name="quiet">Flag indicating whether error messages should be suppressed during legality checks.</param>
    /// <returns>1 if the merge succeeds; otherwise returns an error code from IsMergeAttemptLegal.</returns>
    public static int AttemptMerge(uint objectID, uint mergeToID, int quiet) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int>)0x00588720)(objectID, mergeToID, quiet);

    /// <summary>Determines whether an item may be placed into a specified container, optionally reporting issues to the user.
    /// <code>Offset: 0x005887E0
    /// int __cdecl ItemHolder::AttemptToPlaceInContainer_IsContainerLegal(unsigned int,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_itemID">Identifier of the item being moved.</param>
    /// <param name="i_containerID">Identifier of the destination container.</param>
    /// <param name="i_bQuiet">Suppresses UI notifications when non‑zero; otherwise messages are displayed for disallowed actions.</param>
    /// <returns>1 if placement is allowed, 0 otherwise.</returns>
    public static int AttemptToPlaceInContainer_IsContainerLegal(uint i_itemID, uint i_containerID, int i_bQuiet) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int>)0x005887E0)(i_itemID, i_containerID, i_bQuiet);

    /// <summary>Attempts to merge an item into a compatible stack found within the specified container, searching recursively through all nested items. The operation succeeds only when the item supports stacking and a suitable stack with available space exists; otherwise no action is taken.
    /// <code>Offset: 0x00588A70
    /// int __cdecl ItemHolder::AttemptAutoMerge(unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_itemID">Identifier of the item to be merged.</param>
    /// <param name="i_topContainerID">Identifier of the container whose contents are examined for a compatible stack.</param>
    /// <param name="i_preferredContainerID">Optional identifier of a subcontainer that must exist; if non‑zero, the function verifies its existence but does not restrict merging to items within it.</param>
    /// <returns>Zero when no merge is performed or the item cannot be merged; otherwise returns the result code from ItemHolder::AttemptMerge indicating success.</returns>
    public static int AttemptAutoMerge(uint i_itemID, uint i_topContainerID, uint i_preferredContainerID) => ((delegate* unmanaged[Cdecl]<uint, uint, uint, int>)0x00588A70)(i_itemID, i_topContainerID, i_preferredContainerID);

    /// <summary>
    /// Determines whether a specified item can be stored inside a given container by verifying ownership, trade state, and capacity restrictions.
    /// 
    /// <code>Offset: 0x00588B90
    /// int __cdecl ItemHolder::WillItemFitInContainer(unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_itemID">The identifier of the item being tested for placement.</param>
    /// <param name="i_containerID">The identifier of the container to test against.</param>
    /// <returns>Non‑zero (typically 1) if the item will fit in the container; zero otherwise.</returns>
    public static int WillItemFitInContainer(uint i_itemID, uint i_containerID) => ((delegate* unmanaged[Cdecl]<uint, uint, int>)0x00588B90)(i_itemID, i_containerID);

    /// <summary>Checks whether a drag‑and‑drop from an item into a container is permissible based on player readiness, ownership, container capacity, trade state, and hook status.
    /// <code>Offset: 0x00588CC0
    /// int __cdecl ItemHolder::IsDragIntoContainerAttemptLegal(unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_itemID">The unique identifier of the item being dragged.</param>
    /// <param name="i_containerID">The unique identifier of the target container.</param>
    /// <returns>Integer value of 1 if the drag is legal; otherwise 0.</returns>
    public static int IsDragIntoContainerAttemptLegal(uint i_itemID, uint i_containerID) => ((delegate* unmanaged[Cdecl]<uint, uint, int>)0x00588CC0)(i_itemID, i_containerID);

    /// <summary>Determines whether the specified target object ID is a valid target for the current targeting object, taking into account ownership, trade state, and item use restrictions.
    /// <code>Offset: 0x00588EA0
    /// bool __cdecl ItemHolder::IsTargetCompatibleWithTargetingObject(unsigned int)</code>
    /// </summary>
    /// <param name="i_idTargetObject">ID of the potential target object to test for compatibility with the current targeting object.</param>
    /// <returns>True if the target is compatible; otherwise false.</returns>
    public static byte IsTargetCompatibleWithTargetingObject(uint i_idTargetObject) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x00588EA0)(i_idTargetObject);

    /// <summary>
    /// Attempts to move an item into a container, performing legality checks, optional auto‑merge, and stack handling. Returns non‑zero on success, zero on failure (e.g., full container or invalid request).
    /// 
    /// <code>Offset: 0x00588F70
    /// int __cdecl ItemHolder::AttemptToPlaceInContainer(unsigned int,unsigned int,unsigned int,int,int)</code>
    /// </summary>
    /// <param name="i_itemID">The unique identifier of the item to be placed.</param>
    /// <param name="i_topContainerID">The ID of the top‑level container in which the item will reside.</param>
    /// <param name="i_preferredContainerID">Preferred sub‑container for placement; may be ignored if unsuitable.</param>
    /// <param name="i_bAttemptAutoMerge">Flag indicating whether to attempt merging with an existing stack before placing.</param>
    /// <param name="i_place">The index within the container where the item should be positioned, or a special value denoting automatic placement.</param>
    /// <returns>Non‑zero if the item was successfully placed or merged; zero otherwise.</returns>
    public static int AttemptToPlaceInContainer(uint i_itemID, uint i_topContainerID, uint i_preferredContainerID, int i_bAttemptAutoMerge, int i_place) => ((delegate* unmanaged[Cdecl]<uint, uint, uint, int, int, int>)0x00588F70)(i_itemID, i_topContainerID, i_preferredContainerID, i_bAttemptAutoMerge, i_place);

    /// <summary>Determines the outcome of attempting to use a game item by evaluating ownership, location, usage flags and other conditions.
    /// <code>Offset: 0x00589290
    /// unsigned __int16 __cdecl ItemHolder::DetermineUseResult(ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="weenObj">The item to evaluate for use.</param>
    /// <returns>An unsigned 16‑bit code indicating whether the item can be used and, if not, why it fails (e.g., invalid location, wrong wielder, component pack, etc.).</returns>
    public static ushort DetermineUseResult(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ACCWeenieObject*, ushort>)0x00589290)(weenObj);

    /// <summary>Attempts to place the specified item into a 3‑D position or onto another object, handling merging, giving, container placement, and ground dropping while respecting ownership, trade state, and split stack rules.
    /// <code>Offset: 0x00589430
    /// int __cdecl ItemHolder::AttemptPlaceIn3D(unsigned int,unsigned int,int)</code>
    /// </summary>
    /// <param name="objectID">The ID of the item being moved.</param>
    /// <param name="draggedOnID">The target object's ID; if zero, the item is dropped to the ground.</param>
    /// <param name="dropIfGiveFails">Flag indicating whether to allow dropping onto the ground when a give action fails.</param>
    /// <returns>Non‑zero on successful placement or transfer; zero if the operation was cancelled or failed.</returns>
    public static int AttemptPlaceIn3D(uint objectID, uint draggedOnID, int dropIfGiveFails) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int>)0x00589430)(objectID, draggedOnID, dropIfGiveFails);

    /// <summary>Attempts to use an object identified by <paramref name="itemID"/>, performing cooldown checks, trade state validation, wielding requirements, target selection handling, and confirmation prompts for special items such as altars or volatile rares before invoking the appropriate use event.
    /// <code>Offset: 0x005898B0
    /// void __cdecl ItemHolder::UseObject(unsigned int,int,int)</code>
    /// </summary>
    /// <param name="itemID">The identifier of the item to be used.</param>
    /// <param name="targetIsSelected">Indicates whether a target has already been selected when the item requires targeting.</param>
    /// <param name="forceUse">If non-zero, bypasses some usage restrictions and forces the action to proceed.</param>
    public static void UseObject(uint itemID, int targetIsSelected, int forceUse) => ((delegate* unmanaged[Cdecl]<uint, int, int, void>)0x005898B0)(itemID, targetIsSelected, forceUse);

    /// <summary>Processes interaction between the held item and the specified target when a target is acquired, handling special cases such as mana draining or salvaging based on compatibility checks and updating UI and player state accordingly.
    /// <code>Offset: 0x00589D20
    /// void __cdecl ItemHolder::TargetAcquired(unsigned int)</code>
    /// </summary>
    /// <param name="targetID">Identifier of the object that has been targeted by the user.</param>
    public static void TargetAcquired(uint targetID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00589D20)(targetID);
}

