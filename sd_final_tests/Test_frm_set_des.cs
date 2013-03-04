using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using System.Windows.Forms;


namespace sd_final_tests
{
    [TestFixture]
    class Test_frm_set_des
    {
        public sd_final.IViewInc _parent;
        public sd_final.frm_set_des test_form { get; set; }
        [SetUp]
        public void Init()
        {
            var controller = new sd_final.Inc_Controller(_parent);
            test_form = new sd_final.frm_set_des(20, controller);
        }

        [Test]
        public void Test_can_set_des()
        {
            test_form.des = "";
            Assert.That(test_form.can_set_des(), Is.EqualTo(false));
            test_form.des = "ssdgs";
            Assert.That(test_form.can_set_des(), Is.EqualTo(true));
        }
    }
}
