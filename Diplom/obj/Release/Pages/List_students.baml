   M S B A M L   `   `   `  ���� A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom      Diplom.List_students   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     &localclr-namespace:Diplom     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Foreground
  ����� N� FontSize$ 16(� N� Title$% Список студентов��.��)  #MaterialDesignThemes.Wpf.DialogHost  .���  � RowDefinitions �� $��50 ��� $��* �.+�� .+���  �� Orientation$ 
Horizontal=�.+��� 
�������$��Найти:��$��15q� $   MaterialDesignSubtitle1TextBlock#��[  �� -   $��txt_fio��$��10q�
������� �� 	MaxLength$ 30�� �� TextWrapping$
 Wrap=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$4 .Введите фамилию студента��.  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . .��(  "System.Windows.Controls.DatePicker  -   $��Date_End��$��10q�$&  Дата заселения с  ��&   System.Windows.Controls.DataGrid  -   $
��list��$��1��	   SelectionMode$	 Single=�
   
IsReadOnly
 .    CanUserSortColumns .    CanUserAddRows .     AutoGenerateColumns .     Columns 1  +MaterialDesignThemes.Wpf.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 №��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	Person.Id+   ElementStyle ��  �� 
TargetType" ��.���  �� Property � �� �� Value$ Center=���  � ��$ 3q�  $ ФИО�� �� *
Person.FIO+ �� " ��.���  � ��$ Center=���  � ��$ 3q�  $ № Телефона�� �� *Person.Phone+ �� " ��.���  � ��$ Center=�  $ № Комнаты�� �� *Room_number+ �� " ��.���  � ��$ Right=���  � ��$ Center=���  � ��$ 0 0 7 0q�   �� *Name_rep_and_phone+   HeaderStyle �� =	  7System.Windows.Controls.Primitives.DataGridColumnHeader" 	  & "MaterialDesignDataGridColumnHeader �� BasedOn# [ .���  � �� �� .R��� $
��Wrap=�$	��100��$9��3Имя и телефон представителя�� �� " ��.���  � ��$ Right=���  � ��$ Center=���  � ��$ 0 0 7 0q�4
  .System.Windows.Controls.DataGridTemplateColumn
  $  Редактировать�� 
  CellTemplate �� .R��� $ 
Horizontal=�.+��� $��
btm_change��-    � ToolTip$8 2Нажмите для редактирования��
�������  MaterialDesignIconButton#��[ .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ModeEdit=�$��20��$��20���� $��
btm_delete��-   $, &Нажмите для удаления��  ValidationErrorBrush#��[ #��[ .��  $��5 0 0 0q�$ DeleteAlert=�$��20��$��20��