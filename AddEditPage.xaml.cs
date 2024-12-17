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

namespace Sibintek
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        
        public AddEditPage()
        {
            InitializeComponent();
            CostCB.ItemsSource = SibintekEntities.GetContext().CostType.ToList();
            ContentCB.ItemsSource = SibintekEntities.GetContext().TypeByContent.ToList();
            CoveredCB.ItemsSource = SibintekEntities.GetContext().CoveredByTheProjectType.ToList();
            BeloningCB.ItemsSource = SibintekEntities.GetContext().BelongingToSystem.ToList();
            PrivacyCB.ItemsSource = SibintekEntities.GetContext().PrivacyLevel.ToList();
            InternetCB.ItemsSource = SibintekEntities.GetContext().InternetAccess.ToList();
            EconomicCB.ItemsSource = SibintekEntities.GetContext().EconomicEffect.ToList();
            ArhictectCB.ItemsSource = SibintekEntities.GetContext().ArchitecturalDesign.ToList();
            AZICB.ItemsSource = SibintekEntities.GetContext().AZI.ToList();
            EquipmentCB.ItemsSource = SibintekEntities.GetContext().PurchaseOfEquipment.ToList();
            SoftwareCB.ItemsSource = SibintekEntities.GetContext().PurchasingSoftwareLicenses.ToList();
            UnitCB.ItemsSource = SibintekEntities.GetContext().BusinessUnitSupport.ToList();
            SumCB.ItemsSource = SibintekEntities.GetContext().Sum.ToList();
            CriticalCB.ItemsSource = SibintekEntities.GetContext().CriticalityLevel.ToList();
            DecisionCB.ItemsSource = SibintekEntities.GetContext().DecisionMakingLevel.ToList();
            IClevelCB.ItemsSource = SibintekEntities.GetContext().ICLevel.ToList();
            AdminCB.ItemsSource = SibintekEntities.GetContext().Employee.ToList();
            ManagerCB.ItemsSource = SibintekEntities.GetContext().Employee.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            SibClass.MainFrame.Navigate(new MainPage());
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
