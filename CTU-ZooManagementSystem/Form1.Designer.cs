using System.Windows.Forms;

namespace CTU_ZooManagementSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnFeed = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.lstAnimals = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.btnViewAnimalDetails = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(12, 12);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(120, 30);
            this.btnAddAnimal.TabIndex = 3;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(12, 60);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(120, 30);
            this.btnFeed.TabIndex = 2;
            this.btnFeed.Text = "Feed";
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(12, 108);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(120, 30);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "Move";
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lstAnimals
            // 
            this.lstAnimals.Location = new System.Drawing.Point(366, 12);
            this.lstAnimals.Name = "lstAnimals";
            this.lstAnimals.Size = new System.Drawing.Size(321, 199);
            this.lstAnimals.TabIndex = 5;
            this.lstAnimals.SelectedIndexChanged += new System.EventHandler(this.lstAnimals_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(32, 298);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Items.AddRange(new object[] {
            "Lion",
            "Parrot",
            "Turtle"});
            this.cmbAnimalType.Location = new System.Drawing.Point(355, 298);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(89, 21);
            this.cmbAnimalType.TabIndex = 7;
            this.cmbAnimalType.SelectedIndexChanged += new System.EventHandler(this.cmbAnimalType_SelectedIndexChanged);
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(203, 298);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 20);
            this.numAge.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 265);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Animal Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(226, 265);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(60, 13);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Animal Age";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(363, 265);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 13);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Animal Type";
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Location = new System.Drawing.Point(471, 292);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(120, 30);
            this.btnConfirmAdd.TabIndex = 12;
            this.btnConfirmAdd.Text = "Confirm Add";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // btnViewAnimalDetails
            // 
            this.btnViewAnimalDetails.Location = new System.Drawing.Point(12, 157);
            this.btnViewAnimalDetails.Name = "btnViewAnimalDetails";
            this.btnViewAnimalDetails.Size = new System.Drawing.Size(120, 28);
            this.btnViewAnimalDetails.TabIndex = 13;
            this.btnViewAnimalDetails.Text = "View Details";
            this.btnViewAnimalDetails.UseVisualStyleBackColor = true;
            this.btnViewAnimalDetails.Click += new System.EventHandler(this.btnViewAnimalDetails_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(12, 201);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(120, 28);
            this.btnSpeak.TabIndex = 14;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 344);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.btnViewAnimalDetails);
            this.Controls.Add(this.btnConfirmAdd);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.cmbAnimalType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstAnimals);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.btnAddAnimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnAddAnimal;
        private Button btnFeed;
        private Button btnMove;
        private ListBox lstAnimals;
        private TextBox txtName;
        private ComboBox cmbAnimalType;
        private NumericUpDown numAge;
        private Label lblName;
        private Label lblAge;
        private Label lblType;
        private Button btnConfirmAdd;
        private Button btnViewAnimalDetails;
        private Button btnSpeak;
    }
}
