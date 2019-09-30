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

namespace entity_framework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB_128040_practiceEntities db = new DB_128040_practiceEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ntmfetch_Click(object sender, RoutedEventArgs e)
        {
            if (txtstudent.Text == string.Empty)
            {
                foreach (var student in db.Students)
                {
                    string temp = $"({student.LastName}, {student.FirstName}, likes {student.FavoriteColor})";
                    fetchlst.Items.Add(temp);
                }
            }
            else
            {
                int id; 
                if (Int32.TryParse(txtstudent.Text, out id) == true)
                {
                    db.Students.Where(student => student.StudentID == id);
                    //foreach ( var student in db.Students)
                    //{
                    //    if (student.StudentID == id)
                    //    {
                    //        string temp = $"{student.LastName}, {student.FirstName}, ({student.FavoriteColor})";
                    //        fetchlst.Items.Add(temp);
                    //    }
                    //}
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
