using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace demo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students= new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Generate_Click(object sender, RoutedEventArgs e)
        {
            var matNumber = Convert.ToInt32(matNo.Text);
            var cnt = Convert.ToInt32(stuToGen.Text);
            students= GenerateStudents(cnt, matNumber);
        }

        private List<Student> GenerateStudents(int cnt, int matNum)
        {
            Random rnd= new Random();
            var stu = new List<Student>();
            for (int i = 0; i < cnt; i++)
            {
                var gnd= rnd.Next(2)==0?true:false;
                stu.Add(new Student {matNumber=matNum, firstName=$"Sfn{i}",lastName=$"Sln{i}", gender=gnd });
                matNum++;

            }
            return stu;        }
    }
}
