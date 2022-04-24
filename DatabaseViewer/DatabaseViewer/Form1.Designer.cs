namespace DatabaseViewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtID = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tblContactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblContactsTableAdapter = new DatabaseViewer.AddressBookDataSetTableAdapters.tblContactsTableAdapter();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAdress1 = new System.Windows.Forms.TextBox();
            this.txtAdress2 = new System.Windows.Forms.TextBox();
            this.txtAdress3 = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnPrevRecord = new System.Windows.Forms.Button();
            this.btnNextRecord = new System.Windows.Forms.Button();
            this.btnLastRecord = new System.Windows.Forms.Button();
            this.btnFirstRecord = new System.Windows.Forms.Button();
            this.txtRec = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtAllRecord = new System.Windows.Forms.Label();
            this.txtCurrRecord = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTest = new System.Windows.Forms.Label();
            this.tblContactsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataAddressBookBind = new System.Windows.Forms.BindingSource(this.components);
            this.addressBookDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressBookDataSet = new DatabaseViewer.AddressBookDataSet();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblContactsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAddressBookBind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "ID", true));
            this.txtID.Location = new System.Drawing.Point(186, 21);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(177, 20);
            this.txtID.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tblContactsBindingSource
            // 
            this.tblContactsBindingSource.DataSource = this.tblContactsBindingSource2;
            // 
            // tblContactsTableAdapter
            // 
            this.tblContactsTableAdapter.ClearBeforeFill = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(186, 51);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(177, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "Surname", true));
            this.txtSurname.Location = new System.Drawing.Point(188, 86);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(177, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // txtAdress1
            // 
            this.txtAdress1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "Address1", true));
            this.txtAdress1.Location = new System.Drawing.Point(186, 123);
            this.txtAdress1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdress1.Name = "txtAdress1";
            this.txtAdress1.Size = new System.Drawing.Size(177, 20);
            this.txtAdress1.TabIndex = 4;
            // 
            // txtAdress2
            // 
            this.txtAdress2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "Address2", true));
            this.txtAdress2.Location = new System.Drawing.Point(186, 161);
            this.txtAdress2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdress2.Name = "txtAdress2";
            this.txtAdress2.Size = new System.Drawing.Size(177, 20);
            this.txtAdress2.TabIndex = 5;
            // 
            // txtAdress3
            // 
            this.txtAdress3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "Address3", true));
            this.txtAdress3.Location = new System.Drawing.Point(186, 197);
            this.txtAdress3.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdress3.Name = "txtAdress3";
            this.txtAdress3.Size = new System.Drawing.Size(177, 20);
            this.txtAdress3.TabIndex = 6;
            // 
            // txtPostcode
            // 
            this.txtPostcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "Postcode", true));
            this.txtPostcode.Location = new System.Drawing.Point(186, 233);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(177, 20);
            this.txtPostcode.TabIndex = 7;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IDLabel.Location = new System.Drawing.Point(73, 15);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(31, 25);
            this.IDLabel.TabIndex = 8;
            this.IDLabel.Text = "ID";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fNameLabel.Location = new System.Drawing.Point(58, 45);
            this.fNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(103, 25);
            this.fNameLabel.TabIndex = 9;
            this.fNameLabel.Text = "First name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnameLabel.Location = new System.Drawing.Point(61, 80);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(92, 25);
            this.surnameLabel.TabIndex = 10;
            this.surnameLabel.Text = "Surname";
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.address1Label.Location = new System.Drawing.Point(58, 117);
            this.address1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(101, 25);
            this.address1Label.TabIndex = 11;
            this.address1Label.Text = "Address 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(58, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Address 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(58, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Address 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(58, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Postcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(58, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(58, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(58, 333);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Notes";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(186, 269);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(177, 20);
            this.txtPhone.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(186, 305);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // txtNotes
            // 
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactsBindingSource, "Notes", true));
            this.txtNotes.Location = new System.Drawing.Point(186, 340);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(177, 20);
            this.txtNotes.TabIndex = 20;
            // 
            // btnPrevRecord
            // 
            this.btnPrevRecord.Location = new System.Drawing.Point(180, 410);
            this.btnPrevRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevRecord.Name = "btnPrevRecord";
            this.btnPrevRecord.Size = new System.Drawing.Size(84, 28);
            this.btnPrevRecord.TabIndex = 21;
            this.btnPrevRecord.Text = "<";
            this.btnPrevRecord.UseVisualStyleBackColor = true;
            this.btnPrevRecord.Click += new System.EventHandler(this.btnPrevRecord_Click);
            // 
            // btnNextRecord
            // 
            this.btnNextRecord.Location = new System.Drawing.Point(279, 410);
            this.btnNextRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextRecord.Name = "btnNextRecord";
            this.btnNextRecord.Size = new System.Drawing.Size(84, 28);
            this.btnNextRecord.TabIndex = 22;
            this.btnNextRecord.Text = ">";
            this.btnNextRecord.UseVisualStyleBackColor = true;
            this.btnNextRecord.Click += new System.EventHandler(this.btnNextRecord_Click);
            // 
            // btnLastRecord
            // 
            this.btnLastRecord.Location = new System.Drawing.Point(382, 410);
            this.btnLastRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnLastRecord.Name = "btnLastRecord";
            this.btnLastRecord.Size = new System.Drawing.Size(84, 28);
            this.btnLastRecord.TabIndex = 23;
            this.btnLastRecord.Text = ">>";
            this.btnLastRecord.UseVisualStyleBackColor = true;
            this.btnLastRecord.Click += new System.EventHandler(this.btnLastRecord_Click);
            // 
            // btnFirstRecord
            // 
            this.btnFirstRecord.Location = new System.Drawing.Point(65, 410);
            this.btnFirstRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstRecord.Name = "btnFirstRecord";
            this.btnFirstRecord.Size = new System.Drawing.Size(87, 28);
            this.btnFirstRecord.TabIndex = 24;
            this.btnFirstRecord.Text = "<<";
            this.btnFirstRecord.UseVisualStyleBackColor = true;
            this.btnFirstRecord.Click += new System.EventHandler(this.btnFirstRecord_Click);
            // 
            // txtRec
            // 
            this.txtRec.AutoSize = true;
            this.txtRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRec.Location = new System.Drawing.Point(63, 377);
            this.txtRec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtRec.Name = "txtRec";
            this.txtRec.Size = new System.Drawing.Size(47, 15);
            this.txtRec.TabIndex = 25;
            this.txtRec.Text = "Record";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 379);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "of";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(382, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 30);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(180, 464);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 30);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(279, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 30);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(65, 464);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 30);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(484, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 30);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtAllRecord
            // 
            this.txtAllRecord.AutoSize = true;
            this.txtAllRecord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAllRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAllRecord.Location = new System.Drawing.Point(194, 377);
            this.txtAllRecord.Name = "txtAllRecord";
            this.txtAllRecord.Size = new System.Drawing.Size(21, 15);
            this.txtAllRecord.TabIndex = 34;
            this.txtAllRecord.Text = "18";
            // 
            // txtCurrRecord
            // 
            this.txtCurrRecord.AutoSize = true;
            this.txtCurrRecord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCurrRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCurrRecord.Location = new System.Drawing.Point(127, 377);
            this.txtCurrRecord.Name = "txtCurrRecord";
            this.txtCurrRecord.Size = new System.Drawing.Size(14, 15);
            this.txtCurrRecord.TabIndex = 35;
            this.txtCurrRecord.Text = "1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.address3DataGridViewTextBoxColumn,
            this.postcodeDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblContactsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(443, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(239, 58);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtTest
            // 
            this.txtTest.AutoSize = true;
            this.txtTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTest.Location = new System.Drawing.Point(467, 24);
            this.txtTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(192, 25);
            this.txtTest.TabIndex = 36;
            this.txtTest.Text = "Check data changes";
            // 
            // dataAddressBookBind
            // 
            this.dataAddressBookBind.DataMember = "tblContacts";
            this.dataAddressBookBind.DataSource = this.addressBookDataSet;
            // 
            // addressBookDataSetBindingSource
            // 
            this.addressBookDataSetBindingSource.DataSource = this.addressBookDataSet;
            this.addressBookDataSetBindingSource.Position = 0;
            // 
            // addressBookDataSet
            // 
            this.addressBookDataSet.DataSetName = "AddressBookDataSet";
            this.addressBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "Address1";
            this.address1DataGridViewTextBoxColumn.HeaderText = "Address1";
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "Address2";
            this.address2DataGridViewTextBoxColumn.HeaderText = "Address2";
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            // 
            // address3DataGridViewTextBoxColumn
            // 
            this.address3DataGridViewTextBoxColumn.DataPropertyName = "Address3";
            this.address3DataGridViewTextBoxColumn.HeaderText = "Address3";
            this.address3DataGridViewTextBoxColumn.Name = "address3DataGridViewTextBoxColumn";
            // 
            // postcodeDataGridViewTextBoxColumn
            // 
            this.postcodeDataGridViewTextBoxColumn.DataPropertyName = "Postcode";
            this.postcodeDataGridViewTextBoxColumn.HeaderText = "Postcode";
            this.postcodeDataGridViewTextBoxColumn.Name = "postcodeDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // tblContactsBindingSource2
            // 
            this.tblContactsBindingSource2.DataMember = "tblContacts";
            this.tblContactsBindingSource2.DataSource = this.addressBookDataSetBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 527);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.txtCurrRecord);
            this.Controls.Add(this.txtAllRecord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRec);
            this.Controls.Add(this.btnFirstRecord);
            this.Controls.Add(this.btnLastRecord);
            this.Controls.Add(this.btnNextRecord);
            this.Controls.Add(this.btnPrevRecord);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtAdress3);
            this.Controls.Add(this.txtAdress2);
            this.Controls.Add(this.txtAdress1);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "DatabaseViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAddressBookBind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.BindingSource tblContactsBindingSource;
        private AddressBookDataSetTableAdapters.tblContactsTableAdapter tblContactsTableAdapter;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtAdress3;
        private System.Windows.Forms.TextBox txtAdress2;
        private System.Windows.Forms.TextBox txtAdress1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnPrevRecord;
        private System.Windows.Forms.Button btnFirstRecord;
        private System.Windows.Forms.Button btnLastRecord;
        private System.Windows.Forms.Button btnNextRecord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtRec;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label txtAllRecord;
        private System.Windows.Forms.Label txtCurrRecord;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label txtTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblContactsBindingSource1;
        private System.Windows.Forms.BindingSource dataAddressBookBind;
        private AddressBookDataSet addressBookDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addressBookDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblContactsBindingSource2;
    }
}

