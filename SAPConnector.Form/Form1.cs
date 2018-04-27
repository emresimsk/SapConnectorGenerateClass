using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SAP.Middleware.Connector;
using SAPConnector.Core;
using SAPConnector.Core.Model;

namespace SAP.Form
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            string path = CreateFolder(tbPath.Text, tbFunctionName.Text);

            SapParameter parameter = new SapParameter()
            {
                AppServerHost = tbAppServerHost.Text,
                Client = tbClient.Text,
                IdleTimeout = tbIdleTimeout.Text,
                Language = cbLanguage.SelectedText,
                Name = tbName.Text,
                Password = tbPassword.Text,
                PeakConnectionsLimit = tbPeakConnectionsLimit.Text,
                PoolSize = tbPoolSize.Text,
                SystemNumber = tbSystemNumber.Text,
                User = tbUser.Text,
                FunctionName = tbFunctionName.Text
            };

     


            IRfcFunction function = SapConnection.GetFunction(parameter);

            if (function != null)
            {
                List<SapClassModel> classBuilder = SapConnection.GetAllTablesClass(function);

                foreach (var sapClass in classBuilder)
                {
                    using (var tw = File.AppendText(path + sapClass.ClassName + ".cs"))
                    {
                        tw.WriteLine(sapClass.Builder.ToString());
                        tw.Close();
                    }
                }

                MessageBox.Show(@"Complete", @"Alert", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(@"Not found function name", @"Alert", MessageBoxButtons.OK);
            }

            
        }

        private void btnPathOpen_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();

            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                string location = folderDlg.SelectedPath;

                tbPath.Text = location;
            }
        }

        private string CreateFolder(string path, string folderName)
        {
            path = path + @"\" + folderName;

            bool exists = System.IO.Directory.Exists(path);

            if (!exists)
                System.IO.Directory.CreateDirectory(path);

            return path + @"\";
        }

    }
}












