   M S B A M L   `   `   `  ���� A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom      Diplom.List_users   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     &localclr-namespace:Diplom     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Foreground
  ����� N� FontSize$ 16(� N� Title$- 'Список пользователей��.��)  #MaterialDesignThemes.Wpf.DialogHost  -   $��Warning��   DialogContent �    PrimaryHueDarkBrush#��[  .+��� .+���    CloseDialogCommand#��Z   MaterialDesignIconButton#��[ $��5q�$��30��$��30��$��Right=�.��'  !MaterialDesignThemes.Wpf.PackIcon    ValidationErrorBrush#��[    Kind$ Multiply=�  $ WarningCircle=�$��Center=�
��� ���$��60��$��60��$��	0 -5 0 20q�� 
�������$	��200��$��90�� � RowDefinitions �� $��4* ��� $��5* �.+��� -   $��text_message��$
��Wrap=� �� TextAlignment$ Center=�$��Center=�$��Center=� $  MaterialDesignSubtitle1TextBlock#��[ Удалить?�� $��Center=� �� Orientation$ 
Horizontal=�$��1��.+��� -   $��btm_OK��#��Z $��0 0 10 0q�#��[   MaterialDesignFlatButton#��[ .���� 
���   �ДА�� #��Z $��10 0 0 0q�#��[ .��НЕТ.���  �� $��50 ��� $��* �.+�� .+��� $ 
Horizontal=�.+��� 
�������$��Найти:��$��15q�#��[ �� -   $��txt_fio��$��10q�
�������	 �� 	MaxLength$	 30��
 �� TextWrapping$

 Wrap=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$< 6Введите фамилию пользователя��.  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . .��&   System.Windows.Controls.DataGrid  -   $
��list��$��1��   SelectionMode$ Single=�   
IsReadOnly .    CanUserSortColumns .    CanUserAddRows .     AutoGenerateColumns .     Columns 1  +MaterialDesignThemes.Wpf.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 №��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	Person.Id+   ElementStyle ��  �� 
TargetType" ��.���  �� Property � �� �� Value$ Center=���  � ��$ 3q�  $ ФИО�� �� *
Person.FIO+ �� " ��.���  � ��$ Center=���  � ��$ 3q�  $ № Телефона�� �� *Person.Phone+ �� " ��.���  � ��$ Center=�  $% Тип пользователя�� �� *TypeUser.Name+ �� " ��.���  � ��$ Center=���  � ��$ Center=�  $ 
Логин�� �� *Login+ �� " ��.���  � ��$ Center=�4	  .System.Windows.Controls.DataGridTemplateColumn	  $  Редактировать�� 	  CellTemplate �� .R��� $ 
Horizontal=�.+��� $��
btm_change��-    � ToolTip$8 2Нажмите для редактирования��
�������#��[ .��  $ ModeEdit=�$��20��$��20���� $��
btm_delete��-   $, &Нажмите для удаления��#��[ #��[ .��  $��5 0 0 0q�$ DeleteAlert=�$��20��$��20��