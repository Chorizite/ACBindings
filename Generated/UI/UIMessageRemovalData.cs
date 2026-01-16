namespace ACBindings.Internal;


/// <summary>Maintains references to UI listeners involved in message removal, including a single listener and an array of listeners for batch cleanup operations.</summary>
public unsafe struct UIMessageRemovalData
{
    // Members
    public ACBindings.Internal.UIListener* pListener;
    public System.IntPtr pListenerArray;

    // Methods
}

