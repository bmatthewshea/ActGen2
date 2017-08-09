using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ActGen
{
    public class FileOperations
    {


        public void SaveFile(string filename, string data)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //set save options
            saveFileDialog1.CreatePrompt = false;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.FileName = "myCodes";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //If dialog OK write it.
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                File.WriteAllText(name, data);
            }
        }



        // see http://stackoverflow.com/questions/26369/what-is-the-best-way-to-store-user-settings-for-a-net-application/26400#26400
        // for saving settings in appdata - use this with inno extract app?


    }
}
