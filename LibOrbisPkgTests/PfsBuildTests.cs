using LibOrbisPkg.PFS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibOrbisPkgTests
{
    /// <summary>
    /// Tests functionality of building PFS images
    /// </summary>
    [TestClass]
    public class PfsBuildTests
    {
        [TestMethod]
        public void TestFptHasCollision()
        {
            var root = TestHelper.MakeRoot();
            root.Files.Add(new FSFile(s => s.Position = s.Position, "AO", 0) { Parent = root });
            root.Files.Add(new FSFile(s => s.Position = s.Position, "B0", 0) { Parent = root });
            Assert.IsTrue(FlatPathTable.HasCollision(root.GetAllChildren()));
        }

        [TestMethod]
        public void TestFptNoCollision()
        {
            var root = TestHelper.MakeRoot();
            root.Files.Add(new FSFile(s => s.Position = s.Position, "AO", 0) { Parent = root });
            root.Files.Add(new FSFile(s => s.Position = s.Position, "B1", 0) { Parent = root });
            Assert.IsFalse(FlatPathTable.HasCollision(root.GetAllChildren()));
        }
    }
}
