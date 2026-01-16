namespace ACBindings.Internal;


/// <summary>Encapsulates positional data for an entity, providing its base attributes, cell identifier, and spatial frame within the world.</summary>
public unsafe struct Position
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Position_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Position*, void> Position_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Position*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Position*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Position*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint objcell_id;
    public ACBindings.Internal.Frame frame;

    // Generated Constructor
    public Position() {
        _ConstructorInternal();
    }
    public Position(uint cellID, ACBindings.Internal.Frame* newFrame) {
        _ConstructorInternal(cellID, newFrame);
    }
    public Position(ACBindings.Internal.Position* that) {
        _ConstructorInternal(that);
    }

    // Methods

    /// <summary>Initializes a Position instance with default state: sets object cell ID to zero, establishes an identity orientation quaternion, positions the origin at (0, 0, 0), and caches the frame for later use.
    /// <code>Offset: 0x00424D10
    /// void __thiscall Position::Position(Position*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, void>)0x00424D10)(ref this);

    /// <summary>Constructs a Position object with specified cell ID and frame data.
    /// <code>Offset: 0x004527C0
    /// void __thiscall Position::Position(Position*,unsigned int,const Frame*)</code>
    /// </summary>
    /// <param name="cellID">Identifier of the cell where the position belongs.</param>
    /// <param name="newFrame">Initial frame containing orientation and origin for the position.</param>
    public void _ConstructorInternal(uint cellID, ACBindings.Internal.Frame* newFrame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, uint, ACBindings.Internal.Frame*, void>)0x004527C0)(ref this, cellID, newFrame);

    /// <summary>Computes the identifier of the cell that lies outside the current area for this position, using the object's existing cell ID and its world origin to determine an adjacent exterior cell.
    /// <code>Offset: 0x004527F0
    /// unsigned int __thiscall Position::get_outside_cell_id(Position*)</code>
    /// </summary>
    /// <returns>The unsigned integer ID of the outside cell, or zero when no valid exterior cell can be determined.</returns>
    public uint get_outside_cell_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, uint>)0x004527F0)(ref this);

    /// <summary>Transforms a vector from the coordinate system of source Position into the local space of this Position, applying block offsets and frame transformations.
    /// <code>Offset: 0x00452830
    /// AC1Legacy::Vector3* __thiscall Position::localtolocal(Position*,AC1Legacy::Vector3*,const Position*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">Pointer to a Vector3 that receives the transformed coordinates; also returned by the function.</param>
    /// <param name="p">Source Position whose local frame defines the input vector's coordinate system.</param>
    /// <param name="v">Vector expressed in the source Position's local space to be converted.</param>
    /// <returns>Reference to the result Vector3 containing the coordinates in this Position's local space.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* localtolocal(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.Position* p, ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00452830)(ref this, result, p, v);

    /// <summary>Converts a local position into global coordinates using another Position's frame of reference.
    /// <code>Offset: 0x00452900
    /// AC1Legacy::Vector3* __thiscall Position::localtoglobal(Position*,AC1Legacy::Vector3*,const Position*)</code>
    /// </summary>
    /// <param name="result">Vector to receive the calculated global coordinates.</param>
    /// <param name="p">Reference Position whose origin defines the global coordinate system.</param>
    /// <returns>Pointer to the output vector.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* localtoglobal(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00452900)(ref this, result, p);

    /// <summary>Creates a new Position instance by copying the cell identifier and frame data from another Position.
    /// <code>Offset: 0x004529E0
    /// void __thiscall Position::Position(Position*,const Position*)</code>
    /// </summary>
    /// <param name="that">The source position to copy.</param>
    public void _ConstructorInternal(ACBindings.Internal.Position* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.Position*, void>)0x004529E0)(ref this, that);

    /// <summary>Converts a local coordinate vector into world coordinates by applying the specified position's frame transform and cell offset, storing the result in the supplied Vector3.
    /// <code>Offset: 0x004562A0
    /// AC1Legacy::Vector3* __thiscall Position::localtoglobal(Position*,AC1Legacy::Vector3*,const Position*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">Pointer to a Vector3 that will receive the global coordinates.</param>
    /// <param name="p">Position providing the frame matrix and origin used for transformation.</param>
    /// <param name="v">Local vector to convert into global space.</param>
    /// <returns>Pointer to the result Vector3 containing the transformed coordinates.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* localtoglobal(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.Position* p, ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x004562A0)(ref this, result, p, v);

    /// <summary>Converts a vector from the object's local coordinate space into global coordinates using its frame matrix.
    /// <code>Offset: 0x00456340
    /// AC1Legacy::Vector3* __thiscall Position::localtoglobalvec(Position*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">Receives the transformed vector.</param>
    /// <param name="v">Vector expressed in the object's local coordinate system.</param>
    /// <returns>Pointer to the result vector after transformation.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* localtoglobalvec(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00456340)(ref this, result, v);

    /// <summary>Adjusts the Position so its coordinates fall outside the current land boundaries by updating the cell ID and origin via LandDefs::adjust_to_outside.
    /// <code>Offset: 0x005054A0
    /// void __thiscall Position::adjust_to_outside(Position*)</code>
    /// </summary>
    public void adjust_to_outside() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, void>)0x005054A0)(ref this);

    /// <summary>Calculates the displacement vector from this position to another, incorporating cell block offsets and frame origins.
    /// <code>Offset: 0x0050AA30
    /// AC1Legacy::Vector3* __thiscall Position::get_offset(Position*,AC1Legacy::Vector3*,const Position*)</code>
    /// </summary>
    /// <param name="this">The source Position instance.</param>
    /// <param name="result">Vector3 where the computed offset will be stored; also returned by the function.</param>
    /// <param name="p">The target Position whose relative offset is determined.</param>
    /// <returns>Pointer to the result vector containing the calculated displacement.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* get_offset(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*>)0x0050AA30)(ref this, result, p);

    /// <summary>Transforms a vector from global coordinates to the local coordinate system defined by this Position object’s transformation matrix.
    /// <code>Offset: 0x0050CEF0
    /// AC1Legacy::Vector3* __thiscall Position::globaltolocalvec(Position*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">Pointer to a Vector3 that will receive the transformed local-space vector.</param>
    /// <param name="v">Vector expressed in global coordinates to be converted into local space.</param>
    /// <returns>Pointer to the result vector after conversion, enabling method chaining.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* globaltolocalvec(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x0050CEF0)(ref this, result, v);

    /// <summary>Calculates a world‑space offset from the current Position to another Position by transforming a local vector with the target's frame matrix, applying block offsets, and stores the result in the supplied vector.
    /// <code>Offset: 0x0050E3F0
    /// AC1Legacy::Vector3* __thiscall Position::get_offset(Position*,AC1Legacy::Vector3*,const Position*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="this">The current Position instance whose origin is subtracted from the transformed point.</param>
    /// <param name="result">Output vector that receives the computed offset.</param>
    /// <param name="p">Reference Position used for the transformation matrix and block offset lookup.</param>
    /// <param name="v">Local vector to be transformed relative to Position p.</param>
    /// <returns>Pointer to the result vector containing the calculated offset.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* get_offset(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.Position* p, ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x0050E3F0)(ref this, result, p, v);

    /// <summary>Calculates the relative transform between two Position objects and places the resulting Frame into the supplied result buffer.
    /// <code>Offset: 0x005566B0
    /// Frame* __thiscall Position::subtract2(Position*,Frame*,const Position*)</code>
    /// </summary>
    /// <param name="result">The Frame that will receive the computed relative transformation.</param>
    /// <param name="p2">The Position to subtract from the current instance.</param>
    /// <returns>A pointer to the Frame containing the calculated relative transform.</returns>
    public ACBindings.Internal.Frame* subtract2(ACBindings.Internal.Frame* result, ACBindings.Internal.Position* p2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.Frame*, ACBindings.Internal.Position*, ACBindings.Internal.Frame*>)0x005566B0)(ref this, result, p2);

    /// <summary>Formats a Position instance into a string containing its cell ID, origin coordinates and quaternion components.
    /// <code>Offset: 0x005AA3E0
    /// unsigned int __thiscall Position::ToString(Position*,char*,const unsigned int)</code>
    /// </summary>
    /// <param name="buf">Destination buffer for the formatted text; may be nullptr to query required length.</param>
    /// <param name="size">Maximum number of bytes that can be written to buf.</param>
    /// <returns>Number of characters written to buf (excluding the terminating null), or zero if buf is null.</returns>
    public uint ToString(sbyte* buf, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, sbyte*, uint, uint>)0x005AA3E0)(ref this, buf, size);

    /// <summary>Parses a formatted string to update the Position object's cell ID and frame data.
    /// <code>Offset: 0x005AA460
    /// int __thiscall Position::FromString(Position*,const char*)</code>
    /// </summary>
    /// <param name="buf">Null-terminated text representing the position in either "0x%08X [%f %f %f] %f" or "0x%08X [%f %f %f] %f %f %f %f" format.</param>
    /// <returns>Non-zero when parsing succeeds; zero if the string is invalid or null.</returns>
    public int FromString(sbyte* buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, sbyte*, int>)0x005AA460)(ref this, buf);

    /// <summary>Calculates the total number of bytes required to serialize a Position instance.
    /// <code>Offset: 0x005AA510
    /// unsigned int __thiscall Position::pack_size(Position*)</code>
    /// </summary>
    /// <returns>The size in bytes needed for packing, including frame data and any additional overhead.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, uint>)0x005AA510)(ref this);

    /// <summary>Determines whether a Position instance refers to a cell within bounds and holds a valid frame.
    /// <code>Offset: 0x005AA530
    /// int __thiscall Position::IsValid(Position*)</code>
    /// </summary>
    /// <returns>Non‑zero if both the cell ID is inbound and the associated Frame is valid; zero otherwise.</returns>
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, int>)0x005AA530)(ref this);

    /// <summary>Calculates the Euclidean distance between two positions.
    /// <code>Offset: 0x005AA560
    /// float __thiscall Position::distance(Position*,const Position*)</code>
    /// </summary>
    /// <param name="p">The position to measure against.</param>
    /// <returns>The straight‑line distance as a floating‑point value.</returns>
    public float distance(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.Position*, float>)0x005AA560)(ref this, p);

    /// <summary>Returns the horizontal (XY) Euclidean distance between the current position and another.
    /// <code>Offset: 0x005AA5A0
    /// float __thiscall Position::xy_distance(Position*,const Position*)</code>
    /// </summary>
    /// <param name="p">The target position whose XY coordinates are compared to the current object.</param>
    /// <returns>The XY distance as a float.</returns>
    public float xy_distance(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.Position*, float>)0x005AA5A0)(ref this, p);

    /// <summary>Computes the compass heading from this position toward another position as a degree value between 0 and 360.
    /// <code>Offset: 0x005AA5D0
    /// float __thiscall Position::heading(Position*,const Position*)</code>
    /// </summary>
    /// <param name="p">The target Position used to determine the direction vector.</param>
    /// <returns>The heading in degrees, measured clockwise from north; returns 0 if the two positions are effectively identical or too close together.</returns>
    public float heading(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.Position*, float>)0x005AA5D0)(ref this, p);

    /// <summary>Determines the relative location of a target position with respect to this object, dividing space into horizontal quadrants based on x/y signs and vertical zones using one‑third height thresholds.
    /// <code>Offset: 0x005AA630
    /// unsigned int __thiscall Position::determine_quadrant(Position*,float,const Position*)</code>
    /// </summary>
    /// <param name="height">Reference height used to split the vertical axis into bottom, middle, and top thirds.</param>
    /// <param name="p">Target Position whose relative location is evaluated against this object.</param>
    /// <returns>An unsigned integer bitmask encoding horizontal quadrant (x/y sign) and vertical zone (bottom/middle/top).</returns>
    public uint determine_quadrant(float height, ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, float, ACBindings.Internal.Position*, uint>)0x005AA630)(ref this, height, p);

    /// <summary>Serializes a Position object into a contiguous byte stream, writing its cell identifier followed by packed frame data. The method returns the total number of bytes required for serialization.
    /// <code>Offset: 0x005AA6F0
    /// unsigned int __thiscall Position::Pack(Position*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer location where serialized data should be written; updated to point past the last byte written.</param>
    /// <param name="size">The number of bytes available in the buffer pointed to by addr.</param>
    /// <returns>The total length, in bytes, required to serialize this Position object.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, void**, uint, uint>)0x005AA6F0)(ref this, addr, size);

    /// <summary>Deserializes a Position object from a packed byte stream, extracting the objcell_id and delegating frame deserialization.
    /// <code>Offset: 0x005AA740
    /// int __thiscall Position::UnPack(Position*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer containing packed data; updated to point after the consumed bytes.</param>
    /// <param name="size">Number of bytes remaining in the buffer; validated against the required unpack size.</param>
    /// <returns>Non‑zero if unpacking succeeds; zero if there is insufficient data or an error occurs during frame deserialization.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, void**, uint, int>)0x005AA740)(ref this, addr, size);

    /// <summary>Serializes or deserializes a Position object, writing or reading its cell identifier and frame data based on the archive’s mode.
    /// <code>Offset: 0x005AA7A0
    /// void __thiscall Position::Serialize(Position*,Archive*)</code>
    /// </summary>
    /// <param name="this">The Position instance to serialize or update from the archive.</param>
    /// <param name="io_archive">Archive used for input or output of the object's state.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, ACBindings.Internal.Archive*, void>)0x005AA7A0)(ref this, io_archive);

    /// <summary>Packs the object's cell ID and origin coordinates into a buffer at *addr if sufficient space exists.
    /// <code>Offset: 0x005AA7F0
    /// unsigned int __thiscall Position::PackOrigin(Position*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write address; will be advanced past the packed data.</param>
    /// <param name="size">Number of bytes available in the buffer.</param>
    /// <returns>Always 16, the number of bytes written when size is at least 16.</returns>
    public uint PackOrigin(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, void**, uint, uint>)0x005AA7F0)(ref this, addr, size);

    /// <summary>Deserializes a Position object from the provided buffer. Expects at least 16 bytes and advances the address pointer past the consumed data.
    /// <code>Offset: 0x005AA840
    /// int __thiscall Position::UnPackOrigin(Position*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the buffer; updated after reading each field.</param>
    /// <param name="size">Number of remaining bytes available for unpacking.</param>
    /// <returns>1 if unpacking succeeds, 0 when size is less than the required minimum (16 bytes).</returns>
    public int UnPackOrigin(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, void**, uint, int>)0x005AA840)(ref this, addr, size);

    /// <summary>Calculates the signed minimum distance between two vertical cylinders defined by their radii, heights, and positions. Positive values indicate separation, while negative values denote overlap.
    /// <code>Offset: 0x005AA8A0
    /// float __cdecl Position::cylinder_distance(float,float,const Position*,float,float,const Position*)</code>
    /// </summary>
    /// <param name="r1">Radius of the first cylinder.</param>
    /// <param name="h1">Height of the first cylinder.</param>
    /// <param name="p1">Position (origin point) of the first cylinder.</param>
    /// <param name="r2">Radius of the second cylinder.</param>
    /// <param name="h2">Height of the second cylinder.</param>
    /// <param name="p2">Position (origin point) of the second cylinder.</param>
    /// <returns>Signed distance between the surfaces of the two cylinders; zero when touching, negative if they intersect, positive when separated.</returns>
    public static float cylinder_distance(float r1, float h1, ACBindings.Internal.Position* p1, float r2, float h2, ACBindings.Internal.Position* p2) => ((delegate* unmanaged[Cdecl]<float, float, ACBindings.Internal.Position*, float, float, ACBindings.Internal.Position*, float>)0x005AA8A0)(r1, h1, p1, r2, h2, p2);

    /// <summary>Computes the clearance between two cylindrical objects by measuring the Euclidean distance between their centers and subtracting both radii.
    /// <code>Offset: 0x005AA960
    /// float __cdecl Position::cylinder_distance_no_z(float,const Position*,float,const Position*)</code>
    /// </summary>
    /// <param name="r1">Radius of the first cylinder.</param>
    /// <param name="p1">Position of the first cylinder.</param>
    /// <param name="r2">Radius of the second cylinder.</param>
    /// <param name="p2">Position of the second cylinder.</param>
    /// <returns>The distance between the surfaces of the two cylinders; a negative value indicates overlap.</returns>
    public static float cylinder_distance_no_z(float r1, ACBindings.Internal.Position* p1, float r2, ACBindings.Internal.Position* p2) => ((delegate* unmanaged[Cdecl]<float, ACBindings.Internal.Position*, float, ACBindings.Internal.Position*, float>)0x005AA960)(r1, p1, r2, p2);

    /// <summary>Formats the position's cell ID, 3D coordinates, and heading into a human‑readable string and stores it in the supplied output pointer.
    /// <code>Offset: 0x005AA9B0
    /// int* __thiscall Position::ToDisplayString(int,int*)</code>
    /// </summary>
    /// <param name="a2">Receives the reference to the newly created PStringBase containing the formatted display text.</param>
    /// <returns>The same pointer passed as a2, pointing at the formatted string object.</returns>
    public int* ToDisplayString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Position, int*, int*>)0x005AA9B0)(ref this, a2);
}

