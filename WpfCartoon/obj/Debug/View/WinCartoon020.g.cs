﻿#pragma checksum "..\..\..\View\WinCartoon020.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9BF9ACBBE489FF59493276C9B3F01E68441ADE34E56D4CC80F08899A2E4EE1DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfCartoon.View;


namespace WpfCartoon.View {
    
    
    /// <summary>
    /// WinCartoon020
    /// </summary>
    public partial class WinCartoon020 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 153 "..\..\..\View\WinCartoon020.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewport3D myViewport3D;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\View\WinCartoon020.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Media3D.AxisAngleRotation3D myRotate;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfCartoon;component/view/wincartoon020.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\WinCartoon020.xaml"
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
            this.myViewport3D = ((System.Windows.Controls.Viewport3D)(target));
            
            #line 153 "..\..\..\View\WinCartoon020.xaml"
            this.myViewport3D.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MyViewport3D_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 153 "..\..\..\View\WinCartoon020.xaml"
            this.myViewport3D.MouseMove += new System.Windows.Input.MouseEventHandler(this.MyViewport3D_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.myRotate = ((System.Windows.Media.Media3D.AxisAngleRotation3D)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

