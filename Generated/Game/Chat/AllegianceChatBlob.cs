namespace ACBindings.Internal;


/// <summary>Represents a chat data blob specific to an allegiance context, extending TurbineChatBlob with a monarch identifier for targeted communication. Enables sending and receiving messages associated with a particular monarch within the game's alliance system.</summary>
public unsafe struct AllegianceChatBlob
{
    // Base Classes
    public ACBindings.Internal.TurbineChatBlob BaseClass_TurbineChatBlob; // ACBindings.Internal.TurbineChatBlob

    // Members
    public uint m_monarchID;

    // Methods
}

