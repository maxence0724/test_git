#pragma checksum "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03B8740AA330CFA37BCCC88665236FC2ED51BABC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GestImmo.Views.Forms;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace GestImmo.Views.Forms {
    
    
    /// <summary>
    /// GererMaison
    /// </summary>
    public partial class GererMaison : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtMaisonNom;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtMaisonValeur;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtMaisonAdresse;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtMaisonSurface;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAjouter;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtMaisonNbPieces;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtMaisonNbChambres;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtMaisonNbCaves;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtMaisonNbParkings;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestImmo;component/views/forms/gerermaisonform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TxtMaisonNom = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
            this.TxtMaisonNom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtMaisonNom_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxtMaisonValeur = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
            this.TxtMaisonValeur.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextMaisonValeur_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxtMaisonAdresse = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
            this.TxtMaisonAdresse.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextMaisonAdresse_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TxtMaisonSurface = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
            this.TxtMaisonSurface.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextMaisonSurface_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnAjouter = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
            this.BtnAjouter.Click += new System.Windows.RoutedEventHandler(this.BtnAjouter_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TxtMaisonNbPieces = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
            this.TxtMaisonNbPieces.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextMaisonNbPieces_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TxtMaisonNbChambres = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
            this.TxtMaisonNbChambres.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextMaisonNbChambres_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TxtMaisonNbCaves = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
            this.TxtMaisonNbCaves.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextMaisonNbCaves_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TxtMaisonNbParkings = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\..\..\Views\Forms\GererMaisonForm.xaml"
            this.TxtMaisonNbParkings.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextMaisonNbParkings_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

