using EgzaminBook.Data;
using EgzaminBook.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EgzaminBook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AppContext appContext = new AppContext();
        private readonly List<StackPanel> Panels = new List<StackPanel>();
        public MainWindow()
        {
            InitializeComponent();
            GetFirstQuery();
            Panels.Add(OrderButtonPanel);
            Panels.Add(BookButtonPanel);
            Panels.Add(CustomerButtonPanel);
            Panels.Add(RegisteredCustomerButtonPanel);
            Panels.Add(DiscountButtonPanel);
            Panels.Add(SaleButtonPanel);
            Panels.Add(ReservedButtonPanel);
            Panels.Add(NameButtonPanel);
            Panels.Add(GanresButtonPanel);
            Panels.Add(AuthorsButtonPanel);            
        }
        public void GetFirstQuery()
        {
            var Temp = appContext.sales.ToList<Sale>();
        }
        public void SetCurrentPanel(StackPanel currentPanel)
        {
            foreach (StackPanel item in Panels)
            {
                if (item == currentPanel)
                {
                    item.Visibility = Visibility.Visible;
                }
                else
                {
                    item.Visibility = Visibility.Hidden;
                }
            }
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentPanel(OrderButtonPanel);
        }

        private void ShowOrderButton_Click(object sender, RoutedEventArgs e)
        {
            RezultGrid.ItemsSource = appContext.orders.ToList<Order>();
        }

        private void CreateOrderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditOrderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveOrderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BookButton_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentPanel(BookButtonPanel);
        }

        private void ShowBookButton_Click(object sender, RoutedEventArgs e)
        {
            RezultGrid.ItemsSource = appContext.books.ToList<Book>();
        }

        private void EditSelectedBookButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddNewBookButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveSelectedBookButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CustomerButton_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentPanel(CustomerButtonPanel);
        }

        private void ShowCustomersButton_Click(object sender, RoutedEventArgs e)
        {
            RezultGrid.ItemsSource = appContext.customers.ToList<Customer>();
        }

        private void AddCustomersButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditCustomersButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveCustomersButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RegisteredCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentPanel(RegisteredCustomerButtonPanel);
        }

        private void ShowRegisteredCustomersButton_Click(object sender, RoutedEventArgs e)
        {
            RezultGrid.ItemsSource = appContext.registerClients.ToList<RegisterClient>();
        }

        private void AddRegisteredCustomersButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditRegisteredCustomersButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveRegisteredCustomersButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DiscountsButton_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentPanel(DiscountButtonPanel);
        }

        private void ShowDiscountButton_Click(object sender, RoutedEventArgs e)
        {
            RezultGrid.ItemsSource = appContext.discounts.ToList<Discount>();
        }

        private void AddDiscountButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void EditDiscountButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveDiscountButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SalesButton_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentPanel(SaleButtonPanel);
        }

        private void AddSaleButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowSaleButton_Click(object sender, RoutedEventArgs e)
        {
            RezultGrid.ItemsSource = appContext.sales.ToList<Sale>();
        }

        private void EditSaleButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveSaleButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReservesButton_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentPanel(ReservedButtonPanel);
        }

        private void ShowReservedBookButton_Click(object sender, RoutedEventArgs e)
        {
            RezultGrid.ItemsSource = appContext.reservations.ToList<Reservation>();
        }

        private void AddReservedBookButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditReservedBookButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveReservedBookButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WritteOffSelectedBookButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddBookToSaleButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReserveBookButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchBookByNameButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchBookByPublisherButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchBookByGanreButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowNewBookButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowBestSellingBookButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NameButton_Click(object sender, RoutedEventArgs e)
        {
            RezultGrid.ItemsSource = appContext.books.ToList<Book>();
        }

        private void ShowNameButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddNameButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditNameButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveNameButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowTopNameButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GanresButton_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentPanel(GanresButtonPanel);
        }

        private void ShowGanresButton_Click(object sender, RoutedEventArgs e)
        {
            RezultGrid.ItemsSource = appContext.genres.ToList<Genre>();
        }

        private void AddGanresButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditGanresButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveGanresButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TopGanresPerDayButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TopGanresPerWeekButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TopGanresPerMonthButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TopGanresPerYearButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AuthorsButton_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentPanel(AuthorsButtonPanel);
        }

        private void ShowAuthorsButton_Click(object sender, RoutedEventArgs e)
        {
            RezultGrid.ItemsSource = appContext.authors.ToList<Authors>();
        }

        private void AddAuthorsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditAuthorsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveAuthorsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
