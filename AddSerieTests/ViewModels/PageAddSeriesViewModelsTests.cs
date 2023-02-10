using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddSerie.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSerie.ViewModels.Tests
{
    [TestClass()]
    public class PageAddSeriesViewModelsTests
    {
        [TestMethod()]
        public void PageAddSeriesViewModelsTest()
        {
            PageAddSeriesViewModels addSerieViewModel = new PageAddSeriesViewModels();
            Assert.IsNotNull(addSerieViewModel);
        }

        [TestMethod()]
        public void ActionSetSeriesTest()
        {
            Assert.Fail();
        }
    }
}