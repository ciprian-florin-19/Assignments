namespace ExceptionsAssignment
{
    internal class TestClass
    {
        private string _testField;
        public TestClass(string testField)
        {
            _testField = testField ?? throw new ArgumentNullException("test field cannot be null!");
        }
        public void ThrowCustomException()
        {
            throw new TestException("this is a test!");
        }
    }
}
