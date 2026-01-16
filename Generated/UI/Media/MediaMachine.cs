namespace ACBindings.Internal;


/// <summary>Manages a collection of media descriptions for UI elements, tracking the current item and notifying listeners on changes.</summary>
public unsafe struct MediaMachine : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIListener BaseClass_UIListener; // ACBindings.Internal.UIListener

    // Child Types
    public unsafe struct MediaMachine_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_owner;
    public ACBindings.Internal.SmartArray___MediaDesc_ptr m_array;
    public uint m_curIndex;

    // Generated Constructor
    public MediaMachine() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Determines whether a media pause period has finished based on the current system time.
    /// <code>Offset: 0x00465650
    /// bool __thiscall MediaMachine::Update_Pause(MediaMachine*,MD_Data_Pause*)</code>
    /// </summary>
    /// <param name="desc">Pause data containing minimum and maximum durations and the end time of the pause; may be initialized with an unset end time (-1).</param>
    /// <returns>True if the pause duration has elapsed; otherwise false. If the pause ends, the end time is reset to an uninitialized value.</returns>
    public byte Update_Pause(ACBindings.Internal.MD_Data_Pause* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Pause*, byte>)0x00465650)(ref this, desc);

    /// <summary>Updates the media machine’s current item index to the target specified by a jump descriptor when a random roll succeeds.
    /// <code>Offset: 0x004656E0
    /// bool __thiscall MediaMachine::Update_Jump(MediaMachine*,MD_Data_Jump*)</code>
    /// </summary>
    /// <param name="desc">Jump descriptor containing the desired target index and its probability of execution.</param>
    /// <returns>True if the descriptor and owner were valid; otherwise false. The function may change the current index only when the random roll is within the given probability range.</returns>
    public byte Update_Jump(ACBindings.Internal.MD_Data_Jump* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Jump*, byte>)0x004656E0)(ref this, desc);

    /// <summary>Attempts to send a message from the machine’s owner element using the supplied descriptor. If the probability roll succeeds, the message is broadcast; otherwise it is ignored.
    /// <code>Offset: 0x00465730
    /// bool __thiscall MediaMachine::Update_Message(MediaMachine*,MD_Data_Message*)</code>
    /// </summary>
    /// <param name="desc">Message descriptor containing an ID and probability threshold for broadcasting.</param>
    /// <returns>True if a valid descriptor and owner exist (broadcast attempted); false if either is missing.</returns>
    public byte Update_Message(ACBindings.Internal.MD_Data_Message* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Message*, byte>)0x00465730)(ref this, desc);

    /// <summary>Attempts to trigger a state change on the owner UIElement using the supplied MD_Data_State descriptor. If the descriptor's probability succeeds, calls the owner's IInputActionCallback with the descriptor's state ID.
    /// <code>Offset: 0x00465790
    /// bool __thiscall MediaMachine::Update_State(MediaMachine*,MD_Data_State*)</code>
    /// </summary>
    /// <param name="desc">State descriptor containing the target state ID and activation probability.</param>
    /// <returns>false (operation always returns false).</returns>
    public byte Update_State(ACBindings.Internal.MD_Data_State* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_State*, byte>)0x00465790)(ref this, desc);

    /// <summary>Updates a movie within the media machine, ensuring a MovieTheatre instance exists for playback and releasing it when finished.
    /// <code>Offset: 0x004657E0
    /// bool __thiscall MediaMachine::Update_Movie(MediaMachine*,MD_Data_Movie*)</code>
    /// </summary>
    /// <param name="desc">Movie data descriptor containing file name, stretch flag, and theatre pointer.</param>
    /// <returns>True if playback has completed or an error occurred creating the movie theatre; false otherwise.</returns>
    public byte Update_Movie(ACBindings.Internal.MD_Data_Movie* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Movie*, byte>)0x004657E0)(ref this, desc);

    /// <summary>
    /// Advances an animation by updating its current frame based on elapsed time relative to its total duration, applying the resulting frame to the owning UI element. When the animation reaches its end, timing data is reset and a completion flag is returned.
    /// 
    /// <code>Offset: 0x00465810
    /// bool __thiscall MediaMachine::Update_Anim(MediaMachine*,MD_Data_Anim*)</code>
    /// </summary>
    /// <param name="desc">Animation data containing duration, frame list, and playback state; this parameter is updated with the new progress and current frame index.</param>
    /// <returns>True if the animation completed during this update; otherwise false.</returns>
    public byte Update_Anim(ACBindings.Internal.MD_Data_Anim* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Anim*, byte>)0x00465810)(ref this, desc);

    /// <summary>Updates the alpha image of the MediaMachine's owner UI element according to the supplied MD_Data_Alpha descriptor, clearing or setting the image based on its file identifier.
    /// <code>Offset: 0x00465960
    /// bool __thiscall MediaMachine::Update_Alpha(MediaMachine*,MD_Data_Alpha*)</code>
    /// </summary>
    /// <param name="desc">The MD_Data_Alpha structure containing the media description and file ID to apply.</param>
    /// <returns>True if the owner element was found and updated; otherwise false when desc is null or no owner exists.</returns>
    public byte Update_Alpha(ACBindings.Internal.MD_Data_Alpha* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Alpha*, byte>)0x00465960)(ref this, desc);

    /// <summary>Updates the UI element owned by this MediaMachine with a new image specified by the given MD_Data_Image descriptor. If the descriptor’s file ID equals INVALID_DID_54, clears the current image; otherwise sets the image using the provided draw mode.
    /// <code>Offset: 0x004659A0
    /// bool __thiscall MediaMachine::Update_Image(MediaMachine*,MD_Data_Image*)</code>
    /// </summary>
    /// <param name="desc">Image data descriptor containing the file identifier and drawing mode to apply.</param>
    /// <returns>True if the image was successfully updated or cleared; false when desc is null or the MediaMachine has no owner UI element.</returns>
    public byte Update_Image(ACBindings.Internal.MD_Data_Image* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Image*, byte>)0x004659A0)(ref this, desc);

    /// <summary>Schedules a sound described by MD_Data_Sound for playback through SoundManager, requiring the machine’s owner to be valid.
    /// <code>Offset: 0x004659E0
    /// bool __thiscall MediaMachine::Update_Sound(MediaMachine*,MD_Data_Sound*)</code>
    /// </summary>
    /// <param name="desc">The media description containing a file ID and an optional sound type.</param>
    /// <returns>True when both the descriptor and the owning UI element are present; false if either is null. The function always returns true after validation, even if no sound is actually played.</returns>
    public byte Update_Sound(ACBindings.Internal.MD_Data_Sound* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Sound*, byte>)0x004659E0)(ref this, desc);

    /// <summary>Updates the alpha of a UI element according to a fade transition described by MD_Data_Fade and returns true when the transition completes.
    /// <code>Offset: 0x00465A60
    /// bool __thiscall MediaMachine::Update_Fade(MediaMachine*,MD_Data_Fade*)</code>
    /// </summary>
    /// <param name="desc">Fade parameters including start/end alpha, duration, and elapsed time.</param>
    /// <returns>True if the fade has finished; otherwise false.</returns>
    public byte Update_Fade(ACBindings.Internal.MD_Data_Fade* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Fade*, byte>)0x00465A60)(ref this, desc);

    /// <summary>Adjusts the cursor of the owning UIElement according to an MD_Data_Cursor description, unsetting it when the data ID is invalid.
    /// <code>Offset: 0x00465BB0
    /// bool __thiscall MediaMachine::Update_Cursor(MediaMachine*,MD_Data_Cursor*)</code>
    /// </summary>
    /// <param name="desc">Descriptor holding the desired cursor image ID and hotspot coordinates.</param>
    /// <returns>True if the cursor was successfully set or cleared; false if the descriptor or owner is null.</returns>
    public byte Update_Cursor(ACBindings.Internal.MD_Data_Cursor* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, ACBindings.Internal.MD_Data_Cursor*, byte>)0x00465BB0)(ref this, desc);

    /// <summary>Initializes a new MediaMachine object, setting up its UI listener base class, owner pointer, media descriptor array, and current index to default values.
    /// <code>Offset: 0x00465BF0
    /// void __thiscall MediaMachine::MediaMachine(MediaMachine*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, void>)0x00465BF0)(ref this);

    /// <summary>Releases all media descriptors stored in the machine’s array, clears the count, and frees the underlying buffer when the size flag indicates ownership of the allocation.
    /// <code>Offset: 0x00465C20
    /// void __thiscall MediaMachine::Cleanup(MediaMachine*)</code>
    /// </summary>
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, void>)0x00465C20)(ref this);

    /// <summary>Iterates over the media description array, invoking the appropriate update routine for each element until one reports incomplete or the end of the array is reached. During processing the machine temporarily unregisters from global message 3; if an element remains active it stops further advancement and re‑registers.
    /// <code>Offset: 0x00465CD0
    /// void __thiscall MediaMachine::Update(MediaMachine*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, void>)0x00465CD0)(ref this);

    /// <summary>Handles global messages for a MediaMachine instance, invoking internal update logic when specific message IDs are received.
    /// <code>Offset: 0x00465E20
    /// void __thiscall MediaMachine::ListenToGlobalMessage(MediaMachine*,unsigned int,int)</code>
    /// </summary>
    /// <param name="messageID">Identifier of the global message to process.</param>
    /// <param name="data_int">Optional integer payload associated with the message; currently unused by this implementation.</param>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, uint, int, void>)0x00465E20)(ref this, messageID, data_int);

    /// <summary>Destroys a MediaMachine instance, freeing its media descriptor array and unregistering associated UI elements.
    /// <code>Offset: 0x00465E30
    /// void __thiscall MediaMachine::~MediaMachine(MediaMachine*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, void>)0x00465E30)(ref this);

    /// <summary>Resets the media machine by clearing existing media, loading new media descriptors from the supplied array, resetting the current index to zero, and updating internal state.
    /// <code>Offset: 0x00465EC0
    /// void __thiscall MediaMachine::Reset(MediaMachine*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a structure whose first element is an array of MediaDesc pointers and third element specifies how many entries are to be loaded into the machine.</param>
    public void Reset(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaMachine, int*, void>)0x00465EC0)(ref this, a2);
}

