namespace ExceptionsAssignment
{
    internal class LabRat
    {
        private TestClass _testClass;
        public LabRat(TestClass testClass)
        {
            _testClass = testClass ?? throw new ArgumentNullException("we need to run tests!");
        }
        public void BeginTesting()
        {
            try
            {
                _testClass.ThrowCustomException();
            }
            catch (TestException ex)
            {
                throw new Exception("lab rat throws an exception!", ex);
            }
        }
    }
}
