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
using Constructors_Sosnina.Classes;

namespace Constructors_Sosnina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Classes.Student> AllStudents = RepoStudents.AllStudents();
        public int Count = 10;
        public int Step = 0;
             
        public MainWindow()
        {
            InitializeComponent();
            CreateStudent();
        }

        public void CreateStudent()
        {
            for(int iStudent = Step; iStudent < Step + Count; iStudent++)
            {
                if(AllStudents.Count > iStudent)
                {
                    parent.Children.Add(new Elements.Student(AllStudents[iStudent]));
                }
            }
            this.Step += Count;
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scroll = sender as ScrollViewer;
            double ParentHeight = parent.ActualHeight;
            double WindowHeight = scroll.ActualHeight;
            double DeltaHeight = ParentHeight - WindowHeight;

            if(DeltaHeight - scroll.VerticalOffset < 140)
                CreateStudent();
        }
    }
}
