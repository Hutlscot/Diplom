   M S B A M L   `   `   `  ���� A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom      Diplom.Authorization   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:Diplom     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  
�������$��16(�  � Title$  Авторизация��$	��400��$	��400�� � WindowStartupLocation$ CenterScreen=�   Back#��[   � 
ResizeMode$ NoResize=�.��)  #MaterialDesignThemes.Wpf.DialogHost  .��� .+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ UserTie=�$��Center=�$��Center=�$��0,0,230,112q�  $	 Key=�$��Center=�$��Center=�$��
0,0,230,50q���  �� Orientation$ Vertical=�$��Center=�$��Center=�.+��� -   $��	txt_login�� �� 	MaxLength$ 15��$
��user��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��.  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton .    UnderlineBrush
 � � �.��G� -   $��txt_password��	 G� 	MaxLength$	 15��
 G� Password$
 user1234��$ Пароль�� .    
HelperText$* $Не меньше 8 символов��
 � � ��� -   $��	btm_input��$��25q� $  MaterialDesignRaisedAccentButton#��[ $	��150�� � ToolTip$&  Нажмите для входа��+  %MaterialDesignThemes.Wpf.RippleAssist   Feedback �	#DD000000���� $��0,0,0,3q�#��[  
Войти�� -   $��txt_message��$
��Wrap=�$y�Hidden=�$��Center=�$��Bottom=�$��50q� �� TextAlignment$ Center=�Подождите: