using CashBoardAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBoardTests
{
    public class CashBoardTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            HomePage.GoTo();
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}
