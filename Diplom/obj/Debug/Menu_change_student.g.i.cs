﻿#pragma checksum "..\..\Menu_change_student.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "214A327C9217852D133F9F70E7D4C7430E8B8881313F7C2CFBB48D59CBF71FB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Diplom;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Diplom {
    
    
    /// <summary>
    /// Menu_change_student
    /// </summary>
    public partial class Menu_change_student : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Menu_change_student.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btm_change_student;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Menu_change_student.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btm_change_representative;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Menu_change_student.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btm_change_relative;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Menu_change_student.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btm_change_contract;
        
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
            System.Uri resourceLocater = new System.Uri("/Diplom;component/menu_change_student.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Menu_change_student.xaml"
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
            this.btm_change_student = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Menu_change_student.xaml"
            this.btm_change_student.Click += new System.Windows.RoutedEventHandler(this.btm_change_student_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btm_change_representative = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Menu_change_student.xaml"
            this.btm_change_representative.Click += new System.Windows.RoutedEventHandler(this.btm_change_representative_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btm_change_relative = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\Menu_change_student.xaml"
            this.btm_change_relative.Click += new System.Windows.RoutedEventHandler(this.btm_change_relative_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btm_change_contract = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\Menu_change_student.xaml"
            this.btm_change_contract.Click += new System.Windows.RoutedEventHandler(this.btm_change_contract_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

