namespace ACBindings.Internal;


/// <summary>Represents an end‑of‑DDD message, extending FakeMessageData for use within the application’s messaging infrastructure.</summary>
public unsafe struct DDD_EndDDDMessage
{
    // Base Classes
    public ACBindings.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindings.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_EndDDDMessage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DDD_EndDDDMessage*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Methods
}

