﻿#pragma checksum "..\..\..\..\..\Views\Comets\CreateCometView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36DEB3C3FF8784787BC3B8D9534126AAF0BBA391"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace VirtualPlanetarium.Views.Comets {
    
    
    /// <summary>
    /// CreateCometView
    /// </summary>
    public partial class CreateCometView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\..\Views\Comets\CreateCometView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CometNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\..\Views\Comets\CreateCometView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PerihelionDistanceTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Views\Comets\CreateCometView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AphelionDistanceTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Views\Comets\CreateCometView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OrbitalPeriodTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\Views\Comets\CreateCometView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InclinationTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\Views\Comets\CreateCometView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NucleusDiameterTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Views\Comets\CreateCometView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CompositionTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VirtualPlanetarium;component/views/comets/createcometview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Comets\CreateCometView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CometNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PerihelionDistanceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.AphelionDistanceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.OrbitalPeriodTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.InclinationTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.NucleusDiameterTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CompositionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 27 "..\..\..\..\..\Views\Comets\CreateCometView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
