   M S B A M L   `   `   `  ���� A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom  "    Diplom.Change_representative   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     &localclr-namespace:Diplom     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Foreground
  ����� N� FontSize$ 16(� N� Title$; 5Редактировать представителя��.��� .+�)  #MaterialDesignThemes.Wpf.DialogHost     DialogContent � $	��150��$	��150��.+���  $   MaterialDesignHeadline5TextBlock#��[    Back#��[ $��Center=�$��6q�$��Сохраняю��� $��30��$��30�� % !MaterialDesignCircularProgressBar#��[   SecondaryAccentBrush#���   � IsIndeterminate . .���  � ColumnDefinitions �� $��* ��� $��* �.+��� $��30q�$-��'Данные представителя��.����  �� Orientation$ Vertical=�$��Center=�.+��� -   $��txt_surname�� �� 	MaxLength$ 25��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Фамилия��.  (MaterialDesignThemes.Wpf.TextFieldAssist	   HasClearButton	 . ���� 
 �� Path$$
 Representative.Person.LastName�.���� -   $��txt_name��$ 25��$ Имя��	 . ;  5MaterialDesignThemes.Wpf.Transitions.TransitionAssist   DisableTransitions . ���� $ 
 Representative.Person.Name�.���� -   $��txt_patronymic��$ 25��$ Отчество��	 . ���� $&
  Representative.Person.MiddleName�.���� -   $��	txt_phone��$ 17��$ Телефон��	 . ���� $!
 Representative.Person.Phone�.���� -   $��txt_place_of_work��$ 48�� �� TextWrapping$
 Wrap=�$ Место работы��	 . ���� $ 
 Representative.PlaceOfWork�.���� -   $��txt_place_of_live��$ 64��$
 Wrap=�$% Место жительства��	 . ���� $
 Representative.Residence�.���� -   $��txt_home_phone��$ 7��$% Домашний телефон��	 . ���� $
 Representative.HomePhone�.���� -   $��cmb_type��$ Кем является�� �� SelectedIndex �� $
 Representative.TypeId�.@��� .��
Отец�� .��
Мать�� .��Опекун�� $	��150��$��25q�$y�Hidden=��� $��1��$��30q�$/��)Паспорт представителя��.���� $ Vertical=�$��Center=�.+��� -	   $��
txt_series��$ 5��$ 
Серия��	 . ���� $*
 $Representative.Person.Pasport.Series�.���� -
   $��
txt_number��$ 6��$ 
Номер��	 .  . ���� $*
 $Representative.Person.Pasport.Number�.���� -   $��txt_who_gave��$ 30��$ Кем выдан��	 . ���� $+
 %Representative.Person.Pasport.WhoGave�.���� -   $��txt_address��$	 100��$
 Wrap=�$! Адрес прописки��	 . ���� $+
 %Representative.Person.Pasport.Address�.��(  "System.Windows.Controls.DatePicker  -   $��Date_of_issue��$ Дата выдачи��   SelectedDate �� $+
 %Representative.Person.Pasport.DateGet��� -   $��txt_division_code��$ 7��$' !Код подразделения��	 . ���� $0
 *Representative.Person.Pasport.DevisionCode�.���� -   $��btm_next��
 � Tag$ 98��$��25q�  MaterialDesignRaisedButton#��[ $	��150�� � ToolTip$U OДля перехода необходимо заполнить все поля��+  %MaterialDesignThemes.Wpf.RippleAssist   Feedback �	#DD000000���� 
�������$��0,0,0,3q�Сохранить