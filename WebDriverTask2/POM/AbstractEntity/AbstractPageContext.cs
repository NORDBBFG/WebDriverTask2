using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask2.POM.GestPage;

namespace WebDriverTask2.POM.AbstractEntity
{
    abstract class AbstractPageContext : AbstractPage
    {
        public T VerifyPageTitle<T>(string expectedTitle) where T : class
        {
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            try
            {
                return Activator.CreateInstance(typeof(T), driver) as T;
            } catch (Exception ex)
            {
                throw new Exception($"Something hepend with returning class! \n Exeption: {ex}");
            }
        }
    }
}
