using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using HelperLibrary;
using System.Threading;



namespace MammaProgramFinal
{
    public partial class Form1 : Form
    {
        static Socket clientSoc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        static List<Person> Data = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tmrDat.Interval = 120000;
            tmrDat.Start();


            clientSoc.Connect(new IPEndPoint(IPAddress.Parse("192.168.1.7"), 8080));
           
            Thread recieve = new Thread(new ParameterizedThreadStart(Recieve));
            recieve.Start(clientSoc);
            Thread.Sleep(2000);

            var dataFinal = from data in Data
                            orderby data.Surname ascending
                            select new { data.Initials, data.Name, data.Surname, data.Email, data.Number };



            dgvData.DataSource = dataFinal.ToList();


            var emails = from data in Data
                         where data.Email != "None"
                         select data.Email + ";";

            var numbers = from data in Data
                          where data.Number != "None"
                          select data.Number + ",";


            lstbEmails.DataSource = emails.ToArray();
            lstbNumbers.DataSource = numbers.ToArray();

            dgvData.ReadOnly = true;


        }

        public void Recieve(object obj)
        {
            Socket serverSoc = (Socket)obj;

            while (true)
            {
                byte[] buffer = new byte[10000000];
                int amounOfBytes = serverSoc.Receive(buffer);
               
                Data = (List<Person>)buffer.Deserialize();
                
                

                

            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            if (chkAdd.Checked == true)
            {
                if (txtNumber.Text.Length != 10)
                {
                    MessageBox.Show("The number entered is not 10 characters long","Number incorrect");

                }
                else
                {
                    string name;

                    if (txtEmail.Text.ToUpper() == "NONE" || txtEmail.Text == "")
                    {
                        txtEmail.Text = "None";

                    }

                    name = txtName.Text.Substring(0, 1).ToUpper();
                    name = name + txtName.Text.Substring(1, txtName.Text.Length - 1);

                    Person newPer = new Person(txtInitials.Text.ToUpper(), name, txtSurname.Text, txtEmail.Text, txtNumber.Text);

                    this.Invoke((Action)delegate
                    {
                        clientSoc.Send(newPer.Serialize());

                    });

                    Thread.Sleep(1000);

                    var dataFinal = from data in Data
                                    orderby data.Surname ascending
                                    select new { data.Initials, data.Name, data.Surname, data.Email, data.Number };



                    dgvData.DataSource = dataFinal.ToList();
                    // dgvData.CurrentCell = dgvData.Rows[Data.Count-1].Cells[0];



                    txtInitials.Text = "";
                    txtName.Text = "";
                    txtSurname.Text = "";
                    txtEmail.Text = "";
                    txtNumber.Text = "";

                    chkAdd.Checked = false;

                }
                

            }
            else
            {
                MessageBox.Show("Make sure all info is correct the check the check box","Check box not Checked");
            }

            var emails = from data in Data
                         where data.Email != "None"
                         select data.Email + ";";

            var numbers = from data in Data
                          where data.Number != "None"
                          select data.Number + ",";

            lstbEmails.DataSource = emails.ToArray();
            lstbNumbers.DataSource = numbers.ToArray();


        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            var emails = from data in Data
                         where data.Email != "None"
                         select data.Email + ";";

            var numbers = from data in Data
                          where data.Number != "None"
                          select data.Number + ",";


            lstbEmails.DataSource = emails.ToArray();
            lstbNumbers.DataSource = numbers.ToArray();



        }

        private void btnCopyEmails_Click(object sender, EventArgs e)
        {
            string strEmails = "";

            var emails = from data in Data
                         where data.Email != "None"
                         select data.Email + ";";

            foreach (var item in emails.ToArray())
            {
                strEmails = strEmails + item;
            }
            Clipboard.SetText(strEmails);
        }

        private void btnCopyNumbers_Click(object sender, EventArgs e)
        {
            string strNumbers = "";

            var numbers = from data in Data
                          where data.Number != "None"
                          select data.Number + ",";

            foreach (var item in numbers.ToArray())
            {
                strNumbers = strNumbers + item;
            }
            Clipboard.SetText(strNumbers);

        }

        private void txtSInitials_TextChanged(object sender, EventArgs e)
        {

            

            var Sdata = from data in Data
                        where data.Initials.Contains(txtSInitials.Text.ToUpper())
                        select new { data.Initials, data.Name, data.Surname, data.Email, data.Number };

            
        

            dgvData.DataSource = Sdata.ToList();

        }

        private void txtSName_TextChanged(object sender, EventArgs e)
        {
            

           
                var Sdata = from data in Data
                            where data.Initials.Substring(0, txtSInitials.Text.Length).ToUpper() == txtSInitials.Text.ToUpper() && data.Surname.Substring(0,txtSSurname.Text.Length).ToUpper() == txtSSurname.Text.ToUpper() 
                            select new { data.Initials, data.Name, data.Surname, data.Email, data.Number };

            

            dgvData.DataSource = Sdata.ToList();
        }

        private void btnSCopyEmail_Click(object sender, EventArgs e)
        {
            string strEmails = "";

            var emails = from data in Data
                         where data.Initials.Contains(txtSInitials.Text.ToUpper()) && data.Surname.Substring(0, txtSSurname.Text.Length).ToUpper() == txtSSurname.Text.ToUpper()
                         select data.Email + ";";

            foreach (var item in emails.ToArray())
            {
                strEmails = strEmails + item;
            }


            if (strEmails == "None;")
            {
                MessageBox.Show("There is no Email for this person","No Email");
            }
            else
            {
                Clipboard.SetText(strEmails);
            }

        }

        private void btnSCopyNumber_Click(object sender, EventArgs e)
        {
            string strNumbers = "";

            var numbers = from data in Data
                          where data.Initials.Contains(txtSInitials.Text.ToUpper()) && data.Surname.Substring(0, txtSSurname.Text.Length).ToUpper() == txtSSurname.Text.ToUpper()
                          select data.Number + ",";

            foreach (var item in numbers.ToArray())
            {
                strNumbers = strNumbers + item;
            }


            if (strNumbers == "None,")
            {
                MessageBox.Show("There is no number for this person", "No Number");

            }
            else
            {
                Clipboard.SetText(strNumbers);
            }

            
        }

       

        private void Send(object sender, EventArgs e)
        {
           

        }

        private void tmrDat_Tick(object sender, EventArgs e)
        {
            string refresh = "1" ;
            

            this.Invoke((Action)delegate
            {
                clientSoc.Send(refresh.Serialize());

            });
        }
    }
}
