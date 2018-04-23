using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace NewProject
{
    public partial class Form1 : XtraForm
    {

        Random _r = new Random();

        public Form1()
        {
            InitializeComponent();
            simpleButton1.BringToFront();
            simpleButton2.BringToFront();
        }

        private void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            e.Control = new Control() { BackColor = Color.FromArgb(_r.Next(255), _r.Next(255), _r.Next(255)) };
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<MyFile> files = GetLayouts();
            File.Delete("Test.xml");
            using (Stream stream = new FileStream("Test.xml", FileMode.CreateNew, FileAccess.ReadWrite))
            {
                // Serialise
                XmlSerializer formatter = new XmlSerializer(typeof(List<MyFile>));
                formatter.Serialize(stream, files);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            using (Stream stream = new FileStream("Test.xml", FileMode.Open, FileAccess.Read))
            {
                // Deserailise
                XmlSerializer formatter = new XmlSerializer(typeof(List<MyFile>));
                List<MyFile> deserialisedFiles = (List<MyFile>)formatter.Deserialize(stream);
                RestoreLayouts(deserialisedFiles);
            }

        }
        private List<MyFile> GetLayouts()
        {
            MemoryStream ms1 = new MemoryStream();
            dockManager1.SaveLayoutToStream(ms1);
            MemoryStream ms2 = new MemoryStream();
            tabbedView1.SaveLayoutToStream(ms2);
            return new List<MyFile>{ new MyFile() { FileName = "DockManagerLayout", Data = ms1.ToArray() }, new MyFile() { FileName = "TabbedViewLayout", Data = ms2.ToArray() }};
        }
        private void RestoreLayouts(List<MyFile> deserialisedFiles)
        {
            MyFile dockManagerLayout = deserialisedFiles.OfType<MyFile>().First(mf => mf.FileName == "DockManagerLayout");
            MyFile tabbedViewLayout = deserialisedFiles.OfType<MyFile>().First(mf => mf.FileName == "TabbedViewLayout");

            dockManager1.RestoreLayoutFromStream(new MemoryStream(dockManagerLayout.Data));
            tabbedView1.RestoreLayoutFromStream(new MemoryStream(tabbedViewLayout.Data));
        }
    }
    [Serializable()]
    public class MyFile
    {
        public byte[] Data;
        public string FileName;
    }

}
