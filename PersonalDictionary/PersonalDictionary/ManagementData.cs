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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //Variablen deklarieren (ID,German, Meaning, Details)
                string id = txb_ID.Text;
                string german = txb_German.Text;
                string meaning = txb_Meaning.Text;
                string details = txb_Details.Text;

                //uebermitteln zum SQL mit Hilfe von SqlHelper
                SqlHelper.SqlHelper.ExecuteNonQuery(SQLdata.str, "add_dict", id, german, meaning, details);
                MessageBox.Show("Add Successful!");
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadData()
        {
            gridItemData.DataSource = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.str, "select_dict").Tables[0];
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
                SqlHelper.SqlHelper.ExecuteNonQuery(SQLdata.str, "Delete_dict", id);
                
            }catch (Exception ex)
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
                SqlHelper.SqlHelper.ExecuteNonQuery(SQLdata.str, "Edit_dict", id, german, meaning, details);
               
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
    }
}
