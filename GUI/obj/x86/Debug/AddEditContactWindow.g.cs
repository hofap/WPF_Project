﻿#pragma checksum "..\..\..\AddEditContactWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21BBF6AF695057F0E33FD00AAC645490151FB525"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI;
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


namespace GUI {
    
    
    /// <summary>
    /// AddEditContactWindow
    /// </summary>
    public partial class AddEditContactWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GUI.AddEditContactWindow winAddContact;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblWindowHeader;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblID;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtID;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFirstName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFirstName;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLastName;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLastName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PhoneNumbersGrid;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GUI.PhoneControl phoneControl;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblGroupName;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbGroupName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borderMenu;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\AddEditContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddAnotherPhone;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI;component/addeditcontactwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddEditContactWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.winAddContact = ((GUI.AddEditContactWindow)(target));
            return;
            case 2:
            this.lblWindowHeader = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblID = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lblFirstName = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.lblLastName = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.txtLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.lblPhoneNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.PhoneNumbersGrid = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 11:
            this.phoneControl = ((GUI.PhoneControl)(target));
            return;
            case 12:
            this.lblGroupName = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.cmbGroupName = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 14:
            this.borderMenu = ((System.Windows.Controls.Border)(target));
            return;
            case 15:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\AddEditContactWindow.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\AddEditContactWindow.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.btnAddAnotherPhone = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\AddEditContactWindow.xaml"
            this.btnAddAnotherPhone.Click += new System.Windows.RoutedEventHandler(this.btnAddAnotherPhone_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

