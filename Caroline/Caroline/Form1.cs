using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caroline
{
    public partial class Form1 : Form

    {
        private static int NofRows = 20;
        private static int NofCols = 10;
        FileStream fs;
        private DataTable dt;


        public Form1()
        {
            InitializeComponent();
            //  build the grid view
            dt = new DataTable();

            createLayout();




            if ((fs = SeatDB.FileOpen()) != null)
            {
                Info info = SeatDB.ReadSeats(fs, dt);
                tbxTeacher.Text = info.Teacher;
                tbxGrade.Text = info.Grade;
                tbxRoom.Text = info.Room;
                tbxDate.Text = info.Date;
            }

        }








        private void createLayout()
        {

            for (int col = 0; col < NofCols; col++)
                dt.Columns.Add(col.ToString(), typeof(string));

            for (int row = 0; row < NofRows; row++)
                dt.Rows.Add();

            dgvClass.DataSource = dt;



        }

        private void createTable()
        {
            DataTable dt = new DataTable();
            for (int col = 0; col < 10; col++)
                dt.Columns.Add(col.ToString(), typeof(string));
            for (int row = 0; row < 20; row++)
                dt.Rows.Add();

            dgvClass.DataSource = dt;

        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            string teacher = tbxTeacher.Text;
            string grade = tbxGrade.Text;
            string room = tbxRoom.Text;
            string date = tbxDate.Text;

            Info info = new Info(teacher, grade, room, date);
            if ((fs = SeatDB.WriteSeats(fs, dt, info)) != null)
                SeatDB.FileClose(fs);
            else
                MessageBox.Show("file Write failed");
            this.Close();
        }

        private void dgvClass_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tableCreation();
        }




        public void tableCreation()
        {
            // set color of desks
            var deskColor = Color.FromArgb(102, 204, 255);


            // set color of seats
            var seatColor = Color.FromArgb(213, 236, 242);



            //teachers desk
            for (int i = 3; i < 7; i++)
            {
                //set teachers desk color
                dgvClass.Rows[1].Cells[i].Style.BackColor = deskColor;
                //make teacher editable
                dgvClass.Rows[0].Cells[4].ReadOnly = true;
                dgvClass.Rows[0].Cells[4].Style.BackColor = seatColor;
            }

            //students desk color
            for (int r = 4; r < 14; r = r + 3)
            {

                for (int c = 1; c < 8; c++)
                {
                    dgvClass.Rows[r].Cells[c].Style.BackColor = deskColor;

                    c++;
                    dgvClass.Rows[r].Cells[c].Style.BackColor = deskColor;
                    c++;
                }
            }


            for (int i = 0; i < 9; i++)
            {
                dgvClass.Columns[i].ReadOnly = true;
            }

            //make students desk editable
            for (int r = 5; r < 15; r = r + 3)
            {
                for (int c = 1; c < 8; c++)
                {
                    dgvClass.Rows[r].Cells[c].ReadOnly = false;
                    dgvClass.Rows[r].Cells[c].Style.BackColor = seatColor;
                    c++;
                    dgvClass.Rows[r].Cells[c].ReadOnly = false;
                    dgvClass.Rows[r].Cells[c].Style.BackColor = seatColor;
                    c++;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchItem = tbxSearch.Text;
            search find = new search(fs, dt, searchItem);
            find.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dgvClass.DataSource = null;
            this.dgvClass.Rows.Clear();
            dt = new DataTable();
            this.createLayout();
            this.createTable();
            this.tableCreation();



        }


       


        private void saveBtn_Click(object sender, EventArgs e)
        {
            string teacher = tbxTeacher.Text;
            string grade = tbxGrade.Text;
            string room = tbxRoom.Text;
            string date = tbxDate.Text;

            Info info = new Info(teacher, grade, room, date);
            if ((fs = SeatDB.WriteSeats(fs, dt, info)) != null)
                SeatDB.FileClose(fs);
          
            else
                MessageBox.Show("file Write failed");


        }

        //public static FileStream FileOpen()
        //{
        //    FileStream fs = null;
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.Title = "Open File";
        //    ofd.Filter = "Binary files (*dat) | *.dat | All Files (*.*) |*.*";
        //    DialogResult dr = ofd.ShowDialog();
        //    if (dr == DialogResult.OK)
        //    {
        //        fs = new FileStream(ofd.FileName.TrimEnd(),
        //            FileMode.OpenOrCreate, FileAccess.ReadWrite);
               
        //    }
        //    return fs;
        //}

        private void rafBtn_Click(object sender, EventArgs e)
        {


            

        }

    }
}
    
 

























