   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom  5      "    Diplom.Change_representative   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Diplom     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� 
Foreground
  ����� N� FontSize$ 16(�5	       N� Title$; 5Редактировать представителя��5      .��5      � .+�5   
   )  #MaterialDesignThemes.Wpf.DialogHost     DialogContent 5      � 5      $	��150��6   $	��150��6#   .+�5      ��  $   MaterialDesignHeadline5TextBlock#��[  6      Back#��[ 6Z   $��Center=�6}   $��6q�6�   $��Сохраняю��6�   � 5      $��30��6"   $��30��6-    % !MaterialDesignCircularProgressBar#��[ 69     SecondaryAccentBrush#���  6t    � IsIndeterminate . 6�   5      .��5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��30q�6   $-��'Данные представителя��6'   .��5      ��  �� Orientation$ Vertical=�6!   $��Center=�68   .+�5      �� -   5        $��txt_surname��5       �� 	MaxLength$ 25��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Фамилия��5       .  (MaterialDesignThemes.Wpf.TextFieldAssist	   HasClearButton	 . ��5      �� 
 �� Path$$
 Representative.Person.LastName�.��5!   J   5"      �� 5#      -   5        $��txt_name��5&      $ 25��5%      $ Имя��5'      	 . ;  5MaterialDesignThemes.Wpf.Transitions.TransitionAssist   DisableTransitions . ��5$      �� $ 
 Representative.Person.Name�.��5)   O   5*      �� 5+      -   5        $��txt_patronymic��5.      $ 25��5-      $ Отчество��5/      	 . ��5,      �� $&
  Representative.Person.MiddleName�.��50   J   51      �� 52      -   5        $��	txt_phone��55      $ 17��54      $ Телефон��56      	 . ��53      �� $!
 Representative.Person.Phone�.��57   K   58      �� 59      -   5        $��txt_place_of_work��5<      $ 48��5;       �� TextWrapping$
 Wrap=�5=      $ Место работы��5>      	 . ��5:      �� $ 
 Representative.PlaceOfWork�.��5?   J   5@      �� 5A      -   5        $��txt_place_of_live��5E      $ 64��5C      $
 Wrap=�5D      $% Место жительства��5F      	 . ��5B      �� $
 Representative.Residence�.��5G   J   5H      �� 5I      -   5        $��txt_home_phone��5L      $ 7��5K      $% Домашний телефон��5M      	 . ��5J      �� $
 Representative.HomePhone�.��5N   J   5O      �� 5P      -   5        $��cmb_type��5R      $ Кем является��5S       �� SelectedIndex 5Q      �� $
 Representative.TypeId�.@�5T      �� .��6+   
Отец5V      �� 5W      .��6+   
Мать5Y      �� 5Z      .��6+   Опекун5\      5]      �� 5^      $	��150��6!   $��25q�6-   $y�Hidden=�69   5_      5`      �� 5a      $��1��6   $��30q�6+   $/��)Паспорт представителя��67   .��5b      �� $ Vertical=�6!   $��Center=�68   .+�5c      �� -	   5        $��
txt_series��5f      $ 5��5e      $ 
Серия��5g      	 . ��5d      �� $*
 $Representative.Person.Pasport.Series�.��5h   J   5i      �� 5j      -
   5        $��
txt_number��5m      $ 6��5l      $ 
Номер��5n      	 .  . ��5k      �� $*
 $Representative.Person.Pasport.Number�.��5p   K   5q      �� 5r      -   5        $��txt_who_gave��5u      $ 30��5t      $ Кем выдан��5v      	 . ��5s      �� $+
 %Representative.Person.Pasport.WhoGave�.��5w   J   5x      �� 5y      -   5        $��txt_address��5|      $	 100��5{      $
 Wrap=�5}      $! Адрес прописки��5~      	 . ��5z      �� $+
 %Representative.Person.Pasport.Address�.��5   J   5�      (  "System.Windows.Controls.DatePicker  5�      -   5        $��Date_of_issue��5�      $ Дата выдачи��5�         SelectedDate 5�      �� $+
 %Representative.Person.Pasport.DateGet�5�      �� 5�      -   5        $��txt_division_code��5�      $ 7��5�      $' !Код подразделения��5�      	 . ��5�      �� $0
 *Representative.Person.Pasport.DevisionCode�.��5�   J   5�      �� 5�      -   5        $��btm_next��5�   !   
 � Tag$ 98��5�   !   $��25q�6*     MaterialDesignRaisedButton#��[ 5�      $	��150��5�       � ToolTip$U OДля перехода необходимо заполнить все поля��5�      +  %MaterialDesignThemes.Wpf.RippleAssist   Feedback �	#DD000000��5�      �� 5�   "   
�������$��0,0,0,3q�6?   Сохранить5�   #   5�      5�      5�      5�      5�      5�      5�      