using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NSubstitute;

namespace sd_final_tests
{
    [TestFixture]
    class Test_Inc_Controller
    {
        public sd_final.Inc_Controller controller{get;set;}
        public sd_final.IViewInc _view ;
        [SetUp]
        public void Init()
        {

            _view =Substitute.For<sd_final.IViewInc>();
            controller = new sd_final.Inc_Controller(_view);
        }

        [Test]
        public void Test_Sd_cat_list()
        {
            var res = controller.Sd_cat_list();
            CollectionAssert.AllItemsAreUnique(res);
            foreach (var item in res)
            {
                Assert.That(item, Has.Property("id"));
                Assert.That(item, Has.Property("name"));
            }
        }

        [Test]
        public void Test_Sd_reg_incident_user_list()
        {
            var res = controller.Sd_reg_incident_user_list();
            CollectionAssert.AllItemsAreUnique(res);
            foreach (var item in res)
            {
                Assert.That(item, Has.Property("id"));
                Assert.That(item, Has.Property("fio"));
                Assert.That(item.priv, Is.EqualTo(2));
            }
        }

        [Test]
        public void Test_Sd_Class_incident_user_list()
        {
            var res = controller.Sd_Class_incident_user_list();
            CollectionAssert.AllItemsAreUnique(res);
            foreach (var item in res)
            {
                Assert.That(item, Has.Property("id"));
                Assert.That(item, Has.Property("fio"));
                Assert.That(item.priv, Is.EqualTo(3));
            }
        }

        [Test]
        public void Test_Sd_problem_list()
        {
            var res = controller.Sd_problem_list();
            CollectionAssert.AllItemsAreUnique(res);
            foreach (var item in res)
            {
                Assert.That(item, Has.Property("id"));
                Assert.That(item, Has.Property("name"));
            }
        }

       // [Test]
       // public void Test_
    }
}
