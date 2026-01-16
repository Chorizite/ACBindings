namespace ACBindings.Internal;


/// <summary>Provides a resizable array holding pointers to constant physics objects, managing allocation in fixed-size blocks.</summary>
/// <remarks>Internally stores the array in <c>data</c>, allocates memory in chunks of size <c>blocksize</c>, keeps track of the next free slot with <c>next_available</c>, and records the current number of stored elements in <c>sizeOf</c>.</remarks>
public unsafe struct DArray___CPhysicsObj_ptr
{
    // Members
    public ACBindings.Internal.CPhysicsObj** data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods
}


/// <summary>DArray&lt;CShadowObj&gt; manages a contiguous block of CShadowObj elements, handling allocation and indexing for efficient shadow object storage.</summary>
public unsafe struct DArray___CShadowObj
{
    // Members
    public ACBindings.Internal.CShadowObj* data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods

    /// <summary>Expands the internal storage of the CShadowObj array to accommodate at least n elements, reallocating memory and preserving existing objects. If n is less than or equal to the current capacity, the array shrinks instead.
    /// <code>Offset: 0x00514D50
    /// void __thiscall DArray&lt;CShadowObj&gt;::grow(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the DArray&lt;CShadowObj&gt; instance being resized.</param>
    /// <param name="n">Desired capacity after growth; if smaller than or equal to the current number of elements, the array shrinks.</param>
    // void __thiscall DArray<CShadowObj>::grow(_DWORD*,unsigned int) (template type method)

    /// <summary>Resizes the internal array of shadow objects to the specified length, allocating a smaller buffer when possible and freeing surplus storage.
    /// <code>Offset: 0x00514E90
    /// void __thiscall DArray&lt;CShadowObj&gt;::shrink(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="n">The desired number of elements in the array after resizing.</param>
    // void __thiscall DArray<CShadowObj>::shrink(_DWORD*,unsigned int) (template type method)
}


/// <summary>Dynamic array that stores pointers to CShadowPart objects, managing allocation and tracking the number of elements. Used within rendering engine to manage collections of shadow components efficiently.</summary>
public unsafe struct DArray___CShadowPart_ptr
{
    // Members
    public ACBindings.Internal.CShadowPart** data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods
}


/// <summary>Manages a dynamically resizable collection of constant light object pointers, handling allocation, growth, and indexing within rendering systems.</summary>
public unsafe struct DArray___LIGHTOBJ_ptr
{
    // Members
    public ACBindings.Internal.LIGHTOBJ** data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods
}


/// <summary>Dynamic container for CShadowObj pointers, allocating storage in fixed-size blocks and tracking both available capacity and current element count.</summary>
public unsafe struct DArray___CShadowObj_ptr
{
    // Members
    public ACBindings.Internal.CShadowObj** data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods
}


/// <summary>Manages a resizable collection of ClipPlane objects, allocating memory in contiguous blocks for performance.</summary>
public unsafe struct DArray___ClipPlane
{
    // Members
    public ACBindings.Internal.ClipPlane* data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods

    /// <summary>Increases the internal storage of the array to hold at least the specified number of elements, allocating a larger block when necessary and copying existing items.
    /// <code>Offset: 0x0052DAE0
    /// void __thiscall DArray&lt;ClipPlane&gt;::grow(int*,unsigned int)</code>
    /// </summary>
    /// <param name="n">The desired minimum capacity for the array.</param>
    // void __thiscall DArray<ClipPlane>::grow(int*,unsigned int) (template type method)

    /// <summary>Reduces the dynamic array to the specified size, reallocating storage and destroying surplus elements if necessary.
    /// <code>Offset: 0x0052DBE0
    /// void __thiscall DArray&lt;ClipPlane&gt;::shrink(int*,unsigned int)</code>
    /// </summary>
    /// <param name="n">The desired number of elements in the array after shrinking.</param>
    // void __thiscall DArray<ClipPlane>::shrink(int*,unsigned int) (template type method)
}


/// <summary>Dynamic array container for CELLINFO objects that manages memory in contiguous blocks, providing efficient access and automatic growth as elements are appended.</summary>
public unsafe struct DArray___CELLINFO
{
    // Members
    public ACBindings.Internal.CELLINFO* data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods

    /// <summary>Resizes the internal CELLINFO array to hold at least n elements, allocating a larger block and copying existing items when needed.
    /// <code>Offset: 0x006B5DF0
    /// void __thiscall DArray&lt;CELLINFO&gt;::grow(int*,unsigned int)</code>
    /// </summary>
    /// <param name="n">The target minimum size of the array.</param>
    // void __thiscall DArray<CELLINFO>::grow(int*,unsigned int) (template type method)

    /// <summary>Reduces the dynamic array to the specified element count, deallocating unused capacity and updating internal state.
    /// <code>Offset: 0x006B5E80
    /// void __thiscall DArray&lt;CELLINFO&gt;::shrink(int*,unsigned int)</code>
    /// </summary>
    /// <param name="n">The desired number of elements after shrinking. If greater than the current size, the array is grown instead.</param>
    // void __thiscall DArray<CELLINFO>::shrink(int*,unsigned int) (template type method)
}


/// <summary>Holds a resizable collection of portal_view_type pointers, managing memory in fixed-size blocks and tracking current element count.</summary>
public unsafe struct DArray___portal_view_type_ptr
{
    // Members
    public ACBindings.Internal.portal_view_type** data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods
}


/// <summary>Dynamic array container for portal_info objects, allocating storage in contiguous blocks and maintaining indices for efficient addition and access. It tracks the size of each block and the next available position to facilitate fast insertion.</summary>
public unsafe struct DArray___portal_info
{
    // Members
    public ACBindings.Internal.portal_info* data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods

    /// <summary>Ensures the array contains space for at least a2 portal_info elements, reallocating storage if the requested size exceeds current capacity; otherwise reduces capacity via shrink.
    /// <code>Offset: 0x005A55B0
    /// void __thiscall DArray&lt;portal_info&gt;::grow(int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The desired number of portal_info elements the array should accommodate.</param>
    // void __thiscall DArray<portal_info>::grow(int,unsigned int) (template type method)

    /// <summary>Reduces the array’s capacity to the specified number of elements, reallocating storage when shrinking; if the requested size exceeds current capacity, the array expands instead.
    /// <code>Offset: 0x005A5740
    /// void __thiscall DArray&lt;portal_info&gt;::shrink(int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Desired number of elements after adjustment.</param>
    // void __thiscall DArray<portal_info>::shrink(int,unsigned int) (template type method)
}


/// <summary>DArray&lt;view_poly&gt; provides a dynamic array container for view_poly objects, managing block‑based memory allocation and maintaining size and the next available slot for efficient access.</summary>
public unsafe struct DArray___view_poly
{
    // Members
    public ACBindings.Internal.view_poly* data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods

    /// <summary>Resizes the array to hold at least the specified number of elements, allocating new storage and copying existing items when the requested capacity exceeds the current size; otherwise reduces the allocated space.
    /// <code>Offset: 0x0054D5C0
    /// void __thiscall DArray&lt;view_poly&gt;::grow(int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The desired capacity in terms of element count.</param>
    // void __thiscall DArray<view_poly>::grow(int,unsigned int) (template type method)

    /// <summary>Reduces the array capacity to the specified number of elements, reallocating storage and preserving existing data up to the new size. If the requested size exceeds the current block capacity, delegates to grow().
    /// <code>Offset: 0x0054D640
    /// unsigned int __thiscall DArray&lt;view_poly&gt;::shrink(int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The desired number of elements after shrinking.</param>
    /// <returns>The element count that was available before the shrink operation.</returns>
    // unsigned int __thiscall DArray<view_poly>::shrink(int,unsigned int) (template type method)
}


/// <summary>Dynamic array container for view_vertex objects, managing contiguous memory blocks and tracking allocation state.</summary>
/// <remarks>Fields include a pointer to the underlying data array, block size for allocations, index of next available slot, and total element count.</remarks>
public unsafe struct DArray___view_vertex
{
    // Members
    public ACBindings.Internal.view_vertex* data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods

    /// <summary>Releases the array's allocated memory and performs cleanup on each element.
    /// <code>Offset: 0x0052DF80
    /// void __thiscall DArray&lt;view_vertex&gt;::~DArray&lt;view_vertex&gt;(int*)</code>
    /// </summary>
    // void __thiscall DArray<view_vertex>::~DArray<view_vertex>(int*) (template type method)

    /// <summary>Resizes the internal array of view_vertex objects so that it can hold at least n elements, allocating new storage and copying existing items when an increase is required; if the requested size is smaller, delegates to shrink.
    /// <code>Offset: 0x0054E930
    /// void __thiscall DArray&lt;view_vertex&gt;::grow(int*,unsigned int)</code>
    /// </summary>
    /// <param name="n">The desired number of elements for the array.</param>
    // void __thiscall DArray<view_vertex>::grow(int*,unsigned int) (template type method)

    /// <summary>Resizes the dynamic array of view_vertex objects to the specified capacity, freeing any unused space and truncating excess elements when shrinking.
    /// <code>Offset: 0x0054EA40
    /// void __thiscall DArray&lt;view_vertex&gt;::shrink(int*,unsigned int)</code>
    /// </summary>
    /// <param name="n">The desired number of elements after resizing; if zero all elements are destroyed and storage is released.</param>
    // void __thiscall DArray<view_vertex>::shrink(int*,unsigned int) (template type method)
}


/// <summary>Dynamic array container for unsigned long values, allocating memory in blocks and tracking element count and next available slot.</summary>
public unsafe struct DArray__uint
{
    // Members
    public uint* data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods
}

public unsafe struct DArray___ObjectInfo
{
    // Members
    public ACBindings.Internal.ObjectInfo* data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods

    /// <summary>Resizes the array’s internal storage to support at least the given number of elements, allocating new space when expanding and releasing unused space when contracting.
    /// <code>Offset: 0x0051ABB0
    /// void __thiscall DArray&lt;ObjectInfo&gt;::grow(int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The target capacity (in elements) that the array should accommodate after the operation.</param>
    // void __thiscall DArray<ObjectInfo>::grow(int,unsigned int) (template type method)

    /// <summary>Reduces the array to the specified size, reallocating storage as needed. If the requested size exceeds current capacity, grows instead.
    /// <code>Offset: 0x0051AC20
    /// void __thiscall DArray&lt;ObjectInfo&gt;::shrink(int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Target number of elements; if zero frees all memory and sets size to 0.</param>
    // void __thiscall DArray<ObjectInfo>::shrink(int,unsigned int) (template type method)
}

public unsafe struct DArray___AmbientSound_ptr
{
    // Members
    public ACBindings.Internal.AmbientSound** data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods
}

public unsafe struct DArray___CEnvCell_ptr
{
    // Members
    public ACBindings.Internal.CEnvCell** data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods
}

public unsafe struct DArray___CellListType_ptr
{
    // Members
    public ACBindings.Internal.CellListType** data;
    public uint blocksize;
    public uint next_available;
    public uint sizeOf;

    // Methods
}

