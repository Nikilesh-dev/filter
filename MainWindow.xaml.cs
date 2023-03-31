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

namespace Linq_filter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<product> list = new List<product>();
        public MainWindow()
        {
            InitializeComponent();
            list.Add(new product { ID = 1011, Pname = "Neck T-shirt", prize = 600, rating = 5, purchase = 180, ship = "Prime" });
            list.Add(new product { ID = 1012, Pname = "Neck Hoodie T-shirt", prize = 1200, rating = 2, purchase = 100, ship = "Prime" });
            list.Add(new product { ID = 1013, Pname = "Sleeve", prize = 300, rating = 1, purchase = 80, ship = "Non-Prime" });
            list.Add(new product { ID = 1014, Pname = "Track pant", prize = 800, rating = 5, purchase = 190, ship = "Prime" });
            list.Add(new product { ID = 1015, Pname = "Checked shirt", prize = 1600, rating = 4, purchase = 160, ship = "Non-Prime" });
            list.Add(new product { ID = 1016, Pname = "Jeans", prize = 1100, rating = 4, purchase = 230, ship = "Non-Prime" });
            list.Add(new product { ID = 1017, Pname = "Denim shirt", prize = 1400, rating = 4, purchase = 160, ship = "Prime" });
            list.Add(new product { ID = 1018, Pname = "Cotton shirt", prize = 900, rating = 2, purchase = 90, ship = "Non-Prime" });
            list.Add(new product { ID = 1019, Pname = "Cotton pant", prize = 1300, rating = 5, purchase = 290, ship = "Prime" });
            list.Add(new product { ID = 1010, Pname = "Boxer lower", prize = 400, rating = 4, purchase = 110, ship = "Non-Prime" });
            list.Add(new product { ID = 10111, Pname = "Plain Hoodie", prize = 1900, rating = 4, purchase = 290, ship = "Non-Prime" });
            list.Add(new product { ID = 10112, Pname = "Marvel T-shirt", prize = 600, rating = 3, purchase = 160, ship = "Prime" });
            list.Add(new product { ID = 10112, Pname = "plain shirt", prize = 900, rating = 2, purchase = 90, ship = "Non-Prime" });
            list.Add(new product { ID = 10114, Pname = "Gym track", prize = 1600, rating = 5, purchase = 190, ship = "Prime" });
            list.Add(new product { ID = 10115, Pname = "lower", prize = 400, rating = 4, purchase = 110, ship = "Non-Prime" });
            listview.ItemsSource = list;

        }

        private void prosearch_Click(object sender, RoutedEventArgs e)
        {
            
            if (checkhigh.IsChecked == true && htol.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkhigh.IsChecked == true && htol.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Non-Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkhigh.IsChecked == true && ltoh.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (checkhigh.IsChecked == true && ltoh.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Non-Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (checkAver.IsChecked == true && htol.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && htol.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Non-Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && ltoh.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3 )&& sel.ship == "Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (checkAver.IsChecked == true && ltoh.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Non-Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (below.IsChecked == true && htol.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1 )&& sel.ship == "Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && htol.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1) && sel.ship == "Non-Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && ltoh.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1) && sel.ship == "Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (below.IsChecked == true && ltoh.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1) && sel.ship == "Non-Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }

            else if (checkhigh.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkhigh.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Non-Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where( sel.rating == 4 || sel.rating == 3 )&& sel.ship == "Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3 )&& sel.ship == "Non-Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            select sel; 
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1 )&& sel.ship == "Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1) && sel.ship == "Non-Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (htol.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            orderby sel.prize descending
                            where sel.ship == "Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;

                listview.ItemsSource = value;
            }
            else if (htol.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            orderby sel.prize descending
                            where sel.ship == "Non-Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;

                listview.ItemsSource = value;
            }
            else if (ltoh.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            orderby sel.prize
                            where sel.ship == "Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (ltoh.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list
                            orderby sel.prize
                            where sel.ship == "Non-Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (prime.IsChecked == true  && txtproductsearch != null)
            {
                var value = from sel in list

                            where sel.ship == "Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (nonprime.IsChecked == true  && txtproductsearch != null)
            {
                var value = from sel in list

                            where sel.ship == "Non-Prime" && sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (frequent.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list

                            where sel.purchase > 150 && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }else if(checkhigh.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list

                            where sel.rating == 5  && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list

                            where( sel.rating == 4 || sel.rating ==3) && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && txtproductsearch != null)
            {
                var value = from sel in list

                            where (sel.rating == 2 || sel.rating == 1) && sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }
            else if(txtproductsearch != null )
            {
                var value = from sel in list
                            where sel.Pname.Contains(txtproductsearch.Text)
                            select sel;
                listview.ItemsSource = value;
            }else if (htol.IsChecked == true)
            {
                var value = from sel in list
                            where sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize descending 
                            select sel;

                listview.ItemsSource = value;
            }
            else if (ltoh.IsChecked == true)
            {
                var value = from sel in list
                            where sel.Pname.Contains(txtproductsearch.Text)
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;
            }
        }

        private void prizecheck_Click(object sender, RoutedEventArgs e)
        {

            int great = Convert.ToInt32( txtRone.Text);
            int less = Convert.ToInt32( txtRtwo.Text);
            //var valu = from sel in list
            //            where sel.prize >= great  && sel.prize <= less
            //            select sel;
          
             if (checkhigh.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 &&( sel.prize >= great && sel.prize <= less)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && (sel.prize >= great && sel.prize <= less)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1) && (sel.prize >= great && sel.prize <= less)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkhigh.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Prime" && (sel.prize >= great && sel.prize <= less)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkhigh.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Non-Prime" && (sel.prize >= great && sel.prize <= less)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Prime" && (sel.prize >= great && sel.prize <= less)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Non-Prime" && (sel.prize >= great && sel.prize <= less)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1) && sel.ship == "Prime" && (sel.prize >= great && sel.prize <= less)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1) && sel.ship == "Non-Prime" && (sel.prize >= great && sel.prize <= less)
                            select sel;
                listview.ItemsSource = value;
            }
           
            else if (prime.IsChecked == true)
            {
                var value = from sel in list

                            where sel.ship == "Prime" && (sel.prize >= great && sel.prize <= less)
                            select sel;
                listview.ItemsSource = value;
            }
            else if (nonprime.IsChecked == true)
            {
                var value = from sel in list

                            where sel.ship == "Non-Prime" && (sel.prize >= great && sel.prize <= less)
                            select sel;
                listview.ItemsSource = value;
            }else if(txtproductsearch.Text != null)
            {
                var value = from sel in list

                            where sel.Pname.Contains(txtproductsearch.Text) && (sel.prize >= great && sel.prize <= less)
                            select sel;
                listview.ItemsSource = value;
            }else if(great != null && less != null)
            {
                var value = from sel in list

                            where sel.prize >= great && sel.prize <= less
                            select sel;
                listview.ItemsSource = value;
            }
        }

        private void htol_Checked(object sender, RoutedEventArgs e)
        {
            if (htol.IsChecked == true)
            {
                var value = from sel in list
                            orderby sel.prize descending
                            select sel;

                listview.ItemsSource = value;
            }
            else if (ltoh.IsChecked == true)
            {
                var value = from sel in list
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;
            }

        }

        private void checkhigh_Checked(object sender, RoutedEventArgs e)
        {

            if (checkhigh.IsChecked == true && htol.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkhigh.IsChecked == true && ltoh.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (checkAver.IsChecked == true && htol.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 4 || sel.rating == 3
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && ltoh.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 4 || sel.rating == 3
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (below.IsChecked == true && htol.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 2 || sel.rating == 1
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && ltoh.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 2 || sel.rating == 1
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }

            else if (checkhigh.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 4 || sel.rating == 3
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 2 || sel.rating == 1
                            select sel;
                listview.ItemsSource = value;
            }
        }

        private void prime_Checked(object sender, RoutedEventArgs e)
        {

            if (checkhigh.IsChecked == true && htol.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Prime"
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkhigh.IsChecked == true && htol.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Non-Prime"
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkhigh.IsChecked == true && ltoh.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Prime"
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (checkhigh.IsChecked == true && ltoh.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Non-Prime"
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (checkAver.IsChecked == true && htol.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Prime"
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && htol.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Non-Prime"
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && ltoh.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Prime"
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (checkAver.IsChecked == true && ltoh.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Non-Prime"
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (below.IsChecked == true && htol.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1 )&& sel.ship == "Prime"
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && htol.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1 )&& sel.ship == "Non-Prime"
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && ltoh.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1) && sel.ship == "Prime"
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (below.IsChecked == true && ltoh.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1) && sel.ship == "Non-Prime"
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }

            else if (checkhigh.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Prime"
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkhigh.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Non-Prime"
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            where( sel.rating == 4 || sel.rating == 3) && sel.ship == "Prime"
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Non-Prime"
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1) && sel.ship == "Prime"
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1) && sel.ship == "Non-Prime"
                            select sel;
                listview.ItemsSource = value;
            }
            else if (htol.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            orderby sel.prize descending where sel.ship =="Prime"
                            select sel;

                listview.ItemsSource = value;
            }
            else if (htol.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            orderby sel.prize descending
                            where sel.ship == "Non-Prime"
                            select sel;

                listview.ItemsSource = value;
            }
            else if (ltoh.IsChecked == true && prime.IsChecked == true)
            {
                var value = from sel in list
                            orderby sel.prize
                            where sel.ship == "Prime"
                            select sel;
                listview.ItemsSource = value;
            }
            else if (ltoh.IsChecked == true && nonprime.IsChecked == true)
            {
                var value = from sel in list
                            orderby sel.prize
                            where sel.ship == "Non-Prime"
                            select sel;
                listview.ItemsSource = value;
            }else if (prime.IsChecked == true)
            {
                var value = from sel in list
                         
                            where sel.ship == "Prime"
                            select sel;
                listview.ItemsSource = value;
            }
            else if (nonprime.IsChecked == true)
            {
                var value = from sel in list

                            where sel.ship == "Non-Prime"
                            select sel;
                listview.ItemsSource = value;
            }
        }

        private void frequent_Checked(object sender, RoutedEventArgs e)
        {
            if (checkhigh.IsChecked == true && htol.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Prime" && sel.purchase > 150
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkhigh.IsChecked == true && htol.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Non-Prime" && sel.purchase > 150
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkhigh.IsChecked == true && ltoh.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Prime" && sel.purchase > 150
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (checkhigh.IsChecked == true && ltoh.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Non-Prime" && sel.purchase > 150
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (checkAver.IsChecked == true && htol.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3 )&& sel.ship == "Prime" && sel.purchase > 150
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && htol.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3 )&& sel.ship == "Non-Prime" && sel.purchase > 150
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && ltoh.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Prime" && sel.purchase > 150
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (checkAver.IsChecked == true && ltoh.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Non-Prime" && sel.purchase > 150 
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (below.IsChecked == true && htol.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1 )&& sel.ship == "Prime" && sel.purchase > 150
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && htol.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1) && sel.ship == "Non-Prime" && sel.purchase > 150
                            orderby sel.prize descending
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && ltoh.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1) && sel.ship == "Prime" && sel.purchase > 150
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }
            else if (below.IsChecked == true && ltoh.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1 )&& sel.ship == "Non-Prime" && sel.purchase > 150
                            orderby sel.prize
                            select sel;
                listview.ItemsSource = value;

            }

            else if (checkhigh.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Prime" && sel.purchase > 150
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkhigh.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where sel.rating == 5 && sel.ship == "Non-Prime" && sel.purchase > 150
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Prime" && sel.purchase > 150
                            select sel;
                listview.ItemsSource = value;
            }
            else if (checkAver.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 4 || sel.rating == 3) && sel.ship == "Non-Prime" && sel.purchase > 150
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true )
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1 )&& sel.ship == "Prime" && sel.purchase > 150
                            select sel;
                listview.ItemsSource = value;
            }
            else if (below.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            where (sel.rating == 2 || sel.rating == 1 )&& sel.ship == "Non-Prime" && sel.purchase > 150
                            select sel;
                listview.ItemsSource = value;
            }
            else if (htol.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            orderby sel.prize descending
                            where sel.ship == "Prime" && sel.purchase > 150
                            select sel;

                listview.ItemsSource = value;
            }
            else if (htol.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            orderby sel.prize descending
                            where sel.ship == "Non-Prime" && sel.purchase > 150
                            select sel;

                listview.ItemsSource = value;
            }
            else if (ltoh.IsChecked == true && prime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            orderby sel.prize
                            where sel.ship == "Prime" && sel.purchase > 150
                            select sel;
                listview.ItemsSource = value;
            }
            else if (ltoh.IsChecked == true && nonprime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list
                            orderby sel.prize
                            where sel.ship == "Non-Prime" && sel.purchase > 150
                            select sel;
                listview.ItemsSource = value;
            }
            else if (prime.IsChecked == true && frequent.IsChecked == true)   
            {
                var value = from sel in list

                            where sel.ship == "Prime" && sel.purchase > 150
                            select sel;
                listview.ItemsSource = value;
            }
            else if (nonprime.IsChecked == true && frequent.IsChecked == true)
            {
                var value = from sel in list

                            where sel.ship == "Non-Prime" && sel.purchase > 150
                            select sel;
                listview.ItemsSource = value;
            }else if (frequent.IsChecked == true)
            {
                var value = from sel in list

                            where  sel.purchase > 150
                            select sel;
                listview.ItemsSource = value;
            }
        }
    } 
       
    }

