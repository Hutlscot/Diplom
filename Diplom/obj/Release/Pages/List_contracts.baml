   M S B A M L   `   `   `  ���� A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom      Diplom.List_contracts   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     &localclr-namespace:Diplom     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Foreground
  ����� N� FontSize$ 16(� N� Title$% Список договоров��.��)  #MaterialDesignThemes.Wpf.DialogHost  -   $��Warning��   DialogContent �    PrimaryHueDarkBrush#��[  .+��� .+���    CloseDialogCommand#��Z   MaterialDesignIconButton#��[ $��5q�$��30��$��30��$��Right=�.��'  !MaterialDesignThemes.Wpf.PackIcon    ValidationErrorBrush#��[    Kind$ Multiply=�  $ WarningCircle=�$��Center=�
��� ���$��60��$��60��$��	0 -5 0 20q�� 
�������$	��200��$��90�� � RowDefinitions �� $��4* ��� $��5* �.+��� -   $��text_message��$
��Wrap=� �� TextAlignment$ Center=�$��Center=�$��Center=� $  MaterialDesignSubtitle1TextBlock#��[ Удалить?�� $��Center=� �� Orientation$ 
Horizontal=�$��1��.+��� -   $��btm_OK��#��Z $��0 0 10 0q�#��[   MaterialDesignFlatButton#��[ .���� 
���   �ДА�� #��Z $��10 0 0 0q�#��[ .��НЕТ.���  �� $��50 ��� $��* �.+�� .+��� $ 
Horizontal=�.+��� 
�������$��Найти:��$��15q�#��[ �� -   $��txt_fio��$��10q�
�������	 �� 	MaxLength$	 30��
 �� TextWrapping$

 Wrap=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$4 .Введите фамилию студента��.  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . .��(  "System.Windows.Controls.DatePicker  -   $��Date_End��$��10q�$&  Дата заселения с  ��&   System.Windows.Controls.DataGrid  -   $
��list��$��1��   SelectionMode$ Single=�   
IsReadOnly .    CanUserSortColumns .    CanUserAddRows .     AutoGenerateColumns .     Columns 1  +MaterialDesignThemes.Wpf.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 №��1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding �� *Id+ 	  ElementStyle ��  �� 
TargetType" ��.���  �� Property � �� �� Value$ Center=���  � ��$ 3q�  $ ФИО�� �� *Student.Person.FIO+ �� " ��.���  � ��$ Center=���  � ��$ 3q�  $ № Комнаты�� �� *Room.Number+ �� " ��.���  � ��$ Right=���  � ��$ Center=���  � ��$ 0 0 7 0q�  $! Дата заселения�� �� *	DateStart+ �� StringFormat$ {0:dd.MM.yy}�� �� " ��.���  � ��$ Center=���  � ��$ 20 0 0 0q�  $! Дата выселения�� �� *	DateEnd+$ {0:dd.MM.yy}�� �� " ��.���  � ��$ Center=���  � ��$ 20 0 0 0q�4
  .System.Windows.Controls.DataGridTemplateColumn
  $) #Доступные действия�� 
  CellTemplate �� .R��� $��9 0 0 0q�.+��� $ 
Horizontal=�.+��� $��btm_contract_1��-    � ToolTip$2 ,Сформировать договор №1��
�������#��[ .��  $ FileDocument=�$��20��$��20���� $��btm_contract_2��-   $2 ,Сформировать договор №2��
������#��[ .��  $��5 0 0 0q�$ FileDocument=�$��20��$��20���� $ 
Horizontal=�.+��� $��btm_form��-	   $< 6Сформировать анкету студента��
�������#��[ .��  $ FileAccount=�$��20��$��20���� $��
btm_delete��-
   $, &Нажмите для удаления��#��[ #��[ .��  $��5 0 0 0q�$ DeleteAlert=�$��20��$��20��