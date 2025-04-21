using BfresLibrary;

namespace BFResToCast;

public static class SkeletonExtensions
{
    public static ushort GetBoneIndex(this Skeleton skeleton, float bone) => GetBoneIndex(skeleton, (int)bone);
    
    public static ushort GetBoneIndex(this Skeleton skeleton, int weightId)
    {
        return skeleton.MatrixToBoneList[weightId];
    }
}