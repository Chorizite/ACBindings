namespace ACBindings.Internal;


/// <summary>Specifies the rectangular area occupied by a UI element in screen coordinates, along with its visibility status.</summary>
public unsafe struct UILocationData
{
    // Members
    public float m_x0;
    public float m_y0;
    public float m_x1;
    public float m_y1;
    public byte m_shown;

    // Generated Constructor
    public UILocationData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a UILocationData instance with default coordinates set to –3.0 and visibility enabled.
    /// <code>Offset: 0x006791D0
    /// void __thiscall UILocationData::UILocationData(UILocationData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UILocationData, void>)0x006791D0)(ref this);
}

