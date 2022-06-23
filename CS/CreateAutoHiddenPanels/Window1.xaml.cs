using System;
using System.Windows;
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
