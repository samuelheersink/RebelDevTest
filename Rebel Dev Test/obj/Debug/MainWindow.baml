   M S B A M L   `   `   `  ����I  ERebel Dev Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Rebel_Dev_TestRebel_Dev_Test  5   	   5clr-namespace:Rebel_Dev_Test.MyRebel_Dev_Test.My  5   	   !    Rebel_Dev_Test.RebelDevTest   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Rebel_Dev_Test     5   	   .Myclr-namespace:Rebel_Dev_Test.My     5   	     � Title$  Rebel Dev Test��5	   	   $	��450��6    $	��800��6-   .��5
      � .+�5   
   �� -   5         ��Name$ lvValues��5      $
��Left=�6%   $	��289��6@   $��
548,60,0,0q�6M   $	��Top=�6a   $	��215��6y    �� View 5      �� 5       �� AllowsColumnReorder .  ! �� ColumnHeaderContainerStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � y� �� Value$ 	Collapsed=�6;   5      .P�5      �� -   5        Key�� �� Width$	 100��5   W   	 �� DisplayMemberBinding	 62   �� *Key+6W   �� 5      -   5        	Value��$	 100��5   [   	 64   �� *Value+6[   5      5      �� 5   
   -   5        
 ��Name$
 btnAdd��5      $	��Add��6!   $
��Left=�6/   $��
328,60,0,0q�6J   $	��Top=�6^   $	��133��6v   �� 5   
   -   5        $
 	btnRemove��5      $��Remove Selected��6$   $
��Left=�6>   $��328,111,0,0q�6Y   $	��Top=�6n   $	��133��6�   �� 5   
   -   5        $
 btnClear��5      $��Clear��6#   $
��Left=�63   $��328,161,0,0q�6N   $	��Top=�6c   $	��133��6{   �� 5   
   -   5        $
 	btnExport��5      $��Export to XML��6$   $
��Left=�6<   $��328,211,0,0q�6W   $	��Top=�6l   $	��133��6�   �� 5   
   -   5        $
 
btnSortKey��5      $��Sort by Name��6%   $
��Left=�6<   $��328,272,0,0q�6W   $	��Top=�6l   $	��133��6�   �� 5   
   -	   5        $
 btnSortValue��5      $��Sort by Value��6'   $
��Left=�6?   $��328,329,0,0q�6Z   $	��Top=�6o   $	��133��6�   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ dgInput��5      $
��Left=�6$   $	��289��6?   $��	43,60,0,0q�6L   $	��Top=�6_   $	��215��6w      HeadersVisibility$
 None=�6�      AutoGenerateColumns .     GridLinesVisibility$ 
Horizontal=�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6�      CanUserResizeColumns .     CanUserSortColumns .     CanUserReorderColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Width$ * 6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 60   ��  �� Path$ Contents� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5"      5$      5%      