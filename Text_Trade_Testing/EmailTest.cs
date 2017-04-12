using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Text_Trade_Testing
{

    [TestClass]
    public class EmailTest
    {

        [TestMethod]
        public void SendMail_From_Test_To_Eric_Is_True()
        {

            Email myEmail = new Email("testingemailplzignore@gmail.com",false);

            myEmail.Password = "Abcdef12";

            myEmail.SendMessage("ericoliver52@gmail.com", "test", "Please work");

        }

    }

}
