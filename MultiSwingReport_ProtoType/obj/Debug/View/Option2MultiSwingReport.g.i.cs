﻿#pragma checksum "..\..\..\View\Option2MultiSwingReport.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E53A022AE0CEB544862CDB38837635D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using MultiSwingReport_ProtoType.View;
using SoftwareArchitects.Windows.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace MultiSwingReport_ProtoType.View {
    
    
    /// <summary>
    /// Option2MultiSwingReport
    /// </summary>
    public partial class Option2MultiSwingReport : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\View\Option2MultiSwingReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton LastFiveRadioButton;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\View\Option2MultiSwingReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl AddressPelvisItemsControl;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\View\Option2MultiSwingReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl AddressTorsoItemsControl;
        
        #line default
        #line hidden
        
        
        #line 354 "..\..\..\View\Option2MultiSwingReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl TopPelvisItemsControl;
        
        #line default
        #line hidden
        
        
        #line 398 "..\..\..\View\Option2MultiSwingReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl TopTorsoItemsControl;
        
        #line default
        #line hidden
        
        
        #line 543 "..\..\..\View\Option2MultiSwingReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl ImpactPelvisItemsControl;
        
        #line default
        #line hidden
        
        
        #line 583 "..\..\..\View\Option2MultiSwingReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scrollViewer;
        
        #line default
        #line hidden
        
        
        #line 594 "..\..\..\View\Option2MultiSwingReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl ImpactTorsoItemsControl;
        
        #line default
        #line hidden
        
        
        #line 633 "..\..\..\View\Option2MultiSwingReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Border;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MultiSwingReport_ProtoType;component/view/option2multiswingreport.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Option2MultiSwingReport.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LastFiveRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 36 "..\..\..\View\Option2MultiSwingReport.xaml"
            this.LastFiveRadioButton.Checked += new System.Windows.RoutedEventHandler(this.LastFive_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 42 "..\..\..\View\Option2MultiSwingReport.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.LastTen_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 48 "..\..\..\View\Option2MultiSwingReport.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.LastFifteen_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 54 "..\..\..\View\Option2MultiSwingReport.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.All_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddressPelvisItemsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 6:
            this.AddressTorsoItemsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 7:
            this.TopPelvisItemsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 8:
            this.TopTorsoItemsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 9:
            this.ImpactPelvisItemsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 10:
            this.scrollViewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 11:
            this.ImpactTorsoItemsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 12:
            this.Border = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

