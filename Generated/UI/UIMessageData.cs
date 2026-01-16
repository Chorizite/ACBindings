namespace ACBindings.Internal;


/// <summary>Represents message data containing a listener reference and an associated count used in UI event handling.</summary>
public unsafe struct UIMessageData
{
    // Members
    public ACBindings.Internal.UIListener* pListener;
    public int nCount;

    // Methods
}

