   M S B A M L   `   `   `  ���� A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom      Diplom.Change_relative   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     &localclr-namespace:Diplom     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Foreground
  ����� N� FontSize$ 16(� N� Title$J DРедактирование списка родственников��.��� .+�)  #MaterialDesignThemes.Wpf.DialogHost  -   $��CloseDialog��$��Center=�$��Center=�.���� $��1q�   PrimaryHueMidBrush#���   $	��450��$	��400��}�. ._��  � RowDefinitions �� $��* ��� $
��Auto �.+�&   System.Windows.Controls.DataGrid  -   $
��list��   SelectionMode$ Single=�   
IsReadOnly .    CanUserSortColumns .    CanUserAddRows .     AutoGenerateColumns .  	   Columns	 1  +MaterialDesignThemes.Wpf.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$
 ФИО��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
Person.FIO+   ElementStyle ��  �� 
TargetType" ��.���  �� Property � �� �� Value$ Center=���  � ��$ 3q�  $
 Телефона�� �� *Person.Phone+ �� " ��.���  � ��$ Center=�  $
 
Адрес�� �� *	Address+ �� " ��.���  � ��$ Right=���  � ��$ Center=���  � ��$ 0 0 7 0q�4  .System.Windows.Controls.DataGridTemplateColumn  $ 
 Редактировать��   CellTemplate �� .R��� $��0 0 10 0q� �� Orientation$ 
Horizontal=�$��Center=�.+��� $��
btm_delete��-    � ToolTip$, &Нажмите для удаления��  ValidationErrorBrush#��[   MaterialDesignIconButton#��[ .��'  !MaterialDesignThemes.Wpf.PackIcon  $��5 0 0 0q�   Kind$ DeleteAlert=�$��20��$��20��(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�$��1��  MaterialDesignShadowDepth5 J� Effect# �  .��� .+��� $��16q�)'Список родственников�� -   $��btm_next�� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ $��Right=�$0 *Нажмите для сохранения��$��0 0 15 0q�.��  $��1 0 0 0 q�$ ContentSave=�$��22��$��22���� -   $��btm_open_window_add��#��[ $��Bottom=�$2 ,Щелкните для добавления��$��Right=�$��0��$��	0 0 15 10q�.��  $
 Plus=�$��22��$��22��