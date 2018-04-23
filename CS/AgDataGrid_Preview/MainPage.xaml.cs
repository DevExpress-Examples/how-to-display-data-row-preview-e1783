using System.Windows.Controls;

namespace AgDataGrid_Preview {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.DataSource = ProductList.GetData();
        }
    }
}
