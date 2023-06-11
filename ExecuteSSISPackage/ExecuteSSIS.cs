using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;
namespace ExecuteSSISPackage
{
    public class ExecuteSSIS
    {
        public void RunSSISPackage()
        {
            Microsoft.SqlServer.Dts.Runtime.Application app = new Microsoft.SqlServer.Dts.Runtime.Application();
            Package package = null;
            package = app.LoadPackage(@"E:\CTS_Training\SSIS_PAckages\ImportEmails\ImportEmails\Package.dtsx",null);
            package.Execute();
            if (package.Errors.Count > 0)
            {
                foreach (DtsError err in package.Errors)
                {
                    MessageBox.Show(err.Description);
                }
            }
        }
    }
}
