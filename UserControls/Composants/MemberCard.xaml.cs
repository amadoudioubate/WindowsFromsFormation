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

namespace UserControls.Composants
{
    /// <summary>
    /// Logique d'interaction pour MemberCard.xaml
    /// </summary>
    public partial class MemberCard : UserControl
    {
        public MemberCard()
        {
            InitializeComponent();
        }


        // DEPENDANCY PROPERTY (propdb + TAB + TAB) // permet de binder avec la partie XAML
        public Brush Couleur // Propriété couleur de type Brush
        {
            get { return (Brush)GetValue(CouleurProperty); }
            set { SetValue(CouleurProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Couleur.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CouleurProperty =
            DependencyProperty.Register("Couleur", typeof(Brush), typeof(MemberCard), new PropertyMetadata(Brushes.Blue));



        public String Titre
        {
            get { return (String)GetValue(TitreProperty); }
            set { SetValue(TitreProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitreProperty =
            DependencyProperty.Register("Titre", typeof(String), typeof(MemberCard), new PropertyMetadata("Titre pas defaut"));


        // ------------------------- Evènement Routé ----------------------------
        private void OnJoindreClick(object sender, RoutedEventArgs e)
        {
            // Déclenchement d'un évènement routé personnalisé
            RaiseEvent(new RoutedEventArgs(JoindreClickEvent));
        }

        // Déclaration et enregistrement d'un Routed event

        public static readonly RoutedEvent JoindreClickEvent = EventManager.RegisterRoutedEvent(
                                                                                                nameof(JoindreClickEvent),
                                                                                                RoutingStrategy.Bubble, 
                                                                                                typeof(RoutedEventHandler),
                                                                                                typeof(MemberCard));

        public event RoutedEventHandler JoindreClick
        {
            add { AddHandler(JoindreClickEvent, value); } // Ajout de l'évènement 'JoindreClickEvent' un gestionnaire d'évènements
            remove { RemoveHandler(JoindreClickEvent, value); } // Suppression....
        }
    }
}
