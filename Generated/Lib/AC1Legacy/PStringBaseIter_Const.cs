namespace ACBindings.Internal.AC1Legacy;


/// <summary>AC1Legacy::PStringBaseIter_Const&lt;char&gt; is a read‑only iterator over PString objects, storing a pointer to the string and delegating traversal logic to PStringBaseIter_Common&lt;char&gt;. It allows sequential access to characters without modifying the underlying string.</summary>
public unsafe struct PStringBaseIter_Const__sbyte
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.PStringBaseIter_Common__sbyte BaseClass_AC1Legacy_PStringBaseIter_Common; // ACBindings.Internal.AC1Legacy.PStringBaseIter_Common__sbyte

    // Child Types

    /// <summary>Virtual table for a read‑only string iterator, exposing operations to retrieve length, split the string, and map indices to constant pointers or characters.</summary>
    public unsafe struct PStringBaseIter_Const_vtbl__sbyte
    {
        // Members
        public System.IntPtr GetStrLen;
        public fixed byte gap4[4];
        public System.IntPtr Split;
        public System.IntPtr IndexToConstPointer;
        public System.IntPtr IndexToChar;

        // Methods
    }

    // Members
    public System.IntPtr pstring_ptr;

    // Methods
}

