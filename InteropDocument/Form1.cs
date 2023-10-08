using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InteropDocument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birhdayMan.MaxDate = DateTime.Now.AddYears(-18);
            birhdayWoman.MaxDate = DateTime.Now.AddYears(-18);
        }


        private void docWriteBut_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(CitizenshipManBox.Text) || String.IsNullOrEmpty(CitizenshipWomanBox.Text)))
            {
                InteropObject interObj = new InteropObject("C:\\Users\\Rost\\Files\\Sharp\\Practice\\InteropDocument\\InteropDocument\\Шаблон.docx");
                var dataDoc = new Dictionary<string, string>
            {
                { "<SURNAMEMAN>", surnameManBox.Text},
                { "<NAMEMAN>", nameManBox.Text},
                { "<PATRONYMICMAN>", patronymicManBox.Text},
                { "<CITIZENSHIPMAN>", CitizenshipManBox.Text},
                { "<BIRHDAYMAN>", birhdayMan.Value.ToString("dd MMMM yyyy")},
                { "<RESIDENCEMAN>", residenceManBox.Text},
                { "<SURNAMEWOMAN>", surnameWomanBox.Text},
                { "<NAMEWOMAN>", nameWomanBox.Text},
                { "<PATRONYMICWOMAN>", patronymicWomanBox.Text},
                { "<CITIZENSHIPWOMAN>", CitizenshipWomanBox.Text},
                { "<BIRHDAYWOMAN>", birhdayWoman.Value.ToString("dd MMMM yyyy")},
                { "<RESIDENCEWOMAN>", residenceWomanBox.Text},
                { "<ENDDATE>", endDate.Value.ToString("dd MMMM yyyy")},
                { "<BASIS>", basesBox.Text},
                { "<COURTDATE>", courtDate.Value.ToString("dd MMMM yyyy")},
                { "<DATECERTIFICATE>", certificateDate.Value.ToString("dd MMMM yyyy")},
                { "<NUMCERTIFICATE>", certificateNum.Text},
                { "<NEWSURNAME>", newSurnameBox.Text},
                { "<MARRIAGE>", marriageBox.Text},
                { "<ISSUED>", issuedBox.Text},
                { "<DATEISSUED>", issuedDate.Value.ToString("dd MMMM yyyy")}
            };
                interObj.Process(dataDoc);
            }
            else MessageBox.Show("Выбирите гражданство");
        }

        private void rusChars_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((int)e.KeyChar >= 1072 && (int)e.KeyChar <= 1103) || ((int)e.KeyChar >= 1040 && (int)e.KeyChar <= 1071)
                || ((int)e.KeyChar == 8) || ((int)e.KeyChar == 1105) || ((int)e.KeyChar == 1025)))
            {
                e.Handled = true;
            }
        }

        private void rusSpaceChars_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((int)e.KeyChar >= 1072 && (int)e.KeyChar <= 1103) || ((int)e.KeyChar >= 1040 && (int)e.KeyChar <= 1071)
                || ((int)e.KeyChar == 8) || ((int)e.KeyChar == 1105) || ((int)e.KeyChar == 1025) || ((int)e.KeyChar == 32)))
            {
                e.Handled = true;
            }
        }
    }
}
