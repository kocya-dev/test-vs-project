using test_vs_project;

namespace sample_unit_test
{
    public class SampleTest
    {
        [Fact]
        public void Add()
        {
            var sample = new Sample();
            Assert.Equal(3, sample.Add(1, 2));
        }
        [Fact]
        public void Sub()
        {
            var sample = new Sample();
            Assert.Equal(8, sample.Sub(10, 2));
        }
    }
}