   M S B A M L   `   `   `  ����W  SWpfApp_Kazan2021_Academy_NBA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:WpfApp_Kazan2021_Academy_NBA.Pages"WpfApp_Kazan2021_Academy_NBA.Pages  5      8    2WpfApp_Kazan2021_Academy_NBA.Pages.PlayersMainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:WpfApp_Kazan2021_Academy_NBA.Pages     5        N� Title$  Players Main��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   �� 5      $
��Auto �6   6,   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.      MainBlue#��[  6;   .+�5      �� .��6   	Season:6   �� 5      -   5        $��
CmbSeasons��5       �� DisplayMemberPath$
 Name��6)   6m   �� 5      .��6   Team:6   �� 5      -   5        $��CmbTeams��5      $ TeamName��6'   6o   �� 5      .��6   Player name:6"   �� 5      -   5        $��TxtPlayerName��5      6U   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��GridPlayers��5      $��1��6&      AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6O      
IsReadOnly .    Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6)   	   CellTemplate	 5      �� 5      .R�5      �� $	��100��6$   $	��100��60   ��6=   �� *
Player.Img+6]   5       5"      0  *System.Windows.Controls.DataGridTextColumn  5#      $	 No.��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 62   �� *ShirtNumber+6T     5$         Width$ 2* 6%   $
 Name��60   
 6>   �� *Player.Name+6`     5%      $
 Team��6%   
 63   �� *	Team.Abbr+6S     5&      $ Position��6%   
 67   �� *Player.Position.Abbr+6b     5'      $ Weight��6%   
 65   �� *Player.Weight+6Y     5(      $ Height��6%   
 65   �� *Player.Height+6Y     5)      $ 
Experience��6%   
 69   �� *Player.Experience+6a     5*      $ Country��6%   
 66   �� *Player.Country.CountryName+6g   5,      � 5-   
   $��2��6   .+�5.      �� $ 
Horizontal=�6    � 	Resources 5/       �� 
TargetType  PaginationButton �� BasedOn��%0   '��       7  �� 50      " ��6   8   6^   51      .+�52      �� -   5        $��<<��52   /   6D   �� 53      -   5        $��<��53   2   6C   �� 54      -   5        $��TxtCurrentPage��54      $��50��60   6=   �� 55      -   5        $��LblTotalPages��55      .��6-   of N63   �� 56      -	   5        $��>��56   .   6?   �� 57      -
   5        $��>>��57   .   6C   58      �� 59      -   5        $��LblSummaryInfo��59      $��Center=�6*   $��Italic$�6G   $
��Bold"�6Z   6n   5:      5;      5<      