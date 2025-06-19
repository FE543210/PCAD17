using Books.Data;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Books
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Non depency injection
        //BookContext dbcontext = new BookContext(new DbContextOptions<BookContext>());
        BookContext context;
        Book newbook = new Book();
        //depend injection
        public MainWindow(BookContext bookcontext)
        {
            InitializeComponent();
            context = bookcontext;
            GetBooks();
            AddProductGrid.DataContext = newbook;
        }
        private void GetBooks()
        {
            BookDG.ItemsSource = context.Books.ToList();
        }
        Book selectedBook;
        //public MainWindow()
        //{
        //    InitializeComponent();
        //    GetBooks();
        //}
        private void UpdateBookForEdit(object sender, RoutedEventArgs e)
        {
            selectedBook = (sender as FrameworkElement).DataContext as Book;
            UpdateBookGrid.DataContext = selectedBook;
        }
        private void DeleteBookForEdit(object sender, RoutedEventArgs e)
        {
            var book = (sender as FrameworkElement).DataContext as Book;
            if(book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
                GetBooks();
                MessageBox.Show("Book Removed!");
            }
            else
            {
                MessageBox.Show("Book Not Found");
            }

        }
        private void AddBook(object sender, RoutedEventArgs e)
        {
            context.Books.Add(newbook);
            context.SaveChanges();
            GetBooks();
            MessageBox.Show("Book Added Succefully!");
        }
        private void Update(object sender, RoutedEventArgs e)
        {
            context.Update(selectedBook);
            context.SaveChanges();
            GetBooks();
            MessageBox.Show("Book Updated!");
        }

    }
}