#pragma checksum "..\..\..\Pages\VisitorMenuPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D33ED20A73DDF1F1FC91F9C78E729F26500B49AEC805E3B760196A1180B87E16"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp_Kazan2021_Academy_NBA.Pages;


namespace WpfApp_Kazan2021_Academy_NBA.Pages {
    
    
    /// <summary>
    /// VisitorMenuPage
    /// </summary>
    public partial class VisitorMenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\VisitorMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnTeams;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Pages\VisitorMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPlayers;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Pages\VisitorMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMatchups;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\VisitorMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPhotos;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp_Kazan2021_Academy_NBA;component/pages/visitormenupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\VisitorMenuPage.xaml"
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
            this.BtnTeams = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Pages\VisitorMenuPage.xaml"
            this.BtnTeams.Click += new System.Windows.RoutedEventHandler(this.BtnTeams_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnPlayers = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Pages\VisitorMenuPage.xaml"
            this.BtnPlayers.Click += new System.Windows.RoutedEventHandler(this.BtnPlayers_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnMatchups = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Pages\VisitorMenuPage.xaml"
            this.BtnMatchups.Click += new System.Windows.RoutedEventHandler(this.BtnMatchups_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnPhotos = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Pages\VisitorMenuPage.xaml"
            this.BtnPhotos.Click += new System.Windows.RoutedEventHandler(this.BtnPhotos_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

