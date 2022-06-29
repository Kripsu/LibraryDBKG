using Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace LibraryDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Book> _books;

        public MainWindow()
        {
            InitializeComponent();


            using (var ctx = new LibraryContext())
            {
                _books = new ObservableCollection<Book>(ctx.Books);

                bookDisplay.ItemsSource = _books;
            }


        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(var ctx = new LibraryContext())
            {
                var bookToAdd = new Book
                {

                    Description = "opis dodawanej ksiazki",
                    BookName = "nazwa dodawanej ksiazki"
                };

                ctx.Books.Add(bookToAdd);
                ctx.SaveChanges();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var ctx = new LibraryContext())
            {
                if (bookDisplay.SelectedItem != null)
                {
                    var bookToModify = bookDisplay.SelectedItem as Book;
                    var modifiedBook = new Book
                    {
                        BookName = "modified book name"
                    };
                    ctx.Books.Update(bookToModify);
                    ctx.SaveChanges();
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (var ctx = new LibraryContext())
            {
                if (bookDisplay.SelectedItem != null)
                {
                    var bookToRemove = bookDisplay.SelectedItem as Book;
                    ctx.Books.Remove(bookToRemove);
                    ctx.SaveChanges();
                }
            }
        }

    }
}
