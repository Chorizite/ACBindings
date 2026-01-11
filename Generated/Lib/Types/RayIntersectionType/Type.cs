namespace ACBindings.Internal.RayIntersectionType;

// RayIntersectionType::Type
public enum Type : byte
{
    UsePhysicsRep = 0x0,
    UseExactDrawingRep = 0x1,
    EnvironmentOnly = 0x2,
    PortalsOnly = 0x3,
    UnconnectedPortalsOnly = 0x4
}

