namespace ACBindings.Internal;


/// <summary>Encapsulates message information exchanged between UI elements and the system, including identifiers, parameters, coordinates, and a timestamp.</summary>
public unsafe struct UIElementMessageInfo
{
    // Members
    public uint idElement;
    public ACBindings.Internal.UIElement* pElement;
    public uint idMessage;
    public uint dwParam1;
    public uint dwParam2;
    public ACBindings.Internal.tagPOINT ptWindow;
    public ACBindings.Internal.tagPOINT ptElement;
    public ACBindings.Internal.CTimestamp__uint tsSerialNumber;

    // Generated Constructor
    public UIElementMessageInfo(uint i_idElement, ACBindings.Internal.UIElement* i_pElement, uint i_idMessage, uint i_dwParam1, uint i_dwParam2, int i_xWindow, int i_yWindow, int i_xElement, int i_yElement) {
        _ConstructorInternal(i_idElement, i_pElement, i_idMessage, i_dwParam1, i_dwParam2, i_xWindow, i_yWindow, i_xElement, i_yElement);
    }
    public UIElementMessageInfo(ACBindings.Internal.UIElementMessageInfo* that) {
        _ConstructorInternal(that);
    }

    // Methods

    /// <summary>Creates a UIElementMessageInfo instance with specified element ID, message ID, parameters, and window/element coordinates; initializes the timestamp to zero.
    /// <code>Offset: 0x00459660
    /// void __thiscall UIElementMessageInfo::UIElementMessageInfo(UIElementMessageInfo*,unsigned int,UIElement*,unsigned int,unsigned int,unsigned int,int,int,int,int)</code>
    /// </summary>
    /// <param name="i_idElement">Identifier of the target UI element.</param>
    /// <param name="i_pElement">Pointer to the UIElement object associated with this message.</param>
    /// <param name="i_idMessage">Identifier for the specific UI message being conveyed.</param>
    /// <param name="i_dwParam1">First parameter value supplied by the message.</param>
    /// <param name="i_dwParam2">Second parameter value supplied by the message.</param>
    /// <param name="i_xWindow">X coordinate of the event relative to the window.</param>
    /// <param name="i_yWindow">Y coordinate of the event relative to the window.</param>
    /// <param name="i_xElement">X coordinate of the event relative to the element's origin.</param>
    /// <param name="i_yElement">Y coordinate of the event relative to the element's origin.</param>
    public void _ConstructorInternal(uint i_idElement, ACBindings.Internal.UIElement* i_pElement, uint i_idMessage, uint i_dwParam1, uint i_dwParam2, int i_xWindow, int i_yWindow, int i_xElement, int i_yElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementMessageInfo, uint, ACBindings.Internal.UIElement*, uint, uint, uint, int, int, int, int, void>)0x00459660)(ref this, i_idElement, i_pElement, i_idMessage, i_dwParam1, i_dwParam2, i_xWindow, i_yWindow, i_xElement, i_yElement);

    /// <summary>Copies the contents of another UIElementMessageInfo instance into this instance.
    /// <code>Offset: 0x00459CE0
    /// void __thiscall UIElementMessageInfo::UIElementMessageInfo(UIElementMessageInfo*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="that">The source UIElementMessageInfo object whose data is copied.</param>
    public void _ConstructorInternal(ACBindings.Internal.UIElementMessageInfo* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementMessageInfo, ACBindings.Internal.UIElementMessageInfo*, void>)0x00459CE0)(ref this, that);
}

