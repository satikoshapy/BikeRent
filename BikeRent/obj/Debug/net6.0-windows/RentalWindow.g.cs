﻿#pragma checksum "..\..\..\RentalWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "370DC83E2F8588A58D65C1EE5205D37CCD0D09B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BikeRent;
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


namespace BikeRent {
    
    
    /// <summary>
    /// RentalWindow
    /// </summary>
    public partial class RentalWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\RentalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock titleTextBlock;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\RentalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox startDateTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\RentalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider daysSlider;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\RentalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock daysTextBlock;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\RentalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customerTextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\RentalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock totalTextBlock;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\RentalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock kmTextBlock;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\RentalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox kmTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\RentalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BikeRent;component/rentalwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RentalWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.titleTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.startDateTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.daysSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 4:
            this.daysTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.customerTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.totalTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.kmTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.kmTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.submitButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\RentalWindow.xaml"
            this.submitButton.Click += new System.Windows.RoutedEventHandler(this.submitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

