﻿#pragma checksum "..\..\..\..\..\Konular\Ornekler\Events\MouseHoverForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AA8E62E9D838F39E7DDA431C6B1B6C2DCEB27250"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OFB.WPF.Konular.Ornekler.Events;
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


namespace OFB.WPF.Konular.Ornekler.Events {
    
    
    /// <summary>
    /// MouseHoverForm
    /// </summary>
    public partial class MouseHoverForm : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\Konular\Ornekler\Events\MouseHoverForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Copy;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\Konular\Ornekler\Events\MouseHoverForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy1;
        
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
            System.Uri resourceLocater = new System.Uri("/OFB.WPF;component/konular/ornekler/events/mousehoverform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Konular\Ornekler\Events\MouseHoverForm.xaml"
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
            this.label_Copy = ((System.Windows.Controls.Label)(target));
            
            #line 10 "..\..\..\..\..\Konular\Ornekler\Events\MouseHoverForm.xaml"
            this.label_Copy.MouseLeave += new System.Windows.Input.MouseEventHandler(this.label_Copy_MouseLeave);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\..\Konular\Ornekler\Events\MouseHoverForm.xaml"
            this.label_Copy.MouseEnter += new System.Windows.Input.MouseEventHandler(this.label_Copy_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.button_Copy1 = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\..\Konular\Ornekler\Events\MouseHoverForm.xaml"
            this.button_Copy1.Click += new System.Windows.RoutedEventHandler(this.button_Copy1_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
