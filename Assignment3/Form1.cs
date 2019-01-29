/*Program ID: Assignment3
 * Form ID: Data InputOutput
 * 
 * Purpose: Manage Transaction #
 * 
 * Revision History
 *      Young Geun, Kim(Andrew) 23 Mar 2018
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        List<string> lstTransact = new List<string>();
        List<string> lstDate = new List<string>();
        List<string> lstSerialNumber = new List<string>();
        List<string> lstTool = new List<string>();
        List<string> lstPrice = new List<string>();
        List<string> lstQty = new List<string>();
        List<string> lstAmount = new List<string>();
        public Form1()
        {
            InitializeComponent();

            //
            ltvDisplay.View = View.Details;
            //
            ltvDisplay.BeginUpdate();
            //
            ltvDisplay.Columns.Add("#", 50);
            ltvDisplay.Columns.Add("Purchased-Date", 150);
            ltvDisplay.Columns.Add("Serial #", 150);
            ltvDisplay.Columns.Add("Manufacturing Tools", 300);
            ltvDisplay.Columns.Add("Price", 100);
            ltvDisplay.Columns.Add("Qty", 100);
            ltvDisplay.Columns.Add("Amount", 100);
            //
            ListViewItem lvi = new ListViewItem("a");
            lvi.SubItems.Add("111");
        }
        private bool Validation()
        {
            string message = null;
            Regex regNumber = new Regex(@"\d");
            Regex regString = new Regex(@"^[0-9A-Za-z ]+$");

            DateTime dt;

            bool dateValid = DateTime.TryParseExact(
             txtDate.Text,
             "MM/dd/yyyy",
             CultureInfo.InvariantCulture,
             DateTimeStyles.None,
             out dt);
            bool transactValid = regNumber.IsMatch(txtTransactWrite.Text);
            bool serialValid = regNumber.IsMatch(txtSerialNumber.Text);
            bool toolValid = regString.IsMatch(txtTool.Text);
            bool priceValid = regNumber.IsMatch(txtPrice.Text);
            bool qtyValid = regNumber.IsMatch(txtQty.Text);
            bool amountValid = regNumber.IsMatch(txtAmount.Text);

            if (!transactValid) { message += "Transact Number Can not" +
                    " be Empty or alphabetic\n"; }
            if (lstTransact.IndexOf(txtTransactWrite.Text) != -1)
            { message += "Transact Number Should be Unique\n";
                transactValid = false; }
            if (!serialValid) { message += "Serial Number Can not be" +
                    " Empty or alphabetic\n"; }
            if (!toolValid) { message += "Special Character is Not" +
                    " Acceptable\n"; }
            if (!priceValid) { message += "Price Can not be Empty" +
                    " or alphabetic\n"; }
            if (!qtyValid) { message += "Quantity Can not be Empty" +
                    " or alphabetic\n"; }
            if (!amountValid) { message += "Amount Can not be Empty" +
                    " or alphabetic\n"; }
            if (!dateValid) { message += "Invalid for Date Format\n"; }

            if (message != null) { MessageBox.Show(message); }

            return transactValid && serialValid && toolValid && dateValid
                && priceValid && qtyValid && amountValid;
        }
        private void btnCreateOpen_Click(object sender, EventArgs e)
        {
            bool exist = File.Exists(txtFileName.Text);

            if (rbtCreate.Checked)
            {
                txtFileName.Clear();
                lstTransact.Clear();
                lstDate.Clear();
                lstSerialNumber.Clear();
                lstTool.Clear();
                lstPrice.Clear();
                lstQty.Clear();
                lstAmount.Clear();

                StreamWriter writer = null;

                SaveFileDialog sfdlg = new SaveFileDialog();
                sfdlg.InitialDirectory = @"C:\Users\Public\Desktop";
                sfdlg.FilterIndex = 2;
                sfdlg.Title = "Save text files";
                sfdlg.Filter = "Text Files (*.txt) | *.txt"; 
                if (sfdlg.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = sfdlg.FileName;
                    writer = File.AppendText(sfdlg.FileName);
                    writer.Close();

                    rtbMessage.Text = "New File Created";
                }

            }


            if (rbtOpen.Checked)
            {
                txtFileName.Clear();
                lstTransact.Clear();
                lstDate.Clear();
                lstSerialNumber.Clear();
                lstTool.Clear();
                lstPrice.Clear();
                lstQty.Clear();
                lstAmount.Clear();

                StreamWriter writer = null;

                OpenFileDialog ofdlg = new OpenFileDialog();
                ofdlg.InitialDirectory = @"C:\Users\Public\Desktop";
                ofdlg.FilterIndex = 2;
                ofdlg.Title = "Open text files";
                ofdlg.Filter = "Text Files (*.txt) | *.txt";
                if (ofdlg.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        txtFileName.Text = ofdlg.FileName;
                        writer = File.AppendText(ofdlg.FileName);
                        writer.Close();

                        String line;
                        using (StreamReader reader = 
                            new StreamReader(txtFileName.Text))
                        {
                            line = reader.ReadToEnd();
                            line.TrimEnd();
                        }

                        string[] arrLineBreak = line.Split('\n');
                        string[] arrTabBreak = new string[8];

                        for (int i = 0; i < arrLineBreak.Length - 1; i++)
                        {
                            arrTabBreak = arrLineBreak[i].Split('\t');
                            lstTransact.Add(arrTabBreak[0]);
                            lstDate.Add(arrTabBreak[1]);
                            lstSerialNumber.Add(arrTabBreak[2]);
                            lstTool.Add(arrTabBreak[3]);
                            lstPrice.Add(arrTabBreak[4]);
                            lstQty.Add(arrTabBreak[5]);
                            lstAmount.Add(arrTabBreak[6]);
                        }
                        btnDisplay_Click(sender, e);
                        rtbMessage.Text = "File Load Complete";
                    }
                    catch (IndexOutOfRangeException)
                    {
                        rtbMessage.Text = "Invalid File Format";
                    }
                }
            }
        }

        private void btnWriteRecord_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                lstTransact.Add(txtTransactWrite.Text);
                lstDate.Add(txtDate.Text);
                lstSerialNumber.Add(txtSerialNumber.Text);
                lstTool.Add(txtTool.Text);
                lstPrice.Add(txtPrice.Text);
                lstQty.Add(txtQty.Text);
                lstAmount.Add(txtAmount.Text);

                rtbMessage.Text = "Data has Successfully Added";
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            ltvDisplay.Items.Clear();
            string[] container = new string[7];
            ListViewItem itm;


            for (int i = 0; i < lstTransact.Count; i++)
            {
                container[0] = lstTransact[i];
                container[1] = lstDate[i];
                container[2] = lstSerialNumber[i];
                container[3] = lstTool[i];
                container[4] = lstPrice[i];
                container[5] = lstQty[i];
                container[6] = lstAmount[i];

                itm = new ListViewItem(container);

                ltvDisplay.Items.Add(itm);
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            int index = lstTransact.IndexOf(txtTransactFind.Text);
            if (index == -1)
            {
                rtbMessage.Text = "There is No such Transact Number";
            }
            else
            {
                lstTransact.RemoveAt(index);
                lstDate.RemoveAt(index);
                lstSerialNumber.RemoveAt(index);
                lstTool.RemoveAt(index);
                lstPrice.RemoveAt(index);
                lstQty.RemoveAt(index);
                lstAmount.RemoveAt(index);

                rtbMessage.Text = "Transact Number " +
                    txtTransactFind.Text + " has successfully Removed";

                txtTransactFind.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string tmp = null;

            for (int i = 0; i < lstTransact.Count; i++)
            {
                tmp += lstTransact[i] + "\t" + lstDate[i] + 
                    "\t" + lstSerialNumber[i] + "\t"
                    + lstTool[i] + "\t" + lstPrice[i] + 
                    "\t" + lstQty[i] + "\t"
                    + lstAmount[i] + "\n";
            }

            using (StreamWriter writer =
            new StreamWriter(txtFileName.Text))
            {
                writer.Write(tmp);
            }

            txtFileName.Clear();
            lstTransact.Clear();
            lstDate.Clear();
            lstSerialNumber.Clear();
            lstTool.Clear();
            lstPrice.Clear();
            lstQty.Clear();
            lstAmount.Clear();
            btnDisplay_Click(sender, e);

            rtbMessage.Text = "File has Saved and Closed";
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            File.Delete(txtFileName.Text);
            rtbMessage.Text = txtFileName.Text + " Has Deleted";
            txtFileName.Clear();
            lstTransact.Clear();
            lstDate.Clear();
            lstSerialNumber.Clear();
            lstTool.Clear();
            lstPrice.Clear();
            lstQty.Clear();
            lstAmount.Clear();
            btnDisplay_Click(sender, e);
        }
    }
}
