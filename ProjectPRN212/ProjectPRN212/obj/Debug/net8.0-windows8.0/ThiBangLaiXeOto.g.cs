﻿#pragma checksum "..\..\..\ThiBangLaiXeOto.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CEBB876C6EDDA5C285B6809CCEF2C7A68DE28588"
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
    /// ThiBangLaiXeOto
    /// </summary>
    public partial class ThiBangLaiXeOto : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\ThiBangLaiXeOto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimized;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ThiBangLaiXeOto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMaximized;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ThiBangLaiXeOto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\ThiBangLaiXeOto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid questionContentGrid;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\ThiBangLaiXeOto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbUserId;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\ThiBangLaiXeOto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbUserName;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\ThiBangLaiXeOto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbTimeNow;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\ThiBangLaiXeOto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock timerTextBlock;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\ThiBangLaiXeOto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl navigationPanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjectPRN212;component/thibanglaixeoto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ThiBangLaiXeOto.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnMinimized = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\ThiBangLaiXeOto.xaml"
            this.btnMinimized.Click += new System.Windows.RoutedEventHandler(this.Minimized_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMaximized = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\ThiBangLaiXeOto.xaml"
            this.btnMaximized.Click += new System.Windows.RoutedEventHandler(this.Maximized_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\ThiBangLaiXeOto.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.questionContentGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.lbUserId = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lbUserName = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lbTimeNow = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.timerTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.navigationPanel = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 10:
            
            #line 107 "..\..\..\ThiBangLaiXeOto.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

