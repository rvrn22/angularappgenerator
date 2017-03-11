using Generator;
using NUnit.Framework;

namespace Tests.Unit
{
    [TestFixture]
    public class ComponentGeneratorTest
    {
        [Test]
        public void ShouldGenerateComponent()
        {
            var generator = new ComponentGenerator();
            generator.Generate();
        }
    }
}
