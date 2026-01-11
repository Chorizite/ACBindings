namespace ACBindings.Internal;

public unsafe struct CommandList
{
    // Members
    public ACBindings.Internal.CommandListElement* head;
    public ACBindings.Internal.CommandListElement* mouse_command;
    public ACBindings.Internal.CommandListElement* current;

    // Methods

    /// <summary>
    /// <code>Offset: 0x006B58A0
    /// int __thiscall CommandList::RemoveCommand(CommandList*,unsigned int,float,int)</code>
    /// </summary>
    public int RemoveCommand(uint command, float speed, int mouse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandList, uint, float, int, int>)0x006B58A0)(ref this, command, speed, mouse);

    /// <summary>
    /// <code>Offset: 0x006B5980
    /// unsigned int __thiscall CommandList::GetHead(ChatDisplayInfo*)</code>
    /// </summary>
    public uint GetHead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandList, uint>)0x006B5980)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B5990
    /// int __thiscall CommandList::HeadIsMouse(CommandList*)</code>
    /// </summary>
    public int HeadIsMouse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandList, int>)0x006B5990)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B59B0
    /// void __thiscall CommandList::ClearAllCommands(CommandList*)</code>
    /// </summary>
    public void ClearAllCommands() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandList, void>)0x006B59B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B5A10
    /// void __thiscall CommandList::ClearKeyboardCommands(CommandList*)</code>
    /// </summary>
    public void ClearKeyboardCommands() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandList, void>)0x006B5A10)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B5AC0
    /// void __thiscall CommandList::AddCommand(CommandList*,unsigned int,float,int,int)</code>
    /// </summary>
    public void AddCommand(uint command, float speed, int mouse, int hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandList, uint, float, int, int, void>)0x006B5AC0)(ref this, command, speed, mouse, hold_run);
}

