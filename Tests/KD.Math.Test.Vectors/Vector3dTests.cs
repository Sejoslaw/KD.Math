using KD.Math.Vectors;
using Xunit;

namespace KD.Math.Test.Vectors
{
    public class Vector3dTests
    {
        [Fact]
        public void Test_Vector3d_BasicCreate()
        {
            Vector3d vec1 = this.GetVector();
            Assert.NotNull(vec1);
        }

        [Fact]
        public void Test_Vector3d_Add()
        {
            Vector3d vec1 = this.GetVector();
            Vector3d vec2 = this.GetVector();
            IVector<double> vec3 = vec1.Add(vec2);
            Assert.NotNull(vec3);
        }

        [Fact]
        public void Test_Vector3d_Normalize()
        {
            Vector3d vec1 = this.GetVector();
            IVector<double> vec2 = vec1.Normalize();
            Assert.NotNull(vec2);
        }

        [Fact]
        public void Test_Vector3d_CrossProduct()
        {
            Vector3d vec1 = this.GetVector();
            Vector3d vec2 = this.GetVector();
            IVector<double> vec3 = vec1.CrossProduct(vec2);
            Assert.NotNull(vec3);
        }

        public Vector3d GetVector()
        {
            Vector3d vec = new Vector3d();
            vec.Initialize(new double[] { 2, 3, 4 });
            return vec;
        }
    }
}
