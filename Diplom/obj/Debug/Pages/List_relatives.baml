   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom  5          Diplom.List_relatives   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Diplom     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
Foreground
  ����� N� FontSize$ 16(�5
       N� Title$- 'Список родственников��5      .��5      )  #MaterialDesignThemes.Wpf.DialogHost  .��5   
   �  � RowDefinitions 5      �� 5      $��50 �6    �� 5      $��* �6    .+�5      � .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� 
�������$��Найти:��63   $��15q�6A    $   MaterialDesignSubtitle1TextBlock#��[  6M   �� 5      -   5        $��txt_fio��5      $��10q�5       �� 	MaxLength$ 30��5      $��16(�5       �� TextWrapping$
 Wrap=�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$4 .Введите фамилию студента��5      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . .��5   K   5      (  "System.Windows.Controls.DatePicker  5      -   5        $��Date_End��5       $��10q�5   !   $&  Дата заселения с  ��5"      5#      5$      &   System.Windows.Controls.DataGrid  5%      -   5        $
��list��5&      $��1��5%      	   SelectionMode$	 Single=�5'      
   
IsReadOnly
 .    CanUserSortColumns .    CanUserAddRows .     AutoGenerateColumns .     Columns 5,      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��5/      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5.      �� *	Person.Id+   ElementStyle 50      �� 51       �� 
TargetType" ��6$   .�52   "   ��  �� Property � �� �� Value$ Center=�6F   �� 53   "    � ��$ 3q�6;   54      56        57      $ ФИО студента��59       58      �� *
Person.FIO+ 5:      �� 5;      " ��6$   .�5<   "   ��  � ��$ Center=�6F   �� 5=   "    � ��$ 3q�6;   5>      5@      4	  .System.Windows.Controls.DataGridTemplateColumn	  5A      $/ )Родственники студента��6-    	  CellTemplate 5B      �� 5C      .R�5D   "   9� $#��Раскрыть список��6+   .��5E   &      .  
 . $	 Single=�6   ��6/   �� *	Relatives+ 5F   *   0
  *System.Windows.Controls.DataGridTextColumn
  5G   .   $	 №��6A    6L   �� *Id+6e   
  5H   .   $% ФИО родственника��6A    6[   �� *
Person.FIO+6|   
  5I   .   $ Родство��6A    6R   �� *Degree+6o   
  5J   .   $ № Телефона��6A    6U   �� *Person.Phone+6x   
  5K   .   $ 
Адрес��6A    6P   �� *	Address+6n   5M   '   5N   #   5O      5Q      5S      5T      5U      5V      