namespace WinFormsFileCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSourceDir_Click(object sender, EventArgs e)
        {


            /* folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            cboSource.Items.Add(folderBrowserDialog1.SelectedPath);
            cboSource.Text = folderBrowserDialog1.SelectedPath;*/
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK) { cboSource.Text = folderBrowserDialog1.SelectedPath; }
            listBox1.Items.Add("Source:          " + folderBrowserDialog1.SelectedPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                cboDest.Text = folderBrowserDialog1.SelectedPath;
            }
            /*folderBrowserDialog1 = new FolderBrowserDialog();
                folderBrowserDialog1.ShowDialog();
                cboDest.Items.Add(folderBrowserDialog1.SelectedPath);
                cboDest.Text=folderBrowserDialog1.SelectedPath;*/
            listBox1.Items.Add("Desitnation:  " + folderBrowserDialog1.SelectedPath);
        }

        private void cboSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();

            listBox1.Items.Add("Source:          " + cboSource.Text);
        }

        private void cboDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();

            listBox1.Items.Add("Source:          " + cboDest.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(cboSource.Text, cboFilter.Text);  //!!! array mit Files Namen

            // foreach(Elementtyp Element Name in Menge)
            foreach (string strFile in files)
            {
                string strDest = Path.Combine(cboDest.Text, Path.GetFileName(strFile));
                listBox1.Items.Add($"Copy from: {strFile} to: {strDest}");
                File.Copy(strFile, strDest);
            }



            /*string[] files = Directory.GetFiles(cboSource.Text, cboFilter.Text);  
            string destinationFolder = cboDest.Text; 

            try
            {
                
                for (int i = 0; i < files.Length; i++)
                {
                    
                    string fileName = Path.GetFileName(files[i]);

                    
                    string destinationFile = Path.Combine(destinationFolder, fileName);

                    
                    File.Copy(files[i], destinationFile, overwrite: true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }*/

        }
    }
}
