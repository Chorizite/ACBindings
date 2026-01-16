namespace ACBindings.Internal;


/// <summary>Stores a linked list of command nodes, including a dedicated mouse command pointer and current traversal state.</summary>
/// <remarks>Facilitates adding, removing, and clearing commands, with special handling for the unique mouse command.</remarks>
public unsafe struct CommandList
{
    // Members
    public ACBindings.Internal.CommandListElement* head;
    public ACBindings.Internal.CommandListElement* mouse_command;
    public ACBindings.Internal.CommandListElement* current;

    // Methods

    /// <summary>Removes a command identified by <paramref name="command"/> from the list. If <paramref name="mouse"/> is non‑zero, removes the current mouse command; otherwise searches for and deletes the first matching command that is not the mouse command.
    /// <code>Offset: 0x006B58A0
    /// int __thiscall CommandList::RemoveCommand(CommandList*,unsigned int,float,int)</code>
    /// </summary>
    /// <param name="command">The identifier of the command to remove.</param>
    /// <param name="speed">Unused in this implementation; present for compatibility with other interfaces.</param>
    /// <param name="mouse">When non‑zero, causes removal of the current mouse command instead of performing a normal search.</param>
    /// <returns>Returns 1 if the removed element was the list head, otherwise returns 0.</returns>
    public int RemoveCommand(uint command, float speed, int mouse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandList, uint, float, int, int>)0x006B58A0)(ref this, command, speed, mouse);

    /// <summary>Retrieves the timestamp associated with a chat display information instance.
    /// <code>Offset: 0x006B5980
    /// unsigned int __thiscall CommandList::GetHead(ChatDisplayInfo*)</code>
    /// </summary>
    /// <param name="this">The ChatDisplayInfo object whose timestamp is requested.</param>
    /// <returns>The unsigned integer timestamp (m_ltt) of the chat entry.</returns>
    public uint GetHead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandList, uint>)0x006B5980)(ref this);

    /// <summary>Returns true if the command list’s current head element is the designated mouse command, false otherwise.
    /// <code>Offset: 0x006B5990
    /// int __thiscall CommandList::HeadIsMouse(CommandList*)</code>
    /// </summary>
    /// <returns>Nonzero if head equals mouse_command; zero otherwise.</returns>
    public int HeadIsMouse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandList, int>)0x006B5990)(ref this);

    /// <summary>Removes all command elements from the list, freeing each allocated node and resetting the head and mouse_command pointers.
    /// <code>Offset: 0x006B59B0
    /// void __thiscall CommandList::ClearAllCommands(CommandList*)</code>
    /// </summary>
    public void ClearAllCommands() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandList, void>)0x006B59B0)(ref this);

    /// <summary>Removes all keyboard command nodes preceding the mouse command in a CommandList, deleting each node and updating list links while preserving any remaining commands that follow the mouse command.
    /// <code>Offset: 0x006B5A10
    /// void __thiscall CommandList::ClearKeyboardCommands(CommandList*)</code>
    /// </summary>
    public void ClearKeyboardCommands() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandList, void>)0x006B5A10)(ref this);

    /// <summary>Adds a command to the list, optionally as a mouse command while ensuring only one such command exists.
    /// <code>Offset: 0x006B5AC0
    /// void __thiscall CommandList::AddCommand(CommandList*,unsigned int,float,int,int)</code>
    /// </summary>
    /// <param name="command">Identifier for the command to execute.</param>
    /// <param name="speed">Speed multiplier applied when executing the command.</param>
    /// <param name="mouse">If nonzero, designates this command as a mouse command; it replaces any existing mouse command in the list.</param>
    /// <param name="hold_run">Specifies whether the command should hold the run state during execution.</param>
    public void AddCommand(uint command, float speed, int mouse, int hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandList, uint, float, int, int, void>)0x006B5AC0)(ref this, command, speed, mouse, hold_run);
}

