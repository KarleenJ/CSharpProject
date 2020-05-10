using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace ClubRegistration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        string ConStr = ConfigurationManager.ConnectionStrings["clubDB"].ConnectionString;

        public MainWindow()
        {
            InitializeComponent();
            //BindDatGrid();

            List<Member> members = new List<Member>();
            members.Add(new Member { Name = "Tobio Kageyama", Position = "Setter", ShirtNum = 9, ShirtSize="M",Phone = "123-456-7889" }) ;
            members.Add(new Member { Name = "Shoyo Hinata", Position = "Middle", ShirtNum = 10, ShirtSize = "S", Phone = "888-456-1189" });

            memberList.ItemsSource = members;
        }
        


        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Member player = new Member();


            player.Name = nameTb.Text;
            player.Position = postionTb.Text;
            player.ShirtNum = Int32.Parse(uniNumTb.Text);
            player.ShirtSize = uniSizeTb.Text;
            player.Phone = phoneTb.Text;
            player.Email = emailTb.Text;

            members.Add(player);


        }


        //public void BindDatGrid()
        //{
        //    //set Connection 
        //    SqlConnection connection = new SqlConnection(ConStr);
        //    //Select Query to fetch data
        //    SqlDataAdapter da = new SqlDataAdapter("select * from members", ConStr);

        //    //we need a data container
        //    DataSet ds = new DataSet();
        //    //Fill Data inside ds => its a virtual database
        //    da.Fill(ds, "members");

        //    memberList.ItemsSource = ds.Tables["members"].DefaultView;
        //}
    }
}
