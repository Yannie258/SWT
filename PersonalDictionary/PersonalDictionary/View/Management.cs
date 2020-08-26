using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using NUnit.Framework.Internal.Builders;
using PersonalDictionary.Controller;
using PersonalDictionary.Model;

namespace PersonalDictionary
{
    public partial class ManagementData : Form
    {
       
        public ManagementData()
        {
            InitializeComponent();
            //automatisch Data einladen , wenn Form fortfuehrt
            loadData();
        }
        
        ControlManagement cm = new ControlManagement();

        //Initiation Data mit Programm
        private void loadData()
        {
            DataTable dt = cm.LoadDataTable();
            gridItemData.DataSource = dt;



        }
        #region zeigen geklickte Zeile von Datagrid in TextBox aus    
        private void setValue(int index)
        {
            try
            {
                //erzeugen eine DataGridviewRow
                DataGridViewRow row = gridItemData.Rows[index];
                //uebertragen Data vom Grid zum Textbox
                txb_ID.Text = row.Cells[0].Value.ToString();
                txb_German.Text = row.Cells[1].Value.ToString();
                txb_Meaning.Text = row.Cells[2].Value.ToString();
                txb_Details.Text = row.Cells[3].Value.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gridItemData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            setValue(e.RowIndex);
        }

        #endregion

        #region Add new Word to Database
        private void btn_Add_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txb_ID.Text);
            string german = txb_German.Text;
            string meaning = txb_Meaning.Text;
            string details = txb_Details.Text;


            try
            {
                //bool re;
                //Add ID, German, Mean and DetailMeaning
                
                //Wenn ein Word in Deutsch existiert , gibt Nachricht aus
                DataTable dt = cm.Search(SQLdata.sql,TableProcedure.Lookup_dict.ToString(), german);
                if (dt != null)
                {
                    MessageBox.Show("This Word exists");
                }
                else
                {
                    cm.AddToDB(SQLdata.sql, TableProcedure.add_dict.ToString(), id, german, meaning, details);
                    MessageBox.Show("Add Success");

                }
               //Wenn ID douple ist=> Fehler in Database, weil ID Primary key ist, jedes Wort nur 1 ID hat
                
            }
            catch (Exception)
            {
                MessageBox.Show("Can not add this ID, dopple ID!");
            }
            //uptaten Daten danach
            MessageBox.Show("Click Update to update Data!");
            clear();
        }
        #endregion

        #region Loeschen Wort 
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txb_ID.Text);
            try
            {
                cm.DeleteData(TableProcedure.Delete_dict.ToString(), id);
                //string id = txb_ID.Text;
                //SqlHelper.SqlHelper.ExecuteNonQuery(SQLdata.sql, "Delete_dict", id);
                MessageBox.Show("Delete Successful!");

            }
            catch (Exception )
            {
                MessageBox.Show("Delete cann not success!");
            }
            loadData();
        }
        #endregion
        #region Data bearbeiten
        /*User bearbeitet Data durch TextBox
         * 
         * */
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txb_ID.Enabled = true;
            try
            {
                int id = int.Parse(txb_ID.Text);
                string german = txb_German.Text;
                string meaning = txb_Meaning.Text;
                string details = txb_Details.Text;
                cm.EditData(SQLdata.sql, TableProcedure.Edit_dict.ToString(), id, german, meaning, details);
                MessageBox.Show("Edit Successful!");
                loadData();
                clear();

            }
            catch (Exception )
            {
                MessageBox.Show("Edit cann not success!");
            }

        }

        //loeschen alle in Textbox
        private void clear()
        {
            txb_ID.Text = txb_German.Text = txb_Meaning.Text = txb_Details.Text = "";
        }
        #endregion
        private void btn_Update_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();


        }

        private void ManagementData_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region Search Vokabel
        //User checkt, ob Vokabel bereits vorhanden ist 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string german = txb_German.Text;
            //Verweisen zum VNMean und Details Column
            string mean = Column.VNShort.ToString();
            string detail = Column.VNLong.ToString();
            txb_ID.Text = "";
            //rufen in Proc Lookup_dict ab
            DataTable re = cm.Search(SQLdata.sql,TableProcedure.Lookup_dict.ToString(), german);
            try
            {
                if (re != null) //wenn ein Ergebnis gefunden ist, zeigt die Bedeutungen und Kontext
                {
                    txb_Meaning.Text = re.Rows[0][mean].ToString();
                    txb_Details.Text = re.Rows[0][detail].ToString();
                }
                else
                {
                    MessageBox.Show("Not found. That word are still not be created !");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error DataSystemConnection");
            }
        }
        #endregion
    }
}
