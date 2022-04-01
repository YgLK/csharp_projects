using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addressBookDataSet.tblContacts' table. You can move, or remove it, as needed.
            this.tblContactsTableAdapter.Fill(this.addressBookDataSet.tblContacts);
            // TODO: This line of code loads data into the 'addressBookDataSet.tblContacts' table. You can move, or remove it, as needed.
            this.tblContactsTableAdapter.Fill(this.addressBookDataSet.tblContacts);
            txtAllRecord.Text = tblContactsBindingSource.Count.ToString();
            txtCurrRecord.Text = (tblContactsBindingSource.Position + 1).ToString();

            // set components properties
            btnFirstRecord.Enabled = true;
            btnPrevRecord.Enabled = true;
            btnNextRecord.Enabled = true;
            btnLastRecord.Enabled = true;
            btnEdit.Enabled = true;
            txtID.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtSurname.ReadOnly = true;
            txtAdress1.ReadOnly = true;
            txtAdress2.ReadOnly = true;
            txtAdress3.ReadOnly = true;
            txtPostcode.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtNotes.ReadOnly = true;
        }

        private void btnNextRecord_Click(object sender, EventArgs e)
        {
            tblContactsBindingSource.Position += 1;
            txtCurrRecord.Text = (tblContactsBindingSource.Position + 1).ToString();
        }

        private void btnPrevRecord_Click(object sender, EventArgs e)
        {
            tblContactsBindingSource.Position -= 1;
            txtCurrRecord.Text = (tblContactsBindingSource.Position + 1).ToString();
        }

        private void btnFirstRecord_Click(object sender, EventArgs e)
        {
            tblContactsBindingSource.Position = 0;
            txtCurrRecord.Text = (tblContactsBindingSource.Position + 1).ToString();
        }

        private void btnLastRecord_Click(object sender, EventArgs e)
        {
            tblContactsBindingSource.Position = tblContactsBindingSource.Count - 1;
            txtCurrRecord.Text = (tblContactsBindingSource.Position + 1).ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnFirstRecord.Enabled = false;
            btnPrevRecord.Enabled = false;
            btnNextRecord.Enabled = false;
            btnLastRecord.Enabled = false;
            btnEdit.Enabled = false;
            txtID.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtSurname.ReadOnly = false;
            txtAdress1.ReadOnly = false;
            txtAdress2.ReadOnly = false;
            txtAdress3.ReadOnly = false;
            txtPostcode.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtNotes.ReadOnly = false;
            txtID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int currRecordPos = tblContactsBindingSource.Position;
            tblContactsBindingSource.EndEdit();
            currRecordPos = tblContactsBindingSource.Position;
            // addressBookDataSet is the data associated with tblContactsBindingSource
            if(addressBookDataSet.HasChanges() == true)
            {
                tblContactsTableAdapter.Update(addressBookDataSet);
                tblContactsTableAdapter.Fill(addressBookDataSet.tblContacts);
            }

            txtID.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtSurname.ReadOnly = true;
            txtAdress1.ReadOnly = true;
            txtAdress2.ReadOnly = true;
            txtAdress3.ReadOnly = true;
            txtPostcode.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtNotes.ReadOnly = true;
            btnEdit.Enabled = true;
            
            btnFirstRecord.Enabled = true;
            btnPrevRecord.Enabled = true;
            btnNextRecord.Enabled = true;
            btnLastRecord.Enabled = true;

            tblContactsBindingSource.Position = currRecordPos;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tblContactsBindingSource.CancelEdit();
            txtID.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtSurname.ReadOnly = true;
            txtAdress1.ReadOnly = true;
            txtAdress2.ReadOnly = true;
            txtAdress3.ReadOnly = true;
            txtPostcode.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtNotes.ReadOnly = true;

            btnFirstRecord.Enabled = true;
            btnPrevRecord.Enabled = true;
            btnNextRecord.Enabled = true;
            btnLastRecord.Enabled = true;

            btnEdit.Enabled = true;
            //tblContactsBindingSource.PositionChanged(null, null); (>:|)

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtSurname.ReadOnly = false;
            txtAdress1.ReadOnly = false;
            txtAdress2.ReadOnly = false;
            txtAdress3.ReadOnly = false;
            txtPostcode.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtNotes.ReadOnly = false;
            txtID.Focus();
            int startRecordPos = tblContactsBindingSource.Position;
            tblContactsBindingSource.AddNew();
            txtAllRecord.Text = tblContactsBindingSource.Count.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show(
                "Czy chcesz na pewno usunąc wiersz ?",
                 "potwierdz", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if(response == System.Windows.Forms.DialogResult.Yes)
            {
                tblContactsBindingSource.RemoveAt(tblContactsBindingSource.Position);
            }
            txtAllRecord.Text = tblContactsBindingSource.Count.ToString();
        }
    }
}
