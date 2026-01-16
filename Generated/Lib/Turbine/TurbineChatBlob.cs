namespace ACBindings.Internal;


/// <summary>Represents a data structure used by Turbine chat services to encapsulate message metadata such as target identifier, result status, and chat type.</summary>
public unsafe struct TurbineChatBlob
{
    // Members
    public uint m_targetID;
    public int m_hResult;
    public uint m_ChatType;

    // Methods

    /// <summary>Stores the specified target identifier within the chat blob.
    /// <code>Offset: 0x0051C6F0
    /// void __thiscall TurbineChatBlob::SetTargetID(TurbineChatBlob*,unsigned int)</code>
    /// </summary>
    /// <param name="targetID">The identifier representing the target entity or conversation for this chat blob.</param>
    public void SetTargetID(uint targetID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineChatBlob, uint, void>)0x0051C6F0)(ref this, targetID);

    /// <summary>Creates a tagBLOB that encapsulates the current TurbineChatBlob instance for use in chat APIs.
    /// <code>Offset: 0x005CE950
    /// tagBLOB __thiscall TurbineChatBlob::GetBlob(TurbineChatBlob*)</code>
    /// </summary>
    /// <returns>A tagBLOB structure with its internal pointer set to this TurbineChatBlob instance, enabling it to be passed to other components.</returns>
    public ACBindings.Internal.tagBLOB GetBlob() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineChatBlob, ACBindings.Internal.tagBLOB>)0x005CE950)(ref this);
}

