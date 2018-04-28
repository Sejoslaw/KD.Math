using KD.Math.Vectors;
using Xunit;

namespace KD.Math.Test.Vectors
{
    public class Vector3dTests
    {
        [Fact]
        public void Test_Vector3d_BasicCreate()
        {
            Vector3d vec = new Vector3d();
            vec.Initialize(new double[] { 2, 3, 4 });
        }
    }
}
