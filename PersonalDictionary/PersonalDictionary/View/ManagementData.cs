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
using PersonalDictionary.Controller;
namespace PersonalDictionary
{
    public partial class ManagementData : Form
    {
        //Enums
       
        public ManagementData()
        {
            InitializeComponent();
            //automatisch Data einladen , wenn Form fortfuehrt
            loadData();
        }
        ControllerData cd = new ControllerData();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //Variablen deklarieren (ID,German, Meaning, Details)
                int id = int.Parse(txb_ID.Text);
                string german = txb_German.Text;
                string meaning = txb_Meaning.Text;
                string details = txb_Details.Text;

                //uebermitteln zum SQL mit Hilfe von SqlHelper
                //SqlHelper.SqlHelper.ExecuteNonQuery(SQLdata.sql, "add_dict", id, german, meaning, details);
                cd.Add(id, german, meaning, details);
                MessageBox.Show("Add Successful!");
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadData()
        {
            gridItemData.DataSource = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "select_dict").Tables[0];
        }

        
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txb_ID.Text;
                SqlHelper.SqlHelper.ExecuteNonQuery(SQLdata.sql, "Delete_dict", id);
                MessageBox.Show("Delete Successful!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txb_ID.Text;
                string german = txb_German.Text;
                string meaning = txb_Meaning.Text;
                string details = txb_Details.Text;
                SqlHelper.SqlHelper.ExecuteNonQuery(SQLdata.sql, "Edit_dict", id, german, meaning, details);
                MessageBox.Show("Edit Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            loadData();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            
            cd.Back();
            this.Hide();


        }
    }
}
