using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.DataStore;
using BlabberApp.Domain.Entities;

namespace BlabberApp.DataStoreTest
{
    [TestClass]
    public class InMemoryTest
    {
        private InMemory<Blab> _harness;
        public InMemoryTest()
        {
            _harness = new InMemory<Blab>();
        }
        
        [TestMethod]
        public void Add_Blab_GetByUserId_Success()
        {
            string Email = "foo@example.com";
            Blab Expected = new Blab();
            Expected.Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            Expected.UserID = Email;
            _harness.Add(Expected);
            Blab Actual = (Blab)_harness.GetByUserId(Email);
            Assert.AreEqual(Expected, Actual);

        }
    }
}
