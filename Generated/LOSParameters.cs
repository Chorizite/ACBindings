namespace ACBindings.Internal;


/// <summary>Encapsulates parameters for a line‑of‑sight (LOS) calculation in the physics engine, tracking traversal state, intersection results, and related spatial data.</summary>
public unsafe struct LOSParameters
{
    // Members
    public ACBindings.Internal.EtherealWeenieType m_weenie_LOS;
    public ACBindings.Internal.EtherealPhysicsType m_physics_LOS;
    public ACBindings.Internal.RayIntersectionType.Type m_intersect_type;
    public int m_bTraversePortals;
    public int m_bCheckedOutside;
    public uint m_initial_cell_id;
    public ACBindings.Internal.Ray m_initial_ray;
    public ACBindings.Internal.Ray m_current_ray;
    public uint m_current_cell_id;
    public float m_delta;
    public uint m_trace_result;
    public uint m_final_cell_id;
    public ACBindings.Internal.Ray m_final_ray;
    public ACBindings.Internal.Vector3 m_impact_normal;
    public uint m_portal_index;
    public ACBindings.Internal.LandDefs.Direction m_dir;
    public uint m_next_block_id;

    // Methods
}

