using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Configuration;

namespace K163994_Q2
{
    public partial class Form1 : Form
    {


        XmlSerializer xml;
        EmailMessage emailMessages;
       
        public Form1()
        {
            InitializeComponent();

            emailMessages = new EmailMessage();
            xml = new XmlSerializer(typeof(EmailMessage));

        }

       

       
        private void button1_Click(object sender, EventArgs e)
        {
            EmailMessage obj = new EmailMessage();
            obj.To = TO.Text;
            obj.Subject = Subject.Text;
            obj.Messages = Message.Text;

           
            FileStream file = new FileStream(ConfigurationManager.AppSettings["FilePath"]+obj.To+".xml", FileMode.CreateNew, FileAccess.Write);
            
            xml.Serialize(file, obj);

            file.Close();
            //prevent accidently press the submit button twice.
            button1.Enabled = false;

            TO.Text = "";
            Subject.Text = "";
            Message.Text = "";
        }

       
    }
}
