   M S B A M L   `   `   `  ����D  @OfficeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:OfficeApp.Views.PagesOfficeApp.Views.Pages  5      .    (OfficeApp.Views.Pages.SelectServicesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:OfficeApp.Views.Pages     5        N� Title$  SelectServicesPage��5	       N� 
Background �#171717.��5      �  � ColumnDefinitions 5   
   �� 5      $��0 �6   �� 5      $��* �6   �� 5      $��0 �6    � RowDefinitions 5   
   �� 5      $��0 �6   �� 5      $��* �6   �� 5      $��0 �6   .+�5   
   � $��1��6   $��1��6    5      �� 5      $��3* �6    �� 5      $��* �6    .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgService��5      $��0��6*   $��0��67   $
��auto��6G   $
��auto��6T      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5       �� 5!      .R�5"   "   ��  ��Name$ 	chbSelect��6+   -   5        $
��auto��5"   >   $
��auto��6L   6u   5#      5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 6S   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *	idService+6S     5'      $ Название��6)   $
	 auto 6U   
 6;   �� *title+6U     5(      $ Тип��6)   $
	 auto 6^   
 66   �� *TypeOfService.title+6^     5)      $ Цена��6)   $
	 auto 6Q   
 67   �� *price+6Q     5*      $ Описание��6)   $	 * 6[   
 6;   �� *description+6[   5,      � 5.      $��1��6    5/      �� 50      $��* �6'   �� 51      $��* �6'   .+�54      �� -   5         ��Name$ 	btnAccept��54      $��0��6,   $��0��69   $��Принять��6I   6[   56      57      58      59      