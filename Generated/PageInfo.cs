namespace ACBindings.Internal;

public unsafe struct PageInfo
{
    // Members
    public ACBindings.Internal.PStringBase__ushort m_Label;
    public ACBindings.Internal.PStringBase__ushort m_Title;
    public ACBindings.Internal.PStringBase__ushort m_Notes;
    public int m_PageNumber;
    public byte m_TimerRunning;
    public double m_TimerStamp;
    public int m_Days;
    public int m_Hours;
    public int m_Minutes;
    public byte m_LocationSet;
    public double m_xCoord;
    public double m_yCoord;

    // Generated Constructor
    public PageInfo() {
        _ConstructorInternal();
    }
    public PageInfo(ACBindings.Internal.PageInfo* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00494E50
    /// void __thiscall PageInfo::PageInfo(PageInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageInfo, void>)0x00494E50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00494F70
    /// void __thiscall PageInfo::Clear(PageInfo*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageInfo, void>)0x00494F70)(ref this);

    /// <summary>
    /// <code>Offset: 0x004951D0
    /// void __thiscall PageInfo::PageInfo(PageInfo*,const PageInfo*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.PageInfo* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageInfo, ACBindings.Internal.PageInfo*, void>)0x004951D0)(ref this, rhs);
}

