﻿#pragma checksum "..\..\..\..\..\UI\Capitulo7\Ejercicio1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "630276AA4BBCE7A3CD798FF2F9E344313A7AFD8F"
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
using Tarea3_Cap6y7.UI.Capitulo7;


namespace Tarea3_Cap6y7.UI.Capitulo7 {
    
    
    /// <summary>
    /// Ejercicio1
    /// </summary>
    public partial class Ejercicio1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\..\UI\Capitulo7\Ejercicio1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox califTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\UI\Capitulo7\Ejercicio1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insertarButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\UI\Capitulo7\Ejercicio1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button calcularButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\UI\Capitulo7\Ejercicio1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button limpiarButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\UI\Capitulo7\Ejercicio1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock resultadoTextBlock;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tarea3_Cap6y7;V1.0.0.0;component/ui/capitulo7/ejercicio1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Capitulo7\Ejercicio1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.califTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.insertarButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\..\UI\Capitulo7\Ejercicio1.xaml"
            this.insertarButton.Click += new System.Windows.RoutedEventHandler(this.insertarButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.calcularButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\..\UI\Capitulo7\Ejercicio1.xaml"
            this.calcularButton.Click += new System.Windows.RoutedEventHandler(this.calcularButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.limpiarButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.resultadoTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

