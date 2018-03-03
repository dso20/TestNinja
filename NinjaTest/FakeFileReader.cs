using System.IO;
using TestNinja.Mocking;

namespace NinjaTest
{
    public class FakeFileReader : IFileReader
    {
        public string ReadAllText(string path)
        {
            
            return "test";

        }
    }
}