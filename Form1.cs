namespace WinFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private ComputerList computerList;
        private ComboBox failureModeComboBox;
        private TextBox addressTextBox;
        private TextBox usersTextBox;
        private Button Load;
        private Button AddNewComputer;
        private List<string> failureModes;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creating and populating the ComputerList
            computerList = new ComputerList();

            Computer computer1 = new Computer();
            computer1.Address = "192.168.1.1";
            computer1.Users = new List<string>(new string[] { "User1", "User2" });
            computer1.FailureMode = "Blue Screen of Death";

            Computer computer2 = new Computer();
            computer2.Address = "192.168.1.2";
            computer2.Users = new List<string>(new string[] { "User3", "User4" });
            computer2.FailureMode = "Crash";

            Computer computer3 = new Computer();
            computer3.Address = "192.168.1.3";
            computer3.Users = new List<string>(new string[] { "User2", "User5" });
            computer3.FailureMode = "Blue Screen of Death";

            Computer computer4 = new Computer();
            computer4.Address = "192.168.1.4";
            computer4.Users = new List<string>(new string[] { "User4", "User6" });
            computer4.FailureMode = "Crash";

            Computer computer5 = new Computer();
            computer5.Address = "192.168.1.5";
            computer5.Users = new List<string>(new string[] { "User1", "User3", "User5" });
            computer5.FailureMode = "Freeze";

            computerList.AddComputer(computer1);
            computerList.AddComputer(computer2);
            computerList.AddComputer(computer3);
            computerList.AddComputer(computer4);
            computerList.AddComputer(computer5);

            // Populating the list of failure modes
            failureModes = new List<string>(new string[] { "Blue Screen of Death", "Crash", "Freeze" });

            // Populating the combo box with the list of failure modes
            failureModeComboBox.DataSource = failureModes;
        }

        private void InitializeComponent()
        {
            failureModeComboBox = new ComboBox();
            addressTextBox = new TextBox();
            usersTextBox = new TextBox();
            Load = new Button();
            AddNewComputer = new Button();
            SuspendLayout();
            // 
            // failureModeComboBox
            // 
            failureModeComboBox.FormattingEnabled = true;
            failureModeComboBox.Location = new Point(55, 157);
            failureModeComboBox.Name = "failureModeComboBox";
            failureModeComboBox.Size = new Size(162, 23);
            failureModeComboBox.TabIndex = 0;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(55, 26);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(162, 23);
            addressTextBox.TabIndex = 1;
            // 
            // usersTextBox
            // 
            usersTextBox.Location = new Point(55, 93);
            usersTextBox.Name = "usersTextBox";
            usersTextBox.Size = new Size(162, 23);
            usersTextBox.TabIndex = 2;
            // 
            // Load
            // 
            Load.Location = new Point(33, 210);
            Load.Name = "Load";
            Load.Size = new Size(75, 23);
            Load.TabIndex = 3;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Form1_Load;
            // 
            // AddNewComputer
            // 
            AddNewComputer.Location = new Point(173, 211);
            AddNewComputer.Name = "AddNewComputer";
            AddNewComputer.Size = new Size(75, 23);
            AddNewComputer.TabIndex = 4;
            AddNewComputer.Text = "Add Computer";
            AddNewComputer.UseVisualStyleBackColor = true;
            AddNewComputer.Click += AddComputerButton_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(AddNewComputer);
            Controls.Add(Load);
            Controls.Add(usersTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(failureModeComboBox);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void AddComputerButton_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                MessageBox.Show("Please enter an address.");
                return;
            }

            if (string.IsNullOrWhiteSpace(usersTextBox.Text))
            {
                MessageBox.Show("Please enter at least one user.");
                return;
            }

            if (failureModeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a failure mode.");
                return;
            }

            // Parse the list of users
            List<string> users = new List<string>();
            string[] userNames = usersTextBox.Text.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string userName in userNames)
            {
                users.Add(userName.Trim());
            }

            // Create a new computer object
            Computer computer = new Computer();
            computer.Address = addressTextBox.Text;
            computer.FailureMode = failureModeComboBox.SelectedIndex.ToString();

        }


    }
}