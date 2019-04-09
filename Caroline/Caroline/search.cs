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
    public partial class search : Form
    {
        // FileStream fs;
        // private DataTable dt;
        List<seat> seats = new List<seat>();
        public search(FileStream fs, DataTable dt, string searchItem)
        {
            InitializeComponent();
            

            
            seats = SeatDB.ReadSeatList(fs, dt);

            SeatDB.QuickSort(seats, 0 , seats.Count-1);
           
           int position = SeatDB.BinarySearch(seats, searchItem );
            string Item ="";

            if (position != -1)
            {
                    Item = seats[position].Name;
                                                
            }

            lbxList.Items.Add("Student" + "\t" + "Across" + "\t" + "Down");
            
            foreach (seat s in seats)

            {
                if (s.Name != "" && s.Name!= "Front Desk")

                {
                   
                    if (s.Name.CompareTo(Item) == 0) {

                        lbxList.Items.Add(s.Name + "\t" + s.Row + "\t" + s.Col);
                        lbxList.SelectedItem = (s.Name + "\t" + s.Row + "\t" + s.Col);
                        txbSearch.Text = s.Name;

                    }else
                    lbxList.Items.Add(s.Name +"\t"+ s.Row + "\t" + s.Col);

                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbList_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //lbxList.Items.Add(info);

        }
    }
}
