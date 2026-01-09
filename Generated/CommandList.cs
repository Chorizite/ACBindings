namespace ACBindings;

// CommandList
public unsafe struct CommandList
{
    // Members
    public ACBindings.CommandListElement* head;
    public ACBindings.CommandListElement* mouse_command;
    public ACBindings.CommandListElement* current;

    // Methods
    // int __thiscall CommandList::RemoveCommand(CommandList*,unsigned int,float,int)
    public int RemoveCommand(uint command, float speed, int mouse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandList, uint, float, int, int>)0x006B58A0)(ref this, command, speed, mouse);
    // unsigned int __thiscall CommandList::GetHead(ChatDisplayInfo*)
    public uint GetHead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandList, uint>)0x006B5980)(ref this);
    // int __thiscall CommandList::HeadIsMouse(CommandList*)
    public int HeadIsMouse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandList, int>)0x006B5990)(ref this);
    // void __thiscall CommandList::ClearAllCommands(CommandList*)
    public void ClearAllCommands() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandList, void>)0x006B59B0)(ref this);
    // void __thiscall CommandList::ClearKeyboardCommands(CommandList*)
    public void ClearKeyboardCommands() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandList, void>)0x006B5A10)(ref this);
    // void __thiscall CommandList::AddCommand(CommandList*,unsigned int,float,int,int)
    public void AddCommand(uint command, float speed, int mouse, int hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandList, uint, float, int, int, void>)0x006B5AC0)(ref this, command, speed, mouse, hold_run);
}

