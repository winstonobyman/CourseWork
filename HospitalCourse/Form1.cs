using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace HospitalCourse
{
    public partial class Form1 : Form
    {

        FileStream fs;
        XmlSerializer xs; 


        public Form1()
        {
            InitializeComponent();
        }

        // Список больниц
        public  List<Hospital> listH = new List<Hospital>();

        // Список отделений
        List<Department> listD = new List<Department>();

        public void Form1_Load(object sender, EventArgs e)
        {

            // Список пациентов отделения "Хирургия"
            List<Patient> listP = new List<Patient>();
            listP.Add(new Patient {Name = "Дуглас", Surname = "МакАртур", Birth = new DateTime(1923, 12, 10), Diag = "Ножевое ранение", RoomN = 10 });
            listP.Add(new Patient {Name = "Хирохито", Surname = "Ямато", Birth = new DateTime(1988, 11, 23), Diag = "Перелом ноги", RoomN = 11 });
            listP.Add(new Patient {Name = "Джейме", Surname = "Ланкастер", Birth = new DateTime(1990, 10, 21), Diag = " Перелом руки", RoomN = 12 });

            listD.Add(new Department { Name = "Хирургия", Head = "Гевара", Phone = "8(985)-661-23-43", MaxRoom = 230, List = listP });
            
            // Список пациентов отделения "Кардиология"
            listP = new List<Patient>();
            listP.Add(new Patient { Name = "Уоллис", Surname = "Симпсон", Birth = new DateTime(1978, 12, 10), Diag = "Порог сердца", RoomN = 1 });
            listP.Add(new Patient { Name = "Отто", Surname = "фон Габсбург", Birth = new DateTime(1990, 12, 10), Diag = "Тахикардия", RoomN = 2 });
            listP.Add(new Patient { Name = "Эдуард", Surname = "Виндзор", Birth = new DateTime(1943, 12, 10), Diag = "Стеноз", RoomN = 3 });

            listD.Add(new Department { Name = "Кардиология", Head = "Людовик", Phone = "8(981)643-17-15", MaxRoom = 390, List = listP });
            
            // Список пациентов отделения "Реанимация"
            listP = new List<Patient>();
            listP.Add(new Patient { Name = "Эдуард", Surname = "Носмонов", Birth = new DateTime(1943, 12, 10), Diag = "Острый психоз", RoomN = 4 });
            listP.Add(new Patient { Name = "Егор", Surname = "Шметов", Birth = new DateTime(1988, 12, 10), Diag = "Отсутствие плана", RoomN = 5 });
            listP.Add(new Patient { Name = "Захар", Surname = "Пристепин", Birth = new DateTime(1918, 12, 10), Diag = "Российская проза", RoomN = 43 });

            listD.Add(new Department { Name = "Реанимация", Head = "Дегрелль", Phone = "8372", MaxRoom = 440, List = listP });

            //Добавляем больницу

            listH.Add(new Hospital { Name = "Больница св. Патрика", Address = "Дублин", Foundation = new DateTime(1202, 11, 10), HospHead = "Гиппократ", List = listD });

            listD = new List<Department>();

            listP = new List<Patient>();
            listP.Add(new Patient { Name = "Болвар", Surname = "Фордрагон", Birth = new DateTime(1000,11,1), Diag = "Заражение", RoomN = 123 });
            listP.Add(new Patient { Name = "Иллидан", Surname = "Стормрейдж", Birth = new DateTime(982, 11, 23), Diag = "Бессоница", RoomN = 123 });

            listD.Add(new Department { Name = "Лунный колодец", Head = "Тиранда", Phone = "9000", MaxRoom = 1000, List = listP });

            listP = new List<Patient>();
            listP.Add(new Patient { Name = "Сандор", Surname = "Клиган", Birth = new DateTime(1234,11, 14), Diag = "Ожог", RoomN = 123 });
            listP.Add(new Patient { Name = "Грегор", Surname = "Клиган", Birth = new DateTime(1234, 11, 14), Diag = "Отравление", RoomN = 123 });

            listD.Add(new Department { Name = "Красный Замок", Head = "Пицелль", Phone = "9321", MaxRoom = 3000, List = listP });

            listH.Add(new Hospital { Name = "Фентези - госпиталь", Address = "Дублин", Foundation = new DateTime(1202, 11, 10), HospHead = "Гиппократ", List = listD });

            hospitalBindingSource.DataSource = listH;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddHosp addhosp = new AddHosp();
            addhosp.form1 = this;
            addhosp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Hospital>));

            using (FileStream fs = new FileStream("HospStat.xml", FileMode.OpenOrCreate))
            {
                xs.Serialize(fs, listH);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.CurrentCell.RowIndex;
            departmentBindingSource.DataSource = listH[n].List;
            departmentBindingSource.ResetCurrentItem();
            hospitalBindingSource.ResetCurrentItem();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n1 = dataGridView1.CurrentCell.RowIndex;
            int n2 = dataGridView2.CurrentCell.RowIndex;
            patientBindingSource.DataSource = listH[n1].List[n2].List;
        }
    }
}
