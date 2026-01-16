namespace ACBindings.Internal;


/// <summary>Represents a node within an animation sequence, associating an animation resource with its playback speed and frame boundaries.</summary>
public unsafe struct AnimSequenceNode
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj
    public ACBindings.Internal.DLListData BaseClass_DLListData; // ACBindings.Internal.DLListData

    // Child Types
    public unsafe struct AnimSequenceNode_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimSequenceNode*, void> AnimSequenceNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimSequenceNode*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimSequenceNode*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimSequenceNode*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.CAnimation* anim;
    public float framerate;
    public int low_frame;
    public int high_frame;

    // Generated Constructor
    public AnimSequenceNode() {
        _ConstructorInternal();
    }
    public AnimSequenceNode(ACBindings.Internal.AnimData* data) {
        _ConstructorInternal(data);
    }

    // Methods

    /// <summary>Retrieves the Olthoi chat room identifier from the supplied ChatRoomTracker instance.
    /// <code>Offset: 0x004F24E0
    /// unsigned int __thiscall AnimSequenceNode::get_high_frame(ChatRoomTracker*)</code>
    /// </summary>
    /// <param name="this">The ChatRoomTracker object containing the desired identifier.</param>
    /// <returns>The Olthoi chat room ID stored in the tracker.</returns>
    public uint get_high_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, uint>)0x004F24E0)(ref this);

    /// <summary>Retrieves the animation frame at a specified time index, rounding any fractional part down to the nearest lower integer before lookup.
    /// <code>Offset: 0x005253B0
    /// const AFrame* __thiscall AnimSequenceNode::get_pos_frame(AnimSequenceNode*,long double)</code>
    /// </summary>
    /// <param name="frame_number">The desired frame number as a floating‑point value; the method floors it to an integer index.</param>
    /// <returns>A pointer to the corresponding AFrame instance, or null if no frame exists at that index.</returns>
    public ACBindings.Internal.AFrame* get_pos_frame(double frame_number) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, double, ACBindings.Internal.AFrame*>)0x005253B0)(ref this, frame_number);

    /// <summary>Scales the sequence node's framerate by a multiplier. If the multiplier is negative, swaps the low and high frame boundaries to maintain correct playback direction.
    /// <code>Offset: 0x005267E0
    /// void __thiscall AnimSequenceNode::multiply_framerate(AnimSequenceNode*,float)</code>
    /// </summary>
    /// <param name="multiplier">Scale factor applied to the framerate; negative values cause the node's low and high frames to be swapped before scaling.</param>
    public void multiply_framerate(float multiplier) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, float, void>)0x005267E0)(ref this, multiplier);

    /// <summary>Retrieves the positional frame at the given index from the node's animation if available, otherwise returns null.
    /// <code>Offset: 0x00526810
    /// const AFrame* __thiscall AnimSequenceNode::get_pos_frame(AnimSequenceNode*,int)</code>
    /// </summary>
    /// <param name="fn">The zero‑based frame number to fetch; must be non-negative and less than the total number of frames in the animation.</param>
    /// <returns>A pointer to the requested AFrame, or nullptr when no animation is present or the index is out of bounds.</returns>
    public ACBindings.Internal.AFrame* get_pos_frame(int fn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, int, ACBindings.Internal.AFrame*>)0x00526810)(ref this, fn);

    /// <summary>Retrieves a pointer to the part data for a specified frame from the node’s associated animation.
    /// <code>Offset: 0x00526840
    /// const AnimFrame* __thiscall AnimSequenceNode::get_part_frame(AnimSequenceNode*,int)</code>
    /// </summary>
    /// <param name="fn">The zero‑based index of the desired frame within the animation sequence.</param>
    /// <returns>A pointer to the requested AnimFrame, or nullptr if the index is out of bounds or no animation is attached to the node.</returns>
    public ACBindings.Internal.AnimFrame* get_part_frame(int fn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, int, ACBindings.Internal.AnimFrame*>)0x00526840)(ref this, fn);

    /// <summary>Returns non‑zero when the supplied appraisal profile contains a hook profile; otherwise zero.
    /// <code>Offset: 0x00526870
    /// int __thiscall AnimSequenceNode::has_anim(AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">The appraisal profile to inspect.</param>
    /// <returns>An integer indicating whether the profile has a hook profile (non‑zero) or not (zero).</returns>
    public int has_anim() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, int>)0x00526870)(ref this);

    /// <summary>Retrieves the starting frame index for this animation sequence, accounting for forward or reverse playback based on the framerate.
    /// <code>Offset: 0x00526880
    /// float __thiscall AnimSequenceNode::get_starting_frame(AnimSequenceNode*)</code>
    /// </summary>
    /// <returns>The frame number from which to begin playing; if framerate is negative, returns just before the high frame value to start in reverse.</returns>
    public float get_starting_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, float>)0x00526880)(ref this);

    /// <summary>Retrieves the last frame index of an animation sequence.
    /// <code>Offset: 0x005268B0
    /// float __thiscall AnimSequenceNode::get_ending_frame(AnimSequenceNode*)</code>
    /// </summary>
    /// <returns>The ending frame as a floating‑point value; for forward playback it equals one more than the high frame minus a small epsilon, while for reverse playback it returns the low frame.</returns>
    public float get_ending_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, float>)0x005268B0)(ref this);

    /// <summary>Initializes an animation sequence node with default values, setting list pointers and animation reference to null, establishing the virtual function table, and configuring playback parameters such as 30 fps and uninitialized frame bounds.
    /// <code>Offset: 0x00526930
    /// void __thiscall AnimSequenceNode::AnimSequenceNode(AnimSequenceNode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, void>)0x00526930)(ref this);

    /// <summary>Assigns a new animation to the node using the specified identifier, releasing any previously assigned animation and resetting frame bounds as necessary.
    /// <code>Offset: 0x00526960
    /// int __thiscall AnimSequenceNode::set_animation_id(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">The identifier of the animation to associate; zero removes the current animation.</param>
    /// <returns>The updated lower frame bound after clamping to the animation's frame range.</returns>
    public int set_animation_id(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, int, int>)0x00526960)(ref this, a2);

    /// <summary>Retrieves the next animation sequence node in the list, returning nullptr when this node is the last element.
    /// <code>Offset: 0x005269E0
    /// const AnimSequenceNode* __thiscall AnimSequenceNode::GetNext(AnimSequenceNode*)</code>
    /// </summary>
    /// <returns>A pointer to the following AnimSequenceNode or nullptr if none exists.</returns>
    public ACBindings.Internal.AnimSequenceNode* GetNext() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, ACBindings.Internal.AnimSequenceNode*>)0x005269E0)(ref this);

    /// <summary>Retrieves the preceding animation sequence node in a doubly linked list.
    /// <code>Offset: 0x005269F0
    /// const AnimSequenceNode* __thiscall AnimSequenceNode::GetPrev(AnimSequenceNode*)</code>
    /// </summary>
    /// <returns>The prior node, or null if this is the first element in the list.</returns>
    public ACBindings.Internal.AnimSequenceNode* GetPrev() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, ACBindings.Internal.AnimSequenceNode*>)0x005269F0)(ref this);

    /// <summary>Packs the node’s animation data into the supplied buffer, writing an animation ID (or a sentinel if none), the low frame index, high frame index and framerate in that order. The buffer pointer is advanced past the written values.
    /// <code>Offset: 0x00526AE0
    /// unsigned int __thiscall AnimSequenceNode::Pack(AnimSequenceNode*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; updated to point after the packed data.</param>
    /// <param name="size">Minimum number of bytes available in the buffer (must be at least 16).</param>
    /// <returns>The number of bytes written, always 16.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, void**, uint, uint>)0x00526AE0)(ref this, addr, size);

    /// <summary>Unpacks animation sequence metadata from a binary buffer into the current node.
    /// <code>Offset: 0x00526B40
    /// int __thiscall AnimSequenceNode::UnPack(AnimSequenceNode*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the buffer pointer; advanced past the consumed data upon return.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be at least 16 for successful unpacking.</param>
    /// <returns>1 if unpack succeeded, or 0 when insufficient data is available.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, void**, uint, int>)0x00526B40)(ref this, addr, size);

    /// <summary>Initializes an AnimSequenceNode from the provided AnimData, setting frame range, framerate, and animation identifier.
    /// <code>Offset: 0x00526B90
    /// void __thiscall AnimSequenceNode::AnimSequenceNode(AnimSequenceNode*,const AnimData*)</code>
    /// </summary>
    /// <param name="data">The source data containing animation ID, frame bounds, and playback rate.</param>
    public void _ConstructorInternal(ACBindings.Internal.AnimData* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, ACBindings.Internal.AnimData*, void>)0x00526B90)(ref this, data);
}

