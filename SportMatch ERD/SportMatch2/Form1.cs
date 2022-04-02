using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportMatch2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Match' table. You can move, or remove it, as needed.
            this.matchTableAdapter.Fill(this.dataSet1.Match);
            // TODO: This line of code loads data into the 'dataSet1.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.dataSet1.Ticket);
            // TODO: This line of code loads data into the 'dataSet1.Sport_Fans' table. You can move, or remove it, as needed.
            this.sport_FansTableAdapter.Fill(this.dataSet1.Sport_Fans);

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            int Fan_no, Match_no;
            DateTime birthday;
            DateTime.TryParse(textBox_birthday.Text, out birthday);
            this.sport_FansTableAdapter.Insert(textBox_name.Text, textBox_lastName.Text, textBox_gender.Text, birthday);
            Match_no = (int)comboBox1.SelectedValue;



            

            Fan_no = (int)dataGridView_sportFans.Rows[dataGridView_sportFans.Rows.Count - 2].Cells[0].Value + 1;
            
            this.ticketTableAdapter.Insert(Fan_no, Match_no);

            this.sport_FansTableAdapter.Fill(this.dataSet1.Sport_Fans);
            this.matchTableAdapter.Fill(this.dataSet1.Match);
            this.ticketTableAdapter.Fill(this.dataSet1.Ticket);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int Sel_ID=0;
            int Sel_ID2 = 0;
            int.TryParse(dataGridView_sportFans.Rows[dataGridView_sportFans.CurrentRow.Index].Cells[0].Value.ToString(), out Sel_ID);
            for (int i = 0; i < dataGridView_ticket.Rows.Count - 1; i++)
            {
                if ((int)dataGridView_ticket.Rows[i].Cells[1].Value == Sel_ID)
                {
                    Sel_ID2 = (int)dataGridView_ticket.Rows[i].Cells[1].Value;
                }
                
                this.ticketTableAdapter.DeleteQuery(Sel_ID2);

                this.sport_FansTableAdapter.DeleteSportFans(Sel_ID);

                this.sport_FansTableAdapter.Fill(this.dataSet1.Sport_Fans);
                this.ticketTableAdapter.Fill(this.dataSet1.Ticket);

                




            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int IDX;
            int Sel_ID = 0;

            int fanno;
            fanno = (int)comboBox1.SelectedValue;

            IDX = dataGridView_sportFans.CurrentRow.Index;
            int.TryParse(dataGridView_sportFans.Rows[IDX].Cells[0].Value.ToString(), out Sel_ID);
            DateTime birthday;
            DateTime.TryParse(textBox_birthday.Text, out birthday);
            this.sport_FansTableAdapter.UpdateQuery(textBox_name.Text,textBox_lastName.Text,textBox_gender.Text,birthday,Sel_ID,1);
            this.ticketTableAdapter.UpdateQuery(fanno, fanno,1);
            MessageBox.Show("Updated");
            this.sport_FansTableAdapter.Fill(this.dataSet1.Sport_Fans);
            this.ticketTableAdapter.Fill(this.dataSet1.Ticket);
        }
    }
}
