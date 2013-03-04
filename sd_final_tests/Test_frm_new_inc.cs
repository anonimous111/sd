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
    class Test_frm_new_inc
    {
        public sd_final.frm_new_inc test_form { get; set; }
        public sd_final.IViewInc _parent;
        [SetUp]
        public void Init()
        {
            _parent = Substitute.For<sd_final.IViewInc>();
            var controller = new sd_final.Inc_Controller(_parent);
            test_form = new sd_final.frm_new_inc(_parent, controller);
            
        }
        [Test]
        public void Test_Can_regiser_incident()
        {
            Assert.That(test_form.Is_valid_uinfo(), Is.EqualTo(false));
            Assert.That(test_form.Is_valid_simptoms(), Is.EqualTo(false));
            Assert.That(test_form.Is_valid_uids(), Is.EqualTo(false));
            test_form.uinfo = "uinfo";
            test_form.simptoms = "usimp";
            test_form.uids.Add(23);
            CollectionAssert.AllItemsAreUnique(test_form.uids);
            Assert.That(test_form.Is_valid_uinfo(), Is.EqualTo(true));
            Assert.That(test_form.Is_valid_simptoms(), Is.EqualTo(true));
            Assert.That(test_form.Is_valid_uids(), Is.EqualTo(true));
            Assert.That(test_form.Can_register_incident(),Is.EqualTo(true));
            
        }
    }
}
