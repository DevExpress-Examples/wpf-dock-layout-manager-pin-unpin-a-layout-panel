using System;
using System.Collections.Generic;
using System.Linq;
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
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Layout.Core;

namespace CreateAutoHiddenPanels {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            auotHideGroup.Items.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Items_CollectionChanged);
            
        }

        void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) {
            MessageBox.Show(String.Format("The panel is {0}d to/from the AutoHideGroup", e.Action.ToString()));
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            dockManager1.DockController.Dock(paneProperties, documentGroup1, DockType.Right);           
        }

        private void button2_Click(object sender, RoutedEventArgs e) {
            dockManager1.DockController.Dock(paneProperties, auotHideGroup, DockType.Bottom);
            //dockManager1.DockController.Hide(paneProperties); a new auto hide group will be created

        }

        private void button3_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("IsAutoHidden = "+paneProperties.IsAutoHidden.ToString());
        }

        
        
        
        
    }
}
