﻿#pragma checksum "..\..\..\..\..\Views\Stars\UpdateStarView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9A835D38EC7E7A0812D8EF040B430A396D13463B"
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


namespace VirtualPlanetarium.Views.Stars {
    
    
    /// <summary>
    /// UpdateStarView
    /// </summary>
    public partial class UpdateStarView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\..\Views\Stars\UpdateStarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StarNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\..\Views\Stars\UpdateStarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SpectralClassTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Views\Stars\UpdateStarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MassTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Views\Stars\UpdateStarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RadiusTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\Views\Stars\UpdateStarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TemperatureTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\Views\Stars\UpdateStarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LuminosityTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Views\Stars\UpdateStarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AgeTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/VirtualPlanetarium;component/views/stars/updatestarview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Stars\UpdateStarView.xaml"
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
            this.StarNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SpectralClassTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MassTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.RadiusTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TemperatureTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.LuminosityTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.AgeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 27 "..\..\..\..\..\Views\Stars\UpdateStarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
