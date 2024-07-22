﻿#pragma checksum "..\..\..\UserChangepass.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A881DADA903B8DDAEE93CD7D63430750CCE277A6"
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
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using ProjectPRN212;
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


namespace ProjectPRN212 {
    
    
    /// <summary>
    /// UserChangepass
    /// </summary>
    public partial class UserChangepass : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\UserChangepass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimized;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\UserChangepass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMaximized;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UserChangepass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UserChangepass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbUserId;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\UserChangepass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbUserName;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\UserChangepass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pbOldPass;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\UserChangepass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pbPass;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\UserChangepass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pbConfim;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\UserChangepass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChangePass;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\UserChangepass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnback;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjectPRN212;component/userchangepass.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserChangepass.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnMinimized = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\UserChangepass.xaml"
            this.btnMinimized.Click += new System.Windows.RoutedEventHandler(this.Minimized_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMaximized = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\UserChangepass.xaml"
            this.btnMaximized.Click += new System.Windows.RoutedEventHandler(this.Maximized_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\UserChangepass.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lbUserId = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lbUserName = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.pbOldPass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.pbPass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.pbConfim = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.btnChangePass = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\UserChangepass.xaml"
            this.btnChangePass.Click += new System.Windows.RoutedEventHandler(this.btnChangePass_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnback = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\UserChangepass.xaml"
            this.btnback.Click += new System.Windows.RoutedEventHandler(this.btnback_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

