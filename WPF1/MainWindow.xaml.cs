//Marissa Munoz
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

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string personName = txtName.Text;
            string personAddress = txtAddress.Text;
            int personZip = Convert.ToInt16(txtZipcode.Text);

            //string name, address;

            //ef : EntryForm; class is entryform name is ef
            //EntryForm ef = new EntryForm();
            //EntryForm ef2 = new EntryForm(txtName.Text, txtAddress.Text, Convert.ToInt16(txtZipCode.Text));


            //check to see if the person typed their name, if not ask them to do 
            //it again and move cursor to text spot
            //  bool isFormValid = true;
            // if(name == "" || name == string.Empty)
            // {
            //      MessageBox.Show("please input your name");
            //      txtName.Focus();
            //      //return;
            //      isFormValid = false;
            //  }
            // if(address == "")
            //  {
            //      MessageBox.Show("Please input your address");
            //      isFormValid = false;
            //  }
            //  if(isFormValid == false)
            //  {
            //      
            //  }

            Blahblahbla person = new Blahblahbla();

            person.Name = personName;
            person.Address = personAddress;
            person.ZipCode = personZip;

            LstBox.Items.Add(person.ToString());
        }
    }
}
