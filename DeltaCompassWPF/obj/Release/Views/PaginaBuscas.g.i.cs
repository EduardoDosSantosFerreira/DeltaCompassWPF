﻿#pragma checksum "..\..\..\Views\PaginaBuscas.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1A6BDF30799652226E90F13F5C8424B799C4E31D64104AF0709B7E164CAFA136"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using DeltaCompassWPF.Views;
using DeltaCompassWPF.Views.UserControls;
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


namespace DeltaCompassWPF.Views {
    
    
    /// <summary>
    /// PaginaBuscas
    /// </summary>
    public partial class PaginaBuscas : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Views\PaginaBuscas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscarCla;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\PaginaBuscas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCla;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\PaginaBuscas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bordaCla;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Views\PaginaBuscas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscarUsuario;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Views\PaginaBuscas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUsuario;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Views\PaginaBuscas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bordaUsuario;
        
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
            System.Uri resourceLocater = new System.Uri("/DeltaCompassWPF;component/views/paginabuscas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\PaginaBuscas.xaml"
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
            this.btnBuscarCla = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Views\PaginaBuscas.xaml"
            this.btnBuscarCla.MouseEnter += new System.Windows.Input.MouseEventHandler(this.BtnBuscarCla_MouseEnter);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\Views\PaginaBuscas.xaml"
            this.btnBuscarCla.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BtnBuscarCla_MouseLeave);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\Views\PaginaBuscas.xaml"
            this.btnBuscarCla.Click += new System.Windows.RoutedEventHandler(this.btnBuscarCla_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblCla = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.bordaCla = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.btnBuscarUsuario = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Views\PaginaBuscas.xaml"
            this.btnBuscarUsuario.MouseEnter += new System.Windows.Input.MouseEventHandler(this.BtnBuscarUsuario_MouseEnter);
            
            #line default
            #line hidden
            
            #line 53 "..\..\..\Views\PaginaBuscas.xaml"
            this.btnBuscarUsuario.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BtnBuscarUsuario_MouseLeave);
            
            #line default
            #line hidden
            
            #line 53 "..\..\..\Views\PaginaBuscas.xaml"
            this.btnBuscarUsuario.Click += new System.Windows.RoutedEventHandler(this.btnBuscarUsuario_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblUsuario = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.bordaUsuario = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

