using System.Numerics;
using Syroot.Maths;
using Vector3 = System.Numerics.Vector3;

namespace BFResToCast;

public static class VectorExtensions
{
    public static Vector3 GetAsVector3(this Vector3F vector3F)
    {
        return new Vector3(vector3F.X, vector3F.Y, vector3F.Z);
    }

    public static Vector3 GetAsVector3(this Vector4F vector4F)
    {
        return new Vector3(vector4F.X, vector4F.Y, vector4F.Z);
    }

    public static System.Numerics.Vector4 GetAsVector4(this Vector4F vector4F)
    {
        return new System.Numerics.Vector4(vector4F.X, vector4F.Y, vector4F.Z, vector4F.W);
    }
    
    public static Vector3 RotateThenTransform(this Vector3 vector, Quaternion rotation, Matrix4x4 translation, bool normal = false)
    {
        if (normal)
            return Vector3.TransformNormal(Vector3.TransformNormal(vector, Matrix4x4.CreateFromQuaternion(rotation)), translation);
        else
            return Vector3.Transform(Vector3.Transform(vector, rotation), translation);
    }
    
    public static System.Numerics.Vector4 RotateThenTransform(this System.Numerics.Vector4 vector, Quaternion rotation, Matrix4x4 translation)
    {
        return System.Numerics.Vector4.Transform(System.Numerics.Vector4.Transform(vector, rotation), translation);
    }
}