﻿#pragma checksum "..\..\..\..\..\Views\Forms\GererBoxForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CBF49CB6C18DC7B3EF3C2B5C78F6DA74A1F9A4BE"
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
    /// GererBoxForm
    /// </summary>
    public partial class GererBoxForm : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\..\Views\Forms\GererBoxForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBoxNom;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\Views\Forms\GererBoxForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBoxValeur;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\Views\Forms\GererBoxForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBoxAdresse;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\Views\Forms\GererBoxForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBoxSurface;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\Views\Forms\GererBoxForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAjouter;
        
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
            System.Uri resourceLocater = new System.Uri("/GestImmo;component/views/forms/gererboxform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Forms\GererBoxForm.xaml"
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
            this.TxtBoxNom = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\..\..\Views\Forms\GererBoxForm.xaml"
            this.TxtBoxNom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxNom_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxtBoxValeur = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\..\..\Views\Forms\GererBoxForm.xaml"
            this.TxtBoxValeur.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxValeur_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxtBoxAdresse = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\..\..\Views\Forms\GererBoxForm.xaml"
            this.TxtBoxAdresse.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxAdresse_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TxtBoxSurface = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\..\..\Views\Forms\GererBoxForm.xaml"
            this.TxtBoxSurface.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxSurface_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnAjouter = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\..\Views\Forms\GererBoxForm.xaml"
            this.BtnAjouter.Click += new System.Windows.RoutedEventHandler(this.BtnAjouter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

