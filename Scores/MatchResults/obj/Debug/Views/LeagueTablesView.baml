   M S B A M L   `   `   `  ����  MatchResults)    #MatchResults.Views.LeagueTablesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5	         	BoolToVis��%   &	        �� 5
   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   .+�5      ��  �� DisplayMemberPath$
 Name��6`    �� SelectedIndex$ 0��6y   ��6   �� *
LeagueList+ �� SelectedItem 6:   �� *SelectedItem+6y   5      �� 5   
   $��1��6   .+�5      &   System.Windows.Controls.DataGrid  ��. $��Visible=�6`   $��Visible=�6�      CanUserAddRows .     AutoGenerateColumns .  ��6   �� *LeagueTable+   Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   �� *Name+  5#      $ Points��6)   	 69   �� *Points+  5$      $	 Win��6)   	 66   �� *Win+  5%      $
 Draw��6)   	 67   �� *Draw+  5&      $
 Lose��6)   	 67   �� *Lose+  5'      $ 
GoalScored��6)   	 6=   �� *
GoalScored+  5(      $ GoalConceded��6)   	 6?   �� *GoalConceded+5+      5-      �� 5/   
   $��2��6   .+�50      �  52      �� 53      $��* �6$   �� 54      $��* �6$   .+�57      �� $��To file��6   ��6+   �� *ToFileCommand+�� 58      $��1��6   $��Please wait...��6%   
���  ��$��18(�6O   y�6]   �� *	IsLoading+
 �� 	Converter#
 [  5:      5;      5>      5?      