using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caroline
{    
    class SeatDB
           
    {
        private static int NofRows = 20;
        private static int NofCols = 10;
        

        public static FileStream FileOpen()
        {
            FileStream fs = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";
            ofd.Filter = "Binary files (*dat) | *.dat | All Files (*.*) |*.*";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                fs = new FileStream(ofd.FileName.TrimEnd(),
                    FileMode.OpenOrCreate, FileAccess.ReadWrite);
            }
            return fs;
        }


        public static void FileClose(FileStream fs)
        {
            fs.Flush();
            fs.Close();
        }

        public static Info ReadSeats(FileStream fs, DataTable dt)
        {
            BinaryReader br = new BinaryReader(fs);
            long nor = NofRows * NofCols;
            for (int i = 0; i < nor; i++)
            {
                fs.Seek(i * seat.Size(), 0);
                string name = br.ReadString();
                int r = br.ReadInt32();
                int c = br.ReadInt32();
                dt.Rows[r][c] = name;
               // MessageBox.Show(name);
               

            }
            long ip = NofRows * NofCols + seat.Size();
            fs.Seek(ip, 0);
            string teacher = br.ReadString();
            fs.Seek(ip + 20, 0);
            string grade = br.ReadString();
            fs.Seek(ip + 40, 0);
            string room = br.ReadString();
            fs.Seek(ip + 60, 0);
            string date = br.ReadString();

            Info info = new Info(teacher, grade, room, date);

            return info;
        }

        public static List<seat> ReadSeatList(FileStream fs, DataTable dt)
        {
            BinaryReader br = new BinaryReader(fs);
            long nor = NofRows * NofCols;
            List<seat> seats = new List<seat>();
            for (int i = 0; i < nor; i++)
            {
                fs.Seek(i * seat.Size(), 0);
                string name = br.ReadString();
                int r = br.ReadInt32();
                int c = br.ReadInt32();
                dt.Rows[r][c] = name;
                seat s = new seat(name, r, c);
              //  MessageBox.Show(s.Name);
                seats.Add(s);

            }return seats;
        }


            public static FileStream WriteSeats(FileStream fs, DataTable dt, Info info)
        {
            if (fs == null)
            {
                FileStream fn = null;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save File";
                sfd.Filter = "Binary Files (*.dat)|*.dat|All Files(*.*)|*.*";
                DialogResult dr = sfd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    fn = new FileStream(sfd.FileName.TrimEnd(),
                        FileMode.OpenOrCreate, FileAccess.ReadWrite);
                }
                fs = fn;
            }
            if (fs != null)
            {
                BinaryWriter bw = new BinaryWriter(fs);
                for (int r = 0; r <NofRows; r++)
                {
                    for (int c= 0; c <NofCols; c++)
                    {
                        int pos = r * NofCols + c;
                        fs.Seek(pos * seat.Size(), 0);
                        bw.Write(dt.Rows[r][c].ToString());
                        bw.Write(r);
                        bw.Write(c);

                    }
                }
                long ip = NofRows * NofCols * seat.Size();
                fs.Seek(ip, 0);
                bw.Write(info.Teacher);
                fs.Seek(ip + 20, 0);
                bw.Write(info.Grade);
                fs.Seek(ip + 40, 0);
                bw.Write(info.Room);
                fs.Seek(ip + 60, 0);
                bw.Write(info.Date);
                return fs;
            }
            else
            {
                return null;
            }
        }




        public static void QuickSort(List<seat> arr, int first, int last)
        {
            if (first < last)
            {
                // if there are more values to sort partition the array
                int p = Partition(arr, first, last);
                // sort the right partition
                QuickSort(arr, first, p - 1);
                // sort the left partition
                QuickSort(arr, p + 1, last);
            }
        }
        public static int Partition(List<seat> arr, int first, int last)
        {
            // set the last element as the pivot value
            string pivot = arr[last].Name;
            // set the one end of the array
            int i = first;
            // compare elements from begining to end with pivot element
            for (int j = first; j < last; j++)
            {
                if (pivot.CompareTo(arr[j].Name) >= 0)
                {
                    swap(arr[i], arr[j]);
                    i++;
                }
            }
            swap(arr[i], arr[last]);
            return i;
        }
       public static void swap(seat a, seat b)
        {
            // need to consider each field while swapping
            seat t = new seat(a.Name, a.Row, a.Col);
            a.Name = b.Name; a.Col = b.Col; a.Row = b.Row;
            b.Name = t.Name; b.Col = t.Col; b.Row = t.Row;
        }


        public static int BinarySearch(List<seat> arr, string searchItem)
        {
            // first position of the array
            int first = 0;
            // last position of the array
            int last = arr.Count - 1;
            // middle position of the array
            int mid = (first + last) / 2;
            // found or not
            bool found = false;
            // repeat until search item is found or not
            while (!found && first <= last)
            {
                // check if search item is in the middle of the array
                if (arr[mid].Name.CompareTo(searchItem) == 0)
                {
                    found = true;
                }
                // if not found move first and last to the relevant positions
                else
                {
                    if (arr[mid].Name.CompareTo(searchItem) >= 0)
                        last = mid - 1;
                    else
                        first = mid + 1;
                    mid = (first + last) / 2;
                }
            }
            if (found)
                return mid;
            else
                return -1;
        }




    }
}
