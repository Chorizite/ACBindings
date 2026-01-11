namespace ACBindings.Internal;

public unsafe struct TurbineChatBlob
{
    // Members
    public uint m_targetID;
    public int m_hResult;
    public uint m_ChatType;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0051C6F0
    /// void __thiscall TurbineChatBlob::SetTargetID(TurbineChatBlob*,unsigned int)</code>
    /// </summary>
    public void SetTargetID(uint targetID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineChatBlob, uint, void>)0x0051C6F0)(ref this, targetID);

    /// <summary>
    /// <code>Offset: 0x005CE950
    /// tagBLOB __thiscall TurbineChatBlob::GetBlob(TurbineChatBlob*)</code>
    /// </summary>
    public ACBindings.Internal.tagBLOB GetBlob() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineChatBlob, ACBindings.Internal.tagBLOB>)0x005CE950)(ref this);
}

