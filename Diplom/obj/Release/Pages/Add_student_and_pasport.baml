   M S B A M L   `   `   `  ���� A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom      Diplom.Add_person   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     &localclr-namespace:Diplom     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Foreground
  ����� N� FontSize$ 16(� N� Title$- 'Регистрация студента��.��� .+�)  #MaterialDesignThemes.Wpf.DialogHost  .���  � ColumnDefinitions �� $��* ��� $��* �.+��� $��30q�$#��Данные студента��.����  �� Orientation$ Vertical=�$��Center=�.+��� -   $��txt_surname�� �� 	MaxLength$ 25��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Фамилия��.  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . .���� -   $��txt_name��$ 25��$ Имя�� . ;  5MaterialDesignThemes.Wpf.Transitions.TransitionAssist   DisableTransitions . .���� -   $��txt_patronymic��$ 25��$ Отчество�� . .���� -   $��	txt_phone��$ 17��$ Телефон�� . .��(  "System.Windows.Controls.DatePicker  -   $��Date_of_birth��$ Дата рождения���� -   $��	txt_group��$ 5��$ Группа�� . .���� -   $��btm_load_photo��
	 � Tag$	 98��$��25q�   MaterialDesignRaisedButton#��[  $	��150��
 � ToolTip$D
 >Загрузить файл в формате .jpg или .png��+  %MaterialDesignThemes.Wpf.RippleAssist   Feedback �	#DD000000���� $��Center=�$ 
Horizontal=�.+��� 
�������$��0,0,0,3q�Загрузить фото'  !MaterialDesignThemes.Wpf.PackIcon  $��0 3 0 0q�   Kind$ AttachmentVertical=��� $��1��$��30q�$%��Паспорт студента��.���� $ Vertical=�$��Center=�.+��� -   $��
txt_series��$ 5��$ 
Серия�� . .���� -	   $��
txt_number��$ 6��$ 
Номер�� .  . .���� -
   $��txt_who_gave��$ 30��$ Кем выдан�� . .���� -   $��txt_address��$	 100�� �� TextWrapping$
 Wrap=�$! Адрес прописки�� . .��  -   $��Date_of_issue��$ Дата выдачи���� -   $��txt_division_code��$ 7��$' !Код подразделения�� . .���� -   $��btm_next��$	 98��$��25q�#��[  $	��150��$U
 OДля перехода необходимо заполнить все поля�� �	#DD000000.���� 
�������$��0,0,0,3q�
Далее