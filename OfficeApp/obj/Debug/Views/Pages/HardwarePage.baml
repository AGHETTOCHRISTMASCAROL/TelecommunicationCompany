   M S B A M L   `   `   `  ����D  @OfficeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:OfficeApp.Views.PagesOfficeApp.Views.Pages  5      (    "OfficeApp.Views.Pages.HardwarePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:OfficeApp.Views.Pages     5        N� Title$  HardwarePage��5	       N� 
Background �#171717.��5      �  � ColumnDefinitions 5   
   �� 5      $��0 �6   �� 5      $��* �6   �� 5      $��0 �6    � RowDefinitions 5   
   �� 5      $��0 �6   �� 5      $��* �6   �� 5      $��0 �6   .+�5   
   � $��1��6   $��1��6    5      �� 5      $��3* �6    �� 5      $��* �6    .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgHardware��5      $��0��6+   $��0��68   $
��auto��6H   $
��auto��6U      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
idHardware+6T     5       $ Название��6)   $
 auto 6U    6;   �� *title+6U     5!      $  Производитель��6)   $
 auto 6g    6@   �� *Manufacturer.title+6g     5"      $ Тип��6)   $
 auto 6_    66   �� *TypeOfHardware.title+6_     5#      $ Доступно��6)   $
 auto 6_    6;   �� *availableAmount+6_     5$      $ используется��6)   $
 auto 6^    6?   �� *
usedAmount+6^     5%      $ Описание��6)   $
 auto 6[    6;   �� *description+6[   4  .System.Windows.Controls.DataGridTemplateColumn  5&      $ * 6-   	   CellTemplate	 5'      �� 5(      .R�5)   "   �� 
 ��Name$
 btnEdit��6)   -   5        $��Изменить��5)   :   $
��auto��6M   $
��auto��6[   
������ $��0q�6�   6�   5*      5,      5.      � 50      $��1��6    51      �� 52      $��* �6'   �� 53      $��* �6'   .+�56      �� -   5        $
 btnAdd��56      $��0��6)   $��0��66   $��Добавить��6F   6Y   �� 57      -   5        $
 	btnDelete��57      $��0��6,   $��1��69   $��Удалить��6I   6[   59      5:      5;      5<      