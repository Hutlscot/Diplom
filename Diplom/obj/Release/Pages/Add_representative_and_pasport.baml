   M S B A M L   `   `   `  ���� A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom  +    %Diplom.Add_representative_and_pasport   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     &localclr-namespace:Diplom     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Foreground
  ����� N� FontSize$ 16(� N� Title$- 'Регистрация студента��.��� .+�)  #MaterialDesignThemes.Wpf.DialogHost     DialogContent � $	��150��$	��150��.+���  $   MaterialDesignHeadline5TextBlock#��[    Back#��[ $��Center=�$��6q�$��Сохраняю��� $��30��$��30�� % !MaterialDesignCircularProgressBar#��[   SecondaryAccentBrush#���   � IsIndeterminate . .���  � ColumnDefinitions �� $��* ��� $��* �.+��� $��30q�$-��'Данные представителя��.����  �� Orientation$ Vertical=�$��Center=�.+��� -   $��txt_surname�� �� 	MaxLength$ 25��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Фамилия��.  (MaterialDesignThemes.Wpf.TextFieldAssist	   HasClearButton	 . .���� -   $��txt_name��$ 25��$ Имя��	 . ;  5MaterialDesignThemes.Wpf.Transitions.TransitionAssist
   DisableTransitions
 . .���� -   $��txt_patronymic��$ 25��$ Отчество��	 . .���� -   $��	txt_phone��$ 17��$ Телефон��	 . .���� -   $��txt_place_of_work��$ 48�� �� TextWrapping$
 Wrap=�$ Место работы��	 . .���� -   $��txt_place_of_live��$ 64��$
 Wrap=�$% Место жительства��	 . .���� -   $��txt_home_phone��$ 7��$% Домашний телефон��	 . .���� -   $��cmb_type��$ Кем является��.@��� .��
Отец�� .��
Мать�� .��Опекун�� $	��150��$��25q�$y�Hidden=��� $��1��$��30q�$/��)Паспорт представителя��.���� $ Vertical=�$��Center=�.+��� -	   $��
txt_series��$ 5��$ 
Серия��	 . .���� -
   $��
txt_number��$ 6��$ 
Номер��	 . 
 . .���� -   $��txt_who_gave��$ 30��$ Кем выдан��	 . .���� -   $��txt_address��$	 100��$
 Wrap=�$! Адрес прописки��	 . .��(  "System.Windows.Controls.DatePicker  -   $��Date_of_issue��$ Дата выдачи���� -   $��txt_division_code��$ 7��$' !Код подразделения��	 . .���� -   $��btm_next��
 � Tag$ 98��$��25q�  MaterialDesignRaisedButton#��[ $	��150�� � ToolTip$U OДля перехода необходимо заполнить все поля��+  %MaterialDesignThemes.Wpf.RippleAssist   Feedback �	#DD000000���� 
�������$��0,0,0,3q�
Далее