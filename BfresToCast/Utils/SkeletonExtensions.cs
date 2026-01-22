using BfresLibrary;

namespace BfresToCast.Utils;

public static class SkeletonExtensions
{
    public static ushort GetBoneIndex(this Skeleton skeleton, float bone) => skeleton.GetBoneIndex((int)bone);
    
    public static ushort GetBoneIndex(this Skeleton skeleton, int weightId)
    {
        return skeleton.MatrixToBoneList[weightId];
    }
}