﻿#pragma checksum "..\..\..\Pages\PlayersMainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "806D866A196E647FCDE4DE76F5F845C7FC6C78F503ED523869B507280E92F230"
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
    /// PlayersMainPage
    /// </summary>
    public partial class PlayersMainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\PlayersMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbSeasons;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\PlayersMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbTeams;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\PlayersMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPlayerName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\PlayersMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridPlayers;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp_Kazan2021_Academy_NBA;component/pages/playersmainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PlayersMainPage.xaml"
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
            this.CmbSeasons = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\..\Pages\PlayersMainPage.xaml"
            this.CmbSeasons.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UpdatePlayersDataGrid);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CmbTeams = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\Pages\PlayersMainPage.xaml"
            this.CmbTeams.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UpdatePlayersDataGrid);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxtPlayerName = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\Pages\PlayersMainPage.xaml"
            this.TxtPlayerName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtPlayerName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GridPlayers = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

