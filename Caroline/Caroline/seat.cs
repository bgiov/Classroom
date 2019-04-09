using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caroline
{
    class seat
    {
        string name;
        int row;
        int col;

        public seat()
        {
            this.name = "";
            this.row = 0;
            this.col = 0;
        }
        
        public seat(string name, int row, int col)
        {
            this.name = name;
            this.row =row;
            this.col = col;
        }

        public static int Size()
        {
            return (2 * 20 + 4 * 1 + 4 * 1);
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value;}
        }
        public int Row
        {
            get { return this.row; }
            set { this.row = value; }
        }
        public int Col
        {
            get { return this.col; }
            set { this.col = value; }
        }
    }
    class Info
    {
        string teacher;
        string grade;
        string room;
        string date;

        public Info(string teacher, string grade, string room, string date)
        {
            this.teacher = teacher;
            this.grade = grade;
            this.room = room;
            this.date = date;

        }
        public string Teacher
        {
            get { return this.teacher; }
            set { this.teacher = value; }
        }
        public string Room
        {
            get { return this.room; }
            set { this.room = value; }
        }
        public string Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }
        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public static int Size()
        {
            return (4 * 20);
        }
    }
}
